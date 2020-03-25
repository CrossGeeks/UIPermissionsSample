using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Threading.Tasks;
using PermissionsUISample.Views;

namespace PermissionsUISample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new PermissionPage());
          //  MainPage = new NavigationPage(new PermissionUngrantedPage());
          //  MainPage = new NavigationPage(new SinglePermissionPage());
        }
    }
}
