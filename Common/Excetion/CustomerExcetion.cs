using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 自定义异常
    /// </summary>
    public class CustomerExcetion:System.Exception
    {
        public CustomerExcetion() { }
       
        public CustomerExcetion(string message) : base(message)
        {

        }

    }
}
