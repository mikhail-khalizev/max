using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_cdf8-a1937cec")]
        public void Method_1008_cdf8()
        {
            ii(0x1008_cdf8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_cdfd, 5); calld(Definitions.sys_check_available_stack_size, 0xd_8f50); /* call 0x10165d52 */
            ii(0x1008_ce02, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_ce03, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_ce04, 1); pushd(edx);                             /* push edx */
            ii(0x1008_ce05, 1); pushd(esi);                             /* push esi */
            ii(0x1008_ce06, 1); pushd(edi);                             /* push edi */
            ii(0x1008_ce07, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_ce08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ce0a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_ce10, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_ce13, 4); mov(memb_a32[ss, ebp - 0x8], 0x9);      /* mov byte [ebp-0x8], 0x9 */
            ii(0x1008_ce17, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_ce1a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ce1c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_ce1d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_ce1e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_ce1f, 1); popd(edx);                              /* pop edx */
            ii(0x1008_ce20, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_ce21, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_ce22, 1); retd(); return;                         /* ret */
        }
    }
}
