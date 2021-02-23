using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            Success = success;
        }

        public Result(bool success,string message) : this(success)
        {
            Messages = message;
        }
        public bool Success { get; }

        public string Messages { get; }
    }
}
