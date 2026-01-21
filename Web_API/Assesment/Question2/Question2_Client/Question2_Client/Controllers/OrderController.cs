using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Question2_Client.Models;

namespace Question2_Client.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult DisplayOrders()
        {
            IEnumerable<Order> orderList = null;

            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44344//api/");
                var responsetalk = webclient.GetAsync("Order");
                responsetalk.Wait();

                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultdata = result.Content.ReadAsStringAsync().Result;
                    orderList = JsonConvert.DeserializeObject<List<Order>>(resultdata);
                }
                else
                {
                    orderList = Enumerable.Empty<Order>();
                }

                return View(orderList);
            }
        }
    }
}