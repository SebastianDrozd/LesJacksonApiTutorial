using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LesJacksonApiTutorial.Data;
using LesJacksonApiTutorial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LesJacksonApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo repository;

        public CommandsController(ICommanderRepo repo) {
            this.repository = repo;
        }
   

        //get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands() 
        {

            var commands = repository.GetCommands();

            return Ok(commands);
            
        }

        //get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) 
        {
            var command = repository.GetCommandById(id);

            return Ok(command);
        }
    }
}
