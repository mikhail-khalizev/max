using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dacfeb84-fce0-4006-ba15-ce529b99eeee")]
        public void Method_0015_394a()
        {
            ii(0x15_394a, 1); pushw(bp);                                /* push bp */
            ii(0x15_394b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_394d, 1); pushw(di);                                /* push di */
            ii(0x15_394e, 1); pushw(si);                                /* push si */
            ii(0x15_394f, 1); pushw(ds);                                /* push ds */
            ii(0x15_3950, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x15_3953, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x15_3956, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x15_3958, 3); mov(cx, memw_a16[ss, bp + 0xe]);          /* mov cx, [bp+0xe] */
            ii(0x15_395b, 2); if(jcxzw(0x15_3969, 0xc)) goto l_0x15_3969; /* jcxz 0x3969 */
        l_0x15_395d:
            ii(0x15_395d, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_395e, 2); or(al, al);                               /* or al, al */
            ii(0x15_3960, 2); if(jzw(0x15_3965, 0x3)) goto l_0x15_3965; /* jz 0x3965 */
            ii(0x15_3962, 1); stosb_a16();                              /* stosb */
            ii(0x15_3963, 2); if(loopw_a16(0x15_395d, -0x8)) goto l_0x15_395d; /* loop 0x395d */
        l_0x15_3965:
            ii(0x15_3965, 2); xor(al, al);                              /* xor al, al */
            ii(0x15_3967, 2); rep_a16(() => stosb_a16());               /* rep stosb */
        l_0x15_3969:
            ii(0x15_3969, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x15_396b, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x15_396d, 1); popw(ds);                                 /* pop ds */
            ii(0x15_396e, 1); popw(si);                                 /* pop si */
            ii(0x15_396f, 1); popw(di);                                 /* pop di */
            ii(0x15_3970, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_3972, 1); popw(bp);                                 /* pop bp */
            ii(0x15_3973, 1); retfw(); return;                          /* retf */
        }
    }
}
