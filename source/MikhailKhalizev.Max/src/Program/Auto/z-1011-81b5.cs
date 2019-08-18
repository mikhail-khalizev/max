using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4fb4978a-e785-4e27-8da5-4a8eb7be48fd")]
        public void Method_1011_81b5()
        {
            ii(0x1011_81b5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_81ba, 5); calld(Definitions.sys_check_available_stack_size, 0x4_db93); /* call 0x10165d52 */
            ii(0x1011_81bf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_81c0, 1); pushd(esi);                             /* push esi */
            ii(0x1011_81c1, 1); pushd(edi);                             /* push edi */
            ii(0x1011_81c2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_81c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_81c5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_81cb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_81ce, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_81d1, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_81d4, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_81d8, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1011_81db, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_81dd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_81de, 1); popd(edi);                              /* pop edi */
            ii(0x1011_81df, 1); popd(esi);                              /* pop esi */
            ii(0x1011_81e0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_81e1, 1); retd(); return;                         /* ret */
        }
    }
}
