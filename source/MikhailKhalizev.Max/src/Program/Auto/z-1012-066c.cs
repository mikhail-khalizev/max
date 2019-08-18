using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_066c-f944d443")]
        public void Method_1012_066c()
        {
            ii(0x1012_066c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_0671, 5); calld(Definitions.sys_check_available_stack_size, 0x4_56dc); /* call 0x10165d52 */
            ii(0x1012_0676, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0677, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0678, 1); pushd(edx);                             /* push edx */
            ii(0x1012_0679, 1); pushd(esi);                             /* push esi */
            ii(0x1012_067a, 1); pushd(edi);                             /* push edi */
            ii(0x1012_067b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_067c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_067e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_0684, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_0687, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_068a, 5); calld(0x1007_6c30, -0xa_9a5f);          /* call 0x10076c30 */
            ii(0x1012_068f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0692, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0695, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0697, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0698, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0699, 1); popd(esi);                              /* pop esi */
            ii(0x1012_069a, 1); popd(edx);                              /* pop edx */
            ii(0x1012_069b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_069c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_069d, 1); retd(); return;                         /* ret */
        }
    }
}
