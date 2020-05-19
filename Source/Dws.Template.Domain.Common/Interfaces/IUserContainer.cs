using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces
{
    public interface IUserContainer
    {

        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
    }
}
