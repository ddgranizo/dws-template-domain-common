using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces
{
    public interface IValidatableContent
    {
        IEnumerable<ValidationResult> Validate(string contentJson);
    }
}
