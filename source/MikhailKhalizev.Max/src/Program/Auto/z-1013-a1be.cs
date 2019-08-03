using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a5db5e00-7d49-49b0-8efa-4d8a1c3642bc")]
        public void Method_1013_a1be()
        {
            ii(0x1013_a1be, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_a1c3, 5); calld(Definitions.sys_check_available_stack_size, 0x2bb8a); /* call 0x10165d52 */
            ii(0x1013_a1c8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_a1c9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_a1ca, 1); pushd(esi);                             /* push esi */
            ii(0x1013_a1cb, 1); pushd(edi);                             /* push edi */
            ii(0x1013_a1cc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_a1cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a1cf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_a1d5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a1d8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_a1db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a1de, 5); calld(0x1013_a6f4, 0x511);              /* call 0x1013a6f4 */
            ii(0x1013_a1e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a1e5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a1e8, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a1eb, 5); calld(0x1007_5e24, -0xc43cc);           /* call 0x10075e24 */
            ii(0x1013_a1f0, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1013_a1f3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a1f6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a1f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a1fb, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_a1fe, 5); calld(0x1007_5e24, -0xc43df);           /* call 0x10075e24 */
            ii(0x1013_a203, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1013_a206, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a209, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a20c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_a20f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_a212, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a214, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_a215, 1); popd(edi);                              /* pop edi */
            ii(0x1013_a216, 1); popd(esi);                              /* pop esi */
            ii(0x1013_a217, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_a218, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_a219, 1); retd(); return;                         /* ret */
        }
    }
}
