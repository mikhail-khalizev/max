using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e12c-364fffdc")]
        public void Method_0017_e12c()
        {
            ii(0x17_e12c, 1); pushw(bp);                                /* push bp */
            ii(0x17_e12d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_e12f, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x17_e131, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x17_e133, 1); pushw(ds);                                /* push ds */
            ii(0x17_e134, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x17_e137, 2); mov(di, si);                              /* mov di, si */
            ii(0x17_e139, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x17_e13b, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_e13d, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_e13f, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x17_e142, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x17_e144, 2); not(cx);                                  /* not cx */
            ii(0x17_e146, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x17_e149, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x17_e14b, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x17_e14d, 2); if(jzw(0x17_e151, 0x2)) goto l_0x17_e151; /* jz 0xe151 */
            ii(0x17_e14f, 1); movsb_a16();                              /* movsb */
            ii(0x17_e150, 1); dec(cx);                                  /* dec cx */
        l_0x17_e151:
            ii(0x17_e151, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x17_e153, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x17_e155, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x17_e157, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x17_e159, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x17_e15b, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_e15d, 1); popw(ds);                                 /* pop ds */
            ii(0x17_e15e, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x17_e160, 1); popw(bp);                                 /* pop bp */
            ii(0x17_e161, 1); retfw();                                  /* retf */
        }
    }
}
