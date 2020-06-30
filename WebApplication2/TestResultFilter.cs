using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class TestResultFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            Debug.WriteLine("before");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Debug.WriteLine("after");
        }
    }
}
