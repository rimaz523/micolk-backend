using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Users.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<UserDto>
    {
        public Guid Id { get; set; }
    }

    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        private readonly IMapper _mapper;

        public GetUserByIdQueryHandler
        (
            IMapper mapper
        )
        {
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Id = request.Id,
                FirstName = "John",
                LastName = "Doe"
            };
            //return new UserDto();
            return _mapper.Map<UserDto>(user);
        }
    }
}
