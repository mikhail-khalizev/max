using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa4a1-40bab9bb")]
        public void Method_0000_a4a1()
        {
            ii(0xa4a1, 1);  push(bp);                                  /* push bp */
            ii(0xa4a2, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0xa4a4, 1);  push(di);                                  /* push di */
            ii(0xa4a5, 3);  mov(cx, memw[ss, bp + 8]);                 /* mov cx, [bp+0x8] */
            ii(0xa4a8, 2);  if(jcxz(0xa4e6, 0x3c)) goto l_0xa4e6;      /* jcxz 0xa4e6 */
            ii(0xa4aa, 3);  call(0x4030, -0x647d);                     /* call 0x4030 */
            ii(0xa4ad, 2);  push(8);                                   /* push 0x8 */
            ii(0xa4af, 1);  pop(es);                                   /* pop es */
            ii(0xa4b0, 3);  mov(bx, memw[ss, bp + 4]);                 /* mov bx, [bp+0x4] */
            ii(0xa4b3, 3);  and(bl, 0xf8);                             /* and bl, 0xf8 */
            ii(0xa4b6, 4);  mov(ax, memw[es, bx + 2]);                 /* mov ax, [es:bx+0x2] */
            ii(0xa4ba, 4);  mov(memw[es, 0x62], ax);                   /* mov [es:0x62], ax */
            ii(0xa4be, 4);  mov(al, memb[es, bx + 4]);                 /* mov al, [es:bx+0x4] */
            ii(0xa4c2, 4);  mov(memb[es, 0x64], al);                   /* mov [es:0x64], al */
            ii(0xa4c6, 4);  mov(al, memb[es, bx + 7]);                 /* mov al, [es:bx+0x7] */
            ii(0xa4ca, 4);  mov(memb[es, 0x67], al);                   /* mov [es:0x67], al */
            ii(0xa4ce, 2);  push(0x60);                                /* push 0x60 */
            ii(0xa4d0, 1);  pop(es);                                   /* pop es */
            ii(0xa4d1, 3);  mov(di, memw[ss, bp + 6]);                 /* mov di, [bp+0x6] */
            ii(0xa4d4, 1);  cld();                                     /* cld */
            ii(0xa4d5, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0xa4d7, 3);  mov(cx, memw[ss, bp + 8]);                 /* mov cx, [bp+0x8] */
            ii(0xa4da, 2);  shr(cx, 1);                                /* shr cx, 1 */
            ii(0xa4dc, 2);  if(jz(0xa4e0, 2)) goto l_0xa4e0;           /* jz 0xa4e0 */
            ii(0xa4de, 2);  rep(() => stosw());                        /* rep stosw */
        l_0xa4e0:
            ii(0xa4e0, 2);  if(jae(0xa4e3, 1)) goto l_0xa4e3;          /* jae 0xa4e3 */
            ii(0xa4e2, 1);  stosb();                                   /* stosb */
        l_0xa4e3:
            ii(0xa4e3, 3);  call(0x46c9, -0x5e1d);                     /* call 0x46c9 */
        l_0xa4e6:
            ii(0xa4e6, 1);  pop(di);                                   /* pop di */
            ii(0xa4e7, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0xa4e9, 1);  pop(bp);                                   /* pop bp */
            ii(0xa4ea, 1);  sti();                                     /* sti */
            ii(0xa4eb, 1);  ret();                                     /* ret */
        }
    }
}
