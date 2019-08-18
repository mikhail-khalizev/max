using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c6d0-c502b1ca")]
        public void Method_1013_c6d0()
        {
            ii(0x1013_c6d0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c6d1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c6d2, 1); pushd(edx);                             /* push edx */
            ii(0x1013_c6d3, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c6d4, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c6d5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c6d6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c6d8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_c6de, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x1013_c6e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c6e8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c6ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c6eb, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c6ec, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c6ed, 1); popd(edx);                              /* pop edx */
            ii(0x1013_c6ee, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c6ef, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c6f0, 1); retd(); return;                         /* ret */
        }
    }
}
