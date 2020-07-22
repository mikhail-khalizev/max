using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fae5-6d8760d5")]
        public void Method_0019_fae5()
        {
            ii(0x19_fae5, 1);  push(bp);                               /* push bp */
            ii(0x19_fae6, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_fae8, 1);  push(di);                               /* push di */
            ii(0x19_fae9, 1);  push(si);                               /* push si */
            ii(0x19_faea, 1);  push(ds);                               /* push ds */
            ii(0x19_faeb, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_faee, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_faf0, 2);  sub(si, si);                            /* sub si, si */
            ii(0x19_faf2, 2);  push(3);                                /* push 0x3 */
            ii(0x19_faf4, 5);  call_far_abs(0x80, 0x51ba);             /* call word 0x80:0x51ba */
            ii(0x19_faf9, 1);  pop(bx);                                /* pop bx */
            ii(0x19_fafa, 2);  mov(di, ax);                            /* mov di, ax */
            ii(0x19_fafc, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_faff, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_fb02, 5);  call_far_abs(0x80, 0x535a);             /* call word 0x80:0x535a */
            ii(0x19_fb07, 1);  pop(bx);                                /* pop bx */
            ii(0x19_fb08, 1);  pop(bx);                                /* pop bx */
            ii(0x19_fb09, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_fb0b, 2);  if(jz(0x19_fb10, 3)) goto l_0x19_fb10;  /* jz 0xfb10 */
            ii(0x19_fb0d, 3);  mov(si, 1);                             /* mov si, 0x1 */
        l_0x19_fb10:
            ii(0x19_fb10, 1);  push(di);                               /* push di */
            ii(0x19_fb11, 5);  call_far_abs(0x80, 0x51ba);             /* call word 0x80:0x51ba */
            ii(0x19_fb16, 1);  pop(bx);                                /* pop bx */
            ii(0x19_fb17, 2);  mov(ax, si);                            /* mov ax, si */
            ii(0x19_fb19, 1);  pop(ds);                                /* pop ds */
            ii(0x19_fb1a, 1);  pop(si);                                /* pop si */
            ii(0x19_fb1b, 1);  pop(di);                                /* pop di */
            ii(0x19_fb1c, 1);  leave();                                /* leave */
            ii(0x19_fb1d, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
