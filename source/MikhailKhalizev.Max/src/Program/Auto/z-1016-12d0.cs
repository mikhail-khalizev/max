using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_12d0-623e297b")]
        public void Method_1016_12d0()
        {
            ii(0x1016_12d0, 5); push(0x64);                             /* push 0x64 */
            ii(0x1016_12d5, 5); call(Definitions.sys_check_available_stack_size, 0x4a78); /* call 0x10165d52 */
            ii(0x1016_12da, 1); push(ebx);                              /* push ebx */
            ii(0x1016_12db, 1); push(ecx);                              /* push ecx */
            ii(0x1016_12dc, 1); push(edx);                              /* push edx */
            ii(0x1016_12dd, 1); push(esi);                              /* push esi */
            ii(0x1016_12de, 1); push(edi);                              /* push edi */
            ii(0x1016_12df, 1); push(ebp);                              /* push ebp */
            ii(0x1016_12e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_12e2, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1016_12e8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_12eb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_12ed, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_12f0, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1016_12f3, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1016_12f6, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1016_12fa, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1016_12fd, 5); call(Definitions.my_ctor_0x101b_38f8, -0xe_ac12); /* call 0x100766f0 */
            ii(0x1016_1302, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1016_1305, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1016_1309, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1016_130d, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1016_1310, 5); call(Definitions.my_ctor_0x101b_38f8, -0xe_ac25); /* call 0x100766f0 */
            ii(0x1016_1315, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1016_1318, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1016_131c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_131f, 5); call(0x1007_611c, -0xe_b208);           /* call 0x1007611c */
            ii(0x1016_1324, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1326, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1016_1329, 5); call(0x1007_6630, -0xe_acfe);           /* call 0x10076630 */
            ii(0x1016_132e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1016_1331, 5); call(0x1007_6574, -0xe_adc2);           /* call 0x10076574 */
            ii(0x1016_1336, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1016_133a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1016_133d, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1016_1340, 5); call(0x1007_6574, -0xe_add1);           /* call 0x10076574 */
            ii(0x1016_1345, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1016_1349, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1016_134c, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1016_134f, 5); call(0x1007_6574, -0xe_ade0);           /* call 0x10076574 */
            ii(0x1016_1354, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1016_1358, 2); if(jz(0x1016_136a, 0x10)) goto l_0x1016_136a; /* jz 0x1016136a */
            ii(0x1016_135a, 7); mov(memd[ss, ebp - 0x10], 0x13);        /* mov dword [ebp-0x10], 0x13 */
            ii(0x1016_1361, 7); mov(memd[ss, ebp - 0x18], 0xf);         /* mov dword [ebp-0x18], 0xf */
            ii(0x1016_1368, 2); jmp(0x1016_1378, 0xe); goto l_0x1016_1378; /* jmp 0x10161378 */
        l_0x1016_136a:
            ii(0x1016_136a, 7); mov(memd[ss, ebp - 0x10], 0x14);        /* mov dword [ebp-0x10], 0x14 */
            ii(0x1016_1371, 7); mov(memd[ss, ebp - 0x18], 0x10);        /* mov dword [ebp-0x18], 0x10 */
        l_0x1016_1378:
            ii(0x1016_1378, 5); call(0x1010_2b84, -0x5_e7f9);           /* call 0x10102b84 */
            ii(0x1016_137d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_1382, 1); push(eax);                              /* push eax */
            ii(0x1016_1383, 5); call(0x1010_2ba4, -0x5_e7e4);           /* call 0x10102ba4 */
            ii(0x1016_1388, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_138d, 1); push(eax);                              /* push eax */
            ii(0x1016_138e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_1390, 1); push(eax);                              /* push eax */
            ii(0x1016_1391, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1016_1395, 1); push(eax);                              /* push eax */
            ii(0x1016_1396, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1016_139a, 1); push(eax);                              /* push eax */
            ii(0x1016_139b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_139d, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1016_13a1, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1016_13a5, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1016_13a8, 5); call(0x1015_a2da, -0x70d3);             /* call 0x1015a2da */
            ii(0x1016_13ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_13af, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1016_13b2, 5); call(0x1007_5f2c, -0xe_b48b);           /* call 0x10075f2c */
            ii(0x1016_13b7, 5); call(0x1010_2b84, -0x5_e838);           /* call 0x10102b84 */
            ii(0x1016_13bc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_13c1, 1); push(eax);                              /* push eax */
            ii(0x1016_13c2, 5); call(0x1010_2ba4, -0x5_e823);           /* call 0x10102ba4 */
            ii(0x1016_13c7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_13cc, 1); push(eax);                              /* push eax */
            ii(0x1016_13cd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_13cf, 1); push(eax);                              /* push eax */
            ii(0x1016_13d0, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1016_13d4, 1); push(eax);                              /* push eax */
            ii(0x1016_13d5, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1016_13d9, 1); push(eax);                              /* push eax */
            ii(0x1016_13da, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_13dc, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1016_13e0, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1016_13e4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1016_13e7, 5); call(0x1015_a2da, -0x7112);             /* call 0x1015a2da */
            ii(0x1016_13ec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_13ee, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1016_13f1, 5); call(0x1008_ac18, -0xd_67de);           /* call 0x1008ac18 */
            ii(0x1016_13f6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_13f8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1016_13fb, 5); call(0x1007_5f2c, -0xe_b4d4);           /* call 0x10075f2c */
            ii(0x1016_1400, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_1403, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1016_1406, 5); call(0x1007_6574, -0xe_ae97);           /* call 0x10076574 */
            ii(0x1016_140b, 5); call(0x1008_a998, -0xd_6a78);           /* call 0x1008a998 */
            ii(0x1016_1410, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1413, 5); call(0x1014_b6bd, -0x1_5d5b);           /* call 0x1014b6bd */
            ii(0x1016_1418, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_141b, 4); mov(memb[ds, eax + 0x3e], 0x5);         /* mov byte [eax+0x3e], 0x5 */
            ii(0x1016_141f, 5); cmp(memw[ss, ebp - 0x18], 0xf);         /* cmp word [ebp-0x18], 0xf */
            ii(0x1016_1424, 2); if(jnz(0x1016_1438, 0x12)) goto l_0x1016_1438; /* jnz 0x10161438 */
            ii(0x1016_1426, 5); mov(ebx, 0x22);                         /* mov ebx, 0x22 */
            ii(0x1016_142b, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1016_1430, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1433, 5); call(0x1016_2f96, 0x1b5e);              /* call 0x10162f96 */
        l_0x1016_1438:
            ii(0x1016_1438, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_143b, 5); call(0x1012_0a5c, -0x4_09e4);           /* call 0x10120a5c */
            ii(0x1016_1440, 5); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1016_1445, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_1448, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_144b, 5); call(0x1014_9b07, -0x1_7949);           /* call 0x10149b07 */
            ii(0x1016_1450, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1455, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1458, 5); call(0x1007_6d98, -0xe_a6c5);           /* call 0x10076d98 */
            ii(0x1016_145d, 2); test(al, al);                           /* test al, al */
            ii(0x1016_145f, 2); if(jz(0x1016_147c, 0x1b)) goto l_0x1016_147c; /* jz 0x1016147c */
            ii(0x1016_1461, 5); call(0x1010_2bf8, -0x5_e86e);           /* call 0x10102bf8 */
            ii(0x1016_1466, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_1468, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_146a, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1016_146f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_1472, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_1477, 5); call(0x1013_d5c0, -0x2_3ebc);           /* call 0x1013d5c0 */
        l_0x1016_147c:
            ii(0x1016_147c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_147e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1016_1481, 5); call(0x1007_5f2c, -0xe_b55a);           /* call 0x10075f2c */
            ii(0x1016_1486, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1488, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1016_148b, 5); call(0x1007_5f2c, -0xe_b564);           /* call 0x10075f2c */
            ii(0x1016_1490, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_1492, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_1493, 1); pop(edi);                               /* pop edi */
            ii(0x1016_1494, 1); pop(esi);                               /* pop esi */
            ii(0x1016_1495, 1); pop(edx);                               /* pop edx */
            ii(0x1016_1496, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_1497, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_1498, 1); ret();                                  /* ret */
        }
    }
}
