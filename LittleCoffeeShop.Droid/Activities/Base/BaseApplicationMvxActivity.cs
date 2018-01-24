using System;
using Android.OS;
using LittleCoffeeShop.Core.ViewModels.Base;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace LittleCoffeeShop.Droid.Activities.Base
{
    public abstract class BaseApplicationMvxActivity<TViewModel, TInitParams> : BaseApplicationMvxActivity<TViewModel> where TViewModel : BaseApplicationMvxViewModel<TInitParams> where TInitParams : class
    {
    }

    public abstract class BaseApplicationMvxActivity<TViewModel> : MvxAppCompatActivity<TViewModel> where TViewModel : BaseApplicationMvxViewModel
    {
        public abstract int LayoutId { get; }

        protected override void OnCreate(Bundle bundle)
        {
            var setup = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setup.EnsureInitialized();
            base.OnCreate(bundle);
            SetContentView(LayoutId);
        }
    }
}
