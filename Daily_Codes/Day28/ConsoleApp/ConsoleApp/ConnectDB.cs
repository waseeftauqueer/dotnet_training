using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ConnectDB
    {

        public void ShowEmployee()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from employee", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");
            }
            con.Close();

        }

        public void AddEmployee()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            decimal newSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Date of Joinin: ");
            string doj = Console.ReadLine();
            Console.Write("Enter Dept id: ");
            int deptId = Convert.ToInt32(Console.ReadLine());

            SqlConnection con = new SqlConnection("Integrated Security=true;Database=PracticeDB;Server=(localdb)\\MSSQLLocalDB");

            con.Open();

            string query =$"insert into Employee (EmpName, Salary, DateOfJoin, DeptID) " + $"values ('{name}', {newSalary}, '{doj}', {deptId})";
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = cmd.ExecuteNonQuery();

            Console.WriteLine("Total Records Inserted: " + rows);

            con.Close();
        }


        public void DeleteEmployee(int employeeId)
        {

            SqlConnection con = new SqlConnection("Integrated security = true; database = PracticeDB; server = (localdb)\\MSSQLLocalDB");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from employee where EmpID = "+ employeeId, con); 

            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Inserted is " + rowaffected);

            con.Close();
        }


        public void UpdateEmployee()
        {
            Console.Write("enter Employee Id to update: ");
            int empId = Convert.ToInt16(Console.ReadLine());

            Console.Write("enter new name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter New Salary: ");
            decimal newSalary = Convert.ToDecimal(Console.ReadLine());

            SqlConnection con = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");

            con.Open();

            string query = "update Employee set EmpName = '" + newName + "', Salary = " + newSalary + " where EmpID = " + empId;
            SqlCommand cmd = new SqlCommand(query, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Inserted is " + rowaffected);

            con.Close();
        }

        public void Showprocedure()
        {

            SqlConnection con = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_getemp", con);

            SqlParameter p1 = new SqlParameter("@d", 10);
            SqlParameter p2 = new SqlParameter("@sal", 46000);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);


            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");

            }
            con.Close();
        }

        public void EmpTransaction()
        {
            SqlTransaction tr = null;

            try
            {
                SqlConnection con = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");
                con.Open(); 

                tr = con.BeginTransaction();

                SqlCommand cmd1 = new SqlCommand("insert into one values(2,'vijay')", con);
                SqlCommand cmd2 = new SqlCommand("insert into two values(1,'vijay')", con);

                cmd1.Transaction = tr;
                cmd2.Transaction = tr;
                int rowaffected1 = cmd1.ExecuteNonQuery();
                int rowaffected2 = cmd2.ExecuteNonQuery();
                Console.WriteLine("Total Records Inserted is " + rowaffected1);
                Console.WriteLine("Total Records Inserted is " + rowaffected2);
                tr.Commit();
                con.Close();

            }
            catch (Exception ex)
            {
                tr.Rollback();
                Console.WriteLine("Could not complete.. try again...");
            }
        }
    }
}

