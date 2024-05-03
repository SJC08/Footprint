using Android.Content;
using Android.Views;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.Navigation;

namespace Footprint
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity, NavigationBarView.IOnItemSelectedListener
    {
        private readonly ServiceConnection<LocationService> connection = new();

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            Intent intent = new(this, typeof(LocationService));
            StartForegroundService(intent);
            BindService(intent, connection, Bind.AutoCreate);

            var bottomNav = FindViewById<BottomNavigationView>(Resource.Id.bottom_nav);
            bottomNav.SetOnItemSelectedListener(this);
        }

        public bool OnNavigationItemSelected(IMenuItem p0)
        {
            switch (p0.ItemId)
            {
                case Resource.Id.home:
                    break;
                case Resource.Id.view:
                    break;
            }
            return true;
        }
    }
}