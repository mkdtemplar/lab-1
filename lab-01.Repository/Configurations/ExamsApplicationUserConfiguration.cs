using lab_01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab_01.Repository.Configurations;

public class ExamsApplicationUserConfiguration : IEntityTypeConfiguration<ExamsApplicationUser>
{
    public void Configure(EntityTypeBuilder<ExamsApplicationUser> builder)
    {
        builder.ToTable("AspNetUsers");

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.DateOfBirth)
            .IsRequired();

        builder.Property(x => x.Role)
            .IsRequired()
            .HasConversion<int>();
    }
}