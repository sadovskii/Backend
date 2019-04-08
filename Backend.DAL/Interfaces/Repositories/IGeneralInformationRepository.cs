using Backend.DAL.Entities.GeneralInformationEntities;
using Backend.DAL.Entities.InjuriesDiseasesEntities;
using Backend.DAL.Entities.MedicalExaminationEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.DAL.Interfaces.Repositories
{
    public interface IGeneralInformationRepository : IGenericRepository<GeneralInformation>
    {
        List<Fluorography> GetFluorographyById(int id);
        List<VaccinationStatus> GetVaccinationStatusById(int id);
        List<SurgicalIntervention> GetSurgicalInterventionById(int id);
        void InsertFluorography(int id, Fluorography fluorography);
        void InsertVaccinationStatus(int id, VaccinationStatus vaccinationStatus);
        void InserSurgicalIntervention(int id, SurgicalIntervention surgicalIntervention);
    }
}
