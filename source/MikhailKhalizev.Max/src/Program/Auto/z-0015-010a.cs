using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("56f49fe8-46d2-4d58-9925-ded4f1bdc761")]
        public void Method_0015_010a()
        {
            ii(0x15_010a, 4); movzx(eax, ax);                           /* movzx eax, ax */
            ii(0x15_010e, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x15_0110, 1); pushw(ds);                                /* push ds */
            ii(0x15_0111, 1); popw(ss);                                 /* pop ss */
            ii(0x15_0112, 3); lea(sp, bp - 0x6);                        /* lea sp, [bp-0x6] */
            ii(0x15_0115, 3); test(eax, eax);                           /* test eax, eax */
            ii(0x15_0118, 2); if(jzw_func(0x15_0120, 0x6)) return;      /* jz 0x120 */
            ii(0x15_011a, 3); mov(edi, eax);                            /* mov edi, eax */
            ii(0x15_011d, 3); if(jmpw_func(0x15_0088, -0x98)) return;   /* jmp 0x88 */
        }
    }
}
