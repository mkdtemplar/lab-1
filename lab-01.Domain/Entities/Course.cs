using lab_01.Domain.Common;

namespace lab_01.Domain.Entities;

public class Course : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;
    public int Credits { get; set; }

    // Add this later if you want the second migration to be clearly demonstrated
    public string? Description { get; set; }

    public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    public ICollection<ExamSession> ExamSessions { get; set; } = new List<ExamSession>();
    public ICollection<Teaches> TeachAssignments { get; set; } = new List<Teaches>();
}