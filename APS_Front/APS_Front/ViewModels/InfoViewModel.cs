using APS_Front.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APS_Front.ViewModels
{
    public class InfoViewModel : BaseViewModel
    {
        public Command AirQualityCommand { get; }

        public InfoViewModel()
        {
            Title = "Informações";
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}