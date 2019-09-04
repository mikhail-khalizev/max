using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class DefinitionCollection
    {
        private readonly Dictionary<Address, PropertyInfo> _propertyInfoByAddress = new Dictionary<Address, PropertyInfo>();

        public void AddDefinitionsFromAssembly(Assembly assembly)
        {
            foreach (var type in assembly.GetTypes().Where(x => typeof(IDefinitionGroup).IsAssignableFrom(x)))
                AddDefinitionsClass(type);
        }

        public void AddDefinitionsClass<T>()
        {
            AddDefinitionsClass(typeof(T));
        }

        public void AddDefinitionsClass(Type type)
        {
            var propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Static);
            foreach (var propertyInfo in propertyInfos)
            {
                if (typeof(Address).IsAssignableFrom(propertyInfo.PropertyType))
                {
                    var value = (Address)propertyInfo.GetValue(null);
                    _propertyInfoByAddress[value] = propertyInfo;
                }
                else if (typeof(StringDefinition).IsAssignableFrom(propertyInfo.PropertyType))
                {
                    var value = (StringDefinition)propertyInfo.GetValue(null);
                    _propertyInfoByAddress[value.Address] = propertyInfo;
                }
            }
        }

        public IEnumerable<PropertyInfo> GetAllStringDefinition()
        {
            return _propertyInfoByAddress
                .Select(x => x.Value)
                .Where(x => typeof(StringDefinition).IsAssignableFrom(x.PropertyType));
        }

        public string GetAddressFullName(Address address, Options options = default)
        {
            var str = "";

            if (_propertyInfoByAddress.TryGetValue(address, out var propertyInfo))
            {
                if (!options.SkipDeclaringType && propertyInfo.DeclaringType != null)
                    str = $"{propertyInfo.DeclaringType.Name}.";
                str += propertyInfo.Name;
                return str;
            }

            if (options.NullIfNoName)
                return null;

            if (options.WithNamespace)
            {
                var n = AddressNameConverter.GetNamespace(address);
                if (!string.IsNullOrEmpty(n))
                    str = $"/* {n} */ ";
            }

            if (options.WriteAddressAsDecimal)
                return $"{str}{address.Native}";
            else
                return $"{str}{address.ToShortString()}";
        }

        public struct Options
        {
            public bool WithNamespace { get; set; } // withNamespace - true, если необходимо добавить перед адресом комментарий с пространством имён; иначе - false.
            public bool SkipDeclaringType { get; set; }
            public bool NullIfNoName { get; set; }
            public bool WriteAddressAsDecimal { get; set; }

            public Options WithWriteAddressAsDecimal(bool value = true)
            {
                var opt = this;
                opt.WriteAddressAsDecimal = value;
                return opt;
            }
        }
    }
}