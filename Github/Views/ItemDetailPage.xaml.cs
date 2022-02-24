using Github.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Github.Views
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