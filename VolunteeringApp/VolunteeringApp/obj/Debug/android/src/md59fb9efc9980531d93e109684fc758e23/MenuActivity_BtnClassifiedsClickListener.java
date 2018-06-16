package md59fb9efc9980531d93e109684fc758e23;


public class MenuActivity_BtnClassifiedsClickListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("VolunteeringApp.MenuActivity+BtnClassifiedsClickListener, VolunteeringApp", MenuActivity_BtnClassifiedsClickListener.class, __md_methods);
	}


	public MenuActivity_BtnClassifiedsClickListener ()
	{
		super ();
		if (getClass () == MenuActivity_BtnClassifiedsClickListener.class)
			mono.android.TypeManager.Activate ("VolunteeringApp.MenuActivity+BtnClassifiedsClickListener, VolunteeringApp", "", this, new java.lang.Object[] {  });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
