using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c5e6-4d053502")]
        public void Method_100a_c5e6()
        {
            ii(0x100a_c5e6, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_c5eb, 5); call(Definitions.sys_check_available_stack_size, 0xb_9762); /* call 0x10165d52 */
            ii(0x100a_c5f0, 1); push(ebx);                              /* push ebx */
            ii(0x100a_c5f1, 1); push(ecx);                              /* push ecx */
            ii(0x100a_c5f2, 1); push(edx);                              /* push edx */
            ii(0x100a_c5f3, 1); push(esi);                              /* push esi */
            ii(0x100a_c5f4, 1); push(edi);                              /* push edi */
            ii(0x100a_c5f5, 1); push(ebp);                              /* push ebp */
            ii(0x100a_c5f6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c5f8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_c5fe, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_c601, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c603, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c606, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c609, 5); call(0x1013_ad71, 0x8_e763);            /* call 0x1013ad71 */
            ii(0x100a_c60e, 2); test(al, al);                           /* test al, al */
            ii(0x100a_c610, 2); if(jz(0x100a_c62e, 0x1c)) goto l_0x100a_c62e; /* jz 0x100ac62e */
            ii(0x100a_c612, 5); call(0x1008_ac50, -0x2_19c7);           /* call 0x1008ac50 */
            ii(0x100a_c617, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_c619, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_c61b, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_c61e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c621, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c624, 5); call(0x1007_6574, -0x3_60b5);           /* call 0x10076574 */
            ii(0x100a_c629, 5); call(0x1015_2962, 0xa_6334);            /* call 0x10152962 */
        l_0x100a_c62e:
            ii(0x100a_c62e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c630, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c633, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c636, 5); call(0x1007_6630, -0x3_600b);           /* call 0x10076630 */
            ii(0x100a_c63b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c63d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c640, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_c643, 5); call(0x1009_c8f8, -0xfd50);             /* call 0x1009c8f8 */
            ii(0x100a_c648, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c64a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c64d, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_c650, 5); call(0x1008_afe4, -0x2_1671);           /* call 0x1008afe4 */
            ii(0x100a_c655, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_c658, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_c65d, 5); call(0x100a_5e27, -0x683b);             /* call 0x100a5e27 */
            ii(0x100a_c662, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c664, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_c665, 1); pop(edi);                               /* pop edi */
            ii(0x100a_c666, 1); pop(esi);                               /* pop esi */
            ii(0x100a_c667, 1); pop(edx);                               /* pop edx */
            ii(0x100a_c668, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_c669, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_c66a, 1); ret();                                  /* ret */
        }
    }
}
