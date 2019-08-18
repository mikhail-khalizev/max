using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b0ec-10dd9045")]
        public void Method_100c_b0ec()
        {
            ii(0x100c_b0ec, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b0f1, 5); calld(Definitions.sys_check_available_stack_size, 0x9_ac5c); /* call 0x10165d52 */
            ii(0x100c_b0f6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b0f7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b0f8, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b0f9, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b0fa, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b0fb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b0fc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b0fe, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b104, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b107, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b10a, 5); calld(0x1007_6c30, -0x5_44df);          /* call 0x10076c30 */
            ii(0x100c_b10f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b112, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b115, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b117, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b118, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b119, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b11a, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b11b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b11c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b11d, 1); retd(); return;                         /* ret */
        }
    }
}
