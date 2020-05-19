using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Attributes
{
    public class CustomContent : Attribute
    {
        public Type ContentType { get; set; }
    }
}
