using lab_01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab_01.Repository.Configurations;

public class TeachesConfiguration : IEntityTypeConfiguration<Teaches>
{
    public void Configure(EntityTypeBuilder<Teaches> builder)
    {
        builder.ToTable("TeachAssignments");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.StartDate)
            .IsRequired();

        builder.Property(x => x.EndDate)
            .IsRequired();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.HasOne(x => x.Course)
            .WithMany(x => x.TeachAssignments)
            .HasForeignKey(x => x.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany(x => x.TeachAssignments)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}