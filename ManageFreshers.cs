using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersManagementSystem_WindowsApplication
{
    public class ManageFreshers
    {
        private static BindingList<Trainee> trainees = new BindingList<Trainee>();
        public int traineeId = 0;

        public BindingList<Trainee> Trainees
        {
            get
            {
                return trainees;
            }
            set
            {
                trainees = value;
            }
        }

        public int saveTrainees(Trainee trainee)
        {
            Trainees.Add(trainee);
            return Trainees.Count();
        }

        public BindingList<Trainee> getTrainees()
        {
            return Trainees;
        }

        public void updateTrainee(Trainee updatedTrainee)
        {
            int traineeId = Convert.ToInt32(updatedTrainee.Id);

            foreach (Trainee trainee in trainees)
            {
                if (trainee.Id == traineeId)
                {
                    trainee.Name = updatedTrainee.Name;
                    trainee.MobileNumber = updatedTrainee.MobileNumber;
                    trainee.DateOfBirth = updatedTrainee.DateOfBirth;
                    trainee.Qualification  = updatedTrainee.Qualification;
                    trainee.Address = updatedTrainee.Address;
                }
            }
        }

        public void DeleteTrainee(string id)
        {
            int traineeId = Convert.ToInt32(id);

            foreach(Trainee trainee in trainees)
            {
                if(trainee.Id == traineeId)
                {
                    trainees.Remove(trainee);
                    break;
                }
            }
        }
    }
}
