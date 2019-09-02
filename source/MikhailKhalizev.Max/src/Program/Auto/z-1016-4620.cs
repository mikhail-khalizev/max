using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4620-bf9dca0a")]
        public void Method_1016_4620()
        {
            ii(0x1016_4620, 5); push(0x24);                             /* push 0x24 */
            ii(0x1016_4625, 5); call(Definitions.sys_check_available_stack_size, 0x1728); /* call 0x10165d52 */
            ii(0x1016_462a, 1); push(ebx);                              /* push ebx */
            ii(0x1016_462b, 1); push(ecx);                              /* push ecx */
            ii(0x1016_462c, 1); push(esi);                              /* push esi */
            ii(0x1016_462d, 1); push(edi);                              /* push edi */
            ii(0x1016_462e, 1); push(ebp);                              /* push ebp */
            ii(0x1016_462f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4631, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_4637, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_463a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_463d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_4642, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_4645, 5); call(0x1007_5e24, -0xe_e826);           /* call 0x10075e24 */
            ii(0x1016_464a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_464d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_4650, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1016_4653, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1016_4656, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4658, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_4659, 1); pop(edi);                               /* pop edi */
            ii(0x1016_465a, 1); pop(esi);                               /* pop esi */
            ii(0x1016_465b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_465c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_465d, 1); ret();                                  /* ret */
        }
    }
}
