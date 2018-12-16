using System;
using TheLittleThingsPlayground.Utils;
using Xamarin.Forms;

namespace TheLittleThingsPlayground.Views
{
    public partial class ThreeThreePage : ContentPage
    {
        public ThreeThreePage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PushModalAsync(new ModalPage(), true);
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new SimpleWebView(), true);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (TruncatedLabel.MaxLines == 4)
            {
                TruncatedLabel.MaxLines = 20;
                ReadButton.Text = "[read less]";
            }
            else
            {
                TruncatedLabel.MaxLines = 4;
                ReadButton.Text = "[read more]";
            }

        }

        private void ReleaseNotes_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.3/3.3.0/"));

        }

        async void ViewSource_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewSourcePage
            {
                Source = XamlUtil.GetXamlForType(typeof(ThreeThreePage))
            });
        }
    }
}
