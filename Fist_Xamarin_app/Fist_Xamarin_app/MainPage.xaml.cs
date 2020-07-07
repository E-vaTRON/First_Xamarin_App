using Fist_Xamarin_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace Fist_Xamarin_app
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly string CameraUrl = "https://localhost:5001/api/Cameras/GetCameras";
        private static readonly HttpClientHandler handler = new HttpClientHandler();
        private readonly HttpClient httpClient;
        private ObservableCollection<Camera> Cameras;
        public MainPage()
        {
            InitializeComponent();
            //handler.ServerCertificateCustomValidationCallback = (message, certificate, chain, sslPolicyErrors) => true;
            //httpClient = new HttpClient(handler);
            ObservableCollection<Camera> output = CameraCollection.CameraList();
            CameraList.ItemsSource = output;

//            GetCameras();
        }
//        private async Task GetCameras()
//        {
//            var response = await httpClient.GetAsync(CameraUrl);
//            var result = await response.Content.ReadAsStringAsync();
//            System.Diagnostics.Debug.WriteLine(result);
//            Cameras = JsonConvert.DeserializeObject<ObservableCollection<Camera>>(result);
//            CameraList.ItemsSource = Cameras;
//        }
    }
}
