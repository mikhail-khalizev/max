using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public Address Address { get; set; }

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