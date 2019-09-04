using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2cb7-9e121c46")]
        public void Method_100a_2cb7()
        {
            ii(0x100a_2cb7, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_2cbc, 5); call(Definitions.sys_check_available_stack_size, 0xc_3091); /* call 0x10165d52 */
            ii(0x100a_2cc1, 1); push(ebx);                              /* push ebx */
            ii(0x100a_2cc2, 1); push(ecx);                              /* push ecx */
            ii(0x100a_2cc3, 1); push(edx);                              /* push edx */
            ii(0x100a_2cc4, 1); push(esi);                              /* push esi */
            ii(0x100a_2cc5, 1); push(edi);                              /* push edi */
            ii(0x100a_2cc6, 1); push(ebp);                              /* push ebp */
            ii(0x100a_2cc7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2cc9, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_2ccf, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_2cd2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_2cd5, 4); mov(ax, memw[ds, eax + 13]);            /* mov ax, [eax+0xd] */
            ii(0x100a_2cd9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_2cdc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_2cdf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2ce1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_2ce2, 1); pop(edi);                               /* pop edi */
            ii(0x100a_2ce3, 1); pop(esi);                               /* pop esi */
            ii(0x100a_2ce4, 1); pop(edx);                               /* pop edx */
            ii(0x100a_2ce5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_2ce6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_2ce7, 1); ret();                                  /* ret */
        }
    }
}
