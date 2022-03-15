using System.Collections.Generic;

using Trainee;

namespace FreshersManagement.Data
{
    internal interface IDataAccess
    {
        int SaveTrainee(Fresher fresher);
        List<Fresher> FetchTrainees();
        void DeleteTrainee(int id);
    }
}
