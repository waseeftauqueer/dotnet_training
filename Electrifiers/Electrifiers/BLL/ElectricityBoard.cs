using Electrifiers.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Electrifiers.DAL;

namespace Electrifiers.Validators
{
    public class ElectricityBoard
    {
        public void CalculateBill(ElectricityBill ebill)
        {
            int units = ebill.UnitsConsumed;
            double bill = 0;
            int remaining = units;

            remaining -= Math.Min(100, remaining);

            if (remaining > 0)
            {
                int a = Math.Min(200, remaining);
                bill += a * 1.5;
                remaining -= a;
            }

            if (remaining > 0)
            {
                int a = Math.Min(300, remaining);
                bill += a * 3.5;
                remaining -= a;
            }

            if (remaining > 0)
            {
                int a = Math.Min(400, remaining);
                bill += a * 5.5;
                remaining -= a;
            }

            if (remaining > 0)
            {
                bill += remaining * 7.5;
            }

            ebill.BillAmount = bill;
        }
        public void AddBill(ElectricityBill ebill)
        {
            DBHandler db = new DBHandler();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "insert into ElectricityBill " + "(consumer_number, consumer_name, units_consumed, bill_amount) " +
                           "values (@num, @name, @units, @amount)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@num", ebill.ConsumerNumber);
                 cmd.Parameters.AddWithValue("@name", ebill.ConsumerName);
                cmd.Parameters.AddWithValue("@units",ebill.UnitsConsumed);
                cmd.Parameters.AddWithValue("@amount", ebill.BillAmount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<ElectricityBill> N_BillDetails(int num)
        {
            List<ElectricityBill> bills = new List<ElectricityBill>();
            DBHandler db = new DBHandler();

            using (SqlConnection conn = db.GetConnection())
            {
                string query = "select top (@n) * from ElectricityBill order by consumer_number desc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@n", num);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElectricityBill ebill = new ElectricityBill();
                    ebill.ConsumerNumber = reader["consumer_number"].ToString();
                    ebill.ConsumerName = reader["consumer_name"].ToString();
                    ebill.UnitsConsumed = Convert.ToInt32(reader["units_consumed"]);
                    ebill.BillAmount = Convert.ToDouble(reader["bill_amount"]);
                    bills.Add(ebill);
                }
            }

            return bills;
        }
    }
}