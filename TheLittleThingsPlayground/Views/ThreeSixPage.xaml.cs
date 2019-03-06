using System;
using System.Collections.Generic;
using TheLittleThingsPlayground.Utils;
using Xamarin.Forms;

namespace TheLittleThingsPlayground.Views
{
    public partial class ThreeSixPage : ContentPage
    {
        public ThreeSixPage()
        {
            InitializeComponent();
        }

        private void ReleaseNotes_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://docs.microsoft.com/xamarin/xamarin-forms/release-notes/3.6/3.6.0"));

        }

        async void ViewSource_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewSourcePage
            {
                Source = XamlUtil.GetXamlForType(typeof(ThreeSixPage))
            });
        }
    }
}