using System;
using System.Collections.Generic;
using System.Diagnostics;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Utils;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    [DebuggerDisplay("Guid = {Guid}, Address = {Address}")]
    public class FunctionModel
    {
        public Guid Guid { get; set; }
        public Address Address { get; set; }
        public ArchitectureMode Mode { get; set; }
        public string Raw { get; set; }

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