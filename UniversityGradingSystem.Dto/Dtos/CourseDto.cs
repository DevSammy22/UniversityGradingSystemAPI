using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UniversityGradingSystem.Models.Entities;
using static UniversityGradingSystem.Models.Entities.Course;

namespace UniversityGradingSystem.Dto.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string LecturerName { get; set; }
        public CourseUnits CourseUnit { get; set; }
        [Required]
        public int DeparmentId { get; set; }
        public DepartmentDto Department { get; set; }
    }
}
