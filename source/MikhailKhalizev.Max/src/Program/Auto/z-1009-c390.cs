using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c390-9926e646")]
        public void Method_1009_c390()
        {
            ii(0x1009_c390, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c395, 5); call(Definitions.sys_check_available_stack_size, 0xc_99b8); /* call 0x10165d52 */
            ii(0x1009_c39a, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c39b, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c39c, 1); push(edx);                              /* push edx */
            ii(0x1009_c39d, 1); push(esi);                              /* push esi */
            ii(0x1009_c39e, 1); push(edi);                              /* push edi */
            ii(0x1009_c39f, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c3a0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c3a2, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_c3a8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_c3ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_c3ae, 1); inc(eax);                               /* inc eax */
            ii(0x1009_c3af, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c3b2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c3b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c3b7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c3b8, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c3b9, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c3ba, 1); pop(edx);                               /* pop edx */
            ii(0x1009_c3bb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c3bc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c3bd, 1); ret();                                  /* ret */
        }
    }
}
