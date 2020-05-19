using Dws.Template.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Interfaces.Cruds
{
    public interface IGetMultipleService<T>
    {
        Task<ObjectServiceResponse<DataSetResponse<T>>> GetMultiple(Pagination pagination);
    }
}
