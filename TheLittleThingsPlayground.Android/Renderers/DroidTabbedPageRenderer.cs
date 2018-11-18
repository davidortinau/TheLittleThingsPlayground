using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Internal;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using TheLittleThingsPlayground.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

#if __ANDROID81__
#else
using ALabelVisibilityMode = Android.Support.Design.BottomNavigation.LabelVisibilityMode;
#endif

[assembly: ExportRenderer(typeof(TabbedPage), typeof(DroidTabbedPageRenderer))]
namespace TheLittleThingsPlayground.Droid.Renderers
{
    public class DroidTabbedPageRenderer : Xamarin.Forms.Platform.Android.AppCompat.TabbedPageRenderer
    {
        public DroidTabbedPageRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            var activity = (FormsAppCompatActivity)Context;

            if (e.NewElement != null)
            {
                var relativeLayout = this.GetChildAt(0) as Android.Widget.RelativeLayout;
                if (relativeLayout != null)
                {
                    var bottomNarView = relativeLayout.GetChildAt(1).JavaCast<BottomNavigationView>();
                    bottomNarView.SetShiftMode(false, false);
                }
            }
        }
    }

    public static class BottomNavigationViewUtils
    {
        public static void SetShiftMode(this BottomNavigationView bottomNavigationView, bool enableShiftMode, bool enableItemShiftMode)
        {
            try
            {
                using (var menuView = bottomNavigationView.GetChildAt(0) as BottomNavigationMenuView)
                {
                    if (menuView == null)
                    {
                        System.Diagnostics.Debug.WriteLine("Unable to find BottomNavigationMenuView");
                        return;
                    }

#if __ANDROID81__
					var shiftMode = menuView.Class.GetDeclaredField("mShiftingMode");
					shiftMode.Accessible = true;
					shiftMode.SetBoolean(menuView, enableShiftMode);
					shiftMode.Accessible = false;
					shiftMode.Dispose();
#else
                    if (enableShiftMode)
                        bottomNavigationView.LabelVisibilityMode = ALabelVisibilityMode.LabelVisibilityAuto;
                    else
                        bottomNavigationView.LabelVisibilityMode = ALabelVisibilityMode.LabelVisibilityLabeled;
#endif

                    for (int i = 0; i < menuView.ChildCount; i++)
                    {
                        var child = menuView.GetChildAt(i);
                        var item = child as BottomNavigationItemView;
                        if (item != null)
                        {
#if __ANDROID81__
							item.SetShiftingMode(enableItemShiftMode);
#else
                            item.SetShifting(enableItemShiftMode);
#endif
                            item.SetChecked(item.ItemData.IsChecked);
                        }

                        child.Dispose();
                    }

                    menuView.UpdateMenuView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Unable to set shift mode: {ex}");
            }
        }
    }
}