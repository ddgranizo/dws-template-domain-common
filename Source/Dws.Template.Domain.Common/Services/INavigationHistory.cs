using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Services
{
    public interface INavigationHistory
    {
        void NagivageBack();
        void NavigateForward();
    }
}
