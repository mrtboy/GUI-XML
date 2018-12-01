using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_XML
{
    public partial class DataManagementView : Form
    {
        List<Person> people = new List<Person>();
        static int index = 0;

        public DataManagementView()
        {
            InitializeComponent();
            fillDropDowns();
            refreshGuiData();
        }

        private void fillDropDowns()
        {
            cbEyeColor.DataSource = Enum.GetValues(typeof(eyeColorType));
            cbGender.DataSource = Enum.GetValues(typeof(genderType));
        }

        private void refreshGuiData()
        {
            Employee emp = new Employee("Reza","Taleghani","173",genderType.MALE,eyeColorType.BLUE, "1233442", 1000);
            Employee emp1 = new Employee("Mohammadre", "Taleghani", "173", genderType.MALE, eyeColorType.BROWN, "1233442", 1000);
            Employee emp2 = new Employee("Maryam", "Eghbali", "180", genderType.FEMALE, eyeColorType.BROWN, "1233442", 2000);
            Student stu = new Student("Sara", "Eghbali", "180", genderType.FEMALE, eyeColorType.GRAY, "4324324",5);
            Student stu2 = new Student("Ali", "Eghbali", "180", genderType.FEMALE, eyeColorType.GREEN, "23213", 33);

            people.Add(emp);
            people.Add(emp1);
            people.Add(emp2);
            people.Add(stu);
            people.Add(stu2);
            fillForm();
        }

        private void fillForm()
        {
            lblType.Text = people[index].ToString();
            txtSurname.Text = people[index].Surname;
            txtFamilyName.Text = people[index].GivenName;
            txtHeight.Text = people[index].Height;
            cbGender.SelectedItem = people[index].Gender;
            cbEyeColor.SelectedItem = people[index].EyeColor;

            if (people[index] is Student s)
            {
                txtMatriculation.Text = s.MatriculationNumber;
                lblCreditPoint.Text = s.CreditPoints.ToString();
                txtEmployeeNumber.Text = "";
                lblSalary.Text = "";
            }
            if (people[index] is Employee e)
            {
                txtEmployeeNumber.Text = e.EmployeeNumber;
                lblSalary.Text = e.Salary.ToString();
                txtMatriculation.Text = "";
                lblCreditPoint.Text = "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (people.Count -1 > index)
            {
                index++;
                fillForm();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(0 < index)
            {
                index--;
                fillForm();
            }
        }

        private void btnSaveBinary_Click(object sender, EventArgs e)
        {
            updateThePerson();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, people);
                fileStream.Close();
            }
        }

        private void btnLoadBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream openFileStream = File.OpenRead(openFileDialog.FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                people = (List<Person>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }
            resetTheForm();
            fillForm();
        }

        private Person readTheForm()
        {
            string surename = txtSurname.Text;
            string givenname = txtFamilyName.Text;
            string height = txtHeight.Text;
            genderType gender = (genderType)cbGender.SelectedItem;
            eyeColorType eyeColorType = (eyeColorType)cbEyeColor.SelectedItem;

            Person person;
            if(txtEmployeeNumber.Text != "")
            {
                string employeeNumber = txtEmployeeNumber.Text;
                double salary = lblSalary.Text != "" ? Convert.ToDouble(lblSalary.Text) : 0;
                return person = new Employee(surename,givenname,height, gender, eyeColorType, employeeNumber, salary);
            } else
            {
                string matriculationNumber = txtMatriculation.Text != "" ? txtMatriculation.Text : "";
                int creditPoints = lblCreditPoint.Text != "" ? Convert.ToInt32(lblCreditPoint.Text) : 0;
                return person = new Student(surename,givenname, height, gender, eyeColorType, matriculationNumber, creditPoints);
            }
        }

        private void updateThePerson()
        {
            people[index] = readTheForm();
        }

        private void resetTheForm()
        {
            lblType.Text ="";
            txtSurname.Text ="";
            txtFamilyName.Text = "";
            txtHeight.Text = "";
            cbGender.SelectedItem ="";
            cbEyeColor.SelectedItem ="";
            txtEmployeeNumber.Text = "";
            lblSalary.Text = "";
            txtMatriculation.Text = "";
            lblCreditPoint.Text = "";
        }

        private void btnPromoteStudent_Click(object sender, EventArgs e)
        {
            if(txtMatriculation.Text != "")
            {
                txtEmployeeNumber.Text = "";
                lblSalary.Text = "";
                people[index] = readTheForm();
            }
            fillForm();
        }

        private void btnPromoteEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeNumber.Text != "")
            {
                txtMatriculation.Text = "";
                lblCreditPoint.Text = "";
                people[index] = readTheForm();
            }
            fillForm();
        }
    }
}
