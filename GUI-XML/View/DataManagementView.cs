﻿using System;
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
using System.Xml.Serialization;

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
            btnSaveNewPerson.Visible = false;
            groupPerson();
        }

        private void fillDropDowns()
        {
            cbEyeColor.DataSource = Enum.GetValues(typeof(eyeColorType));
            cbGender.DataSource = Enum.GetValues(typeof(genderType));
        }

        private void refreshGuiData()
        {
            Employee emp = new Employee("Reza","Taleghani",173,genderType.male,eyeColorType.blue, "1233442", 1000);
            Employee emp1 = new Employee("Mohammadre", "Taleghani", 173, genderType.male, eyeColorType.brown, "1233442", 1000);
            Employee emp2 = new Employee("Maryam", "Eghbali", 180, genderType.female, eyeColorType.brown, "1233442", 2000);
            Student stu = new Student("Sara", "Eghbali", 180, genderType.female, eyeColorType.gray, "4324324",5);
            Student stu2 = new Student("Ali", "Eghbali", 180, genderType.female, eyeColorType.green, "23213", 33);

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
            txtSurname.Text = people[index].SurName;
            txtFamilyName.Text = people[index].GivenName;
            txtHeight.Text = people[index].Height.ToString();
            cbGender.SelectedItem = people[index].Gender;
            cbEyeColor.SelectedItem = people[index].EyeColor;

            if (people[index] is Student s)
            {
                txtMatriculation.Text = s.MatriculationNumber;
                lblCreditPoint.Text = s.CreditPoints.ToString();
                txtEmployeeNumber.Text = "";
                lblSalary.Text = "";
            }
            else if (people[index] is Employee e)
            {
                txtEmployeeNumber.Text = e.EmployeeNumber;
                lblSalary.Text = e.Salary.ToString();
                txtMatriculation.Text = "";
                lblCreditPoint.Text = "";
            }
            else
            {
                txtEmployeeNumber.Text = "";
                lblSalary.Text = "";
                txtMatriculation.Text = "";
                lblCreditPoint.Text = "";
            }
            groupPerson();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnSaveNewPerson.Visible = false;
            btnCreateNewPerson.Visible = true;
            
            if (people.Count -1 > index)
            {
                people[index] = readTheForm();
                index++;
                fillForm();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnSaveNewPerson.Visible = false;
            btnCreateNewPerson.Visible = true;
            
            if (0 < index)
            {
                people[index] = readTheForm();
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
            double height = Convert.ToDouble(txtHeight.Text);
            genderType genderType = (genderType)cbGender.SelectedItem;
            eyeColorType eyeColorType = (eyeColorType)cbEyeColor.SelectedItem;

            Person person;
            if(txtEmployeeNumber.Text != "")
            {
                string employeeNumber = txtEmployeeNumber.Text;
                double salary = lblSalary.Text != "" ? Convert.ToDouble(lblSalary.Text) : 0;
                return person = new Employee(surename,givenname,height, genderType, eyeColorType, employeeNumber, salary);
            } else if(txtMatriculation.Text != "")
            {
                string matriculationNumber = txtMatriculation.Text != "" ? txtMatriculation.Text : "";
                int creditPoints = lblCreditPoint.Text != "" ? Convert.ToInt32(lblCreditPoint.Text) : 0;
                return person = new Student(surename,givenname, height, genderType, eyeColorType, matriculationNumber, creditPoints);
            } else
            {
                return person = new Person(surename, givenname, height, genderType, eyeColorType);
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

        private void btnXmlSave_Click(object sender, EventArgs e)
        {
            updateThePerson();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                XmlSerializer mser = new XmlSerializer(typeof(List<Person>));
                mser.Serialize(fileStream, people);
                fileStream.Close();
            }
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream openFileStream = File.OpenRead(openFileDialog.FileName);
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Person>));
                people = (List<Person>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }
            resetTheForm();
            fillForm();
        }


        private void btnCreateNewPerson_Click(object sender, EventArgs e)
        {
            resetTheForm();
            btnSaveNewPerson.Visible = true;
            btnCreateNewPerson.Visible = false;
        }

        private void btnSaveNewPerson_Click(object sender, EventArgs e)
        {
            if(txtFamilyName.Text == "" || txtSurname.Text == "")
            {
                MessageBox.Show("Please fill the form completery");
                return;
            }
            people.Add(readTheForm());
            btnSaveNewPerson.Visible = false;
            btnCreateNewPerson.Visible = true;
            if(people.Count > 0)
            {
                btnDeleteUser.Enabled = true;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            people.Remove(people[index]);
            resetTheForm();
   
            if(people.Count == 0) {
                btnSaveNewPerson.Visible = true;
                btnCreateNewPerson.Visible = false;
                btnDeleteUser.Enabled = false;
            } else
            {
                fillForm();
            } 
           
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupPerson()
        {
            lblCountOfMale.Text = people.FindAll(p => (p.Gender == genderType.male)).Count.ToString();
            lblCountOfWoman.Text = people.FindAll(p => (p.Gender == genderType.female)).Count.ToString();
            lblCountOfBrownEyes.Text = people.FindAll(p => (p.EyeColor == eyeColorType.brown)).Count.ToString();
            lblHeightAverage.Text = people.Select(p =>p.Height).Average().ToString();
            lblTallestPerson.Text = people.Max(p => p.Height).ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSortBySurName_Click(object sender, EventArgs e)
        {
            people = people.OrderBy(p => p.SurName).ToList();
            fillForm();
        }

        private void btnSortByGivenName_Click(object sender, EventArgs e)
        {
            people = people.OrderBy(p => p.GivenName).ToList();
            fillForm();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<Person> person= people.FindAll(p => (p.Height >= 1.7 && p.Height <= 1.71)).ToList();
            dataGridView1.DataSource = person;
            
        }
    }
}
