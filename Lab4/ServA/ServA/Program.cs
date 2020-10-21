using Grpc.Net.Client;
using PhoneValidatorProtos;
using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using ServA.Resolvers;

namespace ServA
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var schema = Schema.For(@" 
                type Query {
                    number: String
                }
               ");
            using var channel = GrpcChannel.ForAddress("https://localhost:5050");
            var client = new PhoneValidatorProtos.Numberer.NumbererClient(channel);
            string number = "";
            var reply = await client.ValidateNumberAsync(new NumberRequest { Number = number });
            if (reply.Result)
            {

            }
            else
            {

            }
        }

        private Schema CreateSchema()
        {
            var numberField = new FieldType();
            numberField.Name = "number";
            numberField.ResolvedType = new StringGraphType();
            numberField.Type = typeof(string);
            numberField.Resolver = new NumberFieldResolver();
            var codeField = new FieldType();
            codeField.Name = "code";
            codeField.ResolvedType = new StringGraphType();
            codeField.Type = typeof(string);
            codeField.Resolver = new CodeFieldResolver();
        }
    }
}
