using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("74e1fba1-01f6-4001-9876-ea7efc7ffe2d")]
        public void Method_0001_12fb()
        {
            ii(0x1_12fb, 3);  cmp(edi, ecx);                            /* cmp edi, ecx */
            ii(0x1_12fe, 2);  if(jbew_func(0x1_12e9, -0x17)) return;    /* jbe 0x12e9 */
            ii(0x1_1300, 3);  callw(0x1_1316, 0x13);                    /* call 0x1316 */
        }
    }
}
