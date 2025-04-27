using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUsers;

/// <summary>
/// AutoMapper profile for GetUsers feature
/// </summary>
public class GetUsersProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetUsersProfile
    /// </summary>
    public GetUsersProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()));
            
        CreateMap<UserName, NameDto>();
        CreateMap<Address, AddressDto>();
        CreateMap<Geolocation, GeolocationDto>();
        
        CreateMap<PagedList<User>, GetUsersResult>()
            .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Items))
            .ForMember(dest => dest.TotalItems, opt => opt.MapFrom(src => src.TotalCount))
            .ForMember(dest => dest.CurrentPage, opt => opt.MapFrom(src => src.CurrentPage))
            .ForMember(dest => dest.TotalPages, opt => opt.MapFrom(src => src.TotalPages));
    }
}
