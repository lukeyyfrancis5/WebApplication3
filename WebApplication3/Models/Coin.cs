using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Razor.Tokenizer.Symbols;
using Microsoft.Ajax.Utilities;

namespace WebApplication3.Models
{
    public class Coin
    {
        public int CoinId { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Coin(string symbol, string name, string price)
        {
            Symbol = symbol;
            Name = name;
            Price = Double.Parse(price, NumberStyles.Currency);
        }
    }
}