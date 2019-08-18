using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fb3bab02-9389-405a-ac59-aaab58bb3a47")]
        public void Method_0000_4f8d()
        {
            ii(0x4f8d, 1);    pushw(bp);                                /* push bp */
            ii(0x4f8e, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4f90, 1);    pushw(si);                                /* push si */
            ii(0x4f91, 1);    pushw(di);                                /* push di */
            ii(0x4f92, 3);    callw(0x4030, -0xf65);                    /* call 0x4030 */
            ii(0x4f95, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x4f97, 1);    popw(ds);                                 /* pop ds */
            ii(0x4f98, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x4f9b, 3);    mov(memw_a16[ds, 0x62], ax);              /* mov [0x62], ax */
            ii(0x4f9e, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x4fa1, 3);    mov(memb_a16[ds, 0x64], al);              /* mov [0x64], al */
            ii(0x4fa4, 4);    mov(memb_a16[ds, 0x67], ah);              /* mov [0x67], ah */
            ii(0x4fa8, 3);    mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x4fab, 2);    pushw(0x60);                              /* push 0x60 */
            ii(0x4fad, 1);    popw(ds);                                 /* pop ds */
            ii(0x4fae, 2);    xor(si, si);                              /* xor si, si */
            ii(0x4fb0, 3);    mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x4fb3, 1);    cld();                                    /* cld */
            ii(0x4fb4, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x4fb6, 1);    pushw(ss);                                /* push ss */
            ii(0x4fb7, 1);    popw(ds);                                 /* pop ds */
            ii(0x4fb8, 3);    callw(0x46c9, -0x8f2);                    /* call 0x46c9 */
            ii(0x4fbb, 1);    popw(di);                                 /* pop di */
            ii(0x4fbc, 1);    popw(si);                                 /* pop si */
            ii(0x4fbd, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4fbf, 1);    popw(bp);                                 /* pop bp */
            ii(0x4fc0, 1);    sti();                                    /* sti */
            ii(0x4fc1, 1);    retw(); return;                           /* ret */
        }
    }
}
