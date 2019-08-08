using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("80ec8572-36e1-4a44-b2cd-0a66d6145c53")]
        public void Method_1013_1930()
        {
            ii(0x1013_1930, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1935, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4418); /* call 0x10165d52 */
            ii(0x1013_193a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_193b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_193c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_193d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_193e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_193f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1941, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_1947, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_194a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_194d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_1951, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1954, 5); calld(0x100a_b494, -0x8_64c5);          /* call 0x100ab494 */
            ii(0x1013_1959, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_195c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_195f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1961, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1962, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1963, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1964, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1965, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1966, 1); retd(); return;                         /* ret */
        }
    }
}
