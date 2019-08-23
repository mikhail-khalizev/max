using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b936-827d1aec")]
        public void Method_1013_b936()
        {
            ii(0x1013_b936, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_b93b, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a412); /* call 0x10165d52 */
            ii(0x1013_b940, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b941, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b942, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b943, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b944, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b945, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b947, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_b94d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b950, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b953, 5); calld(0x1013_c6d0, 0xd78);              /* call 0x1013c6d0 */
            ii(0x1013_b958, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_b95b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b95e, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_b961, 5); calld(0x1013_c668, 0xd02);              /* call 0x1013c668 */
            ii(0x1013_b966, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1013_b969, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b96c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_b96f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b972, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b975, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1013_b97b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_b97e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b981, 5); calld(0x1013_b9e0, 0x5a);               /* call 0x1013b9e0 */
            ii(0x1013_b986, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b989, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_b98c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b98f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b991, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b992, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b993, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b994, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b995, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b996, 1); retd();                                 /* ret */
        }
    }
}
