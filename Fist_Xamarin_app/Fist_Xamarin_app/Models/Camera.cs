using System;
using System.Collections.Generic;
using System.Text;

namespace Fist_Xamarin_app.Models
{
    public class Camera
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public DateTime YearManufact { get; set; }
        //public ICollection<Comment> Comments { get; set; }
        public int CameraID { get; set; }
        public string Megapixel { get; set; }
        public string Sensor { get; set; }
        public int Zoom { get; set; }
        public int NumberOfLength { get; set; }
    }
}
