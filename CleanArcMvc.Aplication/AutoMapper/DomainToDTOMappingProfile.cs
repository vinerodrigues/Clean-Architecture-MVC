using AutoMapper;
using CleanArcMvc.Aplication.DTOs;
using CleanArcMvc.Domain.Models;

namespace CleanArcMvc.Aplication.AutoMapper
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
