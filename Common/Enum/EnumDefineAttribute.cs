using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 枚举特性
    /// </summary>
    public class EnumDefineAttribute : Attribute
    {
        public EnumDefineAttribute()
        {

        }


        public EnumDefineAttribute(string description)
        {
            this.Description = description;
        }

        /// <summary>
        /// 枚举值。
        /// </summary>
        public Int32 Value { get; internal set; }

        /// <summary>
        /// 枚举描述。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 枚举获取列表标识
        /// </summary>
        public string Identity { get; set; }

    }
}
