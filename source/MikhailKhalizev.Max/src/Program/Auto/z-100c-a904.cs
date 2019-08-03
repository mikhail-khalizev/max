using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("558d2bf6-a313-43ad-8b3b-bd91a88edb34")]
        public void Method_100c_a904()
        {
            ii(0x100c_a904, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a909, 5); calld(Definitions.sys_check_available_stack_size, 0x9b444); /* call 0x10165d52 */
            ii(0x100c_a90e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a90f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a910, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a911, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a912, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a913, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a915, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a91b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a91e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a921, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_a925, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a928, 5); calld(0x100c_a93c, 0xf);                /* call 0x100ca93c */
            ii(0x100c_a92d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a930, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a933, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a935, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a936, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a937, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a938, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a939, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a93a, 1); retd(); return;                         /* ret */
        }
    }
}
