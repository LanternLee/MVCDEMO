using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.DAL;

namespace MvcDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        private Entities Db = new Entities();
        public ActionResult Index()
        {
            List<GENRE> genres = Db.GENRE.ToList<GENRE>();
            return View(genres);
        }
    }
}