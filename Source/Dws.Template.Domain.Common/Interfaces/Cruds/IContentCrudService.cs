using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces.Cruds
{
    public interface IContentCrudService<T> :
            ICrudService<T>,
            IContentService<T>
    {
    }
}
