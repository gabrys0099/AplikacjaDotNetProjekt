﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class ExercisesInTraining
    {
        public int Id { get; set; }
        public int TrainingId { get; set; } //jako klucz obcy do tabeli Training
        public int ExerciseId { get; set; } //jako klucz obcy do tabeli CatalogExercise
        public int Sets { get; set; }
        public int Reps { get; set; }
        public float Weight { get; set; }
    }

    public class ExercisesInTrainingDisplay
    {
        public string ExerciseName { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public float Weight { get; set; }

        public override string ToString()
        {
            return $"{ExerciseName} - Sets: {Sets} - Reps: {Reps} - Weight: {Weight}kg";
        }
    }

}
