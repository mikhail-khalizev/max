using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_607a-5d97cd15")]
        public void Method_100d_607a()
        {
            ii(0x100d_607a, 5); push(0xbc);                             /* push 0xbc */
            ii(0x100d_607f, 5); call(Definitions.sys_check_available_stack_size, 0x8_fcce); /* call 0x10165d52 */
            ii(0x100d_6084, 1); push(ebx);                              /* push ebx */
            ii(0x100d_6085, 1); push(ecx);                              /* push ecx */
            ii(0x100d_6086, 1); push(edx);                              /* push edx */
            ii(0x100d_6087, 1); push(esi);                              /* push esi */
            ii(0x100d_6088, 1); push(edi);                              /* push edi */
            ii(0x100d_6089, 1); push(ebp);                              /* push ebp */
            ii(0x100d_608a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_608c, 6); sub(esp, 0xa0);                         /* sub esp, 0xa0 */
            ii(0x100d_6092, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_6095, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x100d_6099, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_609d, 6); lea(eax, memd[ss, ebp - 0x9c]);         /* lea eax, [ebp-0x9c] */
            ii(0x100d_60a3, 5); call(0x100d_5504, -0xba4);              /* call 0x100d5504 */
            ii(0x100d_60a8, 6); mov(memd[ss, ebp - 0xa0], eax);         /* mov [ebp-0xa0], eax */
            ii(0x100d_60ae, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100d_60b2, 6); lea(eax, memd[ss, ebp - 0x9c]);         /* lea eax, [ebp-0x9c] */
            ii(0x100d_60b8, 5); call(0x100d_600e, -0xaf);               /* call 0x100d600e */
            ii(0x100d_60bd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_60bf, 6); lea(eax, memd[ss, ebp - 0x9c]);         /* lea eax, [ebp-0x9c] */
            ii(0x100d_60c5, 5); call(0x100d_5b47, -0x583);              /* call 0x100d5b47 */
            ii(0x100d_60ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_60cc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_60cd, 1); pop(edi);                               /* pop edi */
            ii(0x100d_60ce, 1); pop(esi);                               /* pop esi */
            ii(0x100d_60cf, 1); pop(edx);                               /* pop edx */
            ii(0x100d_60d0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_60d1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_60d2, 1); ret();                                  /* ret */
        }
    }
}
