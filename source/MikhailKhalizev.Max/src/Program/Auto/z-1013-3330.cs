using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("09b974a5-373b-4311-b273-ffe0f0505190")]
        public void Method_1013_3330()
        {
            ii(0x1013_3330, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x1013_3335, 5); calld(Definitions.sys_check_available_stack_size, 0x32a18); /* call 0x10165d52 */
            ii(0x1013_333a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_333b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_333c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_333d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_333e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_333f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3341, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1013_3347, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_334a, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_334d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_3351, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1013_3357, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1013_335b, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1013_335e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_3360, 7); mov(ax, memw_a32[ds, eax + 0x101c_a4f0]); /* mov ax, [eax+0x101ca4f0] */
            ii(0x1013_3367, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_336a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_336e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_3374, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1013_337a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_337d, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_3384, 2); jmpd(0x1013_338c, 0x6); goto l_0x1013_338c; /* jmp 0x1013338c */
        l_0x1013_3386:
            ii(0x1013_3386, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_3389, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1013_338c:
            ii(0x1013_338c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1013_3390, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1013_3393, 6); if(jged(0x1013_3677, 0x2de)) goto l_0x1013_3677; /* jge 0x10133677 */
            ii(0x1013_3399, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_339c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_339f, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_33a3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_33a6, 5); calld(0x100c_b6b0, -0x67cfb);           /* call 0x100cb6b0 */
            ii(0x1013_33ab, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1013_33ae, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_33b0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_33b2, 5); calld(0x1007_6800, -0xbcbb7);           /* call 0x10076800 */
            ii(0x1013_33b7, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1013_33bc, 5); calld(Definitions.sys_new, 0x32a3f);    /* call 0x10165e00 */
            ii(0x1013_33c1, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_33c4, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1013_33c7, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_33ca, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1013_33ce, 2); if(jzd(0x1013_33f3, 0x23)) goto l_0x1013_33f3; /* jz 0x101333f3 */
            ii(0x1013_33d0, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_33d4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_33d7, 5); calld(0x1008_b104, -0xa82d8);           /* call 0x1008b104 */
            ii(0x1013_33dc, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x1013_33df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_33e1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_33e3, 5); calld(0x100c_a2f8, -0x690f0);           /* call 0x100ca2f8 */
            ii(0x1013_33e8, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1013_33eb, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1013_33ee, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1013_33f1, 2); jmpd(0x1013_33f9, 0x6); goto l_0x1013_33f9; /* jmp 0x101333f9 */
        l_0x1013_33f3:
            ii(0x1013_33f3, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1013_33f6, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x1013_33f9:
            ii(0x1013_33f9, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x1013_33fc, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_33ff, 5); calld(0x1007_6800, -0xbcc04);           /* call 0x10076800 */
            ii(0x1013_3404, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_3407, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1013_340a, 5); jmpd(0x1013_353c, 0x12d); goto l_0x1013_353c; /* jmp 0x1013353c */
        //  ii(0x1013_340f, 264); Недостижимый код.
l_0x1013_3517:
            ii(0x1013_3517, 2); jmpd(0x1013_3557, 0x3e); goto l_0x1013_3557; /* jmp 0x10133557 */
        //  ii(0x1013_3519, 35); Недостижимый код.
l_0x1013_353c:
            ii(0x1013_353c, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1013_353f, 3); mov(memb_a32[ss, ebp - 0x40], al);      /* mov [ebp-0x40], al */
            ii(0x1013_3542, 4); cmp(memb_a32[ss, ebp - 0x40], 0x7);     /* cmp byte [ebp-0x40], 0x7 */
            ii(0x1013_3546, 2); if(jad(0x1013_3517, -0x31)) goto l_0x1013_3517; /* ja 0x10133517 */
            ii(0x1013_3548, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_354a, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x1013_354d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_3550, 7); jmpd_abs(memd_a32[cs, eax + 0x1013_351c]); return; /* jmp dword [cs:eax+0x1013351c] */
        l_0x1013_3557:
            ii(0x1013_3557, 4); cmp(memb_a32[ss, ebp - 0x4], 0x7);      /* cmp byte [ebp-0x4], 0x7 */
            ii(0x1013_355b, 2); if(jnzd(0x1013_35d5, 0x78)) goto l_0x1013_35d5; /* jnz 0x101335d5 */
            ii(0x1013_355d, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_3561, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1013_3564, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_3566, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3569, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_356b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_356d, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x1013_3571, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x1013_3574, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3576, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_357a, 3); lea(ebx, eax + 0xa);                    /* lea ebx, [eax+0xa] */
            ii(0x1013_357d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_357f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3582, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_3584, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1013_3587, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_358b, 3); add(edx, 0x9);                          /* add edx, 0x9 */
            ii(0x1013_358e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_3590, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3593, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_3595, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_3597, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x1013_359b, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x1013_359e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_35a0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_35a4, 3); lea(ebx, eax + 0x9);                    /* lea ebx, [eax+0x9] */
            ii(0x1013_35a7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_35a9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_35ac, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_35ae, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_35b1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_35b6, 4); movsx(eax, memw_a32[ss, ebp - 0x44]);   /* movsx eax, word [ebp-0x44] */
            ii(0x1013_35ba, 5); calld(0x1007_6e7c, -0xbc743);           /* call 0x10076e7c */
            ii(0x1013_35bf, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1013_35c2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_35c7, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1013_35cb, 5); calld(0x1007_6e7c, -0xbc754);           /* call 0x10076e7c */
            ii(0x1013_35d0, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_35d3, 2); jmpd(0x1013_360a, 0x35); goto l_0x1013_360a; /* jmp 0x1013360a */
        l_0x1013_35d5:
            ii(0x1013_35d5, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_35d9, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1013_35dd, 1); dec(edx);                               /* dec edx */
            ii(0x1013_35de, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_35e1, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_35e6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_35e8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_35eb, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_35ed, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_35f0, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1013_35f4, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_35f8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_35fb, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_3600, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_3602, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3605, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_3607, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x1013_360a:
            ii(0x1013_360a, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1013_360d, 4); cmp(ax, memw_a32[ss, ebp - 0x48]);      /* cmp ax, [ebp-0x48] */
            ii(0x1013_3611, 2); if(jzd(0x1013_365e, 0x4b)) goto l_0x1013_365e; /* jz 0x1013365e */
            ii(0x1013_3613, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x1013_3616, 3); sub(edx, memd_a32[ss, ebp - 0x48]);     /* sub edx, [ebp-0x48] */
            ii(0x1013_3619, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_361c, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
            ii(0x1013_361f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3622, 5); calld(0x1007_6730, -0xbcef7);           /* call 0x10076730 */
            ii(0x1013_3627, 5); calld(0x100c_b7e4, -0x67e48);           /* call 0x100cb7e4 */
            ii(0x1013_362c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_362e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3631, 5); calld(0x1007_6730, -0xbcf06);           /* call 0x10076730 */
            ii(0x1013_3636, 5); calld(0x100c_b7b4, -0x67e87);           /* call 0x100cb7b4 */
            ii(0x1013_363b, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_363e, 5); calld(0x100c_b74c, -0x67ef7);           /* call 0x100cb74c */
            ii(0x1013_3643, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_3645, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3649, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_364d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_3653, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1013_3659, 5); calld(0x100c_b63c, -0x68022);           /* call 0x100cb63c */
        l_0x1013_365e:
            ii(0x1013_365e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3660, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3663, 5); calld(0x1007_5eec, -0xbd77c);           /* call 0x10075eec */
            ii(0x1013_3668, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_366a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_366d, 5); calld(0x1007_5eec, -0xbd786);           /* call 0x10075eec */
            ii(0x1013_3672, 5); jmpd(0x1013_3386, -0x2f1); goto l_0x1013_3386; /* jmp 0x10133386 */
        l_0x1013_3677:
            ii(0x1013_3677, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3679, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_367a, 1); popd(edi);                              /* pop edi */
            ii(0x1013_367b, 1); popd(esi);                              /* pop esi */
            ii(0x1013_367c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_367d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_367e, 1); retd(); return;                         /* ret */
        }
    }
}