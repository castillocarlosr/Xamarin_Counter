using System.ComponentModel;
using Xamarin.Forms;
using MobileCounter_X.ViewModels;

namespace MobileCounter_X.Views
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