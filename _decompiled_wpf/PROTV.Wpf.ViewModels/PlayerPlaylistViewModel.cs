using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Unosquare.FFME;

namespace PROTV.Wpf.ViewModels;

public class PlayerPlaylistViewModel<T> : AttachedViewModel<T> where T : new()
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public PlayerPlaylistViewModel<T> _003C_003E4__this;

		public T value;

		public _003C_003Ec__DisplayClass7_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void WxMSJDqXPU()
		{
			_003C_003E4__this.Root.OnOpenCommandExcuteAsync(value);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public PlayerPlaylistViewModel<T> _003C_003E4__this;

		public MediaElement m;

		public _003C_003Ec__DisplayClass21_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void G5LSh8FFNS()
		{
			_003C_003E4__this.IsPlaylistEnabled = !LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv);
		}
	}

	private T r3AqlAgFAM;

	private bool SvSqUTdFWx;

	[CompilerGenerated]
	private ObservableCollection<T> qHxqLe4vq9;

	[CompilerGenerated]
	private ObservableCollection<T> cPvq296DM4;

	[CompilerGenerated]
	private ObservableCollection<T> ow6qzbl9jb;

	public bool IsPlaylistEnabled
	{
		get
		{
			return SvSqUTdFWx;
		}
		set
		{
			SetProperty(ref SvSqUTdFWx, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8302, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public T SelectedItem
	{
		get
		{
			return r3AqlAgFAM;
		}
		set
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals5._003C_003E4__this = this;
			CS_0024_003C_003E8__locals5.value = value;
			SetProperty(ref r3AqlAgFAM, CS_0024_003C_003E8__locals5.value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				CS_0024_003C_003E8__locals5._003C_003E4__this.Root.OnOpenCommandExcuteAsync(CS_0024_003C_003E8__locals5.value);
			});
		}
	}

	public ObservableCollection<T> Items
	{
		[CompilerGenerated]
		get
		{
			return qHxqLe4vq9;
		}
		[CompilerGenerated]
		set
		{
			qHxqLe4vq9 = value;
		}
	}

	public ObservableCollection<T> ViewItems
	{
		[CompilerGenerated]
		get
		{
			return cPvq296DM4;
		}
		[CompilerGenerated]
		set
		{
			cPvq296DM4 = value;
		}
	}

	public ObservableCollection<T> RandomizItems
	{
		[CompilerGenerated]
		get
		{
			return ow6qzbl9jb;
		}
		[CompilerGenerated]
		set
		{
			ow6qzbl9jb = value;
		}
	}

	public PlayerPlaylistViewModel(FFMEBaseViewModel<T> model)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		SvSqUTdFWx = true;
		base._002Ector(model);
		Items = new ObservableCollection<T>();
		RandomizItems = new ObservableCollection<T>();
		ViewItems = new ObservableCollection<T>();
	}

	public override void OnApplicationLoaded()
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals5._003C_003E4__this = this;
		CS_0024_003C_003E8__locals5.m = base.Root.MediaElement;
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals5._003C_003E4__this.IsPlaylistEnabled = !LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals5.m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv);
		}, CS_0024_003C_003E8__locals5.m, new string[1] { iFZ5je3XFYKwkvcE5D.D35lls5iF(7996, iFZ5je3XFYKwkvcE5D.N06TeK0ao) }, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
	}
}
