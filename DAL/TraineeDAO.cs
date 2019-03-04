using App.DAL.Context;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
    public class TraineeDAO
    {
        ModelApp modelApp;
        public TraineeDAO(ModelApp modelApp)
        {
            if (modelApp == null)
            {
                modelApp = new ModelApp();
            }

            else
            {
                this.modelApp = modelApp;
            }
               
        }

        public void Add(Trainee trainee)
        {
            this.modelApp.Trainees.Add(trainee);
            this.modelApp.SaveChanges();
        }
    }
}
