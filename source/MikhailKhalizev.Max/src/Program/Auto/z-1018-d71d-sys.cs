using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d71d-a6132145")]
        public void /* sys */ Method_1018_d71d()
        {
            ii(0x1018_d71d, 1); push(ebx);                              /* push ebx */
            ii(0x1018_d71e, 1); push(edx);                              /* push edx */
            ii(0x1018_d71f, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1018_d724, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_d726, 5); call(Definitions.sys_lseek, -0x1_0594); /* call 0x1017d197 */
            ii(0x1018_d72b, 1); pop(edx);                               /* pop edx */
            ii(0x1018_d72c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_d72d, 1); ret();                                  /* ret */
        }
    }
}
