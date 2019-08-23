using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2605-12564efa")]
        public void Method_1015_2605()
        {
            ii(0x1015_2605, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_260a, 5); call(Definitions.sys_check_available_stack_size, 0x1_3743); /* call 0x10165d52 */
            ii(0x1015_260f, 1); push(ebx);                              /* push ebx */
            ii(0x1015_2610, 1); push(ecx);                              /* push ecx */
            ii(0x1015_2611, 1); push(esi);                              /* push esi */
            ii(0x1015_2612, 1); push(edi);                              /* push edi */
            ii(0x1015_2613, 1); push(ebp);                              /* push ebp */
            ii(0x1015_2614, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2616, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_261c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_261f, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1015_2622, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2625, 7); cmp(memb[ds, eax + 0xa5], 0);           /* cmp byte [eax+0xa5], 0x0 */
            ii(0x1015_262c, 2); if(jz(0x1015_267d, 0x4f)) goto l_0x1015_267d; /* jz 0x1015267d */
            ii(0x1015_262e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2631, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1015_2636, 5); call(0x1008_aef4, -0xc_7747);           /* call 0x1008aef4 */
            ii(0x1015_263b, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1015_263e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_2640, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_2642, 5); call(0x1008_ae70, -0xc_77d7);           /* call 0x1008ae70 */
            ii(0x1015_2647, 2); jmp(0x1015_2651, 0x8); goto l_0x1015_2651; /* jmp 0x10152651 */
        l_0x1015_2649:
            ii(0x1015_2649, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_264c, 5); call(0x1007_6bf8, -0xd_ba59);           /* call 0x10076bf8 */
        l_0x1015_2651:
            ii(0x1015_2651, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2653, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_2656, 5); call(0x1013_ad71, -0x1_78ea);           /* call 0x1013ad71 */
            ii(0x1015_265b, 2); test(al, al);                           /* test al, al */
            ii(0x1015_265d, 2); if(jz(0x1015_2673, 0x14)) goto l_0x1015_2673; /* jz 0x10152673 */
            ii(0x1015_265f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_2664, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_2667, 5); call(0x1008_adc4, -0xc_78a8);           /* call 0x1008adc4 */
            ii(0x1015_266c, 5); call(0x100a_28ff, -0xa_fd72);           /* call 0x100a28ff */
            ii(0x1015_2671, 2); jmp(0x1015_2649, -0x2a); goto l_0x1015_2649; /* jmp 0x10152649 */
        l_0x1015_2673:
            ii(0x1015_2673, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2675, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_2678, 5); call(0x1008_8bbc, -0xc_9ac1);           /* call 0x10088bbc */
        l_0x1015_267d:
            ii(0x1015_267d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2680, 5); call(0x1015_26ac, 0x27);                /* call 0x101526ac */
            ii(0x1015_2685, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_2687, 2); if(jz(0x1015_2695, 0xc)) goto l_0x1015_2695; /* jz 0x10152695 */
            ii(0x1015_2689, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_268c, 7); cmp(memb[ds, eax + 0xa5], 0);           /* cmp byte [eax+0xa5], 0x0 */
            ii(0x1015_2693, 2); if(jnz(0x1015_2697, 0x2)) goto l_0x1015_2697; /* jnz 0x10152697 */
        l_0x1015_2695:
            ii(0x1015_2695, 2); jmp(0x1015_26a4, 0xd); goto l_0x1015_26a4; /* jmp 0x101526a4 */
        l_0x1015_2697:
            ii(0x1015_2697, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2699, 3); mov(dl, memb[ss, ebp - 0x4]);           /* mov dl, [ebp-0x4] */
            ii(0x1015_269c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_269f, 5); call(0x100a_297d, -0xa_fd27);           /* call 0x100a297d */
        l_0x1015_26a4:
            ii(0x1015_26a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_26a6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_26a7, 1); pop(edi);                               /* pop edi */
            ii(0x1015_26a8, 1); pop(esi);                               /* pop esi */
            ii(0x1015_26a9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_26aa, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_26ab, 1); ret();                                  /* ret */
        }
    }
}
