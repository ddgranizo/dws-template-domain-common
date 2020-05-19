using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dws.Template.Domain.Common.Utilities
{
    public static class ClaimsUtility
    {
        public static T GetClaim<T>(AuthenticationState state, string key)
        {
            if (state == null)
            {
                return default;
            }
            if (state.User.Claims.Count() == 0)
            {
                return default;
            }
            var str = state.User.Claims.First(k => k.Type == key).Value;
            try
            {
                return ParseUtility.ChangeType<T>(str);
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}
