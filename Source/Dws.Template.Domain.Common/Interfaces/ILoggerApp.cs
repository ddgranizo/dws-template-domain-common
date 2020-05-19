using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces
{
    public interface ILoggerApp
    {
        void Log(string text);
        void Log(object data);
    }
}
