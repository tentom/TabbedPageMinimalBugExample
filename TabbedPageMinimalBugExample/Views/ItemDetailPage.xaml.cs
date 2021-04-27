using System.ComponentModel;
using TabbedPageMinimalBugExample.ViewModels;
using Xamarin.Forms;

namespace TabbedPageMinimalBugExample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}