﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace WebAPI_DotNetCore_Demo.Application.Exceptions
{
    public class IncorrectPasswordException : Exception, IException
    {
        public IncorrectPasswordException() { }

        public IncorrectPasswordException(string message) : base(message) { }

        public IncorrectPasswordException(string message, Exception inner) : base(message, inner) { }

        public async Task TransformHttpResponseAsync(HttpContext httpContext)
        {
            httpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

            await httpContext.Response.WriteAsync(
                JsonConvert.SerializeObject(new
                {
                    HttpStatusCode = HttpStatusCode.Unauthorized,
                    ErrorMessage = Message
                }));
        }
    }
}
