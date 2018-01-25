using System;
using LittleCoffeeShop.Core.ViewModels.Base;
using MvvmCross.Core.Navigation;

namespace LittleCoffeeShop.Core.ViewModels.GettingStarted
{
    public class GetStartedFirstViewModel : BaseApplicationMvxViewModel
    {
        public GetStartedFirstViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
    }
}
