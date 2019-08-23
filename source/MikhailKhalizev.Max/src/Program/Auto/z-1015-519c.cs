using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_519c-16929b9a")]
        public void Method_1015_519c()
        {
            ii(0x1015_519c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_51a1, 5); call(Definitions.sys_check_available_stack_size, 0x1_0bac); /* call 0x10165d52 */
            ii(0x1015_51a6, 1); push(ebx);                              /* push ebx */
            ii(0x1015_51a7, 1); push(ecx);                              /* push ecx */
            ii(0x1015_51a8, 1); push(esi);                              /* push esi */
            ii(0x1015_51a9, 1); push(edi);                              /* push edi */
            ii(0x1015_51aa, 1); push(ebp);                              /* push ebp */
            ii(0x1015_51ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_51ad, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_51b3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_51b6, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_51b9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_51bc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_51bf, 5); call(0x1013_a7ca, -0x1_a9fa);           /* call 0x1013a7ca */
            ii(0x1015_51c4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_51c7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_51ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_51cc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_51cd, 1); pop(edi);                               /* pop edi */
            ii(0x1015_51ce, 1); pop(esi);                               /* pop esi */
            ii(0x1015_51cf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_51d0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_51d1, 1); ret();                                  /* ret */
        }
    }
}
