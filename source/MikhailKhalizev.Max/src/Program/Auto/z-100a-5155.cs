using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_5155-3ba221a5")]
        public void Method_100a_5155()
        {
            ii(0x100a_5155, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_515a, 5); call(Definitions.sys_check_available_stack_size, 0xc_0bf3); /* call 0x10165d52 */
            ii(0x100a_515f, 1); push(ebx);                              /* push ebx */
            ii(0x100a_5160, 1); push(ecx);                              /* push ecx */
            ii(0x100a_5161, 1); push(esi);                              /* push esi */
            ii(0x100a_5162, 1); push(edi);                              /* push edi */
            ii(0x100a_5163, 1); push(ebp);                              /* push ebp */
            ii(0x100a_5164, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_5166, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_516c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_516f, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_5172, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5175, 5); call(0x1008_aef4, -0x1_a286);           /* call 0x1008aef4 */
            ii(0x100a_517a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_517c, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_517f, 5); call(0x1008_ae70, -0x1_a314);           /* call 0x1008ae70 */
            ii(0x100a_5184, 2); jmp(0x100a_518e, 0x8); goto l_0x100a_518e; /* jmp 0x100a518e */
        l_0x100a_5186:
            ii(0x100a_5186, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_5189, 5); call(0x1007_6bf8, -0x2_e596);           /* call 0x10076bf8 */
        l_0x100a_518e:
            ii(0x100a_518e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5190, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_5193, 5); call(0x1013_ad71, 0x9_5bd9);            /* call 0x1013ad71 */
            ii(0x100a_5198, 2); test(al, al);                           /* test al, al */
            ii(0x100a_519a, 2); if(jz(0x100a_51c7, 0x2b)) goto l_0x100a_51c7; /* jz 0x100a51c7 */
            ii(0x100a_519c, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_519f, 5); call(0x1008_adc4, -0x1_a3e0);           /* call 0x1008adc4 */
            ii(0x100a_51a4, 5); call(0x1008_ad90, -0x1_a419);           /* call 0x1008ad90 */
            ii(0x100a_51a9, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100a_51ad, 2); if(jnz(0x100a_51c5, 0x16)) goto l_0x100a_51c5; /* jnz 0x100a51c5 */
            ii(0x100a_51af, 5); call(0x100a_b288, 0x60d4);              /* call 0x100ab288 */
            ii(0x100a_51b4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_51b6, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_51b8, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_51bb, 5); call(0x1008_adc4, -0x1_a3fc);           /* call 0x1008adc4 */
            ii(0x100a_51c0, 5); call(0x100a_28ff, -0x28c6);             /* call 0x100a28ff */
        l_0x100a_51c5:
            ii(0x100a_51c5, 2); jmp(0x100a_5186, -0x41); goto l_0x100a_5186; /* jmp 0x100a5186 */
        l_0x100a_51c7:
            ii(0x100a_51c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_51c9, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_51cc, 5); call(0x1008_8bbc, -0x1_c615);           /* call 0x10088bbc */
            ii(0x100a_51d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_51d3, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_51d4, 1); pop(edi);                               /* pop edi */
            ii(0x100a_51d5, 1); pop(esi);                               /* pop esi */
            ii(0x100a_51d6, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_51d7, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_51d8, 1); ret();                                  /* ret */
        }
    }
}
