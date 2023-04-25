using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechSquad.Models.Models;
using TechSquad.Models.ViewModels;

namespace TechSquad.Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public IMappingExpression<TDestination, TSource> Bidirectional<TSource, TDestination>(
         IMappingExpression<TSource, TDestination> expression)
        {
            return CreateMap<TDestination, TSource>();
        }
        public MappingProfiles()
        {
            CreateMap<ApplicationUser, ApplicationUserViewModel>().ReverseMap();
        }
    }
}
