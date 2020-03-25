using PermissionsUISample.ViewModels;
using Xamarin.Forms;

namespace PermissionsUISample.Views
{
    public partial class SinglePermissionPage : ContentPage
    {
        public SinglePermissionPage()
        {
            InitializeComponent();
            BindingContext = new SinglePermissionPageViewModel();
        }
    }
}
