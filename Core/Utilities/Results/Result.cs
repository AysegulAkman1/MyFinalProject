using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success)//hem kendi hemde diger result çalışcak
        {
            Message = message;          
        }

        public Result(bool success) //aşırı yükleme
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
