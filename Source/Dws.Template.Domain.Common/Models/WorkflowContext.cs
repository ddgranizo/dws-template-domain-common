using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Models
{
    public class WorkflowContext
    {
        public object Data { get; set; }
        //public HttpContext HttpContext { get; }
        public Guid PrimaryEntityId { get; set; }
        public Guid UserId { get; set; }

        public WorkflowContext()
        {

        }

        public WorkflowContext(object data)
        {
            Data = data;
            //HttpContext = httpContext;
            //UserId = new Guid(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        public WorkflowContext(object data, Guid primaryEntityId)
            : this(data)
        {
            PrimaryEntityId = primaryEntityId;
        }

        public void SetData(object data)
        {
            Data = data;
        }

        public void SetPrimaryEntityId(Guid id)
        {
            PrimaryEntityId = id;
        }
    }
}
