using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a81f-be298378")]
        public void Method_0018_a81f()
        {
            ii(0x18_a81f, 2);  mov(ax, ss);                            /* mov ax, ss */
            ii(0x18_a821, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x18_a823, 1);  cld();                                  /* cld */
            ii(0x18_a824, 3);  lea(di, memw[ss, bp + 8]);              /* lea di, [bp+0x8] */
            ii(0x18_a827, 3);  lea(si, memw[ds, bx + 8]);              /* lea si, [bx+0x8] */
            ii(0x18_a82a, 3);  mov(cx, 8);                             /* mov cx, 0x8 */
            ii(0x18_a82d, 2);  rep(() => movsw());                     /* rep movsw */
            ii(0x18_a82f, 3);  mov(ax, memw[ds, bx + 38]);             /* mov ax, [bx+0x26] */
            ii(0x18_a832, 3);  and(ah, 0xe);                           /* and ah, 0xe */
            ii(0x18_a835, 3);  mov(memw[ss, bp + 38], ax);             /* mov [bp+0x26], ax */
            ii(0x18_a838, 5);  test(memw[ss, bp + 38], 0x200);         /* test word [bp+0x26], 0x200 */
            ii(0x18_a83d, 2);  if(jz(0x18_a840, 1)) goto l_0x18_a840;  /* jz 0xa840 */
            ii(0x18_a83f, 1);  sti();                                  /* sti */
        l_0x18_a840:
            ii(0x18_a840, 3);  lea(sp, memw[ss, bp - 4]);              /* lea sp, [bp-0x4] */
            ii(0x18_a843, 4);  pop(memw[ds, 0xf52]);                   /* pop word [0xf52] */
            ii(0x18_a847, 4);  pop(memw[ds, 0x99e]);                   /* pop word [0x99e] */
            ii(0x18_a84b, 4);  pop(memw[ds, 0x996]);                   /* pop word [0x996] */
            ii(0x18_a84f, 1);  inc(sp);                                /* inc sp */
            ii(0x18_a850, 1);  inc(sp);                                /* inc sp */
            ii(0x18_a851, 1);  pop(ds);                                /* pop ds */
            ii(0x18_a852, 1);  pop(es);                                /* pop es */
            ii(0x18_a853, 1);  popa();                                 /* popa */
            ii(0x18_a854, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x18_a857, 2);  iretd();                                /* iretd */
        }
    }
}