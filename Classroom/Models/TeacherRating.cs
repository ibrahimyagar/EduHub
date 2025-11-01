using Classroom.Models;
public class TeacherRating
{
    public int Id { get; set; }
    public int ClassroomId { get; set; }
    public string TeacherId { get; set; }
    public string StudentId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }

    public virtual ApplicationUser Student { get; set; }
    public virtual ApplicationUser Teacher { get; set; }
}