using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Repositories.Base
{
    public interface IContentCrudRepository<T> : ICrudRepository<T>
    {
        Task UpdateContent(Guid id, string content);
    }
}
