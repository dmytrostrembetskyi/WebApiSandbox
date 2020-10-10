using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Web.Api.Core.Dto.GatewayResponses
{
    public abstract class BaseGatewayResponse
    {
        public bool Success { get; set; }
        public IEnumerable<Error> Errors { get; set; }

        protected BaseGatewayResponse(bool success = false, IEnumerable<Error> errors = null)
        {
            Success = success;
            Errors = errors;
        }
    }
}