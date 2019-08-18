using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("09dee64c-b4c0-4912-b50e-8f7b5efd565e")]
        public void Method_100a_a800()
        {
            ii(0x100a_a800, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a801, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a802, 1); pushd(edx);                             /* push edx */
            ii(0x100a_a803, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a804, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a805, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a806, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a808, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_a80e, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x100a_a815, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_a818, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a81a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a81b, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a81c, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a81d, 1); popd(edx);                              /* pop edx */
            ii(0x100a_a81e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a81f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a820, 1); retd(); return;                         /* ret */
        }
    }
}
