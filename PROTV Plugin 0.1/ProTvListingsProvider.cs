using MediaBrowser.Controller.LiveTv;
using MediaBrowser.Model.Dto;
using MediaBrowser.Model.LiveTv;

namespace PROTV.Plugin;

public sealed class ProTvListingsProvider : IListingsProvider
{
    private readonly ProTvApiClient _api;

    public ProTvListingsProvider(ProTvApiClient api)
    {
        _api = api;
    }

    public string Name => "PROTV EPG";

    public string Type => "PROTV";

    public async Task<IEnumerable<ProgramInfo>> GetProgramsAsync(
        ListingsProviderInfo info,
        string channelId,
        DateTime startDateUtc,
        DateTime endDateUtc,
        CancellationToken cancellationToken)
    {
        var channels = await _api.GetEpgAsync(cancellationToken);
        var channel = channels.FirstOrDefault(item => item.ChannelId.ToString() == channelId);
        return (channel?.Programs ?? Array.Empty<ProTvEpgItem>())
            .Where(program => program.EndTime > startDateUtc && program.StartTime < endDateUtc)
            .Select(program => new ProgramInfo
            {
                Id = $"PROTV-{channelId}-{program.StartTime:O}",
                ChannelId = channelId,
                Name = program.Title ?? "PROTV",
                Overview = program.Description,
                StartDate = program.StartTime.ToUniversalTime(),
                EndDate = program.EndTime.ToUniversalTime(),
                IsLive = true
            });
    }

    public Task Validate(ListingsProviderInfo info, bool validateLogin, bool validateListings)
    {
        return validateListings ? _api.GetEpgAsync(CancellationToken.None) : Task.CompletedTask;
    }

    public Task<List<NameIdPair>> GetLineups(ListingsProviderInfo info, string country, string location)
    {
        return Task.FromResult(new List<NameIdPair>
        {
            new() { Name = "PROTV", Id = "PROTV" }
        });
    }

    public async Task<List<ChannelInfo>> GetChannels(ListingsProviderInfo info, CancellationToken cancellationToken)
    {
        var channels = await _api.GetChannelsAsync(cancellationToken);
        return channels.OrderBy(channel => channel.TitleEn ?? channel.TitleAr ?? string.Empty, StringComparer.OrdinalIgnoreCase).Select(channel => new ChannelInfo
        {
            Id = channel.Id.ToString(),
            Name = channel.TitleEn ?? channel.TitleAr ?? $"Channel {channel.Id}",
            Number = channel.Id.ToString(),
            ImageUrl = channel.Logo,
            HasImage = !string.IsNullOrWhiteSpace(channel.Logo),
            ChannelType = ChannelType.TV
        }).ToList();
    }
}
