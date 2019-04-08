using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IEnumerable<InjuriesDiseasesView> GetInjuriesDiseases()
        {
            return _injuriesDiseasesRepository.GetAll();
        }

        // GET: api/InjuriesDiseases/5
        [HttpGet("{id}")]
        public InjuriesDiseasesView GetGetMedicalExamination(int id)
        {
            return _injuriesDiseasesRepository.GetBy(t => t.Id == id);
        }

        // POST: api/InjuriesDiseases
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
