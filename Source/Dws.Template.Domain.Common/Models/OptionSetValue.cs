using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Models
{
    public class OptionSetValue<T>
    {
        public string DisplayName { get; set; }
        public T Value { get; set; }

        public OptionSetValue(string displayName, T value)
        {
            DisplayName = displayName;
            Value = value;
        }

        public OptionSetValue(T value)
        {
            Value = value;
        }

        public OptionSetValue()
        {
        }
    }
}
