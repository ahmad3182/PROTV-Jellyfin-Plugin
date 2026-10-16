/* PROTV home page tab.
 *
 * Served by PROTV as /PROTV/tab.js and loaded by the tab entry PROTV writes into the Custom
 * Tabs plugin configuration. It renders every channel the PROTV tuner serves (same numbering,
 * names and logos Jellyfin shows in Live TV) by reading /PROTV/Channels.
 *
 * Tapping a channel plays it: the tab asks /PROTV/Channels for the Jellyfin Live TV channel item
 * behind every PROTV channel and tells this app's own session to play it
 * (POST /Sessions/{sessionId}/Playing?playCommand=PlayNow). Playback then uses the normal Jellyfin
 * Live TV pipeline (tuner, guide, HLS/transcode), with no PROTV specific player involved.
 */
(function () {
    'use strict';

    if (window.ProTvTab) {
        window.ProTvTab.render();
        return;
    }

    var ROOT_ID = 'protvTabRoot';
    var GRID_ID = 'protvTabGrid';
    var MESSAGE_ID = 'protvTabMessage';
    var STYLE_ID = 'protvTabStyles';
    var PLAYING_CLEAR_MS = 6000;
    var state = {
        requested: false,
        loading: false,
        error: null,
        title: 'PROTV',
        total: 0,
        channels: [],
        filter: '',
        playing: null,
        message: null,
        messageKind: 'info',
        sessionId: null
    };
    var waits = 0;
    var messageTimer = null;

    var css = [
        '.protvTabRoot{box-sizing:border-box;width:100%;padding:.5em 1.5em 3em;}',
        '.protvTabHeader{display:flex;flex-wrap:wrap;align-items:center;gap:.75em;margin:0 0 .5em;}',
        '.protvTabTitle{font-size:1.4em;font-weight:600;margin:0;}',
        '.protvTabCount{font-size:.85em;opacity:.7;margin-right:auto;}',
        '.protvTabSearch,.protvTabButton{font:inherit;color:inherit;background:rgba(128,128,128,.15);',
        'border:1px solid rgba(128,128,128,.45);border-radius:4px;padding:.45em .8em;}',
        '.protvTabSearch{min-width:11em;}',
        '.protvTabButton{cursor:pointer;}',
        '.protvTabButton:hover{background:rgba(128,128,128,.32);}',
        '.protvTabButton[disabled]{opacity:.5;cursor:default;}',
        '.protvTabHint{font-size:.85em;opacity:.65;margin:0 0 1em;}',
        '.protvTabGrid{display:grid;gap:.75em;grid-template-columns:repeat(auto-fill,minmax(10.5em,1fr));}',
        '.protvTabCard{position:relative;display:flex;flex-direction:column;align-items:center;gap:.4em;',
        'padding:.85em .5em;border-radius:8px;background:rgba(128,128,128,.12);text-align:center;',
        'cursor:pointer;border:1px solid transparent;transition:background .15s,border-color .15s;}',
        '.protvTabCard:hover,.protvTabCard:focus{background:rgba(128,128,128,.24);border-color:rgba(128,128,128,.55);',
        'outline:none;}',
        '.protvTabCard[data-live="0"]{cursor:default;opacity:.6;}',
        '.protvTabCard[data-playing="1"]{border-color:#00a4dc;background:rgba(0,164,220,.22);}',
        '.protvTabLogo{display:flex;align-items:center;justify-content:center;width:100%;height:4.5em;}',
        '.protvTabLogo img{max-width:100%;max-height:100%;object-fit:contain;}',
        '.protvTabInitials{font-size:1.5em;font-weight:600;opacity:.75;letter-spacing:.05em;}',
        '.protvTabName{font-size:.95em;font-weight:500;word-break:break-word;}',
        '.protvTabNumber{font-size:.75em;opacity:.6;}',
        '.protvTabPlay{position:absolute;top:.35em;right:.35em;font-size:.9em;line-height:1;padding:.25em .4em;',
        'border:0;border-radius:4px;background:rgba(0,0,0,.35);color:#fff;cursor:pointer;opacity:0;}',
        '.protvTabCard:hover .protvTabPlay,.protvTabCard:focus .protvTabPlay{opacity:.85;}',
        '.protvTabPlay:hover{opacity:1;}',
        '.protvTabBadge{position:absolute;top:.35em;left:.35em;font-size:.9em;line-height:1;}',
        '.protvTabMessage{padding:.5em 0;opacity:.85;}',
        '.protvTabError{padding:1em;border-radius:6px;background:rgba(244,67,54,.18);}',
        '.protvTabNotice{padding:.6em 1em;border-radius:6px;background:rgba(0,164,220,.16);}',
        '.protvTabBad{padding:.6em 1em;border-radius:6px;background:rgba(255,152,0,.18);}'
    ].join('');

    function ensureStyles() {
        if (document.getElementById(STYLE_ID)) {
            return;
        }

        var style = document.createElement('style');
        style.id = STYLE_ID;
        style.type = 'text/css';
        style.appendChild(document.createTextNode(css));
        document.head.appendChild(style);
    }

    function url(path, query) {
        var full = window.ApiClient && ApiClient.getUrl ? ApiClient.getUrl(path) : '/' + path;
        return query ? full + query : full;
    }

    function initials(name) {
        var parts = String(name || '').trim().split(/\s+/).filter(Boolean);
        var text = parts.length > 1
            ? parts[0].charAt(0) + parts[1].charAt(0)
            : String(name || '?').substring(0, 2);
        return text.toUpperCase();
    }

    // Loads the channel list. refresh=true asks the PROTV service again; otherwise the channel
    // list saved by the tuner / guide refresh is used, so the tab opens instantly.
    function load(refresh) {
        state.requested = true;
        state.loading = true;
        state.error = null;
        renderGrid();

        ApiClient.getJSON(url('PROTV/Channels', refresh ? '?refresh=true' : '')).then(function (data) {
            state.loading = false;
            state.title = (data && data.title) || 'PROTV';
            state.channels = (data && data.channels) || [];
            state.total = (data && data.total) || state.channels.length;
            renderHeader();
            renderGrid();
        }, function (error) {
            state.loading = false;
            state.error = describe(error);
            renderHeader();
            renderGrid();
        });
    }

    function describe(error) {
        var status = error && (error.status || error.statusCode);
        if (status === 401 || status === 403) {
            return 'Sign in to Jellyfin again to see the PROTV channels.';
        }

        if (status) {
            return 'The PROTV channel list could not be loaded (HTTP ' + status + ').';
        }

        return 'The PROTV channel list could not be loaded. Is the PROTV plugin still running?';
    }

    function visibleChannels() {
        var filter = state.filter.trim().toLowerCase();
        if (!filter) {
            return state.channels;
        }

        return state.channels.filter(function (channel) {
            return String(channel.name || '').toLowerCase().indexOf(filter) >= 0
                || String(channel.number || '') === filter;
        });
    }

    // ---- playback ---------------------------------------------------------
    // The tab does not start playback itself: it tells this app's session to play the Jellyfin
    // Live TV channel item, exactly like the Jellyfin remote control / "play on" feature.
    function currentSessionId() {
        if (state.sessionId) {
            return Promise.resolve(state.sessionId);
        }

        var deviceId = ApiClient.deviceId ? ApiClient.deviceId() : null;
        var query = {};
        if (deviceId) {
            query.deviceId = deviceId;
        }

        return ApiClient.getSessions(query).then(function (sessions) {
            var list = sessions || [];
            var userId = ApiClient.getCurrentUserId ? ApiClient.getCurrentUserId() : null;
            var own = null;
            var index;
            for (index = 0; index < list.length; index++) {
                if (deviceId && list[index].DeviceId === deviceId) {
                    own = list[index];
                    break;
                }
            }

            if (!own && userId) {
                for (index = 0; index < list.length; index++) {
                    if (list[index].UserId === userId) {
                        own = list[index];
                        break;
                    }
                }
            }

            if (!own && list.length === 1) {
                own = list[0];
            }

            if (!own || !own.Id) {
                throw new Error('no-session');
            }

            state.sessionId = own.Id;
            return state.sessionId;
        });
    }

    function startPlayback(channel) {
        return currentSessionId().then(function (sessionId) {
            var playUrl = ApiClient.getUrl('Sessions/' + sessionId + '/Playing')
                + '?playCommand=PlayNow&itemIds=' + encodeURIComponent(channel.itemId);
            return ApiClient.ajax({ type: 'POST', url: playUrl, dataType: 'json' });
        });
    }

    function playChannel(channel) {
        if (state.playing === channel.number) {
            return;
        }

        if (!channel.itemId) {
            setMessage('This channel has no Jellyfin Live TV entry yet.', 'bad');
            return;
        }

        if (channel.inLiveTv === false) {
            setMessage('"' + channel.name + '" is not in Live TV yet. Press Refresh (or run the '
                + 'Jellyfin "Refresh Guide" task) and try again.', 'bad');
            return;
        }

        state.playing = channel.number;
        renderGrid();
        setMessage('Starting ' + channel.name + '...', 'notice');

        startPlayback(channel).then(function () {
            window.setTimeout(function () {
                if (state.playing === channel.number) {
                    state.playing = null;
                    renderGrid();
                }
            }, PLAYING_CLEAR_MS);
        }, function (error) {
            state.playing = null;
            renderGrid();
            setMessage(playError(channel, error), 'bad');
        });
    }

    function playError(channel, error) {
        if (error && error.message === 'no-session') {
            return 'Jellyfin could not find this app session. Reload the page and try again.';
        }

        var status = error && (error.status || error.statusCode);
        if (status === 401 || status === 403) {
            return 'Sign in to Jellyfin again to play channels.';
        }

        if (status) {
            return '"' + channel.name + '" could not be started (HTTP ' + status
                + '). If Live TV has no channels yet, run the Jellyfin "Refresh Guide" task.';
        }

        return '"' + channel.name + '" could not be started. The PROTV service or the channel '
            + 'stream may be offline.';
    }

    // Opens the channel the way the rest of Jellyfin shows it (details page with its Play button).
    function openChannel(channel) {
        if (!channel.itemId) {
            setMessage('This channel has no Jellyfin Live TV entry yet.', 'bad');
            return;
        }

        window.location.hash = '#/details?id=' + encodeURIComponent(channel.itemId);
    }

    // ---- rendering --------------------------------------------------------
    function setMessage(text, kind) {
        state.message = text;
        state.messageKind = kind || 'info';
        renderMessage();
        if (messageTimer) {
            window.clearTimeout(messageTimer);
        }

        if (text && (kind === 'notice' || kind === 'bad')) {
            messageTimer = window.setTimeout(function () {
                if (state.message === text) {
                    state.message = null;
                    renderMessage();
                }
            }, 8000);
        }
    }

    function renderMessage() {
        var message = document.getElementById(MESSAGE_ID);
        if (!message) {
            return;
        }

        message.className = 'protvTabMessage';
        message.textContent = '';
        if (!state.message) {
            return;
        }

        message.className = 'protvTabMessage ' + (state.messageKind === 'bad' ? 'protvTabBad' : 'protvTabNotice');
        message.textContent = state.message;
    }

    function card(channel) {
        var item = document.createElement('div');
        item.className = 'protvTabCard';
        item.setAttribute('role', 'button');
        item.setAttribute('tabindex', '0');
        item.setAttribute('data-number', channel.number || '');
        item.setAttribute('data-live', channel.inLiveTv === false ? '0' : '1');
        item.setAttribute('data-playing', state.playing === channel.number ? '1' : '0');
        item.setAttribute('title', channel.inLiveTv === false
            ? channel.name + ' is not in Live TV yet'
            : 'Play ' + channel.name);

        var logo = document.createElement('div');
        logo.className = 'protvTabLogo';
        if (channel.logoUrl) {
            var image = document.createElement('img');
            image.loading = 'lazy';
            image.alt = channel.name || '';
            image.src = channel.logoUrl;
            image.addEventListener('error', function () {
                if (image.parentNode) {
                    logo.removeChild(image);
                    logo.appendChild(initialsNode(channel.name));
                }
            });
            logo.appendChild(image);
        } else {
            logo.appendChild(initialsNode(channel.name));
        }

        var name = document.createElement('div');
        name.className = 'protvTabName';
        name.textContent = channel.name || '';

        var number = document.createElement('div');
        number.className = 'protvTabNumber';
        number.textContent = 'Channel ' + (channel.number || '');

        item.appendChild(logo);
        item.appendChild(name);
        item.appendChild(number);

        if (state.playing === channel.number) {
            var badge = document.createElement('span');
            badge.className = 'protvTabBadge';
            badge.textContent = '\u25B6'; // play glyph while the channel is starting
            item.appendChild(badge);
        }

        // Second action: the channel page, for anyone who wants the guide entry or a different
        // player instead of playing straight away.
        if (channel.itemId) {
            var open = document.createElement('button');
            open.className = 'protvTabPlay';
            open.type = 'button';
            open.textContent = '\u2139'; // info glyph
            open.setAttribute('title', 'Open ' + channel.name + ' in Live TV');
            open.addEventListener('click', function (event) {
                event.stopPropagation();
                event.preventDefault();
                openChannel(channel);
            });
            item.appendChild(open);
        }

        item.addEventListener('click', function () {
            playChannel(channel);
        });
        item.addEventListener('keydown', function (event) {
            if (event.key === 'Enter' || event.key === ' ' || event.key === 'Spacebar') {
                event.preventDefault();
                playChannel(channel);
            }
        });

        return item;
    }

    function initialsNode(name) {
        var node = document.createElement('span');
        node.className = 'protvTabInitials';
        node.textContent = initials(name);
        return node;
    }

    // The tab shell: header + grid + message. Built once; only the pieces change afterwards.
    function renderShell(host) {
        host.textContent = '';

        var header = document.createElement('div');
        header.className = 'protvTabHeader';

        var title = document.createElement('h2');
        title.className = 'protvTabTitle';

        var count = document.createElement('span');
        count.className = 'protvTabCount';

        var search = document.createElement('input');
        search.className = 'protvTabSearch';
        search.type = 'search';
        search.placeholder = 'Filter channels';
        search.value = state.filter;
        search.addEventListener('input', function () {
            state.filter = search.value;
            renderGrid();
            renderHeader();
        });

        var button = document.createElement('button');
        button.className = 'protvTabButton';
        button.type = 'button';
        button.textContent = 'Refresh';
        button.addEventListener('click', function () {
            load(true);
        });

        header.appendChild(title);
        header.appendChild(count);
        header.appendChild(search);
        header.appendChild(button);

        var hint = document.createElement('p');
        hint.className = 'protvTabHint';
        hint.textContent = 'Pick a channel to play it here (the same Live TV channel the rest of '
            + 'Jellyfin plays). Use \u2139 on a channel to open its Jellyfin page instead.';

        var grid = document.createElement('div');
        grid.id = GRID_ID;
        grid.className = 'protvTabGrid';

        var message = document.createElement('div');
        message.id = MESSAGE_ID;
        message.className = 'protvTabMessage';

        host.appendChild(header);
        host.appendChild(hint);
        host.appendChild(message);
        host.appendChild(grid);
    }

    function renderHeader() {
        var host = document.getElementById(ROOT_ID);
        if (!host) {
            return;
        }

        var title = host.querySelector('.protvTabTitle');
        var count = host.querySelector('.protvTabCount');
        var button = host.querySelector('.protvTabButton');
        var search = host.querySelector('.protvTabSearch');
        if (title) {
            title.textContent = state.title;
        }

        if (button) {
            button.disabled = state.loading;
            button.textContent = state.loading ? 'Refreshing...' : 'Refresh';
        }

        if (search) {
            search.style.display = state.channels.length ? '' : 'none';
        }

        if (count) {
            if (state.error || !state.channels.length) {
                count.textContent = '';
            } else {
                var visible = visibleChannels().length;
                count.textContent = visible === state.total
                    ? state.total + (state.total === 1 ? ' channel' : ' channels')
                    : visible + ' of ' + state.total + ' channels';
            }
        }
    }

    function renderGrid() {
        var grid = document.getElementById(GRID_ID);
        var message = document.getElementById(MESSAGE_ID);
        if (!grid || !message) {
            return;
        }

        grid.textContent = '';

        if (state.error) {
            setMessage(state.error, 'bad');
            return;
        }

        if (state.loading && !state.channels.length) {
            message.className = 'protvTabMessage';
            message.textContent = 'Loading channels...';
            return;
        }

        if (!state.channels.length) {
            message.className = 'protvTabMessage';
            message.textContent = 'No channels yet. Add the PROTV tuner to Live TV (or press Refresh) '
                + 'and the channels PROTV returns will be listed here.';
            return;
        }

        var visible = visibleChannels();
        if (!visible.length) {
            message.className = 'protvTabMessage';
            message.textContent = 'No channel matches "' + state.filter + '".';
            return;
        }

        var missing = 0;
        var fragment = document.createDocumentFragment();
        for (var index = 0; index < visible.length; index++) {
            if (visible[index].inLiveTv === false) {
                missing++;
            }

            fragment.appendChild(card(visible[index]));
        }

        grid.appendChild(fragment);

        if (missing) {
            setMessage(missing + (missing === 1 ? ' channel is' : ' channels are')
                + ' not in Jellyfin Live TV yet. Run the "Refresh Guide" task in the Jellyfin '
                + 'dashboard, then press Refresh.', 'bad');
        } else {
            renderMessage();
        }
    }

    function render() {
        var host = document.getElementById(ROOT_ID);
        if (!host) {
            // Custom Tabs may execute this before the tab container is in the DOM.
            if (waits < 50) {
                waits++;
                window.setTimeout(render, 100);
            }

            return;
        }

        ensureStyles();
        if (!host.querySelector('.' + 'protvTabHeader')) {
            renderShell(host);
        }

        renderHeader();
        renderGrid();
        if (!state.requested) {
            load(false);
        }
    }

    window.ProTvTab = {
        render: render,
        refresh: function () {
            load(true);
        }
    };

    render();
})();
