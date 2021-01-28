using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsArch.Domain.Commands
{
    public class CreateCourseCommand:CourseCommands
    {
        public CreateCourseCommand(string name,string description,string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
