using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f40db20a-09a9-4336-9a46-a47f2c7ea982")]
        public void Method_1009_c44c()
        {
            ii(0x1009_c44c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c451, 5); calld(Definitions.sys_check_available_stack_size, 0xc_98fc); /* call 0x10165d52 */
            ii(0x1009_c456, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c457, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c458, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c459, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c45a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c45b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c45d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c463, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c466, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_c469, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_c46c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c46f, 5); calld(0x1013_ac7d, 0x9_e809);           /* call 0x1013ac7d */
            ii(0x1009_c474, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c477, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c47a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c47c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c47d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c47e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c47f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c480, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c481, 1); retd(); return;                         /* ret */
        }
    }
}
