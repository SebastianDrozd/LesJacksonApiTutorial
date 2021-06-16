using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LesJacksonApiTutorial.Models;

namespace LesJacksonApiTutorial.Data
{
    public interface ICommanderRepo
    {
   
        public IEnumerable<Command> GetCommands();

        public Command GetCommandById(int id);
    }
    }
