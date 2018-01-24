using System;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace LittleCoffeeShop.Core.ViewModels.Interfaces
{
    public interface IBaseApplicationMvxViewModel
    {
        Task Navigate<TViewModel>() where TViewModel : IMvxViewModel;
        Task Navigate<TViewModel, TParameter>(TParameter param) where TViewModel : IMvxViewModel<TParameter> where TParameter : class;
        bool PresentationChanged(MvxPresentationHint presentationHint);
        Task Close();
    }
}
