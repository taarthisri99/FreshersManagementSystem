using System.Collections.Generic;
using FreshersManagement.Data;
using Trainee;

namespace FreshersManagement.Service
{
    public class Service : IService
    {
        DataAccess dataAccess = new DataAccess();
        public IEnumerable<Fresher> FetchTrainees()
        {
            return dataAccess.FetchTrainees();
        }

        public int SaveTrainee(Fresher fresher)
        {
            return dataAccess.SaveTrainee(fresher);
        }

        public Fresher FetchTrainee(int id)
        {
            return dataAccess.FetchTrainee(id);
        }

        public int UpdateTrainee(Fresher fresher)
        {
            return dataAccess.SaveTrainee(fresher);
        }

        public int DeleteTrainee(int id)
        {
            return dataAccess.DeleteTrainee(id);
        }
    }
}
