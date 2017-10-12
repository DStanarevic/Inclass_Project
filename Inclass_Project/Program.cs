using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Surgeon jenny = new Surgeon("Jenny",234,"Heart",false);
            Surgeon meredith = new Surgeon("Meredith", 645, "Brain", true);
            Nurse sonny = new Nurse("Sonny", 789, "Nursing", 6);
            Receptionist tom = new Receptionist("Tom", 951, "Office", true);
            Nurse anthony = new Nurse("Anthony", 123, "Nursing", 4);
            Console.WriteLine(jenny.EmployeeName + jenny.EmployeeNumber + jenny.SpecialtyArea + jenny.CurrentlyOperating);
            Console.WriteLine(meredith.EmployeeName + meredith.EmployeeNumber + meredith.SpecialtyArea + meredith.CurrentlyOperating);
            

            List<Hospital_Employee> employee = new List<Hospital_Employee>();
            employee.Add(jenny);
            employee.Add(meredith);
            employee.Add(sonny);
            employee.Add(tom);
            employee.Add(anthony);

            employee.ForEach(Console.WriteLine);
            ////foreach(int person in employee)
            //{

            //}

        }
    }
}
