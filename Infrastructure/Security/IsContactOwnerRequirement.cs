using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Infrastructure.Security
{
    public class IsContactOwnerRequirement : IAuthorizationRequirement
    {
    }

    public class IsContactOwnerRequirementHandler : AuthorizationHandler<IsContactOwnerRequirement>
    {
        private readonly DataContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IsContactOwnerRequirementHandler(DataContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            IsContactOwnerRequirement requirement)
        {
            var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null) return Task.CompletedTask;

            var contactId = Guid.Parse(_httpContextAccessor.HttpContext?.Request.RouteValues
                .SingleOrDefault(x => x.Key == "id").Value?.ToString() ?? string.Empty);

            var contact = _dbContext.Contacts.Include(c => c.Vendor).ThenInclude(v => v.Account)
                .FirstOrDefaultAsync(x => x.Id == contactId).Result;

            if (contact == null) return Task.CompletedTask;

            if (contact.Vendor.Account.Id == userId) context.Succeed(requirement);

            return Task.CompletedTask;
        }
        // protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
        //     IsContactOwnerRequirement requirement, Contact resource)
        // {
        //
        //     if (context.User.Identity?.Name == resource.Vendor.Account.UserName)
        //         context.Succeed(requirement);
        //     
        //     return Task.CompletedTask;
        // }
    }
}