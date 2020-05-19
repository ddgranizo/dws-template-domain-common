using Dws.Template.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Interfaces.Cruds
{
    public interface IUpdateService<T>
    {
        Task<ServiceResponse> Update(Guid id, T data);
    }
}
