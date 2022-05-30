using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityGradingSystem.Data.Repository.Interfaces;
using UniversityGradingSystem.Models.Entities;

namespace UniversityGradingSystem.Data.Repository.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _context;

        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            return Save();
        }

        public bool DeleteCourse(Course course)
        {
            _context.Courses.Remove(course);
            return Save();
        }

        public ICollection<Course> GetCourses()
        {
            var result = _context.Courses.Include(c => c.Department).OrderBy(x => x.CourseName).ToList();
            return result;
        }

        public Course GetCourse(int courseId)
        {
            var result = _context.Courses.Include(c => c.Department).FirstOrDefault(c => c.Id == courseId);
            return result;
        }

        public ICollection<Course> GetCoursesInDepartment(int departmentId)
        {
            var result = _context.Courses.Include(c => c.Department).Where(c => c.DeparmentId == departmentId).ToList();
            return result;
        }

        public bool CourseExists(string name)
        {
            bool result = _context.Courses.Any(x => x.CourseName.ToLower().Trim() == name.ToLower().Trim());
            return result;
        }

        public bool CourseExists(int id)
        {
            var result = _context.Courses.Any(x => x.Id == id);
            return result;
        }
        public bool UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            return Save();
        }
        public bool Save()
        {
            return _context.SaveChanges() >= 0 ? true : false;
        }
    }
}
