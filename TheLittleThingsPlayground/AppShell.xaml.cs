using System;
using System.Collections.Generic;
using TheLittleThingsPlayground.Views;
using Xamarin.Forms;

namespace TheLittleThingsPlayground
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("source", typeof(ViewSourcePage));
        }
    }
}
