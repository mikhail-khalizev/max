using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_6478-a2e402b7")]
        public void Method_1009_6478()
        {
            ii(0x1009_6478, 5); push(0x5c);                             /* push 0x5c */
            ii(0x1009_647d, 5); call(Definitions.sys_check_available_stack_size, 0xc_f8d0); /* call 0x10165d52 */
            ii(0x1009_6482, 1); push(ecx);                              /* push ecx */
            ii(0x1009_6483, 1); push(esi);                              /* push esi */
            ii(0x1009_6484, 1); push(edi);                              /* push edi */
            ii(0x1009_6485, 1); push(ebp);                              /* push ebp */
            ii(0x1009_6486, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_6488, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1009_648e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_6491, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_6494, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_6497, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_649a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_649d, 5); call(0x1007_6338, -0x2_016a);           /* call 0x10076338 */
            ii(0x1009_64a2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_64a4, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_64a7, 5); call(0x1007_64b8, -0x1_fff4);           /* call 0x100764b8 */
            ii(0x1009_64ac, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1009_64b1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_64b4, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_64b7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_64ba, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_64c0, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1009_64c6, 5); call(0x1008_b104, -0xb3c7);             /* call 0x1008b104 */
            ii(0x1009_64cb, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x1009_64cf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_64d2, 2); jmp(0x1009_64dc, 0x8); goto l_0x1009_64dc; /* jmp 0x100964dc */
        l_0x1009_64d4:
            ii(0x1009_64d4, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_64d7, 5); call(0x1007_6bf8, -0x1_f8e4);           /* call 0x10076bf8 */
        l_0x1009_64dc:
            ii(0x1009_64dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_64de, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_64e1, 5); call(0x1013_ad71, 0xa_488b);            /* call 0x1013ad71 */
            ii(0x1009_64e6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_64e8, 6); if(jz(0x1009_658d, 0x9f)) goto l_0x1009_658d; /* jz 0x1009658d */
            ii(0x1009_64ee, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_64f1, 5); call(0x1007_63a0, -0x2_0156);           /* call 0x100763a0 */
            ii(0x1009_64f6, 5); cmp(memw[ds, eax + 0x8], 0x5);          /* cmp word [eax+0x8], 0x5 */
            ii(0x1009_64fb, 6); if(jnz(0x1009_6588, 0x87)) goto l_0x1009_6588; /* jnz 0x10096588 */
            ii(0x1009_6501, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_6504, 5); call(0x1007_63a0, -0x2_0169);           /* call 0x100763a0 */
            ii(0x1009_6509, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1009_650c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_650f, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_6512, 5); call(0x1007_63a0, -0x2_0177);           /* call 0x100763a0 */
            ii(0x1009_6517, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1009_651a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_651d, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_6520, 5); call(0x1007_6aac, -0x1_fa79);           /* call 0x10076aac */
            ii(0x1009_6525, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_6528, 5); call(0x1007_63a0, -0x2_018d);           /* call 0x100763a0 */
            ii(0x1009_652d, 5); call(0x1007_623c, -0x2_02f6);           /* call 0x1007623c */
            ii(0x1009_6532, 3); mov(edx, memd[ds, eax + 0x15]);         /* mov edx, [eax+0x15] */
            ii(0x1009_6535, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_6538, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_653a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_653d, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_653f, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1009_6541, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_6544, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1009_6547, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_654a, 5); call(0x1007_5e64, -0x2_06eb);           /* call 0x10075e64 */
            ii(0x1009_654f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6551, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_6554, 5); call(0x100a_95c1, 0x1_3068);            /* call 0x100a95c1 */
        l_0x1009_6559:
            ii(0x1009_6559, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_655c, 5); call(0x1008_9860, -0xcd01);             /* call 0x10089860 */
            ii(0x1009_6561, 1); cwde();                                 /* cwde */
            ii(0x1009_6562, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_6565, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_6568, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_656a, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_656d, 5); call(0x1008_982c, -0xcd46);             /* call 0x1008982c */
            ii(0x1009_6572, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_6575, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1009_6577, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_6579, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1009_657c, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_657f, 5); call(0x100a_96db, 0x1_3157);            /* call 0x100a96db */
            ii(0x1009_6584, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6586, 2); if(jnz(0x1009_6559, -0x2f)) goto l_0x1009_6559; /* jnz 0x10096559 */
        l_0x1009_6588:
            ii(0x1009_6588, 5); jmp(0x1009_64d4, -0xb9); goto l_0x1009_64d4; /* jmp 0x100964d4 */
        l_0x1009_658d:
            ii(0x1009_658d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_6590, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_6593, 5); call(0x1009_c6c8, 0x6130);              /* call 0x1009c6c8 */
            ii(0x1009_6598, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x1009_659b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_659d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_659f, 5); call(0x1009_c5dc, 0x6038);              /* call 0x1009c5dc */
            ii(0x1009_65a4, 2); jmp(0x1009_65ae, 0x8); goto l_0x1009_65ae; /* jmp 0x100965ae */
        l_0x1009_65a6:
            ii(0x1009_65a6, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_65a9, 5); call(0x1007_6bf8, -0x1_f9b6);           /* call 0x10076bf8 */
        l_0x1009_65ae:
            ii(0x1009_65ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_65b0, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_65b3, 5); call(0x1013_ad71, 0xa_47b9);            /* call 0x1013ad71 */
            ii(0x1009_65b8, 2); test(al, al);                           /* test al, al */
            ii(0x1009_65ba, 6); if(jz(0x1009_664b, 0x8b)) goto l_0x1009_664b; /* jz 0x1009664b */
            ii(0x1009_65c0, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_65c3, 5); call(0x1009_c4f8, 0x5f30);              /* call 0x1009c4f8 */
            ii(0x1009_65c8, 5); call(0x1009_c4c4, 0x5ef7);              /* call 0x1009c4c4 */
            ii(0x1009_65cd, 4); cmp(ax, 0x5);                           /* cmp ax, 0x5 */
            ii(0x1009_65d1, 2); if(jnz(0x1009_65e0, 0xd)) goto l_0x1009_65e0; /* jnz 0x100965e0 */
            ii(0x1009_65d3, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_65d6, 5); call(0x1009_c52c, 0x5f51);              /* call 0x1009c52c */
            ii(0x1009_65db, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1009_65de, 2); if(jnz(0x1009_65e2, 0x2)) goto l_0x1009_65e2; /* jnz 0x100965e2 */
        l_0x1009_65e0:
            ii(0x1009_65e0, 2); jmp(0x1009_6646, 0x64); goto l_0x1009_6646; /* jmp 0x10096646 */
        l_0x1009_65e2:
            ii(0x1009_65e2, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1009_65e5, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_65e8, 5); call(0x1009_c4f8, 0x5f0b);              /* call 0x1009c4f8 */
            ii(0x1009_65ed, 5); call(0x100a_2d3d, 0xc74b);              /* call 0x100a2d3d */
            ii(0x1009_65f2, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_65f6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_65f8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_65fb, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_65fd, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1009_65ff, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_6602, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1009_6605, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1009_6608, 5); call(0x1007_5e64, -0x2_07a9);           /* call 0x10075e64 */
            ii(0x1009_660d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_660f, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_6612, 5); call(0x100a_95c1, 0x1_2faa);            /* call 0x100a95c1 */
        l_0x1009_6617:
            ii(0x1009_6617, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_661a, 5); call(0x1008_9860, -0xcdbf);             /* call 0x10089860 */
            ii(0x1009_661f, 1); cwde();                                 /* cwde */
            ii(0x1009_6620, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_6623, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_6626, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_6628, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_662b, 5); call(0x1008_982c, -0xce04);             /* call 0x1008982c */
            ii(0x1009_6630, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_6633, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1009_6635, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_6637, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1009_663a, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_663d, 5); call(0x100a_96db, 0x1_3099);            /* call 0x100a96db */
            ii(0x1009_6642, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6644, 2); if(jnz(0x1009_6617, -0x2f)) goto l_0x1009_6617; /* jnz 0x10096617 */
        l_0x1009_6646:
            ii(0x1009_6646, 5); jmp(0x1009_65a6, -0xa5); goto l_0x1009_65a6; /* jmp 0x100965a6 */
        l_0x1009_664b:
            ii(0x1009_664b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_664d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_6650, 5); call(0x1009_ba6c, 0x5417);              /* call 0x1009ba6c */
            ii(0x1009_6655, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6657, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_665a, 5); call(0x1007_5f6c, -0x2_06f3);           /* call 0x10075f6c */
            ii(0x1009_665f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_6661, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_6662, 1); pop(edi);                               /* pop edi */
            ii(0x1009_6663, 1); pop(esi);                               /* pop esi */
            ii(0x1009_6664, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_6665, 1); ret();                                  /* ret */
        }
    }
}
