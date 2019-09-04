using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8bfc-84d16740")]
        public void Method_1008_8bfc()
        {
            ii(0x1008_8bfc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8c01, 5); call(Definitions.sys_check_available_stack_size, 0xd_d14c); /* call 0x10165d52 */
            ii(0x1008_8c06, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8c07, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8c08, 1); push(esi);                              /* push esi */
            ii(0x1008_8c09, 1); push(edi);                              /* push edi */
            ii(0x1008_8c0a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8c0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8c0d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8c13, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8c16, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_8c19, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_8c1e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8c21, 5); call(0x1013_a1be, 0xb_1598);            /* call 0x1013a1be */
            ii(0x1008_8c26, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8c29, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8c2c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_8c2f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_8c32, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8c34, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8c35, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8c36, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8c37, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8c38, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8c39, 1); ret();                                  /* ret */
        }
    }
}
