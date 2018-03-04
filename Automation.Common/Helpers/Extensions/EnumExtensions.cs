using System;
using System.ComponentModel;
using System.Reflection;

namespace Automation.Common.Helpers.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var enumValueAsString = enumValue.ToString();

            var type = enumValue.GetType();
            var fieldInfo = type.GetField(enumValueAsString);
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length <= 0) return enumValueAsString;
            var attribute = (DescriptionAttribute) attributes[0];
            return attribute.Description;
        }
    }
}