using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using EnelAndroid.App.Dialogs;
using EnelAndroid.App.Presenters.PresenterActivitys;
using static Android.Support.Design.Widget.BottomNavigationView;

namespace EnelAndroid.App.Activitys
{
    /// <summary>
    /// Home activity.
    /// </summary>
    [Activity(Theme = "@style/ThemeNoToolbar", ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize |
             Android.Content.PM.ConfigChanges.Orientation,
             ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class HomeActivity : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        BottomNavigationView navigation;
        TextView mTextMessage;

        /// <summary>
        /// Ons the create.
        /// </summary>
        /// <param name="savedInstanceState">Saved instance state.</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_home);
            mTextMessage = FindViewById<TextView>(Resource.Id.message);
            navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }

        /// <summary>
        /// Ons the navigation item selected.
        /// </summary>
        /// <returns><c>true</c>, if navigation item selected was oned, <c>false</c> otherwise.</returns>
        /// <param name="item">Item.</param>
        public bool OnNavigationItemSelected(IMenuItem item) { return HomePresenter.Intance.MenuBottom(this, item, mTextMessage); }

        /// <summary>
        /// Ons the back pressed.
        /// </summary>
        public override void OnBackPressed(){ SalirDialog.ViewDialogoSalirApp(this); }
    }
}
