using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a578-3d016c17")]
        public void Method_0018_a578()
        {
            ii(0x18_a578, 3);  mov(bx, memw[ss, bp + 16]);             /* mov bx, [bp+0x10] */
            ii(0x18_a57b, 3);  mov(cx, memw[ss, bp + 20]);             /* mov cx, [bp+0x14] */
            ii(0x18_a57e, 1);  push(ss);                               /* push ss */
            ii(0x18_a57f, 1);  pop(es);                                /* pop es */
            ii(0x18_a580, 3);  mov(si, memw[ss, bp + 34]);             /* mov si, [bp+0x22] */
            ii(0x18_a583, 4);  cmp(memb[ss, bp + 22], 0);              /* cmp byte [bp+0x16], 0x0 */
            ii(0x18_a587, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x18_a58a, 3);  mov(ss, memw[ss, bp + 10]);             /* mov ss, [bp+0xa] */
            ii(0x18_a58d, 1);  xchg(sp, ax);                           /* xchg sp, ax */
            ii(0x18_a58e, 1);  push(bx);                               /* push bx */
            ii(0x18_a58f, 1);  push(cx);                               /* push cx */
            ii(0x18_a590, 2);  if(jnz(0x18_a5a0, 0xe)) goto l_0x18_a5a0;/* jnz 0xa5a0 */
            ii(0x18_a592, 2);  mov(ah, 0x49);                          /* mov ah, 0x49 */
            ii(0x18_a594, 1);  push(cs);                               /* push cs */
            ii(0x18_a595, 3);  call(0x18_a366, -0x232);                /* call 0xa366 */
            ii(0x18_a598, 2);  mov(es, si);                            /* mov es, si */
            ii(0x18_a59a, 2);  mov(ah, 0x49);                          /* mov ah, 0x49 */
            ii(0x18_a59c, 1);  push(cs);                               /* push cs */
            ii(0x18_a59d, 3);  call(0x18_a366, -0x23a);                /* call 0xa366 */
        l_0x18_a5a0:
            ii(0x18_a5a0, 1);  sti();                                  /* sti */
            ii(0x18_a5a1, 3);  mov(ax, memw[ds, 0xc2a]);               /* mov ax, [0xc2a] */
            ii(0x18_a5a4, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x18_a5a6, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x18_a5a8, 1);  retf();                                 /* retf */
        }
    }
}
