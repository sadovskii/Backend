using Backend.Views.GeneralInformationEntities;
using Backend.Views.InjuriesDiseasesEntities;
using Backend.DAL.Entities.MedicalExaminationEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Backend.Views
{
    public class PatientView
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }

        public GeneralInformation GeneralInformation { get; set; }
        public ICollection<MedicalExaminationView> MedicalExaminations { get; set; }
        public ICollection<InjuriesDiseases> InjuriesDiseases { get; set; }
    }
}
