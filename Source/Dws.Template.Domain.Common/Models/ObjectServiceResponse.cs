using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dws.Template.Domain.Common.Models
{
    public class ObjectServiceResponse<TObject> : ServiceResponse
    {
        public TObject Value { get; private set; }

        public ObjectServiceResponse() : base() { }

        public ObjectServiceResponse<TObject> Ok(
            TObject instance,
            string message = null,
            string code = DefaultOkCode)
        {
            Value = instance;
            Ok(message, code);
            return this;
        }

        public new ObjectServiceResponse<TObject> Error(string message, string code = DefaultErrorCode)
        {
            base.Error(message, code);
            return this;
        }

        public new ObjectServiceResponse<TObject> Warning(string message, string code = DefaultWarningCode)
        {
            base.Warning(message, code);
            return this;
        }

        public new ObjectServiceResponse<TObject> Exception(Exception exception, string code = DefaultExceptionCode)
        {
            base.Exception(exception, code);
            return this;
        }

        public override bool IsOkResponse() =>
            base.IsOkResponse() && Value != null;


    }
}
