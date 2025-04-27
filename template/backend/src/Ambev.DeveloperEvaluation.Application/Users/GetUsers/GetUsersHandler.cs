using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUsers;

/// <summary>
/// Handler for processing GetUsersQuery requests
/// </summary>
public class GetUsersHandler : IRequestHandler<GetUsersQuery, GetUsersResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetUsersHandler
    /// </summary>
    /// <param name="userRepository">The user repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public GetUsersHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetUsersQuery request
    /// </summary>
    /// <param name="request">The GetUsers query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A paginated list of users</returns>
    public async Task<GetUsersResult> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetUsersValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var parameters = new PaginationParameters
        {
            PageNumber = request.Page,
            PageSize = request.Size,
            OrderBy = request.Order ?? string.Empty
        };

        var pagedList = await _userRepository.GetUsersAsync(parameters, cancellationToken);
        var result = _mapper.Map<GetUsersResult>(pagedList);
        
        return result;
    }
}
