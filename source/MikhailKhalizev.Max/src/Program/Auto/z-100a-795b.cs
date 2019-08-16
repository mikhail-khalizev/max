using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("86134d45-178d-4403-ae7b-8a0bdc6ffaa3")]
        public void Method_100a_795b()
        {
            ii(0x100a_795b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_795e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_7961, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_7964, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7966, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7967, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7968, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7969, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_796a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_796b, 1); retd(); return;                         /* ret */
        }
    }
}
