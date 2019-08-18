using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("49ef237a-047b-4e1f-8801-d88f5550474a")]
        public void Method_1011_d1aa()
        {
            ii(0x1011_d1aa, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_d1af, 5); calld(Definitions.sys_check_available_stack_size, 0x4_8b9e); /* call 0x10165d52 */
            ii(0x1011_d1b4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_d1b5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_d1b6, 1); pushd(edx);                             /* push edx */
            ii(0x1011_d1b7, 1); pushd(esi);                             /* push esi */
            ii(0x1011_d1b8, 1); pushd(edi);                             /* push edi */
            ii(0x1011_d1b9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_d1ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d1bc, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_d1c2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_d1c5, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1011_d1c9, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1011_d1cc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d1ce, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_d1cf, 1); popd(edi);                              /* pop edi */
            ii(0x1011_d1d0, 1); popd(esi);                              /* pop esi */
            ii(0x1011_d1d1, 1); popd(edx);                              /* pop edx */
            ii(0x1011_d1d2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_d1d3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_d1d4, 1); retd(); return;                         /* ret */
        }
    }
}
