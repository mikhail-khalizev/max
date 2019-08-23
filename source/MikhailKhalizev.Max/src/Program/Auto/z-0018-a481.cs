using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a481-7cbbc5c7")]
        public void Method_0018_a481()
        {
            ii(0x18_a481, 3); push(memw[ss, bp + 0x14]);                /* push word [bp+0x14] */
            ii(0x18_a484, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_a486, 3); mov(al, memb[ss, bp + 0x16]);             /* mov al, [bp+0x16] */
            ii(0x18_a489, 1); push(ax);                                 /* push ax */
            ii(0x18_a48a, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x18_a48d, 3); call(0x18_d23d, 0x2dad);                  /* call 0xd23d */
            ii(0x18_a490, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_a493, 3); mov(memw[ss, bp + 0x6], ax);              /* mov [bp+0x6], ax */
            ii(0x18_a496, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_a498, 2); if(jz(0x18_a49e, 0x4)) goto l_0x18_a49e;  /* jz 0xa49e */
            ii(0x18_a49a, 4); and(memb[ss, bp + 0x26], -0x2 /* 0xfe */); /* and byte [bp+0x26], 0xfe */
        l_0x18_a49e:
            ii(0x18_a49e, 3); if(jmp_func(0x18_a3fa, -0xa7)) return;    /* jmp 0xa3fa */
        }
    }
}
