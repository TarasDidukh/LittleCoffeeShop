using System;
using LittleCoffeeShop.Core.ViewModels.Base;
using MvvmCross.Core.Navigation;

namespace LittleCoffeeShop.Core.ViewModels.GettingStarted
{
    public class GetStartedViewModel : BaseApplicationMvxViewModel
    {
        public GetStartedViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
    }
}
