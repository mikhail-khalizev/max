using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2b60-7e93caef")]
        public void Method_1010_2b60()
        {
            ii(0x1010_2b60, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_2b61, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_2b62, 1);  push(edx);                            /* push edx */
            ii(0x1010_2b63, 1);  push(esi);                            /* push esi */
            ii(0x1010_2b64, 1);  push(edi);                            /* push edi */
            ii(0x1010_2b65, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_2b66, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_2b68, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_2b6e, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1010_2b75, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2b78, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_2b7a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_2b7b, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_2b7c, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_2b7d, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_2b7e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_2b7f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_2b80, 1);  ret();                                /* ret */
        }
    }
}
