using System;
using System.Collections.Generic;
using PermissionsUISample.ViewModels;
using Xamarin.Forms;

namespace PermissionsUISample.Views
{
    public partial class PermissionUngrantedPage : ContentPage
    {
        public PermissionUngrantedPage()
        {
            InitializeComponent();
            BindingContext = new PermissionUngrantedPageViewModel();
        }
    }
}
