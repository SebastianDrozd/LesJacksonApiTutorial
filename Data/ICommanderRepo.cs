using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LesJacksonApiTutorial.Models;

namespace LesJacksonApiTutorial.Data
{
    interface ICommanderRepo
    {
        public Command getCommand(int id);

        public List<Command> getCommands();
    }
}
