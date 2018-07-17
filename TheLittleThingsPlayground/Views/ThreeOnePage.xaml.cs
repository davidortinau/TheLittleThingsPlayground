using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace TheLittleThingsPlayground.Views
{
    public partial class ThreeOnePage : ContentPage
    {
        public ThreeOnePage()
        {
            InitializeComponent();

            //ShadowBox.On<iOS>().SetShadowOffset(new Size(0, 20));
        }
    }
}
