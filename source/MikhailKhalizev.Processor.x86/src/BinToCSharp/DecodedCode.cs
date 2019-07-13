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

        public bool Contains(Address addr)
        {
            return cmds.Contains(Instruction.CreateDummyInstruction(addr));
        }

        public void Insert(Instruction cmd)
        {
            if (cmds.Add(cmd))
                area.Add(cmd.Begin, cmd.End);
        }
    }
}