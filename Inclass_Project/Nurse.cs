using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Project
{
    class Nurse:Patient_Care
    {
        //fields
        private int numberOfPatients;
        //Properties
        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
            set { this.numberOfPatients = value; }
        }
        //Constructor
        public Nurse(string employeeName, int employeeNumber, string department, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.numberOfPatients = numberOfPatients;
        }
        
    }
}
