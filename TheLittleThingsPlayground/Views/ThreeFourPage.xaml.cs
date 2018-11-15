using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheLittleThingsPlayground.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThreeFourPage : ContentPage
	{
		public ThreeFourPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.4/3.4.0/");

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Nice tap!", "Close");
        }
    }
}