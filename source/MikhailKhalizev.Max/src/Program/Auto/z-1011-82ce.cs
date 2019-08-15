using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ca9f05bb-c5b9-4db0-9ae3-262462e149bc")]
        public void Method_1011_82ce()
        {
            ii(0x1011_82ce, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_82d3, 5); calld(Definitions.sys_check_available_stack_size, 0x4_da7a); /* call 0x10165d52 */
            ii(0x1011_82d8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_82d9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_82da, 1); pushd(esi);                             /* push esi */
            ii(0x1011_82db, 1); pushd(edi);                             /* push edi */
            ii(0x1011_82dc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_82dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_82df, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_82e5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_82e8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_82eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_82ed, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_82ee, 1); popd(edi);                              /* pop edi */
            ii(0x1011_82ef, 1); popd(esi);                              /* pop esi */
            ii(0x1011_82f0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_82f1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_82f2, 1); retd(); return;                         /* ret */
        }
    }
}
