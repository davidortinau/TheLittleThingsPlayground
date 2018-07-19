using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TheLittleThingsPlayground.Views
{
    public partial class ThreeTwoPage : ContentPage
    {
        public ThreeTwoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            FirstEntry.CursorPosition = 4;
            FirstEntry.SelectionLength = 11;
        }
    }
}
