using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a9b0-951fc28f")]
        public void Method_100a_a9b0()
        {
            ii(0x100a_a9b0, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_a9b1, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_a9b2, 1);  push(edx);                            /* push edx */
            ii(0x100a_a9b3, 1);  push(esi);                            /* push esi */
            ii(0x100a_a9b4, 1);  push(edi);                            /* push edi */
            ii(0x100a_a9b5, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_a9b6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_a9b8, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_a9be, 7);  mov(memd[ss, ebp - 4], 0x7fff);       /* mov dword [ebp-0x4], 0x7fff */
            ii(0x100a_a9c5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_a9c8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_a9ca, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_a9cb, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_a9cc, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_a9cd, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_a9ce, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_a9cf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_a9d0, 1);  ret();                                /* ret */
        }
    }
}
