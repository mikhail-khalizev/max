using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_197f-3152c071")]
        public void Method_0001_197f()
        {
            ii(0x1_197f, 4);  mov(bx, memw_a16[ds, 0xafa]);             /* mov bx, [0xafa] */
            ii(0x1_1983, 2);  mov(cx, memw_a16[ds, bx]);                /* mov cx, [bx] */
            ii(0x1_1985, 1);  dec(bx);                                  /* dec bx */
            ii(0x1_1986, 1);  dec(bx);                                  /* dec bx */
            ii(0x1_1987, 4);  mov(memw_a16[ds, 0xafa], bx);             /* mov [0xafa], bx */
            ii(0x1_198b, 4);  cmp(bx, 0xafa);                           /* cmp bx, 0xafa */
            ii(0x1_198f, 4);  if(jmpw_a16_far_ind(ds, 0xaf6)) return;   /* jmp far word [0xaf6] */
        }
    }
}