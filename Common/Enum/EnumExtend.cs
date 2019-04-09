using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 枚举扩展方法
    /// </summary>
    public static class EnumExtend
    {
        /// <summary>
        /// 获得枚举的EnumDefineAttribute定义。
        /// </summary>
        /// <param name="en">枚举</param>
        /// <returns></returns>
        private static EnumDefineAttribute GetEnumDefineAttribute(System.Enum en)
        {
            string name = System.Enum.GetName(en.GetType(), en);
            FieldInfo field = en.GetType().GetField(name);
            return Attribute.GetCustomAttribute(field, typeof(EnumDefineAttribute)) as EnumDefineAttribute;
        }

        /// <summary>
        /// 根据枚举值获得枚举。
        /// </summary>
        /// <param name="enValue">枚举值</param>
        /// <returns></returns>
        public static TEnum GetEnum<TEnum>(this Int32 enValue) where TEnum : struct
        {
            Type typeFromHandle = typeof(TEnum);
            if (!typeFromHandle.IsEnum)
            {
                throw new System.Exception("GetEnum<TEnum> 中的 TEnum 必须为枚举类型!");
            }

            return (TEnum)System.Enum.Parse(typeFromHandle, Convert.ToString(enValue));
        }

        /// <summary>
        /// 根据枚举获取枚举值
        /// </summary>
        /// <param name="en">枚举</param>
        /// <returns></returns>
        public static int GetValue(System.Enum en)
        {
            return Convert.ToInt32(en);
        }

        /// <summary>
        /// 获得枚举项定义的名称。
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public static string GetName(System.Enum en)
        {
            return System.Enum.GetName(en.GetType(), en);
        }

        /// <summary>
        /// 获得枚举EnumDefineAttribute定义的Description内容。
        /// </summary>
        /// <param name="en">枚举。</param>
        /// <returns></returns>
        public static string GetDescription(this System.Enum en)
        {
            EnumDefineAttribute enumDefineAttribute = GetEnumDefineAttribute(en);
            return enumDefineAttribute.Description;
        }

        /// <summary>
        /// 返回枚举项的EnumDefineAttribute集合。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="identiyName"></param>
        /// <returns></returns>
        public static List<EnumDefineAttribute> GetEnumDefineAttributes<T>(string identiyName)
        {
            Type typeFromHandle = typeof(T);
            if (!typeFromHandle.IsEnum)
            {
                throw new System.Exception("GetEnumDefineAttributes<T> 中的 T 必须为枚举类型!");
            }

            List<EnumDefineAttribute> list = new List<EnumDefineAttribute>();
            Array enumArray = System.Enum.GetValues(typeFromHandle);
            for (int i = 0; i < enumArray.Length; i++)
            {
                System.Enum en = (System.Enum)enumArray.GetValue(i);
                EnumDefineAttribute enumDefineAttribute = GetEnumDefineAttribute(en);
                enumDefineAttribute.Value = GetValue(en);

                if (!string.IsNullOrEmpty(identiyName) && enumDefineAttribute.Identity == identiyName)
                {
                    list.Add(enumDefineAttribute);
                }
            }

            return list;
        }
    }
}
