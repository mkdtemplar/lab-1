using lab_01.Domain.Enums;
using Microsoft.AspNetCore.Identity;
namespace lab_01.Domain.Entities;

public class ExamsApplicationUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public UserRole Role { get; set; }

    public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    public ICollection<Teaches> TeachAssignments { get; set; } = new List<Teaches>();
}