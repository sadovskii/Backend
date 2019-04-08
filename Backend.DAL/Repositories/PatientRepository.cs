using Backend.DAL.EF;
using Backend.DAL.Entities;
using Backend.DAL.Entities.GeneralInformationEntities;
using Backend.DAL.Entities.InjuriesDiseasesEntities;
using Backend.DAL.Entities.MedicalExaminationEntities;
using Backend.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.DAL.Repositories
{
    public class PatientRepository : GenericRepository<ApplicationContext, Patient>, IPatientRepository
    {
        public PatientRepository(ApplicationContext context) : base(context)
        {   
        }

        public Patient GetGeneralInformationById(int id)
        {
            return context.Patients
                .Include(t => t.GeneralInformation)
                .FirstOrDefault(t => t.Id == id);
        }

        public Patient GetMedicalExaminationById(int id)
        {
            return context.Patients
                .Include(t => t.MedicalExaminations)
                .FirstOrDefault(t => t.Id == id);
        }

        public Patient GetInjuriesDiseasesById(int id)
        {
            return context.Patients
                .Include(t => t.InjuriesDiseases).ThenInclude(t => t.MRIs)
                .Include(p => p.InjuriesDiseases).ThenInclude(t => t.HeartUltrasounds)
                .Include(p => p.InjuriesDiseases).ThenInclude(t => t.DisabilityType)
                .FirstOrDefault(t => t.Id == id);
        }
            
        public void InsertGeneralInformation(int id, GeneralInformation generalInformation)
        {
            var entity = context.Patients.FirstOrDefault(t => t.Id == id);

            if (entity == null)
                throw new NullReferenceException();
            else
                entity.GeneralInformation = generalInformation;

            context.SaveChanges();
        }

        public void InsertMedicalExamination(int id, MedicalExamination generalInformation)
        {
            var entity = context.Patients.FirstOrDefault(t => t.Id == id);

            if (entity == null)
                throw new NullReferenceException();
            else
                entity.MedicalExaminations.Add(generalInformation);

            context.SaveChanges();
        }

        public void InsertInjuriesDiseases(int id, InjuriesDiseases generalInformation)
        {
            var entity = context.Patients.FirstOrDefault(t => t.Id == id);

            if (entity == null)
                throw new NullReferenceException();
            else
                entity.InjuriesDiseases.Add(generalInformation);
        }

        public void Delete(int id)
        {
            var entity = context.Patients.FirstOrDefault(t => t.Id == id);

            if (entity == null)
                throw new NullReferenceException();
            else
                Delete(entity);

            context.SaveChanges();
        }
    }
}
