using System;
using System.Collections.Generic;
using System.Diagnostics;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    [DebuggerDisplay("Guid = {Guid}, Address = {Address}")]
    public class JumpsInfoDto
    {
        public Guid Guid { get; set; }

        public Address Address { get; set; }

        public List<Address /* from */> IsGoUp { get; set; }

        public Dictionary<Address /* from */, List<JumpDestinationInfoDto /* to */>> Jumps { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> AdditionalData { get; set; }
    }
}