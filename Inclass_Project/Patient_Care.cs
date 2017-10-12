using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Project
{
    abstract class Patient_Care:Hospital_Employee
    {
        //fields
        protected string department;
        //Properties
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
    }
}
