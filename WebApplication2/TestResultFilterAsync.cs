using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class TestResultFilterAsync : IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            Debug.WriteLine("client did not receive response yet");

            await next();

            Debug.WriteLine("client has received the response...");
        }
    }
}
