using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4274-f7ebcfb1")]
        public void Method_0000_4274()
        {
            ii(0x4274, 1);  pop(ds);                                   /* pop ds */
            ii(0x4275, 1);  pop(ax);                                   /* pop ax */
            ii(0x4276, 1);  pusha();                                   /* pusha */
            ii(0x4277, 1);  push(es);                                  /* push es */
            ii(0x4278, 1);  push(ds);                                  /* push ds */
            ii(0x4279, 1);  push(ss);                                  /* push ss */
            ii(0x427a, 3);  mov(ax, 0x20);                             /* mov ax, 0x20 */
            ii(0x427d, 2);  mov(ds, ax);                               /* mov ds, ax */
            ii(0x427f, 4);  push(memw[ds, 0x996]);                     /* push word [0x996] */
            ii(0x4283, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x4285, 4);  add(memw[ss, bp + 14], 6);                 /* add word [bp+0xe], 0x6 */
            ii(0x4289, 2);  if(jmp_func(0x42dc, 0x51)) return;         /* jmp 0x42dc */
        }
    }
}
