using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4f3a2482-7ab0-4af5-a554-cf593626f85e")]
        public void Method_100f_750b()
        {
            ii(0x100f_750b, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100f_7510, 5); calld(Definitions.sys_check_available_stack_size, 0x6_e83d); /* call 0x10165d52 */
            ii(0x100f_7515, 1); pushd(esi);                             /* push esi */
            ii(0x100f_7516, 1); pushd(edi);                             /* push edi */
            ii(0x100f_7517, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_7518, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_751a, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100f_7520, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_7523, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100f_7526, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100f_7529, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100f_752c, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_7531, 1); pushd(eax);                             /* push eax */
            ii(0x100f_7532, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x100f_7536, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100f_753a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_753c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_7541, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_7544, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7547, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_754a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_754d, 5); calld(0x1007_02b9, -0x8_7299);          /* call 0x100702b9 */
            ii(0x100f_7552, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100f_7555, 6); if(jzd(0x100f_75d3, 0x78)) goto l_0x100f_75d3; /* jz 0x100f75d3 */
            ii(0x100f_755b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_755e, 5); calld(0x1007_623c, -0x8_1327);          /* call 0x1007623c */
            ii(0x100f_7563, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_7565, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100f_7568, 5); calld(0x1007_6800, -0x8_0d6d);          /* call 0x10076800 */
            ii(0x100f_756d, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_7571, 2); if(jzd(0x100f_758f, 0x1c)) goto l_0x100f_758f; /* jz 0x100f758f */
            ii(0x100f_7573, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_7576, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x100f_757a, 2); if(jzd(0x100f_758f, 0x13)) goto l_0x100f_758f; /* jz 0x100f758f */
            ii(0x100f_757c, 4); mov(memb_a32[ss, ebp - 0x14], 0x11);    /* mov byte [ebp-0x14], 0x11 */
            ii(0x100f_7580, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_7582, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100f_7585, 5); calld(0x1007_5eec, -0x8_169e);          /* call 0x10075eec */
            ii(0x100f_758a, 5); jmpd(0x100f_783b, 0x2ac); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_758f:
            ii(0x100f_758f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7592, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x100f_7596, 2); if(jnzd(0x100f_75ab, 0x13)) goto l_0x100f_75ab; /* jnz 0x100f75ab */
            ii(0x100f_7598, 4); mov(memb_a32[ss, ebp - 0x14], 0x15);    /* mov byte [ebp-0x14], 0x15 */
            ii(0x100f_759c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_759e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100f_75a1, 5); calld(0x1007_5eec, -0x8_16ba);          /* call 0x10075eec */
            ii(0x100f_75a6, 5); jmpd(0x100f_783b, 0x290); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_75ab:
            ii(0x100f_75ab, 7); cmp(memb_a32[ds, 0x101c_3918], 0);      /* cmp byte [0x101c3918], 0x0 */
            ii(0x100f_75b2, 2); if(jzd(0x100f_75ba, 0x6)) goto l_0x100f_75ba; /* jz 0x100f75ba */
            ii(0x100f_75b4, 4); mov(memb_a32[ss, ebp - 0x1c], 0x16);    /* mov byte [ebp-0x1c], 0x16 */
            ii(0x100f_75b8, 2); jmpd(0x100f_75be, 0x4); goto l_0x100f_75be; /* jmp 0x100f75be */
        l_0x100f_75ba:
            ii(0x100f_75ba, 4); mov(memb_a32[ss, ebp - 0x1c], 0x14);    /* mov byte [ebp-0x1c], 0x14 */
        l_0x100f_75be:
            ii(0x100f_75be, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x100f_75c1, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100f_75c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_75c6, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100f_75c9, 5); calld(0x1007_5eec, -0x8_16e2);          /* call 0x10075eec */
            ii(0x100f_75ce, 5); jmpd(0x100f_783b, 0x268); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_75d3:
            ii(0x100f_75d3, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_75d7, 2); if(jnzd(0x100f_75e2, 0x9)) goto l_0x100f_75e2; /* jnz 0x100f75e2 */
            ii(0x100f_75d9, 4); mov(memb_a32[ss, ebp - 0x14], 0x15);    /* mov byte [ebp-0x14], 0x15 */
            ii(0x100f_75dd, 5); jmpd(0x100f_783b, 0x259); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_75e2:
            ii(0x100f_75e2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_75e5, 4); cmp(memb_a32[ds, eax + 0x57], 0x7);     /* cmp byte [eax+0x57], 0x7 */
            ii(0x100f_75e9, 2); if(jnzd(0x100f_7600, 0x15)) goto l_0x100f_7600; /* jnz 0x100f7600 */
            ii(0x100f_75eb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_75ee, 5); calld(0x1007_623c, -0x8_13b7);          /* call 0x1007623c */
            ii(0x100f_75f3, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_75f6, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x100f_75fa, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x100f_75fe, 2); if(jld(0x100f_7605, 0x5)) goto l_0x100f_7605; /* jl 0x100f7605 */
        l_0x100f_7600:
            ii(0x100f_7600, 5); jmpd(0x100f_76ac, 0xa7); goto l_0x100f_76ac; /* jmp 0x100f76ac */
        l_0x100f_7605:
            ii(0x100f_7605, 5); mov(ecx, 0x100);                        /* mov ecx, 0x100 */
            ii(0x100f_760a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_760c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_7611, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_7614, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_7618, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_761c, 5); calld(0x1007_388b, -0x8_3d96);          /* call 0x1007388b */
            ii(0x100f_7621, 5); mov(memd_a32[ds, 0x101c_3894], eax);    /* mov [0x101c3894], eax */
            ii(0x100f_7626, 7); cmp(memd_a32[ds, 0x101c_3894], 0);      /* cmp dword [0x101c3894], 0x0 */
            ii(0x100f_762d, 2); if(jzd(0x100f_763d, 0xe)) goto l_0x100f_763d; /* jz 0x100f763d */
            ii(0x100f_762f, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_7634, 5); calld(0x100a_2edb, -0x5_475e);          /* call 0x100a2edb */
            ii(0x100f_7639, 2); test(al, al);                           /* test al, al */
            ii(0x100f_763b, 2); if(jnzd(0x100f_763f, 0x2)) goto l_0x100f_763f; /* jnz 0x100f763f */
        l_0x100f_763d:
            ii(0x100f_763d, 2); jmpd(0x100f_7691, 0x52); goto l_0x100f_7691; /* jmp 0x100f7691 */
        l_0x100f_763f:
            ii(0x100f_763f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7642, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100f_7646, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_7649, 2); jmpd(0x100f_7672, 0x27); goto l_0x100f_7672; /* jmp 0x100f7672 */
        l_0x100f_764b:
            ii(0x100f_764b, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_7650, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x100f_7655, 2); if(jzd(0x100f_7663, 0xc)) goto l_0x100f_7663; /* jz 0x100f7663 */
            ii(0x100f_7657, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_765c, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x100f_7661, 2); if(jnzd(0x100f_7665, 0x2)) goto l_0x100f_7665; /* jnz 0x100f7665 */
        l_0x100f_7663:
            ii(0x100f_7663, 2); jmpd(0x100f_7667, 0x2); goto l_0x100f_7667; /* jmp 0x100f7667 */
        l_0x100f_7665:
            ii(0x100f_7665, 2); jmpd(0x100f_7691, 0x2a); goto l_0x100f_7691; /* jmp 0x100f7691 */
        l_0x100f_7667:
            ii(0x100f_7667, 4); mov(memb_a32[ss, ebp - 0x14], 0x10);    /* mov byte [ebp-0x14], 0x10 */
            ii(0x100f_766b, 5); jmpd(0x100f_783b, 0x1cb); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_7670:
            ii(0x100f_7670, 2); jmpd(0x100f_7691, 0x1f); goto l_0x100f_7691; /* jmp 0x100f7691 */
        l_0x100f_7672:
            ii(0x100f_7672, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_7675, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100f_7678, 5); cmp(memw_a32[ss, ebp - 0x24], 0x41);    /* cmp word [ebp-0x24], 0x41 */
            ii(0x100f_767d, 2); if(jbd(0x100f_768f, 0x10)) goto l_0x100f_768f; /* jb 0x100f768f */
            ii(0x100f_767f, 5); cmp(memw_a32[ss, ebp - 0x24], 0x41);    /* cmp word [ebp-0x24], 0x41 */
            ii(0x100f_7684, 2); if(jbed(0x100f_764b, -0x3b)) goto l_0x100f_764b; /* jbe 0x100f764b */
            ii(0x100f_7686, 5); cmp(memw_a32[ss, ebp - 0x24], 0x48);    /* cmp word [ebp-0x24], 0x48 */
            ii(0x100f_768b, 2); if(jzd(0x100f_7667, -0x26)) goto l_0x100f_7667; /* jz 0x100f7667 */
            ii(0x100f_768d, 2); jmpd(0x100f_7670, -0x1f); goto l_0x100f_7670; /* jmp 0x100f7670 */
        l_0x100f_768f:
            ii(0x100f_768f, 2); jmpd(0x100f_7670, -0x21); goto l_0x100f_7670; /* jmp 0x100f7670 */
        l_0x100f_7691:
            ii(0x100f_7691, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_7695, 2); if(jzd(0x100f_769d, 0x6)) goto l_0x100f_769d; /* jz 0x100f769d */
            ii(0x100f_7697, 4); mov(memb_a32[ss, ebp - 0x28], 0x11);    /* mov byte [ebp-0x28], 0x11 */
            ii(0x100f_769b, 2); jmpd(0x100f_76a1, 0x4); goto l_0x100f_76a1; /* jmp 0x100f76a1 */
        l_0x100f_769d:
            ii(0x100f_769d, 4); mov(memb_a32[ss, ebp - 0x28], 0x15);    /* mov byte [ebp-0x28], 0x15 */
        l_0x100f_76a1:
            ii(0x100f_76a1, 3); mov(al, memb_a32[ss, ebp - 0x28]);      /* mov al, [ebp-0x28] */
            ii(0x100f_76a4, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100f_76a7, 5); jmpd(0x100f_783b, 0x18f); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_76ac:
            ii(0x100f_76ac, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_76af, 4); cmp(memb_a32[ds, eax + 0x57], 0);       /* cmp byte [eax+0x57], 0x0 */
            ii(0x100f_76b3, 6); if(jzd(0x100f_7837, 0x17e)) goto l_0x100f_7837; /* jz 0x100f7837 */
            ii(0x100f_76b9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_76bb, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_76c0, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_76c3, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_76c7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_76cb, 5); calld(0x1007_3aa6, -0x8_3c2a);          /* call 0x10073aa6 */
            ii(0x100f_76d0, 5); mov(memd_a32[ds, 0x101c_3894], eax);    /* mov [0x101c3894], eax */
            ii(0x100f_76d5, 7); cmp(memd_a32[ds, 0x101c_3894], 0);      /* cmp dword [0x101c3894], 0x0 */
            ii(0x100f_76dc, 2); if(jzd(0x100f_76f2, 0x14)) goto l_0x100f_76f2; /* jz 0x100f76f2 */
            ii(0x100f_76de, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_76e2, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_76e6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_76e9, 5); calld(0x100f_1f41, -0x57ad);            /* call 0x100f1f41 */
            ii(0x100f_76ee, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_76f0, 2); if(jnzd(0x100f_76f4, 0x2)) goto l_0x100f_76f4; /* jnz 0x100f76f4 */
        l_0x100f_76f2:
            ii(0x100f_76f2, 2); jmpd(0x100f_76fe, 0xa); goto l_0x100f_76fe; /* jmp 0x100f76fe */
        l_0x100f_76f4:
            ii(0x100f_76f4, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_76f9, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100f_76fc, 2); if(jnzd(0x100f_7700, 0x2)) goto l_0x100f_7700; /* jnz 0x100f7700 */
        l_0x100f_76fe:
            ii(0x100f_76fe, 2); jmpd(0x100f_7711, 0x11); goto l_0x100f_7711; /* jmp 0x100f7711 */
        l_0x100f_7700:
            ii(0x100f_7700, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_7705, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100f_7708, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_770d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_770f, 2); if(jgd(0x100f_7716, 0x5)) goto l_0x100f_7716; /* jg 0x100f7716 */
        l_0x100f_7711:
            ii(0x100f_7711, 5); jmpd(0x100f_7837, 0x121); goto l_0x100f_7837; /* jmp 0x100f7837 */
        l_0x100f_7716:
            ii(0x100f_7716, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7719, 3); mov(al, memb_a32[ds, eax + 0x57]);      /* mov al, [eax+0x57] */
            ii(0x100f_771c, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x100f_771f, 5); jmpd(0x100f_7811, 0xed); goto l_0x100f_7811; /* jmp 0x100f7811 */
        l_0x100f_7724:
            ii(0x100f_7724, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7727, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100f_772a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_772d, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x100f_7730, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_7735, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_7738, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_773b, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_773e, 6); mov(dl, memb_a32[ds, edx + 0x101c_81d5]); /* mov dl, [edx+0x101c81d5] */
            ii(0x100f_7744, 6); cmp(dl, memb_a32[ds, eax + 0x101c_81d5]); /* cmp dl, [eax+0x101c81d5] */
            ii(0x100f_774a, 2); if(jnzd(0x100f_7757, 0xb)) goto l_0x100f_7757; /* jnz 0x100f7757 */
            ii(0x100f_774c, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_7751, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x100f_7755, 2); if(jnzd(0x100f_7759, 0x2)) goto l_0x100f_7759; /* jnz 0x100f7759 */
        l_0x100f_7757:
            ii(0x100f_7757, 2); jmpd(0x100f_7764, 0xb); goto l_0x100f_7764; /* jmp 0x100f7764 */
        l_0x100f_7759:
            ii(0x100f_7759, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_775e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100f_7762, 2); if(jnzd(0x100f_7766, 0x2)) goto l_0x100f_7766; /* jnz 0x100f7766 */
        l_0x100f_7764:
            ii(0x100f_7764, 2); jmpd(0x100f_776f, 0x9); goto l_0x100f_776f; /* jmp 0x100f776f */
        l_0x100f_7766:
            ii(0x100f_7766, 4); mov(memb_a32[ss, ebp - 0x14], 0xd);     /* mov byte [ebp-0x14], 0xd */
            ii(0x100f_776a, 5); jmpd(0x100f_783b, 0xcc); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_776f:
            ii(0x100f_776f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7772, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100f_7776, 2); if(jnzd(0x100f_7783, 0xb)) goto l_0x100f_7783; /* jnz 0x100f7783 */
            ii(0x100f_7778, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_777d, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100f_7781, 2); if(jnzd(0x100f_7785, 0x2)) goto l_0x100f_7785; /* jnz 0x100f7785 */
        l_0x100f_7783:
            ii(0x100f_7783, 2); jmpd(0x100f_77ad, 0x28); goto l_0x100f_77ad; /* jmp 0x100f77ad */
        l_0x100f_7785:
            ii(0x100f_7785, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7788, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100f_778b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_778e, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x100f_7791, 6); mov(edx, memd_a32[ds, edx + 0x101c_81d2]); /* mov edx, [edx+0x101c81d2] */
            ii(0x100f_7797, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100f_779a, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_779f, 5); calld(0x1007_6204, -0x8_15a0);          /* call 0x10076204 */
            ii(0x100f_77a4, 5); calld(0x100f_744f, -0x35a);             /* call 0x100f744f */
            ii(0x100f_77a9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_77ab, 2); if(jnzd(0x100f_77af, 0x2)) goto l_0x100f_77af; /* jnz 0x100f77af */
        l_0x100f_77ad:
            ii(0x100f_77ad, 2); jmpd(0x100f_77b8, 0x9); goto l_0x100f_77b8; /* jmp 0x100f77b8 */
        l_0x100f_77af:
            ii(0x100f_77af, 4); mov(memb_a32[ss, ebp - 0x14], 0xd);     /* mov byte [ebp-0x14], 0xd */
            ii(0x100f_77b3, 5); jmpd(0x100f_783b, 0x83); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_77b8:
            ii(0x100f_77b8, 5); jmpd(0x100f_7837, 0x7a); goto l_0x100f_7837; /* jmp 0x100f7837 */
        l_0x100f_77bd:
            ii(0x100f_77bd, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_77c2, 5); calld(0x1007_623c, -0x8_158b);          /* call 0x1007623c */
            ii(0x100f_77c7, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100f_77ca, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_77cd, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_77d2, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100f_77d5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_77da, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_77dc, 2); if(jged(0x100f_77e4, 0x6)) goto l_0x100f_77e4; /* jge 0x100f77e4 */
            ii(0x100f_77de, 4); mov(memb_a32[ss, ebp - 0x14], 0xc);     /* mov byte [ebp-0x14], 0xc */
            ii(0x100f_77e2, 2); jmpd(0x100f_783b, 0x57); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_77e4:
            ii(0x100f_77e4, 2); jmpd(0x100f_7837, 0x51); goto l_0x100f_7837; /* jmp 0x100f7837 */
        l_0x100f_77e6:
            ii(0x100f_77e6, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_77eb, 5); calld(0x1007_623c, -0x8_15b4);          /* call 0x1007623c */
            ii(0x100f_77f0, 3); mov(edx, memd_a32[ds, eax + 0x19]);     /* mov edx, [eax+0x19] */
            ii(0x100f_77f3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_77f6, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_77fb, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x100f_77fe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_7803, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_7805, 2); if(jged(0x100f_780d, 0x6)) goto l_0x100f_780d; /* jge 0x100f780d */
            ii(0x100f_7807, 4); mov(memb_a32[ss, ebp - 0x14], 0xf);     /* mov byte [ebp-0x14], 0xf */
            ii(0x100f_780b, 2); jmpd(0x100f_783b, 0x2e); goto l_0x100f_783b; /* jmp 0x100f783b */
        l_0x100f_780d:
            ii(0x100f_780d, 2); jmpd(0x100f_7837, 0x28); goto l_0x100f_7837; /* jmp 0x100f7837 */
        l_0x100f_780f:
            ii(0x100f_780f, 2); jmpd(0x100f_7837, 0x26); goto l_0x100f_7837; /* jmp 0x100f7837 */
        l_0x100f_7811:
            ii(0x100f_7811, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x100f_7814, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x100f_7817, 4); cmp(memb_a32[ss, ebp - 0x30], 0x4);     /* cmp byte [ebp-0x30], 0x4 */
            ii(0x100f_781b, 2); if(jbd(0x100f_782b, 0xe)) goto l_0x100f_782b; /* jb 0x100f782b */
            ii(0x100f_781d, 4); cmp(memb_a32[ss, ebp - 0x30], 0x4);     /* cmp byte [ebp-0x30], 0x4 */
            ii(0x100f_7821, 2); if(jbed(0x100f_77bd, -0x66)) goto l_0x100f_77bd; /* jbe 0x100f77bd */
            ii(0x100f_7823, 4); cmp(memb_a32[ss, ebp - 0x30], 0x6);     /* cmp byte [ebp-0x30], 0x6 */
            ii(0x100f_7827, 2); if(jzd(0x100f_77e6, -0x43)) goto l_0x100f_77e6; /* jz 0x100f77e6 */
            ii(0x100f_7829, 2); jmpd(0x100f_780f, -0x1c); goto l_0x100f_780f; /* jmp 0x100f780f */
        l_0x100f_782b:
            ii(0x100f_782b, 4); cmp(memb_a32[ss, ebp - 0x30], 0x3);     /* cmp byte [ebp-0x30], 0x3 */
            ii(0x100f_782f, 6); if(jzd(0x100f_7724, -0x111)) goto l_0x100f_7724; /* jz 0x100f7724 */
            ii(0x100f_7835, 2); jmpd(0x100f_780f, -0x28); goto l_0x100f_780f; /* jmp 0x100f780f */
        l_0x100f_7837:
            ii(0x100f_7837, 4); mov(memb_a32[ss, ebp - 0x14], 0x11);    /* mov byte [ebp-0x14], 0x11 */
        l_0x100f_783b:
            ii(0x100f_783b, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_783e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_7840, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_7841, 1); popd(edi);                              /* pop edi */
            ii(0x100f_7842, 1); popd(esi);                              /* pop esi */
            ii(0x100f_7843, 1); retd(); return;                         /* ret */
        }
    }
}
