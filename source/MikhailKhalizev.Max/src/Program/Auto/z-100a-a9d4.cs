using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a9d4-c502b1ca")]
        public void Method_100a_a9d4()
        {
            ii(0x100a_a9d4, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a9d5, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a9d6, 1); push(edx);                              /* push edx */
            ii(0x100a_a9d7, 1); push(esi);                              /* push esi */
            ii(0x100a_a9d8, 1); push(edi);                              /* push edi */
            ii(0x100a_a9d9, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a9da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a9dc, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100a_a9e2, 7); mov(memd[ss, ebp - 4], 5);              /* mov dword [ebp-0x4], 0x5 */
            ii(0x100a_a9e9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_a9ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a9ee, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a9ef, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a9f0, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a9f1, 1); pop(edx);                               /* pop edx */
            ii(0x100a_a9f2, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a9f3, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a9f4, 1); ret();                                  /* ret */
        }
    }
}
