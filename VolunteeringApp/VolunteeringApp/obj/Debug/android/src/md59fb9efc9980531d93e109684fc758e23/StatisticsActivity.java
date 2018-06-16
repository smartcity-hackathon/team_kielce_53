package md59fb9efc9980531d93e109684fc758e23;


public class StatisticsActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("VolunteeringApp.StatisticsActivity, VolunteeringApp", StatisticsActivity.class, __md_methods);
	}


	public StatisticsActivity ()
	{
		super ();
		if (getClass () == StatisticsActivity.class)
			mono.android.TypeManager.Activate ("VolunteeringApp.StatisticsActivity, VolunteeringApp", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
