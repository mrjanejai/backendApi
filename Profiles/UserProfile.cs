using AutoMapper;
using WebApi.Models.Users;
using WebApi.Entities;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateRequest, User>()
            .ForMember(dest => dest.PasswordHash, opt => opt.Ignore()); // Ignore the PasswordHash property when mapping

        CreateMap<UpdateRequest, User>()
            .ForMember(dest => dest.PasswordHash, opt => opt.Ignore()); // Ignore the PasswordHash property when mapping
    }
}
