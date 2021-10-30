using APS_Front.ViewModels;
using APS_Front.Views;
using APS_Front.Models;
using APS_Front.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace APS_Front.Views
{
    public partial class InfoPage : ContentPage
    {
        InfoViewModel _viewModel;

        public InfoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        public async void OnAirQuality(object sender, EventArgs args)
        {

            await App.Current.MainPage.DisplayAlert("Carbono", "400ppm", "Ok");
        }

        public async void OnAmnonia(object sender, EventArgs args)
        {

            await App.Current.MainPage.DisplayAlert("Amônia", "Níveis normais", "Ok");
        }
        public async void OnHumidity(object sender, EventArgs args)
        {

            await App.Current.MainPage.DisplayAlert("Humidade", "35%", "Ok");
        }
    }
}