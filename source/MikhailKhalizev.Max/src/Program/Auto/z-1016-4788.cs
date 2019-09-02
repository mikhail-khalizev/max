using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4788-ca9a207d")]
        public void Method_1016_4788()
        {
            ii(0x1016_4788, 5); push(0x20);                             /* push 0x20 */
            ii(0x1016_478d, 5); call(Definitions.sys_check_available_stack_size, 0x15c0); /* call 0x10165d52 */
            ii(0x1016_4792, 1); push(ebx);                              /* push ebx */
            ii(0x1016_4793, 1); push(ecx);                              /* push ecx */
            ii(0x1016_4794, 1); push(esi);                              /* push esi */
            ii(0x1016_4795, 1); push(edi);                              /* push edi */
            ii(0x1016_4796, 1); push(ebp);                              /* push ebp */
            ii(0x1016_4797, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4799, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1016_479f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_47a2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_47a5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_47a8, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1016_47aa, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_47ad, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_47b0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_47b3, 5); call(0x1016_47c0, 8);                   /* call 0x101647c0 */
            ii(0x1016_47b8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_47ba, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_47bb, 1); pop(edi);                               /* pop edi */
            ii(0x1016_47bc, 1); pop(esi);                               /* pop esi */
            ii(0x1016_47bd, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_47be, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_47bf, 1); ret();                                  /* ret */
        }
    }
}
