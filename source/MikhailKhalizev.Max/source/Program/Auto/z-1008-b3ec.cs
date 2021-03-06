using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b3ec-c502b1ca")]
        public void Method_1008_b3ec()
        {
            ii(0x1008_b3ec, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_b3ed, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_b3ee, 1);  push(edx);                            /* push edx */
            ii(0x1008_b3ef, 1);  push(esi);                            /* push esi */
            ii(0x1008_b3f0, 1);  push(edi);                            /* push edi */
            ii(0x1008_b3f1, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_b3f2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_b3f4, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1008_b3fa, 7);  mov(memd[ss, ebp - 4], 5);            /* mov dword [ebp-0x4], 0x5 */
            ii(0x1008_b401, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_b404, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_b406, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_b407, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_b408, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_b409, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_b40a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_b40b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_b40c, 1);  ret();                                /* ret */
        }
    }
}
