using System;
using System.Net;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            string xml = webClient.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp");
            XDocument xDocument = XDocument.Parse(xml);
            IEnumerable<XElement> elem = xDocument.Descendants("Valute");
            foreach (var item in elem)
            {
                if(item.Element("Name").Value == "Гонконгских долларов")
                {
                    string gkDollar = item.Element("Value").Value;
                    string gkNominal = item.Element("Nominal").Value;
                    try
                    {
                        double i_gkDollar = double.Parse(gkDollar);
                        double i_gkNominal = double.Parse(gkNominal);
                        Console.WriteLine("Курс гонконгского доллара к российскому рублю: " + (i_gkDollar / i_gkNominal).ToString());
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка!!!");
                    }
                }
            }
        }
    }
}
