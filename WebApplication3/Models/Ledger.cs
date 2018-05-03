using System;
using System.Collections;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Ledger
    {
        public int LedgerId { get; set; }
        public DateTime Time { get; set; }
        public List<Coin> Coins { get; set; }
        
        public virtual Account Account { get; set; }

        public Ledger(DateTime time)
        {
            Time = time;
        }
    }
   
}