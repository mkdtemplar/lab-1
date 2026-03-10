using lab_01.Domain.Common;

namespace lab_01.Domain.Entities;

public class Exam: BaseAuditableEntity
{
    public int Grade { get; set; }

    public Guid CourseId { get; set; }
    public Course? Course { get; set; }

    public Guid ExamSessionId { get; set; }
    public ExamSession? ExamSession { get; set; }

    public Guid UserId { get; set; }
    public ExamsApplicationUser? User { get; set; }
}