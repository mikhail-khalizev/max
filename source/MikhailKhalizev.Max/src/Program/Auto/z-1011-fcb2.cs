using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8191daf6-234d-493b-be3a-0a2000f0f2e3")]
        public void Method_1011_fcb2()
        {
            ii(0x1011_fcb2, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_fcb7, 5); calld(Definitions.sys_check_available_stack_size, 0x4_6096); /* call 0x10165d52 */
            ii(0x1011_fcbc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_fcbd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_fcbe, 1); pushd(edx);                             /* push edx */
            ii(0x1011_fcbf, 1); pushd(esi);                             /* push esi */
            ii(0x1011_fcc0, 1); pushd(edi);                             /* push edi */
            ii(0x1011_fcc1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_fcc2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fcc4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_fcca, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_fccd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_fcd0, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fcd5, 5); calld(0x1011_dd56, -0x1f84);            /* call 0x1011dd56 */
            ii(0x1011_fcda, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_fcdc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_fcdd, 1); popd(edi);                              /* pop edi */
            ii(0x1011_fcde, 1); popd(esi);                              /* pop esi */
            ii(0x1011_fcdf, 1); popd(edx);                              /* pop edx */
            ii(0x1011_fce0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_fce1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_fce2, 1); retd(); return;                         /* ret */
        }
    }
}
