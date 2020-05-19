using Dws.Template.Domain.Common.Interfaces.Cruds;
using Dws.Template.Domain.Common.Models;
using Dws.Template.Domain.Common.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Services.Implementations
{
    public class CrudService<T> : ICrudService<T>
    {
        protected readonly ICrudRepository<T> repository;

        public CrudService(ICrudRepository<T> repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ObjectServiceResponse<Guid>> Create(T data)
        {
            try
            {
                return new ObjectServiceResponse<Guid>()
                    .Ok(await repository.Create(data));
            }
            catch (Exception ex)
            {
                return new ObjectServiceResponse<Guid>().Exception(ex);
            }
        }

        public async Task<ServiceResponse> Delete(Guid id)
        {
            try
            {
                await repository.Delete(id);
                return new ServiceResponse().Ok();
            }
            catch (Exception ex)
            {
                return new ServiceResponse().Exception(ex);
            }
        }

        public async Task<ObjectServiceResponse<T>> Get(Guid id)
        {
            try
            {
                return new ObjectServiceResponse<T>()
                    .Ok(await repository.Get(id));
            }
            catch (Exception ex)
            {
                return new ObjectServiceResponse<T>().Exception(ex);
            }
        }

        public async Task<ObjectServiceResponse<DataSetResponse<T>>> GetMultiple(Pagination pagination)
        {
            try
            {
                return new ObjectServiceResponse<DataSetResponse<T>>()
                    .Ok(await repository.Get(pagination));
            }
            catch (Exception ex)
            {
                return new ObjectServiceResponse<DataSetResponse<T>>().Exception(ex);
            }
        }


        public async Task<ServiceResponse> Update(Guid id, T data)
        {
            try
            {
                await repository.Update(id, data);
                return new ServiceResponse().Ok();
            }
            catch (Exception ex)
            {
                return new ServiceResponse().Exception(ex);
            }
        }
    }
}
