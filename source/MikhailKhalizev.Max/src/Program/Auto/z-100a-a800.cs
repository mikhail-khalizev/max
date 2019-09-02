using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a800-c502b1ca")]
        public void Method_100a_a800()
        {
            ii(0x100a_a800, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a801, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a802, 1); push(edx);                              /* push edx */
            ii(0x100a_a803, 1); push(esi);                              /* push esi */
            ii(0x100a_a804, 1); push(edi);                              /* push edi */
            ii(0x100a_a805, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a806, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a808, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100a_a80e, 7); mov(memd[ss, ebp - 4], 5);              /* mov dword [ebp-0x4], 0x5 */
            ii(0x100a_a815, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_a818, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a81a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a81b, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a81c, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a81d, 1); pop(edx);                               /* pop edx */
            ii(0x100a_a81e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a81f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a820, 1); ret();                                  /* ret */
        }
    }
}
