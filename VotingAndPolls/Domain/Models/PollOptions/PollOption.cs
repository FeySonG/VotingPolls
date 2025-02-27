using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.PollOptions
{
    public class PollOption : Entity
    {
        public required string OptionName { get; set; }
        public required long PollId { get; set; }
    }
}
