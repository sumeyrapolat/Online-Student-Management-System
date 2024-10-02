namespace OnlineStudentManagementSystemProject.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        // İlişkiler
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }


}
