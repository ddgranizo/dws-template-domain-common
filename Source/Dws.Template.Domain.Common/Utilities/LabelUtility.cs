using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Utilities
{
    public static class LabelUtility
    {
        public static string BoolToString(bool boolean)
        {
            if (boolean)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
