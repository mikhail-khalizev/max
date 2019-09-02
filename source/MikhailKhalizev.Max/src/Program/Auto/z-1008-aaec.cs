using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_aaec-a1db1c07")]
        public void Method_1008_aaec()
        {
            ii(0x1008_aaec, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_aaf1, 5); call(Definitions.sys_check_available_stack_size, 0xd_b25c); /* call 0x10165d52 */
            ii(0x1008_aaf6, 1); push(ebx);                              /* push ebx */
            ii(0x1008_aaf7, 1); push(ecx);                              /* push ecx */
            ii(0x1008_aaf8, 1); push(esi);                              /* push esi */
            ii(0x1008_aaf9, 1); push(edi);                              /* push edi */
            ii(0x1008_aafa, 1); push(ebp);                              /* push ebp */
            ii(0x1008_aafb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_aafd, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_ab03, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_ab06, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_ab09, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_ab0c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_ab0f, 5); call(0x1013_a5af, 0xa_fa9b);            /* call 0x1013a5af */
            ii(0x1008_ab14, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ab16, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_ab17, 1); pop(edi);                               /* pop edi */
            ii(0x1008_ab18, 1); pop(esi);                               /* pop esi */
            ii(0x1008_ab19, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_ab1a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_ab1b, 1); ret();                                  /* ret */
        }
    }
}
