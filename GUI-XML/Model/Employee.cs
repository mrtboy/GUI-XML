using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_XML
{
    [Serializable]
    public class Employee : Person
    {
        public String EmployeeNumber { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(String SurName, String GivenName, String Height,
            genderType Gender, eyeColorType eyeColor,String EmployeeNumber,double Salary)
            :base(SurName, GivenName, Height, Gender, eyeColor)
        {
            this.EmployeeNumber = EmployeeNumber;
            this.Salary = Salary;
        }
    }
}
