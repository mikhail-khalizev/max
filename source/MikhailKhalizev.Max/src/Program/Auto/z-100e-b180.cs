using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b180-11b1385e")]
        public void Method_100e_b180()
        {
            ii(0x100e_b180, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_b185, 5); call(Definitions.sys_check_available_stack_size, 0x7_abc8); /* call 0x10165d52 */
            ii(0x100e_b18a, 1); push(ebx);                              /* push ebx */
            ii(0x100e_b18b, 1); push(ecx);                              /* push ecx */
            ii(0x100e_b18c, 1); push(edx);                              /* push edx */
            ii(0x100e_b18d, 1); push(esi);                              /* push esi */
            ii(0x100e_b18e, 1); push(edi);                              /* push edi */
            ii(0x100e_b18f, 1); push(ebp);                              /* push ebp */
            ii(0x100e_b190, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b192, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100e_b198, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_b19b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_b19e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b1a1, 3); mov(eax, memd[ds, eax + 0x1b]);         /* mov eax, [eax+0x1b] */
            ii(0x100e_b1a4, 5); call(0x100d_7d74, -0x1_3435);           /* call 0x100d7d74 */
            ii(0x100e_b1a9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b1ab, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_b1ac, 1); pop(edi);                               /* pop edi */
            ii(0x100e_b1ad, 1); pop(esi);                               /* pop esi */
            ii(0x100e_b1ae, 1); pop(edx);                               /* pop edx */
            ii(0x100e_b1af, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_b1b0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_b1b1, 1); ret();                                  /* ret */
        }
    }
}
