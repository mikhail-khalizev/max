using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c6ac-951fc28f")]
        public void Method_1013_c6ac()
        {
            ii(0x1013_c6ac, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_c6ad, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_c6ae, 1);  push(edx);                            /* push edx */
            ii(0x1013_c6af, 1);  push(esi);                            /* push esi */
            ii(0x1013_c6b0, 1);  push(edi);                            /* push edi */
            ii(0x1013_c6b1, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_c6b2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_c6b4, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1013_c6ba, 7);  mov(memd[ss, ebp - 4], 0x7fff);       /* mov dword [ebp-0x4], 0x7fff */
            ii(0x1013_c6c1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_c6c4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_c6c6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_c6c7, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_c6c8, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_c6c9, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_c6ca, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_c6cb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_c6cc, 1);  ret();                                /* ret */
        }
    }
}
