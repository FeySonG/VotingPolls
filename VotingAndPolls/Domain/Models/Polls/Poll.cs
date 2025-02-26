using Domain.Abstractions;
using Domain.Models.Option;

namespace Domain.Models.Poll
{
    public class Poll : Entity
    {
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set;}
        public required List<PollOption> Options { get; set; }
        public PollRelevance Relevance { get; set; } = PollRelevance.Active;
    }
}
