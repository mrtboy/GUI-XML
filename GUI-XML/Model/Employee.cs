﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_XML
{
    public class Employee:Person
    {

        private String EmployeeNumber { get; set; }
        private int Salary { get; set; }

        public Employee()
        {
        }
    }
}
