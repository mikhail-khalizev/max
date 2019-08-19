using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_dad6-2317839a")]
        public void Method_0017_dad6()
        {
            ii(0x17_dad6, 1); pushw(bp);                                /* push bp */
            ii(0x17_dad7, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_dad9, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x17_dadb, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x17_dadd, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x17_dadf, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_dae1, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x17_dae4, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_dae6, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x17_dae9, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x17_daeb, 3); lea(si, di - 0x1);                        /* lea si, [di-0x1] */
            ii(0x17_daee, 3); mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x17_daf1, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x17_daf4, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x17_daf6, 2); not(cx);                                  /* not cx */
            ii(0x17_daf8, 2); sub(di, cx);                              /* sub di, cx */
            ii(0x17_dafa, 2); xchg(si, di);                             /* xchg si, di */
            ii(0x17_dafc, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_daff, 4); test(si, 0x1);                            /* test si, 0x1 */
            ii(0x17_db03, 2); if(jzw(0x17_db07, 0x2)) goto l_0x17_db07; /* jz 0xdb07 */
            ii(0x17_db05, 1); movsb_a16();                              /* movsb */
            ii(0x17_db06, 1); dec(cx);                                  /* dec cx */
        l_0x17_db07:
            ii(0x17_db07, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x17_db09, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x17_db0b, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x17_db0d, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x17_db0f, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x17_db11, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_db13, 1); popw(bp);                                 /* pop bp */
            ii(0x17_db14, 1); retfw(); return;                          /* retf */
        }
    }
}
