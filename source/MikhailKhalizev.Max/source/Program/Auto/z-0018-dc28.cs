using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dc28-7e96ceaa")]
        public void Method_0018_dc28()
        {
            ii(0x18_dc28, 2);  mov(bx, sp);                            /* mov bx, sp */
            ii(0x18_dc2a, 1);  push(bp);                               /* push bp */
            ii(0x18_dc2b, 2);  push(edi);                              /* push edi */
            ii(0x18_dc2d, 4);  mov(bp, memw[ss, bx + 4]);              /* mov bp, [ss:bx+0x4] */
            ii(0x18_dc31, 4);  mov(bx, memw[ss, bx + 2]);              /* mov bx, [ss:bx+0x2] */
            ii(0x18_dc35, 5);  cmp(memb[ds, 0x2e], 0);                 /* cmp byte [0x2e], 0x0 */
            ii(0x18_dc3a, 2);  if(jz(0x18_dc50, 0x14)) goto l_0x18_dc50;/* jz 0xdc50 */
            ii(0x18_dc3c, 3);  and(bl, 0xf8);                          /* and bl, 0xf8 */
            ii(0x18_dc3f, 2);  mov(di, bx);                            /* mov di, bx */
            ii(0x18_dc41, 2);  push(8);                                /* push 0x8 */
            ii(0x18_dc43, 1);  pop(es);                                /* pop es */
            ii(0x18_dc44, 3);  call(0x18_dc06, -0x41);                 /* call 0xdc06 */
            ii(0x18_dc47, 2);  pop(edi);                               /* pop edi */
            ii(0x18_dc49, 1);  pop(bp);                                /* pop bp */
            ii(0x18_dc4a, 1);  pop(ax);                                /* pop ax */
            ii(0x18_dc4b, 1);  push(ss);                               /* push ss */
            ii(0x18_dc4c, 1);  pop(ss);                                /* pop ss */
            ii(0x18_dc4d, 1);  sti();                                  /* sti */
            ii(0x18_dc4e, 2);  if(jmp_abs(ax)) return;                 /* jmp ax */
        l_0x18_dc50:
            ii(0x18_dc50, 1);  push(ds);                               /* push ds */
            ii(0x18_dc51, 1);  pop(es);                                /* pop es */
            ii(0x18_dc52, 3);  xor(edi, edi);                          /* xor edi, edi */
            ii(0x18_dc55, 3);  mov(di, 0x8c0);                         /* mov di, 0x8c0 */
            ii(0x18_dc58, 1);  push(di);                               /* push di */
            ii(0x18_dc59, 3);  call(0x18_dc06, -0x56);                 /* call 0xdc06 */
            ii(0x18_dc5c, 1);  pop(di);                                /* pop di */
            ii(0x18_dc5d, 2);  mov(cx, ds);                            /* mov cx, ds */
            ii(0x18_dc5f, 4);  test(memb[ss, bp + 8], 8);              /* test byte [bp+0x8], 0x8 */
            ii(0x18_dc63, 2);  if(jz(0x18_dc67, 2)) goto l_0x18_dc67;  /* jz 0xdc67 */
            ii(0x18_dc65, 2);  mov(cx, cs);                            /* mov cx, cs */
        l_0x18_dc67:
            ii(0x18_dc67, 3);  lar(ax, cx);                            /* lar ax, cx */
            ii(0x18_dc6a, 3);  and(ah, 0xfe);                          /* and ah, 0xfe */
            ii(0x18_dc6d, 4);  mov(memb[es, di + 5], ah);              /* mov [es:di+0x5], ah */
            ii(0x18_dc71, 2);  pop(edx);                               /* pop edx */
            ii(0x18_dc73, 1);  pop(bp);                                /* pop bp */
            ii(0x18_dc74, 1);  pop(cx);                                /* pop cx */
            ii(0x18_dc75, 3);  mov(ax, 0xc);                           /* mov ax, 0xc */
            ii(0x18_dc78, 1);  push(cs);                               /* push cs */
            ii(0x18_dc79, 3);  call(0x18_a3b9, -0x38c3);               /* call 0xa3b9 */
            ii(0x18_dc7c, 1);  push(ss);                               /* push ss */
            ii(0x18_dc7d, 1);  pop(ss);                                /* pop ss */
            ii(0x18_dc7e, 3);  mov(edi, edx);                          /* mov edi, edx */
            ii(0x18_dc81, 1);  cmc();                                  /* cmc */
            ii(0x18_dc82, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x18_dc85, 2);  rcl(ax, 1);                             /* rcl ax, 1 */
            ii(0x18_dc87, 1);  sti();                                  /* sti */
            ii(0x18_dc88, 2);  jmp_abs(cx);                            /* jmp cx */
        }
    }
}
