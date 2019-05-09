using Android.App;
using Android.OS;
using EnelAndroid.App.Presenters.PresenterDialogs;

namespace EnelAndroid.App.Dialogs
{
    /// <summary>
    /// Salir dialog.
    /// </summary>
    [Activity(Theme = "@style/ThemeNoToolbar", ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize |
             Android.Content.PM.ConfigChanges.Orientation,
             ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class SalirDialog : Activity
    {
        static Dialog customDialog = null;
        /// <summary>
        /// Ons the create.
        /// </summary>
        /// <param name="savedInstanceState">Saved instance state.</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.dialog_salir);
        }

        /// <summary>
        /// Views the dialogo salir app.
        /// </summary>
        /// <param name="activity">Activity.</param>
        public static void ViewDialogoSalirApp(Activity activity)
        {
            SalirPresenter.Intance.ViewMensajeDialogo(activity, customDialog);
        }
    }
}