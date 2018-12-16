using System;
using TheLittleThingsPlayground.Utils;
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

        public Command SwipeCommand
        {
            get;
            private set;
        }

        public ThreeTwoPage()
        {
            InitializeComponent();

            TapCommand = new Command<string>(HandleAction);
            SwipeCommand = new Command(HandleSwipeAction);

            BindingContext = this;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            MakeSelection();
        }

        private async void HandleSwipeAction()
        {
            await DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture!", "Close");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MakeSelection();
        }

        private void MakeSelection()
        {
            FirstEntry.Focus();
            FirstEntry.CursorPosition = 4;
            FirstEntry.SelectionLength = 11;
        }

        async void HandleAction(string url)
        {
            // await Browser.OpenAsync(url);
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://microsoft.com"));
        }

        private void ReleaseNotes_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.2/3.2.0/"));

        }

        async void ViewSource_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewSourcePage
            {
                Source = XamlUtil.GetXamlForType(typeof(ThreeTwoPage))
            });
        }
    }
}
