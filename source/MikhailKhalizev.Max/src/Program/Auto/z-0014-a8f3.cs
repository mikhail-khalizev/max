using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e9b3e7c4-711e-4809-97df-76c7c6815c96")]
        public void Method_0014_a8f3()
        {
            ii(0x14_a8f3, 3); callw(0x14_ab18, 0x222);                  /* call 0xab18 */
            ii(0x14_a8f6, 2); if(jbw(0x14_a912, 0x1a)) goto l_0x14_a912; /* jb 0xa912 */
            ii(0x14_a8f8, 3); mov(si, memw_a16[ss, bp + 0x12]);         /* mov si, [bp+0x12] */
            ii(0x14_a8fb, 4); mov(di, memw_a16[ds, 0xa]);               /* mov di, [0xa] */
            ii(0x14_a8ff, 3); mov(memw_a16[ds, bx + 0x12], di);         /* mov [bx+0x12], di */
            ii(0x14_a902, 4); mov(cx, memw_a16[ds, 0xe]);               /* mov cx, [0xe] */
            ii(0x14_a906, 1); pushw(ds);                                /* push ds */
            ii(0x14_a907, 3); mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
        l_0x14_a90a:
            ii(0x14_a90a, 1); lodsb_a16();                              /* lodsb */
            ii(0x14_a90b, 1); stosb_a16();                              /* stosb */
            ii(0x14_a90c, 2); or(al, al);                               /* or al, al */
            ii(0x14_a90e, 2); if(loopnew_a16(0x14_a90a, -0x6)) goto l_0x14_a90a; /* loopne 0xa90a */
            ii(0x14_a910, 1); popw(ds);                                 /* pop ds */
            ii(0x14_a911, 1); clc();                                    /* clc */
        l_0x14_a912:
            ii(0x14_a912, 1); retw(); return;                           /* ret */
        }
    }
}
