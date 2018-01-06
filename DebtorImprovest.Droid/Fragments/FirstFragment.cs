using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DebtorImprovest.Core.ViewModels;
using MvvmCross.Droid.Views.Attributes;

namespace DebtorImprovest.Droid.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, true)]
    //[Register("starWarsSample.droid.views.StatusView")]
    public class FirstFragment: BaseFragment<FirstViewModel>
    {
        protected override int FragmentId => Resource.Layout.FirstView;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            ParentActivity.SupportActionBar.Title = "First";
            return view;
        }
    }
}