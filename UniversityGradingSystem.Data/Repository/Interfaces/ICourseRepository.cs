using System;
using System.Collections.Generic;
using System.Text;
using UniversityGradingSystem.Models.Entities;

namespace UniversityGradingSystem.Data.Repository.Interfaces
{
    public interface ICourseRepository
    {
        ICollection<Course> GetCourses();
        ICollection<Course> GetCoursesInDepartment(int parkId);
        Course GetCourse(int courseId);
        bool CourseExists(string name);
        bool CourseExists(int id);
        bool CreateCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(Course course);
        bool Save();
    }
}
