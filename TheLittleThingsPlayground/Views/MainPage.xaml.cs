using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace TheLittleThingsPlayground.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            On<Windows>().SetHeaderIconsEnabled(true);
        }
    }
}