using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TrungTamNgoaiNgu.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string? CourseName { get; set; }
        public string? Images { get; set; }
        public string? SortDes { get; set; }
        public int Star { get; set; }
        public int StudentCount { get; set; }
        public string? LearnTime { get; set; }
        public int Price { get; set; }
        public string? Link { get; set; }
        public bool? IsActive { get; set; }
        public int Status { get; set; }
        public int MenuID { get; set; }

    }
}
