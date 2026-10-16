using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.Helpers;
using PROTV.Wpf.Views;

namespace PROTV.Wpf.ViewModels;

public class HomeViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct DttrZ9aLj7yPObxqeN : IAsyncStateMachine
		{
			public int u9g85KGmvN;

			public AsyncVoidMethodBuilder Hco8uMU36p;

			public _003C_003Ec__DisplayClass29_0 Rug8Aat9Pi;

			private TaskAwaiter zPE8NlAkQF;

			private void MoveNext()
			{
				int num = u9g85KGmvN;
				_003C_003Ec__DisplayClass29_0 obj = Rug8Aat9Pi;
				try
				{
					object obj2;
					TaskAwaiter awaiter;
					string text;
					switch (num)
					{
					default:
						obj2 = RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(obj.ycWZHjMh4p, Xlypb0Hnr2C3ydrYEdG.tG8wg4ah0E), RAspAbuaTQFU0nSRiQ.u5F1dXRFmB) as Page, RAspAbuaTQFU0nSRiQ.UVfHSpoUCc) as BasePage, RAspAbuaTQFU0nSRiQ.IoP1rAL1GD);
						switch (Ad8NmsHKMDNoqEDFjtJ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(obj.ycWZHjMh4p, Xlypb0Hnr2C3ydrYEdG.tG8wg4ah0E), RAspAbuaTQFU0nSRiQ.u5F1dXRFmB) as Page, RAspAbuaTQFU0nSRiQ.UVfHSpoUCc) as BasePage, Ad8NmsHKMDNoqEDFjtJ.ljhHNvS1WJ))
						{
						case ApplicationPage.TVShowPage:
							goto IL_00ff;
						case ApplicationPage.Movies:
							goto IL_0195;
						case ApplicationPage.Series:
							goto IL_022a;
						case ApplicationPage.SurahsPage:
							goto IL_02bf;
						case ApplicationPage.Quran:
							goto IL_0354;
						case ApplicationPage.MusicPage:
							RgohxL7UjTqAbA8ZEPB.D35lls5iF(obj2 as MusicViewModel, obj.JWfZoQwfgB, RgohxL7UjTqAbA8ZEPB.LLn7uP9U8c);
							break;
						case ApplicationPage.Youtube:
							goto IL_0404;
						}
						goto end_IL_0015;
					case 0:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_0184;
					case 1:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_0219;
					case 2:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_02ae;
					case 3:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_0343;
					case 4:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_03d8;
					case 5:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_04d3;
					case 6:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_05c1;
					case 7:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_068f;
					case 8:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_075d;
					case 9:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_082c;
					case 10:
						awaiter = zPE8NlAkQF;
						zPE8NlAkQF = default(TaskAwaiter);
						num = (u9g85KGmvN = -1);
						goto IL_08fb;
					case 11:
						{
							awaiter = zPE8NlAkQF;
							zPE8NlAkQF = default(TaskAwaiter);
							num = (u9g85KGmvN = -1);
							break;
						}
						IL_0404:
						text = eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj2 as YtViewModel, eVlRnEIaHT0dqvCx0Kx.bTbtoUYxPU);
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14368, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							hH6DVMBvgw3ANNRyBk6.D35lls5iF(KBhYvT7PxsjiBgNpv52.D35lls5iF(obj2 as YtViewModel, KBhYvT7PxsjiBgNpv52.XiK7sNba5q).SearchQuery.Search, obj.JWfZoQwfgB, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(KBhYvT7PxsjiBgNpv52.D35lls5iF(obj2 as YtViewModel, KBhYvT7PxsjiBgNpv52.XiK7sNba5q).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (u9g85KGmvN = 5);
								zPE8NlAkQF = awaiter;
								Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_04d3;
						}
						if (!S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14394, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14412, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								hH6DVMBvgw3ANNRyBk6.D35lls5iF(KBhYvT7PxsjiBgNpv52.D35lls5iF(obj2 as YtViewModel, KBhYvT7PxsjiBgNpv52.Lrl7hyV7Tn).SearchQuery.Search, obj.JWfZoQwfgB, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
								awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(KBhYvT7PxsjiBgNpv52.D35lls5iF(obj2 as YtViewModel, KBhYvT7PxsjiBgNpv52.Lrl7hyV7Tn).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (u9g85KGmvN = 6);
									zPE8NlAkQF = awaiter;
									Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_05c1;
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14442, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								hH6DVMBvgw3ANNRyBk6.D35lls5iF(GO5OwO7xWZmxDxSqbSX.D35lls5iF(obj2 as YtViewModel, GO5OwO7xWZmxDxSqbSX.g2o7Y5xCha).SearchQuery.Search, obj.JWfZoQwfgB, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
								awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(GO5OwO7xWZmxDxSqbSX.D35lls5iF(obj2 as YtViewModel, GO5OwO7xWZmxDxSqbSX.g2o7Y5xCha).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (u9g85KGmvN = 7);
									zPE8NlAkQF = awaiter;
									Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_068f;
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14488, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								hH6DVMBvgw3ANNRyBk6.D35lls5iF(KBhYvT7PxsjiBgNpv52.D35lls5iF(obj2 as YtViewModel, KBhYvT7PxsjiBgNpv52.zLM7gcVwW5).SearchQuery.Search, obj.JWfZoQwfgB, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
								awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(KBhYvT7PxsjiBgNpv52.D35lls5iF(obj2 as YtViewModel, KBhYvT7PxsjiBgNpv52.zLM7gcVwW5).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (u9g85KGmvN = 8);
									zPE8NlAkQF = awaiter;
									Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_075d;
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14508, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								hH6DVMBvgw3ANNRyBk6.D35lls5iF(WOgKgD7ixFErPKyNP2O.D35lls5iF(obj2 as YtViewModel, WOgKgD7ixFErPKyNP2O.NRR7QOiXHk).SearchQuery.Search, obj.JWfZoQwfgB, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
								awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(WOgKgD7ixFErPKyNP2O.D35lls5iF(obj2 as YtViewModel, WOgKgD7ixFErPKyNP2O.NRR7QOiXHk).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (u9g85KGmvN = 9);
									zPE8NlAkQF = awaiter;
									Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_082c;
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14526, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								hH6DVMBvgw3ANNRyBk6.D35lls5iF(KBhYvT7PxsjiBgNpv52.D35lls5iF(obj2 as YtViewModel, KBhYvT7PxsjiBgNpv52.xFh7XvIaQk).SearchQuery.Search, obj.JWfZoQwfgB, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
								awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(KBhYvT7PxsjiBgNpv52.D35lls5iF(obj2 as YtViewModel, KBhYvT7PxsjiBgNpv52.xFh7XvIaQk).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (u9g85KGmvN = 10);
									zPE8NlAkQF = awaiter;
									Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_08fb;
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14554, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								hH6DVMBvgw3ANNRyBk6.D35lls5iF(GO5OwO7xWZmxDxSqbSX.D35lls5iF(obj2 as YtViewModel, GO5OwO7xWZmxDxSqbSX.b6G7flrRpY).SearchQuery.Search, obj.JWfZoQwfgB, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
								awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(GO5OwO7xWZmxDxSqbSX.D35lls5iF(obj2 as YtViewModel, GO5OwO7xWZmxDxSqbSX.b6G7flrRpY).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (u9g85KGmvN = 11);
									zPE8NlAkQF = awaiter;
									Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
							}
						}
						goto end_IL_0015;
						IL_0354:
						RgohxL7UjTqAbA8ZEPB.D35lls5iF(obj2 as RecitatorsViewModel, obj.JWfZoQwfgB, RgohxL7UjTqAbA8ZEPB.gQI7NAqm8j);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj2 as RecitatorsViewModel, OYihPsCZ1OyLa5m4TD0.gyR7OtDjD0), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (u9g85KGmvN = 4);
							zPE8NlAkQF = awaiter;
							Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_03d8;
						IL_0219:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_04d3:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_03d8:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_082c:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_02bf:
						RgohxL7UjTqAbA8ZEPB.D35lls5iF(obj2 as SurahsViewModel, obj.JWfZoQwfgB, RgohxL7UjTqAbA8ZEPB.rnQ7SUdKFI);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj2 as SurahsViewModel, OYihPsCZ1OyLa5m4TD0.t147KnMikJ), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (u9g85KGmvN = 3);
							zPE8NlAkQF = awaiter;
							Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0343;
						IL_00ff:
						RgohxL7UjTqAbA8ZEPB.D35lls5iF(obj2 as VideoPlayerViewModel, obj.JWfZoQwfgB, RgohxL7UjTqAbA8ZEPB.eay7t2L3N2);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(kxYFveE4H3pBXluJ1GJ.D35lls5iF(obj2 as VideoPlayerViewModel, true, kxYFveE4H3pBXluJ1GJ.TADpjOOPUg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (u9g85KGmvN = 0);
							zPE8NlAkQF = awaiter;
							Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0184;
						IL_05c1:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_0343:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_08fb:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_02ae:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_068f:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_022a:
						RgohxL7UjTqAbA8ZEPB.D35lls5iF(obj2 as SeriesViewModel, obj.JWfZoQwfgB, RgohxL7UjTqAbA8ZEPB.Ylv7cempRo);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj2 as SeriesViewModel, OYihPsCZ1OyLa5m4TD0.yWt7MSAflM), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (u9g85KGmvN = 2);
							zPE8NlAkQF = awaiter;
							Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02ae;
						IL_0195:
						RgohxL7UjTqAbA8ZEPB.D35lls5iF(obj2 as MoviesViewModel, obj.JWfZoQwfgB, RgohxL7UjTqAbA8ZEPB.MFf7V8DhcT);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj2 as MoviesViewModel, OYihPsCZ1OyLa5m4TD0.EmY77mTlxm), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (u9g85KGmvN = 1);
							zPE8NlAkQF = awaiter;
							Hco8uMU36p.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0219;
						IL_0184:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
						IL_075d:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto end_IL_0015;
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					end_IL_0015:;
				}
				catch (Exception ex)
				{
					u9g85KGmvN = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Hco8uMU36p, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				u9g85KGmvN = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Hco8uMU36p, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Hco8uMU36p, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public HomeViewModel ycWZHjMh4p;

		public string JWfZoQwfgB;

		public _003C_003Ec__DisplayClass29_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(DttrZ9aLj7yPObxqeN))]
		internal void iFuZrAaHxI()
		{
			DttrZ9aLj7yPObxqeN stateMachine = default(DttrZ9aLj7yPObxqeN);
			stateMachine.Hco8uMU36p = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.Rug8Aat9Pi = this;
			stateMachine.u9g85KGmvN = -1;
			stateMachine.Hco8uMU36p.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct uF7j3w0ptwbHQiV2a9 : IAsyncStateMachine
		{
			public int VhB8Muvd5R;

			public AsyncTaskMethodBuilder u3A8CrX5VB;

			public _003C_003Ec__DisplayClass50_0 YDs8YxHIJi;

			private TaskAwaiter wQ28Fg32Dp;

			private void MoveNext()
			{
				int num = VhB8Muvd5R;
				_003C_003Ec__DisplayClass50_0 obj = YDs8YxHIJi;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = wQ28Fg32Dp;
						wQ28Fg32Dp = default(TaskAwaiter);
						num = (VhB8Muvd5R = -1);
						goto IL_0256;
					}
					if (obj.NZhtjat55E != null && Ls4UvyBjyH8eI5XR23L.D35lls5iF(obj.NZhtjat55E, Ls4UvyBjyH8eI5XR23L.O8uByT0POb) == ApplicationPage.Login)
					{
						MainViewModel mainViewModel = AppContainer.Resolve<MainViewModel>();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), KBhlAv9D2TgBJ1kkc0B.ele7Frmq0T);
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), KBhlAv9D2TgBJ1kkc0B.ele7Frmq0T);
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14656, iFZ5je3XFYKwkvcE5D.N06TeK0ao), KBhlAv9D2TgBJ1kkc0B.ele7Frmq0T);
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14684, iFZ5je3XFYKwkvcE5D.N06TeK0ao), KBhlAv9D2TgBJ1kkc0B.ele7Frmq0T);
						TVpHI5w25Coc6cqCLM9.D35lls5iF(mainViewModel, ApplicationPage.Login, AppContainer.Resolve<LoginViewModel>(), TVpHI5w25Coc6cqCLM9.cqo72VAfpH);
					}
					else if (obj.NZhtjat55E != null && Ls4UvyBjyH8eI5XR23L.D35lls5iF(obj.NZhtjat55E, Ls4UvyBjyH8eI5XR23L.O8uByT0POb) != ApplicationPage.NullPage && Ad8NmsHKMDNoqEDFjtJ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(obj.c9ptcfo7xK, Xlypb0Hnr2C3ydrYEdG.tG8wg4ah0E), RAspAbuaTQFU0nSRiQ.u5F1dXRFmB) as Page, RAspAbuaTQFU0nSRiQ.UVfHSpoUCc) as BasePage, Ad8NmsHKMDNoqEDFjtJ.ljhHNvS1WJ) != Ls4UvyBjyH8eI5XR23L.D35lls5iF(obj.NZhtjat55E, Ls4UvyBjyH8eI5XR23L.O8uByT0POb))
					{
						Page page = new Page();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(Ls4UvyBjyH8eI5XR23L.D35lls5iF(obj.c9ptcfo7xK.ylLDS7jG67, Ls4UvyBjyH8eI5XR23L.O8uByT0POb), null, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
						qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(Ls4UvyBjyH8eI5XR23L.D35lls5iF(obj.c9ptcfo7xK.ylLDS7jG67, Ls4UvyBjyH8eI5XR23L.O8uByT0POb), EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
						Page page2 = page;
						GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(obj.c9ptcfo7xK, Xlypb0Hnr2C3ydrYEdG.tG8wg4ah0E), page2, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(100, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (VhB8Muvd5R = 0);
							wQ28Fg32Dp = awaiter;
							u3A8CrX5VB.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0256;
					}
					goto end_IL_0015;
					IL_0256:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					end_IL_0015:;
				}
				catch (Exception ex)
				{
					VhB8Muvd5R = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref u3A8CrX5VB, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				VhB8Muvd5R = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref u3A8CrX5VB, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref u3A8CrX5VB, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct IiZkqUGT84PpNKWHyv : IAsyncStateMachine
		{
			public int nxN869DZt8;

			public AsyncVoidMethodBuilder vDL8sNi2rM;

			public _003C_003Ec__DisplayClass50_0 dXo8xqNMmM;

			private TaskAwaiter ETY8yB9ItM;

			private void MoveNext()
			{
				int num = nxN869DZt8;
				_003C_003Ec__DisplayClass50_0 CS_0024_003C_003E8__locals3 = dXo8xqNMmM;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.c9ptcfo7xK, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.c9ptcfo7xK, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(HomeViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(uF7j3w0ptwbHQiV2a9))] () =>
						{
							uF7j3w0ptwbHQiV2a9 stateMachine = default(uF7j3w0ptwbHQiV2a9);
							stateMachine.u3A8CrX5VB = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.YDs8YxHIJi = CS_0024_003C_003E8__locals3;
							stateMachine.VhB8Muvd5R = -1;
							stateMachine.u3A8CrX5VB.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.u3A8CrX5VB, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (nxN869DZt8 = 0);
							ETY8yB9ItM = awaiter;
							vDL8sNi2rM.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = ETY8yB9ItM;
						ETY8yB9ItM = default(TaskAwaiter);
						num = (nxN869DZt8 = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					nxN869DZt8 = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref vDL8sNi2rM, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				nxN869DZt8 = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref vDL8sNi2rM, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref vDL8sNi2rM, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public HomeViewModel c9ptcfo7xK;

		public BarItemViewModel NZhtjat55E;

		public Func<Task> cIitvRfCuV;

		public _003C_003Ec__DisplayClass50_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(IiZkqUGT84PpNKWHyv))]
		internal void FTIZ2Q1shQ()
		{
			IiZkqUGT84PpNKWHyv stateMachine = default(IiZkqUGT84PpNKWHyv);
			stateMachine.vDL8sNi2rM = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.dXo8xqNMmM = this;
			stateMachine.nxN869DZt8 = -1;
			stateMachine.vDL8sNi2rM.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(uF7j3w0ptwbHQiV2a9))]
		internal Task bBjZzLUGvs()
		{
			uF7j3w0ptwbHQiV2a9 stateMachine = default(uF7j3w0ptwbHQiV2a9);
			stateMachine.u3A8CrX5VB = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.YDs8YxHIJi = this;
			stateMachine.VhB8Muvd5R = -1;
			stateMachine.u3A8CrX5VB.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.u3A8CrX5VB, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnGoToHomeCommandExcute_003Ed__74 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HomeViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HomeViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(HomeViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003COnGoToHomeCommandExcute_003Eb__74_1_003Ed))] () =>
					{
						_003C_003COnGoToHomeCommandExcute_003Eb__74_1_003Ed stateMachine = default(_003C_003COnGoToHomeCommandExcute_003Eb__74_1_003Ed);
						stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals3;
						stateMachine._003C_003E1__state = -1;
						stateMachine._003C_003Et__builder.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
					}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
				return;
			}
			_003C_003E1__state = -2;
			meFicnAMHIVtdhf671p.D35lls5iF(ref _003C_003Et__builder, meFicnAMHIVtdhf671p.bsDASenQ5I);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			vxBFJcAKZoecNtbdqxt.D35lls5iF(ref _003C_003Et__builder, stateMachine, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003COnGoToHomeCommandExcute_003Eb__74_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HomeViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HomeViewModel homeViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00f5;
				}
				if (LsA6RHpKkbdnOn3fX60.D35lls5iF(RfcL6vwujiQ4fIgKavw.D35lls5iF(homeViewModel, RfcL6vwujiQ4fIgKavw.ivKwPPCVxQ), LsA6RHpKkbdnOn3fX60.hmbws5vf5K) || LsA6RHpKkbdnOn3fX60.D35lls5iF(RfcL6vwujiQ4fIgKavw.D35lls5iF(homeViewModel, RfcL6vwujiQ4fIgKavw.ivKwPPCVxQ), LsA6RHpKkbdnOn3fX60.O45whakfsT))
				{
					for (JournalEntry journalEntry = nl3rY1wx1TW2DGoen1u.D35lls5iF(RfcL6vwujiQ4fIgKavw.D35lls5iF(homeViewModel, RfcL6vwujiQ4fIgKavw.ivKwPPCVxQ), nl3rY1wx1TW2DGoen1u.r12wYF8uRm); journalEntry != null; journalEntry = nl3rY1wx1TW2DGoen1u.D35lls5iF(RfcL6vwujiQ4fIgKavw.D35lls5iF(homeViewModel, RfcL6vwujiQ4fIgKavw.ivKwPPCVxQ), nl3rY1wx1TW2DGoen1u.r12wYF8uRm))
					{
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(100, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00f5;
				}
				goto end_IL_0015;
				IL_00f5:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				Page page = new Page();
				KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.LogoPage, null, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
				qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.LogoPage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
				Page page2 = page;
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(homeViewModel, Xlypb0Hnr2C3ydrYEdG.tG8wg4ah0E), page2, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				end_IL_0015:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
				return;
			}
			_003C_003E1__state = -2;
			meFicnAMHIVtdhf671p.D35lls5iF(ref _003C_003Et__builder, meFicnAMHIVtdhf671p.bsDASenQ5I);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			vxBFJcAKZoecNtbdqxt.D35lls5iF(ref _003C_003Et__builder, stateMachine, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private string r6PDVCGSJB;

	private string zrwDasATau;

	private string GT4D0qauLN;

	private bool YAEDGsq5SU;

	private bool PiODTyh4p8;

	private bool wguDZySdvl;

	private List<BarItemViewModel> dnbDtVgTfN;

	private BarItemViewModel ylLDS7jG67;

	private bool nqGDfLNrYn;

	private readonly IStoreContext wXODKHkaRI;

	private readonly IAppService eCFDkkWFDb;

	[CompilerGenerated]
	private string BG3D8kNiun;

	[CompilerGenerated]
	private NavigationService oBWDQaJggG;

	private MainPlayerViewModel yI3DnTx5Tx;

	[CompilerGenerated]
	private List<GalleryImageResponseDto> adiDbr1STk;

	[CompilerGenerated]
	private ICommand xN1D7lw4pO;

	[CompilerGenerated]
	private ICommand rXtD55RB5B;

	[CompilerGenerated]
	private NavigationService siJDujhov2;

	[CompilerGenerated]
	private Frame HlRDAN52r1;

	public string Client
	{
		[CompilerGenerated]
		get
		{
			return BG3D8kNiun;
		}
		[CompilerGenerated]
		set
		{
			BG3D8kNiun = value;
		}
	}

	public string ConnectionStatus
	{
		get
		{
			return r6PDVCGSJB;
		}
		set
		{
			SetProperty(ref r6PDVCGSJB, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8696, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool SearchWindowVisibility
	{
		get
		{
			return YAEDGsq5SU;
		}
		set
		{
			SetProperty(ref YAEDGsq5SU, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8732, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool NavigationWindowVisibility
	{
		get
		{
			return PiODTyh4p8;
		}
		set
		{
			SetProperty(ref PiODTyh4p8, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8780, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool MiniPlayerWindowVisibility
	{
		get
		{
			return wguDZySdvl;
		}
		set
		{
			SetProperty(ref wguDZySdvl, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8836, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public string SearchText
	{
		get
		{
			return GT4D0qauLN;
		}
		set
		{
			_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass29_0();
			CS_0024_003C_003E8__locals4.ycWZHjMh4p = this;
			CS_0024_003C_003E8__locals4.JWfZoQwfgB = value;
			SetProperty(ref GT4D0qauLN, CS_0024_003C_003E8__locals4.JWfZoQwfgB, iFZ5je3XFYKwkvcE5D.D35lls5iF(8892, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass29_0.DttrZ9aLj7yPObxqeN))] () =>
			{
				_003C_003Ec__DisplayClass29_0.DttrZ9aLj7yPObxqeN stateMachine = default(_003C_003Ec__DisplayClass29_0.DttrZ9aLj7yPObxqeN);
				stateMachine.Hco8uMU36p = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.Rug8Aat9Pi = CS_0024_003C_003E8__locals4;
				stateMachine.u9g85KGmvN = -1;
				stateMachine.Hco8uMU36p.Start(ref stateMachine);
			});
		}
	}

	public NavigationService FFMEViewModel
	{
		[CompilerGenerated]
		get
		{
			return oBWDQaJggG;
		}
		[CompilerGenerated]
		internal set
		{
			oBWDQaJggG = value;
		}
	}

	public string LogoImage
	{
		get
		{
			return zrwDasATau;
		}
		set
		{
			SetProperty(ref zrwDasATau, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8916, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
			});
		}
	}

	public MainPlayerViewModel MainPlayer
	{
		get
		{
			return yI3DnTx5Tx;
		}
		set
		{
			SetProperty(ref yI3DnTx5Tx, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8938, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public List<BarItemViewModel> BarItems
	{
		get
		{
			return dnbDtVgTfN;
		}
		set
		{
			SetProperty(ref dnbDtVgTfN, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8962, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
			});
		}
	}

	public List<GalleryImageResponseDto> Images
	{
		[CompilerGenerated]
		get
		{
			return adiDbr1STk;
		}
		[CompilerGenerated]
		private set
		{
			adiDbr1STk = value;
		}
	}

	public BarItemViewModel SelectedBarItem
	{
		get
		{
			return ylLDS7jG67;
		}
		set
		{
			_003C_003Ec__DisplayClass50_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass50_0();
			CS_0024_003C_003E8__locals4.c9ptcfo7xK = this;
			CS_0024_003C_003E8__locals4.NZhtjat55E = value;
			SetProperty(ref ylLDS7jG67, CS_0024_003C_003E8__locals4.NZhtjat55E, iFZ5je3XFYKwkvcE5D.D35lls5iF(8982, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass50_0.IiZkqUGT84PpNKWHyv))] () =>
			{
				_003C_003Ec__DisplayClass50_0.IiZkqUGT84PpNKWHyv stateMachine = default(_003C_003Ec__DisplayClass50_0.IiZkqUGT84PpNKWHyv);
				stateMachine.vDL8sNi2rM = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.dXo8xqNMmM = CS_0024_003C_003E8__locals4;
				stateMachine.nxN869DZt8 = -1;
				stateMachine.vDL8sNi2rM.Start(ref stateMachine);
			});
		}
	}

	public ICommand GoToHomeCommand
	{
		[CompilerGenerated]
		get
		{
			return xN1D7lw4pO;
		}
		[CompilerGenerated]
		set
		{
			xN1D7lw4pO = value;
		}
	}

	public ICommand SearchCommand
	{
		[CompilerGenerated]
		get
		{
			return rXtD55RB5B;
		}
		[CompilerGenerated]
		set
		{
			rXtD55RB5B = value;
		}
	}

	public NavigationService Navigation
	{
		[CompilerGenerated]
		get
		{
			return siJDujhov2;
		}
		[CompilerGenerated]
		internal set
		{
			siJDujhov2 = value;
		}
	}

	public Frame Frame
	{
		[CompilerGenerated]
		get
		{
			return HlRDAN52r1;
		}
		[CompilerGenerated]
		set
		{
			HlRDAN52r1 = value;
		}
	}

	public bool ShowBarItemsPanel
	{
		get
		{
			return nqGDfLNrYn;
		}
		set
		{
			SetProperty(ref nqGDfLNrYn, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(9016, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
			});
		}
	}

	internal void wy0DvsfwcZ()
	{
		GT4D0qauLN = "";
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8892, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
	}

	internal void tmiDWvacpi(string P_0)
	{
		GT4D0qauLN = P_0;
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8892, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
	}

	public HomeViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		wXODKHkaRI = AppContainer.Resolve<IStoreContext>();
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, wq2usy8gNndpuTw5mR.D35lls5iF(wXODKHkaRI, wq2usy8gNndpuTw5mR.Ef8TjHOTJx), qni3xrDkAJ3vF35eMav.Cb5TyW4ZPe);
		eCFDkkWFDb = AppContainer.Resolve<IAppService>();
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand(wWVDBrPR6Z), Q3OeRSTq6SNsAFQUUoG.NTSTJeu3Br);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate
		{
			xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.HuF4wM3GJW);
		}), Q3OeRSTq6SNsAFQUUoG.W10TbWr3kx);
	}

	private void OMqD4lGXrJ()
	{
	}

	[AsyncStateMachine(typeof(_003COnGoToHomeCommandExcute_003Ed__74))]
	private Task wWVDBrPR6Z()
	{
		_003COnGoToHomeCommandExcute_003Ed__74 stateMachine = default(_003COnGoToHomeCommandExcute_003Ed__74);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		B9uMBHTWOOxTj88ZQNF.D35lls5iF(this, new MainPlayerViewModel(), B9uMBHTWOOxTj88ZQNF.AlqT5UvnMk);
		pyK9koHUJmxk64T5R2W.D35lls5iF(this, pyK9koHUJmxk64T5R2W.jDdTzk5roc)?.Clear();
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, wq2usy8gNndpuTw5mR.D35lls5iF(uDRo1NTTfYDM7pYeNXf.D35lls5iF(wXODKHkaRI, uDRo1NTTfYDM7pYeNXf.vmET4kj87M), wq2usy8gNndpuTw5mR.sPG4oZaAO3), qni3xrDkAJ3vF35eMav.QqL4lsR5mo);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(9054, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		PackageReponseDto packageReponseDto = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		int num;
		if (packageReponseDto == null || hjMnupQVVDlRZAYQJC.D35lls5iF(packageReponseDto, hjMnupQVVDlRZAYQJC.bdE4HVikwI))
		{
			PackageReponseDto packageReponseDto2 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
			if (packageReponseDto2 == null || hjMnupQVVDlRZAYQJC.D35lls5iF(packageReponseDto2, hjMnupQVVDlRZAYQJC.rYY412NNIQ))
			{
				PackageReponseDto packageReponseDto3 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
				if (packageReponseDto3 == null || uEUVCI48fycroqgRFqy.D35lls5iF(packageReponseDto3, uEUVCI48fycroqgRFqy.S8u4nXFMlI))
				{
					PackageReponseDto packageReponseDto4 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
					num = ((packageReponseDto4 == null || uEUVCI48fycroqgRFqy.D35lls5iF(packageReponseDto4, uEUVCI48fycroqgRFqy.fgm43JbDTy)) ? 1 : 0);
					goto IL_0123;
				}
			}
		}
		num = 0;
		goto IL_0123;
		IL_0123:
		bool flag = (byte)num != 0;
		List<BarItemViewModel> list = new List<BarItemViewModel>();
		BarItemViewModel barItemViewModel = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(9070, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		PackageReponseDto packageReponseDto5 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel, packageReponseDto5 == null || uEUVCI48fycroqgRFqy.D35lls5iF(packageReponseDto5, uEUVCI48fycroqgRFqy.Dhw44JGnlM), QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(9082, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel, ApplicationPage.TVShowPage, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel);
		BarItemViewModel barItemViewModel2 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel2, iFZ5je3XFYKwkvcE5D.D35lls5iF(9132, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel2, flag, QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel2, iFZ5je3XFYKwkvcE5D.D35lls5iF(9162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel2, ApplicationPage.MyMoviePage, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel2);
		BarItemViewModel barItemViewModel3 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel3, iFZ5je3XFYKwkvcE5D.D35lls5iF(9234, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		PackageReponseDto packageReponseDto6 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel3, packageReponseDto6 == null || hjMnupQVVDlRZAYQJC.D35lls5iF(packageReponseDto6, hjMnupQVVDlRZAYQJC.bdE4HVikwI), QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel3, iFZ5je3XFYKwkvcE5D.D35lls5iF(9250, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel3, ApplicationPage.Movies, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel3);
		BarItemViewModel barItemViewModel4 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel4, iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		PackageReponseDto packageReponseDto7 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel4, packageReponseDto7 == null || hjMnupQVVDlRZAYQJC.D35lls5iF(packageReponseDto7, hjMnupQVVDlRZAYQJC.rYY412NNIQ), QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel4, iFZ5je3XFYKwkvcE5D.D35lls5iF(9324, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel4, ApplicationPage.Series, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel4);
		BarItemViewModel barItemViewModel5 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel5, iFZ5je3XFYKwkvcE5D.D35lls5iF(9382, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		PackageReponseDto packageReponseDto8 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel5, packageReponseDto8 == null || uEUVCI48fycroqgRFqy.D35lls5iF(packageReponseDto8, uEUVCI48fycroqgRFqy.S8u4nXFMlI), QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel5, iFZ5je3XFYKwkvcE5D.D35lls5iF(9396, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel5, ApplicationPage.MusicPage, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel5);
		BarItemViewModel barItemViewModel6 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel6, iFZ5je3XFYKwkvcE5D.D35lls5iF(9452, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		PackageReponseDto packageReponseDto9 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel6, packageReponseDto9 == null || uEUVCI48fycroqgRFqy.D35lls5iF(packageReponseDto9, uEUVCI48fycroqgRFqy.fgm43JbDTy), QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel6, iFZ5je3XFYKwkvcE5D.D35lls5iF(9466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel6, ApplicationPage.ShowPage, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel6);
		BarItemViewModel barItemViewModel7 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel7, iFZ5je3XFYKwkvcE5D.D35lls5iF(9544, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		PackageReponseDto packageReponseDto10 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel7, packageReponseDto10 == null || uEUVCI48fycroqgRFqy.D35lls5iF(packageReponseDto10, uEUVCI48fycroqgRFqy.A074rZCkoq), QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel7, iFZ5je3XFYKwkvcE5D.D35lls5iF(9562, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel7, ApplicationPage.Youtube, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel7);
		BarItemViewModel barItemViewModel8 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel8, iFZ5je3XFYKwkvcE5D.D35lls5iF(9622, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		PackageReponseDto packageReponseDto11 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel8, packageReponseDto11 == null || uEUVCI48fycroqgRFqy.D35lls5iF(packageReponseDto11, uEUVCI48fycroqgRFqy.ox24ei7tD2), QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel8, iFZ5je3XFYKwkvcE5D.D35lls5iF(9636, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel8, ApplicationPage.Quran, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel8);
		BarItemViewModel barItemViewModel9 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel9, iFZ5je3XFYKwkvcE5D.D35lls5iF(9692, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		PackageReponseDto packageReponseDto12 = Yvn1Up49INfjZEB4hak.D35lls5iF(wXODKHkaRI, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel9, packageReponseDto12 == null || uEUVCI48fycroqgRFqy.D35lls5iF(packageReponseDto12, uEUVCI48fycroqgRFqy.rnZ4G0XALm), QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel9, iFZ5je3XFYKwkvcE5D.D35lls5iF(9706, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel9, ApplicationPage.RadioPage, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel9);
		BarItemViewModel barItemViewModel10 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel10, iFZ5je3XFYKwkvcE5D.D35lls5iF(9762, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel10, true, QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel10, iFZ5je3XFYKwkvcE5D.D35lls5iF(9780, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel10, ApplicationPage.ProfilePage, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel10);
		BarItemViewModel barItemViewModel11 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel11, iFZ5je3XFYKwkvcE5D.D35lls5iF(9840, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel11, true, QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel11, iFZ5je3XFYKwkvcE5D.D35lls5iF(9856, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel11, ApplicationPage.Login, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel11);
		BarItemViewModel barItemViewModel12 = new BarItemViewModel();
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel12, iFZ5je3XFYKwkvcE5D.D35lls5iF(9914, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.nJP4TXUF1x);
		QnJnl7fVDKI4mA6voc.D35lls5iF(barItemViewModel12, false, QnJnl7fVDKI4mA6voc.FXm4L2VRqq);
		qni3xrDkAJ3vF35eMav.D35lls5iF(barItemViewModel12, iFZ5je3XFYKwkvcE5D.D35lls5iF(9082, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.K3A4E0xMye);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(barItemViewModel12, ApplicationPage.NullPage, vQwwBH4ByM2YpSoWyIi.CNv40J8fLD);
		list.Add(barItemViewModel12);
		iVr9oS4RKkl66C491Wk.D35lls5iF(this, list, iVr9oS4RKkl66C491Wk.f2X4kwANNU);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(wXODKHkaRI, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), wq2usy8gNndpuTw5mR.D35lls5iF(P1dNdd4vZAyspU1imjK.D35lls5iF(wXODKHkaRI, P1dNdd4vZAyspU1imjK.h1T4AkEL6W), wq2usy8gNndpuTw5mR.Kpt466B1yb), d27jrd3uD0dgsTkvn8k.fC53Pw5IkY), qni3xrDkAJ3vF35eMav.qne4pfR5a4);
	}

	[CompilerGenerated]
	private void G6rDDSWIcZ(object P_0)
	{
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.HuF4wM3GJW);
	}

	[AsyncStateMachine(typeof(_003C_003COnGoToHomeCommandExcute_003Eb__74_1_003Ed))]
	[CompilerGenerated]
	private Task MhwDdd0ZKZ()
	{
		_003C_003COnGoToHomeCommandExcute_003Eb__74_1_003Ed stateMachine = default(_003C_003COnGoToHomeCommandExcute_003Eb__74_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
