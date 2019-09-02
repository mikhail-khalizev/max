using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b936-827d1aec")]
        public void Method_1013_b936()
        {
            ii(0x1013_b936, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_b93b, 5); call(Definitions.sys_check_available_stack_size, 0x2_a412); /* call 0x10165d52 */
            ii(0x1013_b940, 1); push(ebx);                              /* push ebx */
            ii(0x1013_b941, 1); push(ecx);                              /* push ecx */
            ii(0x1013_b942, 1); push(esi);                              /* push esi */
            ii(0x1013_b943, 1); push(edi);                              /* push edi */
            ii(0x1013_b944, 1); push(ebp);                              /* push ebp */
            ii(0x1013_b945, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b947, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_b94d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_b950, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_b953, 5); call(0x1013_c6d0, 0xd78);               /* call 0x1013c6d0 */
            ii(0x1013_b958, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_b95b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b95e, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1013_b961, 5); call(0x1013_c668, 0xd02);               /* call 0x1013c668 */
            ii(0x1013_b966, 3); sub(eax, 4);                            /* sub eax, 0x4 */
            ii(0x1013_b969, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_b96c, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1013_b96f, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_b972, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b975, 6); mov(memd[ds, eax], 0);                  /* mov dword [eax], 0x0 */
            ii(0x1013_b97b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_b97e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b981, 5); call(0x1013_b9e0, 0x5a);                /* call 0x1013b9e0 */
            ii(0x1013_b986, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b989, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_b98c, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_b98f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b991, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_b992, 1); pop(edi);                               /* pop edi */
            ii(0x1013_b993, 1); pop(esi);                               /* pop esi */
            ii(0x1013_b994, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_b995, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_b996, 1); ret();                                  /* ret */
        }
    }
}
