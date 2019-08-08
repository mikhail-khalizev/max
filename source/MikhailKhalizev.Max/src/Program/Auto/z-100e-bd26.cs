using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("69e3a943-371d-4bf7-8511-15e486874bba")]
        public void Method_100e_bd26()
        {
            ii(0x100e_bd26, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100e_bd2b, 5); calld(Definitions.sys_check_available_stack_size, 0x7_a022); /* call 0x10165d52 */
            ii(0x100e_bd30, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_bd31, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_bd32, 1); pushd(edx);                             /* push edx */
            ii(0x100e_bd33, 1); pushd(esi);                             /* push esi */
            ii(0x100e_bd34, 1); pushd(edi);                             /* push edi */
            ii(0x100e_bd35, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_bd36, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_bd38, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100e_bd3e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_bd41, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_bd46, 5); calld(0x1007_6338, -0x7_5a13);          /* call 0x10076338 */
            ii(0x100e_bd4b, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100e_bd4e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_bd50, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_bd52, 5); calld(0x1007_64b8, -0x7_589f);          /* call 0x100764b8 */
            ii(0x100e_bd57, 2); jmpd(0x100e_bd61, 0x8); goto l_0x100e_bd61; /* jmp 0x100ebd61 */
        l_0x100e_bd59:
            ii(0x100e_bd59, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bd5c, 5); calld(0x1007_6bf8, -0x7_5169);          /* call 0x10076bf8 */
        l_0x100e_bd61:
            ii(0x100e_bd61, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bd63, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bd66, 5); calld(0x1013_ad71, 0x4_f006);           /* call 0x1013ad71 */
            ii(0x100e_bd6b, 2); test(al, al);                           /* test al, al */
            ii(0x100e_bd6d, 6); if(jzd(0x100e_bde4, 0x71)) goto l_0x100e_bde4; /* jz 0x100ebde4 */
            ii(0x100e_bd73, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bd76, 5); calld(0x1007_63a0, -0x7_59db);          /* call 0x100763a0 */
            ii(0x100e_bd7b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bd7d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_bd80, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_bd84, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_bd86, 2); if(jnzd(0x100e_bddb, 0x53)) goto l_0x100e_bddb; /* jnz 0x100ebddb */
            ii(0x100e_bd88, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bd8b, 5); calld(0x1007_63a0, -0x7_59f0);          /* call 0x100763a0 */
            ii(0x100e_bd90, 5); cmp(memw_a32[ds, eax + 0x8], 0x17);     /* cmp word [eax+0x8], 0x17 */
            ii(0x100e_bd95, 2); if(jzd(0x100e_bda6, 0xf)) goto l_0x100e_bda6; /* jz 0x100ebda6 */
            ii(0x100e_bd97, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bd9a, 5); calld(0x1007_63a0, -0x7_59ff);          /* call 0x100763a0 */
            ii(0x100e_bd9f, 5); cmp(memw_a32[ds, eax + 0x8], 0x18);     /* cmp word [eax+0x8], 0x18 */
            ii(0x100e_bda4, 2); if(jnzd(0x100e_bda8, 0x2)) goto l_0x100e_bda8; /* jnz 0x100ebda8 */
        l_0x100e_bda6:
            ii(0x100e_bda6, 2); jmpd(0x100e_bdb7, 0xf); goto l_0x100e_bdb7; /* jmp 0x100ebdb7 */
        l_0x100e_bda8:
            ii(0x100e_bda8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bdab, 5); calld(0x1007_63a0, -0x7_5a10);          /* call 0x100763a0 */
            ii(0x100e_bdb0, 5); cmp(memw_a32[ds, eax + 0x8], 0x19);     /* cmp word [eax+0x8], 0x19 */
            ii(0x100e_bdb5, 2); if(jnzd(0x100e_bdb9, 0x2)) goto l_0x100e_bdb9; /* jnz 0x100ebdb9 */
        l_0x100e_bdb7:
            ii(0x100e_bdb7, 2); jmpd(0x100e_bdc8, 0xf); goto l_0x100e_bdc8; /* jmp 0x100ebdc8 */
        l_0x100e_bdb9:
            ii(0x100e_bdb9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bdbc, 5); calld(0x1007_63a0, -0x7_5a21);          /* call 0x100763a0 */
            ii(0x100e_bdc1, 5); cmp(memw_a32[ds, eax + 0x8], 0x1b);     /* cmp word [eax+0x8], 0x1b */
            ii(0x100e_bdc6, 2); if(jnzd(0x100e_bdca, 0x2)) goto l_0x100e_bdca; /* jnz 0x100ebdca */
        l_0x100e_bdc8:
            ii(0x100e_bdc8, 2); jmpd(0x100e_bdd9, 0xf); goto l_0x100e_bdd9; /* jmp 0x100ebdd9 */
        l_0x100e_bdca:
            ii(0x100e_bdca, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bdcd, 5); calld(0x1007_63a0, -0x7_5a32);          /* call 0x100763a0 */
            ii(0x100e_bdd2, 5); cmp(memw_a32[ds, eax + 0x8], 0x20);     /* cmp word [eax+0x8], 0x20 */
            ii(0x100e_bdd7, 2); if(jnzd(0x100e_bddb, 0x2)) goto l_0x100e_bddb; /* jnz 0x100ebddb */
        l_0x100e_bdd9:
            ii(0x100e_bdd9, 2); jmpd(0x100e_bddd, 0x2); goto l_0x100e_bddd; /* jmp 0x100ebddd */
        l_0x100e_bddb:
            ii(0x100e_bddb, 2); jmpd(0x100e_bddf, 0x2); goto l_0x100e_bddf; /* jmp 0x100ebddf */
        l_0x100e_bddd:
            ii(0x100e_bddd, 2); jmpd(0x100e_bde4, 0x5); goto l_0x100e_bde4; /* jmp 0x100ebde4 */
        l_0x100e_bddf:
            ii(0x100e_bddf, 5); jmpd(0x100e_bd59, -0x8b); goto l_0x100e_bd59; /* jmp 0x100ebd59 */
        l_0x100e_bde4:
            ii(0x100e_bde4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bde6, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bde9, 5); calld(0x1013_ad11, 0x4_ef23);           /* call 0x1013ad11 */
            ii(0x100e_bdee, 2); test(al, al);                           /* test al, al */
            ii(0x100e_bdf0, 2); if(jzd(0x100e_be05, 0x13)) goto l_0x100e_be05; /* jz 0x100ebe05 */
            ii(0x100e_bdf2, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_bdf6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bdf8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bdfb, 5); calld(0x1007_5f6c, -0x7_5e94);          /* call 0x10075f6c */
            ii(0x100e_be00, 5); jmpd(0x100e_bf6f, 0x16a); goto l_0x100e_bf6f; /* jmp 0x100ebf6f */
        l_0x100e_be05:
            ii(0x100e_be05, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100e_be0a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_be0e, 5); calld(0x100e_bbf7, -0x21c);             /* call 0x100ebbf7 */
            ii(0x100e_be13, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_be16, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_be1b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_be1f, 5); calld(0x100e_bbf7, -0x22d);             /* call 0x100ebbf7 */
            ii(0x100e_be24, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_be27, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100e_be2e, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100e_be35, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_be39, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100e_be3c, 2); if(jld(0x100e_be4b, 0xd)) goto l_0x100e_be4b; /* jl 0x100ebe4b */
            ii(0x100e_be3e, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_be42, 3); cmp(eax, 0x18);                         /* cmp eax, 0x18 */
            ii(0x100e_be45, 6); if(jged(0x100e_becb, 0x80)) goto l_0x100e_becb; /* jge 0x100ebecb */
        l_0x100e_be4b:
            ii(0x100e_be4b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_be50, 5); calld(0x1007_6338, -0x7_5b1d);          /* call 0x10076338 */
            ii(0x100e_be55, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100e_be58, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_be5a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_be5c, 5); calld(0x1007_643c, -0x7_5a25);          /* call 0x1007643c */
            ii(0x100e_be61, 2); jmpd(0x100e_be6b, 0x8); goto l_0x100e_be6b; /* jmp 0x100ebe6b */
        l_0x100e_be63:
            ii(0x100e_be63, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_be66, 5); calld(0x1007_6bf8, -0x7_5273);          /* call 0x10076bf8 */
        l_0x100e_be6b:
            ii(0x100e_be6b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_be6d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_be70, 5); calld(0x1013_ad71, 0x4_eefc);           /* call 0x1013ad71 */
            ii(0x100e_be75, 2); test(al, al);                           /* test al, al */
            ii(0x100e_be77, 2); if(jzd(0x100e_bea3, 0x2a)) goto l_0x100e_bea3; /* jz 0x100ebea3 */
            ii(0x100e_be79, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_be7c, 5); calld(0x1007_63a0, -0x7_5ae1);          /* call 0x100763a0 */
            ii(0x100e_be81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_be83, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_be86, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_be8a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_be8c, 2); if(jnzd(0x100e_be9d, 0xf)) goto l_0x100e_be9d; /* jnz 0x100ebe9d */
            ii(0x100e_be8e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_be91, 5); calld(0x1007_63a0, -0x7_5af6);          /* call 0x100763a0 */
            ii(0x100e_be96, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100e_be9b, 2); if(jzd(0x100e_be9f, 0x2)) goto l_0x100e_be9f; /* jz 0x100ebe9f */
        l_0x100e_be9d:
            ii(0x100e_be9d, 2); jmpd(0x100e_bea1, 0x2); goto l_0x100e_bea1; /* jmp 0x100ebea1 */
        l_0x100e_be9f:
            ii(0x100e_be9f, 2); jmpd(0x100e_bea3, 0x2); goto l_0x100e_bea3; /* jmp 0x100ebea3 */
        l_0x100e_bea1:
            ii(0x100e_bea1, 2); jmpd(0x100e_be63, -0x40); goto l_0x100e_be63; /* jmp 0x100ebe63 */
        l_0x100e_bea3:
            ii(0x100e_bea3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bea5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bea8, 5); calld(0x1013_ad11, 0x4_ee64);           /* call 0x1013ad11 */
            ii(0x100e_bead, 2); test(al, al);                           /* test al, al */
            ii(0x100e_beaf, 2); if(jzd(0x100e_bec4, 0x13)) goto l_0x100e_bec4; /* jz 0x100ebec4 */
            ii(0x100e_beb1, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_beb5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_beb7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_beba, 5); calld(0x1007_5f6c, -0x7_5f53);          /* call 0x10075f6c */
            ii(0x100e_bebf, 5); jmpd(0x100e_bf6f, 0xab); goto l_0x100e_bf6f; /* jmp 0x100ebf6f */
        l_0x100e_bec4:
            ii(0x100e_bec4, 7); mov(memd_a32[ss, ebp - 0x1c], 0x2);     /* mov dword [ebp-0x1c], 0x2 */
        l_0x100e_becb:
            ii(0x100e_becb, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_bed0, 5); calld(0x1007_6338, -0x7_5b9d);          /* call 0x10076338 */
            ii(0x100e_bed5, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100e_bed8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_beda, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_bedc, 5); calld(0x1007_643c, -0x7_5aa5);          /* call 0x1007643c */
            ii(0x100e_bee1, 2); jmpd(0x100e_beeb, 0x8); goto l_0x100e_beeb; /* jmp 0x100ebeeb */
        l_0x100e_bee3:
            ii(0x100e_bee3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bee6, 5); calld(0x1007_6bf8, -0x7_52f3);          /* call 0x10076bf8 */
        l_0x100e_beeb:
            ii(0x100e_beeb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_beed, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bef0, 5); calld(0x1013_ad71, 0x4_ee7c);           /* call 0x1013ad71 */
            ii(0x100e_bef5, 2); test(al, al);                           /* test al, al */
            ii(0x100e_bef7, 2); if(jzd(0x100e_bf40, 0x47)) goto l_0x100e_bf40; /* jz 0x100ebf40 */
            ii(0x100e_bef9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_befc, 5); calld(0x1007_63a0, -0x7_5b61);          /* call 0x100763a0 */
            ii(0x100e_bf01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bf03, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_bf06, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_bf0a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_bf0c, 2); if(jnzd(0x100e_bf26, 0x18)) goto l_0x100e_bf26; /* jnz 0x100ebf26 */
            ii(0x100e_bf0e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bf11, 5); calld(0x1007_63a0, -0x7_5b76);          /* call 0x100763a0 */
            ii(0x100e_bf16, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_bf19, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_bf1c, 5); calld(0x1007_1f2e, -0x7_9ff3);          /* call 0x10071f2e */
            ii(0x100e_bf21, 1); cwde();                                 /* cwde */
            ii(0x100e_bf22, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_bf24, 2); if(jld(0x100e_bf28, 0x2)) goto l_0x100e_bf28; /* jl 0x100ebf28 */
        l_0x100e_bf26:
            ii(0x100e_bf26, 2); jmpd(0x100e_bf3e, 0x16); goto l_0x100e_bf3e; /* jmp 0x100ebf3e */
        l_0x100e_bf28:
            ii(0x100e_bf28, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bf2b, 5); calld(0x1007_63a0, -0x7_5b90);          /* call 0x100763a0 */
            ii(0x100e_bf30, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_bf33, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_bf36, 5); calld(0x1007_1f2e, -0x7_a00d);          /* call 0x10071f2e */
            ii(0x100e_bf3b, 3); sub(memd_a32[ss, ebp - 0xc], eax);      /* sub [ebp-0xc], eax */
        l_0x100e_bf3e:
            ii(0x100e_bf3e, 2); jmpd(0x100e_bee3, -0x5d); goto l_0x100e_bee3; /* jmp 0x100ebee3 */
        l_0x100e_bf40:
            ii(0x100e_bf40, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_bf43, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x100e_bf47, 2); if(jld(0x100e_bf4f, 0x6)) goto l_0x100e_bf4f; /* jl 0x100ebf4f */
            ii(0x100e_bf49, 4); mov(memb_a32[ss, ebp - 0x20], 0x1);     /* mov byte [ebp-0x20], 0x1 */
            ii(0x100e_bf4d, 2); jmpd(0x100e_bf53, 0x4); goto l_0x100e_bf53; /* jmp 0x100ebf53 */
        l_0x100e_bf4f:
            ii(0x100e_bf4f, 4); mov(memb_a32[ss, ebp - 0x20], 0);       /* mov byte [ebp-0x20], 0x0 */
        l_0x100e_bf53:
            ii(0x100e_bf53, 3); mov(al, memb_a32[ss, ebp - 0x20]);      /* mov al, [ebp-0x20] */
            ii(0x100e_bf56, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100e_bf59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bf5b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_bf5e, 5); calld(0x1007_5f6c, -0x7_5ff7);          /* call 0x10075f6c */
            ii(0x100e_bf63, 2); jmpd(0x100e_bf6f, 0xa); goto l_0x100e_bf6f; /* jmp 0x100ebf6f */
        //    ii(0x100e_bf65, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100e_bf67, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //    ii(0x100e_bf6a, 5); calld(0x1007_5f6c, -0x7_6003);          /* call 0x10075f6c */
        l_0x100e_bf6f:
            ii(0x100e_bf6f, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_bf72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_bf74, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_bf75, 1); popd(edi);                              /* pop edi */
            ii(0x100e_bf76, 1); popd(esi);                              /* pop esi */
            ii(0x100e_bf77, 1); popd(edx);                              /* pop edx */
            ii(0x100e_bf78, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_bf79, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_bf7a, 1); retd(); return;                         /* ret */
        }
    }
}
