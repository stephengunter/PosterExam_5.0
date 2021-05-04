using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Helpers;

namespace ApplicationCore.Authorization
{
	public static class IdendityHelpers
	{
		public static string CurrentUserId(this AuthorizationHandlerContext context)
		{
			var entity = context.User.Claims.Where(c => c.Type == "id").FirstOrDefault();
			if (entity == null) return "";

			return entity.Value;
		}

		public static IEnumerable<string> CurrentUseRoles(this AuthorizationHandlerContext context)
		{
			var entity = context.User.Claims.Where(c => c.Type == "roles").FirstOrDefault();
			if (entity == null) return null;


			return entity.Value.Split(',');
		}


		public static string CurrentUserName(this AuthorizationHandlerContext context)
		{
			var entity = context.User.Claims.Where(c => c.Type == "sub").FirstOrDefault();
			if (entity == null) return "";

			return entity.Value;


		}
		public static bool CurrentUserIsDev(this AuthorizationHandlerContext context)
		{
			var roles = CurrentUseRoles(context);
			if (roles.IsNullOrEmpty()) return false;

			string devRoleName = AppRoles.Dev.ToString();
			var match = roles.Where(r => r.EqualTo(devRoleName)).FirstOrDefault();

			return match != null;
		}

		public static bool CurrentUserIsBoss(this AuthorizationHandlerContext context)
		{
			var roles = CurrentUseRoles(context);
			if (roles.IsNullOrEmpty()) return false;

			string bossRoleName = AppRoles.Boss.ToString();
			var match = roles.Where(r => r.EqualTo(bossRoleName)).FirstOrDefault();

			return match != null;
		}

		public static bool CurrentUserIsSubscriber(this AuthorizationHandlerContext context)
		{
			var roles = CurrentUseRoles(context);
			if (roles.IsNullOrEmpty()) return false;

			string subscriberRoleName = AppRoles.Boss.ToString();
			var match = roles.Where(r => r.EqualTo(subscriberRoleName)).FirstOrDefault();

			return match != null;
		}

	}
}
