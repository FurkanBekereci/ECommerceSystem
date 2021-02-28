using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Önemli not: read-only propertyler sadece constructor içerisinde set edilebilir.
        public Result(bool success,string message = null)
        {
            Success = success;
            Message = message;
        }
        public bool Success { get; }

        public string Message { get; }
        
    }
}
