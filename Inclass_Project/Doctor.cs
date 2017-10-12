using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Project
{
    class Doctor:Hospital_Employee
    {
        //fields
        protected string specialtyArea;
        //Properties
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }
        //Constructor
        public Doctor()
        { }
        public Doctor(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }

    }
}
