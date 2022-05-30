using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityGradingSystem.Data.Repository.Interfaces;
using UniversityGradingSystem.Models.Entities;

namespace UniversityGradingSystem.Data.Repository.Implementations
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool CreateDepartment(Department department)
        {
            _context.Departments.Add(department);
            return Save();
        }

        public bool DeleteDepartment(Department department)
        {
            _context.Departments.Remove(department);
            return Save();
        }

        public bool DepartmentExists(string name)
        {
            bool result = _context.Departments.Any(x => x.DepartmentName.ToLower().Trim() == name.ToLower().Trim());
            return result;
        }

        public bool DepartmentExists(int id)
        {
            bool result = _context.Departments.Any(x => x.Id == id);
            return result;
        }

        public ICollection<Department> GetDepartments()
        {
            var result = _context.Departments.OrderBy(x => x.DepartmentName).ToList();
            return result;
        }

        public Department GetDepartment(int departmentId)
        {
            var result = _context.Departments.FirstOrDefault(x => x.Id == departmentId);
            return result;
        }
       
        public bool UpdateDepartment(Department department)
        {
            _context.Departments.Update(department);
            return Save();
        }
        public bool Save()
        {
            return _context.SaveChanges() >= 0 ? true : false;
        }
    }
}
