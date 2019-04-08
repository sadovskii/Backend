using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.DAL.EF;
using Backend.DAL.Entities;
using Backend.DAL.Entities.GeneralInformationEntities;
using Backend.DAL.Entities.InjuriesDiseasesEntities;
using Backend.DAL.Entities.MedicalExaminationEntities;
using Backend.DAL.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        IPatientRepository _patientRepository;

        public PatientsController(ApplicationContext applicationContext, IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        // GET: api/Patients
        [HttpGet]
        public IEnumerable<PatientView> GetPatient()
        {
            return _patientRepository.GetAll();
        }

        // GET: api/MedicalExamination/5
        [HttpGet("{id}")]
        public PatientView GetPatient(int id)
        {
            return _patientRepository.GetBy(t => t.Id == id);
        }

        // GET: api/Patients/5/GeneralInformation
        [HttpGet("{id}/GeneralInformation")]
        public PatientView GetWithGeneralInformation(int id)
        {
            return _patientRepository.GetGeneralInformationById(id);
        }

        // GET: api/Patients/5/MedicalExamination
        [HttpGet("{id}/MedicalExamination")]
        public PatientView GetWithMedicalExamination(int id)
        {
            return _patientRepository.GetMedicalExaminationById(id);
        }

        // GET: api/Patients/5/InjuriesDiseases
        [HttpGet("{id}/InjuriesDiseases")]
        public PatientView GetWithInjuriesDiseases(int id)
        {
            return _patientRepository.GetInjuriesDiseasesById(id);
        }

        // POST: api/Patients
        [HttpPost]
        public void Post([FromBody] PatientView patient)
        {
            _patientRepository.Insert(patient);
        }

        // POST: api/Patients/5/InjuriesDiseases
        [HttpPost("{id}/GeneralInformation")]
        public void PostWithGeneralInformation(int id, [FromBody] GeneralInformationView generalInformation)
        {
            _patientRepository.InsertGeneralInformation(id, generalInformation);
        }

        // POST: api/Patients/5/InjuriesDiseases
        [HttpPost("{id}/MedicalExamination")]
        public void PostWithMedicalExamination(int id, [FromBody] MedicalExaminationView medicalExamination)
        {
            _patientRepository.InsertMedicalExamination(id, medicalExamination);
        }

        // POST: api/Patients/5/InjuriesDiseases
        [HttpPost("{id}/InjuriesDiseases")]
        public void PostWithInjuriesDiseases(int id, [FromBody] InjuriesDiseasesView injuriesDiseases)
        {
            _patientRepository.InsertInjuriesDiseases(id, injuriesDiseases);
        }

        // PUT: api/Patients/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PatientView patient)
        {
            _patientRepository.Update(patient);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _patientRepository.Delete(id);
        }
    }
}
