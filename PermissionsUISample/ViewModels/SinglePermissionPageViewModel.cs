using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PermissionsUISample.ViewModels
{
    public class SinglePermissionPageViewModel
    {
        public ICommand GoHomeCommand { get; set; }
        public SinglePermissionPageViewModel()
        {
            GoHomeCommand = new Command(async () => await RequestPermissionAsync());
        }

        async Task RequestPermissionAsync()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
            if (status != PermissionStatus.Granted)
            {
                status = await Permissions.RequestAsync<Permissions.Camera>();
            }

            await App.Current.MainPage.DisplayAlert("Hey", "Welcome to my App", "Ok");
        }
    }
}
