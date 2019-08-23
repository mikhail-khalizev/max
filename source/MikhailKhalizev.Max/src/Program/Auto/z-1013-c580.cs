using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c580-191e9a4a")]
        public void Method_1013_c580()
        {
            ii(0x1013_c580, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_c585, 5); call(Definitions.sys_check_available_stack_size, 0x2_97c8); /* call 0x10165d52 */
            ii(0x1013_c58a, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c58b, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c58c, 1); push(edx);                              /* push edx */
            ii(0x1013_c58d, 1); push(esi);                              /* push esi */
            ii(0x1013_c58e, 1); push(edi);                              /* push edi */
            ii(0x1013_c58f, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c590, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c592, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c598, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_c59b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_c59e, 5); call(0x1007_6d58, -0xc_584b);           /* call 0x10076d58 */
            ii(0x1013_c5a3, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_c5a6, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1013_c5a9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c5ac, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_c5af, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_c5b2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_c5b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c5b7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c5b8, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c5b9, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c5ba, 1); pop(edx);                               /* pop edx */
            ii(0x1013_c5bb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c5bc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c5bd, 1); ret();                                  /* ret */
        }
    }
}
