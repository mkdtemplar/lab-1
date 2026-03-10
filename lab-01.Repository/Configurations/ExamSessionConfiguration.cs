using lab_01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab_01.Repository.Configurations;

public class ExamSessionConfiguration : IEntityTypeConfiguration<ExamSession>
{
    public void Configure(EntityTypeBuilder<ExamSession> builder)
    {
        builder.ToTable("ExamSessions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.StartTime)
            .IsRequired();

        builder.Property(x => x.EndTime)
            .IsRequired();

        builder.Property(x => x.Type)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.HasOne(x => x.Course)
            .WithMany(x => x.ExamSessions)
            .HasForeignKey(x => x.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Exams)
            .WithOne(x => x.ExamSession)
            .HasForeignKey(x => x.ExamSessionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}