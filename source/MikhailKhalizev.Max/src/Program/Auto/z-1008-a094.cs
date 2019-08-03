using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cc4ad530-9edd-4f9c-84b6-fa6503ea8c1d")]
        public void Method_1008_a094()
        {
            ii(0x1008_a094, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a099, 5); calld(Definitions.sys_check_available_stack_size, 0xdbcb4); /* call 0x10165d52 */
            ii(0x1008_a09e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a09f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a0a0, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a0a1, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a0a2, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a0a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a0a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a0a6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a0ac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a0af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a0b2, 4); mov(ax, memw_a32[ds, eax + 0x7b]);      /* mov ax, [eax+0x7b] */
            ii(0x1008_a0b6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a0b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a0bc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a0be, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a0bf, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a0c0, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a0c1, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a0c2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a0c3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a0c4, 1); retd(); return;                         /* ret */
        }
    }
}
