using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("892f5fd3-ce9f-4096-b75f-55330034d38b")]
        public void Method_1008_a460()
        {
            ii(0x1008_a460, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_a465, 5); calld(Definitions.sys_check_available_stack_size, 0xdb8e8); /* call 0x10165d52 */
            ii(0x1008_a46a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a46b, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a46c, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a46d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a46e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a470, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a476, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a479, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1008_a47c, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1008_a47f, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1008_a483, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_a486, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_a489, 5); calld(0x1008_b410, 0xf82);              /* call 0x1008b410 */
            ii(0x1008_a48e, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_a491, 5); calld(0x100c_d990, 0x434fa);            /* call 0x100cd990 */
            ii(0x1008_a496, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a498, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a499, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a49a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a49b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a49c, 1); retd(); return;                         /* ret */
        }
    }
}