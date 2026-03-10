using lab_01.Domain.Common;

namespace lab_01.Domain.Entities;

public class Teaches : BaseAuditableEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Guid CourseId { get; set; }
    public Course? Course { get; set; }

    public Guid UserId { get; set; }
    public ExamsApplicationUser? User { get; set; }
}