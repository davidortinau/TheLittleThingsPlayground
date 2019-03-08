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
    public partial class CardExpandPage : ContentPage
    {
        public CardExpandPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Action<double> callback = input => ForecastGrid.HeightRequest = input;
            double startingHeight = ForecastGrid.Height;
            double endingHeight = 0;
            uint rate = 16;
            uint length = 600;
            Easing easing = Easing.CubicOut;

            if (ForecastGrid.Height > 0)
            {
                (sender as Label).Text = "EXPAND";
                endingHeight = 0;
            }
            else
            {
                (sender as Label).Text = "COLLAPSE";
                endingHeight = 140;
            }            
            
            ForecastGrid.Animate("invis", callback, startingHeight, endingHeight, rate, length, easing);
        }
    }
}