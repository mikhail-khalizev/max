using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c53d-7fcf2157")]
        public void Method_100e_c53d()
        {
            ii(0x100e_c53d, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_c542, 5); call(Definitions.sys_check_available_stack_size, 0x7_980b); /* call 0x10165d52 */
            ii(0x100e_c547, 1); push(esi);                              /* push esi */
            ii(0x100e_c548, 1); push(edi);                              /* push edi */
            ii(0x100e_c549, 1); push(ebp);                              /* push ebp */
            ii(0x100e_c54a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_c54c, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_c552, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_c555, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100e_c558, 3); mov(memd[ss, ebp - 0x10], ebx);         /* mov [ebp-0x10], ebx */
            ii(0x100e_c55b, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x100e_c55e, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_c563, 5); call(0x1007_6338, -0x7_6230);           /* call 0x10076338 */
            ii(0x100e_c568, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_c56a, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c56d, 5); call(0x1007_64b8, -0x7_60ba);           /* call 0x100764b8 */
            ii(0x100e_c572, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_c575, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x100e_c57a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_c57d, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x100e_c582, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_c585, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x100e_c58a, 2); jmp(0x100e_c594, 8); goto l_0x100e_c594; /* jmp 0x100ec594 */
        l_0x100e_c58c:
            ii(0x100e_c58c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c58f, 5); call(0x1007_6bf8, -0x7_599c);           /* call 0x10076bf8 */
        l_0x100e_c594:
            ii(0x100e_c594, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c596, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c599, 5); call(0x1013_ad71, 0x4_e7d3);            /* call 0x1013ad71 */
            ii(0x100e_c59e, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c5a0, 6); if(jz(0x100e_c61a, 0x74)) goto l_0x100e_c61a; /* jz 0x100ec61a */
            ii(0x100e_c5a6, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c5a9, 5); call(0x1007_63a0, -0x7_620e);           /* call 0x100763a0 */
            ii(0x100e_c5ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c5b0, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100e_c5b3, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c5b7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_c5b9, 2); if(jnz(0x100e_c5ca, 0xf)) goto l_0x100e_c5ca; /* jnz 0x100ec5ca */
            ii(0x100e_c5bb, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c5be, 5); call(0x1007_63a0, -0x7_6223);           /* call 0x100763a0 */
            ii(0x100e_c5c3, 5); cmp(memw[ds, eax + 8], 0x28);           /* cmp word [eax+0x8], 0x28 */
            ii(0x100e_c5c8, 2); if(jz(0x100e_c5cc, 2)) goto l_0x100e_c5cc; /* jz 0x100ec5cc */
        l_0x100e_c5ca:
            ii(0x100e_c5ca, 2); jmp(0x100e_c5da, 0xe); goto l_0x100e_c5da; /* jmp 0x100ec5da */
        l_0x100e_c5cc:
            ii(0x100e_c5cc, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c5cf, 5); call(0x1007_63a0, -0x7_6234);           /* call 0x100763a0 */
            ii(0x100e_c5d4, 4); cmp(memb[ds, eax + 0x3d], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100e_c5d8, 2); if(jz(0x100e_c5dc, 2)) goto l_0x100e_c5dc; /* jz 0x100ec5dc */
        l_0x100e_c5da:
            ii(0x100e_c5da, 2); jmp(0x100e_c615, 0x39); goto l_0x100e_c615; /* jmp 0x100ec615 */
        l_0x100e_c5dc:
            ii(0x100e_c5dc, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c5df, 5); call(0x1007_63a0, -0x7_6244);           /* call 0x100763a0 */
            ii(0x100e_c5e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c5e6, 3); mov(dl, memb[ds, eax + 0x4a]);          /* mov dl, [eax+0x4a] */
            ii(0x100e_c5e9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_c5ec, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x100e_c5ef, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c5f2, 5); call(0x1007_63a0, -0x7_6257);           /* call 0x100763a0 */
            ii(0x100e_c5f7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c5f9, 3); mov(dl, memb[ds, eax + 0x4c]);          /* mov dl, [eax+0x4c] */
            ii(0x100e_c5fc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_c5ff, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x100e_c602, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c605, 5); call(0x1007_63a0, -0x7_626a);           /* call 0x100763a0 */
            ii(0x100e_c60a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c60c, 3); mov(dl, memb[ds, eax + 0x4b]);          /* mov dl, [eax+0x4b] */
            ii(0x100e_c60f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_c612, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
        l_0x100e_c615:
            ii(0x100e_c615, 5); jmp(0x100e_c58c, -0x8e); goto l_0x100e_c58c; /* jmp 0x100ec58c */
        l_0x100e_c61a:
            ii(0x100e_c61a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c61c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c61f, 5); call(0x1007_5f6c, -0x7_66b8);           /* call 0x10075f6c */
            ii(0x100e_c624, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_c626, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_c627, 1); pop(edi);                               /* pop edi */
            ii(0x100e_c628, 1); pop(esi);                               /* pop esi */
            ii(0x100e_c629, 1); ret();                                  /* ret */
        }
    }
}
