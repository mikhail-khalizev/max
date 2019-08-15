using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9532317e-84ee-46f2-af82-8c40ecaf44e1")]
        public void Method_1011_82a8()
        {
            ii(0x1011_82a8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_82ad, 5); calld(Definitions.sys_check_available_stack_size, 0x4_daa0); /* call 0x10165d52 */
            ii(0x1011_82b2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_82b3, 1); pushd(esi);                             /* push esi */
            ii(0x1011_82b4, 1); pushd(edi);                             /* push edi */
            ii(0x1011_82b5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_82b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_82b8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_82be, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_82c1, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_82c4, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_82c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_82c9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_82ca, 1); popd(edi);                              /* pop edi */
            ii(0x1011_82cb, 1); popd(esi);                              /* pop esi */
            ii(0x1011_82cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_82cd, 1); retd(); return;                         /* ret */
        }
    }
}
