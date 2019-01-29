using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Information
            string StudentFirstName = "";
            string StudentLastName = "";
            DateTime StudentBirthDate;
            string StudentAddressLine1 = "";
            string StudentAddressLine2 = "";
            string StudentCity = "";
            string StudentStateProvince = "";
            string StudentCountry = "";

            // Teacher Information
            string TeacherFirstName = "";
            string TeacherLastName = "";
            DateTime TeacherBirthDate;
            string TeacherAddressLine1 = "";
            string TeacherAddressLine2 = "";
            string TeacherCity = "";
            string TeacherStateProvince = "";
            string TeacherCountry = "";

            // UProgram Infromation
            string ProgramName = "";
            string DepartmentHead = "";
            string Degrees = "";

            // Degree Infromation
            string DegreeName = "";
            int CreditsRequired;

            // Courese Information
            string CourseName = "";
            int Credits;
            int DurationInWeeks;
            string Teacher = "";

            //Values
            Console.Write("Enter your First Name: ");
            StudentFirstName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            StudentLastName = Console.ReadLine();
            Console.WriteLine("Your name is {0} {1}", StudentFirstName, StudentLastName);
        }
    }
}
