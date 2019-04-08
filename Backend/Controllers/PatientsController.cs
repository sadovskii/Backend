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
        public IEnumerable<Patient> GetPatient()
        {
            return _patientRepository.GetAll();
        }

        // GET: api/MedicalExamination/5
        [HttpGet("{id}")]
        public Patient GetPatient(int id)
        {
            return _patientRepository.GetBy(t => t.Id == id);
        }

        // GET: api/Patients/5/GeneralInformation
        [HttpGet("{id}/GeneralInformation")]
        public Patient GetWithGeneralInformation(int id)
        {
            return _patientRepository.GetGeneralInformationById(id);
        }

        // GET: api/Patients/5/MedicalExamination
        [HttpGet("{id}/MedicalExamination")]
        public Patient GetWithMedicalExamination(int id)
        {
            return _patientRepository.GetMedicalExaminationById(id);
        }

        // GET: api/Patients/5/InjuriesDiseases
        [HttpGet("{id}/InjuriesDiseases")]
        public Patient GetWithInjuriesDiseases(int id)
        {
            return _patientRepository.GetInjuriesDiseasesById(id);
        }

        // POST: api/Patients
        [HttpPost]
        public void Post([FromBody] Patient patient)
        {
            _patientRepository.Insert(patient);
        }

        // POST: api/Patients/5/InjuriesDiseases
        [HttpPost("{id}/GeneralInformation")]
        public IActionResult PostWithGeneralInformation(int id, [FromBody] GeneralInformation generalInformation)
        {
            try
            {
                _patientRepository.InsertGeneralInformation(id, generalInformation);
            }
            catch
            {
                return BadRequest();
            }
            return Ok();
        }

        // POST: api/Patients/5/InjuriesDiseases
        [HttpPost("{id}/MedicalExamination")]
        public IActionResult PostWithMedicalExamination(int id, [FromBody] MedicalExamination medicalExamination)
        {
            try
            {
                _patientRepository.InsertMedicalExamination(id, medicalExamination);
            }
            catch
            {
                return BadRequest();
            }
            return Ok();
        }

        // POST: api/Patients/5/InjuriesDiseases
        [HttpPost("{id}/InjuriesDiseases")]
        public IActionResult PostWithInjuriesDiseases(int id, [FromBody] InjuriesDiseases injuriesDiseases)
        {
            try
            {
                _patientRepository.InsertInjuriesDiseases(id, injuriesDiseases);
            }
            catch
            {
                return BadRequest();
            }
            return Ok();
        }

        // PUT: api/Patients/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Patient patient)
        {
            try
            {
                _patientRepository.Update(patient);
            }
            catch
            {
                return BadRequest();
            }
            return Ok();
        }




















        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _patientRepository.Delete(id);
        }
    }
}
