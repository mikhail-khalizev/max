using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aa20-7e93caef")]
        public void Method_100c_aa20()
        {
            ii(0x100c_aa20, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_aa21, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_aa22, 1);  push(edx);                            /* push edx */
            ii(0x100c_aa23, 1);  push(esi);                            /* push esi */
            ii(0x100c_aa24, 1);  push(edi);                            /* push edi */
            ii(0x100c_aa25, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_aa26, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_aa28, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100c_aa2e, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100c_aa35, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_aa38, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_aa3a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_aa3b, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_aa3c, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_aa3d, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_aa3e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_aa3f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_aa40, 1);  ret();                                /* ret */
        }
    }
}
