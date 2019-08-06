using System;
using System.Collections.Generic;
using System.Diagnostics;
using MikhailKhalizev.Processor.x86.Core.Abstractions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    [DebuggerDisplay("Guid = {Guid}, Address = {Address}")]
    public class JumpsInfoDto
    {
        public Guid Guid { get; set; }

        public Address Address { get; set; }

        public Dictionary<Address /* from */, List<Address /* to */>> Jumps { get; set; } = new Dictionary<Address, List<Address>>();
    }
}