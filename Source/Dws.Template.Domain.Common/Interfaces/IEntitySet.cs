using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces
{
    public interface IEntitySet : IEntityKey, IOrganizationQueryable, IUserContainer, IDateContainer
    {

    }
}
