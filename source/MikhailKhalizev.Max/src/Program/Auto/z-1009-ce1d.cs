using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ce1d-cb9386dc")]
        public void Method_1009_ce1d()
        {
            ii(0x1009_ce1d, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1009_ce22, 5); call(Definitions.sys_check_available_stack_size, 0xc_8f2b); /* call 0x10165d52 */
            ii(0x1009_ce27, 1); push(ebx);                              /* push ebx */
            ii(0x1009_ce28, 1); push(ecx);                              /* push ecx */
            ii(0x1009_ce29, 1); push(edx);                              /* push edx */
            ii(0x1009_ce2a, 1); push(esi);                              /* push esi */
            ii(0x1009_ce2b, 1); push(edi);                              /* push edi */
            ii(0x1009_ce2c, 1); push(ebp);                              /* push ebp */
            ii(0x1009_ce2d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ce2f, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_ce35, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_ce38, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ce3b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ce3e, 5); call(0x1007_6b90, -0x2_62b3);           /* call 0x10076b90 */
            ii(0x1009_ce43, 1); cwde();                                 /* cwde */
            ii(0x1009_ce44, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_ce46, 2); if(jnz(0x1009_ce73, 0x2b)) goto l_0x1009_ce73; /* jnz 0x1009ce73 */
            ii(0x1009_ce48, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ce4b, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_ce4e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_ce51, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_ce53, 2); if(jnz(0x1009_ce6e, 0x19)) goto l_0x1009_ce6e; /* jnz 0x1009ce6e */
            ii(0x1009_ce55, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ce58, 4); inc(memw[ds, eax + 0x21]);              /* inc word [eax+0x21] */
            ii(0x1009_ce5c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ce5f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_ce62, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ce65, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_ce68, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ce6b, 3); call_abs(memd[ds, edx + 0x78]);         /* call dword [edx+0x78] */
        l_0x1009_ce6e:
            ii(0x1009_ce6e, 5); jmp(0x1009_cfd2, 0x15f); goto l_0x1009_cfd2; /* jmp 0x1009cfd2 */
        l_0x1009_ce73:
            ii(0x1009_ce73, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ce76, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ce79, 5); call(0x1007_6338, -0x2_6b46);           /* call 0x10076338 */
            ii(0x1009_ce7e, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1009_ce81, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_ce83, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_ce85, 5); call(0x1007_64b8, -0x2_69d2);           /* call 0x100764b8 */
            ii(0x1009_ce8a, 2); jmp(0x1009_ce94, 0x8); goto l_0x1009_ce94; /* jmp 0x1009ce94 */
        l_0x1009_ce8c:
            ii(0x1009_ce8c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_ce8f, 5); call(0x1007_6bf8, -0x2_629c);           /* call 0x10076bf8 */
        l_0x1009_ce94:
            ii(0x1009_ce94, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_ce96, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_ce99, 5); call(0x1013_ad71, 0x9_ded3);            /* call 0x1013ad71 */
            ii(0x1009_ce9e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_cea0, 6); if(jz(0x1009_cfc8, 0x122)) goto l_0x1009_cfc8; /* jz 0x1009cfc8 */
            ii(0x1009_cea6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cea9, 5); call(0x1007_63a0, -0x2_6b0e);           /* call 0x100763a0 */
            ii(0x1009_ceae, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1009_ceb1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_ceb6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_ceb8, 2); if(jz(0x1009_cece, 0x14)) goto l_0x1009_cece; /* jz 0x1009cece */
            ii(0x1009_ceba, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_cebd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cec0, 5); call(0x1007_63a0, -0x2_6b25);           /* call 0x100763a0 */
            ii(0x1009_cec5, 5); call(0x1015_2a52, 0xb_5b88);            /* call 0x10152a52 */
            ii(0x1009_ceca, 2); test(al, al);                           /* test al, al */
            ii(0x1009_cecc, 2); if(jnz(0x1009_ced3, 0x5)) goto l_0x1009_ced3; /* jnz 0x1009ced3 */
        l_0x1009_cece:
            ii(0x1009_cece, 5); jmp(0x1009_cfc3, 0xf0); goto l_0x1009_cfc3; /* jmp 0x1009cfc3 */
        l_0x1009_ced3:
            ii(0x1009_ced3, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_ced6, 5); call(0x1007_63a0, -0x2_6b3b);           /* call 0x100763a0 */
            ii(0x1009_cedb, 5); call(0x1007_623c, -0x2_6ca4);           /* call 0x1007623c */
            ii(0x1009_cee0, 3); mov(edx, memd[ds, eax + 0x8]);          /* mov edx, [eax+0x8] */
            ii(0x1009_cee3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_cee6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_cee8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_ceeb, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_ceed, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1009_ceef, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_cef1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cef4, 5); call(0x1007_63a0, -0x2_6b59);           /* call 0x100763a0 */
            ii(0x1009_cef9, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1009_cefc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_cf01, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1009_cf03, 2); if(jg(0x1009_cf14, 0xf)) goto l_0x1009_cf14; /* jg 0x1009cf14 */
            ii(0x1009_cf05, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1009_cf0a, 5); call(0x1007_5fdc, -0x2_6f33);           /* call 0x10075fdc */
            ii(0x1009_cf0f, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_cf12, 2); if(jge(0x1009_cf19, 0x5)) goto l_0x1009_cf19; /* jge 0x1009cf19 */
        l_0x1009_cf14:
            ii(0x1009_cf14, 5); jmp(0x1009_cf8d, 0x74); goto l_0x1009_cf8d; /* jmp 0x1009cf8d */
        l_0x1009_cf19:
            ii(0x1009_cf19, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cf1c, 5); call(0x1007_63a0, -0x2_6b81);           /* call 0x100763a0 */
            ii(0x1009_cf21, 5); call(0x1015_287d, 0xb_5957);            /* call 0x1015287d */
            ii(0x1009_cf26, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1009_cf2b, 5); call(Definitions.sys_new, 0xc_8ed0);    /* call 0x10165e00 */
            ii(0x1009_cf30, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_cf33, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cf36, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_cf39, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_cf3d, 2); if(jz(0x1009_cf5c, 0x1d)) goto l_0x1009_cf5c; /* jz 0x1009cf5c */
            ii(0x1009_cf3f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cf42, 5); call(0x1007_63d4, -0x2_6b73);           /* call 0x100763d4 */
            ii(0x1009_cf47, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_cf49, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cf4c, 5); call(Definitions.my_ctor_c15, 0x2_e937); /* call 0x100cb888 */
            ii(0x1009_cf51, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_cf54, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_cf57, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_cf5a, 2); jmp(0x1009_cf62, 0x6); goto l_0x1009_cf62; /* jmp 0x1009cf62 */
        l_0x1009_cf5c:
            ii(0x1009_cf5c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_cf5f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1009_cf62:
            ii(0x1009_cf62, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1009_cf65, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_cf68, 5); call(0x1008_b060, -0x1_1f0d);           /* call 0x1008b060 */
            ii(0x1009_cf6d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_cf70, 5); call(0x1008_af84, -0x1_1ff1);           /* call 0x1008af84 */
            ii(0x1009_cf75, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_cf77, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_cf7c, 5); call(0x100a_4d50, 0x7dcf);              /* call 0x100a4d50 */
            ii(0x1009_cf81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_cf83, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_cf86, 5); call(0x1008_8b7c, -0x1_440f);           /* call 0x10088b7c */
            ii(0x1009_cf8b, 2); jmp(0x1009_cfc3, 0x36); goto l_0x1009_cfc3; /* jmp 0x1009cfc3 */
        l_0x1009_cf8d:
            ii(0x1009_cf8d, 5); call(0x1008_b0e4, -0x1_1eae);           /* call 0x1008b0e4 */
            ii(0x1009_cf92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_cf94, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1009_cf96, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cf99, 5); call(0x1007_63d4, -0x2_6bca);           /* call 0x100763d4 */
            ii(0x1009_cf9e, 5); call(0x100a_297d, 0x59da);              /* call 0x100a297d */
            ii(0x1009_cfa3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_cfa6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cfa9, 5); call(0x1007_63a0, -0x2_6c0e);           /* call 0x100763a0 */
            ii(0x1009_cfae, 5); call(0x1015_2a52, 0xb_5a9f);            /* call 0x10152a52 */
            ii(0x1009_cfb3, 2); test(al, al);                           /* test al, al */
            ii(0x1009_cfb5, 2); if(jnz(0x1009_cfc3, 0xc)) goto l_0x1009_cfc3; /* jnz 0x1009cfc3 */
            ii(0x1009_cfb7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_cfb9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cfbc, 5); call(0x1007_5f6c, -0x2_7055);           /* call 0x10075f6c */
            ii(0x1009_cfc1, 2); jmp(0x1009_cfd2, 0xf); goto l_0x1009_cfd2; /* jmp 0x1009cfd2 */
        l_0x1009_cfc3:
            ii(0x1009_cfc3, 5); jmp(0x1009_ce8c, -0x13c); goto l_0x1009_ce8c; /* jmp 0x1009ce8c */
        l_0x1009_cfc8:
            ii(0x1009_cfc8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_cfca, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cfcd, 5); call(0x1007_5f6c, -0x2_7066);           /* call 0x10075f6c */
        l_0x1009_cfd2:
            ii(0x1009_cfd2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cfd4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_cfd5, 1); pop(edi);                               /* pop edi */
            ii(0x1009_cfd6, 1); pop(esi);                               /* pop esi */
            ii(0x1009_cfd7, 1); pop(edx);                               /* pop edx */
            ii(0x1009_cfd8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_cfd9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_cfda, 1); ret();                                  /* ret */
        }
    }
}
