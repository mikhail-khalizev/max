using System;
using System.ComponentModel;
using System.Globalization;

namespace MikhailKhalizev.Processor.x86
{
    public class AddressTypeConverter : TypeConverter
    {
        /// <inheritdoc />
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            else
                return base.CanConvertFrom(context, sourceType);
        }

        /// <inheritdoc />
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string str)
                return Address.Parse(str);
            else
                return base.ConvertFrom(context, culture, value);
        }
    }
}