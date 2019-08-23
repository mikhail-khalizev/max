using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d9af-3152c071")]
        public void Method_0018_d9af()
        {
            ii(0x18_d9af, 4); mov(bx, memw[ds, 0xafa]);                 /* mov bx, [0xafa] */
            ii(0x18_d9b3, 2); mov(cx, memw[ds, bx]);                    /* mov cx, [bx] */
            ii(0x18_d9b5, 1); dec(bx);                                  /* dec bx */
            ii(0x18_d9b6, 1); dec(bx);                                  /* dec bx */
            ii(0x18_d9b7, 4); mov(memw[ds, 0xafa], bx);                 /* mov [0xafa], bx */
            ii(0x18_d9bb, 4); cmp(bx, 0xafa);                           /* cmp bx, 0xafa */
            ii(0x18_d9bf, 4); jmp_far_ind(memw[ds, 0xaf6]);             /* jmp far word [0xaf6] */
        }
    }
}
