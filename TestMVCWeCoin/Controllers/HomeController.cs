using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TestMVCWeCoin.Models;

namespace TestMVCWeCoin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostList()
        {
            const string apiBaseUri = "http://localhost:50505/";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUri);

                HttpResponseMessage response = client.GetAsync("api/values").Result;

                JArray jsonObject = JArray.Parse(response.Content.ReadAsStringAsync().Result);

                List<User> usuario = jsonObject.ToObject<List<User>>();

                return View(usuario);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}