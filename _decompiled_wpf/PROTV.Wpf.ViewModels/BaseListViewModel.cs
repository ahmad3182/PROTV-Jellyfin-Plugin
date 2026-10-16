using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using PROTV.Abstractions.Common;

namespace PROTV.Wpf.ViewModels;

public abstract class BaseListViewModel<ItemModel, Query> : BaseViewModel where ItemModel : new()
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public ItemModel value;

		public BaseListViewModel<ItemModel, Query> _003C_003E4__this;

		public _003C_003Ec__DisplayClass7_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void T17Z3FeY6r()
		{
			if (value != null)
			{
				Task task = _003C_003E4__this.GoToPage(value);
				Action<Exception> action = null;
				bool flag = false;
				gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
			}
		}
	}

	private int WFoBxjPPw4;

	private int zlYByjshv5;

	private int N8JBpkwILC;

	private Query UoKBiXo3f8;

	protected ItemModel _selectedItem;

	[CompilerGenerated]
	private ObservableCollection<ItemModel> k5iB3hITxE;

	[CompilerGenerated]
	private List<SortOrder> XMaBmrdSL4;

	[CompilerGenerated]
	private List<string> oxHBXv4HP4;

	[CompilerGenerated]
	private ICommand mcBBRX8DWx;

	public ItemModel SelectedItem
	{
		get
		{
			return _selectedItem;
		}
		set
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals6.value = value;
			CS_0024_003C_003E8__locals6._003C_003E4__this = this;
			SetProperty(ref _selectedItem, CS_0024_003C_003E8__locals6.value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				if (CS_0024_003C_003E8__locals6.value != null)
				{
					Task task = CS_0024_003C_003E8__locals6._003C_003E4__this.GoToPage(CS_0024_003C_003E8__locals6.value);
					Action<Exception> action = null;
					bool flag = false;
					gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
				}
			});
		}
	}

	public ObservableCollection<ItemModel> Items
	{
		[CompilerGenerated]
		get
		{
			return k5iB3hITxE;
		}
		[CompilerGenerated]
		set
		{
			k5iB3hITxE = value;
		}
	}

	public List<SortOrder> OrderItems
	{
		[CompilerGenerated]
		get
		{
			return XMaBmrdSL4;
		}
		[CompilerGenerated]
		set
		{
			XMaBmrdSL4 = value;
		}
	}

	public List<string> Years
	{
		[CompilerGenerated]
		get
		{
			return oxHBXv4HP4;
		}
		[CompilerGenerated]
		set
		{
			oxHBXv4HP4 = value;
		}
	}

	public ICommand FetchMoreDataCommand
	{
		[CompilerGenerated]
		get
		{
			return mcBBRX8DWx;
		}
		[CompilerGenerated]
		set
		{
			mcBBRX8DWx = value;
		}
	}

	public Query SearchQuery
	{
		get
		{
			return UoKBiXo3f8;
		}
		set
		{
			SetProperty(ref UoKBiXo3f8, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8468, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public int CurrentPage
	{
		get
		{
			return WFoBxjPPw4;
		}
		set
		{
			SetProperty(ref WFoBxjPPw4, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8494, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public int TotalCount
	{
		get
		{
			return zlYByjshv5;
		}
		set
		{
			SetProperty(ref zlYByjshv5, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8520, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public int PageCount
	{
		get
		{
			return N8JBpkwILC;
		}
		set
		{
			SetProperty(ref N8JBpkwILC, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8544, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public BaseListViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		WFoBxjPPw4 = 1;
		base._002Ector();
		Items = new ObservableCollection<ItemModel>();
		OrderItems = new List<SortOrder>
		{
			SortOrder.Asc,
			SortOrder.Desc
		};
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.neHTttLAls);
		Years = new List<string>(from x in zVnN9GTcyGwQgYh0Mkm.D35lls5iF(1900, ODLunXTV5ViHRXVCYur.D35lls5iF(ref dateTime, ODLunXTV5ViHRXVCYur.QZrT7TQm0F) - 1900 + 1, zVnN9GTcyGwQgYh0Mkm.RLTTM145GU)
			select E1oqfbTdQ1YrEeaxoPg.D35lls5iF(ref x, E1oqfbTdQ1YrEeaxoPg.beYTUkKTth));
		Years.Reverse();
		Years.Insert(0, iFZ5je3XFYKwkvcE5D.D35lls5iF(8566, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
	}

	public abstract Task LoadAsync();

	public abstract Task AddMoreItems();

	public abstract Task GoToPage(ItemModel model);
}
