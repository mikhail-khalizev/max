using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a6a4-d3173a76")]
        public void Method_1008_a6a4()
        {
            ii(0x1008_a6a4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_a6a9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b6a4); /* call 0x10165d52 */
            ii(0x1008_a6ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a6af, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a6b0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a6b1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a6b2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a6b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a6b5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a6bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a6be, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1008_a6c1, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1008_a6c4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_a6c7, 3); mov(memb_a32[ds, edx + 0x44], al);      /* mov [edx+0x44], al */
            ii(0x1008_a6ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a6cc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a6cd, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a6ce, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a6cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a6d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a6d1, 1); retd(); return;                         /* ret */
        }
    }
}
