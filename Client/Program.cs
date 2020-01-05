using Minhalib2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teste Scrape!! \n");

            Scrape myscrape = new Scrape();
            string v = myscrape.ScrapeWebpage("https://pt.wikipedia.org/wiki/C_Sharp");
            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
