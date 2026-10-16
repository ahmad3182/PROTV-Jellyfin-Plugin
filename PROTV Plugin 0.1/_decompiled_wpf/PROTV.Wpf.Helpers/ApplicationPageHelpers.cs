using PROTV.Abstractions.Common;
using PROTV.Wpf.ViewModels;
using PROTV.Wpf.Views;

namespace PROTV.Wpf.Helpers;

public static class ApplicationPageHelpers
{
	public static BasePage ToBasePage(this ApplicationPage page, object viewModel = null)
	{
		return page switch
		{
			ApplicationPage.Login => new LogInView(viewModel as LoginViewModel), 
			ApplicationPage.Home => new HomeView(viewModel as HomeViewModel), 
			ApplicationPage.Movies => new MoviesView(viewModel as MoviesViewModel), 
			ApplicationPage.MovieDetailsPage => new MovieDetailsView(viewModel as MovieItemViewModel), 
			ApplicationPage.Series => new SeriesView(viewModel as SeriesViewModel), 
			ApplicationPage.MusicPage => new MusicView(viewModel as MusicViewModel), 
			ApplicationPage.Youtube => new YtView(viewModel as YtViewModel), 
			ApplicationPage.ArtistDetailsView => new ArtistDetailsView(viewModel as ArtistItemViewModel), 
			ApplicationPage.ProfilePage => new ProfileView(viewModel as ProfilePageViewModel), 
			ApplicationPage.Quran => new QuranView(viewModel as RecitatorsViewModel), 
			ApplicationPage.TVShowPage => new VideoPlayerView(viewModel as VideoPlayerViewModel), 
			ApplicationPage.MyMoviePage => new EntertainmentCenterView(viewModel as EntertainmentCenterViewModel), 
			ApplicationPage.SeriesDetailsPage => new SeriesDetailsView(viewModel as SeriesItemViewModel), 
			ApplicationPage.ShowPage => new SeriesView(viewModel as SeriesViewModel), 
			ApplicationPage.LogoPage => new LogoView(), 
			ApplicationPage.ShowMoviePage => new MovieFFMEPlayer(viewModel as MoviePlayerViewModel), 
			ApplicationPage.YoutubePlayer => new YtFFMEPlayer(viewModel as YtVideoPlayerViewModel), 
			ApplicationPage.PlayListDetailsView => new PlaylistSongListView(viewModel as MainPlayerViewModel), 
			ApplicationPage.ShowSeriesPage => new SeriesFFMEPlayer(viewModel as SereisPlayerViewModel), 
			ApplicationPage.RadioPage => new RadioControlView(viewModel as LivePlayerViewModel), 
			ApplicationPage.SurahsPage => new SurahsView(viewModel as SurahsViewModel), 
			_ => null, 
		};
	}

	public static string ToPageTitle(this ApplicationPage page)
	{
		return page switch
		{
			ApplicationPage.Login => iFZ5je3XFYKwkvcE5D.D35lls5iF(12530, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.Home => iFZ5je3XFYKwkvcE5D.D35lls5iF(12318, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.Movies => iFZ5je3XFYKwkvcE5D.D35lls5iF(9234, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.MovieDetailsPage => T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(12544, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 0, T6EedHr0CxquZL0BWCa.RU5rr1yw2Z), 
			ApplicationPage.Series => iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.MusicPage => iFZ5je3XFYKwkvcE5D.D35lls5iF(9382, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.Youtube => iFZ5je3XFYKwkvcE5D.D35lls5iF(9544, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.ArtistDetailsView => T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(12544, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 0, T6EedHr0CxquZL0BWCa.RU5rr1yw2Z), 
			ApplicationPage.ProfilePage => iFZ5je3XFYKwkvcE5D.D35lls5iF(9762, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.Quran => iFZ5je3XFYKwkvcE5D.D35lls5iF(9622, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.TVShowPage => iFZ5je3XFYKwkvcE5D.D35lls5iF(12554, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.MyMoviePage => iFZ5je3XFYKwkvcE5D.D35lls5iF(12574, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.SeriesDetailsPage => T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(12544, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 0, T6EedHr0CxquZL0BWCa.RU5rr1yw2Z), 
			ApplicationPage.ShowPage => iFZ5je3XFYKwkvcE5D.D35lls5iF(9452, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.LogoPage => iFZ5je3XFYKwkvcE5D.D35lls5iF(12318, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.ShowMoviePage => iFZ5je3XFYKwkvcE5D.D35lls5iF(12618, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.YoutubePlayer => iFZ5je3XFYKwkvcE5D.D35lls5iF(12646, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.PlayListDetailsView => iFZ5je3XFYKwkvcE5D.D35lls5iF(12678, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.ShowSeriesPage => iFZ5je3XFYKwkvcE5D.D35lls5iF(12706, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.RadioPage => iFZ5je3XFYKwkvcE5D.D35lls5iF(9692, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			ApplicationPage.SurahsPage => iFZ5je3XFYKwkvcE5D.D35lls5iF(12736, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
			_ => null, 
		};
	}

	public static ApplicationPage ToApplicationPage(this BasePage page)
	{
		if (page is LogInView)
		{
			return ApplicationPage.Login;
		}
		if (page is HomeView)
		{
			return ApplicationPage.Home;
		}
		if (page is MoviesView)
		{
			return ApplicationPage.Movies;
		}
		if (page is SeriesView && spq0gOreqjTFyeVY1nd.D35lls5iF((RAspAbuaTQFU0nSRiQ.D35lls5iF(page, RAspAbuaTQFU0nSRiQ.IoP1rAL1GD) as SeriesViewModel).SearchQuery.Search, spq0gOreqjTFyeVY1nd.qoErGd9J4A) == SeriesType.Series)
		{
			return ApplicationPage.Series;
		}
		if (page is SeriesView)
		{
			return ApplicationPage.ShowPage;
		}
		if (page is MusicView)
		{
			return ApplicationPage.MusicPage;
		}
		if (page is YtView)
		{
			return ApplicationPage.Youtube;
		}
		if (page is MovieDetailsView)
		{
			return ApplicationPage.MovieDetailsPage;
		}
		if (page is EntertainmentCenterView)
		{
			return ApplicationPage.MyMoviePage;
		}
		if (page is LiveFFMEPlayer || page is VideoPlayerView)
		{
			return ApplicationPage.TVShowPage;
		}
		if (page is MovieFFMEPlayer)
		{
			return ApplicationPage.ShowMoviePage;
		}
		if (page is SeriesFFMEPlayer)
		{
			return ApplicationPage.ShowSeriesPage;
		}
		if (page is LogoView)
		{
			return ApplicationPage.LogoPage;
		}
		if (page is SeriesDetailsView)
		{
			return ApplicationPage.SeriesDetailsPage;
		}
		if (page is RadioControlView)
		{
			return ApplicationPage.RadioPage;
		}
		if (page is SurahsView)
		{
			return ApplicationPage.SurahsPage;
		}
		if (page is QuranView)
		{
			return ApplicationPage.Quran;
		}
		if (page is ProfileView)
		{
			return ApplicationPage.ProfilePage;
		}
		if (page is YtFFMEPlayer)
		{
			return ApplicationPage.YoutubePlayer;
		}
		if (page is PlaylistSongListView)
		{
			return ApplicationPage.PlayListDetailsView;
		}
		return ApplicationPage.Login;
	}
}
