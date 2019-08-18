using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_14bc-fd2b9401")]
        public void Method_1013_14bc()
        {
            ii(0x1013_14bc, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1013_14c1, 5); calld(Definitions.sys_check_available_stack_size, 0x3_488c); /* call 0x10165d52 */
            ii(0x1013_14c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_14c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_14c8, 1); pushd(esi);                             /* push esi */
            ii(0x1013_14c9, 1); pushd(edi);                             /* push edi */
            ii(0x1013_14ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_14cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_14cd, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_14d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_14d6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_14d9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_14dc, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_14df, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_14e2, 3); mov(al, memb_a32[ds, eax + 0x17]);      /* mov al, [eax+0x17] */
            ii(0x1013_14e5, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1013_14e8, 5); jmpd(0x1013_1657, 0x16a); goto l_0x1013_1657; /* jmp 0x10131657 */
        l_0x1013_14ed:
            ii(0x1013_14ed, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_14f0, 4); mov(dx, memw_a32[ds, eax + 0x3a]);      /* mov dx, [eax+0x3a] */
            ii(0x1013_14f4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_14f7, 4); add(memw_a32[ds, eax + 0x30], dx);      /* add [eax+0x30], dx */
            ii(0x1013_14fb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_14fe, 3); mov(edx, memd_a32[ds, eax + 0x38]);     /* mov edx, [eax+0x38] */
            ii(0x1013_1501, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_1504, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1507, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_150a, 5); calld(Definitions.my_1_get_count, -0x8_6037); /* call 0x100ab4d8 */
            ii(0x1013_150f, 1); cwde();                                 /* cwde */
            ii(0x1013_1510, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_1512, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_1514, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1517, 3); mov(eax, memd_a32[ds, eax + 0x2e]);     /* mov eax, [eax+0x2e] */
            ii(0x1013_151a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_151d, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1013_151f, 2); if(jled(0x1013_153e, 0x1d)) goto l_0x1013_153e; /* jle 0x1013153e */
            ii(0x1013_1521, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1524, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_1527, 5); calld(Definitions.my_1_get_count, -0x8_6054); /* call 0x100ab4d8 */
            ii(0x1013_152c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_152e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1531, 4); mov(bx, memw_a32[ds, eax + 0x3a]);      /* mov bx, [eax+0x3a] */
            ii(0x1013_1535, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1538, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1013_153a, 4); mov(memw_a32[ds, eax + 0x30], dx);      /* mov [eax+0x30], dx */
        l_0x1013_153e:
            ii(0x1013_153e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1541, 3); mov(eax, memd_a32[ds, eax + 0x2e]);     /* mov eax, [eax+0x2e] */
            ii(0x1013_1544, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_1547, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_1549, 2); if(jged(0x1013_1554, 0x9)) goto l_0x1013_1554; /* jge 0x10131554 */
            ii(0x1013_154b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_154e, 6); mov(memw_a32[ds, eax + 0x30], 0);       /* mov word [eax+0x30], 0x0 */
        l_0x1013_1554:
            ii(0x1013_1554, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_1559, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_155c, 5); calld(0x1013_0c16, -0x94b);             /* call 0x10130c16 */
            ii(0x1013_1561, 5); jmpd(0x1013_1685, 0x11f); goto l_0x1013_1685; /* jmp 0x10131685 */
        l_0x1013_1566:
            ii(0x1013_1566, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1569, 4); mov(dx, memw_a32[ds, eax + 0x3c]);      /* mov dx, [eax+0x3c] */
            ii(0x1013_156d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1570, 4); add(memw_a32[ds, eax + 0x32], dx);      /* add [eax+0x32], dx */
            ii(0x1013_1574, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1577, 3); mov(edx, memd_a32[ds, eax + 0x3a]);     /* mov edx, [eax+0x3a] */
            ii(0x1013_157a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_157d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1580, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1013_1583, 5); calld(Definitions.my_2_get_count, -0xa_6220); /* call 0x1008b368 */
            ii(0x1013_1588, 1); cwde();                                 /* cwde */
            ii(0x1013_1589, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_158b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_158d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1590, 3); mov(eax, memd_a32[ds, eax + 0x30]);     /* mov eax, [eax+0x30] */
            ii(0x1013_1593, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_1596, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1013_1598, 2); if(jled(0x1013_15b7, 0x1d)) goto l_0x1013_15b7; /* jle 0x101315b7 */
            ii(0x1013_159a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_159d, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1013_15a0, 5); calld(Definitions.my_2_get_count, -0xa_623d); /* call 0x1008b368 */
            ii(0x1013_15a5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_15a7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15aa, 4); mov(bx, memw_a32[ds, eax + 0x3c]);      /* mov bx, [eax+0x3c] */
            ii(0x1013_15ae, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15b1, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1013_15b3, 4); mov(memw_a32[ds, eax + 0x32], dx);      /* mov [eax+0x32], dx */
        l_0x1013_15b7:
            ii(0x1013_15b7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15ba, 3); mov(eax, memd_a32[ds, eax + 0x30]);     /* mov eax, [eax+0x30] */
            ii(0x1013_15bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_15c0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_15c2, 2); if(jged(0x1013_15cd, 0x9)) goto l_0x1013_15cd; /* jge 0x101315cd */
            ii(0x1013_15c4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15c7, 6); mov(memw_a32[ds, eax + 0x32], 0);       /* mov word [eax+0x32], 0x0 */
        l_0x1013_15cd:
            ii(0x1013_15cd, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_15d2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15d5, 5); calld(0x1013_0c16, -0x9c4);             /* call 0x10130c16 */
            ii(0x1013_15da, 5); jmpd(0x1013_1685, 0xa6); goto l_0x1013_1685; /* jmp 0x10131685 */
        l_0x1013_15df:
            ii(0x1013_15df, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15e2, 4); mov(dx, memw_a32[ds, eax + 0x3e]);      /* mov dx, [eax+0x3e] */
            ii(0x1013_15e6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15e9, 4); add(memw_a32[ds, eax + 0x34], dx);      /* add [eax+0x34], dx */
            ii(0x1013_15ed, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15f0, 3); mov(edx, memd_a32[ds, eax + 0x3c]);     /* mov edx, [eax+0x3c] */
            ii(0x1013_15f3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_15f6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_15f9, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1013_15fc, 5); calld(Definitions.my_1_get_count, -0x8_6129); /* call 0x100ab4d8 */
            ii(0x1013_1601, 1); cwde();                                 /* cwde */
            ii(0x1013_1602, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_1604, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_1606, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1609, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1013_160c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_160f, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1013_1611, 2); if(jled(0x1013_1630, 0x1d)) goto l_0x1013_1630; /* jle 0x10131630 */
            ii(0x1013_1613, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1616, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1013_1619, 5); calld(Definitions.my_1_get_count, -0x8_6146); /* call 0x100ab4d8 */
            ii(0x1013_161e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_1620, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1623, 4); mov(bx, memw_a32[ds, eax + 0x3e]);      /* mov bx, [eax+0x3e] */
            ii(0x1013_1627, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_162a, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1013_162c, 4); mov(memw_a32[ds, eax + 0x34], dx);      /* mov [eax+0x34], dx */
        l_0x1013_1630:
            ii(0x1013_1630, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1633, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1013_1636, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_1639, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_163b, 2); if(jged(0x1013_1646, 0x9)) goto l_0x1013_1646; /* jge 0x10131646 */
            ii(0x1013_163d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1640, 6); mov(memw_a32[ds, eax + 0x34], 0);       /* mov word [eax+0x34], 0x0 */
        l_0x1013_1646:
            ii(0x1013_1646, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_164b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_164e, 5); calld(0x1013_0c16, -0xa3d);             /* call 0x10130c16 */
            ii(0x1013_1653, 2); jmpd(0x1013_1685, 0x30); goto l_0x1013_1685; /* jmp 0x10131685 */
        l_0x1013_1655:
            ii(0x1013_1655, 2); jmpd(0x1013_1685, 0x2e); goto l_0x1013_1685; /* jmp 0x10131685 */
        l_0x1013_1657:
            ii(0x1013_1657, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1013_165a, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1013_165d, 4); cmp(memb_a32[ss, ebp - 0x14], 0x1);     /* cmp byte [ebp-0x14], 0x1 */
            ii(0x1013_1661, 2); if(jbd(0x1013_1679, 0x16)) goto l_0x1013_1679; /* jb 0x10131679 */
            ii(0x1013_1663, 4); cmp(memb_a32[ss, ebp - 0x14], 0x1);     /* cmp byte [ebp-0x14], 0x1 */
            ii(0x1013_1667, 6); if(jbed(0x1013_1566, -0x107)) goto l_0x1013_1566; /* jbe 0x10131566 */
            ii(0x1013_166d, 4); cmp(memb_a32[ss, ebp - 0x14], 0x3);     /* cmp byte [ebp-0x14], 0x3 */
            ii(0x1013_1671, 6); if(jzd(0x1013_15df, -0x98)) goto l_0x1013_15df; /* jz 0x101315df */
            ii(0x1013_1677, 2); jmpd(0x1013_1655, -0x24); goto l_0x1013_1655; /* jmp 0x10131655 */
        l_0x1013_1679:
            ii(0x1013_1679, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1013_167d, 6); if(jzd(0x1013_14ed, -0x196)) goto l_0x1013_14ed; /* jz 0x101314ed */
            ii(0x1013_1683, 2); jmpd(0x1013_1655, -0x30); goto l_0x1013_1655; /* jmp 0x10131655 */
        l_0x1013_1685:
            ii(0x1013_1685, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1687, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1688, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1689, 1); popd(esi);                              /* pop esi */
            ii(0x1013_168a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_168b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_168c, 1); retd(); return;                         /* ret */
        }
    }
}
