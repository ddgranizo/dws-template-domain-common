using Dws.Template.Domain.Common.Interfaces.Cruds;
using Dws.Template.Domain.Common.Models;
using Dws.Template.Domain.Common.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Services.Implementations
{
    public class IntersectionCrudService<T> : CrudService<T>, IIntersectionCrudService<T>
    {
        private readonly IIntersectionCrudRepository<T> intersectionRepository;

        public IntersectionCrudService(IIntersectionCrudRepository<T> repository)
            : base(repository)
        {
            intersectionRepository = repository;
        }

        public async Task<ServiceResponse> Disassociate(Guid mainId, Guid relatedId)
        {
            try
            {
                await intersectionRepository.Disassociate(mainId, relatedId);
                return new ServiceResponse()
                    .Ok();
            }
            catch (Exception ex)
            {
                return new ServiceResponse().Exception(ex);
            }
        }
    }
}
