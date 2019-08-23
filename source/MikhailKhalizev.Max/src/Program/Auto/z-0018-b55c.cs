using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b55c-6a25a4e4")]
        public void Method_0018_b55c()
        {
            ii(0x18_b55c, 1); pushw(ax);                                /* push ax */
            ii(0x18_b55d, 3); mov(ax, memw_a16[ds, 0xe]);               /* mov ax, [0xe] */
            ii(0x18_b560, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x18_b562, 2); if(jbew(0x18_b566, 0x2)) goto l_0x18_b566; /* jbe 0xb566 */
            ii(0x18_b564, 2); mov(cx, ax);                              /* mov cx, ax */
        l_0x18_b566:
            ii(0x18_b566, 1); popw(ax);                                 /* pop ax */
            ii(0x18_b567, 1); pushw(ds);                                /* push ds */
            ii(0x18_b568, 1); pushw(es);                                /* push es */
            ii(0x18_b569, 4); mov(di, memw_a16[ds, 0xa]);               /* mov di, [0xa] */
            ii(0x18_b56d, 1); pushw(ds);                                /* push ds */
            ii(0x18_b56e, 1); popw(es);                                 /* pop es */
            ii(0x18_b56f, 1); popw(ds);                                 /* pop ds */
            ii(0x18_b570, 1); pusha();                                  /* pusha */
            ii(0x18_b571, 1); cld();                                    /* cld */
            ii(0x18_b572, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x18_b574, 1); popa();                                   /* popa */
            ii(0x18_b575, 1); popw(ds);                                 /* pop ds */
            ii(0x18_b576, 1); retw();                                   /* ret */
        }
    }
}
