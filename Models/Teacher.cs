namespace OnlineStudentManagementSystemProject.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // İlişkiler
        public ICollection<Course> Courses { get; set; } // Öğretmenin verdiği kurslar
    }

}
