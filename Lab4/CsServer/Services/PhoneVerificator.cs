using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsServer.Services
{
    public class PhoneVerificator : CsServer.PhoneVerification.PhoneVerificationBase
    {
        private readonly List<string> numbers = new List<string>() { "88005553535", "0123456789" };
        public override Task<PhoneResponse> VerifyPhone(PhoneRequest request, ServerCallContext context)
        {
            if (numbers.Contains(request.PhoneNumber))
            {
                return Task.FromResult
                (
                    new PhoneResponse() { Message = Response.Found }
                 );
            }
            else return Task.FromResult
            (
                new PhoneResponse() { Message = Response.NotFound }
            );
        }
    }
}
