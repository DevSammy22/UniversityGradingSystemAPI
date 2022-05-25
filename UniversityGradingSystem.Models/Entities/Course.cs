using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversityGradingSystem.Models.Entities
{
    public class Course
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string LecturerName { get; set; }
        public enum CourseUnits { E, D, C, B, A }
        public CourseUnits CourseUnit { get; set; }
        [Required]
        public int DeparmentId { get; set; }
        [ForeignKey("DeparmentId")]
        public Department Department { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
