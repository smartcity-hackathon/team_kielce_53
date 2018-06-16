package md5da10bae7b6a40448d5a5dab4a421e0f7;


public class ClassifiedsAdapter_MyViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("VolunteeringApp.Adapters.ClassifiedsAdapter+MyViewHolder, VolunteeringApp", ClassifiedsAdapter_MyViewHolder.class, __md_methods);
	}


	public ClassifiedsAdapter_MyViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ClassifiedsAdapter_MyViewHolder.class)
			mono.android.TypeManager.Activate ("VolunteeringApp.Adapters.ClassifiedsAdapter+MyViewHolder, VolunteeringApp", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
