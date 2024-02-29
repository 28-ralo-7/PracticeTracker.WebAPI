using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication2.Common;

public class UserAuthorizationHandler : IAuthorizationHandler
{
	public Task HandleAsync(AuthorizationHandlerContext context)
	{
		IAuthorizationRequirement[] pendingRequirements = context.PendingRequirements.ToArray();

		foreach (IAuthorizationRequirement requirement in pendingRequirements)
		{
			if (IsAuth(context.User, context.Resource))
			{
				context.Succeed(requirement);
			}
		}

		return Task.CompletedTask;
	}

	private static bool IsAuth(ClaimsPrincipal user, object? resource)
	{
		// Code omitted for brevity
		return false;
	}
}