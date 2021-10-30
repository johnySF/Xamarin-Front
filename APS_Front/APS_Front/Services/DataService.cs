using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using APS_Front.Models;

namespace APS_Front.Services
{
    class DataService
    {
        string url = "https://localhost:44335/api/airpollution";
        HttpClient client;
        Poluicao ar = new Poluicao();

        public DataService()
        {
            client = new HttpClient();
            var responseContent = client.GetAsync(url).Result.Content.ReadAsStringAsync();
        }
    }
}