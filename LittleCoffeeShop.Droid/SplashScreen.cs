using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace LittleCoffeeShop.Droid
{
    [Activity(
        Label = "LittleCoffeeShop"
        , MainLauncher = true
        , Icon = "@drawable/start_icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
