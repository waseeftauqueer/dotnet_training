// UtilityBilling Class
using OnlineUtilityBIllingSystem;
using System;
using System.Linq;

public static class UtilityBilling
{
    public static double costPerUnit = 1.50;
    public static double serviceCharge = 50;
    private static double taxRate = 0.05;

    private static int totalUsageUnits = 0;

    public static void totalUsage(int[] readings)
    {
        totalUsageUnits = readings.Sum();
    }

    public static double calculateBill()
    {
        return totalUsageUnits * costPerUnit;
    }

    public static double getServiceCharge()
    {
        return serviceCharge;
    }

    public static void calculatedBill(out double total, out double tax, out double netPayable)
    {
   
        total = calculateBill();

        tax = total * taxRate;
        netPayable = total + tax + getServiceCharge();
    }

    public static void display(double total, double tax, double netPayable)
    {
        Console.WriteLine("Utility Bill Summary");
        Console.WriteLine($"Customer ID    : {Customer.getCustomerId()}");
        Console.WriteLine($"Customer Name  : {Customer.getCustomerName()}");
        Console.WriteLine($"Service Charge : {getServiceCharge()}");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Total Usage    : {totalUsageUnits} units");
        Console.WriteLine($"Base Bill      : " + total);
        Console.WriteLine($"Tax Applied    : " + tax);
        Console.WriteLine($"Net Payable    : " + netPayable);
    }
}