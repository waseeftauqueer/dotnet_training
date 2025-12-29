using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFIrstDemo
{
    internal class CrudDemo2
    {
        Model1 dc = new Model1();

        public void InsertNewStudents()
        {
            try
            {
                Student s = new Student()
                {
                    StudentId = 1,
                    StudentName = "Waseef",
                    DOBDate = DateTime.Now,
                    Class = 12,
                    Email = "waseef@gmail.com"
                };
                dc.Students.Add(s);
                int res = dc.SaveChanges();
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                // Each Column may have many validations
                foreach (var item in res)
                {
                    if(item.ValidationErrors.Count > 0)
                    {
                        foreach (var error in item.ValidationErrors)
                        {
                            Console.WriteLine(error.ErrorMessage);
                        }
                    }
                }
            }
            
        }
    }
}
