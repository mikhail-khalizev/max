using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b574-a4356789")]
        public void Method_1008_b574()
        {
            ii(0x1008_b574, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1008_b579, 5); calld(Definitions.sys_check_available_stack_size, 0xd_a7d4); /* call 0x10165d52 */
            ii(0x1008_b57e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b57f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b580, 1); pushd(edx);                             /* push edx */
            ii(0x1008_b581, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b582, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b583, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b584, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b586, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1008_b58c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_b58f, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1008_b594, 5); calld(0x1007_6338, -0x1_5261);          /* call 0x10076338 */
            ii(0x1008_b599, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_b59b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b59e, 5); calld(0x1007_64b8, -0x1_50eb);          /* call 0x100764b8 */
            ii(0x1008_b5a3, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_b5a8, 5); calld(0x1008_a768, -0xe45);             /* call 0x1008a768 */
            ii(0x1008_b5ad, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1008_b5b0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_b5b2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_b5b4, 5); calld(0x1008_ae70, -0x749);             /* call 0x1008ae70 */
            ii(0x1008_b5b9, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_b5c0, 2); jmpd(0x1008_b5ca, 0x8); goto l_0x1008_b5ca; /* jmp 0x1008b5ca */
        l_0x1008_b5c2:
            ii(0x1008_b5c2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b5c5, 5); calld(0x1007_6bf8, -0x1_49d2);          /* call 0x10076bf8 */
        l_0x1008_b5ca:
            ii(0x1008_b5ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b5cc, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b5cf, 5); calld(0x1013_ad71, 0xa_f79d);           /* call 0x1013ad71 */
            ii(0x1008_b5d4, 2); test(al, al);                           /* test al, al */
            ii(0x1008_b5d6, 2); if(jzd(0x1008_b605, 0x2d)) goto l_0x1008_b605; /* jz 0x1008b605 */
            ii(0x1008_b5d8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b5db, 5); calld(0x1007_63a0, -0x1_5240);          /* call 0x100763a0 */
            ii(0x1008_b5e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b5e2, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_b5e5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1008_b5e9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_b5eb, 2); if(jnzd(0x1008_b603, 0x16)) goto l_0x1008_b603; /* jnz 0x1008b603 */
            ii(0x1008_b5ed, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b5f0, 5); calld(0x1007_63a0, -0x1_5255);          /* call 0x100763a0 */
            ii(0x1008_b5f5, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1008_b5f8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_b5fb, 5); calld(0x1007_1f2e, -0x1_96d2);          /* call 0x10071f2e */
            ii(0x1008_b600, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x1008_b603:
            ii(0x1008_b603, 2); jmpd(0x1008_b5c2, -0x43); goto l_0x1008_b5c2; /* jmp 0x1008b5c2 */
        l_0x1008_b605:
            ii(0x1008_b605, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1008_b609, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_b60b, 2); if(jgd(0x1008_b62a, 0x1d)) goto l_0x1008_b62a; /* jg 0x1008b62a */
            ii(0x1008_b60d, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_b611, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b613, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_b616, 5); calld(0x1008_8bbc, -0x2a5f);            /* call 0x10088bbc */
            ii(0x1008_b61b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b61d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b620, 5); calld(0x1007_5f6c, -0x1_56b9);          /* call 0x10075f6c */
            ii(0x1008_b625, 5); jmpd(0x1008_b6e8, 0xbe); goto l_0x1008_b6e8; /* jmp 0x1008b6e8 */
        l_0x1008_b62a:
            ii(0x1008_b62a, 2); jmpd(0x1008_b634, 0x8); goto l_0x1008_b634; /* jmp 0x1008b634 */
        l_0x1008_b62c:
            ii(0x1008_b62c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_b62f, 5); calld(0x1007_6bf8, -0x1_4a3c);          /* call 0x10076bf8 */
        l_0x1008_b634:
            ii(0x1008_b634, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b636, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_b639, 5); calld(0x1013_ad71, 0xa_f733);           /* call 0x1013ad71 */
            ii(0x1008_b63e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_b640, 2); if(jzd(0x1008_b6a6, 0x64)) goto l_0x1008_b6a6; /* jz 0x1008b6a6 */
            ii(0x1008_b642, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_b645, 5); calld(0x1008_adc4, -0x886);             /* call 0x1008adc4 */
            ii(0x1008_b64a, 5); calld(0x1008_ad90, -0x8bf);             /* call 0x1008ad90 */
            ii(0x1008_b64f, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1008_b653, 2); if(jnzd(0x1008_b670, 0x1b)) goto l_0x1008_b670; /* jnz 0x1008b670 */
            ii(0x1008_b655, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_b658, 5); calld(0x1008_adc4, -0x899);             /* call 0x1008adc4 */
            ii(0x1008_b65d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_b660, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_b663, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_b666, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_b669, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x1008_b66c, 2); cmp(al, 0x9);                           /* cmp al, 0x9 */
            ii(0x1008_b66e, 2); if(jzd(0x1008_b672, 0x2)) goto l_0x1008_b672; /* jz 0x1008b672 */
        l_0x1008_b670:
            ii(0x1008_b670, 2); jmpd(0x1008_b6a4, 0x32); goto l_0x1008_b6a4; /* jmp 0x1008b6a4 */
        l_0x1008_b672:
            ii(0x1008_b672, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_b675, 5); calld(0x1008_adf8, -0x882);             /* call 0x1008adf8 */
            ii(0x1008_b67a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_b67d, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_b680, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_b683, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_b686, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_b689, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_b68c, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1008_b68f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_b691, 2); if(jzd(0x1008_b6a4, 0x11)) goto l_0x1008_b6a4; /* jz 0x1008b6a4 */
            ii(0x1008_b693, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_b696, 5); calld(0x1009_c4c4, 0x1_0e29);           /* call 0x1009c4c4 */
            ii(0x1008_b69b, 1); cwde();                                 /* cwde */
            ii(0x1008_b69c, 5); calld(0x1007_1f2e, -0x1_9773);          /* call 0x10071f2e */
            ii(0x1008_b6a1, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x1008_b6a4:
            ii(0x1008_b6a4, 2); jmpd(0x1008_b62c, -0x7a); goto l_0x1008_b62c; /* jmp 0x1008b62c */
        l_0x1008_b6a6:
            ii(0x1008_b6a6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1008_b6aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_b6ac, 2); if(jled(0x1008_b6b4, 0x6)) goto l_0x1008_b6b4; /* jle 0x1008b6b4 */
            ii(0x1008_b6ae, 4); mov(memb_a32[ss, ebp - 0x24], 0x1);     /* mov byte [ebp-0x24], 0x1 */
            ii(0x1008_b6b2, 2); jmpd(0x1008_b6b8, 0x4); goto l_0x1008_b6b8; /* jmp 0x1008b6b8 */
        l_0x1008_b6b4:
            ii(0x1008_b6b4, 4); mov(memb_a32[ss, ebp - 0x24], 0);       /* mov byte [ebp-0x24], 0x0 */
        l_0x1008_b6b8:
            ii(0x1008_b6b8, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x1008_b6bb, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_b6be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b6c0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_b6c3, 5); calld(0x1008_8bbc, -0x2b0c);            /* call 0x10088bbc */
            ii(0x1008_b6c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b6ca, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b6cd, 5); calld(0x1007_5f6c, -0x1_5766);          /* call 0x10075f6c */
            ii(0x1008_b6d2, 2); jmpd(0x1008_b6e8, 0x14); goto l_0x1008_b6e8; /* jmp 0x1008b6e8 */
        //  ii(0x1008_b6d4, 20); Недостижимый код.
        l_0x1008_b6e8:
            ii(0x1008_b6e8, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_b6eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b6ed, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b6ee, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b6ef, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b6f0, 1); popd(edx);                              /* pop edx */
            ii(0x1008_b6f1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b6f2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b6f3, 1); retd(); return;                         /* ret */
        }
    }
}
