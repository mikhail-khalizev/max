using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_351a-40aa05b1")]
        public void Method_0019_351a()
        {
            ii(0x19_351a, 1); push(bp);                                 /* push bp */
            ii(0x19_351b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_351d, 3); mov(cx, memw[ss, bp + 0xc]);              /* mov cx, [bp+0xc] */
            ii(0x19_3520, 2); if(jcxz(0x19_355a, 0x38)) goto l_0x19_355a; /* jcxz 0x355a */
            ii(0x19_3522, 1); push(di);                                 /* push di */
            ii(0x19_3523, 3); les(di, memw[ss, bp + 6]);                /* les di, [bp+0x6] */
            ii(0x19_3526, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x19_3528, 2); neg(dx);                                  /* neg dx */
            ii(0x19_352a, 2); if(jz(0x19_3538, 0xc)) goto l_0x19_3538;  /* jz 0x3538 */
            ii(0x19_352c, 2); sub(dx, cx);                              /* sub dx, cx */
            ii(0x19_352e, 2); sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x19_3530, 2); and(dx, bx);                              /* and dx, bx */
            ii(0x19_3532, 2); add(dx, cx);                              /* add dx, cx */
            ii(0x19_3534, 2); xchg(cx, dx);                             /* xchg cx, dx */
            ii(0x19_3536, 2); sub(dx, cx);                              /* sub dx, cx */
        l_0x19_3538:
            ii(0x19_3538, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x19_353b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x19_353d, 2); shr(cx, 1);                               /* shr cx, 1 */
            ii(0x19_353f, 2); rep(() => stosw());                       /* rep stosw */
            ii(0x19_3541, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x19_3543, 2); rep(() => stosb());                       /* rep stosb */
            ii(0x19_3545, 2); xchg(cx, dx);                             /* xchg cx, dx */
            ii(0x19_3547, 2); if(jcxz(0x19_3559, 0x10)) goto l_0x19_3559; /* jcxz 0x3559 */
            ii(0x19_3549, 2); mov(bx, es);                              /* mov bx, es */
            ii(0x19_354b, 4); add(bx, 8);                               /* add bx, 0x8 */
            ii(0x19_354f, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x19_3551, 2); shr(cx, 1);                               /* shr cx, 1 */
            ii(0x19_3553, 2); rep(() => stosw());                       /* rep stosw */
            ii(0x19_3555, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x19_3557, 2); rep(() => stosb());                       /* rep stosb */
        l_0x19_3559:
            ii(0x19_3559, 1); pop(di);                                  /* pop di */
        l_0x19_355a:
            ii(0x19_355a, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x19_355d, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x19_3560, 1); pop(bp);                                  /* pop bp */
            ii(0x19_3561, 1); retf();                                   /* retf */
        }
    }
}
