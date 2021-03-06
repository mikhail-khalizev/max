using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x839e-47100b14")]
        public void Method_0000_839e()
        {
            ii(0x839e, 1);  push(bp);                                  /* push bp */
            ii(0x839f, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x83a1, 2);  mov(dx, di);                               /* mov dx, di */
            ii(0x83a3, 2);  mov(bx, si);                               /* mov bx, si */
            ii(0x83a5, 3);  mov(si, memw[ss, bp + 6]);                 /* mov si, [bp+0x6] */
            ii(0x83a8, 2);  mov(di, si);                               /* mov di, si */
            ii(0x83aa, 2);  mov(ax, ds);                               /* mov ax, ds */
            ii(0x83ac, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0x83ae, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x83b0, 3);  mov(cx, 0xffff);                           /* mov cx, 0xffff */
            ii(0x83b3, 2);  repne(() => scasb());                      /* repne scasb */
            ii(0x83b5, 2);  not(cx);                                   /* not cx */
            ii(0x83b7, 3);  mov(di, memw[ss, bp + 4]);                 /* mov di, [bp+0x4] */
            ii(0x83ba, 2);  mov(ax, di);                               /* mov ax, di */
            ii(0x83bc, 2);  test(al, 1);                               /* test al, 0x1 */
            ii(0x83be, 2);  if(jz(0x83c2, 2)) goto l_0x83c2;           /* jz 0x83c2 */
            ii(0x83c0, 1);  movsb();                                   /* movsb */
            ii(0x83c1, 1);  dec(cx);                                   /* dec cx */
        l_0x83c2:
            ii(0x83c2, 2);  shr(cx, 1);                                /* shr cx, 1 */
            ii(0x83c4, 2);  rep(() => movsw());                        /* rep movsw */
            ii(0x83c6, 2);  adc(cx, cx);                               /* adc cx, cx */
            ii(0x83c8, 2);  rep(() => movsb());                        /* rep movsb */
            ii(0x83ca, 2);  mov(si, bx);                               /* mov si, bx */
            ii(0x83cc, 2);  mov(di, dx);                               /* mov di, dx */
            ii(0x83ce, 1);  pop(bp);                                   /* pop bp */
            ii(0x83cf, 1);  ret();                                     /* ret */
        }
    }
}
