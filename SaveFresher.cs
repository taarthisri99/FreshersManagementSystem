using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshersManagementSystem_WindowsApplication
{
    public partial class SaveFresher : Form
    {
        ManageFreshers manageFreshers = new ManageFreshers();
         
        public SaveFresher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            long mobileNumber = Convert.ToInt64(MobileNumberBox.Text);
            DateTime dateOfBirth = DateTime.Parse(DateBox.Text);
            string qualification = QualificationBox.Text;
            string address = AddressBox.Text;
            Trainee trainee = new Trainee(++manageFreshers.traineeId, name, mobileNumber, dateOfBirth, qualification
                , address);

            if (string.Equals(IdBox.Text, ""))
            {
                manageFreshers.saveTrainees(trainee);
                MessageBox.Show("Trainee saved successfully");
                clearForm();
            }
            else
            {
                manageFreshers.updateTrainee(trainee);
            }
        }

        private void clearForm()
        {
            NameBox.Text = string.Empty;
            MobileNumberBox.Text = null;
            DateBox.Text = null;
            QualificationBox.Text = string.Empty;
            AddressBox.Text = string.Empty;
        }

        public void ShowDataToUpdate(Trainee trainee)
        {
            IdBox.Text = trainee.Id.ToString();
            NameBox.Text = trainee.Name;
            MobileNumberBox.Text = trainee.MobileNumber.ToString();
            DateBox.Text = trainee.DateOfBirth.ToString();
            QualificationBox.Text = trainee.Qualification;
            AddressBox.Text = trainee.Address;
            ShowDialog();
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(NameBox.Text, @"([a-zA-Z.]+\\s?)*"))
            {
                e.Cancel = true;
                NameBox.Focus();
                errorProvider.SetError(NameBox, "Name should contain only alphabets!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(NameBox, "");
            }
        }

        private void MobileNumberBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(MobileNumberBox.Text, @"^(\+?\d{1,4}[\s-])?(?!0+\s+,?$)\d{10}\s*,?$"))
            {
                e.Cancel = true;
                MobileNumberBox.Focus();
                errorProvider.SetError(MobileNumberBox, "Mobile Numbers should contain only numbers!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(MobileNumberBox, "");
            }
        }

        private int CalculateAge(string dateOfBirthInString)
        {
            int yearOfBirth = DateTime.Parse(dateOfBirthInString).Year;
            int age = (DateTime.Now.Year - yearOfBirth) - 1;

            return age;
        }

        private void DateBox_Validating(object sender, CancelEventArgs e)
        {
            if (CalculateAge(DateBox.Text) < 17)
            {
                e.Cancel = true;
                DateBox.Focus();
                errorProvider.SetError(DateBox, "Not above 18 years of age");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(DateBox, "");
            }
        }
    }   
}
