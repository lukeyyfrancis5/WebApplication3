using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        public virtual List<Ledger> Ledgers { get; set; }


    }
}