using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace TheLittleThingsPlayground.Views
{
    public partial class ThreeOnePage : ContentPage
    {
        public string YourName
        {
            get;
            private set;
        } =
            "David Ortinau";

        public ThreeOnePage()
        {
            InitializeComponent();

            BindingContext = this;

            //ShadowBox.On<iOS>().SetShadowOffset(new Size(0, 20));
        }
    }
}
