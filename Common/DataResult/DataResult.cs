using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum CodeStatus
    {
        fail=0,
        Sucess = 1,
        Exception = 2
    }
    public class DataResult<T>
    {
        /// <summary>
        /// 接口状态
        /// </summary>
        public CodeStatus CodeStatus { get; set; }
        /// <summary>
        /// 提示文本
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 数据结果
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 当前页索引
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// 每页记录条数
        /// </summary>
        public int limit { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public int Count{ get; set; }
    }
}
