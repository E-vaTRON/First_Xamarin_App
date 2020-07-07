using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace Fist_Xamarin_app.Models
{
    public class CameraCollection
    {
        public static ObservableCollection<Camera> CameraList() 
        {
            ObservableCollection<Camera> output = new ObservableCollection<Camera>();

            output.Add(new Camera { Brand = "Canon", Megapixel = "4096x2160/3360x2240", Model = "EOS 5D Mark IV", Zoom = 6, Price = 59690000 });
            output.Add(new Camera { Brand = "Canon", Megapixel = "6000x4000", Model = "Powershot G1 X Mark III", Zoom = 12, Price = 30590000 });
            output.Add(new Camera { Brand = "Sony", Megapixel = "5472x3648", Model = "DSC-RX10M4 E32", Zoom = 25, Price = 41490000 });
            output.Add(new Camera { Brand = "Sony", Megapixel = "3840x2160/1920x1080", Model = "ILCE-7RM3/BCAP2", Zoom = 4, Price = 72990000 });
            output.Add(new Camera { Brand = "Nikon", Megapixel = "3840x2160", Model = "COOLPIX P1000", Zoom = 125, Price = 22800000 });

            return output;
        }
    }
}
