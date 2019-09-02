using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_98c4-e7074e2")]
        public void Method_1008_98c4()
        {
            ii(0x1008_98c4, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_98c9, 5); call(Definitions.sys_check_available_stack_size, 0xd_c484); /* call 0x10165d52 */
            ii(0x1008_98ce, 1); push(ebx);                              /* push ebx */
            ii(0x1008_98cf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_98d0, 1); push(esi);                              /* push esi */
            ii(0x1008_98d1, 1); push(edi);                              /* push edi */
            ii(0x1008_98d2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_98d3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_98d5, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_98db, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_98de, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_98e1, 3); mov(edi, memd[ss, ebp - 4]);            /* mov edi, [ebp-0x4] */
            ii(0x1008_98e4, 3); mov(esi, memd[ss, ebp - 8]);            /* mov esi, [ebp-0x8] */
            ii(0x1008_98e7, 3); lea(esi, memd[ds, esi + 11]);           /* lea esi, [esi+0xb] */
            ii(0x1008_98ea, 1); movsd();                                /* movsd */
            ii(0x1008_98eb, 1); movsd();                                /* movsd */
            ii(0x1008_98ec, 1); movsd();                                /* movsd */
            ii(0x1008_98ed, 1); movsd();                                /* movsd */
            ii(0x1008_98ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_98f0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_98f1, 1); pop(edi);                               /* pop edi */
            ii(0x1008_98f2, 1); pop(esi);                               /* pop esi */
            ii(0x1008_98f3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_98f4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_98f5, 1); ret();                                  /* ret */
        }
    }
}
