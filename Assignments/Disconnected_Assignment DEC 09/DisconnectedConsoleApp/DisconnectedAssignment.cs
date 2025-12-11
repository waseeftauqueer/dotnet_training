using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedConsoleApp
{
    internal class DisconnectedAssignment
    {
        DataSet ds = new DataSet();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();

        public void DisplayRecords()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");
            da1 = new SqlDataAdapter("select * from Employee", con);
            da2 = new SqlDataAdapter("select * from Department", con);

            da1.Fill(ds, "emp");
            dt1 = ds.Tables["emp"];

            da2.Fill(ds, "dept");
            dt2 = ds.Tables["dept"];

            Console.WriteLine("Employee Data : ");
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                Console.WriteLine(dt1.Rows[i][0]);
                Console.WriteLine(dt1.Rows[i][1]);
                Console.WriteLine(dt1.Rows[i][2]);
                Console.WriteLine(dt1.Rows[i][3]);
                Console.WriteLine(dt1.Rows[i][4]);
            }

            Console.WriteLine("Department Data : ");
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                Console.WriteLine(dt2.Rows[i][0]);
                Console.WriteLine(dt2.Rows[i][1]);
            }

        }

        public void FilterForEmployee()
        {
            DataView dv = new DataView(dt1);

            dv.RowFilter = "salary > 47000 and Deptid = 10 and EmpName like 'M%'";
            dv.Sort = "EmpName asc";
            foreach (DataRowView item in dv)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
            }
        }

        public void TotalTables()
        {
            int noTables = ds.Tables.Count;
            Console.WriteLine("Number of tables inside the Dataset : " + noTables);
        }

        public void DeptTableLoader()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");
            DataTable dt = new DataTable();
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Department", con);
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            dr.Close();

            Console.WriteLine("Department Data : ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.Write(dt.Rows[i][0] + " ");
                Console.Write(dt.Rows[i][1]);
                Console.WriteLine();
            }
        }

        public void MergeDataSets()
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            SqlConnection con = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");
            SqlDataAdapter daa1 = new SqlDataAdapter("select * from customers", con);
            SqlDataAdapter daa2 = new SqlDataAdapter("select * from orders", con);

            daa1.Fill(ds1, "Customer");

            daa2.Fill(ds2, "Orders");

            ds1.Merge(ds2);

            foreach (DataRow row in ds1.Tables["Customer"].Rows)
            {
                Console.WriteLine($"{row[0]}  {row[1]}");
            }

            foreach (DataRow row in ds1.Tables["Orders"].Rows)
            {
                Console.WriteLine($"{row[0]}  {row[1]}  {row[2]}  {row[3]}");
            }
           
        }

        public void ReadXMLDataSource()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"C:\dotnet_training\Assignments\DisconnectedConsoleApp\DisconnectedConsoleApp\XMLFile1.xml");

            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"{row["CUSTID"]}\t{row["CUSTNAME"]}\t{row["CUSTADDRESS"]}\t{row["PHONE"]}");
                }
            }
            else
            {
                Console.WriteLine("No data found in XML.");
            }

            Console.ReadLine();
        }
    }
}
