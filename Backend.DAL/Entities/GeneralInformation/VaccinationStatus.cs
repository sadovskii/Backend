using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Backend.DAL.Entities.GeneralInformation
{
    public class VaccinationStatus
    {
        [Key]
        public int Id { get; set; } 
        public DateTime ProcedureTime { get; set; }
        public string Information { get; set; }
    }
}
