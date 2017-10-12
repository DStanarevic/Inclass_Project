using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_Project
{
    class Surgeon:Doctor
    {
        //fields
        private bool currentlyOperating;
        //Properties
        public bool CurrentlyOperating
        {
            get { return this.currentlyOperating; }
            set { this.currentlyOperating = value; }
        }
        //Constructor
        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool currentlyOperating)//:base(employeeName,employeeNumber,specialtyArea)
        {
            
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.currentlyOperating = currentlyOperating;
        }
    }
}
