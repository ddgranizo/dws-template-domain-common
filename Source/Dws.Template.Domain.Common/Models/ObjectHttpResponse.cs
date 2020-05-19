using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Models
{
    public class ObjectHttpResponse<TObject> : HttpResponse
    {
        public ObjectHttpResponse(HttpResponseMessage httpResponseMessage)
            : base(httpResponseMessage)
        {
            if (IsOkResponse())
            {
                Value = JsonSerializer.Deserialize<TObject>(GetBody().Result, Definitions.DefaultSerializeOptions);
            }
        }
        public TObject Value { get; private set; }

    }
}
