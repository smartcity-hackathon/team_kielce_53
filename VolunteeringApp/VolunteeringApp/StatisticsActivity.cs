
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using System.Linq;
using VolunteeringApp.Common;
using VolunteeringApp.Repositories;

namespace VolunteeringApp
{
    [Activity(Label = "StatisticsActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class StatisticsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_statistics);

            var acceptedTextView = FindViewById<TextView>(Resource.Id.statiscics_accepted);
            var rejectedextView = FindViewById<TextView>(Resource.Id.statiscics_rejested);

            var statistics = Repository.Statistics.Where(s => s.UserId == CurrentSession.UserId).FirstOrDefault();

            if (statistics != null)
            {
                acceptedTextView.Text = statistics.AcceptedCount + "";
                rejectedextView.Text = statistics.RejectedCount + "";
            }
        }
    }
}