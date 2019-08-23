using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_48a8-e72207ad")]
        public void Method_1016_48a8()
        {
            ii(0x1016_48a8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1016_48ad, 5); call(Definitions.sys_check_available_stack_size, 0x14a0); /* call 0x10165d52 */
            ii(0x1016_48b2, 1); push(ebx);                              /* push ebx */
            ii(0x1016_48b3, 1); push(ecx);                              /* push ecx */
            ii(0x1016_48b4, 1); push(esi);                              /* push esi */
            ii(0x1016_48b5, 1); push(edi);                              /* push edi */
            ii(0x1016_48b6, 1); push(ebp);                              /* push ebp */
            ii(0x1016_48b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_48b9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_48bf, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_48c2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_48c5, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1016_48c9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_48cc, 5); call(0x1016_48e0, 0xf);                 /* call 0x101648e0 */
            ii(0x1016_48d1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1016_48d4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_48d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_48d9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_48da, 1); pop(edi);                               /* pop edi */
            ii(0x1016_48db, 1); pop(esi);                               /* pop esi */
            ii(0x1016_48dc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_48dd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_48de, 1); ret();                                  /* ret */
        }
    }
}
