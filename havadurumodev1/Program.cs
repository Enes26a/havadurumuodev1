using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace havadurumodev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hava Durumu - Ödev 1

            Console.WriteLine("Lütfen hava durumunu öğrenmek istediğiniz şehrin adını giriniz");

            string sehir = Console.ReadLine();

            string link = "https://api.openweathermap.org/data/2.5/weather?q=" + sehir + "&lang=tr&units=metric&mode=xml&appid=e4b7070abab1899610fd58316c8d4c53";

            XDocument havadurumu = XDocument.Load(link);

            string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            Console.WriteLine("İl = " + sehir);
            Console.WriteLine("Sıcaklık = " + havasicaklik + " Hava Durumu = " + durum);

            #endregion


        }
    }
}
