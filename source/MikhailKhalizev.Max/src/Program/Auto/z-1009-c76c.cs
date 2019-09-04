using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c76c-c80d1ba5")]
        public void Method_1009_c76c()
        {
            ii(0x1009_c76c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c771, 5); call(Definitions.sys_check_available_stack_size, 0xc_95dc); /* call 0x10165d52 */
            ii(0x1009_c776, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c777, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c778, 1); push(edx);                              /* push edx */
            ii(0x1009_c779, 1); push(esi);                              /* push esi */
            ii(0x1009_c77a, 1); push(edi);                              /* push edi */
            ii(0x1009_c77b, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c77c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c77e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_c784, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_c787, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_c78a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_c78c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c78f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c792, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c794, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c795, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c796, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c797, 1); pop(edx);                               /* pop edx */
            ii(0x1009_c798, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c799, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c79a, 1); ret();                                  /* ret */
        }
    }
}
