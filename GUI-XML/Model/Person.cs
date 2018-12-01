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

    public enum genderType { MALE, FEMALE };
    public enum eyeColorType { GRAY, BROWN, BLUE, GREEN};

    [Serializable]
    public class Person
    {
        public String Surname { get; set; }
        public String GivenName { get; set; }
        public String Height { get; set; }
        public eyeColorType EyeColor{ get; set; }
        public genderType Gender { get; set; }
        public Person(String Surname,String GivenName,String Height,genderType Gender,eyeColorType eyeColor)
        {
            this.Surname = Surname;
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
