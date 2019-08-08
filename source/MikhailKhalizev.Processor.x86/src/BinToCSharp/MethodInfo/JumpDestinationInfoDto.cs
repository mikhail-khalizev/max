using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    public class JumpDestinationInfoDto : IEquatable<JumpDestinationInfoDto>
    {
        public Address Address { get; set; }

        public Guid Guid { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> AdditionalData { get; set; }
        
        #region IEquatable

        /// <inheritdoc />
        public bool Equals(JumpDestinationInfoDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Address.Equals(other.Address);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((JumpDestinationInfoDto) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Address.GetHashCode();
        }

        #endregion
    }
}