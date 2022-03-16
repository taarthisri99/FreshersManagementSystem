using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Trainee;

namespace FreshersManagementSystem.Windows
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
            int traineeId = 0;
            string name = NameBox.Text;
            long mobileNumber = Convert.ToInt64(MobileNumberBox.Text);
            DateTime dateOfBirth = DateTime.Parse(DateBox.Text);
            string qualification = QualificationBox.Text;
            string address = AddressBox.Text;
            var fresher = new Fresher(traineeId, name, mobileNumber, dateOfBirth, qualification
                , address);

            if (string.Equals(IdBox.Text, ""))
            {
                if(0 == manageFreshers.SaveTrainee(fresher))
                {
                    MessageBox.Show("Trainee saved Failed\nHint: Mobile Number already exist");
                    MobileNumberBox.Clear();
                }
                else
                {
                    MessageBox.Show("Trainee saved successfully");
                    ClearForm();
                }
            }
            else
            {
                fresher.Id = Convert.ToInt32(IdBox.Text);

                if (0 == manageFreshers.SaveTrainee(fresher))
                {
                    MessageBox.Show("Trainee saved Failed\nHint: Mobile Number already exist");
                    MobileNumberBox.Clear();
                }
                else
                {
                    MessageBox.Show("Trainee saved successfully");
                    ClearForm();
                }
            }
            
        }

        private void ClearForm()
        {
            NameBox.Clear();
            MobileNumberBox.Clear();
            DateBox.Text = null;
            QualificationBox.Text = string.Empty;
            AddressBox.Clear();
        }

        public void ShowDataToUpdate(Fresher fresher)
        {
            IdBox.Text = fresher.Id.ToString();
            NameBox.Text = fresher.Name;
            MobileNumberBox.Text = fresher.MobileNumber.ToString();
            DateBox.Text = fresher.DateOfBirth.ToString();
            QualificationBox.Text = fresher.Qualification;
            AddressBox.Text = fresher.Address;
            ShowDialog();
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            if (!(Regex.IsMatch(NameBox.Text, @"^([a-zA-Z .]*)$") 
                && !(string.IsNullOrWhiteSpace(NameBox.Text))))
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
 