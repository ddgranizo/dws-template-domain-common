using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Models
{
    public class UpdatedValue<T>
    {
        public T OldValue { get; set; }
        public T NewValue { get; set; }

        public UpdatedValue(T oldValue, T newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
