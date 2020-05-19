using Dws.Template.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Interfaces
{
    public interface IWorkflowAction
    {
        Task Execute(WorkflowContext context);
    }
}
