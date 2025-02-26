using Microsoft.EntityFrameworkCore;
using Domain.Models.Poll;

namespace DAL.Modules.Polls
{
    public class PollConfiguration : IEntityTypeConfiguration<Poll>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Poll> builder)
        {
            throw new NotImplementedException();
        }
    }
}
