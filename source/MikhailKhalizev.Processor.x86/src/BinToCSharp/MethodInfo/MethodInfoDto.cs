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
    [DebuggerDisplay("Guid = {Guid}, Address = {Address}")]
    public class MethodInfoDto
    {
        public Guid Guid { get; set; }

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

        public bool ShouldSerializeAddress() => 1 == Addresses.Count;

        public List<Address> Addresses { get; set; } = new List<Address>();

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
        private IDictionary<string, JToken> AdditionalData { get; set; }


        [JsonIgnore]
        public byte[] RawBytes
        {
            get => _rawBytes ?? (_rawBytes = HexHelper.ToBytes(Raw));
            set => Raw = HexHelper.ToHexWithoutPrefix(value);
        }
        private byte[] _rawBytes;

        [JsonIgnore]
        public Dictionary<Address /* from */, HashSet<Address /* to */>> Jumps { get; set; } = new Dictionary<Address, HashSet<Address>>();

        [JsonIgnore]
        public bool IgnoreSave { get; set; }


        public static IEqualityComparer<MethodInfoDto> BodyEqualityComparer =>
            new CustomEqualityComparer<MethodInfoDto>(
                (x, y) => x.Mode == y.Mode && x.Raw == y.Raw,
                x => Tuple.Create(x.Mode, x.Raw).GetHashCode());

        public static IEqualityComparer<MethodInfoDto> GuidEqualityComparer =>
            new CustomEqualityComparer<MethodInfoDto>(
                (x, y) => x.Guid == y.Guid,
                x => x.Guid.GetHashCode());

        public static IEqualityComparer<MethodInfoDto> AddressAndModeEqualityComparer =>
            new CustomEqualityComparer<MethodInfoDto>(
                (x, y) => x.Mode == y.Mode && x.Address == y.Address,
                x => Tuple.Create(x.Mode, x.Address).GetHashCode());
    }
}