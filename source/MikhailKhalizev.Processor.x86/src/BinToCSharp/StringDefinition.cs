using System;
using MikhailKhalizev.Processor.x86.Core.Abstractions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class StringDefinition : IEquatable<StringDefinition>
    {
        public Address Address { get; }
        public string String { get; }

        public StringDefinition(Address address, string str)
        {
            Address = address;
            String = str;
        }

        public static implicit operator Value(StringDefinition sd) => sd.Address;

        #region IEquatable
        
        /// <inheritdoc />
        public bool Equals(StringDefinition other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Address.Equals(other.Address) && string.Equals(String, other.String);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((StringDefinition) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (Address.GetHashCode() * 397) ^ (String != null ? String.GetHashCode() : 0);
            }
        }

        #endregion
    }
}