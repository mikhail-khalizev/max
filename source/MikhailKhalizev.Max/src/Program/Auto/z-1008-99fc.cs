using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_99fc-87c393ef")]
        public void Method_1008_99fc()
        {
            ii(0x1008_99fc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_9a01, 5); call(Definitions.sys_check_available_stack_size, 0xd_c34c); /* call 0x10165d52 */
            ii(0x1008_9a06, 1); push(ebx);                              /* push ebx */
            ii(0x1008_9a07, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9a08, 1); push(esi);                              /* push esi */
            ii(0x1008_9a09, 1); push(edi);                              /* push edi */
            ii(0x1008_9a0a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9a0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9a0d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9a13, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_9a16, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_9a19, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_9a1c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9a1f, 5); call(0x1013_ac7d, 0xb_1259);            /* call 0x1013ac7d */
            ii(0x1008_9a24, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_9a27, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_9a2a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9a2c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9a2d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9a2e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9a2f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9a30, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9a31, 1); ret();                                  /* ret */
        }
    }
}
