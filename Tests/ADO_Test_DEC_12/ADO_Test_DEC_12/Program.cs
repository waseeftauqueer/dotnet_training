using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Test_DEC_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectedArchitecture connectedArchitecture = new ConnectedArchitecture();
            //connectedArchitecture.DisplayCourse();
            //connectedArchitecture.AddStudent();
            //connectedArchitecture.SearchByDepartment();
            //connectedArchitecture.EnrolledCourses();
            //connectedArchitecture.UpdateGrade();

            DisconnectedArchitecture disconnectedArchitecture = new DisconnectedArchitecture();
            disconnectedArchitecture.LoadData();
            //disconnectedArchitecture.UpdateCredits();
            //disconnectedArchitecture.InsertCourse();
            //disconnectedArchitecture.DeleteData();
        }
    }
}
