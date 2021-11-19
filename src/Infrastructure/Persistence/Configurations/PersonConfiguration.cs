using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Ignore(e => e.DomainEvents);
            builder.HasKey(x => x.PersonId);
            builder
                .HasMany(x => x.Addresses)
                .WithOne()
                .HasForeignKey(x => x.PersonId);
        }
    }
}