using System;
using System.Collections.Generic;
using System.Windows.Input;
using TheLittleThingsPlayground.Utils;
using VisualTesting.Pages;
using Xamarin.Forms;

namespace TheLittleThingsPlayground.Views
{
    public partial class ThreeSixPage : ContentPage
    {
        public ICommand GoToVisualPage { get; set; }

        public ThreeSixPage()
        {
            InitializeComponent();

            GoToVisualPage = new Command<string>(NavToVisualPage);

            BindingContext = this;
        }

        private async void NavToVisualPage(string page)
        {
            Type targetPage = typeof(ButtonsPage);

            switch (page)
            {
                case "activityindicators": targetPage = typeof(ActivityIndicatorsPage); break;
                case "buttons": targetPage = typeof(ButtonsPage); break;
                case "cards": targetPage = typeof(CardsPage); break;
                case "editors": targetPage = typeof(Editors); break;
                case "entries": targetPage = typeof(EntriesPage); break;
                case "pickers": targetPage = typeof(Pickers); break;
                case "progress": targetPage = typeof(ProgressPage); break;
                case "sliders": targetPage = typeof(SlidersPage); break;
                case "steppers": targetPage = typeof(SteppersPage); break;
                default: break;
            }

            await Navigation.PushAsync((ContentPage)Activator.CreateInstance(targetPage), true);
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