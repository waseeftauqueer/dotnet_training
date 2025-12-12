using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Test_DEC_12
{
    internal class ConnectedArchitecture
    {
        public void DisplayCourse()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=AdoDB;server=(localdb)\\MSSQLLocalDB");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Courses", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]} ");
            }
            con.Close();
        }

        public void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fullname: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Department : ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter Year of Study : ");
            int year =Convert.ToInt32(Console.ReadLine());
            

            SqlConnection con = new SqlConnection("Integrated Security=true;Database=AdoDB;Server=(localdb)\\MSSQLLocalDB");

            con.Open();

            string query = "insert into Students (StudentId, FullName, Email, Department, YearOfStudy) " +
                           "values (@Id, @Name, @Email, @Department, @Year)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email",email);
            cmd.Parameters.AddWithValue("@Department",department);
            cmd.Parameters.AddWithValue("@Year",year);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Inserted: " +rows);
        }

        public void SearchByDepartment()
        {
            Console.WriteLine("Enter the Department : ");
            string department = Console.ReadLine();

            SqlConnection con = new SqlConnection("Integrated Security=true;Database=AdoDB;Server=(localdb)\\MSSQLLocalDB");

            con.Open();
            string query = "select StudentId, FullName from Students where Department =@dept";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("dept", department);

            SqlDataReader dr =cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}   {dr[1]} ");
            }
            con.Close();
        }

        public void EnrolledCourses()
        {
            Console.WriteLine("Enter the StudentId : ");
            int id = Convert.ToInt32(Console.ReadLine());

            SqlConnection con =new SqlConnection("Integrated Security=true;Database=AdoDB;Server=(localdb)\\MSSQLLocalDB");
            con.Open();
            string query = "select c.CourseName, c.Credits, e.EnrollDate, e.Grade from Enrollments e inner join Courses c on e.CourseId = c.CourseId where e.StudentId =@StudentId";
            SqlCommand cmd = new SqlCommand(query,con);

            cmd.Parameters.AddWithValue("@StudentId", id);
            SqlDataReader dr =cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]} ");
            }

            con.Close();
        }

        public void UpdateGrade()
        {
            Console.WriteLine("Enter StudentId : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Grade : ");
            string grade = Console.ReadLine();

            SqlConnection con = new SqlConnection("Integrated Security=true;Database=AdoDB;Server=(localdb)\\MSSQLLocalDB");
            con.Open();

            string query = "update Enrollments set Grade =@gr where StudentId = @sid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@sid",id);
            cmd.Parameters.AddWithValue("@gr",grade);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Inserted: " +rows);
            con.Close();
        }
    }
}
