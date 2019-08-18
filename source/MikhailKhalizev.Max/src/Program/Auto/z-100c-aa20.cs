using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("222e77c8-4f2a-495a-bdf8-d94c9ee9045b")]
        public void Method_100c_aa20()
        {
            ii(0x100c_aa20, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_aa21, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_aa22, 1); pushd(edx);                             /* push edx */
            ii(0x100c_aa23, 1); pushd(esi);                             /* push esi */
            ii(0x100c_aa24, 1); pushd(edi);                             /* push edi */
            ii(0x100c_aa25, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_aa26, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_aa28, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_aa2e, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100c_aa35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_aa38, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_aa3a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_aa3b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_aa3c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_aa3d, 1); popd(edx);                              /* pop edx */
            ii(0x100c_aa3e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_aa3f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_aa40, 1); retd(); return;                         /* ret */
        }
    }
}
