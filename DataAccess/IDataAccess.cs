﻿using System.Collections.Generic;
using Trainee;

namespace FreshersManagement.Data
{
    internal interface IDataAccess
    {
        int SaveTrainee(Fresher fresher);
        IEnumerable<Fresher> FetchTrainees();
        int DeleteTrainee(int id);
    }
}
