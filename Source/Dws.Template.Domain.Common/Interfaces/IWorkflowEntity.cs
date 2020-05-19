using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces
{
    public interface IWorkflowEntity
    {
        IEnumerable<Type> GetPreCreateWorkflows();
        IEnumerable<Type> GetPostCreateWorkflows();
        IEnumerable<Type> GetPreUpdateWorkflows();
        IEnumerable<Type> GetPostUpdateWorkflows();
        IEnumerable<Type> GetPreDeleteWorkflows();
        IEnumerable<Type> GetPostDeleteWorkflows();
    }
}
