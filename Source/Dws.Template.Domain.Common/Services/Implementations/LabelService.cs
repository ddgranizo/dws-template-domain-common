using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Services.Implementations
{
    public class LabelService : ILabelService
    {
        public LabelService()
        {

        }

        public string BoolToString(bool value)
        {
            if (value)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
