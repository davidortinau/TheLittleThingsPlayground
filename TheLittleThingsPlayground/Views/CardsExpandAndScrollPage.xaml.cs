using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheLittleThingsPlayground.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardsExpandAndScrollPage : ContentPage
    {
        public CardsExpandAndScrollPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Action<double> callback = input => Reviews.HeightRequest = input;
            double startingHeight = Reviews.Height;
            double endingHeight = 0;
            uint rate = 16;
            uint length = 600;
            Easing easing = Easing.CubicOut;

            if (Reviews.Height > 0)
            {
                (sender as Button).Text = System.Text.RegularExpressions.Regex.Unescape("\\uE972");
                endingHeight = 0;
            }
            else
            {
                (sender as Button).Text = System.Text.RegularExpressions.Regex.Unescape("\\uE70E");
                endingHeight = 440;
            }

            Reviews.Animate("invis", callback, startingHeight, endingHeight, rate, length, easing);

        }
    }
}