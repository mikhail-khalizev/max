using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f659-1d68d97")]
        public void Method_1007_f659()
        {
            ii(0x1007_f659, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_f65e, 5); call(Definitions.sys_check_available_stack_size, 0xe_66ef); /* call 0x10165d52 */
            ii(0x1007_f663, 1); push(ebx);                              /* push ebx */
            ii(0x1007_f664, 1); push(ecx);                              /* push ecx */
            ii(0x1007_f665, 1); push(edx);                              /* push edx */
            ii(0x1007_f666, 1); push(esi);                              /* push esi */
            ii(0x1007_f667, 1); push(edi);                              /* push edi */
            ii(0x1007_f668, 1); push(ebp);                              /* push ebp */
            ii(0x1007_f669, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f66b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_f671, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_f674, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f677, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1007_f67a, 5); call(0x1007_6338, -0x9347);             /* call 0x10076338 */
            ii(0x1007_f67f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_f681, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f684, 5); call(0x1007_64b8, -0x91d1);             /* call 0x100764b8 */
            ii(0x1007_f689, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_f68c, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f68f, 5); call(0x1008_b060, 0xb9cc);              /* call 0x1008b060 */
            ii(0x1007_f694, 2); jmp(0x1007_f69e, 0x8); goto l_0x1007_f69e; /* jmp 0x1007f69e */
        l_0x1007_f696:
            ii(0x1007_f696, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f699, 5); call(0x1007_6bf8, -0x8aa6);             /* call 0x10076bf8 */
        l_0x1007_f69e:
            ii(0x1007_f69e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f6a0, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f6a3, 5); call(0x1013_ad71, 0xb_b6c9);            /* call 0x1013ad71 */
            ii(0x1007_f6a8, 2); test(al, al);                           /* test al, al */
            ii(0x1007_f6aa, 2); if(jz(0x1007_f6d4, 0x28)) goto l_0x1007_f6d4; /* jz 0x1007f6d4 */
            ii(0x1007_f6ac, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f6af, 5); call(0x1007_63d4, -0x92e0);             /* call 0x100763d4 */
            ii(0x1007_f6b4, 5); call(0x100a_b50c, 0x2_be53);            /* call 0x100ab50c */
            ii(0x1007_f6b9, 5); call(0x1008_ac50, 0xb592);              /* call 0x1008ac50 */
            ii(0x1007_f6be, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_f6c0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_f6c2, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_f6c5, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f6c8, 5); call(0x1007_63a0, -0x932d);             /* call 0x100763a0 */
            ii(0x1007_f6cd, 5); call(0x1015_2962, 0xd_3290);            /* call 0x10152962 */
            ii(0x1007_f6d2, 2); jmp(0x1007_f696, -0x3e); goto l_0x1007_f696; /* jmp 0x1007f696 */
        l_0x1007_f6d4:
            ii(0x1007_f6d4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f6d7, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1007_f6da, 5); call(0x1013_a6f4, 0xb_b015);            /* call 0x1013a6f4 */
            ii(0x1007_f6df, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f6e2, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1007_f6e5, 5); call(0x1007_6338, -0x93b2);             /* call 0x10076338 */
            ii(0x1007_f6ea, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x1007_f6ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_f6ef, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_f6f1, 5); call(0x1007_643c, -0x92ba);             /* call 0x1007643c */
            ii(0x1007_f6f6, 2); jmp(0x1007_f700, 0x8); goto l_0x1007_f700; /* jmp 0x1007f700 */
        l_0x1007_f6f8:
            ii(0x1007_f6f8, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f6fb, 5); call(0x1007_6bf8, -0x8b08);             /* call 0x10076bf8 */
        l_0x1007_f700:
            ii(0x1007_f700, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f702, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f705, 5); call(0x1013_ad71, 0xb_b667);            /* call 0x1013ad71 */
            ii(0x1007_f70a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_f70c, 2); if(jz(0x1007_f736, 0x28)) goto l_0x1007_f736; /* jz 0x1007f736 */
            ii(0x1007_f70e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f711, 5); call(0x1007_63d4, -0x9342);             /* call 0x100763d4 */
            ii(0x1007_f716, 5); call(0x100a_b50c, 0x2_bdf1);            /* call 0x100ab50c */
            ii(0x1007_f71b, 5); call(0x1008_ac50, 0xb530);              /* call 0x1008ac50 */
            ii(0x1007_f720, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_f722, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_f724, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_f727, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f72a, 5); call(0x1007_63a0, -0x938f);             /* call 0x100763a0 */
            ii(0x1007_f72f, 5); call(0x1015_2962, 0xd_322e);            /* call 0x10152962 */
            ii(0x1007_f734, 2); jmp(0x1007_f6f8, -0x3e); goto l_0x1007_f6f8; /* jmp 0x1007f6f8 */
        l_0x1007_f736:
            ii(0x1007_f736, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f739, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1007_f73c, 5); call(0x1013_a6f4, 0xb_afb3);            /* call 0x1013a6f4 */
            ii(0x1007_f741, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_f744, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_f749, 5); call(0x100a_5e27, 0x2_66d9);            /* call 0x100a5e27 */
            ii(0x1007_f74e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f750, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f753, 5); call(0x1008_8b7c, 0x9424);              /* call 0x10088b7c */
            ii(0x1007_f758, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f75a, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1007_f75d, 5); call(0x1007_5f6c, -0x97f6);             /* call 0x10075f6c */
            ii(0x1007_f762, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f764, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_f765, 1); pop(edi);                               /* pop edi */
            ii(0x1007_f766, 1); pop(esi);                               /* pop esi */
            ii(0x1007_f767, 1); pop(edx);                               /* pop edx */
            ii(0x1007_f768, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_f769, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_f76a, 1); ret();                                  /* ret */
        }
    }
}
