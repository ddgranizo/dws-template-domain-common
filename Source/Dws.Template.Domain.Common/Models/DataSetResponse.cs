using System;
using System.Collections.Generic;
using System.Text;

namespace Dws.Template.Domain.Common.Models
{
    public class DataSetResponse<T>
    {
        public IEnumerable<T> Values { get; set; }
        public double TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int Count { get; set; }
        public double TotalCount { get; set; }

        public DataSetResponse()
        {

        }

        public DataSetResponse(Pagination pagination)
        {
            Count = pagination.Count;
            CurrentPage = pagination.Page;
        }

        public void SetValues(IEnumerable<T> values)
        {
            Values = values ?? throw new ArgumentNullException(nameof(values));
        }
    }
}
