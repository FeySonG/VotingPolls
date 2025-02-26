using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Vote
{
    public class Vote : Entity
    {
        public long PollID { get; set; }
        public long OptionID { get; set; }
        public long UserID { get; set; }
        public DateTime VoteDate { get; set; } = DateTime.Now;
    }
}
