using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1af6-38ad143b")]
        public void Method_001a_1af6()
        {
            ii(0x1a_1af6, 4);  enter(0xc, 0);                          /* enter 0xc, 0x0 */
            ii(0x1a_1afa, 1);  push(di);                               /* push di */
            ii(0x1a_1afb, 1);  push(si);                               /* push si */
            ii(0x1a_1afc, 5);  call_far_abs(0x80, 0x1878);             /* call word 0x80:0x1878 */
            ii(0x1a_1b01, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x1a_1b04, 4);  cmp(memw[ss, bp - 12], 0);              /* cmp word [bp-0xc], 0x0 */
            ii(0x1a_1b08, 2);  if(jz(0x1a_1b0d, 3)) goto l_0x1a_1b0d;  /* jz 0x1b0d */
            ii(0x1a_1b0a, 3);  jmp(0x1a_1b13, 6); goto l_0x1a_1b13;    /* jmp 0x1b13 */
        l_0x1a_1b0d:
            ii(0x1a_1b0d, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x1a_1b10, 3);  jmp(0x1a_1b43, 0x30); goto l_0x1a_1b43; /* jmp 0x1b43 */
        l_0x1a_1b13:
            ii(0x1a_1b13, 5);  mov(memw[ss, bp - 4], 0);               /* mov word [bp-0x4], 0x0 */
            ii(0x1a_1b18, 5);  mov(memw[ss, bp - 2], 0x90);            /* mov word [bp-0x2], 0x90 */
            ii(0x1a_1b1d, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x1a_1b20, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x1a_1b23, 5);  mov(memw[ss, bp - 8], 0);               /* mov word [bp-0x8], 0x0 */
            ii(0x1a_1b28, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x1a_1b2b, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x1a_1b2e, 3);  lea(ax, memw[ss, bp - 10]);             /* lea ax, [bp-0xa] */
            ii(0x1a_1b31, 1);  push(ss);                               /* push ss */
            ii(0x1a_1b32, 1);  push(ax);                               /* push ax */
            ii(0x1a_1b33, 2);  push(0x10);                             /* push 0x10 */
            ii(0x1a_1b35, 5);  call_far_abs(0x80, 0xb38);              /* call word 0x80:0xb38 */
            ii(0x1a_1b3a, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x1a_1b3d, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x1a_1b40, 3);  jmp(0x1a_1b43, 0); goto l_0x1a_1b43;    /* jmp 0x1b43 */
        l_0x1a_1b43:
            ii(0x1a_1b43, 1);  pop(si);                                /* pop si */
            ii(0x1a_1b44, 1);  pop(di);                                /* pop di */
            ii(0x1a_1b45, 1);  leave();                                /* leave */
            ii(0x1a_1b46, 1);  retf();                                 /* retf */
        }
    }
}
