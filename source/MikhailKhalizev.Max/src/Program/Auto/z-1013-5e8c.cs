using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5e8c-9e15909d")]
        public void Method_1013_5e8c()
        {
            ii(0x1013_5e8c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_5e91, 5); calld(Definitions.sys_check_available_stack_size, 0x2_febc); /* call 0x10165d52 */
            ii(0x1013_5e96, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_5e97, 1); pushd(esi);                             /* push esi */
            ii(0x1013_5e98, 1); pushd(edi);                             /* push edi */
            ii(0x1013_5e99, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_5e9a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_5e9c, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_5ea2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_5ea5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_5ea8, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1013_5eab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_5eae, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_5eb1, 5); if(jmpd_func(0x1013_5fa8, 0xf2)) return; /* jmp 0x10135fa8 */
        }
    }
}
