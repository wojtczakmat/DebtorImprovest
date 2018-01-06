using System;
using System.Collections.Generic;
using System.Text;
using DebtorImprovest.Core.ViewModels;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace DebtorImprovest.Core
{
    public class AppStart: MvxNavigatingObject, IMvxAppStart
    {
        private readonly IMvxNavigationService navigation;

        public AppStart(IMvxNavigationService navigation)
        {
            this.navigation = navigation;
        }
        public void Start(object hint = null)
        {
            navigation.Navigate<MainViewModel>();
        }
    }
}
