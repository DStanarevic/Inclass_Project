using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Project
{
    class Receptionist : Patient_Care
    {
        //fields
        private bool isOnPhone;
        //Properties
        public bool IsOnPhone
        {
            get { return this.isOnPhone; }
            set { this.isOnPhone = value; }
        }
        //Constructor
        public Receptionist(string employeeName, int employeeNumber, string department, bool isOnPhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isOnPhone = isOnPhone;
        }
    }

   
    
}
