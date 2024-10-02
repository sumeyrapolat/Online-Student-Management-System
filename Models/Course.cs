namespace OnlineStudentManagementSystemProject.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        // İlişkiler
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; } // Öğretmen bilgisi

        public ICollection<Enrollment> Enrollments { get; set; } // Kursa kayıt olan öğrenciler
        public ICollection<CourseContent> CourseContents { get; set; } // Kursa ait içerikler
    }
}
