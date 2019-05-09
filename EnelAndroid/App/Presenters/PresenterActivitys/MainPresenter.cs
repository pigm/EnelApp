using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Util;
using EnelAndroid.App.Activitys;

namespace EnelAndroid.App.Presenters.PresenterActivitys
{
    /// <summary>
    /// Main presenter.
    /// </summary>
    public class MainPresenter
    {
        private const int TIME_SPLASH = 5000;
        static MainPresenter instance = null;

        /// <summary>
        /// Gets the intance.
        /// </summary>
        /// <value>The intance.</value>
        public static MainPresenter Intance{

            get{
                if (instance == null)
                    instance = new MainPresenter();
                return instance;
            }
        }

        /// <summary>
        /// Inicios the app.
        /// </summary>
        public void InicioApp(Activity activity)
        {
            try
            {
                Task startupwork = new Task(() =>
                {
                    Task.Delay(TIME_SPLASH).Wait();
                });
                startupwork.ContinueWith(t =>
                {
                    activity.StartActivity(new Intent(activity, typeof(HomeActivity)), ActivityOptions.MakeSceneTransitionAnimation(activity).ToBundle());
                }, TaskScheduler.FromCurrentSynchronizationContext());

                startupwork.Start();
            }
            catch (Exception ex)
            {
                Log.Info("start app ", ex.Message);
            }
        }
    }
}
