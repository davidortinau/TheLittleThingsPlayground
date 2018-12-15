using System;
using System.Collections.Generic;

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

    }
}
