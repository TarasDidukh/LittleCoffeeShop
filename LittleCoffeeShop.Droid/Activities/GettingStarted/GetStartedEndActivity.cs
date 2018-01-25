
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LittleCoffeeShop.Core.ViewModels.GettingStarted;
using LittleCoffeeShop.Droid.Activities.Base;

namespace LittleCoffeeShop.Droid.Activities.GettingStarted
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait,
              Theme = "@style/Main.Theme")]
    [Register("com.xamarin.activities.GetStartedEndActivity")]
    public class GetStartedEndActivity : BaseApplicationMvxActivity<GetStartedEndViewModel>
    {
        public override int LayoutId => Resource.Layout.GetStartedEndActivity;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
        }
    }
}
