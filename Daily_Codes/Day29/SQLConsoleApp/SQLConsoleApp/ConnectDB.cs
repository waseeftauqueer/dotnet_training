using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLConsoleApp
{
    internal class ConnectDB
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        public void ShowAllEmployee()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");
            da = new SqlDataAdapter("select * from employee", con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            da.Fill(ds, "emp");
            dt = ds.Tables["emp"];


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][2]);
                Console.WriteLine(dt.Rows[i][3]);
                Console.WriteLine(dt.Rows[i][4]);
            }
        }

        public void SearchEmployee()
        {
            Console.WriteLine("Enter the Employee ID : ");
            int Id = int.Parse(Console.ReadLine());
            DataRow dr = dt.Rows.Find(Id);

            if(dr != null)
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine(dr[4]);
            }
            else
            {
                Console.WriteLine("No such key exists");
            }
        }
        public void AddEmployee()
        {

            dt.Rows.Add(null, "Raj1", 30000, "1-1-2000", 10);
            dt.Rows.Add(null, "vijay1", 31000, "1-1-2001", 20);

            int rowsaffected = da.Update(dt);
            Console.WriteLine("total rows inserted is " + rowsaffected);
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("enter the id");
            int id = int.Parse(Console.ReadLine());
            DataRow drr = dt.Rows.Find(id);

            drr.Delete();

            int rowsaffected = da.Update(dt);
            Console.WriteLine("total rows Deleted is " + rowsaffected);
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("enter the id");
            int id = int.Parse(Console.ReadLine());
            DataRow drr = dt.Rows.Find(id);

            drr[2] = 65000;

            int rowsaffected = da.Update(dt);
            Console.WriteLine("total rows updated is " + rowsaffected);


        }

        public void FilterEmployee()
        {
            Console.WriteLine("Rows after filter is as follows ");
            Console.WriteLine("===================================================");
            DataView dv = new DataView(dt);

            //  dv.RowFilter = "salary > 40000 and Deptid = 10";
            dv.RowFilter = "EmpName like 'M%'";
            foreach (DataRowView item in dv)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
            }

        }
        public void StoreinXML()
        {


            // ds.ReadXml(); reads the xml file and stores in dataset
            // ds.WriteXml(); creates xml file and write all dataset records to xml

            // ds.WriteXml("d:\\employee.xml");

            dt.Rows.Add(null, "Raj1", 30000, "1-1-2000", 10);
            dt.Rows.Add(null, "vijay1", 31000, "1-1-2001", 20);// a new rows is added to datatable

            ds.WriteXml("c:\\employee1.xml", XmlWriteMode.DiffGram);// shows which rows inserted, deleted or updated
            Console.WriteLine("Created Successfully");


        }

        public void changes()
        {


            // 27 records in datatable
            // show me only those records from datatable where new changes has been taken place

            dt.Rows.Add(null, "Raj1", 30000, "1-1-2000", 10);
            dt.Rows.Add(null, "vijay1", 31000, "1-1-2001", 20);// a new rows is added to datatable
            Console.WriteLine("============================");
            Console.WriteLine("Following are new changes : ");
            if (ds.HasChanges())
            {
                DataSet newds = ds.GetChanges();// newds contains only 2 rows

                for (int i = 0; i < newds.Tables["emp"].Rows.Count; i++)
                {

                    Console.WriteLine(newds.Tables["emp"].Rows[i][0]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][1]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][2]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][3]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][4]);
                }

            }
            else
            {
                Console.WriteLine("No Changes has happened in datatable ");
            }

        }

    }
}
