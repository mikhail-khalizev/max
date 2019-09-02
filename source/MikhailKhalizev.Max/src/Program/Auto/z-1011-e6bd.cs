using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_e6bd-3aa1f7e6")]
        public void Method_1011_e6bd()
        {
            ii(0x1011_e6bd, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_e6c2, 5); call(Definitions.sys_check_available_stack_size, 0x4_768b); /* call 0x10165d52 */
            ii(0x1011_e6c7, 1); push(ebx);                              /* push ebx */
            ii(0x1011_e6c8, 1); push(ecx);                              /* push ecx */
            ii(0x1011_e6c9, 1); push(esi);                              /* push esi */
            ii(0x1011_e6ca, 1); push(edi);                              /* push edi */
            ii(0x1011_e6cb, 1); push(ebp);                              /* push ebp */
            ii(0x1011_e6cc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_e6ce, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_e6d4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_e6d7, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_e6da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e6dd, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1011_e6e0, 5); call(0x1012_0894, 0x21af);              /* call 0x10120894 */
            ii(0x1011_e6e5, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x1011_e6e8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e6ea, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_e6ec, 5); call(0x1012_0748, 0x2057);              /* call 0x10120748 */
            ii(0x1011_e6f1, 2); jmp(0x1011_e6fb, 8); goto l_0x1011_e6fb; /* jmp 0x1011e6fb */
        l_0x1011_e6f3:
            ii(0x1011_e6f3, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1011_e6f6, 5); call(0x1007_6bf8, -0xa_7b03);           /* call 0x10076bf8 */
        l_0x1011_e6fb:
            ii(0x1011_e6fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e6fd, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1011_e700, 5); call(0x1013_ad71, 0x1_c66c);            /* call 0x1013ad71 */
            ii(0x1011_e705, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e707, 2); if(jz(0x1011_e730, 0x27)) goto l_0x1011_e730; /* jz 0x1011e730 */
            ii(0x1011_e709, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1011_e70c, 5); call(0x1012_066c, 0x1f5b);              /* call 0x1012066c */
            ii(0x1011_e711, 5); call(Definitions.my__get_unit, -0x6_66fa); /* call 0x100b801c */
            ii(0x1011_e716, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1011_e719, 2); if(jnz(0x1011_e72e, 0x13)) goto l_0x1011_e72e; /* jnz 0x1011e72e */
            ii(0x1011_e71b, 7); mov(memd[ss, ebp - 0x10], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1011_e722, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e724, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1011_e727, 5); call(0x1012_0464, 0x1d38);              /* call 0x10120464 */
            ii(0x1011_e72c, 2); jmp(0x1011_e782, 0x54); goto l_0x1011_e782; /* jmp 0x1011e782 */
        l_0x1011_e72e:
            ii(0x1011_e72e, 2); jmp(0x1011_e6f3, -0x3d); goto l_0x1011_e6f3; /* jmp 0x1011e6f3 */
        l_0x1011_e730:
            ii(0x1011_e730, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e732, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e735, 5); call(0x1013_ad71, 0x1_c637);            /* call 0x1013ad71 */
            ii(0x1011_e73a, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e73c, 2); if(jz(0x1011_e750, 0x12)) goto l_0x1011_e750; /* jz 0x1011e750 */
            ii(0x1011_e73e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e741, 5); call(0x100b_7f18, -0x6_682e);           /* call 0x100b7f18 */
            ii(0x1011_e746, 5); call(Definitions.my__get_unit, -0x6_672f); /* call 0x100b801c */
            ii(0x1011_e74b, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1011_e74e, 2); if(jz(0x1011_e752, 2)) goto l_0x1011_e752; /* jz 0x1011e752 */
        l_0x1011_e750:
            ii(0x1011_e750, 2); jmp(0x1011_e765, 0x13); goto l_0x1011_e765; /* jmp 0x1011e765 */
        l_0x1011_e752:
            ii(0x1011_e752, 7); mov(memd[ss, ebp - 0x10], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1011_e759, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e75b, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1011_e75e, 5); call(0x1012_0464, 0x1d01);              /* call 0x10120464 */
            ii(0x1011_e763, 2); jmp(0x1011_e782, 0x1d); goto l_0x1011_e782; /* jmp 0x1011e782 */
        l_0x1011_e765:
            ii(0x1011_e765, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_e76c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e76e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1011_e771, 5); call(0x1012_0464, 0x1cee);              /* call 0x10120464 */
            ii(0x1011_e776, 2); jmp(0x1011_e782, 0xa); goto l_0x1011_e782; /* jmp 0x1011e782 */
        //  ii(0x1011_e778, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1011_e77a, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
        //  ii(0x1011_e77d, 5); call(0x1012_0464, 0x1ce2);              /* call 0x10120464 */
        l_0x1011_e782:
            ii(0x1011_e782, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_e785, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_e787, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_e788, 1); pop(edi);                               /* pop edi */
            ii(0x1011_e789, 1); pop(esi);                               /* pop esi */
            ii(0x1011_e78a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_e78b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_e78c, 1); ret();                                  /* ret */
        }
    }
}
