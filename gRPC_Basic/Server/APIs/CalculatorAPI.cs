﻿using CalculatorPkg;
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
            return Task.FromResult(new CalcResponse() { Result = request.A + request.B  });

        }

        public override Task<CalcResponse> Subtract(CalcRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CalcResponse() { Result = request.A - request.B });
        }
    }
}