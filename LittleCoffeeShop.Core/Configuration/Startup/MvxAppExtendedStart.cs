using System;
using LittleCoffeeShop.Core.ViewModels;
using LittleCoffeeShop.Core.ViewModels.GettingStarted;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace LittleCoffeeShop.Core.Configuration.Startup
{
    public class MvxAppExtendedStart : IMvxAppStart
    {
        private readonly IMvxNavigationService _navigationService;

        public MvxAppExtendedStart(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void Start(object hint = null)
        {
            _navigationService.Navigate<GetStartedViewModel>();
        }
    }
}
