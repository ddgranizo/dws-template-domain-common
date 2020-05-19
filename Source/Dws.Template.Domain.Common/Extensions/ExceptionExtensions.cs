using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Extensions
{
    public static class ExceptionExtensions
    {
        public static Exception GetLastException(this Exception ex)
        {
            if (ex.InnerException != null)
            {
                return ex.InnerException.GetLastException();
            }
            return ex;
        }

    }
}
