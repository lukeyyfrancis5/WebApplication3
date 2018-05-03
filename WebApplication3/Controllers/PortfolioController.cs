using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PortfolioController : Controller
    {
        private AccountContext _context;


        public PortfolioController()
        {
            _context = new AccountContext();
        }
        // GET: Portfolio
        public ViewResult PortfolioVR()
        {
                        
             var ledgerTime = _context.Ledgers.Include(l => l.Time).ToList();
            // ReSharper disable once Mvc.ViewNotResolved
             return View(ledgerTime);
            
                
        }   
    }
}