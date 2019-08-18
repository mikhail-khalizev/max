using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7ad05a97-2cde-4878-8f87-4105a683d652")]
        public void Method_1007_0010()
        {
            ii(0x1007_0010, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1007_0015, 5); calld(Definitions.sys_check_available_stack_size, 0xf_5d38); /* call 0x10165d52 */
            ii(0x1007_001a, 1); pushd(esi);                             /* push esi */
            ii(0x1007_001b, 1); pushd(edi);                             /* push edi */
            ii(0x1007_001c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_001d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_001f, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1007_0025, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_0028, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1007_002b, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_002e, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1007_0031, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_0035, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_0039, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_003e, 5); calld(0x1010_3541, 0x9_34fe);           /* call 0x10103541 */
            ii(0x1007_0043, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1007_0046, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_0048, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_004a, 5); calld(0x1007_64b8, 0x6469);             /* call 0x100764b8 */
            ii(0x1007_004f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0051, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_0054, 5); calld(0x1007_66ac, 0x6653);             /* call 0x100766ac */
        l_0x1007_0059:
            ii(0x1007_0059, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_005b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_005e, 5); calld(0x1013_ad71, 0xc_ad0e);           /* call 0x1013ad71 */
            ii(0x1007_0063, 2); test(al, al);                           /* test al, al */
            ii(0x1007_0065, 6); if(jzd(0x1007_020e, 0x1a3)) goto l_0x1007_020e; /* jz 0x1007020e */
            ii(0x1007_006b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_006e, 5); calld(0x1007_63a0, 0x632d);             /* call 0x100763a0 */
            ii(0x1007_0073, 6); test(memw_a32[ds, eax + 0x12], 0x180);  /* test word [eax+0x12], 0x180 */
            ii(0x1007_0079, 6); if(jzd(0x1007_01de, 0x15f)) goto l_0x1007_01de; /* jz 0x100701de */
            ii(0x1007_007f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_0082, 5); calld(0x1007_63a0, 0x6319);             /* call 0x100763a0 */
            ii(0x1007_0087, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_008b, 6); if(jzd(0x1007_01dc, 0x14b)) goto l_0x1007_01dc; /* jz 0x100701dc */
            ii(0x1007_0091, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_0094, 5); calld(0x1007_63a0, 0x6307);             /* call 0x100763a0 */
            ii(0x1007_0099, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1007_009d, 2); if(jzd(0x1007_00ad, 0xe)) goto l_0x1007_00ad; /* jz 0x100700ad */
            ii(0x1007_009f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_00a2, 5); calld(0x1007_63a0, 0x62f9);             /* call 0x100763a0 */
            ii(0x1007_00a7, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1b);    /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1007_00ab, 2); if(jnzd(0x1007_00af, 0x2)) goto l_0x1007_00af; /* jnz 0x100700af */
        l_0x1007_00ad:
            ii(0x1007_00ad, 2); jmpd(0x1007_00bd, 0xe); goto l_0x1007_00bd; /* jmp 0x100700bd */
        l_0x1007_00af:
            ii(0x1007_00af, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_00b2, 5); calld(0x1007_63a0, 0x62e9);             /* call 0x100763a0 */
            ii(0x1007_00b7, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1e);    /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_00bb, 2); if(jnzd(0x1007_00bf, 0x2)) goto l_0x1007_00bf; /* jnz 0x100700bf */
        l_0x1007_00bd:
            ii(0x1007_00bd, 2); jmpd(0x1007_00df, 0x20); goto l_0x1007_00df; /* jmp 0x100700df */
        l_0x1007_00bf:
            ii(0x1007_00bf, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_00c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_00c8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_00cb, 5); calld(0x1007_5f2c, 0x5e5c);             /* call 0x10075f2c */
            ii(0x1007_00d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_00d2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_00d5, 5); calld(0x1007_5f6c, 0x5e92);             /* call 0x10075f6c */
            ii(0x1007_00da, 5); jmpd(0x1007_02ae, 0x1cf); goto l_0x1007_02ae; /* jmp 0x100702ae */
        l_0x1007_00df:
            ii(0x1007_00df, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_00e2, 5); calld(0x1007_63a0, 0x62b9);             /* call 0x100763a0 */
            ii(0x1007_00e7, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1007_00eb, 2); if(jzd(0x1007_0103, 0x16)) goto l_0x1007_0103; /* jz 0x10070103 */
            ii(0x1007_00ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_00ef, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_00f2, 5); calld(0x1007_63a0, 0x62a9);             /* call 0x100763a0 */
            ii(0x1007_00f7, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_00fa, 5); calld(0x1013_ad11, 0xc_ac12);           /* call 0x1013ad11 */
            ii(0x1007_00ff, 2); test(al, al);                           /* test al, al */
            ii(0x1007_0101, 2); if(jzd(0x1007_0123, 0x20)) goto l_0x1007_0123; /* jz 0x10070123 */
        l_0x1007_0103:
            ii(0x1007_0103, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_010a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_010c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_010f, 5); calld(0x1007_5f2c, 0x5e18);             /* call 0x10075f2c */
            ii(0x1007_0114, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0116, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_0119, 5); calld(0x1007_5f6c, 0x5e4e);             /* call 0x10075f6c */
            ii(0x1007_011e, 5); jmpd(0x1007_02ae, 0x18b); goto l_0x1007_02ae; /* jmp 0x100702ae */
        l_0x1007_0123:
            ii(0x1007_0123, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_0126, 5); calld(0x1007_63a0, 0x6275);             /* call 0x100763a0 */
            ii(0x1007_012b, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1007_012f, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1007_0133, 2); if(jnzd(0x1007_0147, 0x12)) goto l_0x1007_0147; /* jnz 0x10070147 */
            ii(0x1007_0135, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_0138, 5); calld(0x1007_63a0, 0x6263);             /* call 0x100763a0 */
            ii(0x1007_013d, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1007_0141, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1007_0145, 2); if(jzd(0x1007_0167, 0x20)) goto l_0x1007_0167; /* jz 0x10070167 */
        l_0x1007_0147:
            ii(0x1007_0147, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_014e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0150, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_0153, 5); calld(0x1007_5f2c, 0x5dd4);             /* call 0x10075f2c */
            ii(0x1007_0158, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_015a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_015d, 5); calld(0x1007_5f6c, 0x5e0a);             /* call 0x10075f6c */
            ii(0x1007_0162, 5); jmpd(0x1007_02ae, 0x147); goto l_0x1007_02ae; /* jmp 0x100702ae */
        l_0x1007_0167:
            ii(0x1007_0167, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_016a, 5); calld(0x1007_63a0, 0x6231);             /* call 0x100763a0 */
            ii(0x1007_016f, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_0172, 5); calld(0x1007_69d8, 0x6861);             /* call 0x100769d8 */
            ii(0x1007_0177, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_017a, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_017d, 3); mov(ecx, memd_a32[ds, eax + 0x2]);      /* mov ecx, [eax+0x2] */
            ii(0x1007_0180, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_0183, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1007_0186, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1007_0189, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_018c, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1007_018f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_0192, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_0195, 3); calld_abs(memd_a32[ds, ecx + 0x1c]);    /* call dword [ecx+0x1c] */
            ii(0x1007_0198, 2); test(al, al);                           /* test al, al */
            ii(0x1007_019a, 2); if(jzd(0x1007_01bc, 0x20)) goto l_0x1007_01bc; /* jz 0x100701bc */
            ii(0x1007_019c, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_01a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_01a5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_01a8, 5); calld(0x1007_5f2c, 0x5d7f);             /* call 0x10075f2c */
            ii(0x1007_01ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_01af, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_01b2, 5); calld(0x1007_5f6c, 0x5db5);             /* call 0x10075f6c */
            ii(0x1007_01b7, 5); jmpd(0x1007_02ae, 0xf2); goto l_0x1007_02ae; /* jmp 0x100702ae */
        l_0x1007_01bc:
            ii(0x1007_01bc, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1007_01c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_01c5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_01c8, 5); calld(0x1007_5f2c, 0x5d5f);             /* call 0x10075f2c */
            ii(0x1007_01cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_01cf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_01d2, 5); calld(0x1007_5f6c, 0x5d95);             /* call 0x10075f6c */
            ii(0x1007_01d7, 5); jmpd(0x1007_02ae, 0xd2); goto l_0x1007_02ae; /* jmp 0x100702ae */
        l_0x1007_01dc:
            ii(0x1007_01dc, 2); jmpd(0x1007_0201, 0x23); goto l_0x1007_0201; /* jmp 0x10070201 */
        l_0x1007_01de:
            ii(0x1007_01de, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_01e1, 5); calld(0x1007_63a0, 0x61ba);             /* call 0x100763a0 */
            ii(0x1007_01e6, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1007_01eb, 2); if(jnzd(0x1007_0201, 0x14)) goto l_0x1007_0201; /* jnz 0x10070201 */
            ii(0x1007_01ed, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_01f0, 5); calld(0x1007_6408, 0x6213);             /* call 0x10076408 */
            ii(0x1007_01f5, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x1007_01f8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_01fa, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_01fc, 5); calld(0x1007_6630, 0x642f);             /* call 0x10076630 */
        l_0x1007_0201:
            ii(0x1007_0201, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_0204, 5); calld(0x1007_6bf8, 0x69ef);             /* call 0x10076bf8 */
            ii(0x1007_0209, 5); jmpd(0x1007_0059, -0x1b5); goto l_0x1007_0059; /* jmp 0x10070059 */
        l_0x1007_020e:
            ii(0x1007_020e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0210, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_0213, 5); calld(0x1013_ad71, 0xc_ab59);           /* call 0x1013ad71 */
            ii(0x1007_0218, 2); test(al, al);                           /* test al, al */
            ii(0x1007_021a, 2); if(jzd(0x1007_027d, 0x61)) goto l_0x1007_027d; /* jz 0x1007027d */
            ii(0x1007_021c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_021f, 5); calld(0x1007_6574, 0x6350);             /* call 0x10076574 */
            ii(0x1007_0224, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1007_0228, 2); if(jnzd(0x1007_0260, 0x36)) goto l_0x1007_0260; /* jnz 0x10070260 */
            ii(0x1007_022a, 4); cmp(memb_a32[ss, ebp + 0x10], 0);       /* cmp byte [ebp+0x10], 0x0 */
            ii(0x1007_022e, 2); if(jzd(0x1007_0249, 0x19)) goto l_0x1007_0249; /* jz 0x10070249 */
            ii(0x1007_0230, 5); mov(ebx, 0x27);                         /* mov ebx, 0x27 */
            ii(0x1007_0235, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1007_023a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_023d, 5); calld(0x1007_65d0, 0x638e);             /* call 0x100765d0 */
            ii(0x1007_0242, 5); calld(0x1016_2f96, 0xf_2d4f);           /* call 0x10162f96 */
            ii(0x1007_0247, 2); jmpd(0x1007_0260, 0x17); goto l_0x1007_0260; /* jmp 0x10070260 */
        l_0x1007_0249:
            ii(0x1007_0249, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1007_024e, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1007_0253, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_0256, 5); calld(0x1007_65d0, 0x6375);             /* call 0x100765d0 */
            ii(0x1007_025b, 5); calld(0x1016_2f96, 0xf_2d36);           /* call 0x10162f96 */
        l_0x1007_0260:
            ii(0x1007_0260, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1007_0267, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0269, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_026c, 5); calld(0x1007_5f2c, 0x5cbb);             /* call 0x10075f2c */
            ii(0x1007_0271, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0273, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_0276, 5); calld(0x1007_5f6c, 0x5cf1);             /* call 0x10075f6c */
            ii(0x1007_027b, 2); jmpd(0x1007_02ae, 0x31); goto l_0x1007_02ae; /* jmp 0x100702ae */
        l_0x1007_027d:
            ii(0x1007_027d, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_0284, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0286, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_0289, 5); calld(0x1007_5f2c, 0x5c9e);             /* call 0x10075f2c */
            ii(0x1007_028e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0290, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_0293, 5); calld(0x1007_5f6c, 0x5cd4);             /* call 0x10075f6c */
            ii(0x1007_0298, 2); jmpd(0x1007_02ae, 0x14); goto l_0x1007_02ae; /* jmp 0x100702ae */
        //    ii(0x1007_029a, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1007_029c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //    ii(0x1007_029f, 5); calld(0x1007_5f2c, 0x5c88);             /* call 0x10075f2c */
        //    ii(0x1007_02a4, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1007_02a6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x1007_02a9, 5); calld(0x1007_5f6c, 0x5cbe);             /* call 0x10075f6c */
        l_0x1007_02ae:
            ii(0x1007_02ae, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_02b1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_02b3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_02b4, 1); popd(edi);                              /* pop edi */
            ii(0x1007_02b5, 1); popd(esi);                              /* pop esi */
            ii(0x1007_02b6, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
