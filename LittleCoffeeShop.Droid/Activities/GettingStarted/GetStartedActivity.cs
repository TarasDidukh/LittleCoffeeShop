
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using LittleCoffeeShop.Core.ViewModels.GettingStarted;
using LittleCoffeeShop.Droid.Activities.Base;
using LittleCoffeeShop.Droid.Fragments.GettingStarted;
using MvvmCross.Droid.Support.V4;

namespace LittleCoffeeShop.Droid.Activities.GettingStarted
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait,
              Theme = "@style/Main.Theme")]
    [Register("com.xamarin.activities.GetStartedActivity")]
    public class GetStartedActivity : BaseApplicationMvxActivity<GetStartedViewModel>
    {
        public override int LayoutId => Resource.Layout.GetStartedActivity;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            if (viewPager != null)
            {
                var fragments = new List<MvxViewPagerFragmentInfo>
                {
                    new MvxViewPagerFragmentInfo("", typeof(GetStartedFirstFragment),
                                                 typeof(GetStartedFirstViewModel)),
                    new MvxViewPagerFragmentInfo("", typeof(GetStartedSecondFragment),
                                                 typeof(GetStartedSecondViewModel)),
                    new MvxViewPagerFragmentInfo("", typeof(GetStartedThirdFragment),
                                                 typeof(GetStartedThirdViewModel)),
                };
                viewPager.Adapter = new MvxFragmentPagerAdapter(this, SupportFragmentManager, fragments);
            }

            var tabLayout = FindViewById<TabLayout>(Resource.Id.dots);
            tabLayout.SetupWithViewPager(viewPager, true);
        }
    }
}
