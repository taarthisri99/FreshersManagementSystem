using System;

using FreshersManagement.Data;
using Trainee;

namespace FreshersManagementSystem.Windows
{
    public class ManageFreshers
    {

        public int SaveTrainee(Fresher fresher)
        {
            DataAccess dal = new DataAccess();
            return dal.SaveTrainee(fresher);
        }

        public void DeleteTrainee(string idOfTrainee)
        {
            DataAccess dal = new DataAccess();
            dal.DeleteTrainee(Convert.ToInt32(idOfTrainee));

        }
    }
}
