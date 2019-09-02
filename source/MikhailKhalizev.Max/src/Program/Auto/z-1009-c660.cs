using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c660-b5fdc02a")]
        public void Method_1009_c660()
        {
            ii(0x1009_c660, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c665, 5); call(Definitions.sys_check_available_stack_size, 0xc_96e8); /* call 0x10165d52 */
            ii(0x1009_c66a, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c66b, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c66c, 1); push(esi);                              /* push esi */
            ii(0x1009_c66d, 1); push(edi);                              /* push edi */
            ii(0x1009_c66e, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c66f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c671, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c677, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c67a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_c67d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_c680, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c683, 5); call(0x1013_a66b, 0x9_dfe3);            /* call 0x1013a66b */
            ii(0x1009_c688, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1009_c68b, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1009_c68e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c690, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c691, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c692, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c693, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c694, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c695, 1); ret();                                  /* ret */
        }
    }
}
