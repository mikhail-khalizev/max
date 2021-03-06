using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_05e3-f54df2e6")]
        public void Method_0018_05e3()
        {
            ii(0x18_05e3, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x18_05e7, 1);  push(es);                               /* push es */
            ii(0x18_05e8, 1);  push(di);                               /* push di */
            ii(0x18_05e9, 1);  push(cx);                               /* push cx */
            ii(0x18_05ea, 1);  cld();                                  /* cld */
            ii(0x18_05eb, 3);  les(di, memw[ss, bp + 6]);              /* les di, [bp+0x6] */
            ii(0x18_05ee, 3);  mov(cx, memw[ss, bp + 10]);             /* mov cx, [bp+0xa] */
            ii(0x18_05f1, 3);  mov(ax, memw[ss, bp + 12]);             /* mov ax, [bp+0xc] */
            ii(0x18_05f4, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x18_05f6, 2);  mov(ax, cx);                            /* mov ax, cx */
            ii(0x18_05f8, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x18_05fb, 2);  sub(ax, cx);                            /* sub ax, cx */
            ii(0x18_05fd, 1);  dec(ax);                                /* dec ax */
            ii(0x18_05fe, 1);  pop(cx);                                /* pop cx */
            ii(0x18_05ff, 1);  pop(di);                                /* pop di */
            ii(0x18_0600, 1);  pop(es);                                /* pop es */
            ii(0x18_0601, 1);  leave();                                /* leave */
            ii(0x18_0602, 1);  retf();                                 /* retf */
        }
    }
}
