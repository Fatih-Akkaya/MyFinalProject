using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true,message) //mesaj varsa hem true hem de mesajı gönderir
        {
        }
        public SuccessResult() : base(true) //parametre verilmezse direkt true gider
        {
        }
    }
}
