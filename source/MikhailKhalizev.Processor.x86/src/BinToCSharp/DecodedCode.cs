using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class DecodedCode
    {
        private SortedSet<Instruction> cmds = new SortedSet<Instruction>(Instruction.BeginComparer);
        private UsedSpace<Address> area = new UsedSpace<Address>();

        public SortedSet<Instruction> cmd_get(Address addr)
        {
            return cmds.GetViewBetween(
                Instruction.CreateDummyInstruction(addr), 
                Instruction.CreateDummyInstruction(Address.MaxValue));
        }

        public bool contains(Address addr)
        {
            return cmd_get(addr).Count != 0;
        }
    }
}