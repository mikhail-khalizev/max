using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_27ed-ecb85156")]
        public void Method_1015_27ed()
        {
            ii(0x1015_27ed, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_27f2, 5); call(Definitions.sys_check_available_stack_size, 0x1_355b); /* call 0x10165d52 */
            ii(0x1015_27f7, 1); push(ebx);                              /* push ebx */
            ii(0x1015_27f8, 1); push(ecx);                              /* push ecx */
            ii(0x1015_27f9, 1); push(esi);                              /* push esi */
            ii(0x1015_27fa, 1); push(edi);                              /* push edi */
            ii(0x1015_27fb, 1); push(ebp);                              /* push ebp */
            ii(0x1015_27fc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_27fe, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_2804, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_2807, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_280a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_280d, 5); call(0x1015_26ac, -0x166);              /* call 0x101526ac */
            ii(0x1015_2812, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x1015_2815, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_2817, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_2819, 5); call(0x1008_b060, -0xc_77be);           /* call 0x1008b060 */
            ii(0x1015_281e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_2821, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_2824, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_2829, 5); call(0x1015_51d4, 0x29a6);              /* call 0x101551d4 */
            ii(0x1015_282e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2830, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1015_2833, 5); call(0x1008_8b7c, -0xc_9cbc);           /* call 0x10088b7c */
            ii(0x1015_2838, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_283a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_283b, 1); pop(edi);                               /* pop edi */
            ii(0x1015_283c, 1); pop(esi);                               /* pop esi */
            ii(0x1015_283d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_283e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_283f, 1); ret();                                  /* ret */
        }
    }
}
