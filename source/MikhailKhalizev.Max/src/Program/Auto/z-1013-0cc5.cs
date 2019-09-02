using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0cc5-54baf910")]
        public void Method_1013_0cc5()
        {
            ii(0x1013_0cc5, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_0cca, 5); call(Definitions.sys_check_available_stack_size, 0x3_5083); /* call 0x10165d52 */
            ii(0x1013_0ccf, 1); push(ebx);                              /* push ebx */
            ii(0x1013_0cd0, 1); push(ecx);                              /* push ecx */
            ii(0x1013_0cd1, 1); push(esi);                              /* push esi */
            ii(0x1013_0cd2, 1); push(edi);                              /* push edi */
            ii(0x1013_0cd3, 1); push(ebp);                              /* push ebp */
            ii(0x1013_0cd4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0cd6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0cdc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_0cdf, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_0ce2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_0ce5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_0ce8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0ceb, 4); cmp(memb[ds, eax + 0x17], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_0cef, 2); if(jz(0x1013_0d05, 0x14)) goto l_0x1013_0d05; /* jz 0x10130d05 */
            ii(0x1013_0cf1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0cf4, 4); mov(memb[ds, eax + 0x17], 0);           /* mov byte [eax+0x17], 0x0 */
            ii(0x1013_0cf8, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_0cfd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0d00, 5); call(0x1013_0c16, -0xef);               /* call 0x10130c16 */
        l_0x1013_0d05:
            ii(0x1013_0d05, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0d07, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_0d08, 1); pop(edi);                               /* pop edi */
            ii(0x1013_0d09, 1); pop(esi);                               /* pop esi */
            ii(0x1013_0d0a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_0d0b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_0d0c, 1); ret();                                  /* ret */
        }
    }
}
