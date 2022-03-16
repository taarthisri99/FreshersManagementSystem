using System.Collections.Generic;
using System.Data;
using Trainee;

namespace FreshersManagement.Data
{
    internal interface IDataAccess
    {
        int SaveTrainee(Fresher fresher);
        DataTable FetchTrainees();
        void DeleteTrainee(int id);
    }
}
