using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using VolunteeringApp.Models;
using VolunteeringApp.Repositories;

namespace VolunteeringApp.Adapters
{
    public class ClassifiedsAdapter : RecyclerView.Adapter
    {
        private static Activity _activity;

        private static List<ClassifiedModel> _mClassified = new List<ClassifiedModel>();

        private static RecyclerView _mRecyclerView;


        private class MyViewHolder : RecyclerView.ViewHolder
        {
            public TextView mTitle;
            public TextView mContent;
            public TextView mDate;

            public MyViewHolder(View pItem) : base(pItem)
            {
                mTitle = pItem.FindViewById<TextView>(Resource.Id.classified_title);
                mContent = pItem.FindViewById<TextView>(Resource.Id.classified_subtitle);
                mDate = pItem.FindViewById<TextView>(Resource.Id.classified_date);
            }
        }

        private class MyOnClickListener : Java.Lang.Object, View.IOnClickListener
        {
            public void OnClick(View v)
            {
                // odnajdujemy indeks klikniętego elementu
                int position = _mRecyclerView.GetChildAdapterPosition(v);
                var classified = _mClassified[position];

                Intent intent = new Intent(_activity, typeof(ClassifiedsDetailsActivity));
                intent.PutExtra("ClassifiedId", classified.Id);
                intent.PutExtra("OrganizationId", classified.OrganizationId);
                intent.PutExtra("ClassifiedDetailsId", classified.ClassifiedDetailsId);
                _activity.StartActivity(intent);
            }
        }


        public ClassifiedsAdapter(Activity activity, List<ClassifiedModel> pClassified, RecyclerView pRecyclerView)
        {
            _activity = activity;
            _mClassified = pClassified;
            _mRecyclerView = pRecyclerView;
        }

        public override int ItemCount
        {
            get
            {
                return _mClassified.Count;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var classified = _mClassified[position];
            var mHolder = holder as MyViewHolder;

            mHolder.mTitle.Text = Repository.Organizations.Where(o => o.Id == classified.OrganizationId).First().Name;
            mHolder.mContent.Text = classified.Subtitle;
            mHolder.mDate.Text = $"Od {classified.StartDate} - {classified.EndDate}";
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.classified_layout, parent, false);
            view.SetOnClickListener(new MyOnClickListener());

            return new MyViewHolder(view);
        }
    }
}