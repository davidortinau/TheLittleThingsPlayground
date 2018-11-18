using System;
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
    }
}
