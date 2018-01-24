using Android.App;
using Android.OS;
using LittleCoffeeShop.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace LittleCoffeeShop.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}
