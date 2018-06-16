
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Linq;
using VolunteeringApp.Common;
using VolunteeringApp.Models;
using VolunteeringApp.Repositories;

namespace VolunteeringApp
{
    [Activity(Label = "ClassifiedsDetailsActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ClassifiedsDetailsActivity : Activity
    {

        private static Activity _activity;

        private static ClassifiedModel _classified;

        private static OrganizationModel _organization;

        private static ClassifiedDetailsModel _classifiedDetails;

        private static Button _btn;

        private static AcceptedClassifiedModel _accepted;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_classifieds_details);
            _activity = this;

            int classifiedId = Intent.GetIntExtra("ClassifiedId", 0);
            int organizationId = Intent.GetIntExtra("OrganizationId", 0);
            int classifiedDetailsId = Intent.GetIntExtra("ClassifiedDetailsId", 0);

            _classified = Repository.Classifieds.Where(c => c.Id == classifiedId).FirstOrDefault();
            _organization = Repository.Organizations.Where(c => c.Id == organizationId).FirstOrDefault();
            _classifiedDetails = Repository.ClassifiedDetails.Where(c => c.Id == classifiedDetailsId).FirstOrDefault();

            var titleTextView = FindViewById<TextView>(Resource.Id.classified_details_title);
            var subtitleTextView = FindViewById<TextView>(Resource.Id.classified_details_subtitle);
            var addressTextView = FindViewById<TextView>(Resource.Id.classified_details_address);
            var phoneTextView = FindViewById<TextView>(Resource.Id.classified_details_phone);
            var dateTextView = FindViewById<TextView>(Resource.Id.classified_details_date);
            var descriptionTextView = FindViewById<TextView>(Resource.Id.classified_details_description);
            _btn = FindViewById<Button>(Resource.Id.classified_details_btn);

            titleTextView.Text = _organization.Name;
            subtitleTextView.Text = _classified.Subtitle;
            addressTextView.Text = _organization.Address;
            phoneTextView.Text = _organization.Phone;
            dateTextView.Text = $"{_classified.StartDate} - {_classified.EndDate}";
            descriptionTextView.Text = _classifiedDetails.Description;

            _btn.Text = "Wezmę udział";
            _btn.SetOnClickListener(new BtnObClickListener());

            _accepted = Repository.AcceptedClassified.Where(a => a.UserId == CurrentSession.UserId && a.ClassifiedId == _classified.Id).FirstOrDefault();

            if (_accepted != null)
            {
                _btn.Text = "Rezygnuję";
                _btn.SetBackgroundResource(Resource.Drawable.round_red_background);
                _btn.SetTextColor(Android.Graphics.Color.ParseColor("#b71c1c"));
            }
        }

        private class BtnObClickListener : Java.Lang.Object, View.IOnClickListener
        {
            public void OnClick(View v)
            {
                var statistics = Repository.Statistics.Where(s => s.UserId == CurrentSession.UserId).FirstOrDefault();

                if (_accepted == null)
                {
                    _accepted = new AcceptedClassifiedModel
                    {
                        UserId = CurrentSession.UserId,
                        ClassifiedId = _classified.Id
                    };

                    Repository.AcceptedClassified.Add(_accepted);
                    _btn.Text = "Rezygnuję";
                    _btn.SetBackgroundResource(Resource.Drawable.round_red_background);
                    _btn.SetTextColor(Android.Graphics.Color.ParseColor("#78909c"));

                    statistics.AcceptedCount++;

                    var cl = Repository.Classifieds.Where(c => c.Id == _accepted.ClassifiedId).FirstOrDefault();
                    Toast.MakeText(_activity, $"Bierzesz udział w wydarzeniu {cl.Subtitle}", ToastLength.Short).Show();
                }
                else
                {
                    Repository.AcceptedClassified.Remove(_accepted);                    
                    _btn.Text = "Chcę wziąć udział";
                    _btn.SetBackgroundResource(Resource.Drawable.round_green_background);
                    _btn.SetTextColor(Android.Graphics.Color.ParseColor("#b71c1c"));

                    statistics.RejectedCount++;

                    var cl = Repository.Classifieds.Where(c => c.Id == _accepted.ClassifiedId).FirstOrDefault();
                    Toast.MakeText(_activity, $"Zrezygnowałeś z wydarzenia {cl.Subtitle}", ToastLength.Short).Show();

                    _accepted = null;
                }

                _activity.OnBackPressed();
            }
        }
    }
}