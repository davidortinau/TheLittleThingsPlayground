using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLittleThingsPlayground.Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheLittleThingsPlayground.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThreeFourPage : ContentPage
    {
        public ThreeFourPage()
        {
            InitializeComponent();
        }

        private void ReleaseNotes_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.4/3.4.0/"));

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Wow", "Hello ImageButton!", "Cya");
        }

        async void ViewSource_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewSourcePage
            {
                Source = XamlUtil.GetXamlForType(typeof(ThreeFourPage))
            });
        }
    }
}