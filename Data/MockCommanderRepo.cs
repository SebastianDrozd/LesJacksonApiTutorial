using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LesJacksonApiTutorial.Models;

namespace LesJacksonApiTutorial.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command GetCommandById(int id)
        {
            return new Command
            {
                HowTo = "boil and egg",
                Id = 1,
                Line = "Boil water",
                Platform = "linux"
            };
        }

        public IEnumerable<Command> GetCommands()
        {
            return new List<Command> { new Command
            {
                HowTo = "boil and egg",
                Id = 1,
                Line = "Boil water",
                Platform = "linux"
            },new Command
            {
                HowTo = "boil and egg",
                Id = 1,
                Line = "Boil water",
                Platform = "linux"
            }
        };
        }
    }
}
