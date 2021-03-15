using CleanArchitecture.Infrastructure.Interfaces;
using System;

namespace CleanArchitecture.Web.Services
{
    internal class CurrentUserService : ICurrentUserService
    {
        public Guid UserId => Guid.Parse("4CB763E7-1C01-4D13-A6B9-62F036340C30");
    }
}
