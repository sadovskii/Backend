﻿using Backend.DAL.Entities.MedicalExaminationEntities;
using System.ComponentModel.DataAnnotations;

namespace Backend.DAL.Entities.Common.InstrumentalStudies
{
    public class Electrocardiogram
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }

        public int MedicalExaminationId { get; set; }
        public MedicalExamination MedicalExamination { get; set; }
    }
}
