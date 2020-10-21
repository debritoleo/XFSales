using Xamarin.Forms;
using XFSales.ViewModels;

namespace XFSales
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(Navigation);
        }
    }
}
