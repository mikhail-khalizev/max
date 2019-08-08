using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c24e2cb9-4195-4ea0-8e9b-42d660be4a9a")]
        public void Method_1012_b5cc()
        {
            ii(0x1012_b5cc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_b5d1, 5); calld(Definitions.sys_check_available_stack_size, 0x3_a77c); /* call 0x10165d52 */
            ii(0x1012_b5d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_b5d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_b5d8, 1); pushd(edx);                             /* push edx */
            ii(0x1012_b5d9, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b5da, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b5db, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b5dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b5de, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_b5e4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_b5e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_b5ea, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1012_b5ed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_b5f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_b5f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b5f5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b5f6, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b5f7, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b5f8, 1); popd(edx);                              /* pop edx */
            ii(0x1012_b5f9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_b5fa, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_b5fb, 1); retd(); return;                         /* ret */
        }
    }
}
