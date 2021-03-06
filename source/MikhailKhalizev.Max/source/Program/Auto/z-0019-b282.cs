using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_b282-64d852d4")]
        public void Method_0019_b282()
        {
            ii(0x19_b282, 1);  push(bp);                               /* push bp */
            ii(0x19_b283, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_b285, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_b288, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_b28a, 4);  mov(memw[es, bx + 2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x19_b28e, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_b291, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x19_b294, 3);  or(ax, memw[ss, bp + 8]);               /* or ax, [bp+0x8] */
            ii(0x19_b297, 2);  if(jz(0x19_b2b7, 0x1e)) goto l_0x19_b2b7;/* jz 0xb2b7 */
            ii(0x19_b299, 3);  push(memw[ss, bp + 16]);                /* push word [bp+0x10] */
            ii(0x19_b29c, 2);  push(1);                                /* push 0x1 */
            ii(0x19_b29e, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_b2a1, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_b2a4, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_b2a7, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_b2aa, 3);  call(0x19_de46, 0x2b99);                /* call 0xde46 */
            ii(0x19_b2ad, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_b2b0, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_b2b3, 4);  mov(memw[es, bx + 2], dx);              /* mov [es:bx+0x2], dx */
        l_0x19_b2b7:
            ii(0x19_b2b7, 4);  mov(ax, memw[es, bx + 2]);              /* mov ax, [es:bx+0x2] */
            ii(0x19_b2bb, 3);  or(ax, memw[es, bx]);                   /* or ax, [es:bx] */
            ii(0x19_b2be, 2);  if(jz(0x19_b2c5, 5)) goto l_0x19_b2c5;  /* jz 0xb2c5 */
            ii(0x19_b2c0, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x19_b2c3, 2);  jmp(0x19_b2c7, 2); goto l_0x19_b2c7;    /* jmp 0xb2c7 */
        l_0x19_b2c5:
            ii(0x19_b2c5, 2);  sub(ax, ax);                            /* sub ax, ax */
        l_0x19_b2c7:
            ii(0x19_b2c7, 1);  leave();                                /* leave */
            ii(0x19_b2c8, 3);  ret(0xe);                               /* ret 0xe */
        }
    }
}
