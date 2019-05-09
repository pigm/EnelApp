using System;
using Android.App;
using Android.Widget;

namespace EnelAndroid.App.Presenters.PresenterDialogs
{
    /// <summary>
    /// Salir presenter.
    /// </summary>
    public class SalirPresenter
    {
        static SalirPresenter instance = null;

        /// <summary>
        /// Gets the intance.
        /// </summary>
        /// <value>The intance.</value>
        public static SalirPresenter Intance
        {
            get
            {
                if (instance == null)
                    instance = new SalirPresenter();
                return instance;
            }
        }
        /// <summary>
        /// Views the mensaje dialogo.
        /// </summary>
        /// <param name="activity">Activity.</param>
        /// <param name="customDialog">Custom dialog.</param>
        public void ViewMensajeDialogo(Activity activity, Dialog customDialog)
        {
            customDialog = new Dialog(activity, Resource.Style.MyThemeTranslucent);
            customDialog.SetCancelable(false);
            customDialog.SetContentView(Resource.Layout.dialog_salir);
            Button btnCancelarSalirDialog = customDialog.FindViewById<Button>(Resource.Id.btnCancelarSalida);
            Button btnExitSalirDialog = customDialog.FindViewById<Button>(Resource.Id.btnExitSalida);
            btnCancelarSalirDialog.Click += delegate { customDialog.Dismiss(); };
            btnExitSalirDialog.Click += delegate { activity.FinishAffinity(); };
            customDialog.Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
            customDialog.Show(); 
        }
    }
}
