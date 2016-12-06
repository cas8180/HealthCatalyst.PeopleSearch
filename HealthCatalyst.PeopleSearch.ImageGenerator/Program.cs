using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PeopleSearch.ImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputImageFolder = @"C:\Users\william.fawthrop\Documents\HealthCatalyst.PeopleSearch2\HealthCatalyst.PeopleSearch\HealthCatalyst.PeopleSearch.Web\Content\images\{0}.jpg";
            for (int i = 0; i < 200; i++)
            {
              GetRanImage(string.Format(outputImageFolder, i), i);
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void GetRanImage(string fileName, int id)
        {
            using (WebClient client = new WebClient())
            {
                 client.DownloadFileAsync(new Uri($"https://placeimg.com/35/35/people/{id}"), fileName);
            }
        }
    }
}
