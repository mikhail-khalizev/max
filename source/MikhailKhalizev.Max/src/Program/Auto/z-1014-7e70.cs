using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("59ef7198-b146-4695-aa5f-0babefef013a")]
        public void Method_1014_7e70()
        {
            ii(0x1014_7e70, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_7e75, 5); calld(Definitions.sys_check_available_stack_size, 0x1ded8); /* call 0x10165d52 */
            ii(0x1014_7e7a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7e7b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7e7c, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7e7d, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7e7e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7e7f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7e81, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7e87, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7e8a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_7e8d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_7e90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7e93, 5); calld(0x1013_a2ab, -0xdbed);            /* call 0x1013a2ab */
            ii(0x1014_7e98, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7e9a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7e9b, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7e9c, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7e9d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7e9e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7e9f, 1); retd(); return;                         /* ret */
        }
    }
}
