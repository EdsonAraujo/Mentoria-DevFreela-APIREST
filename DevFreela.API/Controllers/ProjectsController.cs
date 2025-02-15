﻿
using DevFreela.API.Models;
using DevFreela.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{

    [ApiController]
    [Route("api/projects")]

    public class ProjectsController : ControllerBase
    {

        //private readonly FreelanceTotalCostConfig _config;
        //private readonly IConfigService _configService;
        //public ProjectsController(IOptions<FreelanceTotalCostConfig> options,
        //    IConfigService configService)
        //{
        //    _config = options.Value;
        //    _configService = configService;

        //}


        private readonly FreelanceTotalCostConfig _config;
        private readonly OpeningTimeOption _time;
        private readonly IConfigService _configService;

        public ProjectsController(IOptions<FreelanceTotalCostConfig> freelanceOptions,
                                  IOptions<OpeningTimeOption> openingTimeOptions,
                                  IConfigService configService)
        {
            _config = freelanceOptions.Value;
            _time = openingTimeOptions.Value;
            _configService = configService;
        }


        [HttpPut("{id}/cover")]
        public IActionResult PostProfilePicture(IFormFile file)
        {
            var description = $"File: {file.FileName}, Size: {file.Length}";

            // Processar Imagem 
            return Ok(description);

        }


      
        






        // GET api/projects?search=crm

        [HttpGet]
        public IActionResult Get(string search = "")
        {
            return Ok(_configService.GetValue());

        }




        // GET api/projects/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new Exception();

            return Ok();
            
        }

        // POST api/projects
        [HttpPost]
        public IActionResult Post(CreateProjectInputModel model)
        {
            if (model.TotalCost < _config.Minimum || model.TotalCost > _config.Maximum)
            {
                return BadRequest("Número fora dos limites");

            }
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


        [HttpPut("{id}/finish")]

        public IActionResult Finish (int id) 
        {
            return NoContent();
        }


        
        //PUT api/projetc/1234/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }


        //POST api/projects/1/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateProjectCommentInputModel model)
        {

            return NoContent();
        }



    }
}
