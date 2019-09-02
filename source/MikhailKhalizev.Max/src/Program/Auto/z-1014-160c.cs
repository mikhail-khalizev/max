using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_160c-7148e472")]
        public void Method_1014_160c()
        {
            ii(0x1014_160c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_1611, 5); call(Definitions.sys_check_available_stack_size, 0x2_473c); /* call 0x10165d52 */
            ii(0x1014_1616, 1); push(ebx);                              /* push ebx */
            ii(0x1014_1617, 1); push(ecx);                              /* push ecx */
            ii(0x1014_1618, 1); push(esi);                              /* push esi */
            ii(0x1014_1619, 1); push(edi);                              /* push edi */
            ii(0x1014_161a, 1); push(ebp);                              /* push ebp */
            ii(0x1014_161b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_161d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_1623, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_1626, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_1629, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_162d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1630, 5); call(0x1013_b052, -0x65e3);             /* call 0x1013b052 */
            ii(0x1014_1635, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_1638, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1014_163b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_163e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1641, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_1644, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_1647, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1649, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_164a, 1); pop(edi);                               /* pop edi */
            ii(0x1014_164b, 1); pop(esi);                               /* pop esi */
            ii(0x1014_164c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_164d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_164e, 1); ret();                                  /* ret */
        }
    }
}
