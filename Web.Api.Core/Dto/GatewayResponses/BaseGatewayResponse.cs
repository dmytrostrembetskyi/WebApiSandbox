using System.Collections.Generic;

namespace Web.Api.Core.Dto.GatewayResponses
{
    public abstract class BaseGatewayResponse
    {
        protected BaseGatewayResponse(bool success = false, IEnumerable<Error> errors = null)
        {
            Success = success;
            Errors = errors;
        }

        public bool Success { get; set; }
        public IEnumerable<Error> Errors { get; set; }
    }
}