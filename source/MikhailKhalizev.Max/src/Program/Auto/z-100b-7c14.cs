using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e620c933-84f1-4237-bb0b-fe30fb1de2b6")]
        public void Method_100b_7c14()
        {
            ii(0x100b_7c14, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_7c19, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e134); /* call 0x10165d52 */
            ii(0x100b_7c1e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7c1f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7c20, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7c21, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7c22, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7c23, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7c25, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7c2b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7c2e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7c31, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_7c34, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7c37, 5); calld(0x1013_a2ab, 0x8_266f);           /* call 0x1013a2ab */
            ii(0x100b_7c3c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7c3e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7c3f, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7c40, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7c41, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7c42, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7c43, 1); retd(); return;                         /* ret */
        }
    }
}
