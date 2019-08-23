using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_1386-c39d5b4c")]
        public void Method_1011_1386()
        {
            ii(0x1011_1386, 5); pushd(0x234);                           /* push 0x234 */
            ii(0x1011_138b, 5); calld(Definitions.sys_check_available_stack_size, 0x5_49c2); /* call 0x10165d52 */
            ii(0x1011_1390, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_1391, 1); pushd(esi);                             /* push esi */
            ii(0x1011_1392, 1); pushd(edi);                             /* push edi */
            ii(0x1011_1393, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_1394, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_1396, 6); sub(esp, 0x220);                        /* sub esp, 0x220 */
            ii(0x1011_139c, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1011_139f, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x1011_13a2, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1011_13a5, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_13a9, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_13ac, 3); mov(memb_a32[ss, ebp - 0x1d], al);      /* mov [ebp-0x1d], al */
            ii(0x1011_13af, 4); cmp(memb_a32[ss, ebp - 0xc], 0x2);      /* cmp byte [ebp-0xc], 0x2 */
            ii(0x1011_13b3, 2); if(jnzd(0x1011_13cf, 0x1a)) goto l_0x1011_13cf; /* jnz 0x101113cf */
            ii(0x1011_13b5, 5); mov(eax, 0x41);                         /* mov eax, 0x41 */
            ii(0x1011_13ba, 5); calld(0x1007_5fdc, -0x9_b3e3);          /* call 0x10075fdc */
            ii(0x1011_13bf, 5); mov(ebx, 0x3d);                         /* mov ebx, 0x3d */
            ii(0x1011_13c4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_13c6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_13c8, 5); calld(0x100c_aafc, -0x4_68d1);          /* call 0x100caafc */
            ii(0x1011_13cd, 2); jmpd(0x1011_13de, 0xf); goto l_0x1011_13de; /* jmp 0x101113de */
        l_0x1011_13cf:
            ii(0x1011_13cf, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_13d4, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x1011_13d9, 5); calld(0x100c_aafc, -0x4_68e2);          /* call 0x100caafc */
        l_0x1011_13de:
            ii(0x1011_13de, 7); mov(memb_a32[ss, ebp - 0x164], 0);      /* mov byte [ebp-0x164], 0x0 */
            ii(0x1011_13e5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_13e7, 3); mov(dl, memb_a32[ss, ebp - 0x10]);      /* mov dl, [ebp-0x10] */
            ii(0x1011_13ea, 6); lea(eax, ebp - 0x160);                  /* lea eax, [ebp-0x160] */
            ii(0x1011_13f0, 5); calld(0x1011_0bbb, -0x83a);             /* call 0x10110bbb */
        l_0x1011_13f5:
            ii(0x1011_13f5, 7); cmp(memb_a32[ds, 0x101c_5630], 0x1);    /* cmp byte [0x101c5630], 0x1 */
            ii(0x1011_13fc, 2); if(jnzd(0x1011_1403, 0x5)) goto l_0x1011_1403; /* jnz 0x10111403 */
            ii(0x1011_13fe, 5); calld(0x1012_ac94, 0x1_9891);           /* call 0x1012ac94 */
        l_0x1011_1403:
            ii(0x1011_1403, 5); calld(/* sys */ 0x1016_b208, 0x5_9e00); /* call 0x1016b208 */
            ii(0x1011_1408, 6); mov(memd_a32[ss, ebp - 0x154], eax);    /* mov [ebp-0x154], eax */
            ii(0x1011_140e, 7); cmp(memd_a32[ss, ebp - 0x154], 0);      /* cmp dword [ebp-0x154], 0x0 */
            ii(0x1011_1415, 2); if(jled(0x1011_1423, 0xc)) goto l_0x1011_1423; /* jle 0x10111423 */
            ii(0x1011_1417, 10); cmp(memd_a32[ss, ebp - 0x154], 0x7000); /* cmp dword [ebp-0x154], 0x7000 */
            ii(0x1011_1421, 2); if(jld(0x1011_1425, 0x2)) goto l_0x1011_1425; /* jl 0x10111425 */
        l_0x1011_1423:
            ii(0x1011_1423, 2); jmpd(0x1011_142c, 0x7); goto l_0x1011_142c; /* jmp 0x1011142c */
        l_0x1011_1425:
            ii(0x1011_1425, 7); mov(memb_a32[ss, ebp - 0x164], 0);      /* mov byte [ebp-0x164], 0x0 */
        l_0x1011_142c:
            ii(0x1011_142c, 6); mov(eax, memd_a32[ss, ebp - 0x154]);    /* mov eax, [ebp-0x154] */
            ii(0x1011_1432, 6); mov(memd_a32[ss, ebp - 0x168], eax);    /* mov [ebp-0x168], eax */
            ii(0x1011_1438, 5); jmpd(0x1011_1570, 0x133); goto l_0x1011_1570; /* jmp 0x10111570 */
        l_0x1011_143d:
            ii(0x1011_143d, 6); lea(eax, ebp - 0x160);                  /* lea eax, [ebp-0x160] */
            ii(0x1011_1443, 5); calld(0x1011_0efc, -0x54c);             /* call 0x10110efc */
            ii(0x1011_1448, 5); jmpd(0x1011_15d7, 0x18a); goto l_0x1011_15d7; /* jmp 0x101115d7 */
        l_0x1011_144d:
            ii(0x1011_144d, 10); mov(memd_a32[ss, ebp - 0x154], 0xc);   /* mov dword [ebp-0x154], 0xc */
            ii(0x1011_1457, 6); lea(eax, ebp - 0x160);                  /* lea eax, [ebp-0x160] */
            ii(0x1011_145d, 5); calld(0x1011_1035, -0x42d);             /* call 0x10111035 */
            ii(0x1011_1462, 5); jmpd(0x1011_15d7, 0x170); goto l_0x1011_15d7; /* jmp 0x101115d7 */
        l_0x1011_1467:
            ii(0x1011_1467, 10); mov(memd_a32[ss, ebp - 0x154], 0xd);   /* mov dword [ebp-0x154], 0xd */
            ii(0x1011_1471, 6); lea(eax, ebp - 0x160);                  /* lea eax, [ebp-0x160] */
            ii(0x1011_1477, 5); calld(0x1011_1035, -0x447);             /* call 0x10111035 */
            ii(0x1011_147c, 5); jmpd(0x1011_15d7, 0x156); goto l_0x1011_15d7; /* jmp 0x101115d7 */
        l_0x1011_1481:
            ii(0x1011_1481, 10); mov(memd_a32[ss, ebp - 0x16c], 0);     /* mov dword [ebp-0x16c], 0x0 */
            ii(0x1011_148b, 2); jmpd(0x1011_1499, 0xc); goto l_0x1011_1499; /* jmp 0x10111499 */
        l_0x1011_148d:
            ii(0x1011_148d, 6); mov(eax, memd_a32[ss, ebp - 0x16c]);    /* mov eax, [ebp-0x16c] */
            ii(0x1011_1493, 6); inc(memd_a32[ss, ebp - 0x16c]);         /* inc dword [ebp-0x16c] */
        l_0x1011_1499:
            ii(0x1011_1499, 7); movsx(eax, memw_a32[ss, ebp - 0x16c]);  /* movsx eax, word [ebp-0x16c] */
            ii(0x1011_14a0, 3); cmp(eax, 0x13);                         /* cmp eax, 0x13 */
            ii(0x1011_14a3, 6); if(jged(0x1011_156e, 0xc5)) goto l_0x1011_156e; /* jge 0x1011156e */
            ii(0x1011_14a9, 7); movsx(eax, memw_a32[ss, ebp - 0x16c]);  /* movsx eax, word [ebp-0x16c] */
            ii(0x1011_14b0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_14b3, 8); cmp(memd_a32[ds, eax + ebp - 0x150], 0); /* cmp dword [eax+ebp-0x150], 0x0 */
            ii(0x1011_14bb, 6); if(jzd(0x1011_1569, 0xa8)) goto l_0x1011_1569; /* jz 0x10111569 */
            ii(0x1011_14c1, 7); movsx(eax, memw_a32[ss, ebp - 0x16c]);  /* movsx eax, word [ebp-0x16c] */
            ii(0x1011_14c8, 5); add(eax, 0x7000);                       /* add eax, 0x7000 */
            ii(0x1011_14cd, 6); cmp(eax, memd_a32[ss, ebp - 0x154]);    /* cmp eax, [ebp-0x154] */
            ii(0x1011_14d3, 2); if(jnzd(0x1011_14fd, 0x28)) goto l_0x1011_14fd; /* jnz 0x101114fd */
            ii(0x1011_14d5, 7); cmp(memb_a32[ss, ebp - 0x164], 0);      /* cmp byte [ebp-0x164], 0x0 */
            ii(0x1011_14dc, 2); if(jnzd(0x1011_14f4, 0x16)) goto l_0x1011_14f4; /* jnz 0x101114f4 */
            ii(0x1011_14de, 7); movsx(eax, memw_a32[ss, ebp - 0x16c]);  /* movsx eax, word [ebp-0x16c] */
            ii(0x1011_14e5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_14e8, 7); mov(eax, memd_a32[ds, eax + ebp - 0x150]); /* mov eax, [eax+ebp-0x150] */
            ii(0x1011_14ef, 5); calld(0x100c_fbbe, -0x4_1936);          /* call 0x100cfbbe */
        l_0x1011_14f4:
            ii(0x1011_14f4, 7); mov(memb_a32[ss, ebp - 0x164], 0x1);    /* mov byte [ebp-0x164], 0x1 */
            ii(0x1011_14fb, 2); jmpd(0x1011_156e, 0x71); goto l_0x1011_156e; /* jmp 0x1011156e */
        l_0x1011_14fd:
            ii(0x1011_14fd, 7); movsx(edx, memw_a32[ss, ebp - 0x16c]);  /* movsx edx, word [ebp-0x16c] */
            ii(0x1011_1504, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1011_1507, 6); mov(eax, memd_a32[ss, ebp - 0x154]);    /* mov eax, [ebp-0x154] */
            ii(0x1011_150d, 7); cmp(eax, memd_a32[ds, edx + ebp - 0x100]); /* cmp eax, [edx+ebp-0x100] */
            ii(0x1011_1514, 2); if(jnzd(0x1011_152d, 0x17)) goto l_0x1011_152d; /* jnz 0x1011152d */
            ii(0x1011_1516, 7); movsx(eax, memw_a32[ss, ebp - 0x16c]);  /* movsx eax, word [ebp-0x16c] */
            ii(0x1011_151d, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1011_1520, 7); mov(eax, memd_a32[ds, eax + ebp - 0x104]); /* mov eax, [eax+ebp-0x104] */
            ii(0x1011_1527, 6); mov(memd_a32[ss, ebp - 0x154], eax);    /* mov [ebp-0x154], eax */
        l_0x1011_152d:
            ii(0x1011_152d, 7); movsx(edx, memw_a32[ss, ebp - 0x16c]);  /* movsx edx, word [ebp-0x16c] */
            ii(0x1011_1534, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1011_1537, 6); mov(eax, memd_a32[ss, ebp - 0x154]);    /* mov eax, [ebp-0x154] */
            ii(0x1011_153d, 7); cmp(eax, memd_a32[ds, edx + ebp - 0x104]); /* cmp eax, [edx+ebp-0x104] */
            ii(0x1011_1544, 2); if(jnzd(0x1011_1569, 0x23)) goto l_0x1011_1569; /* jnz 0x10111569 */
            ii(0x1011_1546, 10); add(memd_a32[ss, ebp - 0x154], 0xffff_fc18); /* add dword [ebp-0x154], 0xfffffc18 */
            ii(0x1011_1550, 7); movsx(edx, memw_a32[ss, ebp - 0x16c]);  /* movsx edx, word [ebp-0x16c] */
            ii(0x1011_1557, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1011_155a, 6); lea(eax, ebp - 0x160);                  /* lea eax, [ebp-0x160] */
            ii(0x1011_1560, 7); calld_abs(memd_a32[ds, edx + ebp - 0xfc]); /* call dword [edx+ebp-0xfc] */
            ii(0x1011_1567, 2); jmpd(0x1011_156e, 0x5); goto l_0x1011_156e; /* jmp 0x1011156e */
        l_0x1011_1569:
            ii(0x1011_1569, 5); jmpd(0x1011_148d, -0xe1); goto l_0x1011_148d; /* jmp 0x1011148d */
        l_0x1011_156e:
            ii(0x1011_156e, 2); jmpd(0x1011_15d7, 0x67); goto l_0x1011_15d7; /* jmp 0x101115d7 */
        l_0x1011_1570:
            ii(0x1011_1570, 10); cmp(memd_a32[ss, ebp - 0x168], 0x149); /* cmp dword [ebp-0x168], 0x149 */
            ii(0x1011_157a, 2); if(jbd(0x1011_15c2, 0x46)) goto l_0x1011_15c2; /* jb 0x101115c2 */
            ii(0x1011_157c, 10); cmp(memd_a32[ss, ebp - 0x168], 0x149); /* cmp dword [ebp-0x168], 0x149 */
            ii(0x1011_1586, 6); if(jbed(0x1011_144d, -0x13f)) goto l_0x1011_144d; /* jbe 0x1011144d */
            ii(0x1011_158c, 10); cmp(memd_a32[ss, ebp - 0x168], 0x150); /* cmp dword [ebp-0x168], 0x150 */
            ii(0x1011_1596, 2); if(jbd(0x1011_15bd, 0x25)) goto l_0x1011_15bd; /* jb 0x101115bd */
            ii(0x1011_1598, 10); cmp(memd_a32[ss, ebp - 0x168], 0x150); /* cmp dword [ebp-0x168], 0x150 */
            ii(0x1011_15a2, 6); if(jbed(0x1011_143d, -0x16b)) goto l_0x1011_143d; /* jbe 0x1011143d */
            ii(0x1011_15a8, 10); cmp(memd_a32[ss, ebp - 0x168], 0x151); /* cmp dword [ebp-0x168], 0x151 */
            ii(0x1011_15b2, 6); if(jzd(0x1011_1467, -0x151)) goto l_0x1011_1467; /* jz 0x10111467 */
            ii(0x1011_15b8, 5); jmpd(0x1011_1481, -0x13c); goto l_0x1011_1481; /* jmp 0x10111481 */
        l_0x1011_15bd:
            ii(0x1011_15bd, 5); jmpd(0x1011_1481, -0x141); goto l_0x1011_1481; /* jmp 0x10111481 */
        l_0x1011_15c2:
            ii(0x1011_15c2, 10); cmp(memd_a32[ss, ebp - 0x168], 0x148); /* cmp dword [ebp-0x168], 0x148 */
            ii(0x1011_15cc, 6); if(jzd(0x1011_143d, -0x195)) goto l_0x1011_143d; /* jz 0x1011143d */
            ii(0x1011_15d2, 5); jmpd(0x1011_1481, -0x156); goto l_0x1011_1481; /* jmp 0x10111481 */
        l_0x1011_15d7:
            ii(0x1011_15d7, 7); cmp(memd_a32[ss, ebp - 0x15c], 0);      /* cmp dword [ebp-0x15c], 0x0 */
            ii(0x1011_15de, 2); if(jnzd(0x1011_15e9, 0x9)) goto l_0x1011_15e9; /* jnz 0x101115e9 */
            ii(0x1011_15e0, 7); cmp(memd_a32[ss, ebp - 0x158], 0);      /* cmp dword [ebp-0x158], 0x0 */
            ii(0x1011_15e7, 2); if(jzd(0x1011_15eb, 0x2)) goto l_0x1011_15eb; /* jz 0x101115eb */
        l_0x1011_15e9:
            ii(0x1011_15e9, 2); jmpd(0x1011_15f0, 0x5); goto l_0x1011_15f0; /* jmp 0x101115f0 */
        l_0x1011_15eb:
            ii(0x1011_15eb, 5); jmpd(0x1011_13f5, -0x1fb); goto l_0x1011_13f5; /* jmp 0x101113f5 */
        l_0x1011_15f0:
            ii(0x1011_15f0, 6); lea(eax, ebp - 0x160);                  /* lea eax, [ebp-0x160] */
            ii(0x1011_15f6, 5); calld(0x1011_12b5, -0x346);             /* call 0x101112b5 */
            ii(0x1011_15fb, 7); cmp(memd_a32[ss, ebp - 0x158], 0);      /* cmp dword [ebp-0x158], 0x0 */
            ii(0x1011_1602, 6); if(jnzd(0x1011_172e, 0x126)) goto l_0x1011_172e; /* jnz 0x1011172e */
            ii(0x1011_1608, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_160a, 3); mov(al, memb_a32[ss, ebp - 0x1e]);      /* mov al, [ebp-0x1e] */
            ii(0x1011_160d, 6); mov(memw_a32[ds, 0x101c_3982], ax);     /* mov [0x101c3982], ax */
            ii(0x1011_1613, 6); mov(edx, memd_a32[ds, 0x101c_3980]);    /* mov edx, [0x101c3980] */
            ii(0x1011_1619, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_161c, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x1011_1621, 5); calld(0x100c_aafc, -0x4_6b2a);          /* call 0x100caafc */
            ii(0x1011_1626, 4); movsx(edx, memb_a32[ss, ebp - 0x1d]);   /* movsx edx, byte [ebp-0x1d] */
            ii(0x1011_162a, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_162f, 5); calld(0x100c_aafc, -0x4_6b38);          /* call 0x100caafc */
            ii(0x1011_1634, 4); cmp(memb_a32[ss, ebp - 0x1d], 0x9);     /* cmp byte [ebp-0x1d], 0x9 */
            ii(0x1011_1638, 2); if(jnzd(0x1011_1640, 0x6)) goto l_0x1011_1640; /* jnz 0x10111640 */
            ii(0x1011_163a, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1011_163e, 2); if(jzd(0x1011_1642, 0x2)) goto l_0x1011_1642; /* jz 0x10111642 */
        l_0x1011_1640:
            ii(0x1011_1640, 2); jmpd(0x1011_1651, 0xf); goto l_0x1011_1651; /* jmp 0x10111651 */
        l_0x1011_1642:
            ii(0x1011_1642, 10); mov(memd_a32[ss, ebp - 0x170], 0x1);   /* mov dword [ebp-0x170], 0x1 */
            ii(0x1011_164c, 5); jmpd(0x1011_1738, 0xe7); goto l_0x1011_1738; /* jmp 0x10111738 */
        l_0x1011_1651:
            ii(0x1011_1651, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1011_1656, 5); calld(0x1010_bf06, -0x5755);            /* call 0x1010bf06 */
            ii(0x1011_165b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_165d, 6); if(jzd(0x1011_1725, 0xc2)) goto l_0x1011_1725; /* jz 0x10111725 */
            ii(0x1011_1663, 4); cmp(memb_a32[ss, ebp - 0x1d], 0x2);     /* cmp byte [ebp-0x1d], 0x2 */
            ii(0x1011_1667, 2); if(jnzd(0x1011_166e, 0x5)) goto l_0x1011_166e; /* jnz 0x1011166e */
            ii(0x1011_1669, 5); calld(0x100e_e4ca, -0x2_31a4);          /* call 0x100ee4ca */
        l_0x1011_166e:
            ii(0x1011_166e, 5); mov(eax, memd_a32[ds, 0x101c_3980]);    /* mov eax, [0x101c3980] */
            ii(0x1011_1673, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_1676, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_1679, 2); if(jnzd(0x1011_1681, 0x6)) goto l_0x1011_1681; /* jnz 0x10111681 */
            ii(0x1011_167b, 4); cmp(memb_a32[ss, ebp - 0x1d], 0x2);     /* cmp byte [ebp-0x1d], 0x2 */
            ii(0x1011_167f, 2); if(jzd(0x1011_1683, 0x2)) goto l_0x1011_1683; /* jz 0x10111683 */
        l_0x1011_1681:
            ii(0x1011_1681, 2); jmpd(0x1011_168d, 0xa); goto l_0x1011_168d; /* jmp 0x1011168d */
        l_0x1011_1683:
            ii(0x1011_1683, 5); mov(eax, 0x6b6);                        /* mov eax, 0x6b6 */
            ii(0x1011_1688, 5); calld(0x1011_584c, 0x41bf);             /* call 0x1011584c */
        l_0x1011_168d:
            ii(0x1011_168d, 4); cmp(memb_a32[ss, ebp - 0x1d], 0x9);     /* cmp byte [ebp-0x1d], 0x9 */
            ii(0x1011_1691, 6); if(jnzd(0x1011_1715, 0x7e)) goto l_0x1011_1715; /* jnz 0x10111715 */
            ii(0x1011_1697, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_1699, 6); lea(ebx, ebp - 0x220);                  /* lea ebx, [ebp-0x220] */
            ii(0x1011_169f, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_16a4, 5); calld(0x1007_5fdc, -0x9_b6cd);          /* call 0x10075fdc */
            ii(0x1011_16a9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_16ac, 5); mov(eax, memd_a32[ds, 0x101c_3980]);    /* mov eax, [0x101c3980] */
            ii(0x1011_16b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_16b4, 5); calld(0x1013_9ade, 0x2_8425);           /* call 0x10139ade */
            ii(0x1011_16b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_16bb, 6); mov(dl, memb_a32[ss, ebp - 0x17f]);     /* mov dl, [ebp-0x17f] */
            ii(0x1011_16c1, 5); mov(eax, 0x6b);                         /* mov eax, 0x6b */
            ii(0x1011_16c6, 5); calld(0x100c_aafc, -0x4_6bcf);          /* call 0x100caafc */
            ii(0x1011_16cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_16cd, 6); mov(dl, memb_a32[ss, ebp - 0x17e]);     /* mov dl, [ebp-0x17e] */
            ii(0x1011_16d3, 5); mov(eax, 0x6c);                         /* mov eax, 0x6c */
            ii(0x1011_16d8, 5); calld(0x100c_aafc, -0x4_6be1);          /* call 0x100caafc */
            ii(0x1011_16dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_16df, 6); mov(dl, memb_a32[ss, ebp - 0x17d]);     /* mov dl, [ebp-0x17d] */
            ii(0x1011_16e5, 5); mov(eax, 0x6d);                         /* mov eax, 0x6d */
            ii(0x1011_16ea, 5); calld(0x100c_aafc, -0x4_6bf3);          /* call 0x100caafc */
            ii(0x1011_16ef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_16f1, 6); mov(dl, memb_a32[ss, ebp - 0x17c]);     /* mov dl, [ebp-0x17c] */
            ii(0x1011_16f7, 5); mov(eax, 0x6e);                         /* mov eax, 0x6e */
            ii(0x1011_16fc, 5); calld(0x100c_aafc, -0x4_6c05);          /* call 0x100caafc */
            ii(0x1011_1701, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1703, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_1706, 5); calld(0x1010_e501, -0x320a);            /* call 0x1010e501 */
            ii(0x1011_170b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_170d, 2); if(jnzd(0x1011_1715, 0x6)) goto l_0x1011_1715; /* jnz 0x10111715 */
            ii(0x1011_170f, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_1713, 2); jmpd(0x1011_1729, 0x14); goto l_0x1011_1729; /* jmp 0x10111729 */
        l_0x1011_1715:
            ii(0x1011_1715, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1011_171a, 5); calld(0x100f_f0ba, -0x1_2665);          /* call 0x100ff0ba */
            ii(0x1011_171f, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1011_1723, 2); jmpd(0x1011_1729, 0x4); goto l_0x1011_1729; /* jmp 0x10111729 */
        l_0x1011_1725:
            ii(0x1011_1725, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1011_1729:
            ii(0x1011_1729, 5); jmpd(0x1011_13de, -0x350); goto l_0x1011_13de; /* jmp 0x101113de */
        l_0x1011_172e:
            ii(0x1011_172e, 10); mov(memd_a32[ss, ebp - 0x170], 0);     /* mov dword [ebp-0x170], 0x0 */
        l_0x1011_1738:
            ii(0x1011_1738, 6); mov(eax, memd_a32[ss, ebp - 0x170]);    /* mov eax, [ebp-0x170] */
            ii(0x1011_173e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_1740, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_1741, 1); popd(edi);                              /* pop edi */
            ii(0x1011_1742, 1); popd(esi);                              /* pop esi */
            ii(0x1011_1743, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_1744, 1); retd();                                 /* ret */
        }
    }
}
