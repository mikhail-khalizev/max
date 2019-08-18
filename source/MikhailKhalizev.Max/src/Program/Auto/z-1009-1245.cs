using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1343634e-d2b0-49ab-8549-436aaf766fcf")]
        public void Method_1009_1245()
        {
            ii(0x1009_1245, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1009_124a, 5); calld(Definitions.sys_check_available_stack_size, 0xd_4b03); /* call 0x10165d52 */
            ii(0x1009_124f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_1250, 1); pushd(esi);                             /* push esi */
            ii(0x1009_1251, 1); pushd(edi);                             /* push edi */
            ii(0x1009_1252, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_1253, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_1255, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1009_125b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_125e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_1261, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_1264, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_1269, 5); calld(0x1007_6338, -0x1_af36);          /* call 0x10076338 */
            ii(0x1009_126e, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_1271, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_1273, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_1275, 5); calld(0x1007_64b8, -0x1_adc2);          /* call 0x100764b8 */
            ii(0x1009_127a, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1009_127f, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1009_1284, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x1009_1289, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_128c, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_128f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1292, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_1298, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1009_129d, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1009_129f, 5); calld(0x100c_204f, 0x3_0dab);           /* call 0x100c204f */
            ii(0x1009_12a4, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_12a7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_12aa, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_12ad, 5); calld(0x1009_c6c8, 0xb416);             /* call 0x1009c6c8 */
            ii(0x1009_12b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_12b4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_12b7, 5); calld(0x1009_c5dc, 0xb320);             /* call 0x1009c5dc */
            ii(0x1009_12bc, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1009_12c0, 6); if(jzd(0x1009_1336, 0x70)) goto l_0x1009_1336; /* jz 0x10091336 */
            ii(0x1009_12c6, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_12cd, 2); jmpd(0x1009_12d5, 0x6); goto l_0x1009_12d5; /* jmp 0x100912d5 */
        l_0x1009_12cf:
            ii(0x1009_12cf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_12d2, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1009_12d5:
            ii(0x1009_12d5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_12d8, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1009_12df, 2); if(jged(0x1009_1336, 0x55)) goto l_0x1009_1336; /* jge 0x10091336 */
            ii(0x1009_12e1, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_12e4, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_12e6, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_12e9, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1009_12f0, 2); jmpd(0x1009_12f8, 0x6); goto l_0x1009_12f8; /* jmp 0x100912f8 */
        l_0x1009_12f2:
            ii(0x1009_12f2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_12f5, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1009_12f8:
            ii(0x1009_12f8, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_12fb, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_1302, 2); if(jged(0x1009_132d, 0x29)) goto l_0x1009_132d; /* jge 0x1009132d */
            ii(0x1009_1304, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_1307, 4); add(memd_a32[ss, ebp - 0x1c], 0x2);     /* add dword [ebp-0x1c], 0x2 */
            ii(0x1009_130b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_130e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_1310, 2); if(jled(0x1009_132b, 0x19)) goto l_0x1009_132b; /* jle 0x1009132b */
            ii(0x1009_1312, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_1316, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1319, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_131c, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1009_1320, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_1322, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_1324, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1326, 5); mov(memw_a32[ds, eax], 0x7);            /* mov word [eax], 0x7 */
        l_0x1009_132b:
            ii(0x1009_132b, 2); jmpd(0x1009_12f2, -0x3b); goto l_0x1009_12f2; /* jmp 0x100912f2 */
        l_0x1009_132d:
            ii(0x1009_132d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_1330, 4); add(memd_a32[ss, ebp - 0x20], 0x4);     /* add dword [ebp-0x20], 0x4 */
            ii(0x1009_1334, 2); jmpd(0x1009_12cf, -0x67); goto l_0x1009_12cf; /* jmp 0x100912cf */
        l_0x1009_1336:
            ii(0x1009_1336, 5); mov(ebx, 0x38);                         /* mov ebx, 0x38 */
            ii(0x1009_133b, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x1009_1340, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_1343, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_1346, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1349, 5); calld(0x1008_b9c2, -0x598c);            /* call 0x1008b9c2 */
            ii(0x1009_134e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1350, 6); if(jnzd(0x1009_13de, 0x88)) goto l_0x1009_13de; /* jnz 0x100913de */
            ii(0x1009_1356, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1009_135b, 5); calld(0x1007_6338, -0x1_b028);          /* call 0x10076338 */
            ii(0x1009_1360, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_1363, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_1365, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_1367, 5); calld(0x1007_643c, -0x1_af30);          /* call 0x1007643c */
            ii(0x1009_136c, 2); jmpd(0x1009_1376, 0x8); goto l_0x1009_1376; /* jmp 0x10091376 */
        l_0x1009_136e:
            ii(0x1009_136e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1371, 5); calld(0x1007_6bf8, -0x1_a77e);          /* call 0x10076bf8 */
        l_0x1009_1376:
            ii(0x1009_1376, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1378, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_137b, 5); calld(0x1013_ad71, 0xa_99f1);           /* call 0x1013ad71 */
            ii(0x1009_1380, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1382, 2); if(jzd(0x1009_13de, 0x5a)) goto l_0x1009_13de; /* jz 0x100913de */
            ii(0x1009_1384, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1387, 5); calld(0x1007_63a0, -0x1_afec);          /* call 0x100763a0 */
            ii(0x1009_138c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_138e, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1009_1391, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_1394, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_1397, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_139a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_139c, 2); if(jnzd(0x1009_13ad, 0xf)) goto l_0x1009_13ad; /* jnz 0x100913ad */
            ii(0x1009_139e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_13a1, 5); calld(0x1007_63a0, -0x1_b006);          /* call 0x100763a0 */
            ii(0x1009_13a6, 5); cmp(memw_a32[ds, eax + 0x8], 0x29);     /* cmp word [eax+0x8], 0x29 */
            ii(0x1009_13ab, 2); if(jzd(0x1009_13af, 0x2)) goto l_0x1009_13af; /* jz 0x100913af */
        l_0x1009_13ad:
            ii(0x1009_13ad, 2); jmpd(0x1009_13dc, 0x2d); goto l_0x1009_13dc; /* jmp 0x100913dc */
        l_0x1009_13af:
            ii(0x1009_13af, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_13b2, 5); calld(0x1007_63a0, -0x1_b017);          /* call 0x100763a0 */
            ii(0x1009_13b7, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_13ba, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_13bd, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_13c0, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x1009_13c3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_13c6, 5); calld(0x1007_63a0, -0x1_b02b);          /* call 0x100763a0 */
            ii(0x1009_13cb, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_13ce, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_13d1, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_13d3, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_13d5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_13d7, 5); mov(memw_a32[ds, eax], 0x6);            /* mov word [eax], 0x6 */
        l_0x1009_13dc:
            ii(0x1009_13dc, 2); jmpd(0x1009_136e, -0x70); goto l_0x1009_136e; /* jmp 0x1009136e */
        l_0x1009_13de:
            ii(0x1009_13de, 5); mov(ebx, 0x4a);                         /* mov ebx, 0x4a */
            ii(0x1009_13e3, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x1009_13e8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_13eb, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_13ee, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_13f1, 5); calld(0x1008_b9c2, -0x5a34);            /* call 0x1008b9c2 */
            ii(0x1009_13f6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_13f8, 6); if(jnzd(0x1009_1486, 0x88)) goto l_0x1009_1486; /* jnz 0x10091486 */
            ii(0x1009_13fe, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1009_1403, 5); calld(0x1007_6338, -0x1_b0d0);          /* call 0x10076338 */
            ii(0x1009_1408, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_140b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_140d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_140f, 5); calld(0x1007_643c, -0x1_afd8);          /* call 0x1007643c */
            ii(0x1009_1414, 2); jmpd(0x1009_141e, 0x8); goto l_0x1009_141e; /* jmp 0x1009141e */
        l_0x1009_1416:
            ii(0x1009_1416, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1419, 5); calld(0x1007_6bf8, -0x1_a826);          /* call 0x10076bf8 */
        l_0x1009_141e:
            ii(0x1009_141e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1420, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1423, 5); calld(0x1013_ad71, 0xa_9949);           /* call 0x1013ad71 */
            ii(0x1009_1428, 2); test(al, al);                           /* test al, al */
            ii(0x1009_142a, 2); if(jzd(0x1009_1486, 0x5a)) goto l_0x1009_1486; /* jz 0x10091486 */
            ii(0x1009_142c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_142f, 5); calld(0x1007_63a0, -0x1_b094);          /* call 0x100763a0 */
            ii(0x1009_1434, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1436, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1009_1439, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_143c, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_143f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1442, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_1444, 2); if(jnzd(0x1009_1455, 0xf)) goto l_0x1009_1455; /* jnz 0x10091455 */
            ii(0x1009_1446, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1449, 5); calld(0x1007_63a0, -0x1_b0ae);          /* call 0x100763a0 */
            ii(0x1009_144e, 5); cmp(memw_a32[ds, eax + 0x8], 0x2a);     /* cmp word [eax+0x8], 0x2a */
            ii(0x1009_1453, 2); if(jzd(0x1009_1457, 0x2)) goto l_0x1009_1457; /* jz 0x10091457 */
        l_0x1009_1455:
            ii(0x1009_1455, 2); jmpd(0x1009_1484, 0x2d); goto l_0x1009_1484; /* jmp 0x10091484 */
        l_0x1009_1457:
            ii(0x1009_1457, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_145a, 5); calld(0x1007_63a0, -0x1_b0bf);          /* call 0x100763a0 */
            ii(0x1009_145f, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_1462, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_1465, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_1468, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x1009_146b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_146e, 5); calld(0x1007_63a0, -0x1_b0d3);          /* call 0x100763a0 */
            ii(0x1009_1473, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_1476, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1479, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_147b, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_147d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_147f, 5); mov(memw_a32[ds, eax], 0x6);            /* mov word [eax], 0x6 */
        l_0x1009_1484:
            ii(0x1009_1484, 2); jmpd(0x1009_1416, -0x70); goto l_0x1009_1416; /* jmp 0x10091416 */
        l_0x1009_1486:
            ii(0x1009_1486, 5); mov(ebx, 0x3e);                         /* mov ebx, 0x3e */
            ii(0x1009_148b, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x1009_1490, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_1493, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_1496, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1499, 5); calld(0x1008_b9c2, -0x5adc);            /* call 0x1008b9c2 */
            ii(0x1009_149e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_14a0, 6); if(jnzd(0x1009_1527, 0x81)) goto l_0x1009_1527; /* jnz 0x10091527 */
            ii(0x1009_14a6, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1009_14ab, 5); calld(0x1007_6338, -0x1_b178);          /* call 0x10076338 */
            ii(0x1009_14b0, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_14b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_14b5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_14b7, 5); calld(0x1007_643c, -0x1_b080);          /* call 0x1007643c */
            ii(0x1009_14bc, 2); jmpd(0x1009_14c6, 0x8); goto l_0x1009_14c6; /* jmp 0x100914c6 */
        l_0x1009_14be:
            ii(0x1009_14be, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_14c1, 5); calld(0x1007_6bf8, -0x1_a8ce);          /* call 0x10076bf8 */
        l_0x1009_14c6:
            ii(0x1009_14c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_14c8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_14cb, 5); calld(0x1013_ad71, 0xa_98a1);           /* call 0x1013ad71 */
            ii(0x1009_14d0, 2); test(al, al);                           /* test al, al */
            ii(0x1009_14d2, 2); if(jzd(0x1009_1527, 0x53)) goto l_0x1009_1527; /* jz 0x10091527 */
            ii(0x1009_14d4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_14d7, 5); calld(0x1007_63a0, -0x1_b13c);          /* call 0x100763a0 */
            ii(0x1009_14dc, 5); cmp(memw_a32[ds, eax + 0x8], 0xd);      /* cmp word [eax+0x8], 0xd */
            ii(0x1009_14e1, 2); if(jzd(0x1009_14f2, 0xf)) goto l_0x1009_14f2; /* jz 0x100914f2 */
            ii(0x1009_14e3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_14e6, 5); calld(0x1007_63a0, -0x1_b14b);          /* call 0x100763a0 */
            ii(0x1009_14eb, 5); cmp(memw_a32[ds, eax + 0x8], 0xe);      /* cmp word [eax+0x8], 0xe */
            ii(0x1009_14f0, 2); if(jnzd(0x1009_1525, 0x33)) goto l_0x1009_1525; /* jnz 0x10091525 */
        l_0x1009_14f2:
            ii(0x1009_14f2, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1009_14f5, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_14f8, 5); calld(0x1007_63a0, -0x1_b15d);          /* call 0x100763a0 */
            ii(0x1009_14fd, 5); calld(0x1015_2532, 0xc_1030);           /* call 0x10152532 */
            ii(0x1009_1502, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1009_1507, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1508, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1009_150c, 1); pushd(eax);                             /* push eax */
            ii(0x1009_150d, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1009_1511, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1512, 4); movsx(ecx, memw_a32[ss, ebp - 0x30]);   /* movsx ecx, word [ebp-0x30] */
            ii(0x1009_1516, 4); movsx(ebx, memw_a32[ss, ebp - 0x34]);   /* movsx ebx, word [ebp-0x34] */
            ii(0x1009_151a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_151d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_1520, 5); calld(0x1009_0aaa, -0xa7b);             /* call 0x10090aaa */
        l_0x1009_1525:
            ii(0x1009_1525, 2); jmpd(0x1009_14be, -0x69); goto l_0x1009_14be; /* jmp 0x100914be */
        l_0x1009_1527:
            ii(0x1009_1527, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_152c, 5); calld(0x1007_6338, -0x1_b1f9);          /* call 0x10076338 */
            ii(0x1009_1531, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_1534, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_1536, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_1538, 5); calld(0x1007_643c, -0x1_b101);          /* call 0x1007643c */
            ii(0x1009_153d, 2); jmpd(0x1009_1547, 0x8); goto l_0x1009_1547; /* jmp 0x10091547 */
        l_0x1009_153f:
            ii(0x1009_153f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1542, 5); calld(0x1007_6bf8, -0x1_a94f);          /* call 0x10076bf8 */
        l_0x1009_1547:
            ii(0x1009_1547, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1549, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_154c, 5); calld(0x1013_ad71, 0xa_9820);           /* call 0x1013ad71 */
            ii(0x1009_1551, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1553, 2); if(jzd(0x1009_15b3, 0x5e)) goto l_0x1009_15b3; /* jz 0x100915b3 */
            ii(0x1009_1555, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1558, 5); calld(0x1007_63a0, -0x1_b1bd);          /* call 0x100763a0 */
            ii(0x1009_155d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_155f, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1009_1562, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_1565, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_1568, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_156b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_156d, 2); if(jnzd(0x1009_15b1, 0x42)) goto l_0x1009_15b1; /* jnz 0x100915b1 */
            ii(0x1009_156f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1572, 5); calld(0x1007_63a0, -0x1_b1d7);          /* call 0x100763a0 */
            ii(0x1009_1577, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x1009_157c, 2); if(jzd(0x1009_15b1, 0x33)) goto l_0x1009_15b1; /* jz 0x100915b1 */
            ii(0x1009_157e, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1009_1581, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_1584, 5); calld(0x1007_63a0, -0x1_b1e9);          /* call 0x100763a0 */
            ii(0x1009_1589, 5); calld(0x1015_2532, 0xc_0fa4);           /* call 0x10152532 */
            ii(0x1009_158e, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1009_1593, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1594, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1009_1598, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1599, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1009_159d, 1); pushd(eax);                             /* push eax */
            ii(0x1009_159e, 4); movsx(ecx, memw_a32[ss, ebp - 0x30]);   /* movsx ecx, word [ebp-0x30] */
            ii(0x1009_15a2, 4); movsx(ebx, memw_a32[ss, ebp - 0x34]);   /* movsx ebx, word [ebp-0x34] */
            ii(0x1009_15a6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_15a9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_15ac, 5); calld(0x1009_0aaa, -0xb07);             /* call 0x10090aaa */
        l_0x1009_15b1:
            ii(0x1009_15b1, 2); jmpd(0x1009_153f, -0x74); goto l_0x1009_153f; /* jmp 0x1009153f */
        l_0x1009_15b3:
            ii(0x1009_15b3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_15b5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_15b8, 5); calld(0x1009_ba6c, 0xa4af);             /* call 0x1009ba6c */
            ii(0x1009_15bd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_15bf, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_15c2, 5); calld(0x1007_5f6c, -0x1_b65b);          /* call 0x10075f6c */
            ii(0x1009_15c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_15c9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_15ca, 1); popd(edi);                              /* pop edi */
            ii(0x1009_15cb, 1); popd(esi);                              /* pop esi */
            ii(0x1009_15cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_15cd, 1); retd(); return;                         /* ret */
        }
    }
}
