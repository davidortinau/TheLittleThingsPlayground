using System;
using System.Collections.Generic;

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
    }
}
