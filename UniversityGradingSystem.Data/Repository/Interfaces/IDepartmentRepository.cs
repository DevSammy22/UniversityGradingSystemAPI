using System;
using System.Collections.Generic;
using System.Text;
using UniversityGradingSystem.Models.Entities;

namespace UniversityGradingSystem.Data.Repository.Interfaces
{
    public interface IDepartmentRepository
    {
        ICollection<Department> GetDepartments();
        Department GetDepartment(int departmentId);
        bool DepartmentExists(string name);
        bool DepartmentExists(int id);
        bool CreateDepartment(Department department);
        bool UpdateDepartment(Department department);
        bool DeleteDepartment(Department department);
        bool Save();
    }
}
