using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using StudenApi.DTOs;

namespace Student.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentCreateDTO, Domain.Entities.Student>().ReverseMap();
            CreateMap<StudentUpdateDTO, Domain.Entities.Student>().ReverseMap();
        }
    }
}
