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
   
    public class Student:Person
    {
        public String MatriculationNumber { get; set; }
        public int CreditPoints { get; set; }
        public Student() { }
        public Student(String SurName, String GivenName, String Height, genderType Gender,
            eyeColorType eyeColor,String MatriculationNumber, int CreditPoints)
            :base(SurName, GivenName, Height,  Gender, eyeColor)
        {
            this.MatriculationNumber = MatriculationNumber;
            this.CreditPoints = CreditPoints;
        }
    }
}
