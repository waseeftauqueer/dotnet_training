using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasy
{
    internal class Pricing
    {   
        private static decimal gstAmount;
        private static decimal weekendSurCharge = 100;
      
        public static decimal calculateGST(decimal amount)
        {
            gstAmount = (amount * 18m   ) / 100;
            return gstAmount;
        }

        public static void TryGetWeekendSurcharge(DateTime rideDate, out decimal percent)
        {
            DayOfWeek day = rideDate.DayOfWeek;
            if(day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                percent = weekendSurCharge;
            }
            else
            {
                percent = 0;
            }
        }

        public static decimal AddOnsCost(params string[] addOns)
        {
            decimal addOnCost = 0;
            if (addOns.Length == 0) return 0;
            foreach (string ons in addOns)
            {
                if (ons == "child-seat") addOnCost += 80;
                else if (ons == "fast-tag") addOnCost += 60;
                else if (ons == "priority-pickup") addOnCost += 110;
                else if (ons == "extra-luggage") addOnCost += 30;
            }

            return addOnCost;
        }

        public static void ApplyCoupon_ByRef(ref decimal total, decimal couponAmount)
        {
            total += couponAmount;
        }

        public static void RedeemLoyalty(ref int points, ref decimal total)
        {
            total += (points * 10);
            points = 0;
        }
    }
}
