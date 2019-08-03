using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fcc44976-161b-499f-a663-f0d77fecd13c")]
        public void Method_0014_a481()
        {
            ii(0x14_a481, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x14_a484, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x14_a486, 3); mov(al, memb_a16[ss, bp + 0x16]);         /* mov al, [bp+0x16] */
            ii(0x14_a489, 1); pushw(ax);                                /* push ax */
            ii(0x14_a48a, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x14_a48d, 3); callw(0x14_d23d, 0x2dad);                 /* call 0xd23d */
            ii(0x14_a490, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_a493, 3); mov(memw_a16[ss, bp + 0x6], ax);          /* mov [bp+0x6], ax */
            ii(0x14_a496, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_a498, 2); jzw_func(0x14_a49e, 0x4);                 /* jz 0xa49e */
            ii(0x14_a49a, 4); and(memb_a16[ss, bp + 0x26], -0x2 /* 0xfe */); /* and byte [bp+0x26], 0xfe */
        }
    }
}
