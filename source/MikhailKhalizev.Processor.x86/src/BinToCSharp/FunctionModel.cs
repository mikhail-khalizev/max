using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    [DebuggerDisplay("Guid = {Guid}, Address = {Address}")]
    public class FunctionModel
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

        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }


        public static IEqualityComparer<FunctionModel> BodyEqualityComparer =>
            new CustomEqualityComparer<FunctionModel>(
                (x, y) => x.Mode == y.Mode && x.Raw == y.Raw,
                x => Tuple.Create(x.Mode, x.Raw).GetHashCode());

        public static IEqualityComparer<FunctionModel> GuidEqualityComparer =>
            new CustomEqualityComparer<FunctionModel>(
                (x, y) => x.Guid == y.Guid,
                x => x.Guid.GetHashCode());

        public static IEqualityComparer<FunctionModel> AddressAndModeEqualityComparer =>
            new CustomEqualityComparer<FunctionModel>(
                (x, y) => x.Mode == y.Mode && x.Address == y.Address,
                x => Tuple.Create(x.Mode, x.Address).GetHashCode());
    }
}