using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFIrstDemo
{
    internal class CrudDemo
    {
        Model1 dc = new Model1();
        public void Display()
        {
            var res = from t in dc.IPLs select t;
            foreach (var item in res)
            {
                Console.WriteLine(item.TeamID + " " + item.TeamName + " " + item.Captain + " " + item.State);
            }
        }

        public void Insert()
        {
            IPL ob = new IPL() {TeamName = "CSK", Captain = "MS Dhoni", State = "Chennai" };

            dc.IPLs.Add(ob);
            int i = dc.SaveChanges();
            Console.WriteLine("Total rows inserted is " + i);
        }
    }
}
