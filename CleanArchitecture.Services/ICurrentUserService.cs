using System;

namespace CleanArchitecture.Services
{
    public interface ICurrentUserService
    {
        Guid UserId { get; }
    }
}
