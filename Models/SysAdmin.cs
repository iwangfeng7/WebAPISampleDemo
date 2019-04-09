using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIdemo
{
    /// <summary>
    /// 登录用户实体类
    /// </summary>
    public class SysAdmin
    {
        public string LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string AdminName { get; set; }
    }
}