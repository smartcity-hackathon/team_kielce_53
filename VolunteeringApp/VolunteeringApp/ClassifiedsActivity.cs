using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using VolunteeringApp.Adapters;
using VolunteeringApp.Repositories;

namespace VolunteeringApp
{
    [Activity(Label = "ClassifiedsActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ClassifiedsActivity : AppCompatActivity
    {
        private RecyclerView _recyclerView;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_classifieds);

            _recyclerView = FindViewById<RecyclerView>(Resource.Id.classified_recycler);
            _recyclerView.HasFixedSize = true;
            _recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            _recyclerView.SetItemAnimator(new DefaultItemAnimator());
            _recyclerView.SetAdapter(new ClassifiedsAdapter(this, Repository.Classifieds, _recyclerView));
        }
    }
}