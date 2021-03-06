using CalculatorPkg;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static CalculatorPkg.CalculatorService;

namespace Server.APIs
{
    public class CalculatorAPI : CalculatorServiceBase
    {
        public override Task<CalcResponse> Add(CalcRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Request for Adding {request.A} and {request.B} received ");
            return Task.FromResult(new CalcResponse() { Result = request.A + request.B  });

        }

        public override Task<CalcResponse> Subtract(CalcRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Request for Subtracting {request.A} and {request.B} received ");
            return Task.FromResult(new CalcResponse() { Result = request.A - request.B });
        }

        public override async Task<CalcResponse> Multiply(CalcRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Request for Multiplying {request.A} and {request.B} received ");
            await Task.Delay(2000);
            return await Task.FromResult(new CalcResponse() { Result = request.A * request.B });
        }

        public override Task<CalcDivResponse> Divide(CalcDivRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Request for Multiplying {request.A} and {request.B} received ");
            if (request.B == 0)
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Divisor cannot be Zero"));
            }
            return Task.FromResult(new CalcDivResponse() { Result = request.A / (double)request.B });
        }
    }
}
