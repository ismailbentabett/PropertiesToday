using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Application.MappingProfiles
{
    public class Mappings
    :
    Profile
    {
        public Mappings()
        {
            CreateMap<Application.Models.NewPropertyRequest, Domain.Property>();
        }
    }
}