using Dws.Template.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Extensions
{
    public static class HttpResponseExtensions
    {
        public static Task<T> ToAsyncTask<T>(this ObjectHttpResponse<T> objectHttpResponse)
        {
            if (objectHttpResponse.IsOkResponse())
            {
                return Task.FromResult(objectHttpResponse.Value);
            }
            throw new HttpRequestException(objectHttpResponse.Message);
        }

        public static Task ToAsyncTask(this HttpResponse objectHttpResponse)
        {
            if (objectHttpResponse.IsOkResponse())
            {
                return Task.CompletedTask;
            }
            throw new HttpRequestException(objectHttpResponse.Message);
        }
    }
}
