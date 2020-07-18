using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a9b8-951fc28f")]
        public void Method_100c_a9b8()
        {
            ii(0x100c_a9b8, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_a9b9, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_a9ba, 1);  push(edx);                            /* push edx */
            ii(0x100c_a9bb, 1);  push(esi);                            /* push esi */
            ii(0x100c_a9bc, 1);  push(edi);                            /* push edi */
            ii(0x100c_a9bd, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_a9be, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_a9c0, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100c_a9c6, 7);  mov(memd[ss, ebp - 4], 0x7fff);       /* mov dword [ebp-0x4], 0x7fff */
            ii(0x100c_a9cd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a9d0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_a9d2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_a9d3, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_a9d4, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_a9d5, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_a9d6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_a9d7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_a9d8, 1);  ret();                                /* ret */
        }
    }
}
