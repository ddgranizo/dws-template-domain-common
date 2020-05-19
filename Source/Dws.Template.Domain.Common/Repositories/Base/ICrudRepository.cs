using Dws.Template.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Repositories.Base
{
    public interface ICrudRepository<T>
    {
        Task<T> Get(Guid id);
        Task<DataSetResponse<T>> Get(Pagination pagination);
        Task<Guid> Create(T data);
        Task Delete(Guid id);
        Task Update(Guid id, T data);
    }
}
