using App.DAL;
using App.DAL.Context;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class TraineeBLO
    {
        TraineeDAO traineeDAO;

        public TraineeBLO(ModelApp ModelApp)
        {
            traineeDAO = new TraineeDAO(ModelApp);
        }
        public void Add(Trainee trainee)
        {
            traineeDAO.Add(trainee);
        }
    }
}
