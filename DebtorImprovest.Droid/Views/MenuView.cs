using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.Graphics.Drawable;
using Android.Views;
using Android.Widget;
using DebtorImprovest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace DebtorImprovest.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.navigation_frame)]
    //[Register("starWarsSample.droid.views.MenuView")]
    public class MenuFragment : MvxFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        private NavigationView navigationView;
        private IMenuItem previousMenuItem;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.MenuView, null);

            navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            navigationView.SetNavigationItemSelectedListener(this);
            navigationView.Menu.FindItem(Resource.Id.nav_first).SetChecked(true);

            //var iconPlanets = navigationView.Menu.FindItem(Resource.Id.nav_planets);
            //iconPlanets.SetTitle(Strings.TargetPlanets);
            //iconPlanets.SetCheckable(false);
            //iconPlanets.SetChecked(true);
            //var imgPlanet = VectorDrawableCompat.Create(Resources, Resource.Drawable.planet, Activity.Theme);
            //iconPlanets.SetIcon(imgPlanet);

            //previousMenuItem = iconPlanets;

            //var iconPeople = navigationView.Menu.FindItem(Resource.Id.nav_people);
            //iconPeople.SetTitle(Strings.TargetPeople);
            //iconPeople.SetCheckable(false);
            //var imgPeople = VectorDrawableCompat.Create(Resources, Resource.Drawable.people, Activity.Theme);
            //iconPeople.SetIcon(imgPeople);

            //var iconStatistics = navigationView.Menu.FindItem(Resource.Id.nav_statistics);
            //iconStatistics.SetTitle(Strings.Statistics);
            //iconStatistics.SetCheckable(false);
            //var imgStatistics = VectorDrawableCompat.Create(Resources, Resource.Drawable.statistics, Activity.Theme);
            //iconStatistics.SetIcon(imgStatistics);

            return view;
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            if (previousMenuItem != null)
                previousMenuItem.SetChecked(false);

            item.SetCheckable(true);
            item.SetChecked(true);

            previousMenuItem = item;

            Navigate(item.ItemId);

            return true;
        }

        private async Task Navigate(int itemId)
        {
            ((MainView)Activity).DrawerLayout.CloseDrawers();
            await Task.Delay(TimeSpan.FromMilliseconds(250));

            switch (itemId)
            {
                case Resource.Id.nav_first:
                    ViewModel.ShowFirst.Execute(null);
                    break;
                case Resource.Id.nav_second:
                    ViewModel.ShowSecond.Execute(null);
                    break;
            }
        }
    }
}