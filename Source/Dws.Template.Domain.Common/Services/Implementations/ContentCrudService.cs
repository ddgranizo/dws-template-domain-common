using Dws.Template.Domain.Common.Interfaces.Cruds;
using Dws.Template.Domain.Common.Models;
using Dws.Template.Domain.Common.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Services.Implementations
{
    public class ContentCrudService<T> : CrudService<T>, IContentCrudService<T>
    {
        private readonly IContentCrudRepository<T> contentRepository;

        public ContentCrudService(IContentCrudRepository<T> repository)
            : base(repository)
        {
            contentRepository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ServiceResponse> UpdateContent(Guid id, string content)
        {
            try
            {
                await contentRepository.UpdateContent(id, content);
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
