using System;
using Android.App;
using Android.Views;
using Android.Widget;

namespace EnelAndroid.App.Presenters.PresenterActivitys
{
    /// <summary>
    /// Home presenter.
    /// </summary>
    public class HomePresenter
    {
        static HomePresenter instance = null;

        /// <summary>
        /// Gets the intance.
        /// </summary>
        /// <value>The intance.</value>
        public static HomePresenter Intance
        {
            get
            {
                if (instance == null)
                    instance = new HomePresenter();
                return instance;
            }
        }

        /// <summary>
        /// Menus the bottom.
        /// </summary>
        /// <returns><c>true</c>, if bottom was menued, <c>false</c> otherwise.</returns>
        /// <param name="activity">Activity.</param>
        /// <param name="item">Item.</param>
        /// <param name="mTextMessage">M text message.</param>
        public bool MenuBottom(Activity activity, IMenuItem item, TextView mTextMessage)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    mTextMessage.Text = activity.Resources.GetString(Resource.String.title_home);
                    return true;
                case Resource.Id.navigation_report_problem:
                    mTextMessage.Text = activity.Resources.GetString(Resource.String.title_report_problem);
                    return true;
                case Resource.Id.navigation_contact_phone:
                    mTextMessage.Text = activity.Resources.GetString(Resource.String.title_contact_phone);
                    return true;
                case Resource.Id.navigation_stars:
                    mTextMessage.Text = activity.Resources.GetString(Resource.String.title_stars);
                    return true;
            }
            return false;
        }
    }
}
