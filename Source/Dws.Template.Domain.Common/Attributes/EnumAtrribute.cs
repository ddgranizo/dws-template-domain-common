using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Attributes
{
    public class EnumAtrribute : Attribute
    {
        public Type TypeContainer { get; set; }
        public string EnumName { get; set; }
    }
}
