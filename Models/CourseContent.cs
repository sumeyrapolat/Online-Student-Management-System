namespace OnlineStudentManagementSystemProject.Models
{
    public class CourseContent
    {
        public int CourseContentId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } // Metin veya bağlantı şeklinde içerik

        // İlişkiler
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }

}
