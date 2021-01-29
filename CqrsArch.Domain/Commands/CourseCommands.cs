using Cqrs.Arch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsArch.Domain.Commands
{
    public abstract class CourseCommands:Command
    {
        public string Name { get;protected set; }
        public string Description { get;protected set; }
        public string ImageUrl { get;protected set; }

    }
}
