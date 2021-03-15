using System;

namespace CleanArchitecture.Infrastructure.Interfaces
{
    public interface ICurrentUserService
    {
        Guid UserId { get; }
    }
}
