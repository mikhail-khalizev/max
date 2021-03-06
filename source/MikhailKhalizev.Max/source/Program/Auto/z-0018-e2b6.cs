using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e2b6-ad72e4db")]
        public void Method_0018_e2b6()
        {
            ii(0x18_e2b6, 2);  mov(ax, cx);                            /* mov ax, cx */
            ii(0x18_e2b8, 2);  test(al, 0x80);                         /* test al, 0x80 */
            ii(0x18_e2ba, 2);  if(jnz(0x18_e2bf, 3)) goto l_0x18_e2bf; /* jnz 0xe2bf */
            ii(0x18_e2bc, 3);  and(ax, 0x10);                          /* and ax, 0x10 */
        l_0x18_e2bf:
            ii(0x18_e2bf, 3);  and(ax, 0x2f10);                        /* and ax, 0x2f10 */
            ii(0x18_e2c2, 3);  cmp(ax, 0x10);                          /* cmp ax, 0x10 */
            ii(0x18_e2c5, 2);  if(jnz_func(0x18_e2b3, -0x14)) return;  /* jnz 0xe2b3 */
            ii(0x18_e2c7, 1);  push(cx);                               /* push cx */
            ii(0x18_e2c8, 3);  call(0x18_e070, -0x25b);                /* call 0xe070 */
            ii(0x18_e2cb, 1);  pop(cx);                                /* pop cx */
            ii(0x18_e2cc, 2);  if(jb_func(0x18_e2b3, -0x1b)) return;   /* jb 0xe2b3 */
            ii(0x18_e2ce, 3);  mov(ax, memw[ds, bx + 5]);              /* mov ax, [bx+0x5] */
            ii(0x18_e2d1, 3);  and(ax, 0xf00);                         /* and ax, 0xf00 */
            ii(0x18_e2d4, 3);  and(ch, 0xf0);                          /* and ch, 0xf0 */
            ii(0x18_e2d7, 2);  or(ax, cx);                             /* or ax, cx */
            ii(0x18_e2d9, 3);  mov(memw[ds, bx + 5], ax);              /* mov [bx+0x5], ax */
            ii(0x18_e2dc, 3);  jmp_func(0x18_e067, -0x278);            /* jmp 0xe067 */
        }
    }
}
