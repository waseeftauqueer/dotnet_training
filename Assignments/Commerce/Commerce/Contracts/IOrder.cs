using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Contracts
{
    internal interface IOrder
    {
        int Id { get; }
        string BuyerEmail { get; }
        string ShipToCity { get; }
        string Status { get; }
        double TotalWeight { get; }
        int Items { get; }
    }
}
