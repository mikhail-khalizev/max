using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b5dc-9aa47ed1")]
        public void Method_0018_b5dc()
        {
            ii(0x18_b5dc, 2); cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0x18_b5de, 2); if(jzw(0x18_b5e2, 0x2)) goto l_0x18_b5e2; /* jz 0xb5e2 */
            ii(0x18_b5e0, 2); if(jmpw_func(0x18_b5b2, -0x30)) return;   /* jmp 0xb5b2 */
        l_0x18_b5e2:
            ii(0x18_b5e2, 1); pusha();                                  /* pusha */
            ii(0x18_b5e3, 1); pushw(es);                                /* push es */
            ii(0x18_b5e4, 1); pushw(ds);                                /* push ds */
            ii(0x18_b5e5, 5); mov(ds, memw_a16[cs, 0x5680]);            /* mov ds, [cs:0x5680] */
            ii(0x18_b5ea, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x18_b5ec, 3); mov(cx, 0x11);                            /* mov cx, 0x11 */
            ii(0x18_b5ef, 3); callw(0x18_b55c, -0x96);                  /* call 0xb55c */
            ii(0x18_b5f2, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x18_b5f4, 3); callw(0x18_b58c, -0x6b);                  /* call 0xb58c */
            ii(0x18_b5f7, 1); popw(ds);                                 /* pop ds */
            ii(0x18_b5f8, 1); popw(es);                                 /* pop es */
            ii(0x18_b5f9, 1); popa();                                   /* popa */
            ii(0x18_b5fa, 2); iretd(); return;                          /* iretd */
        }
    }
}
