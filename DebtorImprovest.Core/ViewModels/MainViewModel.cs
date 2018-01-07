using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace DebtorImprovest.Core.ViewModels
{
    public class MainViewModel: MvxViewModel
    {
        private readonly IMvxNavigationService navigation;

        public MainViewModel(IMvxNavigationService navigation)
        {
            this.navigation = navigation;
            ShowMenu = new MvxAsyncCommand(() => navigation.Navigate<MenuViewModel>());
            ShowSecond = new MvxAsyncCommand(() => navigation.Navigate<SecondViewModel>());
        }

        public IMvxAsyncCommand ShowMenu { get; }
        public IMvxAsyncCommand ShowSecond { get; }
    }
}
