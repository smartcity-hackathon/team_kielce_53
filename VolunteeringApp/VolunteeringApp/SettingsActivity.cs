
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace VolunteeringApp
{
    [Activity(Label = "SettingsActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SettingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_settings);
        }
    }
}