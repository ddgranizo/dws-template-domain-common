﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Interfaces
{
    public interface IEntityIntersection
    {
        Guid GetMainId();
        Guid GetRelatedId();
    }
}
