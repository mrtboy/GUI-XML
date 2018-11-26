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
    public class Person
    {
        private String SurName { get; set; }
        private String GivenName { get; set; }
        private String Height { get; set; }
        public enum genderType { male, female };
        public enum eyeColorType { gray, brown, blue, green };

        public Person(String SurName,String GivenName,String Height,genderType Gender,eyeColorType eyeColor)
        {
           
        }
    }
}
