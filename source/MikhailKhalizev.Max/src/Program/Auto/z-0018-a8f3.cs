using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce0673d3-8422-4027-98c5-a26495b8d813")]
        public void Method_0018_a8f3()
        {
            ii(0x18_a8f3, 3); callw(0x18_ab18, 0x222);                  /* call 0xab18 */
            ii(0x18_a8f6, 2); if(jbw(0x18_a912, 0x1a)) goto l_0x18_a912; /* jb 0xa912 */
            ii(0x18_a8f8, 3); mov(si, memw_a16[ss, bp + 0x12]);         /* mov si, [bp+0x12] */
            ii(0x18_a8fb, 4); mov(di, memw_a16[ds, 0xa]);               /* mov di, [0xa] */
            ii(0x18_a8ff, 3); mov(memw_a16[ds, bx + 0x12], di);         /* mov [bx+0x12], di */
            ii(0x18_a902, 4); mov(cx, memw_a16[ds, 0xe]);               /* mov cx, [0xe] */
            ii(0x18_a906, 1); pushw(ds);                                /* push ds */
            ii(0x18_a907, 3); mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
        l_0x18_a90a:
            ii(0x18_a90a, 1); lodsb_a16();                              /* lodsb */
            ii(0x18_a90b, 1); stosb_a16();                              /* stosb */
            ii(0x18_a90c, 2); or(al, al);                               /* or al, al */
            ii(0x18_a90e, 2); if(loopnew_a16(0x18_a90a, -0x6)) goto l_0x18_a90a; /* loopne 0xa90a */
            ii(0x18_a910, 1); popw(ds);                                 /* pop ds */
            ii(0x18_a911, 1); clc();                                    /* clc */
        l_0x18_a912:
            ii(0x18_a912, 1); retw(); return;                           /* ret */
        }
    }
}
