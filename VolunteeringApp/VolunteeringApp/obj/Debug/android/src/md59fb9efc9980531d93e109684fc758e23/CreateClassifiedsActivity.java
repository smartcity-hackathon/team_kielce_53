package md59fb9efc9980531d93e109684fc758e23;


public class CreateClassifiedsActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("VolunteeringApp.CreateClassifiedsActivity, VolunteeringApp", CreateClassifiedsActivity.class, __md_methods);
	}


	public CreateClassifiedsActivity ()
	{
		super ();
		if (getClass () == CreateClassifiedsActivity.class)
			mono.android.TypeManager.Activate ("VolunteeringApp.CreateClassifiedsActivity, VolunteeringApp", "", this, new java.lang.Object[] {  });
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
