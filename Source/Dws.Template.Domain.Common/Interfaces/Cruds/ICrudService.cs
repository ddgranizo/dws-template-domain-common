using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces.Cruds
{
    public interface ICrudService<T> :
            ICreateService<T>,
            IUpdateService<T>,
            IGetMultipleService<T>,
            IGetService<T>,
            IDeleteService
    {
    }
}
