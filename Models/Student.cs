namespace OnlineStudentManagementSystemProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // İlişkiler
        public ICollection<Enrollment> Enrollments { get; set; } // Öğrencinin kayıtlı olduğu kurslar
    }

}
