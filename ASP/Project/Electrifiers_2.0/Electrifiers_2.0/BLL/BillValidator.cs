using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Electrifiers_2._0.BLL
{
    public class BillValidator
    {
        // Consumber Number Validation
        public void ValidateConsumerNumber(string consumerNumber)
        {
            if (!Regex.IsMatch(consumerNumber, @"^EB\d{5}$"))
                throw new FormatException("Invalid Consumer Number");
        }

        // Units Validation
        public void ValidateUnitsConsumed(int units)
        {
            if (units < 0)
                throw new ArgumentException("Given units is invalid");
        }

        // Month Validation
        public void ValidateMonth(int month)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("Invalid month value");
        }

        // Year Validation
        public void ValidateYear(int year)
        {
            if (year < 2000 || year > 2100)
                throw new ArgumentException("Invalid year value");
        }
    }
}