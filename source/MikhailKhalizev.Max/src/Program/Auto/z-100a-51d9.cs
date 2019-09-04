using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_51d9-83858494")]
        public void Method_100a_51d9()
        {
            ii(0x100a_51d9, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100a_51de, 5); call(Definitions.sys_check_available_stack_size, 0xc_0b6f); /* call 0x10165d52 */
            ii(0x100a_51e3, 1); push(ebx);                              /* push ebx */
            ii(0x100a_51e4, 1); push(ecx);                              /* push ecx */
            ii(0x100a_51e5, 1); push(esi);                              /* push esi */
            ii(0x100a_51e6, 1); push(edi);                              /* push edi */
            ii(0x100a_51e7, 1); push(ebp);                              /* push ebp */
            ii(0x100a_51e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_51ea, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_51f0, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_51f3, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_51f6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_51f9, 5); call(0x1008_aef4, -0x1_a30a);           /* call 0x1008aef4 */
            ii(0x100a_51fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_5200, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_5203, 5); call(0x1008_ae70, -0x1_a398);           /* call 0x1008ae70 */
            ii(0x100a_5208, 2); jmp(0x100a_5212, 8); goto l_0x100a_5212; /* jmp 0x100a5212 */
        l_0x100a_520a:
            ii(0x100a_520a, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_520d, 5); call(0x1007_6bf8, -0x2_e61a);           /* call 0x10076bf8 */
        l_0x100a_5212:
            ii(0x100a_5212, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5214, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_5217, 5); call(0x1013_ad71, 0x9_5b55);            /* call 0x1013ad71 */
            ii(0x100a_521c, 2); test(al, al);                           /* test al, al */
            ii(0x100a_521e, 2); if(jz(0x100a_5262, 0x42)) goto l_0x100a_5262; /* jz 0x100a5262 */
            ii(0x100a_5220, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_5223, 5); call(0x1008_adc4, -0x1_a464);           /* call 0x1008adc4 */
            ii(0x100a_5228, 5); call(0x1008_ad90, -0x1_a49d);           /* call 0x1008ad90 */
            ii(0x100a_522d, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x100a_5231, 2); if(jnz(0x100a_524e, 0x1b)) goto l_0x100a_524e; /* jnz 0x100a524e */
            ii(0x100a_5233, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_5236, 5); call(0x1008_adc4, -0x1_a477);           /* call 0x1008adc4 */
            ii(0x100a_523b, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_523e, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_5241, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_5244, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_5247, 3); call_abs(memd[ds, edx + 40]);           /* call dword [edx+0x28] */
            ii(0x100a_524a, 2); test(al, al);                           /* test al, al */
            ii(0x100a_524c, 2); if(jnz(0x100a_5250, 2)) goto l_0x100a_5250; /* jnz 0x100a5250 */
        l_0x100a_524e:
            ii(0x100a_524e, 2); jmp(0x100a_5260, 0x10); goto l_0x100a_5260; /* jmp 0x100a5260 */
        l_0x100a_5250:
            ii(0x100a_5250, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_5254, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5256, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_5259, 5); call(0x1008_8bbc, -0x1_c6a2);           /* call 0x10088bbc */
            ii(0x100a_525e, 2); jmp(0x100a_527c, 0x1c); goto l_0x100a_527c; /* jmp 0x100a527c */
        l_0x100a_5260:
            ii(0x100a_5260, 2); jmp(0x100a_520a, -0x58); goto l_0x100a_520a; /* jmp 0x100a520a */
        l_0x100a_5262:
            ii(0x100a_5262, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_5266, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5268, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_526b, 5); call(0x1008_8bbc, -0x1_c6b4);           /* call 0x10088bbc */
            ii(0x100a_5270, 2); jmp(0x100a_527c, 0xa); goto l_0x100a_527c; /* jmp 0x100a527c */
        //  ii(0x100a_5272, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_5274, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
        //  ii(0x100a_5277, 5); call(0x1008_8bbc, -0x1_c6c0);           /* call 0x10088bbc */
        l_0x100a_527c:
            ii(0x100a_527c, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100a_527f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_5281, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_5282, 1); pop(edi);                               /* pop edi */
            ii(0x100a_5283, 1); pop(esi);                               /* pop esi */
            ii(0x100a_5284, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_5285, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_5286, 1); ret();                                  /* ret */
        }
    }
}
