using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PermissionsUISample.ViewModels
{
    public class PermissionUngrantedPageViewModel
    {
        public ICommand GoSettingsCommand { get; set; }
        public PermissionUngrantedPageViewModel()
        {
            GoSettingsCommand = new Command(() => AppInfo.ShowSettingsUI());
        }
    }
}
