using System.Collections.Generic;
using Trainee;

namespace FreshersManagement.Service
{
    internal interface IService
    {
        int SaveTrainee(Fresher fresher);
        IEnumerable<Fresher> FetchTrainees();
        Fresher FetchTrainee(int id);
        int UpdateTrainee(Fresher fresher);
        int DeleteTrainee(int id);
    }
}
