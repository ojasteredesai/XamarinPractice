﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamLearningDemo3.Convertor
{
    public class EasingConverterr : TypeConverter
    {
        public override bool CanConvertFrom(Type sourceType)
        {
            if (sourceType == null)
                throw new ArgumentNullException("EasingConverter.CanConvertFrom: sourceType");
            return (sourceType == typeof(string));
        }        public override object ConvertFrom(CultureInfo culture, object value)
        {
            if (value == null || !(value is string))
                return null;
            string name = ((string)value).Trim();
            if (name.StartsWith("Easing"))
            {
                name = name.Substring(7);
            }

            FieldInfo field = typeof(Easing).GetRuntimeField(name);
            if (field != null && field.IsStatic)
            {
                return (Easing)field.GetValue(null);
            }
            throw new InvalidOperationException(
            String.Format("Cannot convert \"{0}\" into Xamarin.Forms.Easing", value));
        }
    }
}
