
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using LittleCoffeeShop.Core.ViewModels.GettingStarted;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;

namespace LittleCoffeeShop.Droid.Fragments.GettingStarted
{
    public class GetStartedSecondFragment : MvxFragment<GetStartedSecondViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.GetStartedSecondFragment, null);
            return view;
        }
    }
}
