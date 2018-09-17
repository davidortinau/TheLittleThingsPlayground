using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TheLittleThingsPlayground.Views
{
    public partial class ThreeTwoPage : ContentPage
    {
        public string Url
        {
            get;
            private set;
        } = "xamarin.com";

        public Command TapCommand
        {
            get;
            private set;
        }

        public ThreeTwoPage()
        {
            InitializeComponent();

            TapCommand = new Command<string>(HandleAction);

            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            FirstEntry.CursorPosition = 4;
            FirstEntry.SelectionLength = 11;
        }

        async void HandleAction(string url)
        {
            await Browser.OpenAsync(url);
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            await Browser.OpenAsync("https://microsoft.com");
        }
    }
}
