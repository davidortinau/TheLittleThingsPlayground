using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheLittleThingsPlayground.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public Command TapCommand
        {
            get;
            private set;
        }

        public AboutPage()
        {
            InitializeComponent();
            TapCommand = new Command<string>(HandleAction);

            BindingContext = this;
            
        }

        async void HandleAction(string url)
        {
            //await Browser.OpenAsync(url);
            Device.OpenUri(new System.Uri(url));
        }
    }
}