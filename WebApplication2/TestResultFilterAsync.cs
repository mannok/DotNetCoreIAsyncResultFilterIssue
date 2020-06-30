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

            await next();   // action handler should be fired at this point

            Debug.WriteLine("client should not yet received the response at this point. However, I can see the response has been returned from server while breakpoint is stopped at this line. This behavior is not same as the Synchronize Version (IResultFilter). We have no way to set the result after the action handler has finished and before response has been sent back to client.");
        }
    }
}
