using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_79b2-6957db3")]
        public void Method_1008_79b2()
        {
            ii(0x1008_79b2, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_79b7, 5); call(Definitions.sys_check_available_stack_size, 0xd_e396); /* call 0x10165d52 */
            ii(0x1008_79bc, 1); push(ebx);                              /* push ebx */
            ii(0x1008_79bd, 1); push(ecx);                              /* push ecx */
            ii(0x1008_79be, 1); push(edx);                              /* push edx */
            ii(0x1008_79bf, 1); push(esi);                              /* push esi */
            ii(0x1008_79c0, 1); push(edi);                              /* push edi */
            ii(0x1008_79c1, 1); push(ebp);                              /* push ebp */
            ii(0x1008_79c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_79c4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_79ca, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_79cd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_79d0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_79d3, 5); call(0x1007_6338, -0x1_16a0);           /* call 0x10076338 */
            ii(0x1008_79d8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_79da, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_79dd, 5); call(0x1007_64b8, -0x1_152a);           /* call 0x100764b8 */
            ii(0x1008_79e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_79e4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_79e7, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_79ea, 5); call(0x1008_afe4, 0x35f5);              /* call 0x1008afe4 */
            ii(0x1008_79ef, 2); jmp(0x1008_79f9, 0x8); goto l_0x1008_79f9; /* jmp 0x100879f9 */
        l_0x1008_79f1:
            ii(0x1008_79f1, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_79f4, 5); call(0x1007_6bf8, -0x1_0e01);           /* call 0x10076bf8 */
        l_0x1008_79f9:
            ii(0x1008_79f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_79fb, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_79fe, 5); call(0x1013_ad71, 0xb_336e);            /* call 0x1013ad71 */
            ii(0x1008_7a03, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7a05, 2); if(jz(0x1008_7a26, 0x1f)) goto l_0x1008_7a26; /* jz 0x10087a26 */
            ii(0x1008_7a07, 5); call(0x1008_a79c, 0x2d90);              /* call 0x1008a79c */
            ii(0x1008_7a0c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_7a0e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_7a10, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_7a13, 5); call(0x1007_63d4, -0x1_1644);           /* call 0x100763d4 */
            ii(0x1008_7a18, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_7a1a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_7a1f, 5); call(0x100a_53ac, 0x1_d988);            /* call 0x100a53ac */
            ii(0x1008_7a24, 2); jmp(0x1008_79f1, -0x35); goto l_0x1008_79f1; /* jmp 0x100879f1 */
        l_0x1008_7a26:
            ii(0x1008_7a26, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7a29, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7a2c, 5); call(0x1013_a6f4, 0xb_2cc3);            /* call 0x1013a6f4 */
            ii(0x1008_7a31, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_7a34, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_7a39, 5); call(0x100a_5e27, 0x1_e3e9);            /* call 0x100a5e27 */
            ii(0x1008_7a3e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7a40, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_7a43, 5); call(0x1007_5f6c, -0x1_1adc);           /* call 0x10075f6c */
            ii(0x1008_7a48, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7a4a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_7a4b, 1); pop(edi);                               /* pop edi */
            ii(0x1008_7a4c, 1); pop(esi);                               /* pop esi */
            ii(0x1008_7a4d, 1); pop(edx);                               /* pop edx */
            ii(0x1008_7a4e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_7a4f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_7a50, 1); ret();                                  /* ret */
        }
    }
}
