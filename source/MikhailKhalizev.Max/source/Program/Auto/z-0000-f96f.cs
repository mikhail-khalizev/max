using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xf96f-3152c071")]
        public void Method_0000_f96f()
        {
            ii(0xf96f, 4);  mov(bx, memw[ds, 0xafa]);                  /* mov bx, [0xafa] */
            ii(0xf973, 2);  mov(cx, memw[ds, bx]);                     /* mov cx, [bx] */
            ii(0xf975, 1);  dec(bx);                                   /* dec bx */
            ii(0xf976, 1);  dec(bx);                                   /* dec bx */
            ii(0xf977, 4);  mov(memw[ds, 0xafa], bx);                  /* mov [0xafa], bx */
            ii(0xf97b, 4);  cmp(bx, 0xafa);                            /* cmp bx, 0xafa */
            ii(0xf97f, 4);  jmp_far_ind(memw[ds, 0xaf6]);              /* jmp far word [0xaf6] */
        }
    }
}
