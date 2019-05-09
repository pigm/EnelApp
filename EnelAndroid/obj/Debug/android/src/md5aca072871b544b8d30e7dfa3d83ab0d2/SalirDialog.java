package md5aca072871b544b8d30e7dfa3d83ab0d2;


public class SalirDialog
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
		mono.android.Runtime.register ("EnelAndroid.App.Dialogs.SalirDialog, EnelAndroid", SalirDialog.class, __md_methods);
	}


	public SalirDialog ()
	{
		super ();
		if (getClass () == SalirDialog.class)
			mono.android.TypeManager.Activate ("EnelAndroid.App.Dialogs.SalirDialog, EnelAndroid", "", this, new java.lang.Object[] {  });
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
