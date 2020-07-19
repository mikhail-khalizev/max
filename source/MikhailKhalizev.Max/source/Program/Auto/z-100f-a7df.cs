using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a7df-69485d42")]
        public void Method_100f_a7df()
        {
            ii(0x100f_a7df, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_a7e1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_a7e2, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_a7e3, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_a7e4, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_a7e5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_a7e6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_a7e7, 1);  ret();                                /* ret */
        }
    }
}
