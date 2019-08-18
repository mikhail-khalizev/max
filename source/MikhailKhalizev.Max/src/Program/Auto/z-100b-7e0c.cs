using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a5629b84-1795-49ed-8904-29cc6f9454cf")]
        public void Method_100b_7e0c()
        {
            ii(0x100b_7e0c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7e11, 5); calld(Definitions.sys_check_available_stack_size, 0xa_df3c); /* call 0x10165d52 */
            ii(0x100b_7e16, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7e17, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7e18, 1); pushd(edx);                             /* push edx */
            ii(0x100b_7e19, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7e1a, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7e1b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7e1c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7e1e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7e24, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7e27, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7e2a, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100b_7e2d, 5); calld(0x100a_b33c, -0xcaf6);            /* call 0x100ab33c */
            ii(0x100b_7e32, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7e35, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7e38, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7e3a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7e3b, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7e3c, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7e3d, 1); popd(edx);                              /* pop edx */
            ii(0x100b_7e3e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7e3f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7e40, 1); retd(); return;                         /* ret */
        }
    }
}
