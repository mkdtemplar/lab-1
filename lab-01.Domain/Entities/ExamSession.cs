using lab_01.Domain.Common;
using lab_01.Domain.Enums;

namespace lab_01.Domain.Entities;

public class ExamSession : BaseAuditableEntity
{
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public ExamSessionType Type { get; set; }

    public Guid CourseId { get; set; }
    public Course? Course { get; set; }

    public ICollection<Exam> Exams { get; set; } = new List<Exam>();
}