using APS_Front.ViewModels;
using APS_Front.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace APS_Front
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
