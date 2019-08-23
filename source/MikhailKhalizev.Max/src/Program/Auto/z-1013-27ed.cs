using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_27ed-3587ed20")]
        public void Method_1013_27ed()
        {
            ii(0x1013_27ed, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_27f2, 5); call(Definitions.sys_check_available_stack_size, 0x3_355b); /* call 0x10165d52 */
            ii(0x1013_27f7, 1); push(ebx);                              /* push ebx */
            ii(0x1013_27f8, 1); push(ecx);                              /* push ecx */
            ii(0x1013_27f9, 1); push(esi);                              /* push esi */
            ii(0x1013_27fa, 1); push(edi);                              /* push edi */
            ii(0x1013_27fb, 1); push(ebp);                              /* push ebp */
            ii(0x1013_27fc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_27fe, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_2804, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_2807, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_280a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_280d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_2810, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_2813, 4); mov(ax, memw[ds, eax + 0x5]);           /* mov ax, [eax+0x5] */
            ii(0x1013_2817, 1); dec(eax);                               /* dec eax */
            ii(0x1013_2818, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_281b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_281e, 5); call(0x1013_2705, -0x11e);              /* call 0x10132705 */
            ii(0x1013_2823, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_2825, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_2826, 1); pop(edi);                               /* pop edi */
            ii(0x1013_2827, 1); pop(esi);                               /* pop esi */
            ii(0x1013_2828, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_2829, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_282a, 1); ret();                                  /* ret */
        }
    }
}
