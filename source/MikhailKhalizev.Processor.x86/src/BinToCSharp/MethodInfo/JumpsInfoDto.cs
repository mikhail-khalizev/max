using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    [DebuggerDisplay("Id = {Id}")]
    public class JumpsInfoDto : IEquatable<JumpsInfoDto>
    {
        public string Id { get; set; }

        public List<Address /* from */> IsGoUp { get; set; }

        public Dictionary<Address /* from */, List<JumpDestinationInfoDto /* to */>> Jumps { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> AdditionalData { get; set; }


        #region JumpsInfoDto

        /// <inheritdoc />
        public bool Equals(JumpsInfoDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is JumpsInfoDto other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }

        #endregion
    }
}