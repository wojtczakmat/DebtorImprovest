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
            ShowFirst = new MvxAsyncCommand(() => navigation.Navigate<FirstViewModel>());
            ShowSecond = new MvxAsyncCommand(() => navigation.Navigate<SecondViewModel>());
        }

        public IMvxAsyncCommand ShowFirst { get; }
        public IMvxAsyncCommand ShowSecond { get; }
    }
}
