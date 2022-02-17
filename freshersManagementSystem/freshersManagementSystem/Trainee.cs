using System;

namespace FreshersManagementSystem
{
    public class Trainee
    {
        public Trainee(int id, string name, long mobileNumber, DateOnly dateOfBirth, string address)
        {
            Id = id;
            Name = name;
            MobileNumber = mobileNumber;
            DateOfBirth = dateOfBirth;
            Address = address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}"
                , Id, Name, MobileNumber, DateOfBirth, Address);
        }
    }
}
