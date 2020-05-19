using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces
{
    public interface IDateContainer
    {
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
