
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
using V7Search = Android.Support.V7.Widget;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using LittleCoffeeShop.Core.ViewModels.GettingStarted;
using LittleCoffeeShop.Droid.Activities.Base;
using Android.Widget;
using Android.Support.V4.Content;
using Android.Graphics;

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

            var toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "";
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu);

            V7Search.SearchView searchView = FindViewById<V7Search.SearchView>(Resource.Id.search);
            var textHint = searchView.FindViewById<TextView>(Resource.Id.search_src_text);
            textHint.SetTextColor(new Color(ContextCompat.GetColor(this,Resource.Color.text_hint)));
            textHint.SetTextSize(Android.Util.ComplexUnitType.Sp, 14);

            var searchMagIcon = searchView.FindViewById<ImageView>(Resource.Id.search_mag_icon);
            searchMagIcon.SetImageResource(Resource.Drawable.ic_search);
            searchMagIcon.SetColorFilter(new Color(ContextCompat.GetColor(this, Resource.Color.gray_tint)), PorterDuff.Mode.SrcIn);

            var searchClose = searchView.FindViewById<ImageView>(Resource.Id.search_close_btn);
            searchClose.SetImageResource(Resource.Drawable.ic_close);
            searchClose.SetColorFilter(new Color(ContextCompat.GetColor(this, Resource.Color.gray_tint)), PorterDuff.Mode.SrcIn);
        }
    }
}
