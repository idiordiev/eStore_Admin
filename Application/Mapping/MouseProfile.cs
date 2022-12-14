using AutoMapper;
using eStore_Admin.Application.RequestDTOs;
using eStore_Admin.Application.Responses;
using eStore_Admin.Domain.Entities;

namespace eStore_Admin.Application.Mapping
{
    public class MouseProfile : Profile
    {
        public MouseProfile()
        {
            CreateMap<Mouse, MouseResponse>();
            CreateMap<MouseDto, Mouse>();
        }
    }
}