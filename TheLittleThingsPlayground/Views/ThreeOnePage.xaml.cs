using System;
using TheLittleThingsPlayground.Utils;
using Xamarin.Forms;

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
            Device.OpenUri(new System.Uri("https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.1/3.1.0/"));

        }

        async void ViewSource_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewSourcePage
            {
                Source = XamlUtil.GetXamlForType(typeof(ThreeOnePage))
            });
        }
    }
}
