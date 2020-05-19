using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Repositories.Base
{
    public interface IIntersectionCrudRepository<T> : ICrudRepository<T>
    {
        Task Disassociate(Guid mainDataId, Guid relatedDataId);
    }
}
