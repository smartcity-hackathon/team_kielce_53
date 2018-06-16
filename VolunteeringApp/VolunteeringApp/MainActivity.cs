using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using Java.Interop;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VolunteeringApp.Common;
using VolunteeringApp.Models;
using VolunteeringApp.Repositories;

namespace VolunteeringApp
{
    [Activity(Label = "Logowanie", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        private LinearLayout _contentLayout;

        private LinearLayout _loadingLayout;

        private TextInputEditText _usernameText;

        private TextInputEditText _passwordText;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _contentLayout = FindViewById<LinearLayout>(Resource.Id.main_content);
            _loadingLayout = FindViewById<LinearLayout>(Resource.Id.main_loading);
            _usernameText = FindViewById<TextInputEditText>(Resource.Id.main_username);
            _passwordText = FindViewById<TextInputEditText>(Resource.Id.main_password);

            _usernameText.Text = "hackathon@um.pl";
            _passwordText.Text = "hackathon";
        }

        private void SetLoading(bool isLoading)
        {
            if (isLoading)
            {
                _contentLayout.Visibility = ViewStates.Gone;
                _loadingLayout.Visibility = ViewStates.Visible;
            }
            else
            {
                _contentLayout.Visibility = ViewStates.Visible;
                _loadingLayout.Visibility = ViewStates.Gone;
            }
        }

        public override void OnBackPressed()
        {
            new AlertDialog.Builder(this)
                .SetTitle("Zamykanie aplikacji")
                .SetMessage("Czy jesteś pewnien, że chcesz zamknąć aplikację?")
                .SetPositiveButton("Tak", (s, e) =>
                {
                    base.OnBackPressed();
                })
                .SetNegativeButton("Nie", (s, e) =>
                {

                })
                .SetCancelable(false)
                .Create()
                .Show();
        }

        [Export("mainbtnLoginOnClick")]
        public void mainbtnLoginOnClick(View view)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(_usernameText.Text))
            {
                _usernameText.SetError("Podaj e-mail", null);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(_passwordText.Text))
            {
                _passwordText.SetError("Podaj hasło", null);
                isValid = false;
            }

            if (isValid)
            {
                SetLoading(true);

                var user = new UserModel
                {
                    Email = _usernameText.Text.Trim(),
                    Password = _passwordText.Text.Trim()
                };

                Task.Run(() =>
                {
                    if (!Repository.IsInitialized)
                    {
                        Repository.Load();
                    }

                    var storedUser = Repository.Users.Where(u => u.Email == user.Email).FirstOrDefault();

                    if (storedUser == null)
                    {
                        user.Id = Repository.Users.Count + 1;

                        var statistics = new StatisticModel
                        {
                            UserId = user.Id,
                            AcceptedCount = 0,
                            RejectedCount = 0
                        };

                        Repository.Users.Add(user);
                        Repository.Statistics.Add(statistics);

                        storedUser = user;
                    }

                    CurrentSession.UserId = storedUser.Id;

                    Thread.Sleep(1000);
                })
                .ContinueWith(result => RunOnUiThread(() =>
                {
                    SetLoading(false);

                    Intent intent = new Intent(this, typeof(MenuActivity));
                    StartActivity(intent);
                }));
            }
        }
    }
}
