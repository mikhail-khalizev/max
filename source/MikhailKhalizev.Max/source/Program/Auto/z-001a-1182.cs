using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1182-7ebf7252")]
        public void Method_001a_1182()
        {
            ii(0x1a_1182, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x1a_1186, 1);  push(ds);                               /* push ds */
            ii(0x1a_1187, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x1a_118a, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x1a_118c, 5);  mov(memw[ss, bp - 18], 0);              /* mov word [bp-0x12], 0x0 */
            ii(0x1a_1191, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x1a_1194, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x1a_1197, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x1a_119a, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x1a_119d, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x1a_11a0, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x1a_11a3, 3);  mov(ax, memw[ss, bp + 12]);             /* mov ax, [bp+0xc] */
            ii(0x1a_11a6, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x1a_11a9, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x1a_11ac, 1);  push(ss);                               /* push ss */
            ii(0x1a_11ad, 1);  push(ax);                               /* push ax */
            ii(0x1a_11ae, 3);  push(0x3f00);                           /* push 0x3f00 */
            ii(0x1a_11b1, 5);  call_far_abs(0x80, 0x4c9f);             /* call word 0x80:0x4c9f */
            ii(0x1a_11b6, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x1a_11b9, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x1a_11bb, 2);  if(jz(0x1a_11c2, 5)) goto l_0x1a_11c2;  /* jz 0x11c2 */
            ii(0x1a_11bd, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x1a_11c0, 2);  jmp(0x1a_11c5, 3); goto l_0x1a_11c5;    /* jmp 0x11c5 */
        l_0x1a_11c2:
            ii(0x1a_11c2, 3);  mov(ax, 0xffff);                        /* mov ax, 0xffff */
        l_0x1a_11c5:
            ii(0x1a_11c5, 1);  pop(ds);                                /* pop ds */
            ii(0x1a_11c6, 1);  leave();                                /* leave */
            ii(0x1a_11c7, 3);  retf(8);                                /* retf 0x8 */
        }
    }
}
