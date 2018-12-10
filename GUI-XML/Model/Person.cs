using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GUI_XML
{

    public enum genderType { male, female };
    public enum eyeColorType { gray, brown, blue, green};

    [Serializable]
    [XmlInclude(typeof(Person))]
    [XmlInclude(typeof(Student))]
    [XmlInclude(typeof(Employee))]
    public class Person
    {
        public String SurName { get; set; }
        public String GivenName { get; set; }
        public String Height { get; set; }
        public eyeColorType EyeColor{ get; set; }
        public genderType Gender { get; set; }
        public Person(String Surname,String GivenName,String Height,genderType Gender,eyeColorType eyeColor)
        {
            this.SurName = Surname;
            this.GivenName = GivenName;
            this.Height = Height;
            this.Gender = Gender;
            this.EyeColor = eyeColor;
        }

        public Person()
        {

        }
    }
}
