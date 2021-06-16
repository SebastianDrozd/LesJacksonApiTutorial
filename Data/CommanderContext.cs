using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LesJacksonApiTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace LesJacksonApiTutorial.Data
{
    public class CommanderContext : DbContext
    {

        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt) 
        { 
                     
        }

        public DbSet<Command> Commands { get; set; }
    }
}
