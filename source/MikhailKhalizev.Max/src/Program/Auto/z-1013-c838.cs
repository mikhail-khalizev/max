using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b4a651f8-7d82-4bb2-8f40-7cb8a1a6b18e")]
        public void Method_1013_c838()
        {
            ii(0x1013_c838, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_c83d, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9510); /* call 0x10165d52 */
            ii(0x1013_c842, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c843, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c844, 1); pushd(edx);                             /* push edx */
            ii(0x1013_c845, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c846, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c847, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c848, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c84a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c850, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_c853, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c856, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1013_c859, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c85c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c85f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c861, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c862, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c863, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c864, 1); popd(edx);                              /* pop edx */
            ii(0x1013_c865, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c866, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c867, 1); retd(); return;                         /* ret */
        }
    }
}
