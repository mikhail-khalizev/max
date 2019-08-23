using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3a0a-6621d7f7")]
        public void Method_0019_3a0a()
        {
            ii(0x19_3a0a, 1); push(bp);                                 /* push bp */
            ii(0x19_3a0b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_3a0d, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x19_3a0f, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_3a11, 1); push(ds);                                 /* push ds */
            ii(0x19_3a12, 3); les(di, memw[ss, bp + 0x6]);              /* les di, [bp+0x6] */
            ii(0x19_3a15, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3a17, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_3a1a, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x19_3a1c, 3); lea(si, memw[ds, di - 0x1]);              /* lea si, [di-0x1] */
            ii(0x19_3a1f, 3); les(di, memw[ss, bp + 0xa]);              /* les di, [bp+0xa] */
            ii(0x19_3a22, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_3a25, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x19_3a27, 2); not(cx);                                  /* not cx */
            ii(0x19_3a29, 2); sub(di, cx);                              /* sub di, cx */
            ii(0x19_3a2b, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x19_3a2d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_3a2f, 3); mov(es, memw[ss, bp + 0x8]);              /* mov es, [bp+0x8] */
            ii(0x19_3a32, 2); xchg(si, di);                             /* xchg si, di */
            ii(0x19_3a34, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_3a37, 4); test(si, 0x1);                            /* test si, 0x1 */
            ii(0x19_3a3b, 2); if(jz(0x19_3a3f, 0x2)) goto l_0x19_3a3f;  /* jz 0x3a3f */
            ii(0x19_3a3d, 1); movsb();                                  /* movsb */
            ii(0x19_3a3e, 1); dec(cx);                                  /* dec cx */
        l_0x19_3a3f:
            ii(0x19_3a3f, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x19_3a41, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x19_3a43, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x19_3a45, 2); rep(() => movsb());                       /* rep movsb */
            ii(0x19_3a47, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x19_3a49, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x19_3a4b, 1); pop(ds);                                  /* pop ds */
            ii(0x19_3a4c, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_3a4e, 1); pop(bp);                                  /* pop bp */
            ii(0x19_3a4f, 1); retf();                                   /* retf */
        }
    }
}
