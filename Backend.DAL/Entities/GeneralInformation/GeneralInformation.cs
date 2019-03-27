using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.DAL.Entities.GeneralInformation
{
    public class GeneralInformation
    {
        public DateTime Bithday { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public virtual Patient Patient { get; set; }
        public double ArterialPressure { get; set; }
        public ICollection<Fluorography> Fluorographies { get; set; }
        public ICollection<VaccinationStatus> VaccinationStatuses { get; set; }
    }
}
