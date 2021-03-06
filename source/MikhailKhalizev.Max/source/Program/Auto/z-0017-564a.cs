using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_564a-69e5b386")]
        public void Method_0017_564a()
        {
            ii(0x17_564a, 1);  push(ds);                               /* push ds */
            ii(0x17_564b, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_564e, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_5650, 1);  nop();                                  /* nop */
            ii(0x17_5651, 1);  push(cs);                               /* push cs */
            ii(0x17_5652, 3);  call(0x17_8e80, 0x382b);                /* call 0x8e80 */
            ii(0x17_5655, 3);  mov(memw[ds, 0xae], ax);                /* mov [0xae], ax */
            ii(0x17_5658, 4);  mov(memw[ds, 0xb0], dx);                /* mov [0xb0], dx */
            ii(0x17_565c, 5);  cmp(memw[ds, 0x51a0], 0);               /* cmp word [0x51a0], 0x0 */
            ii(0x17_5661, 2);  if(jnz(0x17_5678, 0x15)) goto l_0x17_5678;/* jnz 0x5678 */
            ii(0x17_5663, 4);  push(memw[ds, 0x4f86]);                 /* push word [0x4f86] */
            ii(0x17_5667, 4);  push(memw[ds, 0x4f84]);                 /* push word [0x4f84] */
            ii(0x17_566b, 1);  nop();                                  /* nop */
            ii(0x17_566c, 1);  push(cs);                               /* push cs */
            ii(0x17_566d, 3);  call(0x17_909e, 0x3a2e);                /* call 0x909e */
            ii(0x17_5670, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5673, 1);  nop();                                  /* nop */
            ii(0x17_5674, 1);  push(cs);                               /* push cs */
            ii(0x17_5675, 3);  call(0x17_9078, 0x3a00);                /* call 0x9078 */
        l_0x17_5678:
            ii(0x17_5678, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5679, 1);  retf();                                 /* retf */
        }
    }
}
