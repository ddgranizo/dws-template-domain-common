using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class OptionSetAtrribute : Attribute
    {
        public string DisplayName { get; set; }
        public int Value { get; set; }

    }
}
