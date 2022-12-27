using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Dto.Option
{
    public class OptionCreateDto
    {
        public OptionCreateDto(string description)
        {
            Description = description;
        }

        public string Description { get; protected set; }
    }
}
