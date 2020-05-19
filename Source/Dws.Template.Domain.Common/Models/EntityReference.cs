using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Models
{
    public class EntityReference
    {
        public string EntityLogicalName { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public EntityReference()
        {

        }

        public EntityReference(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
