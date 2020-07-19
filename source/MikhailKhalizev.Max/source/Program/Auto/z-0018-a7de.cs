using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a7de-5f28ab9f")]
        public void Method_0018_a7de()
        {
            ii(0x18_a7de, 1);  cli();                                  /* cli */
            ii(0x18_a7df, 1);  push(di);                               /* push di */
            ii(0x18_a7e0, 4);  sub(di, 0x180);                         /* sub di, 0x180 */
            ii(0x18_a7e4, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x18_a7e6, 2);  mov(si, sp);                            /* mov si, sp */
            ii(0x18_a7e8, 1);  push(cx);                               /* push cx */
            ii(0x18_a7e9, 5);  push(memw[es, 0xf52]);                  /* push word [es:0xf52] */
            ii(0x18_a7ee, 2);  mov(bx, di);                            /* mov bx, di */
            ii(0x18_a7f0, 1);  cld();                                  /* cld */
            ii(0x18_a7f1, 3);  mov(cx, 0xc);                           /* mov cx, 0xc */
            ii(0x18_a7f4, 2);  rep(() => movsw());                     /* rep movsw */
            ii(0x18_a7f6, 2);  mov(ds, dx);                            /* mov ds, dx */
            ii(0x18_a7f8, 4);  mov(memw[ds, 0x99e], bx);               /* mov [0x99e], bx */
            ii(0x18_a7fc, 4);  mov(memw[ds, 0x996], bx);               /* mov [0x996], bx */
            ii(0x18_a800, 3);  mov(memw[ds, bx + 34], ss);             /* mov [bx+0x22], ss */
            ii(0x18_a803, 3);  mov(memw[ds, bx + 38], bp);             /* mov [bx+0x26], bp */
            ii(0x18_a806, 2);  inc(ah);                                /* inc ah */
            ii(0x18_a808, 3);  cmp(ah, 0x68);                          /* cmp ah, 0x68 */
            ii(0x18_a80b, 2);  if(ja(0x18_a81c, 0xf)) goto l_0x18_a81c;/* ja 0xa81c */
            ii(0x18_a80d, 2);  xor(al, al);                            /* xor al, al */
            ii(0x18_a80f, 2);  xchg(ah, al);                           /* xchg ah, al */
            ii(0x18_a811, 3);  mov(memw[ds, 0x97e], ax);               /* mov [0x97e], ax */
            ii(0x18_a814, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x18_a816, 1);  xchg(di, ax);                           /* xchg di, ax */
            ii(0x18_a817, 5);  if(jmp_abs(memw[cs, di + 1642])) return;/* jmp word [cs:di+0x66a] */
        l_0x18_a81c:
            ii(0x18_a81c, 3);  call(0x18_a893, 0x74);                  /* call 0xa893 */
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
