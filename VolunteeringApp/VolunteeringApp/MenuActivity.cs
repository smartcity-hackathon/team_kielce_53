
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace VolunteeringApp
{
    [Activity(Label = "Menu", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MenuActivity : Activity
    {
        private static Activity _activity;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_menu);
            _activity = this;

            var btnClassifieds = FindViewById<Button>(Resource.Id.menu_btnClassifieds);
            var btnAccepted = FindViewById<Button>(Resource.Id.menu_btnAccepted);
            var btnStatistics = FindViewById<Button>(Resource.Id.menu_btnStatistics);
            var btnMessage = FindViewById<Button>(Resource.Id.menu_btnMessage);
            var btnSettings = FindViewById<Button>(Resource.Id.menu_btnSettings);

            btnClassifieds.SetOnClickListener(new BtnClassifiedsClickListener());
            btnAccepted.SetOnClickListener(new BtnAcceptedClickListener());
            btnStatistics.SetOnClickListener(new BtnStatisticsClickListener());
            btnMessage.SetOnClickListener(new BtnMessageClickListener());
            btnSettings.SetOnClickListener(new BtnSettingsClickListener());
        }

        private class BtnClassifiedsClickListener : Java.Lang.Object, View.IOnClickListener
        {
            public void OnClick(View v)
            {
                Intent intent = new Intent(_activity, typeof(ClassifiedsActivity));
                _activity.StartActivity(intent);
            }
        }

        private class BtnAcceptedClickListener : Java.Lang.Object, View.IOnClickListener
        {
            public void OnClick(View v)
            {
                Intent intent = new Intent(_activity, typeof(AcceptedActivity));
                _activity.StartActivity(intent);
            }
        }

        private class BtnStatisticsClickListener : Java.Lang.Object, View.IOnClickListener
        {
            public void OnClick(View v)
            {
                Intent intent = new Intent(_activity, typeof(StatisticsActivity));
                _activity.StartActivity(intent);
            }
        }

        private class BtnMessageClickListener : Java.Lang.Object, View.IOnClickListener
        {
            public void OnClick(View v)
            {
                Intent intent = new Intent(_activity, typeof(MessageActivity));
                _activity.StartActivity(intent);
            }
        }

        private class BtnSettingsClickListener : Java.Lang.Object, View.IOnClickListener
        {
            public void OnClick(View v)
            {
                Intent intent = new Intent(_activity, typeof(SettingsActivity));
                _activity.StartActivity(intent);
            }
        }
    }
}