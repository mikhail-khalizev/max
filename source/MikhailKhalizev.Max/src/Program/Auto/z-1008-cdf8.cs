using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_cdf8-a1937cec")]
        public void Method_1008_cdf8()
        {
            ii(0x1008_cdf8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_cdfd, 5); call(Definitions.sys_check_available_stack_size, 0xd_8f50); /* call 0x10165d52 */
            ii(0x1008_ce02, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ce03, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ce04, 1); push(edx);                              /* push edx */
            ii(0x1008_ce05, 1); push(esi);                              /* push esi */
            ii(0x1008_ce06, 1); push(edi);                              /* push edi */
            ii(0x1008_ce07, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ce08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ce0a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_ce10, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_ce13, 4); mov(memb[ss, ebp - 8], 9);              /* mov byte [ebp-0x8], 0x9 */
            ii(0x1008_ce17, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1008_ce1a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ce1c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_ce1d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_ce1e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_ce1f, 1); pop(edx);                               /* pop edx */
            ii(0x1008_ce20, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_ce21, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_ce22, 1); ret();                                  /* ret */
        }
    }
}
