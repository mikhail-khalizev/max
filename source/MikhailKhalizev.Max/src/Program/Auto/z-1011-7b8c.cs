using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7b8c-a68fb529")]
        public void Method_1011_7b8c()
        {
            ii(0x1011_7b8c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_7b91, 5); calld(Definitions.sys_check_available_stack_size, 0x4_e1bc); /* call 0x10165d52 */
            ii(0x1011_7b96, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7b97, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7b98, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7b99, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7b9a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7b9b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7b9d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_7ba3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7ba6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_7ba9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_7bae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7bb1, 5); calld(0x1007_5e24, -0xa_1d92);          /* call 0x10075e24 */
            ii(0x1011_7bb6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7bb9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7bbc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_7bbf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7bc2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7bc4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7bc5, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7bc6, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7bc7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7bc8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7bc9, 1); retd();                                 /* ret */
        }
    }
}
