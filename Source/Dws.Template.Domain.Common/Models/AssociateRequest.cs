using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Models
{
    public class AssociateRequest<T>
    {
        public IEnumerable<T> RelatedSet { get; set; }

        public AssociateRequest(IEnumerable<T> relatedSet)
        {
            RelatedSet = relatedSet;
        }
    }
}
