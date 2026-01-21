using Question2_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Question2_Server.Controllers
{
    public class OrderController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        // For ID 5
        public IHttpActionResult GetOrdersByEmployee()
        {
            var orders = db.Orders.Where(o => o.EmployeeID == 5).Select(o => new{o.OrderID,o.OrderDate, o.ShipCountry}).ToList();
            return Ok(orders);
        }
    }
}
