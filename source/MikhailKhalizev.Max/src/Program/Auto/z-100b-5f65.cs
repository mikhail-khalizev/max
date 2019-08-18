using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5f65-7dfbacc3")]
        public void Method_100b_5f65()
        {
            ii(0x100b_5f65, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_5f6a, 5); calld(Definitions.sys_check_available_stack_size, 0xa_fde3); /* call 0x10165d52 */
            ii(0x100b_5f6f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_5f70, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5f71, 1); pushd(edx);                             /* push edx */
            ii(0x100b_5f72, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5f73, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5f74, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_5f75, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5f77, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_5f7d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_5f80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5f83, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5f86, 5); calld(0x1013_a794, 0x8_4809);           /* call 0x1013a794 */
            ii(0x100b_5f8b, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100b_5f8e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_5f91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5f94, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5f96, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5f97, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5f98, 1); popd(esi);                              /* pop esi */
            ii(0x100b_5f99, 1); popd(edx);                              /* pop edx */
            ii(0x100b_5f9a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_5f9b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_5f9c, 1); retd(); return;                         /* ret */
        }
    }
}
