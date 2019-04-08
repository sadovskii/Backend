using Backend.DAL.Entities.MedicalExaminationEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend.DAL.Entities.Common
{
    public class MedicalProfession
    {
        [Key]
        public int Id { get; set; }
        public string ProfessionName { get; set; }
        public ICollection<DoctorsDiagnosis>  DoctorsDiagnosis { get; set; }
    }
}
