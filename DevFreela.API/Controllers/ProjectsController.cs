﻿
using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{

    [ApiController]
    [Route("api/projects")]

    public class ProjectsController :ControllerBase
    {
        private readonly FreelanceTotalCostConfig _config;
        public ProjectsController(IOptions<FreelanceTotalCostConfig> options)
        {
          //  dsdasd
        }




        // GET api/projects?search=crm

        [HttpGet]
        public IActionResult Get(string search)
        {
            return Ok();

        }




        // GET api/projects/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST api/projects
        [HttpPost]
        public IActionResult Post(CreateProjectInputModel model)
        {

            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        //  PUT api/projects/1234

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectInputModel model)
        {


            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }


        //PUT api/projetc/1234/start

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //PUT api/projetc/1234/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }



        //POST api/projects/1234/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateProjectCommentInputModel model)
        {

            return Ok();
        }


    }
}
