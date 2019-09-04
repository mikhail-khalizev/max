using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8dfb-8a4e17f2")]
        public void Method_100b_8dfb()
        {
            ii(0x100b_8dfb, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_8e00, 5); call(Definitions.sys_check_available_stack_size, 0xa_cf4d); /* call 0x10165d52 */
            ii(0x100b_8e05, 1); push(ebx);                              /* push ebx */
            ii(0x100b_8e06, 1); push(ecx);                              /* push ecx */
            ii(0x100b_8e07, 1); push(edx);                              /* push edx */
            ii(0x100b_8e08, 1); push(esi);                              /* push esi */
            ii(0x100b_8e09, 1); push(edi);                              /* push edi */
            ii(0x100b_8e0a, 1); push(ebp);                              /* push ebp */
            ii(0x100b_8e0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8e0d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_8e13, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_8e16, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_8e19, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100b_8e1c, 5); call(0x1008_afb4, -0x2_de6d);           /* call 0x1008afb4 */
            ii(0x100b_8e21, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_8e24, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_8e27, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8e29, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_8e2a, 1); pop(edi);                               /* pop edi */
            ii(0x100b_8e2b, 1); pop(esi);                               /* pop esi */
            ii(0x100b_8e2c, 1); pop(edx);                               /* pop edx */
            ii(0x100b_8e2d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_8e2e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_8e2f, 1); ret();                                  /* ret */
        }
    }
}
