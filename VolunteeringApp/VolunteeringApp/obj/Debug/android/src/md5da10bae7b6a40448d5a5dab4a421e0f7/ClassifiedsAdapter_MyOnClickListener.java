package md5da10bae7b6a40448d5a5dab4a421e0f7;


public class ClassifiedsAdapter_MyOnClickListener
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
		mono.android.Runtime.register ("VolunteeringApp.Adapters.ClassifiedsAdapter+MyOnClickListener, VolunteeringApp", ClassifiedsAdapter_MyOnClickListener.class, __md_methods);
	}


	public ClassifiedsAdapter_MyOnClickListener ()
	{
		super ();
		if (getClass () == ClassifiedsAdapter_MyOnClickListener.class)
			mono.android.TypeManager.Activate ("VolunteeringApp.Adapters.ClassifiedsAdapter+MyOnClickListener, VolunteeringApp", "", this, new java.lang.Object[] {  });
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
