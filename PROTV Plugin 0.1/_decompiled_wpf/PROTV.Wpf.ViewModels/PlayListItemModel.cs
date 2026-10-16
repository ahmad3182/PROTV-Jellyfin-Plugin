using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class PlayListItemModel<T> : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct TVZH0mRayVIuyIEMQG : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass9_0 _003C_003E4__this;

			private TaskAwaiter<Response<string>> _003C_003Eu__1;

			private void MoveNext()
			{
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass9_0 obj = _003C_003E4__this;
				try
				{
					_ = 1;
					try
					{
						TaskAwaiter<Response<string>> awaiter;
						if (num == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Response<string>>);
							num = (_003C_003E1__state = -1);
							goto IL_00c8;
						}
						if (num == 1)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Response<string>>);
							num = (_003C_003E1__state = -1);
							goto IL_01a1;
						}
						if (!obj.value)
						{
							awaiter = q0O3arc8jfLgcgyMrcw.D35lls5iF(obj._003C_003E4__this.triPEanUaM, obj._003C_003E4__this.MediaId, obj._003C_003E4__this.PlayList.Id, q0O3arc8jfLgcgyMrcw.rSac33aHEX).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01a1;
						}
						if (obj._003C_003E4__this.MediaId != 0)
						{
							awaiter = q0O3arc8jfLgcgyMrcw.D35lls5iF(obj._003C_003E4__this.triPEanUaM, obj._003C_003E4__this.MediaId, obj._003C_003E4__this.PlayList.Id, q0O3arc8jfLgcgyMrcw.W4ccnetVti).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00c8;
						}
						goto end_IL_001a;
						IL_00c8:
						if (awaiter.GetResult().Status)
						{
							S2TLVumHJ5aeKRPsMnq.D35lls5iF(obj._003C_003E4__this.Media, S2TLVumHJ5aeKRPsMnq.lkSm1NMjdP).Add(obj._003C_003E4__this.PlayList.Id);
							obj._003C_003E4__this.Count = obj._003C_003E4__this.Count + 1;
						}
						goto end_IL_001a;
						IL_01a1:
						if (awaiter.GetResult().Status)
						{
							S2TLVumHJ5aeKRPsMnq.D35lls5iF(obj._003C_003E4__this.Media, S2TLVumHJ5aeKRPsMnq.lkSm1NMjdP).Remove(obj._003C_003E4__this.PlayList.Id);
							obj._003C_003E4__this.Count = obj._003C_003E4__this.Count - 1;
						}
						end_IL_001a:;
					}
					catch
					{
					}
				}
				catch (Exception ex)
				{
					_003C_003E1__state = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				_003C_003E1__state = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref _003C_003Et__builder, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref _003C_003Et__builder, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public bool value;

		public PlayListItemModel<T> _003C_003E4__this;

		public _003C_003Ec__DisplayClass9_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(PlayListItemModel<>._003C_003Ec__DisplayClass9_0.TVZH0mRayVIuyIEMQG))]
		internal void oFVS5m9V1e()
		{
			TVZH0mRayVIuyIEMQG stateMachine = default(TVZH0mRayVIuyIEMQG);
			stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine._003C_003E4__this = this;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
		}
	}

	private readonly IPlaylistService triPEanUaM;

	private PlaylistResponseDto<T> K3vP9Hi0hx;

	internal bool HhGPenc8f1;

	private ImageSource pJePOx3g8a;

	private int K1MPrudpK8;

	private int A1PPHP0usN;

	private SongResponseDto BFjPor2TCO;

	public PlaylistResponseDto<T> PlayList
	{
		get
		{
			return K3vP9Hi0hx;
		}
		set
		{
			SetProperty(ref K3vP9Hi0hx, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10628, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				Count = arHqIuLQE32UGutIac7.D35lls5iF(PlayList.ItemsCount, arHqIuLQE32UGutIac7.Fa2LXljLFk);
			});
		}
	}

	public bool IsChecked
	{
		get
		{
			return HhGPenc8f1;
		}
		set
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals4.value = value;
			CS_0024_003C_003E8__locals4._003C_003E4__this = this;
			SetProperty(ref HhGPenc8f1, CS_0024_003C_003E8__locals4.value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10648, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(PlayListItemModel<>._003C_003Ec__DisplayClass9_0.TVZH0mRayVIuyIEMQG))] () =>
			{
				_003C_003Ec__DisplayClass9_0.TVZH0mRayVIuyIEMQG stateMachine = default(_003C_003Ec__DisplayClass9_0.TVZH0mRayVIuyIEMQG);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals4;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public ImageSource Poster
	{
		get
		{
			return pJePOx3g8a;
		}
		set
		{
			SetProperty(ref pJePOx3g8a, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(1046, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public int MediaId
	{
		get
		{
			return K1MPrudpK8;
		}
		set
		{
			SetProperty(ref K1MPrudpK8, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10670, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public int Count
	{
		get
		{
			return A1PPHP0usN;
		}
		set
		{
			SetProperty(ref A1PPHP0usN, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10688, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public SongResponseDto Media
	{
		get
		{
			return BFjPor2TCO;
		}
		set
		{
			SetProperty(ref BFjPor2TCO, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10702, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public PlayListItemModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		triPEanUaM = AppContainer.Resolve<IPlaylistService>();
	}

	[CompilerGenerated]
	private void r1iPwuUqhD()
	{
		Count = arHqIuLQE32UGutIac7.D35lls5iF(PlayList.ItemsCount, arHqIuLQE32UGutIac7.Fa2LXljLFk);
	}
}
