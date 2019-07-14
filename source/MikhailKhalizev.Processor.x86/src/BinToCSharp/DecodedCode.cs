﻿using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class DecodedCode
    {
        private SortedSet<Instruction> cmds = new SortedSet<Instruction>(Instruction.BeginComparer);
        public UsedSpace<Address> area = new UsedSpace<Address>();

        public Instruction cmd_get(Address addr)
        {
            cmds.TryGetValue(new Instruction(addr), out var actual);
            return actual;
        }

        public bool Contains(Address addr)
        {
            return cmds.Contains(new Instruction(addr));
        }

        public void Insert(Instruction cmd)
        {
            if (cmds.Add(cmd))
                area.Add(cmd.Begin, cmd.End);
        }

        /**
 * @brief Возвращает инструкцию, следующую за заданной.
 * @param i Инструкция, для которой необходимо определить следующую инструкцию.
 */
        public Instruction cmd_get_next_logical(Instruction i)
        {
            // Инструкции могут пересекаться.

            return cmd_get(i.End);
        }
}
}