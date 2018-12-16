using System;
using System.Collections.Generic;
using TheLittleThingsPlayground.Utils;
using Xamarin.Forms;

namespace TheLittleThingsPlayground.Views
{
    public partial class ThreeFivePage : ContentPage
    {
        public ThreeFivePage()
        {
            InitializeComponent();
        }

        private void ReleaseNotes_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.5/3.5.0-pre1/"));

        }

        async void ViewSource_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewSourcePage
            {
                Source = XamlUtil.GetXamlForType(typeof(ThreeFivePage))
            });
        }
    }
}
