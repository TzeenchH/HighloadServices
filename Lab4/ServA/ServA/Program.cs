using Grpc.Net.Client;
using PhoneValidatorProtos;
using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using System.Collections.Generic;
using System.Linq;

namespace ServA
{
    class Program
    {

        static async Task Main(string[] args)
        {
            var schema = Schema.For(@" 
                type Query{
                    isphonevalid (number: string, code: int) {
                        result: string
                    }
                }
               ");
            using var channel = GrpcChannel.ForAddress("https://localhost:5050");
            var client = new PhoneValidatorProtos.Numberer.NumbererClient(channel);
            IReadOnlyCollection<int> codes = new int[] { 26, 42, 13, 24 };
            int code = 11;
            var reply = await client.ValidateNumberAsync(new NumberRequest { Number = number });
            if (reply.Result)
            {
                if (codes.Contains<int>(code))
                {
                    var res = new { Result = "valid" };
                    schema.ExecuteAsync(_ =>
                    {
                        _.Query = "{isphonevalid}";
                        _.Root = res;
                    });
                }
                else
                {
                    var res = new { Result = "not valid" };
                    schema.ExecuteAsync(_ =>
                    {
                        _.Query = "{isphonevalid}";
                        _.Root = res;
                    });
                }
            }
            else
            {
                var res = new { Result = "phone not found" };
                schema.ExecuteAsync( _ =>
                {
                    _.Query = "{isphonevalid}";
                    _.Root = res;
                });
            }
        }

    }
}
