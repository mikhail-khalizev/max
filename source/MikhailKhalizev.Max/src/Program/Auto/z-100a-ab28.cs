using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ab28-c502b1ca")]
        public void Method_100a_ab28()
        {
            ii(0x100a_ab28, 1); push(ebx);                              /* push ebx */
            ii(0x100a_ab29, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ab2a, 1); push(edx);                              /* push edx */
            ii(0x100a_ab2b, 1); push(esi);                              /* push esi */
            ii(0x100a_ab2c, 1); push(edi);                              /* push edi */
            ii(0x100a_ab2d, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ab2e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ab30, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100a_ab36, 7); mov(memd[ss, ebp - 4], 5);              /* mov dword [ebp-0x4], 0x5 */
            ii(0x100a_ab3d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ab40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ab42, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_ab43, 1); pop(edi);                               /* pop edi */
            ii(0x100a_ab44, 1); pop(esi);                               /* pop esi */
            ii(0x100a_ab45, 1); pop(edx);                               /* pop edx */
            ii(0x100a_ab46, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_ab47, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_ab48, 1); ret();                                  /* ret */
        }
    }
}
