using System;
using System.Threading.Tasks;
using LittleCoffeeShop.Core.ViewModels.Interfaces;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace LittleCoffeeShop.Core.ViewModels.Base
{
    public abstract class BaseApplicationMvxViewModel : MvxViewModel, IBaseApplicationMvxViewModel
    {
        protected readonly IMvxNavigationService _navigationService;

        public BaseApplicationMvxViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public async Task Navigate<TViewModel>() where TViewModel : IMvxViewModel
        {
            await _navigationService.Navigate<TViewModel>();
        }


        public async Task Navigate<TViewModel, TParameter>(TParameter param)
            where TViewModel : IMvxViewModel<TParameter>
            where TParameter : class
        {
            await _navigationService.Navigate<TViewModel, TParameter>(param);
        }

        public async Task Close()
        {
            await _navigationService.Close(this);
        }

        public bool PresentationChanged(MvxPresentationHint presentationHint)
        {
            return ChangePresentation(presentationHint);
        }
    }

    public abstract class BaseApplicationMvxViewModel<TInitParams> : BaseApplicationMvxViewModel, IMvxViewModel<TInitParams> where TInitParams : class
    {
        public BaseApplicationMvxViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        public virtual Task Initialize(TInitParams parameter)
        {

            return Task.FromResult(true);
        }

        public virtual void Prepare(TInitParams parameter) { }
    }
}
