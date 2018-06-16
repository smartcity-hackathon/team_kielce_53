using System.Linq;

using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using VolunteeringApp.Adapters;
using VolunteeringApp.Common;
using VolunteeringApp.Repositories;

namespace VolunteeringApp
{
    [Activity(Label = "AcceptedActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class AcceptedActivity : AppCompatActivity
    {
        private RecyclerView _recyclerView;

        private TextView _noResultTextView;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_accepted);

            _noResultTextView = FindViewById<TextView>(Resource.Id.accepted_noresult);
            _recyclerView = FindViewById<RecyclerView>(Resource.Id.accepted_recycler);

            _recyclerView.HasFixedSize = true;
            _recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            _recyclerView.SetItemAnimator(new DefaultItemAnimator());
        }

        protected override void OnResume()
        {            
            var accepted = Repository.AcceptedClassified.Where(a => a.UserId == CurrentSession.UserId).Select(a => a.ClassifiedId).ToList();
            var classifieds = Repository.Classifieds.Where(c => accepted.Contains(c.Id)).ToList();

            if (classifieds.Any())
            {
                _noResultTextView.Visibility = ViewStates.Gone;
                _recyclerView.Visibility = ViewStates.Visible;

                _recyclerView.SetAdapter(new ClassifiedsAdapter(this, classifieds, _recyclerView));
            }
            else
            {
                _noResultTextView.Visibility = ViewStates.Visible;
                _recyclerView.Visibility = ViewStates.Gone;
            }

            base.OnResume();
        }
    }
}