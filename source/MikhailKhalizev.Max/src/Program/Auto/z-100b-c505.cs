using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("69b5eec2-fbd7-421a-a602-bb3317e1c9b3")]
        public void Method_100b_c505()
        {
            ii(0x100b_c505, 6); lea(edx, ebp - 0x1a4);                  /* lea edx, [ebp-0x1a4] */
            ii(0x100b_c50b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c50e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c511, 5); calld(0x1007_8137, -0x4_43df);          /* call 0x10078137 */
            ii(0x100b_c516, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c519, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_c51c, 5); calld(0x100c_b000, 0xeadf);             /* call 0x100cb000 */
            ii(0x100b_c521, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c523, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c526, 5); calld(0x100c_af68, 0xea3d);             /* call 0x100caf68 */
            ii(0x100b_c52b, 2); jmpd(0x100b_c535, 0x8); goto l_0x100b_c535; /* jmp 0x100bc535 */
        l_0x100b_c52d:
            ii(0x100b_c52d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c530, 5); calld(0x1007_6bf8, -0x4_593d);          /* call 0x10076bf8 */
        l_0x100b_c535:
            ii(0x100b_c535, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c537, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c53a, 5); calld(0x1013_ad71, 0x7_e832);           /* call 0x1013ad71 */
            ii(0x100b_c53f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c541, 6); if(jzd(0x100b_c644, 0xfd)) goto l_0x100b_c644; /* jz 0x100bc644 */
            ii(0x100b_c547, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c54a, 5); calld(0x1008_a0f8, -0x3_2457);          /* call 0x1008a0f8 */
            ii(0x100b_c54f, 5); calld(0x100b_8dfb, -0x3759);            /* call 0x100b8dfb */
            ii(0x100b_c554, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_c556, 6); if(jnzd(0x100b_c63f, 0xe3)) goto l_0x100b_c63f; /* jnz 0x100bc63f */
            ii(0x100b_c55c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c55f, 5); calld(0x1008_a0f8, -0x3_246c);          /* call 0x1008a0f8 */
            ii(0x100b_c564, 5); calld(0x1008_a370, -0x3_21f9);          /* call 0x1008a370 */
            ii(0x100b_c569, 6); mov(memd_a32[ss, ebp - 0x1a8], eax);    /* mov [ebp-0x1a8], eax */
            ii(0x100b_c56f, 6); lea(ebx, ebp - 0x1a4);                  /* lea ebx, [ebp-0x1a4] */
            ii(0x100b_c575, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c578, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_c57b, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c581, 5); calld(0x1007_76f3, -0x4_4e93);          /* call 0x100776f3 */
            ii(0x100b_c586, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c588, 2); if(jzd(0x100b_c5a6, 0x1c)) goto l_0x100b_c5a6; /* jz 0x100bc5a6 */
            ii(0x100b_c58a, 5); mov(ebx, 0x1000);                       /* mov ebx, 0x1000 */
            ii(0x100b_c58f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c592, 5); calld(0x1008_a12c, -0x3_246b);          /* call 0x1008a12c */
            ii(0x100b_c597, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c599, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c59c, 5); calld(0x100b_ab5d, -0x1a44);            /* call 0x100bab5d */
            ii(0x100b_c5a1, 5); jmpd(0x100b_c63f, 0x99); goto l_0x100b_c63f; /* jmp 0x100bc63f */
        l_0x100b_c5a6:
            ii(0x100b_c5a6, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c5ae, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c5b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c5b4, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100b_c5b7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_c5ba, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c5bc, 2); if(jzd(0x100b_c5d5, 0x17)) goto l_0x100b_c5d5; /* jz 0x100bc5d5 */
            ii(0x100b_c5be, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5c4, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_c5c7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_c5cc, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100b_c5cf, 6); if(jnzd(0x100b_c63f, 0x6a)) goto l_0x100b_c63f; /* jnz 0x100bc63f */
        l_0x100b_c5d5:
            ii(0x100b_c5d5, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5db, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x100b_c5e0, 2); if(jnzd(0x100b_c5ee, 0xc)) goto l_0x100b_c5ee; /* jnz 0x100bc5ee */
            ii(0x100b_c5e2, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5e8, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100b_c5ec, 2); if(jzd(0x100b_c603, 0x15)) goto l_0x100b_c603; /* jz 0x100bc603 */
        l_0x100b_c5ee:
            ii(0x100b_c5ee, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c5f4, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_c5f7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_c5fa, 5); calld(0x100b_b097, -0x1568);            /* call 0x100bb097 */
            ii(0x100b_c5ff, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c601, 2); if(jzd(0x100b_c605, 0x2)) goto l_0x100b_c605; /* jz 0x100bc605 */
        l_0x100b_c603:
            ii(0x100b_c603, 2); jmpd(0x100b_c628, 0x23); goto l_0x100b_c628; /* jmp 0x100bc628 */
        l_0x100b_c605:
            ii(0x100b_c605, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c60b, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_c60e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_c613, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100b_c616, 2); if(jnzd(0x100b_c626, 0xe)) goto l_0x100b_c626; /* jnz 0x100bc626 */
            ii(0x100b_c618, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100b_c61e, 6); test(memw_a32[ds, eax + 0x12], 0x1c0);  /* test word [eax+0x12], 0x1c0 */
            ii(0x100b_c624, 2); if(jnzd(0x100b_c628, 0x2)) goto l_0x100b_c628; /* jnz 0x100bc628 */
        l_0x100b_c626:
            ii(0x100b_c626, 2); jmpd(0x100b_c63f, 0x17); goto l_0x100b_c63f; /* jmp 0x100bc63f */
        l_0x100b_c628:
            ii(0x100b_c628, 5); mov(ebx, 0x1f00);                       /* mov ebx, 0x1f00 */
            ii(0x100b_c62d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_c630, 5); calld(0x1008_a12c, -0x3_2509);          /* call 0x1008a12c */
            ii(0x100b_c635, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c637, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c63a, 5); calld(0x100b_ab5d, -0x1ae2);            /* call 0x100bab5d */
        l_0x100b_c63f:
            ii(0x100b_c63f, 5); jmpd(0x100b_c52d, -0x117); goto l_0x100b_c52d; /* jmp 0x100bc52d */
        l_0x100b_c644:
            ii(0x100b_c644, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100b_c64b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_c650, 5); calld(0x1007_6338, -0x4_631d);          /* call 0x10076338 */
            ii(0x100b_c655, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c658, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c65a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c65c, 5); calld(0x1007_643c, -0x4_6225);          /* call 0x1007643c */
            ii(0x100b_c661, 2); jmpd(0x100b_c66b, 0x8); goto l_0x100b_c66b; /* jmp 0x100bc66b */
        l_0x100b_c663:
            ii(0x100b_c663, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c666, 5); calld(0x1007_6bf8, -0x4_5a73);          /* call 0x10076bf8 */
        l_0x100b_c66b:
            ii(0x100b_c66b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c66d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c670, 5); calld(0x1013_ad71, 0x7_e6fc);           /* call 0x1013ad71 */
            ii(0x100b_c675, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c677, 2); if(jzd(0x100b_c6b2, 0x39)) goto l_0x100b_c6b2; /* jz 0x100bc6b2 */
            ii(0x100b_c679, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c67c, 5); calld(0x1007_63a0, -0x4_62e1);          /* call 0x100763a0 */
            ii(0x100b_c681, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c683, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c686, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c689, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c68c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c68e, 2); if(jnzd(0x100b_c69f, 0xf)) goto l_0x100b_c69f; /* jnz 0x100bc69f */
            ii(0x100b_c690, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c693, 5); calld(0x1007_63a0, -0x4_62f8);          /* call 0x100763a0 */
            ii(0x100b_c698, 5); cmp(memw_a32[ds, eax + 0x8], 0x7);      /* cmp word [eax+0x8], 0x7 */
            ii(0x100b_c69d, 2); if(jzd(0x100b_c6a1, 0x2)) goto l_0x100b_c6a1; /* jz 0x100bc6a1 */
        l_0x100b_c69f:
            ii(0x100b_c69f, 2); jmpd(0x100b_c6b0, 0xf); goto l_0x100b_c6b0; /* jmp 0x100bc6b0 */
        l_0x100b_c6a1:
            ii(0x100b_c6a1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6a4, 5); calld(0x1007_63a0, -0x4_6309);          /* call 0x100763a0 */
            ii(0x100b_c6a9, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x100b_c6ad, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
        l_0x100b_c6b0:
            ii(0x100b_c6b0, 2); jmpd(0x100b_c663, -0x4f); goto l_0x100b_c663; /* jmp 0x100bc663 */
        l_0x100b_c6b2:
            ii(0x100b_c6b2, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_c6b7, 5); calld(0x1007_6338, -0x4_6384);          /* call 0x10076338 */
            ii(0x100b_c6bc, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c6bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c6c1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c6c3, 5); calld(0x1007_643c, -0x4_628c);          /* call 0x1007643c */
            ii(0x100b_c6c8, 2); jmpd(0x100b_c6d2, 0x8); goto l_0x100b_c6d2; /* jmp 0x100bc6d2 */
        l_0x100b_c6ca:
            ii(0x100b_c6ca, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6cd, 5); calld(0x1007_6bf8, -0x4_5ada);          /* call 0x10076bf8 */
        l_0x100b_c6d2:
            ii(0x100b_c6d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c6d4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6d7, 5); calld(0x1013_ad71, 0x7_e695);           /* call 0x1013ad71 */
            ii(0x100b_c6dc, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c6de, 2); if(jzd(0x100b_c73e, 0x5e)) goto l_0x100b_c73e; /* jz 0x100bc73e */
            ii(0x100b_c6e0, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6e3, 5); calld(0x1007_63a0, -0x4_6348);          /* call 0x100763a0 */
            ii(0x100b_c6e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c6ea, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c6ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c6f0, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c6f3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c6f5, 2); if(jnzd(0x100b_c706, 0xf)) goto l_0x100b_c706; /* jnz 0x100bc706 */
            ii(0x100b_c6f7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c6fa, 5); calld(0x1007_63a0, -0x4_635f);          /* call 0x100763a0 */
            ii(0x100b_c6ff, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100b_c704, 2); if(jzd(0x100b_c708, 0x2)) goto l_0x100b_c708; /* jz 0x100bc708 */
        l_0x100b_c706:
            ii(0x100b_c706, 2); jmpd(0x100b_c716, 0xe); goto l_0x100b_c716; /* jmp 0x100bc716 */
        l_0x100b_c708:
            ii(0x100b_c708, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c70b, 5); calld(0x1007_63a0, -0x4_6370);          /* call 0x100763a0 */
            ii(0x100b_c710, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100b_c714, 2); if(jnzd(0x100b_c718, 0x2)) goto l_0x100b_c718; /* jnz 0x100bc718 */
        l_0x100b_c716:
            ii(0x100b_c716, 2); jmpd(0x100b_c726, 0xe); goto l_0x100b_c726; /* jmp 0x100bc726 */
        l_0x100b_c718:
            ii(0x100b_c718, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c71b, 5); calld(0x1007_63a0, -0x4_6380);          /* call 0x100763a0 */
            ii(0x100b_c720, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_c724, 2); if(jnzd(0x100b_c728, 0x2)) goto l_0x100b_c728; /* jnz 0x100bc728 */
        l_0x100b_c726:
            ii(0x100b_c726, 2); jmpd(0x100b_c73c, 0x14); goto l_0x100b_c73c; /* jmp 0x100bc73c */
        l_0x100b_c728:
            ii(0x100b_c728, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c72a, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x100b_c72f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c732, 5); calld(0x1007_6408, -0x4_632f);          /* call 0x10076408 */
            ii(0x100b_c737, 5); calld(0x1016_3053, 0xa_6917);           /* call 0x10163053 */
        l_0x100b_c73c:
            ii(0x100b_c73c, 2); jmpd(0x100b_c6ca, -0x74); goto l_0x100b_c6ca; /* jmp 0x100bc6ca */
        l_0x100b_c73e:
            ii(0x100b_c73e, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100b_c742, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100b_c745, 6); if(jld(0x100b_c800, 0xb5)) goto l_0x100b_c800; /* jl 0x100bc800 */
            ii(0x100b_c74b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_c750, 5); calld(0x1007_6338, -0x4_641d);          /* call 0x10076338 */
            ii(0x100b_c755, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c758, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c75a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c75c, 5); calld(0x1007_643c, -0x4_6325);          /* call 0x1007643c */
            ii(0x100b_c761, 2); jmpd(0x100b_c76b, 0x8); goto l_0x100b_c76b; /* jmp 0x100bc76b */
        l_0x100b_c763:
            ii(0x100b_c763, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c766, 5); calld(0x1007_6bf8, -0x4_5b73);          /* call 0x10076bf8 */
        l_0x100b_c76b:
            ii(0x100b_c76b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c76d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c770, 5); calld(0x1013_ad71, 0x7_e5fc);           /* call 0x1013ad71 */
            ii(0x100b_c775, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c777, 6); if(jzd(0x100b_c800, 0x83)) goto l_0x100b_c800; /* jz 0x100bc800 */
            ii(0x100b_c77d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c780, 5); calld(0x1007_63a0, -0x4_63e5);          /* call 0x100763a0 */
            ii(0x100b_c785, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c787, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c78a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c78d, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c790, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c792, 2); if(jnzd(0x100b_c7c5, 0x31)) goto l_0x100b_c7c5; /* jnz 0x100bc7c5 */
            ii(0x100b_c794, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c797, 5); calld(0x1007_63a0, -0x4_63fc);          /* call 0x100763a0 */
            ii(0x100b_c79c, 5); cmp(memw_a32[ds, eax + 0x8], 0);        /* cmp word [eax+0x8], 0x0 */
            ii(0x100b_c7a1, 2); if(jzd(0x100b_c7b2, 0xf)) goto l_0x100b_c7b2; /* jz 0x100bc7b2 */
            ii(0x100b_c7a3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7a6, 5); calld(0x1007_63a0, -0x4_640b);          /* call 0x100763a0 */
            ii(0x100b_c7ab, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x100b_c7b0, 2); if(jnzd(0x100b_c7b4, 0x2)) goto l_0x100b_c7b4; /* jnz 0x100bc7b4 */
        l_0x100b_c7b2:
            ii(0x100b_c7b2, 2); jmpd(0x100b_c7c3, 0xf); goto l_0x100b_c7c3; /* jmp 0x100bc7c3 */
        l_0x100b_c7b4:
            ii(0x100b_c7b4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7b7, 5); calld(0x1007_63a0, -0x4_641c);          /* call 0x100763a0 */
            ii(0x100b_c7bc, 5); cmp(memw_a32[ds, eax + 0x8], 0x1d);     /* cmp word [eax+0x8], 0x1d */
            ii(0x100b_c7c1, 2); if(jnzd(0x100b_c7c5, 0x2)) goto l_0x100b_c7c5; /* jnz 0x100bc7c5 */
        l_0x100b_c7c3:
            ii(0x100b_c7c3, 2); jmpd(0x100b_c7c7, 0x2); goto l_0x100b_c7c7; /* jmp 0x100bc7c7 */
        l_0x100b_c7c5:
            ii(0x100b_c7c5, 2); jmpd(0x100b_c7d5, 0xe); goto l_0x100b_c7d5; /* jmp 0x100bc7d5 */
        l_0x100b_c7c7:
            ii(0x100b_c7c7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7ca, 5); calld(0x1007_63a0, -0x4_642f);          /* call 0x100763a0 */
            ii(0x100b_c7cf, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100b_c7d3, 2); if(jnzd(0x100b_c7d7, 0x2)) goto l_0x100b_c7d7; /* jnz 0x100bc7d7 */
        l_0x100b_c7d5:
            ii(0x100b_c7d5, 2); jmpd(0x100b_c7e5, 0xe); goto l_0x100b_c7e5; /* jmp 0x100bc7e5 */
        l_0x100b_c7d7:
            ii(0x100b_c7d7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7da, 5); calld(0x1007_63a0, -0x4_643f);          /* call 0x100763a0 */
            ii(0x100b_c7df, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_c7e3, 2); if(jnzd(0x100b_c7e7, 0x2)) goto l_0x100b_c7e7; /* jnz 0x100bc7e7 */
        l_0x100b_c7e5:
            ii(0x100b_c7e5, 2); jmpd(0x100b_c7fb, 0x14); goto l_0x100b_c7fb; /* jmp 0x100bc7fb */
        l_0x100b_c7e7:
            ii(0x100b_c7e7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c7e9, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x100b_c7ee, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c7f1, 5); calld(0x1007_6408, -0x4_63ee);          /* call 0x10076408 */
            ii(0x100b_c7f6, 5); calld(0x1016_3053, 0xa_6858);           /* call 0x10163053 */
        l_0x100b_c7fb:
            ii(0x100b_c7fb, 5); jmpd(0x100b_c763, -0x9d); goto l_0x100b_c763; /* jmp 0x100bc763 */
        l_0x100b_c800:
            ii(0x100b_c800, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c802, 6); lea(edx, ebp - 0x1ac);                  /* lea edx, [ebp-0x1ac] */
            ii(0x100b_c808, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c80b, 5); calld(0x100c_6677, 0x9e67);             /* call 0x100c6677 */
            ii(0x100b_c810, 6); lea(edx, ebp - 0x1b0);                  /* lea edx, [ebp-0x1b0] */
            ii(0x100b_c816, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c819, 5); calld(0x100c_735d, 0xab3f);             /* call 0x100c735d */
            ii(0x100b_c81e, 5); calld(0x100c_aef4, 0xe6d1);             /* call 0x100caef4 */
            ii(0x100b_c823, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c825, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_c827, 6); lea(edx, ebp - 0x1b0);                  /* lea edx, [ebp-0x1b0] */
            ii(0x100b_c82d, 6); lea(eax, ebp - 0x1b4);                  /* lea eax, [ebp-0x1b4] */
            ii(0x100b_c833, 5); calld(0x100c_ae64, 0xe62c);             /* call 0x100cae64 */
            ii(0x100b_c838, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_c83a, 5); calld(0x100c_aef4, 0xe6b5);             /* call 0x100caef4 */
            ii(0x100b_c83f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c841, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_c843, 6); lea(edx, ebp - 0x1ac);                  /* lea edx, [ebp-0x1ac] */
            ii(0x100b_c849, 6); lea(eax, ebp - 0x1b8);                  /* lea eax, [ebp-0x1b8] */
            ii(0x100b_c84f, 5); calld(0x100c_ae64, 0xe610);             /* call 0x100cae64 */
            ii(0x100b_c854, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100b_c857, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100b_c859, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c85b, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100b_c85d, 5); calld(0x100c_63af, 0x9b4d);             /* call 0x100c63af */
            ii(0x100b_c862, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c864, 6); lea(eax, ebp - 0x1b8);                  /* lea eax, [ebp-0x1b8] */
            ii(0x100b_c86a, 5); calld(0x100c_a6a0, 0xde31);             /* call 0x100ca6a0 */
            ii(0x100b_c86f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c871, 6); lea(eax, ebp - 0x1b4);                  /* lea eax, [ebp-0x1b4] */
            ii(0x100b_c877, 5); calld(0x100c_a6a0, 0xde24);             /* call 0x100ca6a0 */
            ii(0x100b_c87c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c87f, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c882, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_c888, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100b_c88e, 5); calld(0x100c_b67c, 0xede9);             /* call 0x100cb67c */
            ii(0x100b_c893, 6); mov(memd_a32[ss, ebp - 0x1bc], eax);    /* mov [ebp-0x1bc], eax */
        l_0x100b_c899:
            ii(0x100b_c899, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c89c, 5); cmp(memw_a32[ds, eax + 0xa], -0x1 /* 0xff */); /* cmp word [eax+0xa], 0xffff */
            ii(0x100b_c8a1, 2); if(jzd(0x100b_c8b3, 0x10)) goto l_0x100b_c8b3; /* jz 0x100bc8b3 */
            ii(0x100b_c8a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c8a6, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100b_c8aa, 7); cmp(ax, memw_a32[ss, ebp - 0x1bc]);     /* cmp ax, [ebp-0x1bc] */
            ii(0x100b_c8b1, 2); if(jled(0x100b_c8b8, 0x5)) goto l_0x100b_c8b8; /* jle 0x100bc8b8 */
        l_0x100b_c8b3:
            ii(0x100b_c8b3, 5); jmpd(0x100b_c97c, 0xc4); goto l_0x100b_c97c; /* jmp 0x100bc97c */
        l_0x100b_c8b8:
            ii(0x100b_c8b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c8bb, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100b_c8bf, 6); sub(memd_a32[ss, ebp - 0x1bc], eax);    /* sub [ebp-0x1bc], eax */
            ii(0x100b_c8c5, 7); movsx(edx, memw_a32[ss, ebp - 0x1bc]);  /* movsx edx, word [ebp-0x1bc] */
            ii(0x100b_c8cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c8cf, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c8d2, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_c8d8, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100b_c8de, 5); calld(0x100c_b60c, 0xed29);             /* call 0x100cb60c */
            ii(0x100b_c8e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c8e6, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c8e9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_c8ef, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_c8f2, 4); mov(dx, memw_a32[ds, edx + 0xc]);       /* mov dx, [edx+0xc] */
            ii(0x100b_c8f6, 7); add(memw_a32[ds, eax + 0x101c_a583], dx); /* add [eax+0x101ca583], dx */
            ii(0x100b_c8fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c900, 5); calld(0x100c_79a0, 0xb09b);             /* call 0x100c79a0 */
            ii(0x100b_c905, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100b_c90c, 2); if(jzd(0x100b_c919, 0xb)) goto l_0x100b_c919; /* jz 0x100bc919 */
            ii(0x100b_c90e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c911, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c914, 5); calld(0x1012_894c, 0x6_c033);           /* call 0x1012894c */
        l_0x100b_c919:
            ii(0x100b_c919, 5); calld(0x100c_aef4, 0xe5d6);             /* call 0x100caef4 */
            ii(0x100b_c91e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c920, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_c922, 6); lea(edx, ebp - 0x1b0);                  /* lea edx, [ebp-0x1b0] */
            ii(0x100b_c928, 6); lea(eax, ebp - 0x1c0);                  /* lea eax, [ebp-0x1c0] */
            ii(0x100b_c92e, 5); calld(0x100c_ae64, 0xe531);             /* call 0x100cae64 */
            ii(0x100b_c933, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100b_c935, 5); calld(0x100c_aef4, 0xe5ba);             /* call 0x100caef4 */
            ii(0x100b_c93a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_c93c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_c93e, 6); lea(edx, ebp - 0x1ac);                  /* lea edx, [ebp-0x1ac] */
            ii(0x100b_c944, 6); lea(eax, ebp - 0x1c4);                  /* lea eax, [ebp-0x1c4] */
            ii(0x100b_c94a, 5); calld(0x100c_ae64, 0xe515);             /* call 0x100cae64 */
            ii(0x100b_c94f, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100b_c952, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_c954, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c956, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_c958, 5); calld(0x100c_63af, 0x9a52);             /* call 0x100c63af */
            ii(0x100b_c95d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c95f, 6); lea(eax, ebp - 0x1c4);                  /* lea eax, [ebp-0x1c4] */
            ii(0x100b_c965, 5); calld(0x100c_a6a0, 0xdd36);             /* call 0x100ca6a0 */
            ii(0x100b_c96a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c96c, 6); lea(eax, ebp - 0x1c0);                  /* lea eax, [ebp-0x1c0] */
            ii(0x100b_c972, 5); calld(0x100c_a6a0, 0xdd29);             /* call 0x100ca6a0 */
            ii(0x100b_c977, 5); jmpd(0x100b_c899, -0xe3); goto l_0x100b_c899; /* jmp 0x100bc899 */
        l_0x100b_c97c:
            ii(0x100b_c97c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c97e, 6); lea(eax, ebp - 0x1b0);                  /* lea eax, [ebp-0x1b0] */
            ii(0x100b_c984, 5); calld(0x100c_a6a0, 0xdd17);             /* call 0x100ca6a0 */
            ii(0x100b_c989, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c98b, 6); lea(eax, ebp - 0x1ac);                  /* lea eax, [ebp-0x1ac] */
            ii(0x100b_c991, 5); calld(0x100c_a6a0, 0xdd0a);             /* call 0x100ca6a0 */
            ii(0x100b_c996, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c999, 5); calld(0x100b_e21a, 0x187c);             /* call 0x100be21a */
            ii(0x100b_c99e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c9a1, 5); calld(0x100b_b100, -0x18a6);            /* call 0x100bb100 */
            ii(0x100b_c9a6, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_c9ab, 5); calld(0x1007_6338, -0x4_6678);          /* call 0x10076338 */
            ii(0x100b_c9b0, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_c9b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_c9b5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_c9b7, 5); calld(0x1007_643c, -0x4_6580);          /* call 0x1007643c */
            ii(0x100b_c9bc, 2); jmpd(0x100b_c9c6, 0x8); goto l_0x100b_c9c6; /* jmp 0x100bc9c6 */
        l_0x100b_c9be:
            ii(0x100b_c9be, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c9c1, 5); calld(0x1007_6bf8, -0x4_5dce);          /* call 0x10076bf8 */
        l_0x100b_c9c6:
            ii(0x100b_c9c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c9c8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c9cb, 5); calld(0x1013_ad71, 0x7_e3a1);           /* call 0x1013ad71 */
            ii(0x100b_c9d0, 2); test(al, al);                           /* test al, al */
            ii(0x100b_c9d2, 6); if(jzd(0x100b_cab1, 0xd9)) goto l_0x100b_cab1; /* jz 0x100bcab1 */
            ii(0x100b_c9d8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c9db, 5); calld(0x1007_63a0, -0x4_6640);          /* call 0x100763a0 */
            ii(0x100b_c9e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_c9e2, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_c9e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_c9e8, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_c9eb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_c9ed, 6); if(jnzd(0x100b_caac, 0xb9)) goto l_0x100b_caac; /* jnz 0x100bcaac */
            ii(0x100b_c9f3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_c9f6, 5); calld(0x1007_63a0, -0x4_665b);          /* call 0x100763a0 */
            ii(0x100b_c9fb, 5); calld(0x1015_26ac, 0x9_5cac);           /* call 0x101526ac */
            ii(0x100b_ca00, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ca02, 2); if(jzd(0x100b_ca1a, 0x16)) goto l_0x100b_ca1a; /* jz 0x100bca1a */
            ii(0x100b_ca04, 5); calld(0x1008_b0e4, -0x3_1925);          /* call 0x1008b0e4 */
            ii(0x100b_ca09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ca0b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_ca0d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_ca10, 5); calld(0x1007_63d4, -0x4_6641);          /* call 0x100763d4 */
            ii(0x100b_ca15, 5); calld(0x100a_297d, -0x1_a09d);          /* call 0x100a297d */
        l_0x100b_ca1a:
            ii(0x100b_ca1a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_ca1d, 5); calld(0x1007_63a0, -0x4_6682);          /* call 0x100763a0 */
            ii(0x100b_ca22, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100b_ca25, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_ca2a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ca2c, 6); if(jled(0x100b_caac, 0x7a)) goto l_0x100b_caac; /* jle 0x100bcaac */
            ii(0x100b_ca32, 10); mov(memd_a32[ss, ebp - 0x1c8], 0x1);   /* mov dword [ebp-0x1c8], 0x1 */
            ii(0x100b_ca3c, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100b_ca41, 5); calld(Definitions.sys_new, 0xa_93ba);   /* call 0x10165e00 */
            ii(0x100b_ca46, 6); mov(memd_a32[ss, ebp - 0x1cc], eax);    /* mov [ebp-0x1cc], eax */
            ii(0x100b_ca4c, 6); mov(eax, memd_a32[ss, ebp - 0x1cc]);    /* mov eax, [ebp-0x1cc] */
            ii(0x100b_ca52, 6); mov(memd_a32[ss, ebp - 0x1d0], eax);    /* mov [ebp-0x1d0], eax */
            ii(0x100b_ca58, 7); cmp(memd_a32[ss, ebp - 0x1d0], 0);      /* cmp dword [ebp-0x1d0], 0x0 */
            ii(0x100b_ca5f, 2); if(jzd(0x100b_ca8a, 0x29)) goto l_0x100b_ca8a; /* jz 0x100bca8a */
            ii(0x100b_ca61, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_ca64, 5); calld(0x1007_63d4, -0x4_6695);          /* call 0x100763d4 */
            ii(0x100b_ca69, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ca6b, 6); mov(eax, memd_a32[ss, ebp - 0x1cc]);    /* mov eax, [ebp-0x1cc] */
            ii(0x100b_ca71, 5); calld(0x100a_3d3a, -0x1_8d3c);          /* call 0x100a3d3a */
            ii(0x100b_ca76, 6); mov(memd_a32[ss, ebp - 0x1d4], eax);    /* mov [ebp-0x1d4], eax */
            ii(0x100b_ca7c, 6); mov(eax, memd_a32[ss, ebp - 0x1d4]);    /* mov eax, [ebp-0x1d4] */
            ii(0x100b_ca82, 6); mov(memd_a32[ss, ebp - 0x1d8], eax);    /* mov [ebp-0x1d8], eax */
            ii(0x100b_ca88, 2); jmpd(0x100b_ca96, 0xc); goto l_0x100b_ca96; /* jmp 0x100bca96 */
        l_0x100b_ca8a:
            ii(0x100b_ca8a, 6); mov(eax, memd_a32[ss, ebp - 0x1d0]);    /* mov eax, [ebp-0x1d0] */
            ii(0x100b_ca90, 6); mov(memd_a32[ss, ebp - 0x1d8], eax);    /* mov [ebp-0x1d8], eax */
        l_0x100b_ca96:
            ii(0x100b_ca96, 6); mov(edx, memd_a32[ss, ebp - 0x1d8]);    /* mov edx, [ebp-0x1d8] */
            ii(0x100b_ca9c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_caa1, 6); mov(ebx, memd_a32[ss, ebp - 0x1c8]);    /* mov ebx, [ebp-0x1c8] */
            ii(0x100b_caa7, 5); calld(0x100a_4db6, -0x1_7cf6);          /* call 0x100a4db6 */
        l_0x100b_caac:
            ii(0x100b_caac, 5); jmpd(0x100b_c9be, -0xf3); goto l_0x100b_c9be; /* jmp 0x100bc9be */
        l_0x100b_cab1:
            ii(0x100b_cab1, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100b_cab6, 5); calld(0x1007_6338, -0x4_6783);          /* call 0x10076338 */
            ii(0x100b_cabb, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100b_cabe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_cac0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_cac2, 5); calld(0x1007_643c, -0x4_668b);          /* call 0x1007643c */
            ii(0x100b_cac7, 2); jmpd(0x100b_cad1, 0x8); goto l_0x100b_cad1; /* jmp 0x100bcad1 */
        l_0x100b_cac9:
            ii(0x100b_cac9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cacc, 5); calld(0x1007_6bf8, -0x4_5ed9);          /* call 0x10076bf8 */
        l_0x100b_cad1:
            ii(0x100b_cad1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cad3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cad6, 5); calld(0x1013_ad71, 0x7_e296);           /* call 0x1013ad71 */
            ii(0x100b_cadb, 2); test(al, al);                           /* test al, al */
            ii(0x100b_cadd, 6); if(jzd(0x100b_cbbc, 0xd9)) goto l_0x100b_cbbc; /* jz 0x100bcbbc */
            ii(0x100b_cae3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cae6, 5); calld(0x1007_63a0, -0x4_674b);          /* call 0x100763a0 */
            ii(0x100b_caeb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_caed, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_caf0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_caf3, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_caf6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_caf8, 6); if(jnzd(0x100b_cbb7, 0xb9)) goto l_0x100b_cbb7; /* jnz 0x100bcbb7 */
            ii(0x100b_cafe, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cb01, 5); calld(0x1007_63a0, -0x4_6766);          /* call 0x100763a0 */
            ii(0x100b_cb06, 5); calld(0x1015_26ac, 0x9_5ba1);           /* call 0x101526ac */
            ii(0x100b_cb0b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_cb0d, 2); if(jzd(0x100b_cb25, 0x16)) goto l_0x100b_cb25; /* jz 0x100bcb25 */
            ii(0x100b_cb0f, 5); calld(0x1008_b0e4, -0x3_1a30);          /* call 0x1008b0e4 */
            ii(0x100b_cb14, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cb16, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_cb18, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cb1b, 5); calld(0x1007_63d4, -0x4_674c);          /* call 0x100763d4 */
            ii(0x100b_cb20, 5); calld(0x100a_297d, -0x1_a1a8);          /* call 0x100a297d */
        l_0x100b_cb25:
            ii(0x100b_cb25, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cb28, 5); calld(0x1007_63a0, -0x4_678d);          /* call 0x100763a0 */
            ii(0x100b_cb2d, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100b_cb30, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_cb35, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_cb37, 6); if(jled(0x100b_cbb7, 0x7a)) goto l_0x100b_cbb7; /* jle 0x100bcbb7 */
            ii(0x100b_cb3d, 10); mov(memd_a32[ss, ebp - 0x1dc], 0x1);   /* mov dword [ebp-0x1dc], 0x1 */
            ii(0x100b_cb47, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100b_cb4c, 5); calld(Definitions.sys_new, 0xa_92af);   /* call 0x10165e00 */
            ii(0x100b_cb51, 6); mov(memd_a32[ss, ebp - 0x1e0], eax);    /* mov [ebp-0x1e0], eax */
            ii(0x100b_cb57, 6); mov(eax, memd_a32[ss, ebp - 0x1e0]);    /* mov eax, [ebp-0x1e0] */
            ii(0x100b_cb5d, 6); mov(memd_a32[ss, ebp - 0x1e4], eax);    /* mov [ebp-0x1e4], eax */
            ii(0x100b_cb63, 7); cmp(memd_a32[ss, ebp - 0x1e4], 0);      /* cmp dword [ebp-0x1e4], 0x0 */
            ii(0x100b_cb6a, 2); if(jzd(0x100b_cb95, 0x29)) goto l_0x100b_cb95; /* jz 0x100bcb95 */
            ii(0x100b_cb6c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cb6f, 5); calld(0x1007_63d4, -0x4_67a0);          /* call 0x100763d4 */
            ii(0x100b_cb74, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_cb76, 6); mov(eax, memd_a32[ss, ebp - 0x1e0]);    /* mov eax, [ebp-0x1e0] */
            ii(0x100b_cb7c, 5); calld(0x100a_3d3a, -0x1_8e47);          /* call 0x100a3d3a */
            ii(0x100b_cb81, 6); mov(memd_a32[ss, ebp - 0x1e8], eax);    /* mov [ebp-0x1e8], eax */
            ii(0x100b_cb87, 6); mov(eax, memd_a32[ss, ebp - 0x1e8]);    /* mov eax, [ebp-0x1e8] */
            ii(0x100b_cb8d, 6); mov(memd_a32[ss, ebp - 0x1ec], eax);    /* mov [ebp-0x1ec], eax */
            ii(0x100b_cb93, 2); jmpd(0x100b_cba1, 0xc); goto l_0x100b_cba1; /* jmp 0x100bcba1 */
        l_0x100b_cb95:
            ii(0x100b_cb95, 6); mov(eax, memd_a32[ss, ebp - 0x1e4]);    /* mov eax, [ebp-0x1e4] */
            ii(0x100b_cb9b, 6); mov(memd_a32[ss, ebp - 0x1ec], eax);    /* mov [ebp-0x1ec], eax */
        l_0x100b_cba1:
            ii(0x100b_cba1, 6); mov(edx, memd_a32[ss, ebp - 0x1ec]);    /* mov edx, [ebp-0x1ec] */
            ii(0x100b_cba7, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_cbac, 6); mov(ebx, memd_a32[ss, ebp - 0x1dc]);    /* mov ebx, [ebp-0x1dc] */
            ii(0x100b_cbb2, 5); calld(0x100a_4db6, -0x1_7e01);          /* call 0x100a4db6 */
        l_0x100b_cbb7:
            ii(0x100b_cbb7, 5); jmpd(0x100b_cac9, -0xf3); goto l_0x100b_cac9; /* jmp 0x100bcac9 */
        l_0x100b_cbbc:
            ii(0x100b_cbbc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_cbbf, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_cbc2, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_cbc7, 5); calld(0x100a_4fb5, -0x1_7c17);          /* call 0x100a4fb5 */
            ii(0x100b_cbcc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cbce, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_cbd1, 5); calld(0x1008_8e4c, -0x3_3d8a);          /* call 0x10088e4c */
            ii(0x100b_cbd6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cbd8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_cbdb, 5); calld(0x1007_5f6c, -0x4_6c74);          /* call 0x10075f6c */
        }
    }
}
