using Electrifiers_2._0.DAL;
using Electrifiers_2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace Electrifiers_2._0.BLL
{
    public class ElectricityBoard
    {
        private DBHandler dbHandler;

        // DB Connection
        public ElectricityBoard()
        {
            dbHandler = new DBHandler();
        }

        // Bill Calculation Method
        public void CalculateBill(ElectricityBill bill)
        {
            int units = bill.UnitsConsumed;
            double amount = 0;

            if (units <= 100)
                amount = 0;
            else if (units <= 300)
                amount = (units - 100) * 1.5;
            else if (units <= 600)
                amount = 200 * 1.5 + (units - 300) * 3.5;
            else if (units <= 1000)
                amount = 200 * 1.5 + 300 * 3.5 + (units - 600) * 5.5;
            else
                amount = 200 * 1.5 + 300 * 3.5 + 400 * 5.5 + (units - 1000) * 7.5;

            bill.BillAmount = amount;
        }

        // Checking existence of bill
        public bool IsBillExist(string consumerNumber, int month, int year)
        {
            using (SqlConnection connection = dbHandler.GetConnection())
            {
                string query = @"select count(*) from ElectricityBill 
                                 where ConsumerNumber = @ConsumerNumber and BillMonth = @Month and BillYear = @Year";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ConsumerNumber", consumerNumber);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Bill Adding to Database
        public void AddBill(ElectricityBill bill)
        {
            if (IsBillExist(bill.ConsumerNumber, bill.BillMonth, bill.BillYear))
                throw new Exception($"Bill already exists for {bill.ConsumerNumber} for {bill.BillMonth}/{bill.BillYear}");

            using (SqlConnection connection = dbHandler.GetConnection())
            {
                string query = @"insert into ElectricityBill 
                                (ConsumerNumber, ConsumerName, UnitsConsumed, BillAmount, BillMonth, BillYear, CreatedDate)
                                values (@ConsumerNumber, @ConsumerName, @UnitsConsumed, @BillAmount, @BillMonth, @BillYear, @CreatedDate)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ConsumerNumber", bill.ConsumerNumber);
                    cmd.Parameters.AddWithValue("@ConsumerName", bill.ConsumerName);
                    cmd.Parameters.AddWithValue("@UnitsConsumed", bill.UnitsConsumed);
                    cmd.Parameters.AddWithValue("@BillAmount", bill.BillAmount);
                    cmd.Parameters.AddWithValue("@BillMonth", bill.BillMonth);
                    cmd.Parameters.AddWithValue("@BillYear", bill.BillYear);
                    cmd.Parameters.AddWithValue("@CreatedDate", bill.CreatedDate);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ElectricityBill> GetBills(
            int lastN = 0,
            string consumerNumber = null,
            int? month = null,
            int? year = null,
            double? minAmount = null,
            double? maxAmount = null,
            DateTime? startDate = null,
            DateTime? endDate = null
        )
        {
            List<ElectricityBill> bills = new List<ElectricityBill>();

            using (SqlConnection conn = dbHandler.GetConnection())
            {
                StringBuilder query = new StringBuilder("SELECT * FROM ElectricityBill WHERE 1=1 ");

                // Add filters dynamically
                if (!string.IsNullOrEmpty(consumerNumber))
                    query.Append("AND ConsumerNumber = @ConsumerNumber ");
                if (month.HasValue)
                    query.Append("AND BillMonth = @Month ");
                if (year.HasValue)
                    query.Append("AND BillYear = @Year ");
                if (minAmount.HasValue)
                    query.Append("AND BillAmount >= @MinAmount ");
                if (maxAmount.HasValue)
                    query.Append("AND BillAmount <= @MaxAmount ");
                if (startDate.HasValue)
                    query.Append("AND CreatedDate >= @StartDate ");
                if (endDate.HasValue)
                    query.Append("AND CreatedDate <= @EndDate ");

                query.Append("ORDER BY CreatedDate DESC ");

                if (lastN > 0)
                    query.Append("OFFSET 0 ROWS FETCH NEXT @Top ROWS ONLY");

                using (SqlCommand cmd = new SqlCommand(query.ToString(), conn))
                {
                    if (!string.IsNullOrEmpty(consumerNumber))
                        cmd.Parameters.AddWithValue("@ConsumerNumber", consumerNumber);
                    if (month.HasValue)
                        cmd.Parameters.AddWithValue("@Month", month.Value);
                    if (year.HasValue)
                        cmd.Parameters.AddWithValue("@Year", year.Value);
                    if (minAmount.HasValue)
                        cmd.Parameters.AddWithValue("@MinAmount", minAmount.Value);
                    if (maxAmount.HasValue)
                        cmd.Parameters.AddWithValue("@MaxAmount", maxAmount.Value);
                    if (startDate.HasValue)
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Value);
                    if (endDate.HasValue)
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Value);
                    if (lastN > 0)
                        cmd.Parameters.AddWithValue("@Top", lastN);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ElectricityBill bill = new ElectricityBill
                            {
                                ConsumerNumber = reader["ConsumerNumber"].ToString(),
                                ConsumerName = reader["ConsumerName"].ToString(),
                                UnitsConsumed = Convert.ToInt32(reader["UnitsConsumed"]),
                                BillAmount = Convert.ToDouble(reader["BillAmount"]),
                                BillMonth = Convert.ToInt32(reader["BillMonth"]),
                                BillYear = Convert.ToInt32(reader["BillYear"]),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                            };
                            bills.Add(bill);
                        }
                    }
                }
            }

            return bills;
        }
    }
}