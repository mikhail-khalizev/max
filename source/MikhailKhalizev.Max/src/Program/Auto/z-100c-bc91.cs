using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_bc91-f0fe3239")]
        public void Method_100c_bc91()
        {
            ii(0x100c_bc91, 5); pushd(0x5c);                            /* push 0x5c */
            ii(0x100c_bc96, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a0b7); /* call 0x10165d52 */
            ii(0x100c_bc9b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_bc9c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_bc9d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_bc9e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_bc9f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_bca0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_bca2, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x100c_bca8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_bcab, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_bcae, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_bcb2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_bcb5, 5); calld(0x1007_64fc, -0x5_57be);          /* call 0x100764fc */
            ii(0x100c_bcba, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_bcbd, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_bcc1, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_bcc6, 5); calld(0x1008_a768, -0x4_1563);          /* call 0x1008a768 */
            ii(0x100c_bccb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_bccd, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bcd0, 5); calld(0x1008_ae70, -0x4_0e65);          /* call 0x1008ae70 */
            ii(0x100c_bcd5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_bcd9, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100c_bcdc, 7); test(memb_a32[ds, eax + 0x101c_81c1], 0x2); /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x100c_bce3, 2); if(jzd(0x100c_bcfd, 0x18)) goto l_0x100c_bcfd; /* jz 0x100cbcfd */
            ii(0x100c_bce5, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100c_bcea, 5); calld(0x1007_6338, -0x5_59b7);          /* call 0x10076338 */
            ii(0x100c_bcef, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100c_bcf2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_bcf4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_bcf6, 5); calld(0x1007_643c, -0x5_58bf);          /* call 0x1007643c */
            ii(0x100c_bcfb, 2); jmpd(0x100c_bd13, 0x16); goto l_0x100c_bd13; /* jmp 0x100cbd13 */
        l_0x100c_bcfd:
            ii(0x100c_bcfd, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100c_bd02, 5); calld(0x1007_6338, -0x5_59cf);          /* call 0x10076338 */
            ii(0x100c_bd07, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100c_bd0a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_bd0c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_bd0e, 5); calld(0x1007_643c, -0x5_58d7);          /* call 0x1007643c */
        l_0x100c_bd13:
            ii(0x100c_bd13, 2); jmpd(0x100c_bd1d, 0x8); goto l_0x100c_bd1d; /* jmp 0x100cbd1d */
        l_0x100c_bd15:
            ii(0x100c_bd15, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_bd18, 5); calld(0x1007_6bf8, -0x5_5125);          /* call 0x10076bf8 */
        l_0x100c_bd1d:
            ii(0x100c_bd1d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bd1f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_bd22, 5); calld(0x1013_ad71, 0x6_f04a);           /* call 0x1013ad71 */
            ii(0x100c_bd27, 2); test(al, al);                           /* test al, al */
            ii(0x100c_bd29, 2); if(jzd(0x100c_bd74, 0x49)) goto l_0x100c_bd74; /* jz 0x100cbd74 */
            ii(0x100c_bd2b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_bd2e, 5); calld(0x1007_63a0, -0x5_5993);          /* call 0x100763a0 */
            ii(0x100c_bd33, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bd35, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100c_bd38, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_bd3b, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100c_bd3e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_bd41, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_bd43, 2); if(jnzd(0x100c_bd57, 0x12)) goto l_0x100c_bd57; /* jnz 0x100cbd57 */
            ii(0x100c_bd45, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_bd48, 5); calld(0x1007_63a0, -0x5_59ad);          /* call 0x100763a0 */
            ii(0x100c_bd4d, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100c_bd51, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100c_bd55, 2); if(jzd(0x100c_bd59, 0x2)) goto l_0x100c_bd59; /* jz 0x100cbd59 */
        l_0x100c_bd57:
            ii(0x100c_bd57, 2); jmpd(0x100c_bd72, 0x19); goto l_0x100c_bd72; /* jmp 0x100cbd72 */
        l_0x100c_bd59:
            ii(0x100c_bd59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bd5b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bd5e, 5); calld(0x1008_8bbc, -0x4_31a7);          /* call 0x10088bbc */
            ii(0x100c_bd63, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bd65, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_bd68, 5); calld(0x1007_5f6c, -0x5_5e01);          /* call 0x10075f6c */
            ii(0x100c_bd6d, 5); jmpd(0x100c_bf38, 0x1c6); goto l_0x100c_bf38; /* jmp 0x100cbf38 */
        l_0x100c_bd72:
            ii(0x100c_bd72, 2); jmpd(0x100c_bd15, -0x5f); goto l_0x100c_bd15; /* jmp 0x100cbd15 */
        l_0x100c_bd74:
            ii(0x100c_bd74, 2); jmpd(0x100c_bd7e, 0x8); goto l_0x100c_bd7e; /* jmp 0x100cbd7e */
        l_0x100c_bd76:
            ii(0x100c_bd76, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bd79, 5); calld(0x1007_6bf8, -0x5_5186);          /* call 0x10076bf8 */
        l_0x100c_bd7e:
            ii(0x100c_bd7e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bd80, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bd83, 5); calld(0x1013_ad71, 0x6_efe9);           /* call 0x1013ad71 */
            ii(0x100c_bd88, 2); test(al, al);                           /* test al, al */
            ii(0x100c_bd8a, 6); if(jzd(0x100c_be15, 0x85)) goto l_0x100c_be15; /* jz 0x100cbe15 */
            ii(0x100c_bd90, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bd93, 5); calld(0x1008_adc4, -0x4_0fd4);          /* call 0x1008adc4 */
            ii(0x100c_bd98, 5); calld(0x1008_ad90, -0x4_100d);          /* call 0x1008ad90 */
            ii(0x100c_bd9d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_bd9f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_bda2, 4); cmp(dx, memw_a32[ds, eax + 0x9]);       /* cmp dx, [eax+0x9] */
            ii(0x100c_bda6, 2); if(jnzd(0x100c_bde0, 0x38)) goto l_0x100c_bde0; /* jnz 0x100cbde0 */
            ii(0x100c_bda8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bdab, 5); calld(0x1008_adc4, -0x4_0fec);          /* call 0x1008adc4 */
            ii(0x100c_bdb0, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_bdb3, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_bdb6, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_bdb9, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_bdbc, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100c_bdbf, 2); cmp(al, 0x9);                           /* cmp al, 0x9 */
            ii(0x100c_bdc1, 2); if(jzd(0x100c_bdde, 0x1b)) goto l_0x100c_bdde; /* jz 0x100cbdde */
            ii(0x100c_bdc3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bdc6, 5); calld(0x1008_adc4, -0x4_1007);          /* call 0x1008adc4 */
            ii(0x100c_bdcb, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_bdce, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_bdd1, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_bdd4, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_bdd7, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100c_bdda, 2); cmp(al, 0x8);                           /* cmp al, 0x8 */
            ii(0x100c_bddc, 2); if(jnzd(0x100c_bde0, 0x2)) goto l_0x100c_bde0; /* jnz 0x100cbde0 */
        l_0x100c_bdde:
            ii(0x100c_bdde, 2); jmpd(0x100c_bde2, 0x2); goto l_0x100c_bde2; /* jmp 0x100cbde2 */
        l_0x100c_bde0:
            ii(0x100c_bde0, 2); jmpd(0x100c_bdf5, 0x13); goto l_0x100c_bdf5; /* jmp 0x100cbdf5 */
        l_0x100c_bde2:
            ii(0x100c_bde2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bde5, 5); calld(0x1008_adf8, -0x4_0ff2);          /* call 0x1008adf8 */
            ii(0x100c_bdea, 5); calld(0x1009_c4c4, -0x2_f92b);          /* call 0x1009c4c4 */
            ii(0x100c_bdef, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100c_bdf3, 2); if(jzd(0x100c_bdf7, 0x2)) goto l_0x100c_bdf7; /* jz 0x100cbdf7 */
        l_0x100c_bdf5:
            ii(0x100c_bdf5, 2); jmpd(0x100c_be10, 0x19); goto l_0x100c_be10; /* jmp 0x100cbe10 */
        l_0x100c_bdf7:
            ii(0x100c_bdf7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bdf9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bdfc, 5); calld(0x1008_8bbc, -0x4_3245);          /* call 0x10088bbc */
            ii(0x100c_be01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_be03, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_be06, 5); calld(0x1007_5f6c, -0x5_5e9f);          /* call 0x10075f6c */
            ii(0x100c_be0b, 5); jmpd(0x100c_bf38, 0x128); goto l_0x100c_bf38; /* jmp 0x100cbf38 */
        l_0x100c_be10:
            ii(0x100c_be10, 5); jmpd(0x100c_bd76, -0x9f); goto l_0x100c_bd76; /* jmp 0x100cbd76 */
        l_0x100c_be15:
            ii(0x100c_be15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_be18, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_be1b, 5); calld(0x1007_6574, -0x5_58ac);          /* call 0x10076574 */
            ii(0x100c_be20, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100c_be23, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_be26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_be29, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_be2c, 5); calld(0x1007_6574, -0x5_58bd);          /* call 0x10076574 */
            ii(0x100c_be31, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100c_be34, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_be37, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_be3a, 5); calld(0x1007_6aac, -0x5_5393);          /* call 0x10076aac */
            ii(0x100c_be3f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_be43, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100c_be46, 7); test(memb_a32[ds, eax + 0x101c_81c1], 0x2); /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x100c_be4d, 2); if(jzd(0x100c_be83, 0x34)) goto l_0x100c_be83; /* jz 0x100cbe83 */
            ii(0x100c_be4f, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100c_be52, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100c_be55, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_be58, 5); calld(0x1007_5e64, -0x5_5ff9);          /* call 0x10075e64 */
            ii(0x100c_be5d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_be5f, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_be63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_be66, 3); mov(esi, memd_a32[ds, eax + 0x7]);      /* mov esi, [eax+0x7] */
            ii(0x100c_be69, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x100c_be6c, 6); imul(esi, esi, 0xc5);                   /* imul esi, esi, 0xc5 */
            ii(0x100c_be72, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100c_be77, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100c_be79, 5); calld(0x100b_e5c2, -0xd8bc);            /* call 0x100be5c2 */
            ii(0x100c_be7e, 5); jmpd(0x100c_bf24, 0xa1); goto l_0x100c_bf24; /* jmp 0x100cbf24 */
        l_0x100c_be83:
            ii(0x100c_be83, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_be87, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_be8a, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x4_0deb); /* call 0x1008b0a4 */
            ii(0x100c_be8f, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100c_be92, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_be96, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100c_be9b, 5); calld(Definitions.sys_new, 0x9_9f60);   /* call 0x10165e00 */
            ii(0x100c_bea0, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100c_bea3, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100c_bea6, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100c_bea9, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100c_bead, 2); if(jzd(0x100c_bef5, 0x46)) goto l_0x100c_bef5; /* jz 0x100cbef5 */
            ii(0x100c_beaf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_beb2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_beb5, 5); calld(0x1007_6574, -0x5_5946);          /* call 0x10076574 */
            ii(0x100c_beba, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100c_bebd, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_bec0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_bec3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_bec6, 5); calld(0x1007_6574, -0x5_5957);          /* call 0x10076574 */
            ii(0x100c_becb, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100c_bece, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_bed1, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100c_bed4, 5); calld(0x1007_6aac, -0x5_542d);          /* call 0x10076aac */
            ii(0x100c_bed9, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100c_bedb, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100c_bede, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_bee2, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100c_bee5, 5); calld(0x1009_87c5, -0x3_3725);          /* call 0x100987c5 */
            ii(0x100c_beea, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100c_beed, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100c_bef0, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100c_bef3, 2); jmpd(0x100c_befb, 0x6); goto l_0x100c_befb; /* jmp 0x100cbefb */
        l_0x100c_bef5:
            ii(0x100c_bef5, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100c_bef8, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x100c_befb:
            ii(0x100c_befb, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x100c_befe, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_bf01, 5); calld(0x1008_afe4, -0x4_0f22);          /* call 0x1008afe4 */
            ii(0x100c_bf06, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_bf09, 5); calld(0x1008_af84, -0x4_0f8a);          /* call 0x1008af84 */
            ii(0x100c_bf0e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_bf10, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_bf15, 5); calld(0x100a_4d50, -0x2_71ca);          /* call 0x100a4d50 */
            ii(0x100c_bf1a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bf1c, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_bf1f, 5); calld(0x1008_8b7c, -0x4_33a8);          /* call 0x10088b7c */
        l_0x100c_bf24:
            ii(0x100c_bf24, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bf26, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_bf29, 5); calld(0x1008_8bbc, -0x4_3372);          /* call 0x10088bbc */
            ii(0x100c_bf2e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_bf30, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_bf33, 5); calld(0x1007_5f6c, -0x5_5fcc);          /* call 0x10075f6c */
        l_0x100c_bf38:
            ii(0x100c_bf38, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_bf3a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_bf3b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_bf3c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_bf3d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_bf3e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_bf3f, 1); retd(); return;                         /* ret */
        }
    }
}
