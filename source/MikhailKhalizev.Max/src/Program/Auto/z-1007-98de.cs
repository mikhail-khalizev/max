using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_98de-bfb28d3b")]
        public void Method_1007_98de()
        {
            ii(0x1007_98de, 5); pushd(0x164);                           /* push 0x164 */
            ii(0x1007_98e3, 5); calld(Definitions.sys_check_available_stack_size, 0xe_c46a); /* call 0x10165d52 */
            ii(0x1007_98e8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_98e9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_98ea, 1); pushd(esi);                             /* push esi */
            ii(0x1007_98eb, 1); pushd(edi);                             /* push edi */
            ii(0x1007_98ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_98ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_98ef, 6); sub(esp, 0x14c);                        /* sub esp, 0x14c */
            ii(0x1007_98f5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_98f8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_98fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_98fe, 5); calld(0x1007_623c, -0x36c7);            /* call 0x1007623c */
            ii(0x1007_9903, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1007_9906, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9909, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_990b, 6); if(jnzd(0x1007_9dce, 0x4bd)) goto l_0x1007_9dce; /* jnz 0x10079dce */
            ii(0x1007_9911, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9914, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9916, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_9919, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_991c, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_991f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9922, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_9924, 2); if(jnzd(0x1007_992f, 0x9)) goto l_0x1007_992f; /* jnz 0x1007992f */
            ii(0x1007_9926, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9929, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_992d, 2); if(jnzd(0x1007_9934, 0x5)) goto l_0x1007_9934; /* jnz 0x10079934 */
        l_0x1007_992f:
            ii(0x1007_992f, 5); jmpd(0x1007_9dc9, 0x495); goto l_0x1007_9dc9; /* jmp 0x10079dc9 */
        l_0x1007_9934:
            ii(0x1007_9934, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9937, 5); cmp(memw_a32[ds, eax + 0x8], 0x19);     /* cmp word [eax+0x8], 0x19 */
            ii(0x1007_993c, 2); if(jzd(0x1007_9948, 0xa)) goto l_0x1007_9948; /* jz 0x10079948 */
            ii(0x1007_993e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9941, 5); cmp(memw_a32[ds, eax + 0x8], 0x18);     /* cmp word [eax+0x8], 0x18 */
            ii(0x1007_9946, 2); if(jnzd(0x1007_994a, 0x2)) goto l_0x1007_994a; /* jnz 0x1007994a */
        l_0x1007_9948:
            ii(0x1007_9948, 2); jmpd(0x1007_9954, 0xa); goto l_0x1007_9954; /* jmp 0x10079954 */
        l_0x1007_994a:
            ii(0x1007_994a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_994d, 5); cmp(memw_a32[ds, eax + 0x8], 0x1b);     /* cmp word [eax+0x8], 0x1b */
            ii(0x1007_9952, 2); if(jnzd(0x1007_9956, 0x2)) goto l_0x1007_9956; /* jnz 0x10079956 */
        l_0x1007_9954:
            ii(0x1007_9954, 2); jmpd(0x1007_9960, 0xa); goto l_0x1007_9960; /* jmp 0x10079960 */
        l_0x1007_9956:
            ii(0x1007_9956, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9959, 5); cmp(memw_a32[ds, eax + 0x8], 0x17);     /* cmp word [eax+0x8], 0x17 */
            ii(0x1007_995e, 2); if(jnzd(0x1007_9962, 0x2)) goto l_0x1007_9962; /* jnz 0x10079962 */
        l_0x1007_9960:
            ii(0x1007_9960, 2); jmpd(0x1007_9970, 0xe); goto l_0x1007_9970; /* jmp 0x10079970 */
        l_0x1007_9962:
            ii(0x1007_9962, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9965, 5); cmp(memw_a32[ds, eax + 0x8], 0x20);     /* cmp word [eax+0x8], 0x20 */
            ii(0x1007_996a, 6); if(jnzd(0x1007_9b26, 0x1b6)) goto l_0x1007_9b26; /* jnz 0x10079b26 */
        l_0x1007_9970:
            ii(0x1007_9970, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9973, 5); calld(0x1007_6204, -0x3774);            /* call 0x10076204 */
            ii(0x1007_9978, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1007_997b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_997e, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1007_9981, 2); if(jled(0x1007_9996, 0x13)) goto l_0x1007_9996; /* jle 0x10079996 */
            ii(0x1007_9983, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9986, 5); calld(0x1007_6204, -0x3787);            /* call 0x10076204 */
            ii(0x1007_998b, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1007_998e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9991, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1007_9994, 2); if(jgd(0x1007_999b, 0x5)) goto l_0x1007_999b; /* jg 0x1007999b */
        l_0x1007_9996:
            ii(0x1007_9996, 5); jmpd(0x1007_9b26, 0x18b); goto l_0x1007_9b26; /* jmp 0x10079b26 */
        l_0x1007_999b:
            ii(0x1007_999b, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_999f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_99a2, 5); calld(0x1008_8a08, 0xf061);             /* call 0x10088a08 */
            ii(0x1007_99a7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_99aa, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1007_99ae, 5); calld(0x100a_314c, 0x2_9799);           /* call 0x100a314c */
            ii(0x1007_99b3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_99b6, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x1007_99bb, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1007_99c0, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1007_99c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_99c6, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_99c9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_99cc, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x1007_99d2, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_99d7, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_99d9, 5); calld(0x100c_27f0, 0x4_8e12);           /* call 0x100c27f0 */
            ii(0x1007_99de, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_99e0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_99e3, 5); calld(0x100b_854d, 0x3_eb65);           /* call 0x100b854d */
            ii(0x1007_99e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_99ea, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_99ed, 5); calld(0x1008_8dcc, 0xf3da);             /* call 0x10088dcc */
            ii(0x1007_99f2, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_99f9, 2); jmpd(0x1007_9a01, 0x6); goto l_0x1007_9a01; /* jmp 0x10079a01 */
        l_0x1007_99fb:
            ii(0x1007_99fb, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_99fe, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1007_9a01:
            ii(0x1007_9a01, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_9a04, 5); calld(0x1008_a4a0, 0x1_0a97);           /* call 0x1008a4a0 */
            ii(0x1007_9a09, 4); cmp(ax, memw_a32[ss, ebp - 0x20]);      /* cmp ax, [ebp-0x20] */
            ii(0x1007_9a0d, 2); if(jled(0x1007_9a76, 0x67)) goto l_0x1007_9a76; /* jle 0x10079a76 */
            ii(0x1007_9a0f, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1007_9a13, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_9a16, 5); calld(0x1008_a3dc, 0x1_09c1);           /* call 0x1008a3dc */
            ii(0x1007_9a1b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_9a1e, 5); calld(0x100c_defa, 0x5_44d7);           /* call 0x100cdefa */
            ii(0x1007_9a23, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9a25, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9a28, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x1007_9a2c, 2); if(jnzd(0x1007_9a62, 0x34)) goto l_0x1007_9a62; /* jnz 0x10079a62 */
            ii(0x1007_9a2e, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1007_9a32, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_9a35, 5); calld(0x1008_a3dc, 0x1_09a2);           /* call 0x1008a3dc */
            ii(0x1007_9a3a, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1007_9a3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_9a40, 3); mov(ebx, memd_a32[ds, eax + 0x7]);      /* mov ebx, [eax+0x7] */
            ii(0x1007_9a43, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_9a46, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x1007_9a4c, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1007_9a51, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_9a53, 5); calld(0x100d_fd2c, 0x6_62d4);           /* call 0x100dfd2c */
            ii(0x1007_9a58, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1007_9a5c, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1007_9a60, 2); if(jled(0x1007_9a74, 0x12)) goto l_0x1007_9a74; /* jle 0x10079a74 */
        l_0x1007_9a62:
            ii(0x1007_9a62, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1007_9a66, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_9a69, 5); calld(0x1008_a3dc, 0x1_096e);           /* call 0x1008a3dc */
            ii(0x1007_9a6e, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
        l_0x1007_9a74:
            ii(0x1007_9a74, 2); jmpd(0x1007_99fb, -0x7b); goto l_0x1007_99fb; /* jmp 0x100799fb */
        l_0x1007_9a76:
            ii(0x1007_9a76, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_9a79, 5); calld(0x100b_870a, 0x3_ec8c);           /* call 0x100b870a */
            ii(0x1007_9a7e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1007_9a81, 5); cmp(memw_a32[ss, ebp - 0x24], -0x1 /* 0xff */); /* cmp word [ebp-0x24], 0xffff */
            ii(0x1007_9a86, 6); if(jzd(0x1007_9b1c, 0x90)) goto l_0x1007_9b1c; /* jz 0x10079b1c */
            ii(0x1007_9a8c, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1007_9a91, 5); calld(Definitions.sys_new, 0xe_c36a);   /* call 0x10165e00 */
            ii(0x1007_9a96, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1007_9a99, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1007_9a9c, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1007_9a9f, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1007_9aa3, 2); if(jzd(0x1007_9ac1, 0x1c)) goto l_0x1007_9ac1; /* jz 0x10079ac1 */
            ii(0x1007_9aa5, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1007_9aa8, 3); add(ebx, 0x1d);                         /* add ebx, 0x1d */
            ii(0x1007_9aab, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_9aae, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1007_9ab1, 5); calld(Definitions.my_ctor_c12, 0x2_c5b6); /* call 0x100a606c */
            ii(0x1007_9ab6, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1007_9ab9, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1007_9abc, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1007_9abf, 2); jmpd(0x1007_9ac7, 0x6); goto l_0x1007_9ac7; /* jmp 0x10079ac7 */
        l_0x1007_9ac1:
            ii(0x1007_9ac1, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1007_9ac4, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1007_9ac7:
            ii(0x1007_9ac7, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1007_9aca, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1007_9acd, 5); calld(0x1008_a914, 0x1_0e42);           /* call 0x1008a914 */
            ii(0x1007_9ad2, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1007_9ad6, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1007_9ad9, 5); calld(0x1008_a7dc, 0x1_0cfe);           /* call 0x1008a7dc */
            ii(0x1007_9ade, 5); calld(0x100a_63bc, 0x2_c8d9);           /* call 0x100a63bc */
            ii(0x1007_9ae3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_9ae6, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1007_9ae9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_9aec, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1007_9af0, 5); calld(0x100a_23e4, 0x2_88ef);           /* call 0x100a23e4 */
            ii(0x1007_9af5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9af7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_9afa, 4); add(memw_a32[ds, eax + 0x21], dx);      /* add [eax+0x21], dx */
            ii(0x1007_9afe, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1007_9b01, 5); calld(0x1008_a868, 0x1_0d62);           /* call 0x1008a868 */
            ii(0x1007_9b06, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9b08, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_9b0d, 5); calld(0x100a_4d50, 0x2_b23e);           /* call 0x100a4d50 */
            ii(0x1007_9b12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9b14, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1007_9b17, 5); calld(0x1008_8cbc, 0xf1a0);             /* call 0x10088cbc */
        l_0x1007_9b1c:
            ii(0x1007_9b1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9b1e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_9b21, 5); calld(0x1008_8dcc, 0xf2a6);             /* call 0x10088dcc */
        l_0x1007_9b26:
            ii(0x1007_9b26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9b29, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x1007_9b2e, 2); if(jzd(0x1007_9b3a, 0xa)) goto l_0x1007_9b3a; /* jz 0x10079b3a */
            ii(0x1007_9b30, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9b33, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x1007_9b38, 2); if(jnzd(0x1007_9b4c, 0x12)) goto l_0x1007_9b4c; /* jnz 0x10079b4c */
        l_0x1007_9b3a:
            ii(0x1007_9b3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_9b3d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_9b40, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9b43, 5); calld(0x100a_5c69, 0x2_c121);           /* call 0x100a5c69 */
            ii(0x1007_9b48, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9b4a, 2); if(jzd(0x1007_9b51, 0x5)) goto l_0x1007_9b51; /* jz 0x10079b51 */
        l_0x1007_9b4c:
            ii(0x1007_9b4c, 5); jmpd(0x1007_9dc9, 0x278); goto l_0x1007_9dc9; /* jmp 0x10079dc9 */
        l_0x1007_9b51:
            ii(0x1007_9b51, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_9b55, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9b58, 5); calld(0x1008_8a08, 0xeeab);             /* call 0x10088a08 */
            ii(0x1007_9b5d, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1007_9b60, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1007_9b64, 4); mov(memb_a32[ss, ebp - 0x44], 0);       /* mov byte [ebp-0x44], 0x0 */
            ii(0x1007_9b68, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1007_9b6d, 5); calld(0x1007_6338, -0x383a);            /* call 0x10076338 */
            ii(0x1007_9b72, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9b74, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1007_9b77, 5); calld(0x1007_64b8, -0x36c4);            /* call 0x100764b8 */
            ii(0x1007_9b7c, 5); mov(ebx, 0xba);                         /* mov ebx, 0xba */
            ii(0x1007_9b81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9b83, 6); lea(eax, ebp - 0x104);                  /* lea eax, [ebp-0x104] */
            ii(0x1007_9b89, 5); calld(Definitions.sys_memset, 0xe_c252); /* call 0x10165de0 */
            ii(0x1007_9b8e, 2); jmpd(0x1007_9b98, 0x8); goto l_0x1007_9b98; /* jmp 0x10079b98 */
        l_0x1007_9b90:
            ii(0x1007_9b90, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1007_9b93, 5); calld(0x1007_6bf8, -0x2fa0);            /* call 0x10076bf8 */
        l_0x1007_9b98:
            ii(0x1007_9b98, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9b9a, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1007_9b9d, 5); calld(0x1013_ad71, 0xc_11cf);           /* call 0x1013ad71 */
            ii(0x1007_9ba2, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9ba4, 2); if(jzd(0x1007_9bda, 0x34)) goto l_0x1007_9bda; /* jz 0x10079bda */
            ii(0x1007_9ba6, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1007_9ba9, 5); calld(0x1007_63a0, -0x380e);            /* call 0x100763a0 */
            ii(0x1007_9bae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9bb0, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_9bb3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_9bb6, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_9bb9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9bbc, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_9bbe, 2); if(jnzd(0x1007_9bd8, 0x18)) goto l_0x1007_9bd8; /* jnz 0x10079bd8 */
            ii(0x1007_9bc0, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1007_9bc3, 5); calld(0x1007_63a0, -0x3828);            /* call 0x100763a0 */
            ii(0x1007_9bc8, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1007_9bcb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9bce, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_9bd0, 8); inc(memw_a32[ds, eax + ebp - 0x104]);   /* inc word [eax+ebp-0x104] */
        l_0x1007_9bd8:
            ii(0x1007_9bd8, 2); jmpd(0x1007_9b90, -0x4a); goto l_0x1007_9b90; /* jmp 0x10079b90 */
        l_0x1007_9bda:
            ii(0x1007_9bda, 7); movsx(eax, memw_a32[ss, ebp - 0xd2]);   /* movsx eax, word [ebp-0xd2] */
            ii(0x1007_9be1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_9be3, 2); if(jzd(0x1007_9bf0, 0xb)) goto l_0x1007_9bf0; /* jz 0x10079bf0 */
            ii(0x1007_9be5, 7); movsx(eax, memw_a32[ss, ebp - 0xd4]);   /* movsx eax, word [ebp-0xd4] */
            ii(0x1007_9bec, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_9bee, 2); if(jnzd(0x1007_9bf2, 0x2)) goto l_0x1007_9bf2; /* jnz 0x10079bf2 */
        l_0x1007_9bf0:
            ii(0x1007_9bf0, 2); jmpd(0x1007_9bfd, 0xb); goto l_0x1007_9bfd; /* jmp 0x10079bfd */
        l_0x1007_9bf2:
            ii(0x1007_9bf2, 7); movsx(eax, memw_a32[ss, ebp - 0xce]);   /* movsx eax, word [ebp-0xce] */
            ii(0x1007_9bf9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_9bfb, 2); if(jnzd(0x1007_9c01, 0x4)) goto l_0x1007_9c01; /* jnz 0x10079c01 */
        l_0x1007_9bfd:
            ii(0x1007_9bfd, 4); mov(memb_a32[ss, ebp - 0x44], 0x1);     /* mov byte [ebp-0x44], 0x1 */
        l_0x1007_9c01:
            ii(0x1007_9c01, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_9c06, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1007_9c0b, 6); lea(edx, ebp - 0x108);                  /* lea edx, [ebp-0x108] */
            ii(0x1007_9c11, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_9c14, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_9c17, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9c1a, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_9c20, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1007_9c25, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_9c27, 5); calld(0x100c_27f0, 0x4_8bc4);           /* call 0x100c27f0 */
            ii(0x1007_9c2c, 3); lea(ebx, ebp - 0x3c);                   /* lea ebx, [ebp-0x3c] */
            ii(0x1007_9c2f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9c31, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_9c33, 5); calld(0x100b_8583, 0x3_e94b);           /* call 0x100b8583 */
            ii(0x1007_9c38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9c3a, 6); lea(eax, ebp - 0x108);                  /* lea eax, [ebp-0x108] */
            ii(0x1007_9c40, 5); calld(0x1008_8dcc, 0xf187);             /* call 0x10088dcc */
            ii(0x1007_9c45, 10); mov(memd_a32[ss, ebp - 0x10c], 0);     /* mov dword [ebp-0x10c], 0x0 */
            ii(0x1007_9c4f, 2); jmpd(0x1007_9c5d, 0xc); goto l_0x1007_9c5d; /* jmp 0x10079c5d */
        l_0x1007_9c51:
            ii(0x1007_9c51, 6); mov(eax, memd_a32[ss, ebp - 0x10c]);    /* mov eax, [ebp-0x10c] */
            ii(0x1007_9c57, 6); inc(memd_a32[ss, ebp - 0x10c]);         /* inc dword [ebp-0x10c] */
        l_0x1007_9c5d:
            ii(0x1007_9c5d, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9c60, 5); calld(0x1008_a4a0, 0x1_083b);           /* call 0x1008a4a0 */
            ii(0x1007_9c65, 7); cmp(ax, memw_a32[ss, ebp - 0x10c]);     /* cmp ax, [ebp-0x10c] */
            ii(0x1007_9c6c, 6); if(jled(0x1007_9d38, 0xc6)) goto l_0x1007_9d38; /* jle 0x10079d38 */
            ii(0x1007_9c72, 7); movsx(edx, memw_a32[ss, ebp - 0x10c]);  /* movsx edx, word [ebp-0x10c] */
            ii(0x1007_9c79, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9c7c, 5); calld(0x1008_a3dc, 0x1_075b);           /* call 0x1008a3dc */
            ii(0x1007_9c81, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_9c84, 5); calld(0x100c_defa, 0x5_4271);           /* call 0x100cdefa */
            ii(0x1007_9c89, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
            ii(0x1007_9c8f, 6); mov(eax, memd_a32[ss, ebp - 0x110]);    /* mov eax, [ebp-0x110] */
            ii(0x1007_9c95, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_9c98, 4); cmp(ax, memw_a32[ds, edx + 0x8]);       /* cmp ax, [edx+0x8] */
            ii(0x1007_9c9c, 2); if(jzd(0x1007_9cb5, 0x17)) goto l_0x1007_9cb5; /* jz 0x10079cb5 */
            ii(0x1007_9c9e, 7); movsx(eax, memw_a32[ss, ebp - 0x110]);  /* movsx eax, word [ebp-0x110] */
            ii(0x1007_9ca5, 5); calld(0x100c_defa, 0x5_4250);           /* call 0x100cdefa */
            ii(0x1007_9caa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9cac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9caf, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x1007_9cb3, 2); if(jnzd(0x1007_9cb7, 0x2)) goto l_0x1007_9cb7; /* jnz 0x10079cb7 */
        l_0x1007_9cb5:
            ii(0x1007_9cb5, 2); jmpd(0x1007_9ccc, 0x15); goto l_0x1007_9ccc; /* jmp 0x10079ccc */
        l_0x1007_9cb7:
            ii(0x1007_9cb7, 7); movsx(edx, memw_a32[ss, ebp - 0x10c]);  /* movsx edx, word [ebp-0x10c] */
            ii(0x1007_9cbe, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9cc1, 5); calld(0x1008_a3dc, 0x1_0716);           /* call 0x1008a3dc */
            ii(0x1007_9cc6, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
        l_0x1007_9ccc:
            ii(0x1007_9ccc, 4); cmp(memb_a32[ss, ebp - 0x44], 0);       /* cmp byte [ebp-0x44], 0x0 */
            ii(0x1007_9cd0, 2); if(jzd(0x1007_9cf2, 0x20)) goto l_0x1007_9cf2; /* jz 0x10079cf2 */
            ii(0x1007_9cd2, 7); movsx(edx, memw_a32[ss, ebp - 0x10c]);  /* movsx edx, word [ebp-0x10c] */
            ii(0x1007_9cd9, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9cdc, 5); calld(0x1008_a3dc, 0x1_06fb);           /* call 0x1008a3dc */
            ii(0x1007_9ce1, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_9ce4, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_9ce7, 9); test(memw_a32[ds, eax + 0x101c_81c0], 0x1c0); /* test word [eax+0x101c81c0], 0x1c0 */
            ii(0x1007_9cf0, 2); if(jnzd(0x1007_9cf4, 0x2)) goto l_0x1007_9cf4; /* jnz 0x10079cf4 */
        l_0x1007_9cf2:
            ii(0x1007_9cf2, 2); jmpd(0x1007_9d1c, 0x28); goto l_0x1007_9d1c; /* jmp 0x10079d1c */
        l_0x1007_9cf4:
            ii(0x1007_9cf4, 7); movsx(edx, memw_a32[ss, ebp - 0x10c]);  /* movsx edx, word [ebp-0x10c] */
            ii(0x1007_9cfb, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9cfe, 5); calld(0x1008_a3dc, 0x1_06d9);           /* call 0x1008a3dc */
            ii(0x1007_9d03, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_9d06, 5); calld(0x100c_defa, 0x5_41ef);           /* call 0x100cdefa */
            ii(0x1007_9d0b, 1); cwde();                                 /* cwde */
            ii(0x1007_9d0c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_9d0e, 7); mov(eax, memd_a32[ds, eax + ebp - 0x106]); /* mov eax, [eax+ebp-0x106] */
            ii(0x1007_9d15, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9d18, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_9d1a, 2); if(jgd(0x1007_9d1e, 0x2)) goto l_0x1007_9d1e; /* jg 0x10079d1e */
        l_0x1007_9d1c:
            ii(0x1007_9d1c, 2); jmpd(0x1007_9d33, 0x15); goto l_0x1007_9d33; /* jmp 0x10079d33 */
        l_0x1007_9d1e:
            ii(0x1007_9d1e, 7); movsx(edx, memw_a32[ss, ebp - 0x10c]);  /* movsx edx, word [ebp-0x10c] */
            ii(0x1007_9d25, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9d28, 5); calld(0x1008_a3dc, 0x1_06af);           /* call 0x1008a3dc */
            ii(0x1007_9d2d, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
        l_0x1007_9d33:
            ii(0x1007_9d33, 5); jmpd(0x1007_9c51, -0xe7); goto l_0x1007_9c51; /* jmp 0x10079c51 */
        l_0x1007_9d38:
            ii(0x1007_9d38, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9d3b, 5); calld(0x100b_870a, 0x3_e9ca);           /* call 0x100b870a */
            ii(0x1007_9d40, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
            ii(0x1007_9d46, 8); cmp(memw_a32[ss, ebp - 0x110], -0x1 /* 0xff */); /* cmp word [ebp-0x110], 0xffff */
            ii(0x1007_9d4e, 2); if(jzd(0x1007_9db5, 0x65)) goto l_0x1007_9db5; /* jz 0x10079db5 */
            ii(0x1007_9d50, 7); movsx(eax, memw_a32[ss, ebp - 0x110]);  /* movsx eax, word [ebp-0x110] */
            ii(0x1007_9d57, 5); calld(0x100c_defa, 0x5_419e);           /* call 0x100cdefa */
            ii(0x1007_9d5c, 6); mov(memd_a32[ss, ebp - 0x114], eax);    /* mov [ebp-0x114], eax */
            ii(0x1007_9d62, 6); mov(eax, memd_a32[ss, ebp - 0x114]);    /* mov eax, [ebp-0x114] */
            ii(0x1007_9d68, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_9d6b, 4); cmp(ax, memw_a32[ds, edx + 0x8]);       /* cmp ax, [edx+0x8] */
            ii(0x1007_9d6f, 2); if(jzd(0x1007_9d7d, 0xc)) goto l_0x1007_9d7d; /* jz 0x10079d7d */
            ii(0x1007_9d71, 6); mov(eax, memd_a32[ss, ebp - 0x114]);    /* mov eax, [ebp-0x114] */
            ii(0x1007_9d77, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
        l_0x1007_9d7d:
            ii(0x1007_9d7d, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1007_9d80, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_9d83, 3); add(edx, 0x1d);                         /* add edx, 0x1d */
            ii(0x1007_9d86, 6); lea(eax, ebp - 0x118);                  /* lea eax, [ebp-0x118] */
            ii(0x1007_9d8c, 5); calld(0x1007_5e64, -0x3f2d);            /* call 0x10075e64 */
            ii(0x1007_9d91, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_9d93, 7); movsx(edx, memw_a32[ss, ebp - 0x110]);  /* movsx edx, word [ebp-0x110] */
            ii(0x1007_9d9a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_9d9d, 3); mov(esi, memd_a32[ds, eax + 0x7]);      /* mov esi, [eax+0x7] */
            ii(0x1007_9da0, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1007_9da3, 6); imul(esi, esi, 0xc5);                   /* imul esi, esi, 0xc5 */
            ii(0x1007_9da9, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_9dae, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_9db0, 5); calld(0x100b_e5c2, 0x4_480d);           /* call 0x100be5c2 */
        l_0x1007_9db5:
            ii(0x1007_9db5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9db7, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1007_9dba, 5); calld(0x1007_5f6c, -0x3e53);            /* call 0x10075f6c */
            ii(0x1007_9dbf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9dc1, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_9dc4, 5); calld(0x1008_8dcc, 0xf003);             /* call 0x10088dcc */
        l_0x1007_9dc9:
            ii(0x1007_9dc9, 5); jmpd(0x1007_9fe9, 0x21b); goto l_0x1007_9fe9; /* jmp 0x10079fe9 */
        l_0x1007_9dce:
            ii(0x1007_9dce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9dd1, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1007_9dd4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_9dd9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_9ddb, 2); if(jnzd(0x1007_9df8, 0x1b)) goto l_0x1007_9df8; /* jnz 0x10079df8 */
            ii(0x1007_9ddd, 5); calld(0x1008_a79c, 0x1_09ba);           /* call 0x1008a79c */
            ii(0x1007_9de2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_9de4, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_9de6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_9de9, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_9dee, 5); calld(0x100a_53ac, 0x2_b5b9);           /* call 0x100a53ac */
            ii(0x1007_9df3, 5); jmpd(0x1007_9fe9, 0x1f1); goto l_0x1007_9fe9; /* jmp 0x10079fe9 */
        l_0x1007_9df8:
            ii(0x1007_9df8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_9dfb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_9dfe, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_9e01, 5); calld(0x1008_ab1c, 0x1_0d16);           /* call 0x1008ab1c */
            ii(0x1007_9e06, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_9e09, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9e0c, 5); calld(0x1015_27ed, 0xd_89dc);           /* call 0x101527ed */
            ii(0x1007_9e11, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_9e16, 5); calld(0x1008_a768, 0x1_094d);           /* call 0x1008a768 */
            ii(0x1007_9e1b, 6); lea(ebx, ebp - 0x11c);                  /* lea ebx, [ebp-0x11c] */
            ii(0x1007_9e21, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9e23, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_9e25, 5); calld(0x1008_ae70, 0x1_1046);           /* call 0x1008ae70 */
            ii(0x1007_9e2a, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_9e2e, 6); lea(eax, ebp - 0x120);                  /* lea eax, [ebp-0x120] */
            ii(0x1007_9e34, 5); calld(Definitions.my_ctor_0x101b_3b58, 0x1_126b); /* call 0x1008b0a4 */
            ii(0x1007_9e39, 6); mov(memd_a32[ss, ebp - 0x124], eax);    /* mov [ebp-0x124], eax */
            ii(0x1007_9e3f, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1007_9e43, 2); jmpd(0x1007_9e50, 0xb); goto l_0x1007_9e50; /* jmp 0x10079e50 */
        l_0x1007_9e45:
            ii(0x1007_9e45, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1007_9e4b, 5); calld(0x1007_6bf8, -0x3258);            /* call 0x10076bf8 */
        l_0x1007_9e50:
            ii(0x1007_9e50, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9e52, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1007_9e58, 5); calld(0x1013_ad71, 0xc_0f14);           /* call 0x1013ad71 */
            ii(0x1007_9e5d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9e5f, 6); if(jzd(0x1007_9f90, 0x12b)) goto l_0x1007_9f90; /* jz 0x10079f90 */
            ii(0x1007_9e65, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9e68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9e6a, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_9e6d, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1007_9e73, 5); calld(0x1008_adc4, 0x1_0f4c);           /* call 0x1008adc4 */
            ii(0x1007_9e78, 5); calld(0x1008_ad90, 0x1_0f13);           /* call 0x1008ad90 */
            ii(0x1007_9e7d, 1); cwde();                                 /* cwde */
            ii(0x1007_9e7e, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1007_9e80, 2); if(jnzd(0x1007_9ea9, 0x27)) goto l_0x1007_9ea9; /* jnz 0x10079ea9 */
            ii(0x1007_9e82, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1007_9e88, 5); calld(0x1008_adc4, 0x1_0f37);           /* call 0x1008adc4 */
            ii(0x1007_9e8d, 6); mov(memd_a32[ss, ebp - 0x128], eax);    /* mov [ebp-0x128], eax */
            ii(0x1007_9e93, 6); mov(eax, memd_a32[ss, ebp - 0x128]);    /* mov eax, [ebp-0x128] */
            ii(0x1007_9e99, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1007_9e9c, 6); mov(eax, memd_a32[ss, ebp - 0x128]);    /* mov eax, [ebp-0x128] */
            ii(0x1007_9ea2, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x1007_9ea5, 2); cmp(al, 0x3);                           /* cmp al, 0x3 */
            ii(0x1007_9ea7, 2); if(jnzd(0x1007_9eab, 0x2)) goto l_0x1007_9eab; /* jnz 0x10079eab */
        l_0x1007_9ea9:
            ii(0x1007_9ea9, 2); jmpd(0x1007_9ed5, 0x2a); goto l_0x1007_9ed5; /* jmp 0x10079ed5 */
        l_0x1007_9eab:
            ii(0x1007_9eab, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1007_9eb1, 5); calld(0x1008_adc4, 0x1_0f0e);           /* call 0x1008adc4 */
            ii(0x1007_9eb6, 6); mov(memd_a32[ss, ebp - 0x12c], eax);    /* mov [ebp-0x12c], eax */
            ii(0x1007_9ebc, 6); mov(eax, memd_a32[ss, ebp - 0x12c]);    /* mov eax, [ebp-0x12c] */
            ii(0x1007_9ec2, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1007_9ec5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_9ec8, 6); mov(eax, memd_a32[ss, ebp - 0x12c]);    /* mov eax, [ebp-0x12c] */
            ii(0x1007_9ece, 3); calld_abs(memd_a32[ds, ebx + 0x8]);     /* call dword [ebx+0x8] */
            ii(0x1007_9ed1, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9ed3, 2); if(jnzd(0x1007_9eda, 0x5)) goto l_0x1007_9eda; /* jnz 0x10079eda */
        l_0x1007_9ed5:
            ii(0x1007_9ed5, 5); jmpd(0x1007_9f8b, 0xb1); goto l_0x1007_9f8b; /* jmp 0x10079f8b */
        l_0x1007_9eda:
            ii(0x1007_9eda, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1007_9ee0, 5); calld(0x1008_adc4, 0x1_0edf);           /* call 0x1008adc4 */
            ii(0x1007_9ee5, 6); mov(memd_a32[ss, ebp - 0x130], eax);    /* mov [ebp-0x130], eax */
            ii(0x1007_9eeb, 6); mov(eax, memd_a32[ss, ebp - 0x130]);    /* mov eax, [ebp-0x130] */
            ii(0x1007_9ef1, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1007_9ef4, 6); lea(edx, ebp - 0x140);                  /* lea edx, [ebp-0x140] */
            ii(0x1007_9efa, 6); mov(eax, memd_a32[ss, ebp - 0x130]);    /* mov eax, [ebp-0x130] */
            ii(0x1007_9f00, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1007_9f03, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9f06, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1007_9f0a, 6); sub(edx, memd_a32[ss, ebp - 0x13c]);    /* sub edx, [ebp-0x13c] */
            ii(0x1007_9f10, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9f13, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1007_9f17, 6); sub(eax, memd_a32[ss, ebp - 0x13c]);    /* sub eax, [ebp-0x13c] */
            ii(0x1007_9f1d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_9f20, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9f23, 4); mov(bx, memw_a32[ds, eax + 0x1a]);      /* mov bx, [eax+0x1a] */
            ii(0x1007_9f27, 6); sub(ebx, memd_a32[ss, ebp - 0x140]);    /* sub ebx, [ebp-0x140] */
            ii(0x1007_9f2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9f30, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1007_9f34, 6); sub(eax, memd_a32[ss, ebp - 0x140]);    /* sub eax, [ebp-0x140] */
            ii(0x1007_9f3a, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1007_9f3d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_9f3f, 6); mov(memd_a32[ss, ebp - 0x144], eax);    /* mov [ebp-0x144], eax */
            ii(0x1007_9f45, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9f47, 6); lea(eax, ebp - 0x120);                  /* lea eax, [ebp-0x120] */
            ii(0x1007_9f4d, 5); calld(0x1013_ad11, 0xc_0dbf);           /* call 0x1013ad11 */
            ii(0x1007_9f52, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9f54, 2); if(jnzd(0x1007_9f65, 0xf)) goto l_0x1007_9f65; /* jnz 0x10079f65 */
            ii(0x1007_9f56, 6); mov(eax, memd_a32[ss, ebp - 0x144]);    /* mov eax, [ebp-0x144] */
            ii(0x1007_9f5c, 7); cmp(ax, memw_a32[ss, ebp - 0x148]);     /* cmp ax, [ebp-0x148] */
            ii(0x1007_9f63, 2); if(jged(0x1007_9f8b, 0x26)) goto l_0x1007_9f8b; /* jge 0x10079f8b */
        l_0x1007_9f65:
            ii(0x1007_9f65, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1007_9f6b, 5); calld(0x1008_adf8, 0x1_0e88);           /* call 0x1008adf8 */
            ii(0x1007_9f70, 6); lea(ebx, ebp - 0x120);                  /* lea ebx, [ebp-0x120] */
            ii(0x1007_9f76, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9f78, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_9f7a, 5); calld(0x1008_afe4, 0x1_1065);           /* call 0x1008afe4 */
            ii(0x1007_9f7f, 6); mov(eax, memd_a32[ss, ebp - 0x144]);    /* mov eax, [ebp-0x144] */
            ii(0x1007_9f85, 6); mov(memd_a32[ss, ebp - 0x148], eax);    /* mov [ebp-0x148], eax */
        l_0x1007_9f8b:
            ii(0x1007_9f8b, 5); jmpd(0x1007_9e45, -0x14b); goto l_0x1007_9e45; /* jmp 0x10079e45 */
        l_0x1007_9f90:
            ii(0x1007_9f90, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9f92, 6); lea(eax, ebp - 0x120);                  /* lea eax, [ebp-0x120] */
            ii(0x1007_9f98, 5); calld(0x1013_ad71, 0xc_0dd4);           /* call 0x1013ad71 */
            ii(0x1007_9f9d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9f9f, 2); if(jzd(0x1007_9fcf, 0x2e)) goto l_0x1007_9fcf; /* jz 0x10079fcf */
            ii(0x1007_9fa1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9fa4, 5); calld(0x1015_287d, 0xd_88d4);           /* call 0x1015287d */
            ii(0x1007_9fa9, 6); lea(eax, ebp - 0x120);                  /* lea eax, [ebp-0x120] */
            ii(0x1007_9faf, 5); calld(0x1008_af28, 0x1_0f74);           /* call 0x1008af28 */
            ii(0x1007_9fb4, 6); mov(memd_a32[ss, ebp - 0x14c], eax);    /* mov [ebp-0x14c], eax */
            ii(0x1007_9fba, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x1007_9fc0, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1007_9fc3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_9fc6, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x1007_9fcc, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
        l_0x1007_9fcf:
            ii(0x1007_9fcf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9fd1, 6); lea(eax, ebp - 0x120);                  /* lea eax, [ebp-0x120] */
            ii(0x1007_9fd7, 5); calld(0x1008_8b7c, 0xeba0);             /* call 0x10088b7c */
            ii(0x1007_9fdc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9fde, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1007_9fe4, 5); calld(0x1008_8bbc, 0xebd3);             /* call 0x10088bbc */
        l_0x1007_9fe9:
            ii(0x1007_9fe9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_9feb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_9fec, 1); popd(edi);                              /* pop edi */
            ii(0x1007_9fed, 1); popd(esi);                              /* pop esi */
            ii(0x1007_9fee, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_9fef, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_9ff0, 1); retd(); return;                         /* ret */
        }
    }
}
