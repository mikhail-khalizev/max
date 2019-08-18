using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_80fd-a5d3f29e")]
        public void Method_1015_80fd()
        {
            ii(0x1015_80fd, 5); pushd(0xbc);                            /* push 0xbc */
            ii(0x1015_8102, 5); calld(Definitions.sys_check_available_stack_size, 0xdc4b); /* call 0x10165d52 */
            ii(0x1015_8107, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_8108, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_8109, 1); pushd(esi);                             /* push esi */
            ii(0x1015_810a, 1); pushd(edi);                             /* push edi */
            ii(0x1015_810b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_810c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_810e, 6); sub(esp, 0x88);                         /* sub esp, 0x88 */
            ii(0x1015_8114, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_8117, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_811a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_811d, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1015_8120, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1015_8124, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_8127, 5); calld(0x1016_43bc, 0xc290);             /* call 0x101643bc */
            ii(0x1015_812c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_812f, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1015_8133, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1015_8137, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1015_813a, 5); calld(0x1016_43f8, 0xc2b9);             /* call 0x101643f8 */
            ii(0x1015_813f, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1015_8142, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1015_8146, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_814d, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1015_8154, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1015_815b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_8160, 5); calld(0x100f_448c, -0x6_3cd9);          /* call 0x100f448c */
            ii(0x1015_8165, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1015_816a, 5); calld(0x1007_6338, -0xe_1e37);          /* call 0x10076338 */
            ii(0x1015_816f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_8171, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_8174, 5); calld(0x1007_64b8, -0xe_1cc1);          /* call 0x100764b8 */
            ii(0x1015_8179, 2); jmpd(0x1015_8183, 0x8); goto l_0x1015_8183; /* jmp 0x10158183 */
        l_0x1015_817b:
            ii(0x1015_817b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_817e, 5); calld(0x1007_6bf8, -0xe_158b);          /* call 0x10076bf8 */
        l_0x1015_8183:
            ii(0x1015_8183, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8185, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_8188, 5); calld(0x1013_ad71, -0x1_d41c);          /* call 0x1013ad71 */
            ii(0x1015_818d, 2); test(al, al);                           /* test al, al */
            ii(0x1015_818f, 6); if(jzd(0x1015_8316, 0x181)) goto l_0x1015_8316; /* jz 0x10158316 */
            ii(0x1015_8195, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_8198, 5); calld(0x1007_63a0, -0xe_1dfd);          /* call 0x100763a0 */
            ii(0x1015_819d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_81a0, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_81a3, 3); cmp(dl, memb_a32[ds, eax + 0x26]);      /* cmp dl, [eax+0x26] */
            ii(0x1015_81a6, 2); if(jnzd(0x1015_81bd, 0x15)) goto l_0x1015_81bd; /* jnz 0x101581bd */
            ii(0x1015_81a8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_81ab, 5); calld(0x1007_63a0, -0xe_1e10);          /* call 0x100763a0 */
            ii(0x1015_81b0, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1015_81b4, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_81b7, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x1015_81bb, 2); if(jzd(0x1015_81bf, 0x2)) goto l_0x1015_81bf; /* jz 0x101581bf */
        l_0x1015_81bd:
            ii(0x1015_81bd, 2); jmpd(0x1015_81d0, 0x11); goto l_0x1015_81d0; /* jmp 0x101581d0 */
        l_0x1015_81bf:
            ii(0x1015_81bf, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_81c2, 5); calld(0x1007_63a0, -0xe_1e27);          /* call 0x100763a0 */
            ii(0x1015_81c7, 5); calld(0x1015_0e51, -0x737b);            /* call 0x10150e51 */
            ii(0x1015_81cc, 2); test(al, al);                           /* test al, al */
            ii(0x1015_81ce, 2); if(jnzd(0x1015_81d2, 0x2)) goto l_0x1015_81d2; /* jnz 0x101581d2 */
        l_0x1015_81d0:
            ii(0x1015_81d0, 2); jmpd(0x1015_81e0, 0xe); goto l_0x1015_81e0; /* jmp 0x101581e0 */
        l_0x1015_81d2:
            ii(0x1015_81d2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_81d5, 5); calld(0x1007_63a0, -0xe_1e3a);          /* call 0x100763a0 */
            ii(0x1015_81da, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1015_81de, 2); if(jnzd(0x1015_81e5, 0x5)) goto l_0x1015_81e5; /* jnz 0x101581e5 */
        l_0x1015_81e0:
            ii(0x1015_81e0, 5); jmpd(0x1015_8311, 0x12c); goto l_0x1015_8311; /* jmp 0x10158311 */
        l_0x1015_81e5:
            ii(0x1015_81e5, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1015_81ec, 2); jmpd(0x1015_81f4, 0x6); goto l_0x1015_81f4; /* jmp 0x101581f4 */
        l_0x1015_81ee:
            ii(0x1015_81ee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_81f1, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1015_81f4:
            ii(0x1015_81f4, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_81f7, 5); calld(Definitions.my_1_get_count, -0xa_cd24); /* call 0x100ab4d8 */
            ii(0x1015_81fc, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1015_8200, 2); if(jled(0x1015_8221, 0x1f)) goto l_0x1015_8221; /* jle 0x10158221 */
            ii(0x1015_8202, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_8205, 5); calld(0x1007_63a0, -0xe_1e6a);          /* call 0x100763a0 */
            ii(0x1015_820a, 5); calld(0x1007_6204, -0xe_200b);          /* call 0x10076204 */
            ii(0x1015_820f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_8211, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1015_8215, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_8218, 5); calld(0x1016_48a8, 0xc68b);             /* call 0x101648a8 */
            ii(0x1015_821d, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1015_821f, 2); if(jnzd(0x1015_81ee, -0x33)) goto l_0x1015_81ee; /* jnz 0x101581ee */
        l_0x1015_8221:
            ii(0x1015_8221, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_8224, 5); calld(Definitions.my_1_get_count, -0xa_cd51); /* call 0x100ab4d8 */
            ii(0x1015_8229, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1015_822d, 2); if(jnzd(0x1015_8283, 0x54)) goto l_0x1015_8283; /* jnz 0x10158283 */
            ii(0x1015_822f, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1015_8232, 5); calld(0x1007_20b1, -0xe_6186);          /* call 0x100720b1 */
            ii(0x1015_8237, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1015_823a, 5); calld(0x1007_20b1, -0xe_618e);          /* call 0x100720b1 */
            ii(0x1015_823f, 3); lea(ebx, ebp - 0x64);                   /* lea ebx, [ebp-0x64] */
            ii(0x1015_8242, 3); lea(edx, ebp - 0x58);                   /* lea edx, [ebp-0x58] */
            ii(0x1015_8245, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_8248, 5); calld(0x1007_63a0, -0xe_1ead);          /* call 0x100763a0 */
            ii(0x1015_824d, 5); calld(0x1007_6204, -0xe_204e);          /* call 0x10076204 */
            ii(0x1015_8252, 5); calld(0x1014_3616, -0x1_4c41);          /* call 0x10143616 */
            ii(0x1015_8257, 5); calld(0x1016_495c, 0xc700);             /* call 0x1016495c */
            ii(0x1015_825c, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_825f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_8262, 5); calld(0x1007_63a0, -0xe_1ec7);          /* call 0x100763a0 */
            ii(0x1015_8267, 5); calld(0x1007_6204, -0xe_2068);          /* call 0x10076204 */
            ii(0x1015_826c, 3); lea(ecx, ebp - 0x3c);                   /* lea ecx, [ebp-0x3c] */
            ii(0x1015_826f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_8271, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1015_8273, 5); calld(0x1016_4870, 0xc5f8);             /* call 0x10164870 */
            ii(0x1015_8278, 3); lea(edx, ebp - 0x56);                   /* lea edx, [ebp-0x56] */
            ii(0x1015_827b, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1015_827e, 5); calld(0x1016_4788, 0xc505);             /* call 0x10164788 */
        l_0x1015_8283:
            ii(0x1015_8283, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_8286, 5); calld(0x1007_63a0, -0xe_1eeb);          /* call 0x100763a0 */
            ii(0x1015_828b, 5); calld(0x1015_09a6, -0x78ea);            /* call 0x101509a6 */
            ii(0x1015_8290, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_8293, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_8295, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_8298, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_829b, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1015_829d, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1015_82a0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_82a3, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1015_82a7, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1015_82aa, 5); calld(0x1016_474c, 0xc49d);             /* call 0x1016474c */
            ii(0x1015_82af, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1015_82b2, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1015_82b6, 2); if(jld(0x1015_8311, 0x59)) goto l_0x1015_8311; /* jl 0x10158311 */
            ii(0x1015_82b8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_82bb, 5); calld(0x1007_63d4, -0xe_1eec);          /* call 0x100763d4 */
            ii(0x1015_82c0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_82c2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_82c5, 5); calld(0x1007_63a0, -0xe_1f2a);          /* call 0x100763a0 */
            ii(0x1015_82ca, 5); calld(0x1008_a998, -0xc_d937);          /* call 0x1008a998 */
            ii(0x1015_82cf, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_82d4, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x1015_82d9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_82dc, 5); calld(0x1007_63d4, -0xe_1f0d);          /* call 0x100763d4 */
            ii(0x1015_82e1, 5); calld(0x1016_3053, 0xad6d);             /* call 0x10163053 */
            ii(0x1015_82e6, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_82e9, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x1015_82ec, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_82ef, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
            ii(0x1015_82f2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_82f5, 5); calld(0x1007_63d4, -0xe_1f26);          /* call 0x100763d4 */
            ii(0x1015_82fa, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1015_82fd, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1015_8301, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1015_8304, 5); calld(0x1016_474c, 0xc443);             /* call 0x1016474c */
            ii(0x1015_8309, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_830b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_830e, 3); sub(memw_a32[ds, edx], ax);             /* sub [edx], ax */
        l_0x1015_8311:
            ii(0x1015_8311, 5); jmpd(0x1015_817b, -0x19b); goto l_0x1015_817b; /* jmp 0x1015817b */
        l_0x1015_8316:
            ii(0x1015_8316, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_8319, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1015_831c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_831f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_8322, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_8325, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_832a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_8330, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1015_8335, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_8337, 5); calld(0x100d_fd2c, -0x7_8610);          /* call 0x100dfd2c */
            ii(0x1015_833c, 5); calld(0x100e_f36c, -0x6_8fd5);          /* call 0x100ef36c */
            ii(0x1015_8341, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_8344, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1015_8347, 5); calld(0x1014_f905, -0x8a47);            /* call 0x1014f905 */
            ii(0x1015_834c, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1015_8350, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_8352, 2); if(jnzd(0x1015_83be, 0x6a)) goto l_0x1015_83be; /* jnz 0x101583be */
            ii(0x1015_8354, 5); calld(0x100c_aa00, -0x8_d959);          /* call 0x100caa00 */
            ii(0x1015_8359, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_835e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_835f, 5); calld(0x100c_aa20, -0x8_d944);          /* call 0x100caa20 */
            ii(0x1015_8364, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_8366, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_8368, 5); mov(esi, 0x2);                          /* mov esi, 0x2 */
            ii(0x1015_836d, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_8370, 5); calld(0x1015_09a6, -0x79cf);            /* call 0x101509a6 */
            ii(0x1015_8375, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_8378, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_837a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_837d, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_8380, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1015_8382, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1015_8385, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8386, 5); mov(eax, StringDefinitions.IRawMaterialNeededToUpgrade2); /* mov eax, 0x101b2434 */
            ii(0x1015_838b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_838c, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1015_8391, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8392, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1015_8395, 5); calld(Definitions.my_string_ctor, -0x1_68b2); /* call 0x10141ae8 */
            ii(0x1015_839a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_839b, 5); calld(0x1014_2037, -0x1_6369);          /* call 0x10142037 */
            ii(0x1015_83a0, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1015_83a3, 5); calld(Definitions.my_strobj_c_str_v2, -0xc_ebe0); /* call 0x100897c8 */
            ii(0x1015_83a8, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1015_83aa, 5); calld(0x1011_5d23, -0x4_268c);          /* call 0x10115d23 */
            ii(0x1015_83af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_83b1, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1015_83b4, 5); calld(Definitions.my_string_dtor, -0x1_688f); /* call 0x10141b2a */
            ii(0x1015_83b9, 5); jmpd(0x1015_84a9, 0xeb); goto l_0x1015_84a9; /* jmp 0x101584a9 */
        l_0x1015_83be:
            ii(0x1015_83be, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1015_83c2, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_83c5, 2); if(jnzd(0x1015_843c, 0x75)) goto l_0x1015_843c; /* jnz 0x1015843c */
            ii(0x1015_83c7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_83ca, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1015_83cd, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_83d0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_83d3, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1015_83d6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_83d9, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_83dc, 5); calld(0x1007_6aac, -0xe_1935);          /* call 0x10076aac */
            ii(0x1015_83e1, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1015_83e3, 3); mov(ebx, memd_a32[ss, ebp - 0x28]);     /* mov ebx, [ebp-0x28] */
            ii(0x1015_83e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_83e8, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_83ec, 1); pushd(eax);                             /* push eax */
            ii(0x1015_83ed, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1015_83f0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_83f1, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_83f4, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_83f7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_83fa, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_83fd, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1015_8403, 5); mov(eax, StringDefinitions.SUpgradedToMarkSForIRawMaterial2); /* mov eax, 0x101b2457 */
            ii(0x1015_8408, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8409, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1015_840e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_840f, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x1015_8415, 5); calld(Definitions.my_string_ctor, -0x1_6932); /* call 0x10141ae8 */
            ii(0x1015_841a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_841b, 5); calld(0x1014_2037, -0x1_63e9);          /* call 0x10142037 */
            ii(0x1015_8420, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1015_8423, 5); calld(Definitions.my_strobj_c_str_v2, -0xc_ec60); /* call 0x100897c8 */
            ii(0x1015_8428, 5); calld(0x1011_5b60, -0x4_28cd);          /* call 0x10115b60 */
            ii(0x1015_842d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_842f, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x1015_8435, 5); calld(Definitions.my_string_dtor, -0x1_6910); /* call 0x10141b2a */
            ii(0x1015_843a, 2); jmpd(0x1015_84a9, 0x6d); goto l_0x1015_84a9; /* jmp 0x101584a9 */
        l_0x1015_843c:
            ii(0x1015_843c, 5); calld(0x100c_aa00, -0x8_da41);          /* call 0x100caa00 */
            ii(0x1015_8441, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_8446, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8447, 5); calld(0x100c_aa20, -0x8_da2c);          /* call 0x100caa20 */
            ii(0x1015_844c, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_844e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_8450, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8452, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_8456, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8457, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1015_845a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_845b, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_845e, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_8461, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_8464, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_8467, 6); pushd(memd_a32[ds, eax + 0x101c_81db]); /* push dword [eax+0x101c81db] */
            ii(0x1015_846d, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1015_8471, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8472, 5); mov(eax, StringDefinitions.ISUpgradedToMarkSForIRawMaterial); /* mov eax, 0x101b2483 */
            ii(0x1015_8477, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8478, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1015_847d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_847e, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x1015_8484, 5); calld(Definitions.my_string_ctor, -0x1_69a1); /* call 0x10141ae8 */
            ii(0x1015_8489, 1); pushd(eax);                             /* push eax */
            ii(0x1015_848a, 5); calld(0x1014_2037, -0x1_6458);          /* call 0x10142037 */
            ii(0x1015_848f, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1015_8492, 5); calld(Definitions.my_strobj_c_str_v2, -0xc_eccf); /* call 0x100897c8 */
            ii(0x1015_8497, 5); calld(0x1011_5d23, -0x4_2779);          /* call 0x10115d23 */
            ii(0x1015_849c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_849e, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x1015_84a4, 5); calld(Definitions.my_string_dtor, -0x1_697f); /* call 0x10141b2a */
        l_0x1015_84a9:
            ii(0x1015_84a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_84ab, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_84ae, 5); calld(0x1007_5f6c, -0xe_2547);          /* call 0x10075f6c */
            ii(0x1015_84b3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_84b5, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1015_84b8, 5); calld(0x1016_46a0, 0xc1e3);             /* call 0x101646a0 */
            ii(0x1015_84bd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_84bf, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_84c2, 5); calld(0x1016_4660, 0xc199);             /* call 0x10164660 */
            ii(0x1015_84c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_84c9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_84ca, 1); popd(edi);                              /* pop edi */
            ii(0x1015_84cb, 1); popd(esi);                              /* pop esi */
            ii(0x1015_84cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_84cd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_84ce, 1); retd(); return;                         /* ret */
        }
    }
}
