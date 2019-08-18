using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d82f-2e3b1161")]
        public void Method_1011_d82f()
        {
            ii(0x1011_d82f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_d834, 5); calld(Definitions.sys_check_available_stack_size, 0x4_8519); /* call 0x10165d52 */
            ii(0x1011_d839, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_d83a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_d83b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_d83c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_d83d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_d83e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d840, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_d846, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_d849, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_d84c, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_d84f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_d852, 3); mov(memb_a32[ds, edx + 0x14], al);      /* mov [edx+0x14], al */
            ii(0x1011_d855, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d857, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_d858, 1); popd(edi);                              /* pop edi */
            ii(0x1011_d859, 1); popd(esi);                              /* pop esi */
            ii(0x1011_d85a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_d85b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_d85c, 1); retd(); return;                         /* ret */
        }
    }
}
