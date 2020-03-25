using System;
using System.Collections.Generic;
using PermissionsUISample.ViewModels;
using Xamarin.Forms;

namespace PermissionsUISample.Views
{
    public partial class PermissionPage : ContentPage
    {
        public PermissionPage()
        {
            InitializeComponent();
            BindingContext = new PermissionPageViewModel();
        }
    }
}
