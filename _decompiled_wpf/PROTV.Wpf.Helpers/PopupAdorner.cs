using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace PROTV.Wpf.Helpers;

public class PopupAdorner : Adorner
{
	private VisualCollection R69Gr74tCg;

	private ContentPresenter b59GHjbs4w;

	protected override int VisualChildrenCount => m9MGZR7k2RmVqYXYS5.D35lls5iF(R69Gr74tCg, m9MGZR7k2RmVqYXYS5.MVtkRxpVva);

	public PopupAdorner(UIElement adornedElement, UIElement content, Vector offset)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(adornedElement);
		R69Gr74tCg = new VisualCollection(this);
		b59GHjbs4w = new ContentPresenter();
		xxXK7Dk9CCLOU59xcRW.D35lls5iF(R69Gr74tCg, b59GHjbs4w, xxXK7Dk9CCLOU59xcRW.WL3kDUP73D);
		KBhlAv9D2TgBJ1kkc0B.D35lls5iF(b59GHjbs4w, content, KBhlAv9D2TgBJ1kkc0B.yX5kH2edZ7);
		VKPgscndlUWLn8geWtk.D35lls5iF(this, new Thickness(Pl25iek1VcrpeM60UbR.D35lls5iF(ref offset, Pl25iek1VcrpeM60UbR.Dx6k8fP1Mu), Pl25iek1VcrpeM60UbR.D35lls5iF(ref offset, Pl25iek1VcrpeM60UbR.jHKkn1j9uf), 0.0, 0.0), VKPgscndlUWLn8geWtk.q5ck32kc6h);
	}

	protected override Size MeasureOverride(Size constraint)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		b3Xs5bkTJWvffBoIwFO.D35lls5iF(b59GHjbs4w, constraint, b3Xs5bkTJWvffBoIwFO.Q5Vk4MKUU9);
		return GAFcFirX4H1KbV9nid5.D35lls5iF(b59GHjbs4w, GAFcFirX4H1KbV9nid5.MDtkLu0iIW);
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		o2iaqtrFfDSwmbNKtL9.D35lls5iF(b59GHjbs4w, new Rect(0.0, 0.0, vqksM8kEHbIb4nNIlaN.D35lls5iF(ref finalSize, vqksM8kEHbIb4nNIlaN.AKSkBdDH7S), vqksM8kEHbIb4nNIlaN.D35lls5iF(ref finalSize, vqksM8kEHbIb4nNIlaN.cKUk0Dl4dn)), o2iaqtrFfDSwmbNKtL9.CTykrH70Bn);
		return GAFcFirX4H1KbV9nid5.D35lls5iF(b59GHjbs4w, GAFcFirX4H1KbV9nid5.lpLrfHFLLp);
	}

	protected override Visual GetVisualChild(int index)
	{
		return tuaqGVkeKij2Tyb8sNj.D35lls5iF(R69Gr74tCg, index, tuaqGVkeKij2Tyb8sNj.AKPkGiHVL3);
	}

	public void Show()
	{
		AdMcOokpoApdteQe088.D35lls5iF(KTM4NTkAKFo0U59QblC.D35lls5iF(t3qeG0kkKVql4NLwI9v.D35lls5iF(this, t3qeG0kkKVql4NLwI9v.bkEkv72Gjx), KTM4NTkAKFo0U59QblC.W86k61VZu9), this, AdMcOokpoApdteQe088.HYNkwBtY6Z);
	}

	public void Hide()
	{
		AdornerLayer adornerLayer = KTM4NTkAKFo0U59QblC.D35lls5iF(t3qeG0kkKVql4NLwI9v.D35lls5iF(this, t3qeG0kkKVql4NLwI9v.bkEkv72Gjx), KTM4NTkAKFo0U59QblC.W86k61VZu9);
		if (adornerLayer != null)
		{
			AdMcOokpoApdteQe088.D35lls5iF(adornerLayer, this, AdMcOokpoApdteQe088.qBVkCubsyS);
		}
	}
}
