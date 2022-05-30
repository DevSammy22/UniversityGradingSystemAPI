using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static UniversityGradingSystem.Models.Entities.Course;

namespace UniversityGradingSystem.Dto.Dtos
{
    public class CourseCreateDto
    {
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string LecturerName { get; set; }
        public CourseUnits CourseUnit { get; set; }
        [Required]
        public int DeparmentId { get; set; }
    }
}
