using Api.Domain.Entities;
using Api.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SchoolTaskController : ControllerBase
    {
        private readonly ISchoolTaskService _service;
        public SchoolTaskController(ISchoolTaskService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get());
            }
            catch (ArgumentException ex)
            {

                return StatusCode((int) HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetById")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException ex)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SchoolTask user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Post(user);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetById", new { id = result.Id})), result);
                }

                return BadRequest();
            }
            catch (ArgumentException ex)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] SchoolTask user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Put(user);
                if (result != null)
                {
                    return Ok(result);
                }

                return BadRequest();
            }
            catch (ArgumentException ex)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                 return Ok(await _service.Delete(id));
            }
            catch (ArgumentException ex)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
