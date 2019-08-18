using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6c06e7f4-9e5a-4d90-9b7d-48b586398e36")]
        public void Method_100b_7a14()
        {
            ii(0x100b_7a14, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7a19, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e334); /* call 0x10165d52 */
            ii(0x100b_7a1e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7a1f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7a20, 1); pushd(edx);                             /* push edx */
            ii(0x100b_7a21, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7a22, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7a23, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7a24, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7a26, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7a2c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7a2f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7a32, 5); calld(0x1007_6c30, -0x4_0e07);          /* call 0x10076c30 */
            ii(0x100b_7a37, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7a3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7a3d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7a3f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7a40, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7a41, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7a42, 1); popd(edx);                              /* pop edx */
            ii(0x100b_7a43, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7a44, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7a45, 1); retd(); return;                         /* ret */
        }
    }
}
