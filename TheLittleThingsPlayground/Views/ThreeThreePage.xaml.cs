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

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(TruncatedLabel.MaxLines == 4)
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
    }
}
