using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend.DAL.Entities.InjuriesDiseasesEntities
{
    public class DisabilityType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }}
    }
}
