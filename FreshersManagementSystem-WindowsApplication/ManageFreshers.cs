using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dal;
using Trainee;

namespace FreshersManagementSystem_WindowsApplication
{
    public class ManageFreshers
    {
        private static BindingList<Fresher> freshers = new BindingList<Fresher>();

        public BindingList<Fresher> Freshers
        {
            get
            {
                return freshers;
            }
            set
            {
                freshers = value;
            }
        }

        public void SaveTrainees(Fresher fresher)
        {
            DatabaseAccessLayer dal = new DatabaseAccessLayer();
            dal.InsertTrainee(fresher);
        }

        public BindingList<Fresher> GetTrainees()
        {
            return Freshers;
        }

        public void UpdateTrainee(Fresher fresher)
        {
            DatabaseAccessLayer dal = new DatabaseAccessLayer();
            dal.UpdateTrainee(fresher);
        }

        public void DeleteTrainee(string idOfTrainee)
        {
            DatabaseAccessLayer dal = new DatabaseAccessLayer();
            dal.DeleteTrainee(Convert.ToInt32(idOfTrainee));

        }
    }
}
