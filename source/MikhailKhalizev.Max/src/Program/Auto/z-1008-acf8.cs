using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_acf8-bb9998ab")]
        public void Method_1008_acf8()
        {
            ii(0x1008_acf8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_acfd, 5); call(Definitions.sys_check_available_stack_size, 0xd_b050); /* call 0x10165d52 */
            ii(0x1008_ad02, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ad03, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ad04, 1); push(edx);                              /* push edx */
            ii(0x1008_ad05, 1); push(esi);                              /* push esi */
            ii(0x1008_ad06, 1); push(edi);                              /* push edi */
            ii(0x1008_ad07, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ad08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ad0a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_ad10, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_ad13, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_ad16, 3); mov(al, memb[ds, eax + 7]);             /* mov al, [eax+0x7] */
            ii(0x1008_ad19, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1008_ad1c, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1008_ad1f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ad21, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_ad22, 1); pop(edi);                               /* pop edi */
            ii(0x1008_ad23, 1); pop(esi);                               /* pop esi */
            ii(0x1008_ad24, 1); pop(edx);                               /* pop edx */
            ii(0x1008_ad25, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_ad26, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_ad27, 1); ret();                                  /* ret */
        }
    }
}
