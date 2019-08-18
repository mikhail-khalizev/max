using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6cd706c9-afbe-4942-a385-c4352a3b19c5")]
        public void Method_1013_19d0()
        {
            ii(0x1013_19d0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_19d1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_19d2, 1); pushd(edx);                             /* push edx */
            ii(0x1013_19d3, 1); pushd(esi);                             /* push esi */
            ii(0x1013_19d4, 1); pushd(edi);                             /* push edi */
            ii(0x1013_19d5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_19d6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_19d8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_19de, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x1013_19e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_19e8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_19ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_19eb, 1); popd(edi);                              /* pop edi */
            ii(0x1013_19ec, 1); popd(esi);                              /* pop esi */
            ii(0x1013_19ed, 1); popd(edx);                              /* pop edx */
            ii(0x1013_19ee, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_19ef, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_19f0, 1); retd(); return;                         /* ret */
        }
    }
}
