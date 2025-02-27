using Microsoft.EntityFrameworkCore;
using Domain.Models.Polls;
using Domain.Models.Users;

namespace DAL.Modules.Polls
{
    public class PollConfiguration : IEntityTypeConfiguration<Poll>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Poll> builder)
        {
            builder.Property(x => x.Id)
           .ValueGeneratedOnAdd();

            builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.UserID);
        }
    }
}
