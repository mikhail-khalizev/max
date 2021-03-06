using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d3bf-a9b34bc9")]
        public void /* sys */ Method_1018_d3bf()
        {
            ii(0x1018_d3bf, 1);  push(edx);                            /* push edx */
            ii(0x1018_d3c0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1018_d3c2, 5);  call(/* sys */ 0x1018_d7a2, 0x3db);   /* call 0x1018d7a2 */
            ii(0x1018_d3c7, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1018_d3c9, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_d3ca, 1);  ret();                                /* ret */
        }
    }
}
