using CVEDashboard.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVEDashboard.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            DBMethods dbMethods = new DBMethods();
            SqlDataReader reader = dbMethods.getReader("SELECT name FROM tbl_names WHERE id = 1");
            String name = "";
            while (reader.Read())
            {
                 name = reader.GetString(0);
            }

            ViewBag.returnName = name;
            return View();
        }

    }
}