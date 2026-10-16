using System;
using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PROTV.Wpf.Helpers;

public class Image : System.Windows.Controls.Image
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CImageUrlPropertyChanged_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DependencyPropertyChangedEventArgs e;

		public DependencyObject obj;

		private string _003Curl_003E5__2;

		private Image _003CcachedImage_003E5__3;

		private BitmapImage _003CbitmapImage_003E5__4;

		private TaskAwaiter<MemoryStream> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num == 0)
				{
					goto IL_010f;
				}
				_003Curl_003E5__2 = kO8WlprtJQWYYRfm8Ps.D35lls5iF(ref e, kO8WlprtJQWYYRfm8Ps.v81rV7KHVP) as string;
				if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(_003Curl_003E5__2, M6ZErPEr2LZyWYpa5O.tZ53SRMKfw))
				{
					_003CcachedImage_003E5__3 = (Image)(object)this.obj;
					_003CbitmapImage_003E5__4 = new BitmapImage();
					switch (WS4FJ5VddWBU0Yo98BN.D35lls5iF(WS4FJ5VddWBU0Yo98BN.OArVUHQryu))
					{
					case FileCache.CacheMode.WinINet:
						YIm9yctLBn23GQIH06k.D35lls5iF(_003CbitmapImage_003E5__4, YIm9yctLBn23GQIH06k.JMMVtlIhRF);
						q1Tr4JVcpi32kXPINLU.D35lls5iF(_003CbitmapImage_003E5__4, wOYA5cVVDRT1p2TLaiB.D35lls5iF(_003CcachedImage_003E5__3, wOYA5cVVDRT1p2TLaiB.XbFV7hgv1o), q1Tr4JVcpi32kXPINLU.yXqVMEnURJ);
						pXNQrAVS3EjnBXf6YOO.D35lls5iF(_003CbitmapImage_003E5__4, new Uri(_003Curl_003E5__2), pXNQrAVS3EjnBXf6YOO.QX6VKeNbaM);
						buBcx3VNds4Ekpo9nIL.D35lls5iF(_003CbitmapImage_003E5__4, new RequestCachePolicy(RequestCacheLevel.Default), buBcx3VNds4Ekpo9nIL.F1DVOJNJmm);
						YIm9yctLBn23GQIH06k.D35lls5iF(_003CbitmapImage_003E5__4, YIm9yctLBn23GQIH06k.URcVuM31xy);
						HA9xp31qTso7BFFbOAp.D35lls5iF(_003CcachedImage_003E5__3, _003CbitmapImage_003E5__4, HA9xp31qTso7BFFbOAp.ak51JUGhyn);
						goto end_IL_000e;
					case FileCache.CacheMode.Dedicated:
						break;
					default:
						throw new ArgumentOutOfRangeException();
					}
					goto IL_010f;
				}
				goto end_IL_000e;
				IL_010f:
				try
				{
					MemoryStream memoryStream;
					TaskAwaiter<MemoryStream> awaiter;
					if (num != 0)
					{
						memoryStream = null;
						if (VMs7lU9URBMKdJRC1h1.D35lls5iF(_003Curl_003E5__2, iFZ5je3XFYKwkvcE5D.D35lls5iF(16998, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1))
						{
							goto IL_01a4;
						}
						awaiter = SJd7PJdZd6ObcySHIoO.D35lls5iF(_003Curl_003E5__2, SJd7PJdZd6ObcySHIoO.dCfdjKg5IF).GetAwaiter();
						if (!awaiter.IsCompleted)
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
						_003C_003Eu__1 = default(TaskAwaiter<MemoryStream>);
						num = (_003C_003E1__state = -1);
					}
					memoryStream = awaiter.GetResult();
					goto IL_01a4;
					IL_01a4:
					if (VMs7lU9URBMKdJRC1h1.D35lls5iF(_003Curl_003E5__2, iFZ5je3XFYKwkvcE5D.D35lls5iF(16998, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1) || memoryStream != null)
					{
						YIm9yctLBn23GQIH06k.D35lls5iF(_003CbitmapImage_003E5__4, YIm9yctLBn23GQIH06k.JMMVtlIhRF);
						q1Tr4JVcpi32kXPINLU.D35lls5iF(_003CbitmapImage_003E5__4, wOYA5cVVDRT1p2TLaiB.D35lls5iF(_003CcachedImage_003E5__3, wOYA5cVVDRT1p2TLaiB.XbFV7hgv1o), q1Tr4JVcpi32kXPINLU.yXqVMEnURJ);
						bgqGYyVPdExA3PhJFTM.D35lls5iF(_003CbitmapImage_003E5__4, BitmapCacheOption.OnLoad, bgqGYyVPdExA3PhJFTM.STiVsDcm8W);
						if (memoryStream != null)
						{
							BCVA5MVhvLixFTvjpbw.D35lls5iF(_003CbitmapImage_003E5__4, memoryStream, BCVA5MVhvLixFTvjpbw.Em7Vx4do2G);
						}
						else
						{
							pXNQrAVS3EjnBXf6YOO.D35lls5iF(_003CbitmapImage_003E5__4, new Uri(_003Curl_003E5__2), pXNQrAVS3EjnBXf6YOO.QX6VKeNbaM);
						}
						if (V4VMaWmQYRpUqEIxujB.D35lls5iF(_003CcachedImage_003E5__3, V4VMaWmQYRpUqEIxujB.XyEVYHMUDl).HasValue && V4VMaWmQYRpUqEIxujB.D35lls5iF(_003CcachedImage_003E5__3, V4VMaWmQYRpUqEIxujB.XyEVYHMUDl) != 0)
						{
							vQKA0r9sJ1kArsIHc16.D35lls5iF(_003CbitmapImage_003E5__4, V4VMaWmQYRpUqEIxujB.D35lls5iF(_003CcachedImage_003E5__3, V4VMaWmQYRpUqEIxujB.XyEVYHMUDl).Value, vQKA0r9sJ1kArsIHc16.sqmVgVxxLW);
						}
						YIm9yctLBn23GQIH06k.D35lls5iF(_003CbitmapImage_003E5__4, YIm9yctLBn23GQIH06k.URcVuM31xy);
						HA9xp31qTso7BFFbOAp.D35lls5iF(_003CcachedImage_003E5__3, _003CbitmapImage_003E5__4, HA9xp31qTso7BFFbOAp.ak51JUGhyn);
					}
				}
				catch
				{
				}
				end_IL_000e:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				_003Curl_003E5__2 = null;
				_003CcachedImage_003E5__3 = null;
				_003CbitmapImage_003E5__4 = null;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
				return;
			}
			_003C_003E1__state = -2;
			_003Curl_003E5__2 = null;
			_003CcachedImage_003E5__3 = null;
			_003CbitmapImage_003E5__4 = null;
			T4XmPoA4VNJJP1afcgL.D35lls5iF(ref _003C_003Et__builder, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref _003C_003Et__builder, stateMachine, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CImageSizePropertyChanged_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DependencyPropertyChangedEventArgs e;

		public DependencyObject obj;

		private int? _003Csize_003E5__2;

		private Image _003CcachedImage_003E5__3;

		private BitmapImage _003CbitmapImage_003E5__4;

		private TaskAwaiter<MemoryStream> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num == 0)
				{
					goto IL_015d;
				}
				_003Csize_003E5__2 = kO8WlprtJQWYYRfm8Ps.D35lls5iF(ref e, kO8WlprtJQWYYRfm8Ps.v81rV7KHVP) as int?;
				if (_003Csize_003E5__2.HasValue || _003Csize_003E5__2 != 0)
				{
					_003CcachedImage_003E5__3 = (Image)(object)this.obj;
					_003CbitmapImage_003E5__4 = new BitmapImage();
					if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003CcachedImage_003E5__3, eVlRnEIaHT0dqvCx0Kx.O3NVilNGZK), M6ZErPEr2LZyWYpa5O.tZ53SRMKfw))
					{
						switch (WS4FJ5VddWBU0Yo98BN.D35lls5iF(WS4FJ5VddWBU0Yo98BN.OArVUHQryu))
						{
						case FileCache.CacheMode.WinINet:
							YIm9yctLBn23GQIH06k.D35lls5iF(_003CbitmapImage_003E5__4, YIm9yctLBn23GQIH06k.JMMVtlIhRF);
							q1Tr4JVcpi32kXPINLU.D35lls5iF(_003CbitmapImage_003E5__4, wOYA5cVVDRT1p2TLaiB.D35lls5iF(_003CcachedImage_003E5__3, wOYA5cVVDRT1p2TLaiB.XbFV7hgv1o), q1Tr4JVcpi32kXPINLU.yXqVMEnURJ);
							pXNQrAVS3EjnBXf6YOO.D35lls5iF(_003CbitmapImage_003E5__4, new Uri(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003CcachedImage_003E5__3, eVlRnEIaHT0dqvCx0Kx.O3NVilNGZK)), pXNQrAVS3EjnBXf6YOO.QX6VKeNbaM);
							buBcx3VNds4Ekpo9nIL.D35lls5iF(_003CbitmapImage_003E5__4, new RequestCachePolicy(RequestCacheLevel.Default), buBcx3VNds4Ekpo9nIL.F1DVOJNJmm);
							YIm9yctLBn23GQIH06k.D35lls5iF(_003CbitmapImage_003E5__4, YIm9yctLBn23GQIH06k.URcVuM31xy);
							HA9xp31qTso7BFFbOAp.D35lls5iF(_003CcachedImage_003E5__3, _003CbitmapImage_003E5__4, HA9xp31qTso7BFFbOAp.ak51JUGhyn);
							goto end_IL_000e;
						case FileCache.CacheMode.Dedicated:
							break;
						default:
							throw new ArgumentOutOfRangeException();
						}
						goto IL_015d;
					}
				}
				goto end_IL_000e;
				IL_015d:
				try
				{
					MemoryStream memoryStream;
					TaskAwaiter<MemoryStream> awaiter;
					if (num != 0)
					{
						memoryStream = null;
						if (VMs7lU9URBMKdJRC1h1.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003CcachedImage_003E5__3, eVlRnEIaHT0dqvCx0Kx.O3NVilNGZK), iFZ5je3XFYKwkvcE5D.D35lls5iF(16998, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1))
						{
							goto IL_020b;
						}
						awaiter = SJd7PJdZd6ObcySHIoO.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003CcachedImage_003E5__3, eVlRnEIaHT0dqvCx0Kx.O3NVilNGZK), SJd7PJdZd6ObcySHIoO.dCfdjKg5IF).GetAwaiter();
						if (!awaiter.IsCompleted)
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
						_003C_003Eu__1 = default(TaskAwaiter<MemoryStream>);
						num = (_003C_003E1__state = -1);
					}
					memoryStream = awaiter.GetResult();
					goto IL_020b;
					IL_020b:
					if (VMs7lU9URBMKdJRC1h1.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003CcachedImage_003E5__3, eVlRnEIaHT0dqvCx0Kx.O3NVilNGZK), iFZ5je3XFYKwkvcE5D.D35lls5iF(16998, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1) || memoryStream != null)
					{
						YIm9yctLBn23GQIH06k.D35lls5iF(_003CbitmapImage_003E5__4, YIm9yctLBn23GQIH06k.JMMVtlIhRF);
						q1Tr4JVcpi32kXPINLU.D35lls5iF(_003CbitmapImage_003E5__4, wOYA5cVVDRT1p2TLaiB.D35lls5iF(_003CcachedImage_003E5__3, wOYA5cVVDRT1p2TLaiB.XbFV7hgv1o), q1Tr4JVcpi32kXPINLU.yXqVMEnURJ);
						bgqGYyVPdExA3PhJFTM.D35lls5iF(_003CbitmapImage_003E5__4, BitmapCacheOption.OnLoad, bgqGYyVPdExA3PhJFTM.STiVsDcm8W);
						if (memoryStream != null)
						{
							BCVA5MVhvLixFTvjpbw.D35lls5iF(_003CbitmapImage_003E5__4, memoryStream, BCVA5MVhvLixFTvjpbw.Em7Vx4do2G);
						}
						else
						{
							pXNQrAVS3EjnBXf6YOO.D35lls5iF(_003CbitmapImage_003E5__4, new Uri(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003CcachedImage_003E5__3, eVlRnEIaHT0dqvCx0Kx.O3NVilNGZK)), pXNQrAVS3EjnBXf6YOO.QX6VKeNbaM);
						}
						if (_003Csize_003E5__2.HasValue && _003Csize_003E5__2 != 0)
						{
							vQKA0r9sJ1kArsIHc16.D35lls5iF(_003CbitmapImage_003E5__4, V4VMaWmQYRpUqEIxujB.D35lls5iF(_003CcachedImage_003E5__3, V4VMaWmQYRpUqEIxujB.XyEVYHMUDl).Value, vQKA0r9sJ1kArsIHc16.sqmVgVxxLW);
						}
						YIm9yctLBn23GQIH06k.D35lls5iF(_003CbitmapImage_003E5__4, YIm9yctLBn23GQIH06k.URcVuM31xy);
						HA9xp31qTso7BFFbOAp.D35lls5iF(_003CcachedImage_003E5__3, _003CbitmapImage_003E5__4, HA9xp31qTso7BFFbOAp.ak51JUGhyn);
					}
				}
				catch
				{
				}
				end_IL_000e:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				_003CcachedImage_003E5__3 = null;
				_003CbitmapImage_003E5__4 = null;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
				return;
			}
			_003C_003E1__state = -2;
			_003CcachedImage_003E5__3 = null;
			_003CbitmapImage_003E5__4 = null;
			T4XmPoA4VNJJP1afcgL.D35lls5iF(ref _003C_003Et__builder, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref _003C_003Et__builder, stateMachine, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public static readonly DependencyProperty ImageUrlProperty;

	public static readonly DependencyProperty CreateOptionsProperty;

	public static readonly DependencyProperty ImageSizeProperty;

	public int? ImageSize
	{
		get
		{
			return (int?)EmqD3J86gxqLokWBlHc.D35lls5iF(this, ImageSizeProperty, EmqD3J86gxqLokWBlHc.q0W8pLlgXM);
		}
		set
		{
			jsMkaY8wkGDPQeJiaWA.D35lls5iF(this, ImageSizeProperty, value, jsMkaY8wkGDPQeJiaWA.ppe8CdkjEY);
		}
	}

	public string ImageUrl
	{
		get
		{
			return (string)EmqD3J86gxqLokWBlHc.D35lls5iF(this, ImageUrlProperty, EmqD3J86gxqLokWBlHc.q0W8pLlgXM);
		}
		set
		{
			jsMkaY8wkGDPQeJiaWA.D35lls5iF(this, ImageUrlProperty, value, jsMkaY8wkGDPQeJiaWA.ppe8CdkjEY);
		}
	}

	public BitmapCreateOptions CreateOptions
	{
		get
		{
			return (BitmapCreateOptions)EmqD3J86gxqLokWBlHc.D35lls5iF(this, CreateOptionsProperty, EmqD3J86gxqLokWBlHc.q0W8pLlgXM);
		}
		set
		{
			jsMkaY8wkGDPQeJiaWA.D35lls5iF(this, CreateOptionsProperty, value, jsMkaY8wkGDPQeJiaWA.ppe8CdkjEY);
		}
	}

	static Image()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		ImageUrlProperty = BrQfd88PXGwGWbvCv5M.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(14874, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(string).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(Image).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), new PropertyMetadata((object)"", new PropertyChangedCallback(Vc6GERRR5m)), BrQfd88PXGwGWbvCv5M.ped8sxNsq3);
		CreateOptionsProperty = BnMwo0RQh2Q6CeyvlNf.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(14894, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(BitmapCreateOptions).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(Image).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), BnMwo0RQh2Q6CeyvlNf.CFaRXFhRqe);
		ImageSizeProperty = BrQfd88PXGwGWbvCv5M.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(14924, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(int?).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(Image).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), new PropertyMetadata((object)null, new PropertyChangedCallback(aSFG9OjZBC)), BrQfd88PXGwGWbvCv5M.ped8sxNsq3);
		EHeKHbRfI5g8NJ94cDP.D35lls5iF(FrameworkElement.DefaultStyleKeyProperty, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(Image).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), (PropertyMetadata)(object)new FrameworkPropertyMetadata((object)sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(Image).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5)), EHeKHbRfI5g8NJ94cDP.hYHRFlZQtq);
	}

	[AsyncStateMachine(typeof(_003CImageUrlPropertyChanged_003Ed__10))]
	private static void Vc6GERRR5m(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		_003CImageUrlPropertyChanged_003Ed__10 stateMachine = default(_003CImageUrlPropertyChanged_003Ed__10);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine.obj = P_0;
		stateMachine.e = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CImageSizePropertyChanged_003Ed__11))]
	private static void aSFG9OjZBC(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		_003CImageSizePropertyChanged_003Ed__11 stateMachine = default(_003CImageSizePropertyChanged_003Ed__11);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine.obj = P_0;
		stateMachine.e = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	public Image()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
