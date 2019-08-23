using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_df2e-afb160a")]
        public void Method_1011_df2e()
        {
            ii(0x1011_df2e, 5); pushd(0xd4);                            /* push 0xd4 */
            ii(0x1011_df33, 5); calld(Definitions.sys_check_available_stack_size, 0x4_7e1a); /* call 0x10165d52 */
            ii(0x1011_df38, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_df39, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_df3a, 1); pushd(edx);                             /* push edx */
            ii(0x1011_df3b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_df3c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_df3d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_df3e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_df40, 6); sub(esp, 0xa4);                         /* sub esp, 0xa4 */
            ii(0x1011_df46, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_df49, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1011_df4d, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_df50, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xa_7865); /* call 0x100766f0 */
            ii(0x1011_df55, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1011_df58, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1011_df5c, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1011_df60, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_df63, 5); calld(0x100a_b3f4, -0x7_2b74);          /* call 0x100ab3f4 */
            ii(0x1011_df68, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_df6b, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1011_df6f, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1011_df73, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_df76, 5); calld(0x100b_7fdc, -0x6_5f9f);          /* call 0x100b7fdc */
            ii(0x1011_df7b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_df7e, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1011_df82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_df84, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_df87, 5); calld(0x1013_ad71, 0x1_cde5);           /* call 0x1013ad71 */
            ii(0x1011_df8c, 2); test(al, al);                           /* test al, al */
            ii(0x1011_df8e, 2); if(jzd(0x1011_dfca, 0x3a)) goto l_0x1011_dfca; /* jz 0x1011dfca */
            ii(0x1011_df90, 5); calld(0x1014_82f4, 0x2_a35f);           /* call 0x101482f4 */
            ii(0x1011_df95, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_df97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_df9a, 3); sub(edx, memd_a32[ds, eax + 0x12]);     /* sub edx, [eax+0x12] */
            ii(0x1011_df9d, 3); mov(memd_a32[ds, eax + 0x12], edx);     /* mov [eax+0x12], edx */
            ii(0x1011_dfa0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dfa3, 4); cmp(memd_a32[ds, eax + 0x1a], 0);       /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_dfa7, 2); if(jnzd(0x1011_dfca, 0x21)) goto l_0x1011_dfca; /* jnz 0x1011dfca */
            ii(0x1011_dfa9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dfac, 5); calld(0x100b_7f74, -0x6_603d);          /* call 0x100b7f74 */
            ii(0x1011_dfb1, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1011_dfb4, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1011_dfb7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_dfb9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_dfbb, 5); calld(0x1012_0834, 0x2874);             /* call 0x10120834 */
            ii(0x1011_dfc0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_dfc2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dfc5, 5); calld(0x100b_7fa4, -0x6_6026);          /* call 0x100b7fa4 */
        l_0x1011_dfca:
            ii(0x1011_dfca, 5); calld(0x1014_82f4, 0x2_a325);           /* call 0x101482f4 */
            ii(0x1011_dfcf, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x1011_dfd5, 6); cmp(eax, memd_a32[ds, 0x101b_dd84]);    /* cmp eax, [0x101bdd84] */
            ii(0x1011_dfdb, 2); if(jbed(0x1011_dffd, 0x20)) goto l_0x1011_dffd; /* jbe 0x1011dffd */
            ii(0x1011_dfdd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_dfdf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dfe2, 5); calld(0x1013_ad71, 0x1_cd8a);           /* call 0x1013ad71 */
            ii(0x1011_dfe7, 2); test(al, al);                           /* test al, al */
            ii(0x1011_dfe9, 2); if(jnzd(0x1011_dffb, 0x10)) goto l_0x1011_dffb; /* jnz 0x1011dffb */
            ii(0x1011_dfeb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dfee, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_dff1, 5); calld(0x1007_6b90, -0xa_7466);          /* call 0x10076b90 */
            ii(0x1011_dff6, 1); cwde();                                 /* cwde */
            ii(0x1011_dff7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_dff9, 2); if(jled(0x1011_dffd, 0x2)) goto l_0x1011_dffd; /* jle 0x1011dffd */
        l_0x1011_dffb:
            ii(0x1011_dffb, 2); jmpd(0x1011_dfff, 0x2); goto l_0x1011_dfff; /* jmp 0x1011dfff */
        l_0x1011_dffd:
            ii(0x1011_dffd, 2); jmpd(0x1011_e032, 0x33); goto l_0x1011_e032; /* jmp 0x1011e032 */
        l_0x1011_dfff:
            ii(0x1011_dfff, 5); calld(0x1014_82f4, 0x2_a2f0);           /* call 0x101482f4 */
            ii(0x1011_e004, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e006, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e009, 3); sub(edx, memd_a32[ds, eax + 0x12]);     /* sub edx, [eax+0x12] */
            ii(0x1011_e00c, 3); mov(memd_a32[ds, eax + 0x12], edx);     /* mov [eax+0x12], edx */
            ii(0x1011_e00f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e011, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_e014, 5); calld(0x100b_7368, -0x6_6cb1);          /* call 0x100b7368 */
            ii(0x1011_e019, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e01b, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_e01e, 5); calld(0x100a_9f38, -0x7_40eb);          /* call 0x100a9f38 */
            ii(0x1011_e023, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e025, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_e028, 5); calld(0x1007_5f2c, -0xa_8101);          /* call 0x10075f2c */
            ii(0x1011_e02d, 5); jmpd(0x1011_e339, 0x307); goto l_0x1011_e339; /* jmp 0x1011e339 */
        l_0x1011_e032:
            ii(0x1011_e032, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e034, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e037, 5); calld(0x1013_ad11, 0x1_ccd5);           /* call 0x1013ad11 */
            ii(0x1011_e03c, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e03e, 6); if(jzd(0x1011_e0ca, 0x86)) goto l_0x1011_e0ca; /* jz 0x1011e0ca */
            ii(0x1011_e044, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e047, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_e04a, 5); calld(0x1007_6b90, -0xa_74bf);          /* call 0x10076b90 */
            ii(0x1011_e04f, 1); cwde();                                 /* cwde */
            ii(0x1011_e050, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_e052, 2); if(jnzd(0x1011_e077, 0x23)) goto l_0x1011_e077; /* jnz 0x1011e077 */
            ii(0x1011_e054, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e056, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_e059, 5); calld(0x100b_7368, -0x6_6cf6);          /* call 0x100b7368 */
            ii(0x1011_e05e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e060, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_e063, 5); calld(0x100a_9f38, -0x7_4130);          /* call 0x100a9f38 */
            ii(0x1011_e068, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e06a, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_e06d, 5); calld(0x1007_5f2c, -0xa_8146);          /* call 0x10075f2c */
            ii(0x1011_e072, 5); jmpd(0x1011_e339, 0x2c2); goto l_0x1011_e339; /* jmp 0x1011e339 */
        l_0x1011_e077:
            ii(0x1011_e077, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e07a, 5); calld(0x1011_f679, 0x15fa);             /* call 0x1011f679 */
            ii(0x1011_e07f, 5); calld(0x1014_82f4, 0x2_a270);           /* call 0x101482f4 */
            ii(0x1011_e084, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x1011_e08a, 6); cmp(eax, memd_a32[ds, 0x101b_dd84]);    /* cmp eax, [0x101bdd84] */
            ii(0x1011_e090, 2); if(jbed(0x1011_e0c5, 0x33)) goto l_0x1011_e0c5; /* jbe 0x1011e0c5 */
            ii(0x1011_e092, 5); calld(0x1014_82f4, 0x2_a25d);           /* call 0x101482f4 */
            ii(0x1011_e097, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e099, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e09c, 3); sub(edx, memd_a32[ds, eax + 0x12]);     /* sub edx, [eax+0x12] */
            ii(0x1011_e09f, 3); mov(memd_a32[ds, eax + 0x12], edx);     /* mov [eax+0x12], edx */
            ii(0x1011_e0a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e0a4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_e0a7, 5); calld(0x100b_7368, -0x6_6d44);          /* call 0x100b7368 */
            ii(0x1011_e0ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e0ae, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_e0b1, 5); calld(0x100a_9f38, -0x7_417e);          /* call 0x100a9f38 */
            ii(0x1011_e0b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e0b8, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_e0bb, 5); calld(0x1007_5f2c, -0xa_8194);          /* call 0x10075f2c */
            ii(0x1011_e0c0, 5); jmpd(0x1011_e339, 0x274); goto l_0x1011_e339; /* jmp 0x1011e339 */
        l_0x1011_e0c5:
            ii(0x1011_e0c5, 5); jmpd(0x1011_e032, -0x98); goto l_0x1011_e032; /* jmp 0x1011e032 */
        l_0x1011_e0ca:
            ii(0x1011_e0ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e0cd, 5); calld(0x100b_7f18, -0x6_61ba);          /* call 0x100b7f18 */
            ii(0x1011_e0d2, 5); calld(Definitions.my__get_unit, -0x6_60bb); /* call 0x100b801c */
            ii(0x1011_e0d7, 3); lea(ebx, ebp - 0x34);                   /* lea ebx, [ebp-0x34] */
            ii(0x1011_e0da, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e0dc, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_e0de, 5); calld(0x1007_6630, -0xa_7ab3);          /* call 0x10076630 */
            ii(0x1011_e0e3, 7); mov(memd_a32[ss, ebp - 0xc], 0x5);      /* mov dword [ebp-0xc], 0x5 */
            ii(0x1011_e0ea, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_e0ed, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_e0f0, 5); calld(0x1012_0908, 0x2813);             /* call 0x10120908 */
        l_0x1011_e0f5:
            ii(0x1011_e0f5, 5); calld(0x100e_a7e7, -0x3_3913);          /* call 0x100ea7e7 */
            ii(0x1011_e0fa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_e0fd, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1011_e100, 1); cwde();                                 /* cwde */
            ii(0x1011_e101, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_e103, 2); if(jgd(0x1011_e152, 0x4d)) goto l_0x1011_e152; /* jg 0x1011e152 */
            ii(0x1011_e105, 7); mov(memd_a32[ss, ebp - 0xc], 0x5);      /* mov dword [ebp-0xc], 0x5 */
            ii(0x1011_e10c, 5); calld(0x1014_82f4, 0x2_a1e3);           /* call 0x101482f4 */
            ii(0x1011_e111, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x1011_e117, 6); cmp(eax, memd_a32[ds, 0x101b_dd84]);    /* cmp eax, [0x101bdd84] */
            ii(0x1011_e11d, 2); if(jbed(0x1011_e152, 0x33)) goto l_0x1011_e152; /* jbe 0x1011e152 */
            ii(0x1011_e11f, 5); calld(0x1014_82f4, 0x2_a1d0);           /* call 0x101482f4 */
            ii(0x1011_e124, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e126, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e129, 3); sub(edx, memd_a32[ds, eax + 0x12]);     /* sub edx, [eax+0x12] */
            ii(0x1011_e12c, 3); mov(memd_a32[ds, eax + 0x12], edx);     /* mov [eax+0x12], edx */
            ii(0x1011_e12f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e131, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_e134, 5); calld(0x100b_7368, -0x6_6dd1);          /* call 0x100b7368 */
            ii(0x1011_e139, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e13b, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_e13e, 5); calld(0x100a_9f38, -0x7_420b);          /* call 0x100a9f38 */
            ii(0x1011_e143, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e145, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_e148, 5); calld(0x1007_5f2c, -0xa_8221);          /* call 0x10075f2c */
            ii(0x1011_e14d, 5); jmpd(0x1011_e339, 0x1e7); goto l_0x1011_e339; /* jmp 0x1011e339 */
        l_0x1011_e152:
            ii(0x1011_e152, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1011_e155, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e158, 5); calld(0x1009_cbc4, -0x8_1599);          /* call 0x1009cbc4 */
            ii(0x1011_e15d, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e15f, 2); if(jzd(0x1011_e184, 0x23)) goto l_0x1011_e184; /* jz 0x1011e184 */
            ii(0x1011_e161, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e163, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_e166, 5); calld(0x100b_7368, -0x6_6e03);          /* call 0x100b7368 */
            ii(0x1011_e16b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e16d, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_e170, 5); calld(0x100a_9f38, -0x7_423d);          /* call 0x100a9f38 */
            ii(0x1011_e175, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e177, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_e17a, 5); calld(0x1007_5f2c, -0xa_8253);          /* call 0x10075f2c */
            ii(0x1011_e17f, 5); jmpd(0x1011_e339, 0x1b5); goto l_0x1011_e339; /* jmp 0x1011e339 */
        l_0x1011_e184:
            ii(0x1011_e184, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e187, 4); cmp(memd_a32[ds, eax + 0x1a], 0);       /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_e18b, 2); if(jzd(0x1011_e196, 0x9)) goto l_0x1011_e196; /* jz 0x1011e196 */
            ii(0x1011_e18d, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x1011_e194, 2); jmpd(0x1011_e1af, 0x19); goto l_0x1011_e1af; /* jmp 0x1011e1af */
        l_0x1011_e196:
            ii(0x1011_e196, 5); mov(ecx, 0xacb);                        /* mov ecx, 0xacb */
            ii(0x1011_e19b, 5); mov(ebx, StringDefinitions.PathsCpp);   /* mov ebx, 0x101a7d9e */
            ii(0x1011_e1a0, 5); mov(edx, StringDefinitions.BackwardSearcherNotEqual0); /* mov edx, 0x101a7da8 */
            ii(0x1011_e1a5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_e1a7, 5); calld(Definitions.sys_assert, 0x4_7be6); /* call 0x10165d92 */
            ii(0x1011_e1ac, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1011_e1af:
            ii(0x1011_e1af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e1b2, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x1011_e1b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e1b8, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1011_e1bb, 5); calld(0x1011_cc04, -0x15bc);            /* call 0x1011cc04 */
            ii(0x1011_e1c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e1c3, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1011_e1c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e1c9, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_e1cc, 5); calld(0x1011_ca0a, -0x17c7);            /* call 0x1011ca0a */
            ii(0x1011_e1d1, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e1d3, 6); if(jnzd(0x1011_e0f5, -0xe4)) goto l_0x1011_e0f5; /* jnz 0x1011e0f5 */
            ii(0x1011_e1d9, 5); mov(eax, memd_a32[ds, 0x101c_52e2]);    /* mov eax, [0x101c52e2] */
            ii(0x1011_e1de, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_e1e1, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_e1e4, 2); if(jld(0x1011_e237, 0x51)) goto l_0x1011_e237; /* jl 0x1011e237 */
            ii(0x1011_e1e6, 5); mov(eax, memd_a32[ds, 0x101c_52fa]);    /* mov eax, [0x101c52fa] */
            ii(0x1011_e1eb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_e1ee, 1); pushd(eax);                             /* push eax */
            ii(0x1011_e1ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e1f2, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1011_e1f5, 5); calld(0x1014_85ad, 0x2_a3b3);           /* call 0x101485ad */
            ii(0x1011_e1fa, 1); pushd(eax);                             /* push eax */
            ii(0x1011_e1fb, 6); pushd(memd_a32[ds, 0x101c_52e8]);       /* push dword [0x101c52e8] */
            ii(0x1011_e201, 5); mov(eax, StringDefinitions.DebugPathGeneratorEvaluatedLiTilesInLiMsecsMaxDepthI); /* mov eax, 0x101a7dbf */
            ii(0x1011_e206, 1); pushd(eax);                             /* push eax */
            ii(0x1011_e207, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x1011_e20d, 1); pushd(eax);                             /* push eax */
            ii(0x1011_e20e, 5); calld(Definitions.sys_sprintf, 0x4_7cee); /* call 0x10165f01 */
            ii(0x1011_e213, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1011_e216, 5); calld(0x100c_aa00, -0x5_381b);          /* call 0x100caa00 */
            ii(0x1011_e21b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_e220, 1); pushd(eax);                             /* push eax */
            ii(0x1011_e221, 5); calld(0x100c_aa20, -0x5_3806);          /* call 0x100caa20 */
            ii(0x1011_e226, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_e228, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_e22a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e22c, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x1011_e232, 5); calld(0x1011_5d23, -0x8514);            /* call 0x10115d23 */
        l_0x1011_e237:
            ii(0x1011_e237, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e23a, 3); pushd(memd_a32[ds, eax + 0x1a]);        /* push dword [eax+0x1a] */
            ii(0x1011_e23d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e240, 5); calld(0x100b_7f18, -0x6_632d);          /* call 0x100b7f18 */
            ii(0x1011_e245, 5); calld(0x1012_09c8, 0x277e);             /* call 0x101209c8 */
            ii(0x1011_e24a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_e24d, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_e250, 5); calld(0x1007_6574, -0xa_7ce1);          /* call 0x10076574 */
            ii(0x1011_e255, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1011_e258, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_e25b, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_e25e, 5); calld(0x1007_6574, -0xa_7cef);          /* call 0x10076574 */
            ii(0x1011_e263, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1011_e266, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_e269, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_e26c, 5); calld(0x1007_6aac, -0xa_77c5);          /* call 0x10076aac */
            ii(0x1011_e271, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_e273, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1011_e276, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e279, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_e27c, 5); calld(0x1011_ce26, -0x145b);            /* call 0x1011ce26 */
            ii(0x1011_e281, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e283, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_e286, 5); calld(0x1012_0ad0, 0x2845);             /* call 0x10120ad0 */
            ii(0x1011_e28b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e28d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e290, 5); calld(0x100a_9f38, -0x7_435d);          /* call 0x100a9f38 */
            ii(0x1011_e295, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e298, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_e29b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_e29e, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_e2a2, 2); if(jzd(0x1011_e2bb, 0x17)) goto l_0x1011_e2bb; /* jz 0x1011e2bb */
            ii(0x1011_e2a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e2a6, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_e2a9, 5); calld(Definitions.my_dtor_d7, -0x206c); /* call 0x1011c242 */
            ii(0x1011_e2ae, 5); calld(Definitions.sys_delete, 0x4_7cb1); /* call 0x10165f64 */
            ii(0x1011_e2b3, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x1011_e2b9, 2); jmpd(0x1011_e2c5, 0xa); goto l_0x1011_e2c5; /* jmp 0x1011e2c5 */
        l_0x1011_e2bb:
            ii(0x1011_e2bb, 10); mov(memd_a32[ss, ebp - 0xa0], 0);      /* mov dword [ebp-0xa0], 0x0 */
        l_0x1011_e2c5:
            ii(0x1011_e2c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e2c8, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1011_e2cb, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_e2ce, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1011_e2d2, 2); if(jzd(0x1011_e2eb, 0x17)) goto l_0x1011_e2eb; /* jz 0x1011e2eb */
            ii(0x1011_e2d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e2d6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_e2d9, 5); calld(Definitions.my_dtor_d7, -0x209c); /* call 0x1011c242 */
            ii(0x1011_e2de, 5); calld(Definitions.sys_delete, 0x4_7c81); /* call 0x10165f64 */
            ii(0x1011_e2e3, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x1011_e2e9, 2); jmpd(0x1011_e2f5, 0xa); goto l_0x1011_e2f5; /* jmp 0x1011e2f5 */
        l_0x1011_e2eb:
            ii(0x1011_e2eb, 10); mov(memd_a32[ss, ebp - 0xa4], 0);      /* mov dword [ebp-0xa4], 0x0 */
        l_0x1011_e2f5:
            ii(0x1011_e2f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e2f8, 7); mov(memd_a32[ds, eax + 0x16], 0);       /* mov dword [eax+0x16], 0x0 */
            ii(0x1011_e2ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e302, 7); mov(memd_a32[ds, eax + 0x1a], 0);       /* mov dword [eax+0x1a], 0x0 */
            ii(0x1011_e309, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_e30c, 5); calld(0x100a_b33c, -0x7_2fd5);          /* call 0x100ab33c */
            ii(0x1011_e311, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e313, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_e316, 5); calld(0x1011_e342, 0x27);               /* call 0x1011e342 */
            ii(0x1011_e31b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e31d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_e320, 5); calld(0x100b_7368, -0x6_6fbd);          /* call 0x100b7368 */
            ii(0x1011_e325, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e327, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_e32a, 5); calld(0x100a_9f38, -0x7_43f7);          /* call 0x100a9f38 */
            ii(0x1011_e32f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e331, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_e334, 5); calld(0x1007_5f2c, -0xa_840d);          /* call 0x10075f2c */
        l_0x1011_e339:
            ii(0x1011_e339, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_e33b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_e33c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_e33d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_e33e, 1); popd(edx);                              /* pop edx */
            ii(0x1011_e33f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_e340, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_e341, 1); retd();                                 /* ret */
        }
    }
}
