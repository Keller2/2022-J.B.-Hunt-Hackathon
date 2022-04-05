/*using System;
using System.Net.Http;
using System.Collections.Generic;
//
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml;
//using System.Threading.Tasks;
*/
using System.Net.Http;
//using namespace std;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System;
using System.Linq;
using HtmlAgilityPack;
//using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace email_Scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            GetHtml(); // was originaly a program to scrape html just havent changed he name
            Console.ReadLine();
            GetHtml(); // runs the email program 3 times
            Console.ReadLine();
            GetHtml();
            Console.ReadLine();
            GetHtml();

        }
        private static async void GetHtml()
        {
            Console.WriteLine("This program currently doesnt work see code for more information");
            delay(6000); // delete this line once you have fixed the later comment
            Console.WriteLine("Enter first name:");
            string var2 = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string var3 = Console.ReadLine();
            string var1 = "url of query should end with query?="; // this program wont work with out the proper url
            var search = var1 + var2 + var3;
            //Console.Write(search);
            WebClient client = new WebClient();
            string output = client.DownloadString(search);

            dynamic outpt = JsonConvert.DeserializeObject<dynamic>(output);
            string email = outpt[0]["Email"];// change "email" to what ever your looking for in the JSON file

            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(email);
        }

        void init()
        {
            GetHtml();
        }
    }
    internal class Webclient : WebClient
    {
    }
}
