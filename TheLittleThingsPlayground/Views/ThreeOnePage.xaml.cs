using System;
using System.Collections.Generic;
using Xamarin.Essentials;
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
        }

        private void ReleaseNotes_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.1/3.1.0/");

        }
    }
}
