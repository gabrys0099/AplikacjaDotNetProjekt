﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikacjaDotNetProjekt.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class TrainingService
    {
        private readonly DBContext _dbContext;

        public TrainingService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddTrainingToDatabase(Training training)
        {
            try
            {
                _dbContext.Trainings.Add(training);
                _dbContext.SaveChanges();

                return training.Id;
            }
            catch (Exception ex) 
            {
                return -1;
            }
        }

        public bool DoesTrainingExists(string trainingName)
        {
            return _dbContext.Trainings.Any(p => p.Name == trainingName);    
        }

        public int GetTrainingIdByName(string trainingName)
        {
            Training training = _dbContext.Trainings.FirstOrDefault(e => e.Name == trainingName);


            return training != null ? training.Id : -1;
        }

        public List<Training> GetTrainingsFromDatabase(int userId)
        {
            var uniqueTrainings = _dbContext.Trainings
                .Where(training => training.User_ID == userId)
                .GroupBy(training => training.Name)
                .Select(group => group.First())
                .ToList();

            return uniqueTrainings;
        }

        public List<Training> GetTodaysTraining(int userId, DateTime today)
        {

            return _dbContext.Trainings
                .Where(training => training.Date.Date == today.Date && training.User_ID == userId)
                .ToList();
        }

        public async Task DeleteTrainingFromDB(int userId, int trainingId)
        {
            var training = _dbContext.Trainings
                .FirstOrDefault(w => w.Id == trainingId && w.User_ID == userId);

            if (training != null)
            {
                _dbContext.Trainings.Remove(training);
                _dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Nie znaleziono treningu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
