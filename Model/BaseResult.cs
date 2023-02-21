using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_technical_code.Model
{
    public class BaseResult
    {
        public bool? Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
