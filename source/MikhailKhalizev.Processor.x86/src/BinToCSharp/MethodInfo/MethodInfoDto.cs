using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    [DebuggerDisplay("Id = {Id}")]
    public class MethodInfoDto : IEquatable<MethodInfoDto>
    {
        public static string GenerateId(Address address, ArchitectureMode mode, byte[] raw)
        {
            var rawHash = (int)mode;
            for (var i = 0; i < raw.Length; i++)
                rawHash = (((rawHash << 5) + rawHash) ^ raw[i]);
            return $"{address}-{rawHash:x}";
        }


        public string Id { get; set; }

        public Guid Guid { get; set; }

        public Address CsBase { get; set; }

        public bool ShouldSerializeCsBase() => CsBase != 0;

        public Address Address
        {
            get => Addresses.FirstOrDefault();
            set
            {
                if (Addresses.Count == 0)
                    Addresses.Add(value);
                else if (Addresses.Count == 1)
                    Addresses[0] = value;
                else
                    throw new InvalidOperationException("Multiple addresses associated with function.");
            }
        }

        public List<Address> Addresses { get; set; } = new List<Address>(); // TODO Удалить поддержку дублирующих методов. Только хлопоты добавляет. А в реальном человеческом коде дублей нет.

        public bool ShouldSerializeAddresses() => 1 < Addresses.Count;

        /// <summary>
        /// Разрядность декодируемого кода. 16 или 32 бит.
        /// </summary>
        public ArchitectureMode Mode { get; set; }

        /// <summary>
        /// Исходный бинарный код функции.
        /// </summary>
        public string Raw { get; set; }

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
    }
}