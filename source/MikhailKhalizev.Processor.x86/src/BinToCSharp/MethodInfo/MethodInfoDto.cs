using System;
using System.Collections.Generic;
using System.Diagnostics;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    [DebuggerDisplay("Id = {Id}")]
    public class MethodInfoDto : IEquatable<MethodInfoDto>, IComparable<MethodInfoDto>, IComparable
    {
        public static string GenerateId(Address address, ArchitectureMode mode, byte[] raw)
        {
            var rawHash = (int)mode;
            for (var i = 0; i < raw.Length; i++)
                rawHash = (((rawHash << 5) + rawHash) ^ raw[i]);
            return $"{address}-{rawHash:x}";
        }


        public string Id { get; set; }

        public Address CsBase { get; set; }

        public bool ShouldSerializeCsBase() => CsBase != 0;

        // Result address (CsBase already added).
        public Address Address { get; set; }

        /// <summary>
        /// Разрядность декодируемого кода. 16 или 32 бит.
        /// </summary>
        public ArchitectureMode Mode { get; set; }

        /// <summary>
        /// Исходный бинарный код метода.
        /// </summary>
        public string Raw { get; set; }
        
        /// <summary>
        /// Дополнительный код.
        /// </summary>
        public Dictionary<Address, string> ExtraRaw { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> AdditionalData { get; set; }


        [JsonIgnore]
        public byte[] RawBytes
        {
            get => _rawBytes ?? (_rawBytes = HexHelper.ToBytes(Raw));
            set
            {
                _rawBytes = null;

                Raw = HexHelper.ToHexWithoutPrefix(value);

                if (Raw.Length % 2 != 0)
                    throw new InvalidOperationException("Raw.Length % 2 != 0");
            }
        }
        private byte[] _rawBytes;

        [JsonIgnore]
        public JumpsInfoDto JumpsInfo { get; set; }

        [JsonIgnore]
        public Dictionary<Address /* from */, HashSet<JumpDestinationInfoDto>> Jumps { get; set; }

        [JsonIgnore]
        public bool IgnoreSave { get; set; }

        
        #region IEquatable
        
        /// <inheritdoc />
        public bool Equals(MethodInfoDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is MethodInfoDto other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }

        #endregion
        
        #region IComparable

        /// <inheritdoc />
        public int CompareTo(MethodInfoDto other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;

            var addressComparison = Address.CompareTo(other.Address);
            if (addressComparison != 0) return addressComparison;

            return string.Compare(Id, other.Id, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;

            return obj is MethodInfoDto other
                ? CompareTo(other)
                : throw new ArgumentException($"Object must be of type {nameof(MethodInfoDto)}");
        }

        #endregion
    }
}