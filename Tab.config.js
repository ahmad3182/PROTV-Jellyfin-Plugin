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
    var MORE_ID = 'protvTabMore';
    var STYLE_ID = 'protvTabStyles';
    var PLAYING_CLEAR_MS = 6000;
    // How often the tab checks whether the client opened its player after a play command, how
    // long it waits, and how many times it may ask (see watchPlayback).
    var PLAY_WATCH_MS = 500;
    var PLAY_WATCH_TICKS = 10;
    var PLAY_ATTEMPTS = 3;
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
        sessionId: null,
        // Which half of the tab is open: channels | movies | series.
        view: 'channels',
        vodLoading: false,
        vodError: null,
        vodFilter: '',
        vodPage: 1,
        vodPageCount: 0,
        vodTotal: 0,
        vodItems: [],
        vodCategories: [],
        vodCategoryId: null,
        vodSeries: null
    };
    var waits = 0;
    var messageTimer = null;
    var vodSearchTimer = null;
    var VOD_PAGE_SIZE = 60;

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
        '.protvTabBad{padding:.6em 1em;border-radius:6px;background:rgba(255,152,0,.18);}',
        '.protvTabViews{display:flex;gap:.4em;}',
        '.protvTabView{font:inherit;color:inherit;background:rgba(128,128,128,.15);border:1px solid rgba(128,128,128,.45);',
        'border-radius:999px;padding:.35em .9em;cursor:pointer;opacity:.85;}',
        '.protvTabView:hover{background:rgba(128,128,128,.3);}',
        '.protvTabView[data-active="1"]{background:#00a4dc;border-color:#00a4dc;color:#fff;opacity:1;}',
        '.protvTabPosterGrid{display:grid;gap:1em;grid-template-columns:repeat(auto-fill,minmax(9em,1fr));}',
        '.protvTabPoster{display:flex;flex-direction:column;gap:.35em;cursor:pointer;outline:none;}',
        '.protvTabPosterArt{position:relative;display:flex;align-items:center;justify-content:center;',
        'border-radius:8px;overflow:hidden;background:rgba(128,128,128,.18);aspect-ratio:2/3;}',
        '.protvTabPosterArt img{width:100%;height:100%;object-fit:cover;display:block;}',
        '.protvTabPosterLabel{font-size:.9em;line-height:1.25;word-break:break-word;}',
        '.protvTabPosterMeta{font-size:.75em;opacity:.65;}',
        '.protvTabPosterPlay{position:absolute;inset:0;display:flex;align-items:center;justify-content:center;',
        'background:rgba(0,0,0,.4);color:#fff;font-size:2em;opacity:0;transition:opacity .15s;}',
        '.protvTabPoster:hover .protvTabPosterPlay,.protvTabPoster:focus .protvTabPosterPlay{opacity:1;}',
        '.protvTabPoster[data-missing="1"] .protvTabPosterArt{opacity:.55;}',
        '.protvTabPoster[data-playing="1"] .protvTabPosterArt{box-shadow:0 0 0 2px #00a4dc;}',
        '.protvTabSeasons{display:block;}',
        '.protvTabSeasonTitle{font-weight:600;margin:1em 0 .4em;}',
        '.protvTabEpisodes{display:flex;flex-direction:column;gap:.35em;}',
        '.protvTabEpisode{display:flex;gap:.6em;align-items:center;padding:.45em .6em;border-radius:6px;',
        'background:rgba(128,128,128,.12);cursor:pointer;outline:none;}',
        '.protvTabEpisode:hover,.protvTabEpisode:focus{background:rgba(128,128,128,.26);}',
        '.protvTabEpisode[data-playing="1"]{background:rgba(0,164,220,.22);}',
        '.protvTabEpisodeNumber{font-weight:600;opacity:.7;min-width:2.4em;}',
        '.protvTabMore{margin-top:1em;}'
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

    // ---- VOD: films and series --------------------------------------------
    // The catalogue is paged straight out of PROTV (nothing large is kept in the browser), and
    // every title the plugin has already synced carries the id of the Jellyfin item it became, so
    // tapping a film plays it like any other Jellyfin item.
    function pad2(value) {
        var number = parseInt(value, 10) || 0;
        return (number < 10 ? '0' : '') + number;
    }

    function vodSection() {
        return state.view === 'series' ? 'Series' : 'Movies';
    }

    function loadVod(page, append) {
        state.vodLoading = true;
        state.vodError = null;
        state.vodPage = page || 1;
        if (!append) {
            state.vodItems = [];
            state.vodSeries = null;
            renderHeader();
            renderGrid();
        }

        var query = '?page=' + state.vodPage + '&pageSize=' + VOD_PAGE_SIZE;
        if (state.vodFilter) {
            query += '&search=' + encodeURIComponent(state.vodFilter);
        }

        if (state.vodCategoryId) {
            query += '&categoryId=' + encodeURIComponent(state.vodCategoryId);
        }

        ApiClient.getJSON(url('PROTV/Vod/' + vodSection(), query)).then(function (data) {
            var items = (data && data.items) || [];
            state.vodLoading = false;
            state.vodItems = append ? state.vodItems.concat(items) : items;
            state.vodTotal = (data && data.total) || 0;
            state.vodPageCount = (data && data.pageCount) || 0;
            state.vodCategories = (data && data.categories) || [];
            renderHeader();
            renderGrid();
        }, function (error) {
            state.vodLoading = false;
            state.vodError = describeVod(error);
            renderHeader();
            renderGrid();
        });
    }

    function loadSeriesDetail(series) {
        state.vodLoading = true;
        state.vodError = null;
        renderGrid();
        ApiClient.getJSON(url('PROTV/Vod/SeriesDetail', '?seriesId=' + encodeURIComponent(series.id)))
            .then(function (data) {
                state.vodLoading = false;
                state.vodSeries = data;
                renderGrid();
                renderHeader();
            }, function (error) {
                state.vodLoading = false;
                state.vodError = describeVod(error);
                renderGrid();
            });
    }

    function describeVod(error) {
        var status = error && (error.status || error.statusCode);
        if (status === 401 || status === 403) {
            return 'Sign in to Jellyfin again to browse the PROTV catalogue.';
        }

        if (status) {
            return 'The PROTV catalogue could not be loaded (HTTP ' + status + ').';
        }

        return 'The PROTV catalogue could not be loaded. Check the PROTV settings on the dashboard page.';
    }

    function switchView(view) {
        if (state.view === view) {
            return;
        }

        state.view = view;
        state.vodFilter = '';
        state.vodCategoryId = null;
        state.vodSeries = null;
        state.vodItems = [];
        state.vodError = null;
        state.vodPage = 1;
        var search = document.querySelector('#' + ROOT_ID + ' .protvTabSearch');
        if (search && view !== 'channels') {
            search.value = '';
        }

        renderHeader();
        renderGrid();
        if (view !== 'channels' && !state.vodItems.length) {
            loadVod(1);
        }
    }

    function renderVodBody() {
        var grid = document.getElementById(GRID_ID);
        var message = document.getElementById(MESSAGE_ID);
        var more = document.getElementById(MORE_ID);
        if (!grid || !message) {
            return;
        }

        grid.textContent = '';
        if (more) {
            more.style.display = 'none';
        }

        if (state.vodSeries) {
            renderSeriesDetail(grid, message);
            return;
        }

        if (state.vodError) {
            setMessage(state.vodError, 'bad');
            return;
        }

        if (state.vodLoading && !state.vodItems.length) {
            message.className = 'protvTabMessage';
            message.textContent = 'Loading the PROTV catalogue...';
            return;
        }

        if (!state.vodItems.length) {
            message.className = 'protvTabMessage';
            message.textContent = state.vodFilter
                ? 'No PROTV title matches "' + state.vodFilter + '".'
                : 'The PROTV catalogue returned no titles.';
            return;
        }

        renderMessage();
        grid.className = 'protvTabPosterGrid';
        var fragment = document.createDocumentFragment();
        for (var index = 0; index < state.vodItems.length; index++) {
            fragment.appendChild(vodCard(state.vodItems[index]));
        }

        grid.appendChild(fragment);

        if (more && state.vodPage < state.vodPageCount) {
            more.style.display = '';
            more.textContent = 'Load more (' + state.vodItems.length + ' of ' + state.vodTotal + ')';
        }
    }

    function vodCard(item) {
        var isSeries = item.kind === 'series';
        var missing = !isSeries && (!item.itemId || item.inLibrary === false);
        var node = document.createElement('div');
        node.className = 'protvTabPoster';
        node.setAttribute('role', 'button');
        node.setAttribute('tabindex', '0');
        node.setAttribute('data-playing', state.playing === 'vod:' + item.id ? '1' : '0');
        node.setAttribute('data-missing', missing ? '1' : '0');
        node.setAttribute('title', isSeries ? 'Open ' + item.title : 'Play ' + item.title);

        var art = document.createElement('div');
        art.className = 'protvTabPosterArt';
        if (item.posterUrl) {
            var image = document.createElement('img');
            image.loading = 'lazy';
            image.alt = item.title || '';
            image.src = item.posterUrl;
            image.addEventListener('error', function () {
                if (image.parentNode) {
                    art.removeChild(image);
                    art.appendChild(initialsNode(item.title));
                }
            });
            art.appendChild(image);
        } else {
            art.appendChild(initialsNode(item.title));
        }

        var overlay = document.createElement('div');
        overlay.className = 'protvTabPosterPlay';
        overlay.textContent = isSeries ? '\u2261' : '\u25b6';
        art.appendChild(overlay);

        var label = document.createElement('div');
        label.className = 'protvTabPosterLabel';
        label.textContent = item.title || '';

        var meta = document.createElement('div');
        meta.className = 'protvTabPosterMeta';
        meta.textContent = vodMeta(item, missing);

        node.appendChild(art);
        node.appendChild(label);
        node.appendChild(meta);

        var open = function () {
            if (isSeries) {
                loadSeriesDetail(item);
            } else {
                playVod(item);
            }
        };
        node.addEventListener('click', open);
        node.addEventListener('keydown', function (event) {
            if (event.key === 'Enter' || event.key === ' ' || event.key === 'Spacebar') {
                event.preventDefault();
                open();
            }
        });

        return node;
    }

    function vodMeta(item, missing) {
        var parts = [];
        if (item.kind === 'series') {
            if (item.seasonsCount) {
                parts.push(item.seasonsCount + (item.seasonsCount === 1 ? ' season' : ' seasons'));
            }
        } else if (item.kind === 'episode') {
            parts.push('S' + pad2(item.seasonNumber || 1) + 'E' + pad2(item.episodeNumber || 1));
        }

        if (item.year) {
            parts.push(String(item.year));
        }

        if (item.durationMinutes) {
            parts.push(item.durationMinutes + ' min');
        }

        if (item.rating) {
            parts.push('\u2605 ' + item.rating.toFixed(1));
        }

        if (missing) {
            parts.push('not synced yet');
        }

        return parts.join(' \u00b7 ');
    }

    function renderSeriesDetail(grid, message) {
        var data = state.vodSeries;
        var series = (data && data.series) || {};
        var seasons = (data && data.seasons) || [];
        message.className = 'protvTabMessage';
        message.textContent = '';
        grid.className = 'protvTabSeasons';

        var back = document.createElement('button');
        back.className = 'protvTabButton';
        back.type = 'button';
        back.textContent = '\u2190 Back to ' + vodSection().toLowerCase();
        back.addEventListener('click', function () {
            state.vodSeries = null;
            renderGrid();
            renderHeader();
        });
        grid.appendChild(back);

        var heading = document.createElement('div');
        heading.className = 'protvTabSeasonTitle';
        heading.textContent = series.title || 'Series';
        grid.appendChild(heading);

        if (!seasons.length) {
            var empty = document.createElement('p');
            empty.className = 'protvTabMessage';
            empty.textContent = 'This series has no seasons listed yet.';
            grid.appendChild(empty);
            return;
        }

        seasons.forEach(function (season) {
            var title = document.createElement('div');
            title.className = 'protvTabSeasonTitle';
            title.textContent = season.title || ('Season ' + season.index);
            grid.appendChild(title);

            var list = document.createElement('div');
            list.className = 'protvTabEpisodes';
            (season.episodes || []).forEach(function (episode) {
                list.appendChild(episodeRow(episode));
            });
            grid.appendChild(list);
        });
    }

    function episodeRow(episode) {
        var row = document.createElement('div');
        row.className = 'protvTabEpisode';
        row.setAttribute('role', 'button');
        row.setAttribute('tabindex', '0');
        row.setAttribute('data-playing', state.playing === 'vod:' + episode.id ? '1' : '0');

        var number = document.createElement('span');
        number.className = 'protvTabEpisodeNumber';
        number.textContent = 'E' + pad2(episode.episodeNumber || 1);

        var title = document.createElement('span');
        title.textContent = episode.title || '';

        var meta = document.createElement('span');
        meta.className = 'protvTabPosterMeta';
        meta.textContent = (!episode.itemId || episode.inLibrary === false)
            ? 'not synced yet'
            : (episode.durationMinutes ? episode.durationMinutes + ' min' : '');

        row.appendChild(number);
        row.appendChild(title);
        row.appendChild(meta);

        var open = function () {
            playVod(episode);
        };
        row.addEventListener('click', open);
        row.addEventListener('keydown', function (event) {
            if (event.key === 'Enter' || event.key === ' ' || event.key === 'Spacebar') {
                event.preventDefault();
                open();
            }
        });

        return row;
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
            // No dataType: the endpoint answers 204 with an empty body.
            return ApiClient.ajax({ type: 'POST', url: playUrl });
        });
    }

    // True once the client has visibly reacted to a play command by opening its player.
    function playerStarted() {
        if (!document.getElementById(GRID_ID)) {
            return true; // the client replaced the tab with its player page
        }

        if (window.location.hash.indexOf('video') >= 0) {
            return true;
        }

        var videos = document.querySelectorAll('video');
        for (var index = 0; index < videos.length; index++) {
            if (String(videos[index].currentSrc || videos[index].src || '')) {
                return true;
            }
        }

        return false;
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
        sendPlay(playable(channel.number, channel.name, channel.itemId, true), 1);
    }

    // Plays a film or an episode from the VOD catalogue. They are ordinary Jellyfin items once the
    // plugin has synced them, so they start exactly the way a live channel does.
    function playVod(item) {
        var key = 'vod:' + item.id;
        if (state.playing === key) {
            return;
        }

        if (!item.itemId || item.inLibrary === false) {
            setMessage('"' + item.title + '" is not in the PROTV VOD library yet. Open the PROTV '
                + 'dashboard page, press "Sync now" and come back once it has run.', 'bad');
            return;
        }

        state.playing = key;
        renderGrid();
        renderHeader();
        setMessage('Starting ' + item.title + '...', 'notice');
        sendPlay(playable(key, item.title, item.itemId, false), 1);
    }

    // What a play command needs: a key to highlight the card, a label for the messages and the
    // Jellyfin item to play. Live TV channels and VOD titles go through the same pipeline.
    function playable(key, label, itemId, isChannel) {
        return { key: key, label: label, itemId: itemId, isChannel: isChannel };
    }

    function sendPlay(target, attempt) {
        startPlayback(target).then(function () {
            watchPlayback(target, attempt);
        }, function (error) {
            var status = error && (error.status || error.statusCode);
            if (attempt < PLAY_ATTEMPTS && status !== 401 && status !== 403) {
                window.setTimeout(function () {
                    sendPlay(target, attempt + 1);
                }, PLAY_WATCH_MS);
                return;
            }

            finishPlay(playError(target, error));
        });
    }

    // The client answers by opening its player. That can take a few seconds, and the very first
    // play in a freshly loaded page can be swallowed while the client is still loading its player,
    // so ask again when nothing happens.
    function watchPlayback(target, attempt) {
        var ticks = 0;
        var timer = window.setInterval(function () {
            ticks++;
            if (playerStarted()) {
                window.clearInterval(timer);
                window.setTimeout(function () {
                    if (state.playing === target.key) {
                        state.playing = null;
                        renderGrid();
                        renderHeader();
                    }
                }, PLAYING_CLEAR_MS);
                return;
            }

            if (ticks < PLAY_WATCH_TICKS) {
                return;
            }

            window.clearInterval(timer);
            if (attempt < PLAY_ATTEMPTS) {
                sendPlay(target, attempt + 1);
                return;
            }

            finishPlay('"' + target.label + '" did not start. Check that the stream is online, '
                + 'then try again.');
        }, PLAY_WATCH_MS);
    }

    function finishPlay(message) {
        state.playing = null;
        renderGrid();
        renderHeader();
        if (message) {
            setMessage(message, 'bad');
        }
    }

    function playError(target, error) {
        if (error && error.message === 'no-session') {
            return 'Jellyfin could not find this app session. Reload the page and try again.';
        }

        var status = error && (error.status || error.statusCode);
        if (status === 401 || status === 403) {
            return 'Sign in to Jellyfin again to play this.';
        }

        if (status) {
            var hint = target.isChannel
                ? ' If Live TV has no channels yet, run the Jellyfin "Refresh Guide" task.'
                : ' If the PROTV VOD library is empty, run the VOD sync from the PROTV dashboard page.';
            return '"' + target.label + '" could not be started (HTTP ' + status + ').' + hint;
        }

        return '"' + target.label + '" could not be started. The PROTV service or the stream may be '
            + 'offline.';
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
            if (state.view === 'channels') {
                state.filter = search.value;
                renderGrid();
                renderHeader();
                return;
            }

            state.vodFilter = search.value;
            if (vodSearchTimer) {
                window.clearTimeout(vodSearchTimer);
            }

            vodSearchTimer = window.setTimeout(function () {
                loadVod(1);
            }, 450);
        });
        search.addEventListener('keydown', function (event) {
            if (event.key === 'Enter' && state.view !== 'channels') {
                event.preventDefault();
                if (vodSearchTimer) {
                    window.clearTimeout(vodSearchTimer);
                }

                loadVod(1);
            }
        });

        // Channels / Films / Series. The two VOD views browse the PROTV catalogue.
        var views = document.createElement('div');
        views.className = 'protvTabViews';
        [['channels', 'Channels'], ['movies', 'Films'], ['series', 'Series']].forEach(function (entry) {
            var view = document.createElement('button');
            view.className = 'protvTabView';
            view.type = 'button';
            view.setAttribute('data-view', entry[0]);
            view.textContent = entry[1];
            view.addEventListener('click', function () {
                switchView(entry[0]);
            });
            views.appendChild(view);
        });

        var button = document.createElement('button');
        button.className = 'protvTabButton protvTabRefresh';
        button.type = 'button';
        button.textContent = 'Refresh';
        button.addEventListener('click', function () {
            if (state.view === 'channels') {
                load(true);
            } else {
                loadVod(1);
            }
        });

        header.appendChild(title);
        header.appendChild(count);
        header.appendChild(views);
        header.appendChild(search);
        header.appendChild(button);

        var hint = document.createElement('p');
        hint.className = 'protvTabHint';
        hint.textContent = 'Pick a channel to play it here (the same Live TV channel the rest of '
            + 'Jellyfin plays). Use \u2139 on a channel to open its Jellyfin page instead.';

        var grid = document.createElement('div');
        grid.id = GRID_ID;
        grid.className = 'protvTabGrid';

        var more = document.createElement('button');
        more.id = MORE_ID;
        more.className = 'protvTabButton protvTabMore';
        more.type = 'button';
        more.style.display = 'none';
        more.addEventListener('click', function () {
            if (state.vodLoading) {
                return;
            }

            loadVod(state.vodPage + 1, true);
        });

        var message = document.createElement('div');
        message.id = MESSAGE_ID;
        message.className = 'protvTabMessage';

        host.appendChild(header);
        host.appendChild(hint);
        host.appendChild(message);
        host.appendChild(grid);
        host.appendChild(more);
    }

    function renderHeader() {
        var host = document.getElementById(ROOT_ID);
        if (!host) {
            return;
        }

        var title = host.querySelector('.protvTabTitle');
        var count = host.querySelector('.protvTabCount');
        var button = host.querySelector('.protvTabRefresh');
        var search = host.querySelector('.protvTabSearch');
        var hint = host.querySelector('.protvTabHint');
        if (title) {
            title.textContent = state.title;
        }

        var busy = state.view === 'channels' ? state.loading : state.vodLoading;
        var views = host.querySelectorAll('.protvTabView');
        for (var index = 0; index < views.length; index++) {
            views[index].setAttribute(
                'data-active',
                views[index].getAttribute('data-view') === state.view ? '1' : '0');
        }

        if (button) {
            button.disabled = busy;
            button.textContent = busy
                ? (state.view === 'channels' ? 'Refreshing...' : 'Loading...')
                : 'Refresh';
        }

        if (search) {
            if (state.view === 'channels') {
                search.placeholder = 'Filter channels';
                search.style.display = state.channels.length ? '' : 'none';
            } else {
                search.placeholder = state.view === 'series' ? 'Search series' : 'Search films';
                search.style.display = '';
            }
        }

        if (hint) {
            hint.textContent = state.view === 'channels'
                ? 'Pick a channel to play it here (the same Live TV channel the rest of Jellyfin '
                    + 'plays). Use \u2139 on a channel to open its Jellyfin page instead.'
                : 'Films and episodes play here once they are in the PROTV VOD library (see the '
                    + 'PROTV dashboard page). Series open their season list.';
        }

        if (!count) {
            return;
        }

        if (state.view === 'channels') {
            if (state.error || !state.channels.length) {
                count.textContent = '';
            } else {
                var visible = visibleChannels().length;
                count.textContent = visible === state.total
                    ? state.total + (state.total === 1 ? ' channel' : ' channels')
                    : visible + ' of ' + state.total + ' channels';
            }

            return;
        }

        if (state.vodSeries || !state.vodItems.length) {
            count.textContent = '';
            return;
        }

        var noun = state.view === 'series' ? 'series' : 'films';
        count.textContent = state.vodItems.length === state.vodTotal
            ? state.vodTotal + ' ' + noun
            : state.vodItems.length + ' of ' + state.vodTotal + ' ' + noun;
    }

    function renderGrid() {
        var grid = document.getElementById(GRID_ID);
        var message = document.getElementById(MESSAGE_ID);
        if (!grid || !message) {
            return;
        }

        if (state.view !== 'channels') {
            renderVodBody();
            return;
        }

        grid.className = 'protvTabGrid';
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
