using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Users.GetUsers;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUsers;

/// <summary>
/// AutoMapper profile for GetUsers feature in the API layer
/// </summary>
public class GetUsersProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetUsersProfile
    /// </summary>
    public GetUsersProfile()
    {
        // Map from API request to application query
        CreateMap<GetUsersRequest, GetUsersQuery>();
        
        // Map from application result to API response
        CreateMap<GetUsersResult, GetUsersResponse>();
        CreateMap<UserDto, UserResponseDto>();
        CreateMap<NameDto, NameResponseDto>();
        CreateMap<AddressDto, AddressResponseDto>();
        CreateMap<GeolocationDto, GeolocationResponseDto>();
    }
}
