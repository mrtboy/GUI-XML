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
        private String MatriculationNumber { get; set; }
        private int CreditPoints { get; set; }
        public Student()
        {
        }
    }
}
