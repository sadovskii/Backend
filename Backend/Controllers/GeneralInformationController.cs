using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.DAL.EF;
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
    public class GeneralInformationController : ControllerBase
    {
        IGeneralInformationRepository _generalInformationRepository;

        public GeneralInformationController(ApplicationContext applicationContext, IGeneralInformationRepository generalInformationRepository)
        {
            _generalInformationRepository = generalInformationRepository;
        }

        // GET: api/GeneralInformation
        [HttpGet]
        public IEnumerable<GeneralInformation> GetGeneralInformation()
        {
            return _generalInformationRepository.GetAll();
        }

        #region GET
        // GET: api/GeneralInformation/5
        [HttpGet("{id}")]
        public GeneralInformation GetGeneralInformation(int id)
        {
            return _generalInformationRepository.GetBy(t => t.Id == id);
        }

        // GET: api/GeneralInformation/5/Fluorography
        [HttpGet("{id}", Name = "GetFluorography")]
        public List<Fluorography> GetWithFluorography(int id)
        {
            return _generalInformationRepository.GetFluorographyById(id);
        }

        // GET: api/GeneralInformation/5/VaccinationStatus
        [HttpGet("{id}", Name = "GetVaccinationStatus")]
        public List<VaccinationStatus> GetWithVaccinationStatus(int id)
        {
            return _generalInformationRepository.GetVaccinationStatusById(id);
        }

        // GET: api/GeneralInformation/5/SurgicalIntervention
        [HttpGet("{id}", Name = "GetSurgicalIntervention")]
        public List<SurgicalIntervention> GetWithSurgicalIntervention(int id)
        {
            return _generalInformationRepository.GetSurgicalInterventionById(id);
        }
        #endregion

        #region POST
        // POST: api/Patients/5/Fluorography
        [HttpPost("{id}/Fluorography")]
        public void PostWithGeneralInformation(int id, [FromBody] Fluorography fluorography)
        {
            _generalInformationRepository.InsertFluorography(id, fluorography);
        }

        // POST: api/Patients/5/VaccinationStatus
        [HttpPost("{id}/VaccinationStatus")]
        public void PostWithMedicalExamination(int id, [FromBody] VaccinationStatus vaccinationStatus)
        {
            _generalInformationRepository.InsertVaccinationStatus(id, vaccinationStatus);
        }

        // POST: api/Patients/5/InjuriesDiseases
        [HttpPost("{id}/SurgicalIntervention")]
        public void PostWithInjuriesDiseases(int id, [FromBody] SurgicalIntervention surgicalIntervention)
        {
            _generalInformationRepository.InserSurgicalIntervention(id, surgicalIntervention);
        }
        #endregion

        // PUT: api/GeneralInformation/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GeneralInformation value)
        {
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
