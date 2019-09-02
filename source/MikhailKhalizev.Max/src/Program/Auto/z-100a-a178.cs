using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a178-5fe0902b")]
        public void Method_100a_a178()
        {
            ii(0x100a_a178, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_a17d, 5); call(Definitions.sys_check_available_stack_size, 0xb_bbd0); /* call 0x10165d52 */
            ii(0x100a_a182, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a183, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a184, 1); push(esi);                              /* push esi */
            ii(0x100a_a185, 1); push(edi);                              /* push edi */
            ii(0x100a_a186, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a187, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a189, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a18f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a192, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_a195, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100a_a19a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a19d, 5); call(0x1007_5e24, -0x3_437e);           /* call 0x10075e24 */
            ii(0x100a_a1a2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a1a5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a1a8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_a1ab, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_a1ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a1b0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a1b1, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a1b2, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a1b3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a1b4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a1b5, 1); ret();                                  /* ret */
        }
    }
}
