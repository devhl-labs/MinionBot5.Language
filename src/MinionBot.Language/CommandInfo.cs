using System;
using System.Collections.Generic;
using System.Text;

namespace MinionBot.Language
{
    public class CommandInfo
    {
        public string Name { get; }
        public string Description { get; }
        public int PageNumber { get; }
        public string[] InputParameters { get; }

        public CommandInfo(int pageNumber, string name, string description, params string[] inputParameters)
        {
            Name = name;
            Description = description;
            PageNumber = pageNumber;
            InputParameters = inputParameters;
        }
    }
}
