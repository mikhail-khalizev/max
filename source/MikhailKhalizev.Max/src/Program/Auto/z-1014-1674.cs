using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1674-c502b1ca")]
        public void Method_1014_1674()
        {
            ii(0x1014_1674, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1675, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1676, 1); pushd(edx);                             /* push edx */
            ii(0x1014_1677, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1678, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1679, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_167a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_167c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_1682, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x1014_1689, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_168c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_168e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_168f, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1690, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1691, 1); popd(edx);                              /* pop edx */
            ii(0x1014_1692, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1693, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1694, 1); retd(); return;                         /* ret */
        }
    }
}
