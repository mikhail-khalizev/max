using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c0a8e91-7758-48c4-9aef-471b151e5df9")]
        public void Method_0015_351a()
        {
            ii(0x15_351a, 1); pushw(bp);                                /* push bp */
            ii(0x15_351b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_351d, 3); mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0x15_3520, 2); if(jcxzw(0x15_355a, 0x38)) goto l_0x15_355a; /* jcxz 0x355a */
            ii(0x15_3522, 1); pushw(di);                                /* push di */
            ii(0x15_3523, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x15_3526, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x15_3528, 2); neg(dx);                                  /* neg dx */
            ii(0x15_352a, 2); if(jzw(0x15_3538, 0xc)) goto l_0x15_3538; /* jz 0x3538 */
            ii(0x15_352c, 2); sub(dx, cx);                              /* sub dx, cx */
            ii(0x15_352e, 2); sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x15_3530, 2); and(dx, bx);                              /* and dx, bx */
            ii(0x15_3532, 2); add(dx, cx);                              /* add dx, cx */
            ii(0x15_3534, 2); xchg(cx, dx);                             /* xchg cx, dx */
            ii(0x15_3536, 2); sub(dx, cx);                              /* sub dx, cx */
        l_0x15_3538:
            ii(0x15_3538, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_353b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x15_353d, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x15_353f, 2); rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x15_3541, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x15_3543, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x15_3545, 2); xchg(cx, dx);                             /* xchg cx, dx */
            ii(0x15_3547, 2); if(jcxzw(0x15_3559, 0x10)) goto l_0x15_3559; /* jcxz 0x3559 */
            ii(0x15_3549, 2); mov(bx, es);                              /* mov bx, es */
            ii(0x15_354b, 4); add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x15_354f, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x15_3551, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x15_3553, 2); rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x15_3555, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x15_3557, 2); rep_a16(() => stosb_a16());               /* rep stosb */
        l_0x15_3559:
            ii(0x15_3559, 1); popw(di);                                 /* pop di */
        l_0x15_355a:
            ii(0x15_355a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_355d, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x15_3560, 1); popw(bp);                                 /* pop bp */
            ii(0x15_3561, 1); retfw(); return;                          /* retf */
        }
    }
}
