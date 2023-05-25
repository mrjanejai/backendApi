using AutoMapper;
using WebApi.Models.Products;
using WebApi.Entities;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<CreateRequest, Product>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.CreateBy, opt => opt.MapFrom(src => src.CreateBy))
            .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => src.CreateDate))
            .ForMember(dest => dest.UpdateBy, opt => opt.MapFrom(src => src.UpdateBy))
            .ForMember(dest => dest.UpdateDate, opt => opt.MapFrom(src => src.UpdateDate));

        CreateMap<UpdateRequest, Product>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.UpdateBy, opt => opt.MapFrom(src => src.UpdateBy));

    }
}
