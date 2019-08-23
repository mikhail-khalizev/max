using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_f6c6-7fd7bb7a")]
        public void Method_1010_f6c6()
        {
            ii(0x1010_f6c6, 5); push(0x54);                             /* push 0x54 */
            ii(0x1010_f6cb, 5); call(Definitions.sys_check_available_stack_size, 0x5_6682); /* call 0x10165d52 */
            ii(0x1010_f6d0, 1); push(ecx);                              /* push ecx */
            ii(0x1010_f6d1, 1); push(esi);                              /* push esi */
            ii(0x1010_f6d2, 1); push(edi);                              /* push edi */
            ii(0x1010_f6d3, 1); push(ebp);                              /* push ebp */
            ii(0x1010_f6d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f6d6, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1010_f6dc, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_f6df, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1010_f6e2, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1010_f6e5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_f6e8, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1010_f6ea, 5); call(0x1010_edfe, -0x8f1);              /* call 0x1010edfe */
            ii(0x1010_f6ef, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_f6f2, 4); imul(eax, memd[ds, edx + 0xc], 0x18);   /* imul eax, [edx+0xc], 0x18 */
            ii(0x1010_f6f6, 6); mov(eax, memd[ds, eax + 0x101b_abf6]);  /* mov eax, [eax+0x101babf6] */
            ii(0x1010_f6fc, 5); mov(memd[ds, 0x101b_abd4], eax);        /* mov [0x101babd4], eax */
            ii(0x1010_f701, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_f706, 1); push(eax);                              /* push eax */
            ii(0x1010_f707, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_f70c, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_f711, 5); mov(esi, 0x101b_abc4);                  /* mov esi, 0x101babc4 */
            ii(0x1010_f716, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_f719, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1010_f71b, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1010_f71d, 5); call(0x1010_8a05, -0x6d1d);             /* call 0x10108a05 */
            ii(0x1010_f722, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_f725, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1010_f727, 5); call(0x1010_eda6, -0x986);              /* call 0x1010eda6 */
            ii(0x1010_f72c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_f72f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_f732, 7); mov(memw[ds, edx + 0x229], ax);         /* mov [edx+0x229], ax */
            ii(0x1010_f739, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_f73e, 5); call(/* sys */ 0x1016_a24c, 0x5_ab09);  /* call 0x1016a24c */
            ii(0x1010_f743, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_f74a:
            ii(0x1010_f74a, 3); dec(memd[ss, ebp - 0x4]);               /* dec dword [ebp-0x4] */
            ii(0x1010_f74d, 5); cmp(memw[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x1010_f752, 6); if(jz(0x1010_f8ef, 0x197)) goto l_0x1010_f8ef; /* jz 0x1010f8ef */
            ii(0x1010_f758, 5); mov(eax, memd[ds, 0x101b_abd8]);        /* mov eax, [0x101babd8] */
            ii(0x1010_f75d, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_f760, 5); mov(eax, memd[ds, 0x101b_abe0]);        /* mov eax, [0x101babe0] */
            ii(0x1010_f765, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_f768, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_f76c, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_f76f, 6); mov(edx, memd[ds, 0x101b_abdc]);        /* mov edx, [0x101babdc] */
            ii(0x1010_f775, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_f777, 3); mov(memd[ss, ebp - 0x20], edx);         /* mov [ebp-0x20], edx */
            ii(0x1010_f77a, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_f77d, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1010_f780, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_f783, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_f787, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f78a, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_f78d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f78f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_f792, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_f796, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f799, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_f79c, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1010_f7a0, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_f7a3, 3); add(edx, memd[ss, ebp - 0xc]);          /* add edx, [ebp-0xc] */
            ii(0x1010_f7a6, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f7a8, 6); mov(memd[ds, edx + 0x201], eax);        /* mov [edx+0x201], eax */
            ii(0x1010_f7ae, 5); call(0x1011_5318, 0x5b65);              /* call 0x10115318 */
            ii(0x1010_f7b3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_f7b8, 1); push(eax);                              /* push eax */
            ii(0x1010_f7b9, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_f7be, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_f7c3, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1010_f7c6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_f7c9, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f7cb, 5); call(0x1010_8a05, -0x6dcb);             /* call 0x10108a05 */
            ii(0x1010_f7d0, 2); push(0x2);                              /* push 0x2 */
            ii(0x1010_f7d2, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_f7d5, 1); push(eax);                              /* push eax */
            ii(0x1010_f7d6, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_f7d9, 1); push(eax);                              /* push eax */
            ii(0x1010_f7da, 3); mov(ecx, memd[ss, ebp - 0x18]);         /* mov ecx, [ebp-0x18] */
            ii(0x1010_f7dd, 3); mov(ebx, memd[ss, ebp - 0x24]);         /* mov ebx, [ebp-0x24] */
            ii(0x1010_f7e0, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x1010_f7e5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_f7e8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f7ea, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1010_f7ed, 5); call(/* sys */ 0x1016_a5a0, 0x5_adae);  /* call 0x1016a5a0 */
            ii(0x1010_f7f2, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_f7f7, 5); call(Definitions.sys_new, 0x5_6604);    /* call 0x10165e00 */
            ii(0x1010_f7fc, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_f7ff, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_f802, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_f805, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1010_f809, 2); if(jz(0x1010_f837, 0x2c)) goto l_0x1010_f837; /* jz 0x1010f837 */
            ii(0x1010_f80b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_f80e, 3); sub(eax, memd[ss, ebp - 0x20]);         /* sub eax, [ebp-0x20] */
            ii(0x1010_f811, 1); cwde();                                 /* cwde */
            ii(0x1010_f812, 1); push(eax);                              /* push eax */
            ii(0x1010_f813, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_f816, 3); sub(eax, memd[ss, ebp - 0x24]);         /* sub eax, [ebp-0x24] */
            ii(0x1010_f819, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_f81c, 4); movsx(ebx, memw[ss, ebp - 0x20]);       /* movsx ebx, word [ebp-0x20] */
            ii(0x1010_f820, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1010_f824, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_f827, 5); call(0x100c_e39d, -0x4_148f);           /* call 0x100ce39d */
            ii(0x1010_f82c, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1010_f82f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_f832, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1010_f835, 2); jmp(0x1010_f83d, 0x6); goto l_0x1010_f83d; /* jmp 0x1010f83d */
        l_0x1010_f837:
            ii(0x1010_f837, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1010_f83a, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
        l_0x1010_f83d:
            ii(0x1010_f83d, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1010_f841, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_f844, 3); add(edx, memd[ss, ebp - 0xc]);          /* add edx, [ebp-0xc] */
            ii(0x1010_f847, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_f84a, 6); mov(memd[ds, edx + 0x1d9], eax);        /* mov [edx+0x1d9], eax */
            ii(0x1010_f850, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_f852, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_f856, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f859, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1010_f85c, 6); mov(eax, memd[ds, eax + 0x1d9]);        /* mov eax, [eax+0x1d9] */
            ii(0x1010_f862, 5); call(0x100d_5194, -0x3_a6d3);           /* call 0x100d5194 */
            ii(0x1010_f867, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1010_f86b, 6); add(edx, 0x7d0);                        /* add edx, 0x7d0 */
            ii(0x1010_f871, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_f875, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f878, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1010_f87b, 6); mov(eax, memd[ds, eax + 0x1d9]);        /* mov eax, [eax+0x1d9] */
            ii(0x1010_f881, 5); call(0x100d_5164, -0x3_a722);           /* call 0x100d5164 */
            ii(0x1010_f886, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x1010_f88b, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_f88f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f892, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1010_f895, 6); mov(eax, memd[ds, eax + 0x1d9]);        /* mov eax, [eax+0x1d9] */
            ii(0x1010_f89b, 5); call(0x100d_50d4, -0x3_a7cc);           /* call 0x100d50d4 */
            ii(0x1010_f8a0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_f8a3, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f8a5, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x1010_f8a8, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_f8ac, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f8af, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1010_f8b2, 6); mov(eax, memd[ds, eax + 0x1d9]);        /* mov eax, [eax+0x1d9] */
            ii(0x1010_f8b8, 5); call(0x100c_f85c, -0x4_0061);           /* call 0x100cf85c */
            ii(0x1010_f8bd, 5); call(0x100d_51e4, -0x3_a6de);           /* call 0x100d51e4 */
            ii(0x1010_f8c2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_f8c4, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_f8c6, 5); call(0x100d_5204, -0x3_a6c7);           /* call 0x100d5204 */
            ii(0x1010_f8cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_f8cd, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_f8cf, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_f8d3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f8d6, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1010_f8d9, 6); mov(eax, memd[ds, eax + 0x1d9]);        /* mov eax, [eax+0x1d9] */
            ii(0x1010_f8df, 5); call(0x100c_fa7c, -0x3_fe68);           /* call 0x100cfa7c */
            ii(0x1010_f8e4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_f8e7, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1010_f8ea, 5); jmp(0x1010_f74a, -0x1a5); goto l_0x1010_f74a; /* jmp 0x1010f74a */
        l_0x1010_f8ef:
            ii(0x1010_f8ef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f8f1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_f8f2, 1); pop(edi);                               /* pop edi */
            ii(0x1010_f8f3, 1); pop(esi);                               /* pop esi */
            ii(0x1010_f8f4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_f8f5, 1); ret();                                  /* ret */
        }
    }
}
