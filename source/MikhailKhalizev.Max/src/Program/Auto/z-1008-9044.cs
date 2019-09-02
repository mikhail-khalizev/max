using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9044-a3a8b948")]
        public void Method_1008_9044()
        {
            ii(0x1008_9044, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_9049, 5); call(Definitions.sys_check_available_stack_size, 0xd_cd04); /* call 0x10165d52 */
            ii(0x1008_904e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_904f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9050, 1); push(esi);                              /* push esi */
            ii(0x1008_9051, 1); push(edi);                              /* push edi */
            ii(0x1008_9052, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9053, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9055, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_905b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_905e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_9061, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_9066, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9069, 5); call(0x1007_5e24, -0x1_324a);           /* call 0x10075e24 */
            ii(0x1008_906e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_9071, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9074, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_9077, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_907a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_907c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_907d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_907e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_907f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9080, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9081, 1); ret();                                  /* ret */
        }
    }
}
