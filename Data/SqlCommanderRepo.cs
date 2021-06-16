﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LesJacksonApiTutorial.Models;

namespace LesJacksonApiTutorial.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Command> GetCommands()
        {
            return _context.Commands.ToList();
        }
    }
}
