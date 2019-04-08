using Backend.DAL.Entities.MedicalExaminationEntities;
using System.ComponentModel.DataAnnotations;

namespace Backend.DAL.Entities.Common.LaboratoryResearch
{
    public class GeneralUrineAnalysis
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }

        public MedicalExamination MedicalExamination { get; set; }
    }
}
