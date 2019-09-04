using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_afb4-b39f8514")]
        public void Method_1008_afb4()
        {
            ii(0x1008_afb4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_afb9, 5); call(Definitions.sys_check_available_stack_size, 0xd_ad94); /* call 0x10165d52 */
            ii(0x1008_afbe, 1); push(ebx);                              /* push ebx */
            ii(0x1008_afbf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_afc0, 1); push(edx);                              /* push edx */
            ii(0x1008_afc1, 1); push(esi);                              /* push esi */
            ii(0x1008_afc2, 1); push(edi);                              /* push edi */
            ii(0x1008_afc3, 1); push(ebp);                              /* push ebp */
            ii(0x1008_afc4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_afc6, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_afcc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_afcf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_afd2, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_afd4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_afd7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_afda, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_afdc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_afdd, 1); pop(edi);                               /* pop edi */
            ii(0x1008_afde, 1); pop(esi);                               /* pop esi */
            ii(0x1008_afdf, 1); pop(edx);                               /* pop edx */
            ii(0x1008_afe0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_afe1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_afe2, 1); ret();                                  /* ret */
        }
    }
}
