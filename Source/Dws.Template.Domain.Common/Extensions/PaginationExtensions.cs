using Dws.Template.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Extensions
{
    public static class PaginationExtensions
    {
        public static Dictionary<string, string> ToDictionary(this Pagination pagination)
        {
            var dic = new Dictionary<string, string>();
            dic.Add(nameof(pagination.Page).ToLower(), pagination.Page.ToString());
            dic.Add(nameof(pagination.Count).ToLower(), pagination.Count.ToString());
            if (!string.IsNullOrEmpty(pagination.SearchText))
            {
                dic.Add(nameof(pagination.SearchText).ToLower(), pagination.SearchText);
            }
            if (!string.IsNullOrEmpty(pagination.Filter))
            {
                dic.Add(nameof(pagination.Filter), pagination.Filter);
            }
            if (!string.IsNullOrEmpty(pagination.OrderBy))
            {
                dic.Add(nameof(pagination.OrderBy), pagination.OrderBy);
            }
            return dic;
        }
    }
}
