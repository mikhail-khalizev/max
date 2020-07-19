using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ac70-7e93caef")]
        public void Method_1008_ac70()
        {
            ii(0x1008_ac70, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_ac71, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_ac72, 1);  push(edx);                            /* push edx */
            ii(0x1008_ac73, 1);  push(esi);                            /* push esi */
            ii(0x1008_ac74, 1);  push(edi);                            /* push edi */
            ii(0x1008_ac75, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_ac76, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_ac78, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1008_ac7e, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1008_ac85, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ac88, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_ac8a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_ac8b, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_ac8c, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_ac8d, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_ac8e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_ac8f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_ac90, 1);  ret();                                /* ret */
        }
    }
}
