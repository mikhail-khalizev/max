using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_13b0-b9cc41dd")]
        public void Method_1012_13b0()
        {
            ii(0x1012_13b0, 5); pushd(0xa0);                            /* push 0xa0 */
            ii(0x1012_13b5, 5); calld(Definitions.sys_check_available_stack_size, 0x4_4998); /* call 0x10165d52 */
            ii(0x1012_13ba, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_13bb, 1); pushd(esi);                             /* push esi */
            ii(0x1012_13bc, 1); pushd(edi);                             /* push edi */
            ii(0x1012_13bd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_13be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_13c0, 6); sub(esp, 0x74);                         /* sub esp, 0x74 */
            ii(0x1012_13c6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_13c9, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_13cc, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_13cf, 6); cmp(memw_a32[ss, ebp - 0x4], 0x6c1);    /* cmp word [ebp-0x4], 0x6c1 */
            ii(0x1012_13d5, 2); if(jnzd(0x1012_13dd, 0x6)) goto l_0x1012_13dd; /* jnz 0x101213dd */
            ii(0x1012_13d7, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1012_13db, 2); jmpd(0x1012_13e1, 0x4); goto l_0x1012_13e1; /* jmp 0x101213e1 */
        l_0x1012_13dd:
            ii(0x1012_13dd, 4); mov(memb_a32[ss, ebp - 0x10], 0x26);    /* mov byte [ebp-0x10], 0x26 */
        l_0x1012_13e1:
            ii(0x1012_13e1, 3); mov(ebx, memd_a32[ss, ebp - 0x13]);     /* mov ebx, [ebp-0x13] */
            ii(0x1012_13e4, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1012_13e7, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_13eb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_13ee, 5); calld(0x100d_68a3, -0x4_ab50);          /* call 0x100d68a3 */
            ii(0x1012_13f3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_13f6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_13f9, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_13fc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_13ff, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_6aac); /* mov dword [eax+0x13], 0x101b6aac */
            ii(0x1012_1406, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_140b, 5); calld(0x1012_0d94, -0x67c);             /* call 0x10120d94 */
            ii(0x1012_1410, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_1415, 5); calld(/* sys */ 0x1016_a24c, 0x4_8e32); /* call 0x1016a24c */
            ii(0x1012_141a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_141d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_1420, 4); mov(memw_a32[ds, edx + 0x3e], ax);      /* mov [edx+0x3e], ax */
            ii(0x1012_1424, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_1427, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_142a, 4); mov(memw_a32[ds, edx + 0x40], ax);      /* mov [edx+0x40], ax */
            ii(0x1012_142e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_1431, 7); mov(memd_a32[ds, eax + 0x42], 0);       /* mov dword [eax+0x42], 0x0 */
            ii(0x1012_1438, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_143b, 4); mov(memb_a32[ds, eax + 0x48], 0);       /* mov byte [eax+0x48], 0x0 */
            ii(0x1012_143f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_1442, 6); mov(memw_a32[ds, eax + 0x49], 0x21);    /* mov word [eax+0x49], 0x21 */
            ii(0x1012_1448, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_144a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_144d, 5); calld(0x100d_6adf, -0x4_a973);          /* call 0x100d6adf */
            ii(0x1012_1452, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_1455, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_1458, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_145b, 5); calld(0x100d_6a11, -0x4_aa4f);          /* call 0x100d6a11 */
            ii(0x1012_1460, 6); cmp(memw_a32[ss, ebp - 0x4], 0x6c1);    /* cmp word [ebp-0x4], 0x6c1 */
            ii(0x1012_1466, 2); if(jnzd(0x1012_1471, 0x9)) goto l_0x1012_1471; /* jnz 0x10121471 */
            ii(0x1012_1468, 7); mov(memd_a32[ss, ebp - 0x1c], 0x8d);    /* mov dword [ebp-0x1c], 0x8d */
            ii(0x1012_146f, 2); jmpd(0x1012_1478, 0x7); goto l_0x1012_1478; /* jmp 0x10121478 */
        l_0x1012_1471:
            ii(0x1012_1471, 7); mov(memd_a32[ss, ebp - 0x1c], 0x17f);   /* mov dword [ebp-0x1c], 0x17f */
        l_0x1012_1478:
            ii(0x1012_1478, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1012_147b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_147e, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_1483, 5); calld(Definitions.sys_new, 0x4_4978);   /* call 0x10165e00 */
            ii(0x1012_1488, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1012_148b, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1012_148e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1012_1491, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1012_1495, 2); if(jzd(0x1012_14be, 0x27)) goto l_0x1012_14be; /* jz 0x101214be */
            ii(0x1012_1497, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1012_149b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_149c, 5); mov(ecx, 0x7d);                         /* mov ecx, 0x7d */
            ii(0x1012_14a1, 5); mov(ebx, 0x17b);                        /* mov ebx, 0x17b */
            ii(0x1012_14a6, 5); mov(edx, 0x17a);                        /* mov edx, 0x17a */
            ii(0x1012_14ab, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1012_14ae, 5); calld(Definitions.my_ctor_c17, -0x5_30a4); /* call 0x100ce40f */
            ii(0x1012_14b3, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1012_14b6, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1012_14b9, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1012_14bc, 2); jmpd(0x1012_14c4, 0x6); goto l_0x1012_14c4; /* jmp 0x101214c4 */
        l_0x1012_14be:
            ii(0x1012_14be, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1012_14c1, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x1012_14c4:
            ii(0x1012_14c4, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1012_14c7, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_14ca, 3); mov(memd_a32[ds, edx + 0x32], eax);     /* mov [edx+0x32], eax */
            ii(0x1012_14cd, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_14d2, 5); calld(Definitions.sys_new, 0x4_4929);   /* call 0x10165e00 */
            ii(0x1012_14d7, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1012_14da, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1012_14dd, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1012_14e0, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1012_14e4, 2); if(jzd(0x1012_150d, 0x27)) goto l_0x1012_150d; /* jz 0x1012150d */
            ii(0x1012_14e6, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1012_14ea, 1); pushd(eax);                             /* push eax */
            ii(0x1012_14eb, 5); mov(ecx, 0xd7);                         /* mov ecx, 0xd7 */
            ii(0x1012_14f0, 5); mov(ebx, 0x17f);                        /* mov ebx, 0x17f */
            ii(0x1012_14f5, 5); mov(edx, 0x17e);                        /* mov edx, 0x17e */
            ii(0x1012_14fa, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1012_14fd, 5); calld(Definitions.my_ctor_c17, -0x5_30f3); /* call 0x100ce40f */
            ii(0x1012_1502, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1012_1505, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1012_1508, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1012_150b, 2); jmpd(0x1012_1513, 0x6); goto l_0x1012_1513; /* jmp 0x10121513 */
        l_0x1012_150d:
            ii(0x1012_150d, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1012_1510, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x1012_1513:
            ii(0x1012_1513, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1012_1516, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_1519, 3); mov(memd_a32[ds, edx + 0x36], eax);     /* mov [edx+0x36], eax */
            ii(0x1012_151c, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_1521, 5); calld(Definitions.sys_new, 0x4_48da);   /* call 0x10165e00 */
            ii(0x1012_1526, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1012_1529, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1012_152c, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_152f, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1012_1533, 2); if(jzd(0x1012_155c, 0x27)) goto l_0x1012_155c; /* jz 0x1012155c */
            ii(0x1012_1535, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1012_1539, 1); pushd(eax);                             /* push eax */
            ii(0x1012_153a, 5); mov(ecx, 0xbc);                         /* mov ecx, 0xbc */
            ii(0x1012_153f, 5); mov(ebx, 0x17d);                        /* mov ebx, 0x17d */
            ii(0x1012_1544, 5); mov(edx, 0x17c);                        /* mov edx, 0x17c */
            ii(0x1012_1549, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1012_154c, 5); calld(Definitions.my_ctor_c17, -0x5_3142); /* call 0x100ce40f */
            ii(0x1012_1551, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1012_1554, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1012_1557, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1012_155a, 2); jmpd(0x1012_1562, 0x6); goto l_0x1012_1562; /* jmp 0x10121562 */
        l_0x1012_155c:
            ii(0x1012_155c, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1012_155f, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
        l_0x1012_1562:
            ii(0x1012_1562, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1012_1565, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_1568, 3); mov(memd_a32[ds, edx + 0x3a], eax);     /* mov [edx+0x3a], eax */
            ii(0x1012_156b, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1012_156e, 5); calld(0x100d_5224, -0x4_c34f);          /* call 0x100d5224 */
            ii(0x1012_1573, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1574, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1012_1577, 5); calld(0x100d_5250, -0x4_c32c);          /* call 0x100d5250 */
            ii(0x1012_157c, 1); pushd(eax);                             /* push eax */
            ii(0x1012_157d, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1012_1580, 5); calld(0x100d_527c, -0x4_c309);          /* call 0x100d527c */
            ii(0x1012_1585, 1); pushd(eax);                             /* push eax */
            ii(0x1012_1586, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1012_1589, 5); calld(0x100d_52a8, -0x4_c2e6);          /* call 0x100d52a8 */
            ii(0x1012_158e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_158f, 5); calld(0x100d_52d4, -0x4_c2c0);          /* call 0x100d52d4 */
            ii(0x1012_1594, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_1597, 5); calld(0x100d_52f8, -0x4_c2a4);          /* call 0x100d52f8 */
            ii(0x1012_159c, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_159f, 5); mov(edx, StringDefinitions.Done);       /* mov edx, 0x101a7e90 */
            ii(0x1012_15a4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_15a7, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x1012_15aa, 5); calld(0x100c_ef64, -0x5_264b);          /* call 0x100cef64 */
            ii(0x1012_15af, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1012_15b2, 5); calld(0x100d_5224, -0x4_c393);          /* call 0x100d5224 */
            ii(0x1012_15b7, 1); pushd(eax);                             /* push eax */
            ii(0x1012_15b8, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1012_15bb, 5); calld(0x100d_5250, -0x4_c370);          /* call 0x100d5250 */
            ii(0x1012_15c0, 1); pushd(eax);                             /* push eax */
            ii(0x1012_15c1, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x1012_15c4, 5); calld(0x100d_527c, -0x4_c34d);          /* call 0x100d527c */
            ii(0x1012_15c9, 1); pushd(eax);                             /* push eax */
            ii(0x1012_15ca, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1012_15cd, 5); calld(0x100d_52a8, -0x4_c32a);          /* call 0x100d52a8 */
            ii(0x1012_15d2, 1); pushd(eax);                             /* push eax */
            ii(0x1012_15d3, 5); calld(0x100d_52d4, -0x4_c304);          /* call 0x100d52d4 */
            ii(0x1012_15d8, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_15db, 5); calld(0x100d_52f8, -0x4_c2e8);          /* call 0x100d52f8 */
            ii(0x1012_15e0, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_15e3, 5); mov(edx, StringDefinitions.Cancel);     /* mov edx, 0x101a7e95 */
            ii(0x1012_15e8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_15eb, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1012_15ee, 5); calld(0x100c_ef64, -0x5_268f);          /* call 0x100cef64 */
            ii(0x1012_15f3, 5); mov(edx, 0x3e9);                        /* mov edx, 0x3e9 */
            ii(0x1012_15f8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_15fb, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1012_15fe, 5); calld(0x100d_5134, -0x4_c4cf);          /* call 0x100d5134 */
            ii(0x1012_1603, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x1012_1608, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_160b, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x1012_160e, 5); calld(0x100d_5134, -0x4_c4df);          /* call 0x100d5134 */
            ii(0x1012_1613, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1012_1618, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_161b, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_161e, 5); calld(0x100d_5134, -0x4_c4ef);          /* call 0x100d5134 */
            ii(0x1012_1623, 5); mov(edx, 0x73e9);                       /* mov edx, 0x73e9 */
            ii(0x1012_1628, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_162b, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1012_162e, 5); calld(0x100d_5164, -0x4_c4cf);          /* call 0x100d5164 */
            ii(0x1012_1633, 5); mov(edx, 0x73e8);                       /* mov edx, 0x73e8 */
            ii(0x1012_1638, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_163b, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x1012_163e, 5); calld(0x100d_5164, -0x4_c4df);          /* call 0x100d5164 */
            ii(0x1012_1643, 5); mov(edx, 0x703f);                       /* mov edx, 0x703f */
            ii(0x1012_1648, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_164b, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_164e, 5); calld(0x100d_5164, -0x4_c4ef);          /* call 0x100d5164 */
            ii(0x1012_1653, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x1012_1658, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_165b, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1012_165e, 5); calld(0x100d_50d4, -0x4_c58f);          /* call 0x100d50d4 */
            ii(0x1012_1663, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x1012_1668, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_166b, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x1012_166e, 5); calld(0x100d_50d4, -0x4_c59f);          /* call 0x100d50d4 */
            ii(0x1012_1673, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_1678, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_167b, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_167e, 5); calld(0x100d_50d4, -0x4_c5af);          /* call 0x100d50d4 */
            ii(0x1012_1683, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_1686, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x1012_1689, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_168c, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1012_168f, 5); calld(0x100c_f85c, -0x5_1e38);          /* call 0x100cf85c */
            ii(0x1012_1694, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_1697, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x1012_169a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_169d, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x1012_16a0, 5); calld(0x100c_f85c, -0x5_1e49);          /* call 0x100cf85c */
            ii(0x1012_16a5, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_16a8, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x1012_16ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_16ae, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_16b1, 5); calld(0x100c_f85c, -0x5_1e5a);          /* call 0x100cf85c */
            ii(0x1012_16b6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_16b9, 6); cmp(memw_a32[ds, eax + 0x40], 0x6cd);   /* cmp word [eax+0x40], 0x6cd */
            ii(0x1012_16bf, 2); if(jnzd(0x1012_16ff, 0x3e)) goto l_0x1012_16ff; /* jnz 0x101216ff */
            ii(0x1012_16c1, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_16c6, 1); pushd(eax);                             /* push eax */
            ii(0x1012_16c7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_16cc, 1); pushd(eax);                             /* push eax */
            ii(0x1012_16cd, 2); pushd(0x2);                             /* push 0x2 */
            ii(0x1012_16cf, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1012_16d4, 1); pushd(eax);                             /* push eax */
            ii(0x1012_16d5, 5); mov(eax, 0xb8);                         /* mov eax, 0xb8 */
            ii(0x1012_16da, 1); pushd(eax);                             /* push eax */
            ii(0x1012_16db, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1012_16e0, 1); pushd(eax);                             /* push eax */
            ii(0x1012_16e1, 5); mov(ecx, 0x6c);                         /* mov ecx, 0x6c */
            ii(0x1012_16e6, 5); mov(ebx, StringDefinitions.Preferences); /* mov ebx, 0x101a7e9c */
            ii(0x1012_16eb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_16ee, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x1012_16f1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_16f4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_16f7, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1012_16fa, 5); calld(0x100e_9ae5, -0x3_7c1a);          /* call 0x100e9ae5 */
        l_0x1012_16ff:
            ii(0x1012_16ff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_1702, 5); calld(0x1012_227f, 0xb78);              /* call 0x1012227f */
            ii(0x1012_1707, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_170a, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_170d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_1710, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1012_1713, 5); calld(Definitions.sys_display_draw_1, 0x4_5d90); /* call 0x101674a8 */
            ii(0x1012_1718, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1012_171f, 2); jmpd(0x1012_1727, 0x6); goto l_0x1012_1727; /* jmp 0x10121727 */
        l_0x1012_1721:
            ii(0x1012_1721, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1012_1724, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1012_1727:
            ii(0x1012_1727, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1012_172a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_172d, 4); cmp(ax, memw_a32[ds, edx + 0x49]);      /* cmp ax, [edx+0x49] */
            ii(0x1012_1731, 2); if(jged(0x1012_1781, 0x4e)) goto l_0x1012_1781; /* jge 0x10121781 */
            ii(0x1012_1733, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_1737, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_173a, 7); cmp(memb_a32[ds, eax + 0x101b_b061], 0x40); /* cmp byte [eax+0x101bb061], 0x40 */
            ii(0x1012_1741, 2); if(jnzd(0x1012_174e, 0xb)) goto l_0x1012_174e; /* jnz 0x1012174e */
            ii(0x1012_1743, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_1746, 6); cmp(memw_a32[ds, eax + 0x40], 0x6c1);   /* cmp word [eax+0x40], 0x6c1 */
            ii(0x1012_174c, 2); if(jnzd(0x1012_177f, 0x31)) goto l_0x1012_177f; /* jnz 0x1012177f */
        l_0x1012_174e:
            ii(0x1012_174e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_1752, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1755, 7); cmp(memb_a32[ds, eax + 0x101b_b05c], 0x5); /* cmp byte [eax+0x101bb05c], 0x5 */
            ii(0x1012_175c, 2); if(jnzd(0x1012_177f, 0x21)) goto l_0x1012_177f; /* jnz 0x1012177f */
            ii(0x1012_175e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_1762, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1765, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_1767, 6); mov(dl, memb_a32[ds, eax + 0x101b_b074]); /* mov dl, [eax+0x101bb074] */
            ii(0x1012_176d, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_1771, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1774, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_177a, 5); calld(0x100c_fb73, -0x5_1c0c);          /* call 0x100cfb73 */
        l_0x1012_177f:
            ii(0x1012_177f, 2); jmpd(0x1012_1721, -0x60); goto l_0x1012_1721; /* jmp 0x10121721 */
        l_0x1012_1781:
            ii(0x1012_1781, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_1784, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x1012_1787, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x1012_178a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_178c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_178d, 1); popd(edi);                              /* pop edi */
            ii(0x1012_178e, 1); popd(esi);                              /* pop esi */
            ii(0x1012_178f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_1790, 1); retd();                                 /* ret */
        }
    }
}
