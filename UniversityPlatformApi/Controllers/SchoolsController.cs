using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniversityPlatformApi.Service.Interfaces;
using UniversityPlatformApi.Models;

namespace UniversityPlatformApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly ISchoolService _schoolService;

        public SchoolsController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        // GET: api/Schools
        [HttpGet]
        public async Task<IEnumerable<School>> GetSchools()
        {
            return await _schoolService.GetSchoolsAsync();
        }

        // GET: api/Schools/5
        [HttpGet("{id}")]
        public async Task<ActionResult<School>> GetSchool(int id)
        {
            var school = await _schoolService.GetSchoolByIdAsync(id);

            if (school == null)
            {
                return NotFound();
            }

            return school;
        }

        // PUT: api/Universities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUniversity(int id, University university)
        //{
        //    if (id != university.UniversityId)
        //    {
        //        return BadRequest();
        //    }
        //    _uow.Universities.Update(university);

        //    try
        //    {
        //        await _uow.CommitAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UniversityExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Universities
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<University>> PostUniversity(University university)
        //{
        //    _uow.Universities.Add(university);
        //    await _uow.CommitAsync();

        //    return CreatedAtAction("GetUniversity", new { id = university.UniversityId }, university);
        //}

        //// DELETE: api/Universities/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<University>> DeleteUniversity(int id)
        //{
        //    var university = await _uow.Universities.GetAsync(id);
        //    if (university == null)
        //    {
        //        return NotFound();
        //    }

        //    _uow.Universities.Delete(university);
        //    await _uow.CommitAsync();

        //    return university;
        //}

        //private bool UniversityExists(int id)
        //{
        //    return _uow.Universities.Get(e => e.UniversityId == id) != null;
        //}
    }
}
