using System;

namespace RideEasy
{
    internal class Ride
    {
        private Vehicle vehicle;
        private decimal distance;
        private DateTime rideDate;

        public Ride(Vehicle vehicle, decimal distance, DateTime rideDate)
        {
            this.vehicle = vehicle;
            this.distance = distance;
            this.rideDate = rideDate;
        }

        public void ComputeBill(out decimal subtotal, out decimal gst, out decimal total, params string[] addOns)
        {
            decimal baseFare = vehicle.vehicleBasePrice;
            decimal perKmRate = vehicle.vehiclePerKmRate;
            decimal distanceCost = distance * perKmRate;

            decimal addOnCost = Pricing.AddOnsCost(addOns);

            decimal weekendSurcharge = 0;
            Pricing.TryGetWeekendSurcharge(rideDate, out weekendSurcharge);

            subtotal = baseFare + distanceCost + addOnCost + weekendSurcharge;

            gst = Pricing.calculateGST(subtotal);

            total = subtotal + gst;

            decimal couponAmount = 50m;
            int loyaltyPoints = 100;

            Pricing.ApplyCoupon_ByRef(ref total, couponAmount);
            Pricing.RedeemLoyalty(ref loyaltyPoints, ref total);
        }
    }
}
