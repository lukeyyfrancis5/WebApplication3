
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CryptoData()
        {
            ViewBag.Message = "Here are the current top 100 coins !";
            ViewBag.Time = DateTime.Now;

            var url = "https://coinmarketcap.com/";

            var htmlWeb = new HtmlWeb();

            var htmlDocument = new HtmlDocument();
            htmlDocument = htmlWeb.Load(url);

            HtmlNodeCollection allRows = htmlDocument.DocumentNode.SelectNodes("//table[1]/tbody[1]/tr[*]");
            //var rowNumber = 0;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
            
            List<Coin> currencyDataList = new List<Coin>();
            List<DateTime> ledgerList = new List<DateTime>();
            foreach (var row in allRows)
            {
                // Console.WriteLine("Attempting to process row: " + rowNumber++);

                var CoinSymbol = row.ChildNodes[3].ChildNodes[3].InnerText;
                var CoinName = row.ChildNodes[3].ChildNodes[5].InnerText;
                var CoinPrice = row.ChildNodes[7].InnerText;

                Coin coin = new Coin(CoinSymbol, CoinName, CoinPrice);
                currencyDataList.Add(coin);
            }

            //using (var db = new AccountContext())
            //{
            //    var ledger = new Ledger(
            //    {
            //        Coins = currencyDataList,
            //        Time = ledgerList
            //    };
            //    db.Ledgers.Add(ledgerList);
            //    db.SaveChanges();
            //}

                //using (var db = new AccountContext())
                //{
                //    var ledger = new Ledger
                //    {
                //        Coins = currencyDataList,
                //        Time = time;
                //};

    

        //}

            return View(currencyDataList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}