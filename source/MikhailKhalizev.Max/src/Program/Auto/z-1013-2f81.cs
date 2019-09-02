using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_2f81-81edae3c")]
        public void Method_1013_2f81()
        {
            ii(0x1013_2f81, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1013_2f86, 5); call(Definitions.sys_check_available_stack_size, 0x3_2dc7); /* call 0x10165d52 */
            ii(0x1013_2f8b, 1); push(ebx);                              /* push ebx */
            ii(0x1013_2f8c, 1); push(ecx);                              /* push ecx */
            ii(0x1013_2f8d, 1); push(esi);                              /* push esi */
            ii(0x1013_2f8e, 1); push(edi);                              /* push edi */
            ii(0x1013_2f8f, 1); push(ebp);                              /* push ebp */
            ii(0x1013_2f90, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_2f92, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1013_2f98, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_2f9b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_2f9e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_2fa1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_2fa4, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1013_2fa9, 5); call(0x1007_6338, -0xb_cc76);           /* call 0x10076338 */
            ii(0x1013_2fae, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x1013_2fb1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_2fb3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_2fb5, 5); call(0x1007_64b8, -0xb_cb02);           /* call 0x100764b8 */
            ii(0x1013_2fba, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_2fbd, 4); mov(memb[ds, eax + 0x1d], 1);           /* mov byte [eax+0x1d], 0x1 */
            ii(0x1013_2fc1, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_2fc8, 2); jmp(0x1013_2fd0, 6); goto l_0x1013_2fd0; /* jmp 0x10132fd0 */
        l_0x1013_2fca:
            ii(0x1013_2fca, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_2fcd, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1013_2fd0:
            ii(0x1013_2fd0, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_2fd4, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1013_2fd7, 2); if(jge(0x1013_2ffc, 0x23)) goto l_0x1013_2ffc; /* jge 0x10132ffc */
            ii(0x1013_2fd9, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_2fdd, 3); imul(eax, eax, 0x1f);                   /* imul eax, eax, 0x1f */
            ii(0x1013_2fe0, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1013_2fe3, 3); add(edx, 0x2a);                         /* add edx, 0x2a */
            ii(0x1013_2fe6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_2fe8, 5); call(0x1013_3998, 0x9ab);               /* call 0x10133998 */
            ii(0x1013_2fed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_2fef, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_2ff3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_2ff5, 5); mov(memw[ds, eax + ebp - 0x24], dx);    /* mov [eax+ebp-0x24], dx */
            ii(0x1013_2ffa, 2); jmp(0x1013_2fca, -0x32); goto l_0x1013_2fca; /* jmp 0x10132fca */
        l_0x1013_2ffc:
            ii(0x1013_2ffc, 2); jmp(0x1013_3006, 8); goto l_0x1013_3006; /* jmp 0x10133006 */
        l_0x1013_2ffe:
            ii(0x1013_2ffe, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_3001, 5); call(0x1007_6bf8, -0xb_c40e);           /* call 0x10076bf8 */
        l_0x1013_3006:
            ii(0x1013_3006, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3008, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_300b, 5); call(0x1013_ad71, 0x7d61);              /* call 0x1013ad71 */
            ii(0x1013_3010, 2); test(al, al);                           /* test al, al */
            ii(0x1013_3012, 6); if(jz(0x1013_3132, 0x11a)) goto l_0x1013_3132; /* jz 0x10133132 */
            ii(0x1013_3018, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_301b, 5); call(0x1007_63a0, -0xb_cc80);           /* call 0x100763a0 */
            ii(0x1013_3020, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3022, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1013_3025, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_3028, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1013_302b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_302e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_3030, 2); if(jnz(0x1013_3041, 0xf)) goto l_0x1013_3041; /* jnz 0x10133041 */
            ii(0x1013_3032, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_3035, 5); call(0x1007_63a0, -0xb_cc9a);           /* call 0x100763a0 */
            ii(0x1013_303a, 5); cmp(memw[ds, eax + 8], 0x1d);           /* cmp word [eax+0x8], 0x1d */
            ii(0x1013_303f, 2); if(jz(0x1013_3043, 2)) goto l_0x1013_3043; /* jz 0x10133043 */
        l_0x1013_3041:
            ii(0x1013_3041, 2); jmp(0x1013_3051, 0xe); goto l_0x1013_3051; /* jmp 0x10133051 */
        l_0x1013_3043:
            ii(0x1013_3043, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_3046, 5); call(0x1007_63a0, -0xb_ccab);           /* call 0x100763a0 */
            ii(0x1013_304b, 4); cmp(memb[ds, eax + 0x3d], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1013_304f, 2); if(jz(0x1013_3056, 5)) goto l_0x1013_3056; /* jz 0x10133056 */
        l_0x1013_3051:
            ii(0x1013_3051, 5); jmp(0x1013_312d, 0xd7); goto l_0x1013_312d; /* jmp 0x1013312d */
        l_0x1013_3056:
            ii(0x1013_3056, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_3059, 5); call(0x1007_63a0, -0xb_ccbe);           /* call 0x100763a0 */
            ii(0x1013_305e, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x1013_3061, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_3064, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_3066, 4); mov(eax, memd[ds, eax + ebp - 0x26]);   /* mov eax, [eax+ebp-0x26] */
            ii(0x1013_306a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_306d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_306f, 2); if(jle(0x1013_308b, 0x1a)) goto l_0x1013_308b; /* jle 0x1013308b */
            ii(0x1013_3071, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_3074, 5); call(0x1007_63a0, -0xb_ccd9);           /* call 0x100763a0 */
            ii(0x1013_3079, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x1013_307c, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_307f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_3081, 5); dec(memw[ds, eax + ebp - 0x24]);        /* dec word [eax+ebp-0x24] */
            ii(0x1013_3086, 5); jmp(0x1013_312d, 0xa2); goto l_0x1013_312d; /* jmp 0x1013312d */
        l_0x1013_308b:
            ii(0x1013_308b, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_3092, 2); jmp(0x1013_309a, 6); goto l_0x1013_309a; /* jmp 0x1013309a */
        l_0x1013_3094:
            ii(0x1013_3094, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_3097, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1013_309a:
            ii(0x1013_309a, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_309e, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1013_30a1, 2); if(jge(0x1013_30b1, 0xe)) goto l_0x1013_30b1; /* jge 0x101330b1 */
            ii(0x1013_30a3, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_30a7, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_30a9, 6); cmp(memw[ds, eax + ebp - 0x24], 0);     /* cmp word [eax+ebp-0x24], 0x0 */
            ii(0x1013_30af, 2); if(jz(0x1013_3094, -0x1d)) goto l_0x1013_3094; /* jz 0x10133094 */
        l_0x1013_30b1:
            ii(0x1013_30b1, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_30b5, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1013_30b8, 2); if(jnz(0x1013_30d0, 0x16)) goto l_0x1013_30d0; /* jnz 0x101330d0 */
            ii(0x1013_30ba, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_30bc, 5); mov(edx, 8);                            /* mov edx, 0x8 */
            ii(0x1013_30c1, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_30c4, 5); call(0x1007_63d4, -0xb_ccf5);           /* call 0x100763d4 */
            ii(0x1013_30c9, 5); call(0x1016_3053, 0x2_ff85);            /* call 0x10163053 */
            ii(0x1013_30ce, 2); jmp(0x1013_312d, 0x5d); goto l_0x1013_312d; /* jmp 0x1013312d */
        l_0x1013_30d0:
            ii(0x1013_30d0, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1013_30d5, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_30d8, 5); call(0x1007_63a0, -0xb_cd3d);           /* call 0x100763a0 */
            ii(0x1013_30dd, 3); mov(edx, memd[ds, eax + 0x5a]);         /* mov edx, [eax+0x5a] */
            ii(0x1013_30e0, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1013_30e3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_30e6, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1013_30e9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_30ec, 5); call(0x1013_322d, 0x13c);               /* call 0x1013322d */
            ii(0x1013_30f1, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_30f4, 5); call(0x1007_63a0, -0xb_cd59);           /* call 0x100763a0 */
            ii(0x1013_30f9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_30fb, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1013_30fe, 3); mov(memb[ds, edx + 0x5d], al);          /* mov [edx+0x5d], al */
            ii(0x1013_3101, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_3106, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_3109, 5); call(0x1007_63a0, -0xb_cd6e);           /* call 0x100763a0 */
            ii(0x1013_310e, 3); mov(edx, memd[ds, eax + 0x5a]);         /* mov edx, [eax+0x5a] */
            ii(0x1013_3111, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1013_3114, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_3117, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1013_311a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_311d, 5); call(0x1013_322d, 0x10b);               /* call 0x1013322d */
            ii(0x1013_3122, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_3126, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_3128, 5); dec(memw[ds, eax + ebp - 0x24]);        /* dec word [eax+ebp-0x24] */
        l_0x1013_312d:
            ii(0x1013_312d, 5); jmp(0x1013_2ffe, -0x134); goto l_0x1013_2ffe; /* jmp 0x10132ffe */
        l_0x1013_3132:
            ii(0x1013_3132, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_3139, 2); if(jz(0x1013_3149, 0xe)) goto l_0x1013_3149; /* jz 0x10133149 */
            ii(0x1013_313b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_313e, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1013_3141, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_3144, 5); call(0x1012_894c, -0xa7fd);             /* call 0x1012894c */
        l_0x1013_3149:
            ii(0x1013_3149, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_314b, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1013_314e, 5); call(0x1007_5f6c, -0xb_d1e7);           /* call 0x10075f6c */
            ii(0x1013_3153, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3155, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_3156, 1); pop(edi);                               /* pop edi */
            ii(0x1013_3157, 1); pop(esi);                               /* pop esi */
            ii(0x1013_3158, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_3159, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_315a, 1); ret();                                  /* ret */
        }
    }
}
