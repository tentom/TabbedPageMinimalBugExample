using System;
using TabbedPageMinimalBugExample.Services;
using TabbedPageMinimalBugExample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageMinimalBugExample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
