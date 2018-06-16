
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace VolunteeringApp
{
    [Activity(Label = "MessageActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MessageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_message);
        }
    }
}