using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
            Success = success;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public string Message { get; }
        public bool Success { get; }
    }
}
