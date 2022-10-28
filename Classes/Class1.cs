using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }


        public Car()
        {

        }
        public Car(string brand, string model, string year)
        {
            Name = brand;
            Model = model;
            Year = year;
        }


    }
}
