using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Services;
using PROTV.DataAccess;
using PROTV.Wpf.ViewModels;
using PROTV.Wpf.Views;
using Refit;

namespace PROTV.Wpf.Bootstrap;

public class AppContainer
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public string TgI88fhU0A;

		public _003C_003Ec__DisplayClass1_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal Task<string> cCA8kUlU2j()
		{
			return Task.FromResult(TgI88fhU0A);
		}
	}

	private static IContainer M4XTj3TnhL;

	public static void AppInititalize()
	{
		ContainerBuilder containerBuilder = new ContainerBuilder();
		SqliteConnectionStringBuilder sqliteConnectionStringBuilder = new SqliteConnectionStringBuilder(iFZ5je3XFYKwkvcE5D.D35lls5iF(15464, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		hH6DVMBvgw3ANNRyBk6.D35lls5iF(sqliteConnectionStringBuilder, CD1XyAkh2uXPIjQpM2J.D35lls5iF(Environment.GetFolderPath(Environment.SpecialFolder.Personal), iFZ5je3XFYKwkvcE5D.D35lls5iF(15506, iFZ5je3XFYKwkvcE5D.N06TeK0ao), QQLie3eYkZwbFFm9Jjw.D35lls5iF(sqliteConnectionStringBuilder, QQLie3eYkZwbFFm9Jjw.eGpksEKMx4), CD1XyAkh2uXPIjQpM2J.jI8kxN2VVg), hH6DVMBvgw3ANNRyBk6.HwpkYbnGmu);
		string connectionString = wq2usy8gNndpuTw5mR.D35lls5iF(sqliteConnectionStringBuilder, wq2usy8gNndpuTw5mR.ajcDe8nffb);
		if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(UwSEfC4rh9eVlFenwI.D35lls5iF(Environment.GetFolderPath(Environment.SpecialFolder.Personal), iFZ5je3XFYKwkvcE5D.D35lls5iF(15506, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UwSEfC4rh9eVlFenwI.jjPkgidiRA), M6ZErPEr2LZyWYpa5O.vqqBpLiOe))
		{
			gM00OS0Iir9SCS8q6P.D35lls5iF(UwSEfC4rh9eVlFenwI.D35lls5iF(Environment.GetFolderPath(Environment.SpecialFolder.Personal), iFZ5je3XFYKwkvcE5D.D35lls5iF(15506, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UwSEfC4rh9eVlFenwI.jjPkgidiRA), gM00OS0Iir9SCS8q6P.RKarZUs3s);
		}
		DbContextOptionsBuilder<ClientDataStoreDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<ClientDataStoreDbContext>();
		dbContextOptionsBuilder.UseSqlite(connectionString);
		ClientDataStoreDbContext instance = new ClientDataStoreDbContext(dbContextOptionsBuilder.Options);
		containerBuilder.RegisterInstance(instance).As<ClientDataStoreDbContext>().SingleInstance();
		RefitSettings refitSettings = new RefitSettings();
		if (M4XTj3TnhL != null)
		{
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass1_0();
			IStoreContext storeContext = M4XTj3TnhL.Resolve<IStoreContext>();
			CS_0024_003C_003E8__locals2.TgI88fhU0A = bEXq5ukQ3K0eWImoKOH.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(storeContext, QQLie3eYkZwbFFm9Jjw.wSLkiqiN60), 7, bEXq5ukQ3K0eWImoKOH.IsPkXEuEM9);
			PHpK3ekfN1RcEmydh2F.D35lls5iF(refitSettings, () => Task.FromResult(CS_0024_003C_003E8__locals2.TgI88fhU0A), PHpK3ekfN1RcEmydh2F.rtYkFrfOFP);
			containerBuilder.RegisterInstance(storeContext).As<IStoreContext>().SingleInstance();
			MainViewModel instance2 = M4XTj3TnhL.Resolve<MainViewModel>();
			containerBuilder.RegisterInstance(instance2).As<MainViewModel>().SingleInstance();
			HomeViewModel instance3 = M4XTj3TnhL.Resolve<HomeViewModel>();
			containerBuilder.RegisterInstance(instance3).As<HomeViewModel>().SingleInstance();
		}
		else
		{
			containerBuilder.RegisterType<MainViewModel>().AsSelf().SingleInstance();
			containerBuilder.RegisterType<HomeViewModel>().AsSelf().SingleInstance();
			containerBuilder.RegisterType<StoreContext>().As<IStoreContext>().SingleInstance();
		}
		IAuthApi authApi = RestService.For<IAuthApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IAuthApi authApi2 = RestService.For<IAuthApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IAppApi appApi = RestService.For<IAppApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IAppApi appApi2 = RestService.For<IAppApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IYoutubeApi youtubeApi = RestService.For<IYoutubeApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IYoutubeApi youtubeApi2 = RestService.For<IYoutubeApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IMusicApi musicApi = RestService.For<IMusicApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IMusicApi musicApi2 = RestService.For<IMusicApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IPeopleApi peopleApi = RestService.For<IPeopleApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IPeopleApi peopleApi2 = RestService.For<IPeopleApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IMovieApi movieApi = RestService.For<IMovieApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IMovieApi movieApi2 = RestService.For<IMovieApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		ISeriesApi seriesApi = RestService.For<ISeriesApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		ISeriesApi seriesApi2 = RestService.For<ISeriesApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		ISeasonApi seasonApi = RestService.For<ISeasonApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		ISeasonApi seasonApi2 = RestService.For<ISeasonApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IQuranApi quranApi = RestService.For<IQuranApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IQuranApi quranApi2 = RestService.For<IQuranApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		ILiveApi liveApi = RestService.For<ILiveApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		ILiveApi liveApi2 = RestService.For<ILiveApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IHistoryApi historyApi = RestService.For<IHistoryApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IHistoryApi historyApi2 = RestService.For<IHistoryApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IPlaylistApi playlistApi = RestService.For<IPlaylistApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.iuBk23v7hp), refitSettings);
		IPlaylistApi playlistApi2 = RestService.For<IPlaylistApi>(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.NmHkZgakBO), refitSettings);
		IPTVApis iPTVApis = new IPTVApis();
		QlENc4kjCmkhWljxN7X.D35lls5iF(iPTVApis, authApi2, QlENc4kjCmkhWljxN7X.W0xkyBp14C);
		QlENc4kjCmkhWljxN7X.D35lls5iF(iPTVApis, authApi, QlENc4kjCmkhWljxN7X.Ru3kqUxoiw);
		sTkJHpkJWatgSa0Vyty.D35lls5iF(iPTVApis, appApi2, sTkJHpkJWatgSa0Vyty.uy0kbjuvDW);
		sTkJHpkJWatgSa0Vyty.D35lls5iF(iPTVApis, appApi, sTkJHpkJWatgSa0Vyty.mRDkWwuPJX);
		v5UqnRk5uhOf2Iqv5Dl.D35lls5iF(iPTVApis, youtubeApi2, v5UqnRk5uhOf2Iqv5Dl.TICkz35dT2);
		v5UqnRk5uhOf2Iqv5Dl.D35lls5iF(iPTVApis, youtubeApi, v5UqnRk5uhOf2Iqv5Dl.oBavoKFIqj);
		pOyg6Avluuu01gMvJq2.D35lls5iF(iPTVApis, musicApi2, pOyg6Avluuu01gMvJq2.BMXv9HqlIM);
		pOyg6Avluuu01gMvJq2.D35lls5iF(iPTVApis, musicApi, pOyg6Avluuu01gMvJq2.S7LvDC797v);
		kml9wwvHuScIHPT6sUa.D35lls5iF(iPTVApis, peopleApi2, kml9wwvHuScIHPT6sUa.zQHv11VPFI);
		kml9wwvHuScIHPT6sUa.D35lls5iF(iPTVApis, peopleApi, kml9wwvHuScIHPT6sUa.Mxwv8AnQRi);
		yoklSFvnc80WICR0oYr.D35lls5iF(iPTVApis, movieApi2, yoklSFvnc80WICR0oYr.wmkv3oMj2D);
		yoklSFvnc80WICR0oYr.D35lls5iF(iPTVApis, movieApi, yoklSFvnc80WICR0oYr.AuGvTLrtkS);
		KnPyjhv4j6VV900jTdi.D35lls5iF(iPTVApis, seriesApi2, KnPyjhv4j6VV900jTdi.aJ4vLNJxOq);
		KnPyjhv4j6VV900jTdi.D35lls5iF(iPTVApis, seriesApi, KnPyjhv4j6VV900jTdi.HiQvEAZdgO);
		vj6BiLvBU6JYOZrxA3G.D35lls5iF(iPTVApis, seasonApi2, vj6BiLvBU6JYOZrxA3G.Atvv0NQiVQ);
		vj6BiLvBU6JYOZrxA3G.D35lls5iF(iPTVApis, seasonApi, vj6BiLvBU6JYOZrxA3G.kL4vrxHrbe);
		e0Eb8svemjveMKFnJAp.D35lls5iF(iPTVApis, quranApi2, e0Eb8svemjveMKFnJAp.qBUvGAbuaL);
		e0Eb8svemjveMKFnJAp.D35lls5iF(iPTVApis, quranApi, e0Eb8svemjveMKFnJAp.kikvR8Plwt);
		vHTBBqvkBbEbkmloVQZ.D35lls5iF(iPTVApis, liveApi2, vHTBBqvkBbEbkmloVQZ.MUqvvI5ILe);
		vHTBBqvkBbEbkmloVQZ.D35lls5iF(iPTVApis, liveApi, vHTBBqvkBbEbkmloVQZ.M3rvAl0F5b);
		BrRMyDv6rdhM2yt54gd.D35lls5iF(iPTVApis, historyApi2, BrRMyDv6rdhM2yt54gd.kg9vpCaTUa);
		BrRMyDv6rdhM2yt54gd.D35lls5iF(iPTVApis, historyApi, BrRMyDv6rdhM2yt54gd.xV4vwKMteG);
		aYyywGvC2MZM9sCpPly.D35lls5iF(iPTVApis, playlistApi2, aYyywGvC2MZM9sCpPly.AZdvm9nJ3Y);
		aYyywGvC2MZM9sCpPly.D35lls5iF(iPTVApis, playlistApi, aYyywGvC2MZM9sCpPly.OXIva58qxB);
		IPTVApis instance4 = iPTVApis;
		containerBuilder.RegisterInstance(instance4).SingleInstance();
		containerBuilder.RegisterType<AuthService>().As<IAuthService>().SingleInstance();
		containerBuilder.RegisterType<AppService>().As<IAppService>().SingleInstance();
		containerBuilder.RegisterType<YoutubeService>().As<IYoutubeService>().SingleInstance();
		containerBuilder.RegisterType<MusicService>().As<IMusicService>().SingleInstance();
		containerBuilder.RegisterType<PeopleService>().As<IPeopleService>().SingleInstance();
		containerBuilder.RegisterType<MovieService>().As<IMovieService>().SingleInstance();
		containerBuilder.RegisterType<SeriesService>().As<ISeriesService>().SingleInstance();
		containerBuilder.RegisterType<SeasonService>().As<ISeasonService>().SingleInstance();
		containerBuilder.RegisterType<QuranService>().As<IQuranService>().SingleInstance();
		containerBuilder.RegisterType<LiveService>().As<ILiveService>().SingleInstance();
		containerBuilder.RegisterType<HistoryService>().As<IHistoryService>().SingleInstance();
		containerBuilder.RegisterType<PlaylistService>().As<IPlaylistService>().SingleInstance();
		containerBuilder.RegisterType<LoginViewModel>().AsSelf();
		containerBuilder.RegisterType<MoviesViewModel>().AsSelf();
		containerBuilder.RegisterType<SeriesViewModel>().AsSelf();
		containerBuilder.RegisterType<MusicViewModel>().AsSelf();
		containerBuilder.RegisterType<YtViewModel>().AsSelf();
		containerBuilder.RegisterType<RecitatorsViewModel>().AsSelf();
		containerBuilder.RegisterType<EntertainmentCenterViewModel>().AsSelf();
		containerBuilder.RegisterType<LivePlayerViewModel>().AsSelf();
		containerBuilder.RegisterType<ProfilePageViewModel>().AsSelf();
		containerBuilder.RegisterType<BaseClientDataStore>().As<IClientDataStore>().SingleInstance();
		M4XTj3TnhL = X4ki0FvIChbalMUUv6m.D35lls5iF(containerBuilder, ContainerBuildOptions.None, X4ki0FvIChbalMUUv6m.NeVvdd2lOl);
	}

	public static T Resolve<T>()
	{
		try
		{
			return M4XTj3TnhL.Resolve<T>();
		}
		catch
		{
			return default(T);
		}
	}

	public static T Resolve<T>(NamedParameter namedParameter)
	{
		try
		{
			return M4XTj3TnhL.Resolve<T>(new Parameter[1] { namedParameter });
		}
		catch
		{
			return default(T);
		}
	}

	public AppContainer()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
