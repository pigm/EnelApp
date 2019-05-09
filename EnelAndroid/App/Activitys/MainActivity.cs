using Android.App;
using Android.OS;
using Android.Support.V7.App;
using EnelAndroid.App.Presenters.PresenterActivitys;

namespace EnelAndroid.App.Activitys
{
    /// <summary>
    /// Main activity.
    /// </summary>
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme.Splash", MainLauncher = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize |
             Android.Content.PM.ConfigChanges.Orientation,
             ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {
        /// <summary>
        /// Ons the create.
        /// </summary>
        /// <param name="savedInstanceState">Saved instance state.</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);          
            SetContentView(Resource.Layout.activity_splash);
            MainPresenter.Intance.InicioApp(this);
        }
     
    }
}