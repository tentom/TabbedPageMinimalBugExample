using System;
using System.Collections.Generic;
using System.ComponentModel;
using TabbedPageMinimalBugExample.Models;
using TabbedPageMinimalBugExample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageMinimalBugExample.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}