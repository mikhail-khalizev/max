using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6515a85e-718c-48cf-91a3-d845ccdeaacb")]
        public void Method_100b_815c()
        {
            ii(0x100b_815c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_8161, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dbec); /* call 0x10165d52 */
            ii(0x100b_8166, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8167, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8168, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8169, 1); pushd(edi);                             /* push edi */
            ii(0x100b_816a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_816b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_816d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_8173, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8176, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_8179, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_817c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_817f, 5); calld(0x1013_abc3, 0x8_2a3f);           /* call 0x1013abc3 */
            ii(0x100b_8184, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8187, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_818a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_818d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8190, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_8193, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_8196, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8198, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8199, 1); popd(edi);                              /* pop edi */
            ii(0x100b_819a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_819b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_819c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_819d, 1); retd(); return;                         /* ret */
        }
    }
}
