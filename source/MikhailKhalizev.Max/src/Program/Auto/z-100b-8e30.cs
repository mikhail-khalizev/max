using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8e30-36a6c451")]
        public void Method_100b_8e30()
        {
            ii(0x100b_8e30, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_8e35, 5); calld(Definitions.sys_check_available_stack_size, 0xa_cf18); /* call 0x10165d52 */
            ii(0x100b_8e3a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8e3b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8e3c, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8e3d, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8e3e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8e3f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8e41, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_8e47, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8e4a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_8e4d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_8e50, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8e53, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100b_8e56, 5); calld(0x1008_afe4, -0x2_de77);          /* call 0x1008afe4 */
            ii(0x100b_8e5b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8e5d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8e5e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8e5f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8e60, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8e61, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8e62, 1); retd();                                 /* ret */
        }
    }
}
