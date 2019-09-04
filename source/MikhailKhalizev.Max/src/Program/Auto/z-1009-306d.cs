using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_306d-373612b8")]
        public void Method_1009_306d()
        {
            ii(0x1009_306d, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_3072, 5); call(Definitions.sys_check_available_stack_size, 0xd_2cdb); /* call 0x10165d52 */
            ii(0x1009_3077, 1); push(ebx);                              /* push ebx */
            ii(0x1009_3078, 1); push(ecx);                              /* push ecx */
            ii(0x1009_3079, 1); push(edx);                              /* push edx */
            ii(0x1009_307a, 1); push(esi);                              /* push esi */
            ii(0x1009_307b, 1); push(edi);                              /* push edi */
            ii(0x1009_307c, 1); push(ebp);                              /* push ebp */
            ii(0x1009_307d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_307f, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_3085, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_3088, 4); mov(memb[ss, ebp - 8], 0x15);           /* mov byte [ebp-0x8], 0x15 */
            ii(0x1009_308c, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1009_308f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3091, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_3092, 1); pop(edi);                               /* pop edi */
            ii(0x1009_3093, 1); pop(esi);                               /* pop esi */
            ii(0x1009_3094, 1); pop(edx);                               /* pop edx */
            ii(0x1009_3095, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_3096, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_3097, 1); ret();                                  /* ret */
        }
    }
}
