using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp
{
    class MobilePhone
    {
        public string PhoneModel { get; set; }
        public string MarketName { get; set; }
        public string IMEI { get; set; }
        public string SerialNumber { get; set; }
        public string ReleaseDate { get; set; }



        public void GetPhones(string phoneBrand)
        {
           var GalaxyS8 = new MobilePhone();
            GalaxyS8.PhoneModel = "SM-G900DS";
            GalaxyS8.MarketName = "Galaxy S8";
            GalaxyS8.IMEI = "358098882300987";
            GalaxyS8.SerialNumber = "SM09DRS00G";
            GalaxyS8.ReleaseDate = "20 / 02 / 2017";

            Console.WriteLine($"Your phone is a {phoneBrand} {GalaxyS8.MarketName} {GalaxyS8.PhoneModel}");
        }
        
    }
}
