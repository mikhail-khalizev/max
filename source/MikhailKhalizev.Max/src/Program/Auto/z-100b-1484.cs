using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1484-cbe3ef45")]
        public void Method_100b_1484()
        {
            ii(0x100b_1484, 5); push(0x60);                             /* push 0x60 */
            ii(0x100b_1489, 5); call(Definitions.sys_check_available_stack_size, 0xb_48c4); /* call 0x10165d52 */
            ii(0x100b_148e, 1); push(ebx);                              /* push ebx */
            ii(0x100b_148f, 1); push(ecx);                              /* push ecx */
            ii(0x100b_1490, 1); push(esi);                              /* push esi */
            ii(0x100b_1491, 1); push(edi);                              /* push edi */
            ii(0x100b_1492, 1); push(ebp);                              /* push ebp */
            ii(0x100b_1493, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1495, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100b_149b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_149e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_14a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_14a3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_14a6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_14a9, 5); call(0x1013_ad71, 0x8_98c3);            /* call 0x1013ad71 */
            ii(0x100b_14ae, 2); test(al, al);                           /* test al, al */
            ii(0x100b_14b0, 2); if(jz(0x100b_14c9, 0x17)) goto l_0x100b_14c9; /* jz 0x100b14c9 */
            ii(0x100b_14b2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_14b5, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_14b8, 5); call(0x1007_6574, -0x3_af49);           /* call 0x10076574 */
            ii(0x100b_14bd, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x100b_14c0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_14c5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_14c7, 2); if(jle(0x100b_14cb, 0x2)) goto l_0x100b_14cb; /* jle 0x100b14cb */
        l_0x100b_14c9:
            ii(0x100b_14c9, 2); jmp(0x100b_14d4, 0x9); goto l_0x100b_14d4; /* jmp 0x100b14d4 */
        l_0x100b_14cb:
            ii(0x100b_14cb, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_14cf, 5); jmp(0x100b_1809, 0x335); goto l_0x100b_1809; /* jmp 0x100b1809 */
        l_0x100b_14d4:
            ii(0x100b_14d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_14d6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_14d9, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_14dc, 5); call(0x1013_ad71, 0x8_9890);            /* call 0x1013ad71 */
            ii(0x100b_14e1, 2); test(al, al);                           /* test al, al */
            ii(0x100b_14e3, 2); if(jz(0x100b_1520, 0x3b)) goto l_0x100b_1520; /* jz 0x100b1520 */
            ii(0x100b_14e5, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_14e8, 3); mov(edx, memd[ds, edx + 0x11]);         /* mov edx, [edx+0x11] */
            ii(0x100b_14eb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_14ee, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_14f1, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x100b_14f4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_14f7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_14fd, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100b_1502, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_1504, 5); call(0x100d_fd2c, 0x2_e823);            /* call 0x100dfd2c */
            ii(0x100b_1509, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_150b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_150e, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1511, 5); call(0x1007_6574, -0x3_afa2);           /* call 0x10076574 */
            ii(0x100b_1516, 4); mov(dx, memw[ds, edx + 0x19]);          /* mov dx, [edx+0x19] */
            ii(0x100b_151a, 4); cmp(dx, memw[ds, eax + 0x52]);          /* cmp dx, [eax+0x52] */
            ii(0x100b_151e, 2); if(jle(0x100b_1522, 0x2)) goto l_0x100b_1522; /* jle 0x100b1522 */
        l_0x100b_1520:
            ii(0x100b_1520, 2); jmp(0x100b_152b, 0x9); goto l_0x100b_152b; /* jmp 0x100b152b */
        l_0x100b_1522:
            ii(0x100b_1522, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_1526, 5); jmp(0x100b_1809, 0x2de); goto l_0x100b_1809; /* jmp 0x100b1809 */
        l_0x100b_152b:
            ii(0x100b_152b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_152e, 5); call(0x100b_7d68, 0x6835);              /* call 0x100b7d68 */
            ii(0x100b_1533, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1535, 2); if(jnz(0x100b_1540, 0x9)) goto l_0x100b_1540; /* jnz 0x100b1540 */
            ii(0x100b_1537, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_153b, 5); jmp(0x100b_1809, 0x2c9); goto l_0x100b_1809; /* jmp 0x100b1809 */
        l_0x100b_1540:
            ii(0x100b_1540, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1543, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_1546, 5); call(0x1007_6b90, -0x3_a9bb);           /* call 0x10076b90 */
            ii(0x100b_154b, 1); cwde();                                 /* cwde */
            ii(0x100b_154c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_154e, 2); if(jnz(0x100b_1578, 0x28)) goto l_0x100b_1578; /* jnz 0x100b1578 */
            ii(0x100b_1550, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1552, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1555, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1558, 5); call(0x1013_ad11, 0x8_97b4);            /* call 0x1013ad11 */
            ii(0x100b_155d, 2); test(al, al);                           /* test al, al */
            ii(0x100b_155f, 2); if(jnz(0x100b_1576, 0x15)) goto l_0x100b_1576; /* jnz 0x100b1576 */
            ii(0x100b_1561, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1564, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1567, 5); call(0x1007_6574, -0x3_aff8);           /* call 0x10076574 */
            ii(0x100b_156c, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100b_156f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_1572, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1574, 2); if(jnz(0x100b_1578, 0x2)) goto l_0x100b_1578; /* jnz 0x100b1578 */
        l_0x100b_1576:
            ii(0x100b_1576, 2); jmp(0x100b_157a, 0x2); goto l_0x100b_157a; /* jmp 0x100b157a */
        l_0x100b_1578:
            ii(0x100b_1578, 2); jmp(0x100b_1583, 0x9); goto l_0x100b_1583; /* jmp 0x100b1583 */
        l_0x100b_157a:
            ii(0x100b_157a, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_157e, 5); jmp(0x100b_1809, 0x286); goto l_0x100b_1809; /* jmp 0x100b1809 */
        l_0x100b_1583:
            ii(0x100b_1583, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1585, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1588, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_158b, 5); call(0x1013_ad11, 0x8_9781);            /* call 0x1013ad11 */
            ii(0x100b_1590, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1592, 2); if(jz(0x100b_15e4, 0x50)) goto l_0x100b_15e4; /* jz 0x100b15e4 */
            ii(0x100b_1594, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1597, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x100b_159a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_159d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_15a0, 3); mov(edx, memd[ds, edx + 0x7]);          /* mov edx, [edx+0x7] */
            ii(0x100b_15a3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_15a6, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100b_15ac, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100b_15b1, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100b_15b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_15b5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_15b7, 5); call(0x100d_fd2c, 0x2_e770);            /* call 0x100dfd2c */
            ii(0x100b_15bc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_15be, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_15c1, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_15c4, 5); call(0x1007_6b90, -0x3_aa39);           /* call 0x10076b90 */
            ii(0x100b_15c9, 4); cmp(ax, memw[ds, edx + 0x19]);          /* cmp ax, [edx+0x19] */
            ii(0x100b_15cd, 2); if(jge(0x100b_15d5, 0x6)) goto l_0x100b_15d5; /* jge 0x100b15d5 */
            ii(0x100b_15cf, 4); mov(memb[ss, ebp - 0x24], 0x1);         /* mov byte [ebp-0x24], 0x1 */
            ii(0x100b_15d3, 2); jmp(0x100b_15d9, 0x4); goto l_0x100b_15d9; /* jmp 0x100b15d9 */
        l_0x100b_15d5:
            ii(0x100b_15d5, 4); mov(memb[ss, ebp - 0x24], 0);           /* mov byte [ebp-0x24], 0x0 */
        l_0x100b_15d9:
            ii(0x100b_15d9, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x100b_15dc, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100b_15df, 5); jmp(0x100b_1809, 0x225); goto l_0x100b_1809; /* jmp 0x100b1809 */
        l_0x100b_15e4:
            ii(0x100b_15e4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_15e7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_15ea, 5); call(0x1007_6574, -0x3_b07b);           /* call 0x10076574 */
            ii(0x100b_15ef, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100b_15f2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_15f5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_15f8, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_15fb, 5); call(0x1007_6574, -0x3_b08c);           /* call 0x10076574 */
            ii(0x100b_1600, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100b_1603, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_1606, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_1609, 5); call(0x1007_6aac, -0x3_ab62);           /* call 0x10076aac */
            ii(0x100b_160e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1611, 5); call(0x100b_7d68, 0x6752);              /* call 0x100b7d68 */
            ii(0x100b_1616, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_1619, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_161c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_161f, 5); call(0x1007_6574, -0x3_b0b0);           /* call 0x10076574 */
            ii(0x100b_1624, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x100b_1628, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100b_162b, 4); sub(ax, memw[ds, edx + 0x1c]);          /* sub ax, [edx+0x1c] */
            ii(0x100b_162f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_1632, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1635, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1638, 5); call(0x1007_6574, -0x3_b0c9);           /* call 0x10076574 */
            ii(0x100b_163d, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x100b_1641, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100b_1644, 4); sub(ax, memw[ds, edx + 0x1a]);          /* sub ax, [edx+0x1a] */
            ii(0x100b_1648, 1); cwde();                                 /* cwde */
            ii(0x100b_1649, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_164b, 5); call(0x100a_5f65, -0xb6eb);             /* call 0x100a5f65 */
            ii(0x100b_1650, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_1653, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1656, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_1659, 5); call(0x1007_6b90, -0x3_aace);           /* call 0x10076b90 */
            ii(0x100b_165e, 1); cwde();                                 /* cwde */
            ii(0x100b_165f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1661, 6); if(jz(0x100b_1720, 0xb9)) goto l_0x100b_1720; /* jz 0x100b1720 */
            ii(0x100b_1667, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_166a, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_166d, 5); call(0x100b_7c44, 0x65d2);              /* call 0x100b7c44 */
            ii(0x100b_1672, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x100b_1675, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1677, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1679, 5); call(0x100b_7b28, 0x64aa);              /* call 0x100b7b28 */
            ii(0x100b_167e, 2); jmp(0x100b_1688, 0x8); goto l_0x100b_1688; /* jmp 0x100b1688 */
        l_0x100b_1680:
            ii(0x100b_1680, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_1683, 5); call(0x1007_6bf8, -0x3_aa90);           /* call 0x10076bf8 */
        l_0x100b_1688:
            ii(0x100b_1688, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_168a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_168d, 5); call(0x1013_ad71, 0x8_96df);            /* call 0x1013ad71 */
            ii(0x100b_1692, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1694, 6); if(jz(0x100b_1716, 0x7c)) goto l_0x100b_1716; /* jz 0x100b1716 */
            ii(0x100b_169a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_169d, 5); call(0x100b_7a14, 0x6372);              /* call 0x100b7a14 */
            ii(0x100b_16a2, 5); call(0x100b_7d68, 0x66c1);              /* call 0x100b7d68 */
            ii(0x100b_16a7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_16a9, 2); if(jz(0x100b_1711, 0x66)) goto l_0x100b_1711; /* jz 0x100b1711 */
            ii(0x100b_16ab, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_16ae, 5); call(0x100b_7a14, 0x6361);              /* call 0x100b7a14 */
            ii(0x100b_16b3, 5); call(0x100b_7d68, 0x66b0);              /* call 0x100b7d68 */
            ii(0x100b_16b8, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_16bb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_16be, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_16c1, 5); call(0x1007_6574, -0x3_b152);           /* call 0x10076574 */
            ii(0x100b_16c6, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x100b_16ca, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100b_16cd, 4); sub(ax, memw[ds, edx + 0x1c]);          /* sub ax, [edx+0x1c] */
            ii(0x100b_16d1, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_16d4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_16d7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_16da, 5); call(0x1007_6574, -0x3_b16b);           /* call 0x10076574 */
            ii(0x100b_16df, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x100b_16e3, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100b_16e6, 4); sub(ax, memw[ds, edx + 0x1a]);          /* sub ax, [edx+0x1a] */
            ii(0x100b_16ea, 1); cwde();                                 /* cwde */
            ii(0x100b_16eb, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_16ed, 5); call(0x100a_5f65, -0xb78d);             /* call 0x100a5f65 */
            ii(0x100b_16f2, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_16f5, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_16f8, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x100b_16fc, 2); if(jge(0x100b_1711, 0x13)) goto l_0x100b_1711; /* jge 0x100b1711 */
            ii(0x100b_16fe, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_1702, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1704, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_1707, 5); call(0x100b_7650, 0x5f44);              /* call 0x100b7650 */
            ii(0x100b_170c, 5); jmp(0x100b_1809, 0xf8); goto l_0x100b_1809; /* jmp 0x100b1809 */
        l_0x100b_1711:
            ii(0x100b_1711, 5); jmp(0x100b_1680, -0x96); goto l_0x100b_1680; /* jmp 0x100b1680 */
        l_0x100b_1716:
            ii(0x100b_1716, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1718, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_171b, 5); call(0x100b_7650, 0x5f30);              /* call 0x100b7650 */
        l_0x100b_1720:
            ii(0x100b_1720, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1723, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1726, 5); call(0x1007_6574, -0x3_b1b7);           /* call 0x10076574 */
            ii(0x100b_172b, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100b_172e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_1731, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1733, 6); if(jle(0x100b_1805, 0xcc)) goto l_0x100b_1805; /* jle 0x100b1805 */
            ii(0x100b_1739, 4); or(memb[ss, ebp - 0x10], 0x1);          /* or byte [ebp-0x10], 0x1 */
            ii(0x100b_173d, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_1740, 5); call(0x100b_7cbc, 0x6577);              /* call 0x100b7cbc */
            ii(0x100b_1745, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100b_1748, 4); and(memb[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100b_174c, 4); or(memb[ss, ebp - 0x10], 0x1);          /* or byte [ebp-0x10], 0x1 */
            ii(0x100b_1750, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_1753, 5); call(0x100b_7b6c, 0x6414);              /* call 0x100b7b6c */
            ii(0x100b_1758, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100b_175b, 4); and(memb[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100b_175f, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100b_1762, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1765, 5); call(0x100b_0f0d, -0x85d);              /* call 0x100b0f0d */
            ii(0x100b_176a, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_176d, 5); call(0x100b_7c44, 0x64d2);              /* call 0x100b7c44 */
            ii(0x100b_1772, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1774, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_1777, 5); call(0x100b_7aac, 0x6330);              /* call 0x100b7aac */
            ii(0x100b_177c, 2); jmp(0x100b_1786, 0x8); goto l_0x100b_1786; /* jmp 0x100b1786 */
        l_0x100b_177e:
            ii(0x100b_177e, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_1781, 5); call(0x1007_6bf8, -0x3_ab8e);           /* call 0x10076bf8 */
        l_0x100b_1786:
            ii(0x100b_1786, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1788, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_178b, 5); call(0x1013_ad71, 0x8_95e1);            /* call 0x1013ad71 */
            ii(0x100b_1790, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1792, 2); if(jz(0x100b_17f1, 0x5d)) goto l_0x100b_17f1; /* jz 0x100b17f1 */
            ii(0x100b_1794, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_1797, 5); call(0x100b_7a14, 0x6278);              /* call 0x100b7a14 */
            ii(0x100b_179c, 5); call(0x100b_7d68, 0x65c7);              /* call 0x100b7d68 */
            ii(0x100b_17a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_17a3, 2); if(jz(0x100b_17ef, 0x4a)) goto l_0x100b_17ef; /* jz 0x100b17ef */
            ii(0x100b_17a5, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x100b_17a8, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_17ab, 5); call(0x100b_7a14, 0x6264);              /* call 0x100b7a14 */
            ii(0x100b_17b0, 5); call(0x100b_7da0, 0x65eb);              /* call 0x100b7da0 */
            ii(0x100b_17b5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_17b7, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100b_17ba, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_17bd, 5); call(0x1007_5e64, -0x3_b95e);           /* call 0x10075e64 */
            ii(0x100b_17c2, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_17c4, 5); call(0x100a_5fca, -0xb7ff);             /* call 0x100a5fca */
            ii(0x100b_17c9, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_17cc, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_17cf, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x100b_17d3, 2); if(jge(0x100b_17ef, 0x1a)) goto l_0x100b_17ef; /* jge 0x100b17ef */
            ii(0x100b_17d5, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_17d9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_17db, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_17de, 5); call(0x100b_7650, 0x5e6d);              /* call 0x100b7650 */
            ii(0x100b_17e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_17e5, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_17e8, 5); call(0x100b_7610, 0x5e23);              /* call 0x100b7610 */
            ii(0x100b_17ed, 2); jmp(0x100b_1809, 0x1a); goto l_0x100b_1809; /* jmp 0x100b1809 */
        l_0x100b_17ef:
            ii(0x100b_17ef, 2); jmp(0x100b_177e, -0x73); goto l_0x100b_177e; /* jmp 0x100b177e */
        l_0x100b_17f1:
            ii(0x100b_17f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_17f3, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_17f6, 5); call(0x100b_7650, 0x5e55);              /* call 0x100b7650 */
            ii(0x100b_17fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_17fd, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_1800, 5); call(0x100b_7610, 0x5e0b);              /* call 0x100b7610 */
        l_0x100b_1805:
            ii(0x100b_1805, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x100b_1809:
            ii(0x100b_1809, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100b_180c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_180e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_180f, 1); pop(edi);                               /* pop edi */
            ii(0x100b_1810, 1); pop(esi);                               /* pop esi */
            ii(0x100b_1811, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_1812, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_1813, 1); ret();                                  /* ret */
        }
    }
}
