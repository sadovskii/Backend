using Backend.Views.Common.InstrumentalStudies;
using Backend.Views.Common.LaboratoryResearch;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Backend.Views.MedicalExaminationEntities
{
    public class MedicalExaminationView
    {
        [Key]
        public int Id { get; set; }
        public DateTime ProcedureTime { get; set; }
        public bool Allowance { get; set; }

        public ICollection<DoctorsDiagnosisView> DoctorsDiagnoses { get; set; }
        public ICollection<BloodChemistryAnalysis> BloodChemistryAnalyses { get; set; }
        public ICollection<GeneralBloodAnalysis> GeneralBloodAnalyses { get; set; }
        public ICollection<GeneralUrineAnalysis> GeneralUrineAnalyses { get; set; }
        public ICollection<HeartUltrasound> HeartUltrasounds { get; set; }
        public ICollection<Electrocardiogram> Electrocardiograms { get; set; }

        public int PatientId { get; set; }
        public PatientView Patient { get; set; }

    }
}
