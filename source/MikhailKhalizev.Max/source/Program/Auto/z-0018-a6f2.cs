using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a6f2-761b37ee")]
        public void Method_0018_a6f2()
        {
            ii(0x18_a6f2, 1);  push(ds);                               /* push ds */
            ii(0x18_a6f3, 1);  cbw();                                  /* cbw */
            ii(0x18_a6f4, 1);  push(ax);                               /* push ax */
            ii(0x18_a6f5, 3);  call(0x18_e868, 0x4170);                /* call 0xe868 */
            ii(0x18_a6f8, 1);  pop(bx);                                /* pop bx */
            ii(0x18_a6f9, 2);  add(bx, bx);                            /* add bx, bx */
            ii(0x18_a6fb, 4);  mov(bx, memw[ds, bx + 0x44b8]);         /* mov bx, [bx+0x44b8] */
            ii(0x18_a6ff, 4);  test(memb[ds, bx - 2], 1);              /* test byte [bx-0x2], 0x1 */
            ii(0x18_a703, 2);  if(jz(0x18_a71b, 0x16)) goto l_0x18_a71b;/* jz 0xa71b */
            ii(0x18_a705, 3);  mov(cx, memw[ss, bp + 16]);             /* mov cx, [bp+0x10] */
            ii(0x18_a708, 3);  mov(dx, memw[ss, bp + 20]);             /* mov dx, [bp+0x14] */
            ii(0x18_a70b, 3);  xchg(memw[ds, bx - 4], cx);             /* xchg [bx-0x4], cx */
            ii(0x18_a70e, 3);  xchg(memw[ds, bx - 6], dx);             /* xchg [bx-0x6], dx */
            ii(0x18_a711, 3);  mov(memw[ss, bp + 20], dx);             /* mov [bp+0x14], dx */
            ii(0x18_a714, 3);  mov(memw[ss, bp + 16], cx);             /* mov [bp+0x10], cx */
            ii(0x18_a717, 4);  or(memb[ds, bx - 2], -0x80 /* 0x80 */); /* or byte [bx-0x2], 0x80 */
        l_0x18_a71b:
            ii(0x18_a71b, 1);  pop(ds);                                /* pop ds */
            ii(0x18_a71c, 2);  if(jz_func(0x18_a6ef, -0x2f)) return;   /* jz 0xa6ef */
            ii(0x18_a71e, 1);  ret();                                  /* ret */
        }
    }
}
