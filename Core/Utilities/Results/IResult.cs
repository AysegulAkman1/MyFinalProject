using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }//get okumak için kullandık.İşlem başarılı mı degil mi
        string Message { get; }//kullanıcıya mesaj gönderme şu yönden başarısız gibi.
    }
}
