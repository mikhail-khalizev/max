using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_394a-4ec0c4e2")]
        public void Method_0019_394a()
        {
            ii(0x19_394a, 1); push(bp);                                 /* push bp */
            ii(0x19_394b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_394d, 1); push(di);                                 /* push di */
            ii(0x19_394e, 1); push(si);                                 /* push si */
            ii(0x19_394f, 1); push(ds);                                 /* push ds */
            ii(0x19_3950, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x19_3953, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x19_3956, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x19_3958, 3); mov(cx, memw[ss, bp + 0xe]);              /* mov cx, [bp+0xe] */
            ii(0x19_395b, 2); if(jcxz(0x19_3969, 0xc)) goto l_0x19_3969; /* jcxz 0x3969 */
        l_0x19_395d:
            ii(0x19_395d, 1); lodsb();                                  /* lodsb */
            ii(0x19_395e, 2); or(al, al);                               /* or al, al */
            ii(0x19_3960, 2); if(jz(0x19_3965, 0x3)) goto l_0x19_3965;  /* jz 0x3965 */
            ii(0x19_3962, 1); stosb();                                  /* stosb */
            ii(0x19_3963, 2); if(loop(0x19_395d, -0x8)) goto l_0x19_395d; /* loop 0x395d */
        l_0x19_3965:
            ii(0x19_3965, 2); xor(al, al);                              /* xor al, al */
            ii(0x19_3967, 2); rep(() => stosb());                       /* rep stosb */
        l_0x19_3969:
            ii(0x19_3969, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_396b, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_396d, 1); pop(ds);                                  /* pop ds */
            ii(0x19_396e, 1); pop(si);                                  /* pop si */
            ii(0x19_396f, 1); pop(di);                                  /* pop di */
            ii(0x19_3970, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_3972, 1); pop(bp);                                  /* pop bp */
            ii(0x19_3973, 1); retf();                                   /* retf */
        }
    }
}
