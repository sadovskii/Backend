using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.DAL.Entities.Common.InstrumentalStudies;
using Backend.DAL.Entities.InjuriesDiseasesEntities;
using Backend.DAL.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InjuriesDiseasesController : ControllerBase
    {
        IInjuriesDiseasesRepository _injuriesDiseasesRepository;

        public InjuriesDiseasesController(IInjuriesDiseasesRepository injuriesDiseasesRepository)
        {
            _injuriesDiseasesRepository = injuriesDiseasesRepository;
        }

        // GET: api/InjuriesDiseases
        [HttpGet]
        public IEnumerable<InjuriesDiseases> GetInjuriesDiseases()
        {
            return _injuriesDiseasesRepository.GetAll();
        }

        // GET: api/InjuriesDiseases/5
        [HttpGet("{id}")]
        public InjuriesDiseases GetGetMedicalExamination(int id)
        {
            return _injuriesDiseasesRepository.GetBy(t => t.Id == id);
        }

        // GET: api/InjuriesDiseases/5/MRIs
        [HttpGet("{id}", Name = "MRIs")]
        public List<MRI> GetWithMRI(int id)
        {
            return _injuriesDiseasesRepository.GetMRIById(id);
        }

        // GET: api/GeneralInformation/5/HeartUltrasounds
        [HttpGet("{id}", Name = "HeartUltrasounds")]
        public List<HeartUltrasound> GetWithHeartUltrasound(int id)
        {
            return _injuriesDiseasesRepository.GetHeartUltrasoundById(id);
        }

        // POST: api/Patients/5/MRI
        [HttpPost("{id}/MRI")]
        public void PostWithMRI(int id, [FromBody] MRI mri)
        {
            _injuriesDiseasesRepository.InsertMRI(id, mri);
        }

        // POST: api/Patients/5/HeartUltrasound
        [HttpPost("{id}/HeartUltrasound")]
        public void PostWithHeartUltrasound(int id, [FromBody] HeartUltrasound heartUltrasound)
        {
            _injuriesDiseasesRepository.InsertHeartUltrasound(id, heartUltrasound);
        }

        // PUT: api/InjuriesDiseases/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
