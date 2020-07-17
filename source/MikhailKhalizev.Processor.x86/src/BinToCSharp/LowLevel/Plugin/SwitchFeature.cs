using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel.Plugin
{
    public class SwitchFeature : IInstructionFeature
    {
        public List<Address> Addresses { get; }

        public SwitchFeature()
        {
            Addresses = new List<Address>();
        }

        public SwitchFeature(List<Address> addresses)
        {
            Addresses = addresses;
        }
    }
}