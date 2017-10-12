using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Project
{
    abstract class Hospital_Employee
    {
        //fields
        protected string employeeName;
        protected int employeeNumber;
        //Properties
        public string EmployeeName
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }
        }
        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
            set { this.employeeNumber = value; }
        }
            
            
            
            
        //Constructor
        public Hospital_Employee()
        { }
    }
}
