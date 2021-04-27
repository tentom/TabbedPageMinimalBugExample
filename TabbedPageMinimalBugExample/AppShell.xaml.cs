using System;
using System.Collections.Generic;
using TabbedPageMinimalBugExample.ViewModels;
using TabbedPageMinimalBugExample.Views;
using Xamarin.Forms;

namespace TabbedPageMinimalBugExample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
