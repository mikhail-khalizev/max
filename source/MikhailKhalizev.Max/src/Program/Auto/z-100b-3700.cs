using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3700-753fa5df")]
        public void Method_100b_3700()
        {
            ii(0x100b_3700, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_3705, 5); call(Definitions.sys_check_available_stack_size, 0xb_2648); /* call 0x10165d52 */
            ii(0x100b_370a, 1); push(ecx);                              /* push ecx */
            ii(0x100b_370b, 1); push(esi);                              /* push esi */
            ii(0x100b_370c, 1); push(edi);                              /* push edi */
            ii(0x100b_370d, 1); push(ebp);                              /* push ebp */
            ii(0x100b_370e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3710, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_3716, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_3719, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_371c, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100b_371f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_3722, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_3725, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3727, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_372a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_372d, 5); call(0x1013_ad71, 0x8_763f);            /* call 0x1013ad71 */
            ii(0x100b_3732, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3734, 2); if(jz(0x100b_3754, 0x1e)) goto l_0x100b_3754; /* jz 0x100b3754 */
            ii(0x100b_3736, 4); cmp(memb[ss, ebp - 4], 3);              /* cmp byte [ebp-0x4], 0x3 */
            ii(0x100b_373a, 2); if(jz(0x100b_3742, 6)) goto l_0x100b_3742; /* jz 0x100b3742 */
            ii(0x100b_373c, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_3740, 2); if(jnz(0x100b_374c, 0xa)) goto l_0x100b_374c; /* jnz 0x100b374c */
        l_0x100b_3742:
            ii(0x100b_3742, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_3745, 5); call(0x100b_375b, 0x11);                /* call 0x100b375b */
            ii(0x100b_374a, 2); jmp(0x100b_3754, 8); goto l_0x100b_3754; /* jmp 0x100b3754 */
        l_0x100b_374c:
            ii(0x100b_374c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_374f, 5); call(0x100b_33a4, -0x3b0);              /* call 0x100b33a4 */
        l_0x100b_3754:
            ii(0x100b_3754, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3756, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_3757, 1); pop(edi);                               /* pop edi */
            ii(0x100b_3758, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3759, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_375a, 1); ret();                                  /* ret */
        }
    }
}
