using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Kapanis
{
    public class Car
    {

        public Car() 
        {
            ProductionOfDate = DateTime.Now;                  //nesne oluşturduğunda üretim tarihi şimdiki tarihe atanacak
        }


        public DateTime ProductionOfDate { get; set; }        //üretim tarihi
        public string SerialNumber { get; set; }
        public string Brand { get; set; }                   //Marka
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }

       

    }
}
