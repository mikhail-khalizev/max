using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a66b-cbc83f2a")]
        public void Method_1013_a66b()
        {
            ii(0x1013_a66b, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_a670, 5); call(Definitions.sys_check_available_stack_size, 0x2_b6dd); /* call 0x10165d52 */
            ii(0x1013_a675, 1); push(ebx);                              /* push ebx */
            ii(0x1013_a676, 1); push(ecx);                              /* push ecx */
            ii(0x1013_a677, 1); push(esi);                              /* push esi */
            ii(0x1013_a678, 1); push(edi);                              /* push edi */
            ii(0x1013_a679, 1); push(ebp);                              /* push ebp */
            ii(0x1013_a67a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a67c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_a682, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_a685, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_a688, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_a68b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_a68e, 5); call(0x1013_a21a, -0x479);              /* call 0x1013a21a */
            ii(0x1013_a693, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x1013_a696, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a698, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_a69a, 5); call(0x1007_6d14, -0xc_398b);           /* call 0x10076d14 */
            ii(0x1013_a69f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a6a1, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1013_a6a4, 5); call(0x1013_ad11, 0x668);               /* call 0x1013ad11 */
            ii(0x1013_a6a9, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a6ab, 2); if(jz(0x1013_a6bd, 0x10)) goto l_0x1013_a6bd; /* jz 0x1013a6bd */
            ii(0x1013_a6ad, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1013_a6b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a6b3, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1013_a6b6, 5); call(0x1007_5e24, -0xc_4897);           /* call 0x10075e24 */
            ii(0x1013_a6bb, 2); jmp(0x1013_a6e9, 0x2c); goto l_0x1013_a6e9; /* jmp 0x1013a6e9 */
        l_0x1013_a6bd:
            ii(0x1013_a6bd, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1013_a6c0, 5); call(0x1007_6c68, -0xc_3a5d);           /* call 0x10076c68 */
            ii(0x1013_a6c5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a6c7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_a6ca, 5); call(0x1013_a5af, -0x120);              /* call 0x1013a5af */
            ii(0x1013_a6cf, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1013_a6d3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a6d5, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1013_a6d8, 5); call(0x1007_5e24, -0xc_48b9);           /* call 0x10075e24 */
            ii(0x1013_a6dd, 2); jmp(0x1013_a6e9, 0xa); goto l_0x1013_a6e9; /* jmp 0x1013a6e9 */
        //  ii(0x1013_a6df, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1013_a6e1, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
        //  ii(0x1013_a6e4, 5); call(0x1007_5e24, -0xc_48c5);           /* call 0x10075e24 */
        l_0x1013_a6e9:
            ii(0x1013_a6e9, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1013_a6ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a6ee, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_a6ef, 1); pop(edi);                               /* pop edi */
            ii(0x1013_a6f0, 1); pop(esi);                               /* pop esi */
            ii(0x1013_a6f1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_a6f2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_a6f3, 1); ret();                                  /* ret */
        }
    }
}
