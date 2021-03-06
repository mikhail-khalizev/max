using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a8a1-757fc67d")]
        public void Method_0018_a8a1()
        {
            ii(0x18_a8a1, 4);  mov(bx, memw[ds, 0x99e]);               /* mov bx, [0x99e] */
            ii(0x18_a8a5, 3);  mov(memw[ds, bx + 38], ax);             /* mov [bx+0x26], ax */
            ii(0x18_a8a8, 3);  mov(ss, memw[ds, bx + 34]);             /* mov ss, [bx+0x22] */
            ii(0x18_a8ab, 3);  mov(sp, memw[ds, bx + 30]);             /* mov sp, [bx+0x1e] */
            ii(0x18_a8ae, 3);  mov(ax, memw[ds, 0xc32]);               /* mov ax, [0xc32] */
            ii(0x18_a8b1, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x18_a8b3, 5);  pop(memw[es, 0x1064]);                  /* pop word [es:0x1064] */
            ii(0x18_a8b8, 2);  mov(ax, ds);                            /* mov ax, ds */
            ii(0x18_a8ba, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x18_a8bc, 1);  popa();                                 /* popa */
            ii(0x18_a8bd, 1);  cld();                                  /* cld */
            ii(0x18_a8be, 1);  ret();                                  /* ret */
        }
    }
}
