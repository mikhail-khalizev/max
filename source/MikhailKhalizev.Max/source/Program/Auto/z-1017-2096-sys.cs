using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2096-8500e19c")]
        public void /* sys */ Method_1017_2096()
        {
            ii(0x1017_2096, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_2097, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1017_2099, 5);  call(/* sys */ 0x1017_211c, 0x7e);    /* call 0x1017211c */
            ii(0x1017_209e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_20a0, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1017_20a2, 5);  call(/* sys */ 0x1018_d57c, 0x1_b4d5);/* call 0x1018d57c */
            ii(0x1017_20a7, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1017_20a9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_20aa, 1);  ret();                                /* ret */
        }
    }
}
