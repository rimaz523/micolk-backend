using Application.Common.Mappings;
using Domain.Entities;
using System;

namespace Application.Users.Queries.GetUserById
{
    public class UserDto : IMapFrom<User>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
