using System;
using LittleCoffeeShop.Core.ViewModels.Base;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace LittleCoffeeShop.Core.ViewModels.GettingStarted
{
    public class GetStartedSecondViewModel : BaseApplicationMvxViewModel
    {
        public GetStartedSecondViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        public MvxAsyncCommand OpenLast =>
            new MvxAsyncCommand(async () => await Navigate<GetStartedEndViewModel>());
    }
}
