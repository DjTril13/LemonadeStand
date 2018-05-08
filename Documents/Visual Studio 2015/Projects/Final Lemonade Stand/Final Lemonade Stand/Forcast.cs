using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;

namespace Final_Lemonade_Stand
{
    public class Forcast
    {
        public Forcast(string City)
        {
            city = City;
        }
        private string city;
        private float temperature;
        private float temperatureMax;
        private float temperatureMin;

        public void CheckWeather()
        {
            API DataAPI = new API(City);
            temperature = DataAPI.GetTemp();
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public float Temp
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public float TempMax
        {
            get { return temperatureMax; }
            set { temperatureMax = value; }
        }
        public float TempMin
        {
            get { return temperatureMin; }
            set { temperatureMin = value; }
        }
       
        }
    }

    


//} 5263045