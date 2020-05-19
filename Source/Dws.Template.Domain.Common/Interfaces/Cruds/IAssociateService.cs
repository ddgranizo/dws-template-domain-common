using Dws.Template.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Interfaces.Cruds
{
    public interface IAssociateService<U, V>
    {
        Task<ServiceResponse> Execute(U mainData, V related);
        Task<ServiceResponse> Execute(U mainData, IEnumerable<V> relatedSet);
    }
}
