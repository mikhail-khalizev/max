using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_06b0-67e31b6d")]
        public void Method_1014_06b0()
        {
            ii(0x1014_06b0, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_06b5, 5); call(Definitions.sys_check_available_stack_size, 0x2_5698); /* call 0x10165d52 */
            ii(0x1014_06ba, 1); push(ebx);                              /* push ebx */
            ii(0x1014_06bb, 1); push(ecx);                              /* push ecx */
            ii(0x1014_06bc, 1); push(esi);                              /* push esi */
            ii(0x1014_06bd, 1); push(edi);                              /* push edi */
            ii(0x1014_06be, 1); push(ebp);                              /* push ebp */
            ii(0x1014_06bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_06c1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_06c7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_06ca, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_06cd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_06d0, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x1014_06d3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_06d6, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1014_06d9, 2); if(jg(0x1014_06f4, 0x19)) goto l_0x1014_06f4; /* jg 0x101406f4 */
            ii(0x1014_06db, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_06de, 3); mov(edx, memd[ds, eax + 0x36]);         /* mov edx, [eax+0x36] */
            ii(0x1014_06e1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_06e4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_06e7, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x1014_06ea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_06ed, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_06ef, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1014_06f2, 2); if(jg(0x1014_06f9, 5)) goto l_0x1014_06f9; /* jg 0x101406f9 */
        l_0x1014_06f4:
            ii(0x1014_06f4, 5); jmp(0x1014_076f, 0x76); goto l_0x1014_076f; /* jmp 0x1014076f */
        l_0x1014_06f9:
            ii(0x1014_06f9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_06fc, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_06ff, 4); add(dx, memw[ds, eax + 0x26]);          /* add dx, [eax+0x26] */
            ii(0x1014_0703, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0706, 4); sub(dx, memw[ds, eax + 0x38]);          /* sub dx, [eax+0x38] */
            ii(0x1014_070a, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x1014_070d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0710, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0713, 5); call(Definitions.my_1_get_count, -0x9_5240); /* call 0x100ab4d8 */
            ii(0x1014_0718, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x1014_071c, 2); if(jg(0x1014_0727, 9)) goto l_0x1014_0727; /* jg 0x10140727 */
            ii(0x1014_071e, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1014_0722, 5); jmp(0x1014_083a, 0x113); goto l_0x1014_083a; /* jmp 0x1014083a */
        l_0x1014_0727:
            ii(0x1014_0727, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_072a, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_072d, 4); cmp(ax, memw[ds, edx + 0x28]);          /* cmp ax, [edx+0x28] */
            ii(0x1014_0731, 2); if(jnz(0x1014_0736, 3)) goto l_0x1014_0736; /* jnz 0x10140736 */
            ii(0x1014_0733, 1); int3();                                 /* int3 */
            ii(0x1014_0734, 2); jmp(0x1014_0766, 0x30); goto l_0x1014_0766; /* jmp 0x10140766 */
        l_0x1014_0736:
            ii(0x1014_0736, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0739, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_073c, 4); mov(memw[ds, edx + 0x28], ax);          /* mov [edx+0x28], ax */
            ii(0x1014_0740, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0743, 3); mov(edx, memd[ds, eax + 0x26]);         /* mov edx, [eax+0x26] */
            ii(0x1014_0746, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_0749, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_074c, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_074f, 5); call(0x1014_159c, 0xe48);               /* call 0x1014159c */
            ii(0x1014_0754, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0756, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0759, 5); call(0x1014_0bcd, 0x46f);               /* call 0x10140bcd */
            ii(0x1014_075e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0761, 5); call(0x1014_0958, 0x1f2);               /* call 0x10140958 */
        l_0x1014_0766:
            ii(0x1014_0766, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1014_076a, 5); jmp(0x1014_083a, 0xcb); goto l_0x1014_083a; /* jmp 0x1014083a */
        l_0x1014_076f:
            ii(0x1014_076f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0772, 3); mov(eax, memd[ds, eax + 0x3a]);         /* mov eax, [eax+0x3a] */
            ii(0x1014_0775, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_0778, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1014_077b, 6); if(jnz(0x1014_07f5, 0x74)) goto l_0x1014_07f5; /* jnz 0x101407f5 */
            ii(0x1014_0781, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0784, 4); mov(dx, memw[ds, eax + 0x2a]);          /* mov dx, [eax+0x2a] */
            ii(0x1014_0788, 1); dec(edx);                               /* dec edx */
            ii(0x1014_0789, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_078c, 4); add(memw[ds, eax + 0x26], dx);          /* add [eax+0x26], dx */
            ii(0x1014_0790, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0793, 3); mov(edx, memd[ds, eax + 0x24]);         /* mov edx, [eax+0x24] */
            ii(0x1014_0796, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_0799, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_079c, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x1014_079f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_07a2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_07a4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_07a7, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_07aa, 5); call(Definitions.my_1_get_count, -0x9_52d7); /* call 0x100ab4d8 */
            ii(0x1014_07af, 1); cwde();                                 /* cwde */
            ii(0x1014_07b0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_07b2, 2); if(jle(0x1014_07e7, 0x33)) goto l_0x1014_07e7; /* jle 0x101407e7 */
            ii(0x1014_07b4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_07b7, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_07ba, 5); call(Definitions.my_1_get_count, -0x9_52e7); /* call 0x100ab4d8 */
            ii(0x1014_07bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_07c1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_07c4, 4); mov(bx, memw[ds, eax + 0x2a]);          /* mov bx, [eax+0x2a] */
            ii(0x1014_07c8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_07cb, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1014_07cd, 4); mov(memw[ds, eax + 0x26], dx);          /* mov [eax+0x26], dx */
            ii(0x1014_07d1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_07d4, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x1014_07d7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_07da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_07dc, 2); if(jge(0x1014_07e7, 9)) goto l_0x1014_07e7; /* jge 0x101407e7 */
            ii(0x1014_07de, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_07e1, 6); mov(memw[ds, eax + 0x26], 0);           /* mov word [eax+0x26], 0x0 */
        l_0x1014_07e7:
            ii(0x1014_07e7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_07ea, 5); call(0x1014_0958, 0x169);               /* call 0x10140958 */
            ii(0x1014_07ef, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1014_07f3, 2); jmp(0x1014_083a, 0x45); goto l_0x1014_083a; /* jmp 0x1014083a */
        l_0x1014_07f5:
            ii(0x1014_07f5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_07f8, 3); mov(eax, memd[ds, eax + 0x38]);         /* mov eax, [eax+0x38] */
            ii(0x1014_07fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_07fe, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1014_0801, 2); if(jnz(0x1014_0836, 0x33)) goto l_0x1014_0836; /* jnz 0x10140836 */
            ii(0x1014_0803, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0806, 4); mov(dx, memw[ds, eax + 0x2a]);          /* mov dx, [eax+0x2a] */
            ii(0x1014_080a, 1); dec(edx);                               /* dec edx */
            ii(0x1014_080b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_080e, 4); sub(memw[ds, eax + 0x26], dx);          /* sub [eax+0x26], dx */
            ii(0x1014_0812, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0815, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x1014_0818, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_081b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_081d, 2); if(jge(0x1014_0828, 9)) goto l_0x1014_0828; /* jge 0x10140828 */
            ii(0x1014_081f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0822, 6); mov(memw[ds, eax + 0x26], 0);           /* mov word [eax+0x26], 0x0 */
        l_0x1014_0828:
            ii(0x1014_0828, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_082b, 5); call(0x1014_0958, 0x128);               /* call 0x10140958 */
            ii(0x1014_0830, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1014_0834, 2); jmp(0x1014_083a, 4); goto l_0x1014_083a; /* jmp 0x1014083a */
        l_0x1014_0836:
            ii(0x1014_0836, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1014_083a:
            ii(0x1014_083a, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1014_083d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_083f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_0840, 1); pop(edi);                               /* pop edi */
            ii(0x1014_0841, 1); pop(esi);                               /* pop esi */
            ii(0x1014_0842, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_0843, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_0844, 1); ret();                                  /* ret */
        }
    }
}
