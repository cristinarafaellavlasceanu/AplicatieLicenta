using AplicatieLicenta.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AplicatieLicenta.Views
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