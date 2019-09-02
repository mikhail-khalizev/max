using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4470-9ea7342b")]
        public void Method_1010_4470()
        {
            ii(0x1010_4470, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_4475, 5); call(Definitions.sys_check_available_stack_size, 0x6_18d8); /* call 0x10165d52 */
            ii(0x1010_447a, 1); push(ebx);                              /* push ebx */
            ii(0x1010_447b, 1); push(ecx);                              /* push ecx */
            ii(0x1010_447c, 1); push(esi);                              /* push esi */
            ii(0x1010_447d, 1); push(edi);                              /* push edi */
            ii(0x1010_447e, 1); push(ebp);                              /* push ebp */
            ii(0x1010_447f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4481, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_4487, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_448a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_448d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1010_4492, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_4495, 5); call(0x1007_5e24, -0x8_e676);           /* call 0x10075e24 */
            ii(0x1010_449a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_449d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_44a0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_44a3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_44a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_44a8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_44a9, 1); pop(edi);                               /* pop edi */
            ii(0x1010_44aa, 1); pop(esi);                               /* pop esi */
            ii(0x1010_44ab, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_44ac, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_44ad, 1); ret();                                  /* ret */
        }
    }
}
