using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c630-e2acab67")]
        public void Method_1013_c630()
        {
            ii(0x1013_c630, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c635, 5); call(Definitions.sys_check_available_stack_size, 0x2_9718); /* call 0x10165d52 */
            ii(0x1013_c63a, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c63b, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c63c, 1); push(esi);                              /* push esi */
            ii(0x1013_c63d, 1); push(edi);                              /* push edi */
            ii(0x1013_c63e, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c63f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c641, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c647, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c64a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c64d, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1013_c651, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c654, 5); call(0x100a_b494, -0x9_11c5);           /* call 0x100ab494 */
            ii(0x1013_c659, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_c65c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_c65f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c661, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c662, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c663, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c664, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c665, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c666, 1); ret();                                  /* ret */
        }
    }
}
