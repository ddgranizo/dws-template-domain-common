using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Models
{
    public class Pagination
    {
        public Guid Id { get; set; }
        public string SearchText { get; set; }
        public string Filter { get; set; }
        public string OrderBy { get; set; }
        public int Page { get; set; } = 1;
        public int Count { get; set; } = 10;
        public string Expand { get; set; }
    }
}
