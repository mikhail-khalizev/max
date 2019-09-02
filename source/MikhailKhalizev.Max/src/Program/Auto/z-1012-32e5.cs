using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_32e5-9da9be11")]
        public void Method_1012_32e5()
        {
            ii(0x1012_32e5, 5); push(0x70);                             /* push 0x70 */
            ii(0x1012_32ea, 5); call(Definitions.sys_check_available_stack_size, 0x4_2a63); /* call 0x10165d52 */
            ii(0x1012_32ef, 1); push(ebx);                              /* push ebx */
            ii(0x1012_32f0, 1); push(ecx);                              /* push ecx */
            ii(0x1012_32f1, 1); push(edx);                              /* push edx */
            ii(0x1012_32f2, 1); push(esi);                              /* push esi */
            ii(0x1012_32f3, 1); push(edi);                              /* push edi */
            ii(0x1012_32f4, 1); push(ebp);                              /* push ebp */
            ii(0x1012_32f5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_32f7, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1012_32fd, 4); or(memb[ss, ebp - 4], 1);               /* or byte [ebp-0x4], 0x1 */
            ii(0x1012_3301, 5); mov(ebx, 0x6c1);                        /* mov ebx, 0x6c1 */
            ii(0x1012_3306, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_3308, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1012_330b, 5); call(0x1012_13b0, -0x1f60);             /* call 0x101213b0 */
            ii(0x1012_3310, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_3313, 4); and(memb[ss, ebp - 4], -2 /* 0xfe */);  /* and byte [ebp-0x4], 0xfe */
            ii(0x1012_3317, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1012_331a, 5); call(0x1012_31dd, -0x142);              /* call 0x101231dd */
            ii(0x1012_331f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_3321, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1012_3324, 5); call(0x1012_1791, -0x1b98);             /* call 0x10121791 */
            ii(0x1012_3329, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_332b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_332c, 1); pop(edi);                               /* pop edi */
            ii(0x1012_332d, 1); pop(esi);                               /* pop esi */
            ii(0x1012_332e, 1); pop(edx);                               /* pop edx */
            ii(0x1012_332f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_3330, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_3331, 1); ret();                                  /* ret */
        }
    }
}
