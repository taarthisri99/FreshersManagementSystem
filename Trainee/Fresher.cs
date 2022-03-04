using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainee
{
    public class Fresher
    {
        public Fresher(int id, string name, long mobileNumber, DateTime dateOfBirth
            , string qualification, string address)
        {
            Id = id;
            Name = name;
            MobileNumber = mobileNumber;
            DateOfBirth = dateOfBirth;
            Qualification = qualification;
            Address = address;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }
    }
}
