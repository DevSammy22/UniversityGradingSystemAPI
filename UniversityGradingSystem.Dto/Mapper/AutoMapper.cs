using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UniversityGradingSystem.Dto.Dtos;
using UniversityGradingSystem.Models.Entities;

namespace UniversityGradingSystem.Dto.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();
        }
    }
}
