using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Currency
    {
        public enum ccy : byte { USD, EUR, RUR, BTC }
        public enum base_ccy { UAH, USD }
        public ccy Ccy { get; set; }
        public base_ccy Base_Ccy { get; set; }
        private double buy;
        private double sale;
        public double Buy
        {
            get => buy;
            set => buy = value;
        }
        public double Sale
        {
            get => sale;
            set => sale = value;
        }
        public Currency(ccy ccy, base_ccy base_ccy, double buy, double sale)
        {
            Ccy = ccy;
            Base_Ccy = base_ccy;
            Buy = buy;
            Sale = sale; 
        }
        // public Currency() : this(default(ccy), default(base_ccy), 0f, 0f) { }
        public override string ToString()
        {
            return $"Ccy : {Ccy}, base_ccy : {Base_Ccy}, buy : {Buy}, sale : {Sale}";
        }
    }
    class Course
    {
        private string fname;
        private const string Expansion = ".json";
        private List<Currency> currencies;
        public string FileName
        {
            get => fname;
            set => fname = value + Expansion;
        }
        public object JsonConvert { get; private set; }

        public Course(string fname)
        {
            FileName = fname;
            currencies = new List<Currency>();
            WebClient web = new WebClient();
            File.WriteAllText(FileName, web.DownloadString("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5"));
        }
        public void Print(Currency.ccy ccy, Currency.base_ccy base_ccy)
        {
            List<Currency> tmp = new List<Currency>();
            string json = File.ReadAllText(FileName);
            tmp = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Currency>>(json);
            
            foreach (var item in tmp)
            {
                if (ccy == item.Ccy && base_ccy == item.Base_Ccy)
                {
                    Console.WriteLine(item.ToString());
                    currencies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Currency>>(json);
                    foreach (var c in currencies)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
        }

    }
}
