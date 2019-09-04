using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1436-666d284a")]
        public void Method_1007_1436()
        {
            ii(0x1007_1436, 5); push(0x38);                             /* push 0x38 */
            ii(0x1007_143b, 5); call(Definitions.sys_check_available_stack_size, 0xf_4912); /* call 0x10165d52 */
            ii(0x1007_1440, 1); push(ecx);                              /* push ecx */
            ii(0x1007_1441, 1); push(esi);                              /* push esi */
            ii(0x1007_1442, 1); push(edi);                              /* push edi */
            ii(0x1007_1443, 1); push(ebp);                              /* push ebp */
            ii(0x1007_1444, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_1446, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_144c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_144f, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1007_1452, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1007_1455, 4); or(memb[ss, ebp - 16], 1);              /* or byte [ebp-0x10], 0x1 */
            ii(0x1007_1459, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1007_145c, 5); call(0x1007_64fc, 0x509b);              /* call 0x100764fc */
            ii(0x1007_1461, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1007_1464, 4); and(memb[ss, ebp - 16], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1007_1468, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_146a, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1007_146d, 3); mov(al, memb[ds, edx + 38]);            /* mov al, [edx+0x26] */
            ii(0x1007_1470, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1007_1473, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_1476, 8); imul(ax, memw[ds, 0x101c_8172]);        /* imul ax, [0x101c8172] */
            ii(0x1007_147e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_1481, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_1483, 3); mov(memd[ss, ebp - 20], edx);           /* mov [ebp-0x14], edx */
            ii(0x1007_1486, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_1489, 5); cmp(memw[ds, eax + 8], 0x45);           /* cmp word [eax+0x8], 0x45 */
            ii(0x1007_148e, 2); if(jnz(0x1007_14a8, 0x18)) goto l_0x1007_14a8; /* jnz 0x100714a8 */
            ii(0x1007_1490, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1007_1494, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_149a, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1007_149e, 6); mov(eax, memd[ds, eax + 0x101c_a6a7]);  /* mov eax, [eax+0x101ca6a7] */
            ii(0x1007_14a4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_14a6, 2); dec(memb[ds, eax]);                     /* dec byte [eax] */
        l_0x1007_14a8:
            ii(0x1007_14a8, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_14ab, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_14b0, 2); if(jz(0x1007_14bc, 0xa)) goto l_0x1007_14bc; /* jz 0x100714bc */
            ii(0x1007_14b2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_14b5, 5); cmp(memw[ds, eax + 8], 0x43);           /* cmp word [eax+0x8], 0x43 */
            ii(0x1007_14ba, 2); if(jnz(0x1007_14d4, 0x18)) goto l_0x1007_14d4; /* jnz 0x100714d4 */
        l_0x1007_14bc:
            ii(0x1007_14bc, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1007_14c0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_14c6, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1007_14ca, 6); mov(eax, memd[ds, eax + 0x101c_a6ab]);  /* mov eax, [eax+0x101ca6ab] */
            ii(0x1007_14d0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_14d2, 2); dec(memb[ds, eax]);                     /* dec byte [eax] */
        l_0x1007_14d4:
            ii(0x1007_14d4, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1007_14d8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_14de, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1007_14e2, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x1007_14e8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_14ea, 2); dec(memb[ds, eax]);                     /* dec byte [eax] */
            ii(0x1007_14ec, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1007_14ee, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_14f3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_14f5, 6); if(jnz(0x1007_15ce, 0xd3)) goto l_0x1007_15ce; /* jnz 0x100715ce */
            ii(0x1007_14fb, 4); movsx(ecx, memw[ss, ebp - 24]);         /* movsx ecx, word [ebp-0x18] */
            ii(0x1007_14ff, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_1503, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1007_1507, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_150a, 5); call(0x1007_6aac, 0x559d);              /* call 0x10076aac */
            ii(0x1007_150f, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1007_1511, 5); call(0x100a_929b, 0x3_7d85);            /* call 0x100a929b */
            ii(0x1007_1516, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_151a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_151c, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1007_1521, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_1523, 2); if(jnz(0x1007_1550, 0x2b)) goto l_0x1007_1550; /* jnz 0x10071550 */
            ii(0x1007_1525, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1007_1529, 6); mov(edx, memd[ds, 0x101c_70e8]);        /* mov edx, [0x101c70e8] */
            ii(0x1007_152f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_1531, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1007_1533, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1538, 6); mov(edx, memd[ds, 0x101c_70cc]);        /* mov edx, [0x101c70cc] */
            ii(0x1007_153e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_1540, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1007_1544, 6); mov(ebx, memd[ds, 0x101c_70e0]);        /* mov ebx, [0x101c70e0] */
            ii(0x1007_154a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_154c, 2); mov(dl, memb[ds, edx]);                 /* mov dl, [edx] */
            ii(0x1007_154e, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
        l_0x1007_1550:
            ii(0x1007_1550, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_1554, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1007_1558, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_155d, 5); call(0x1010_3541, 0x9_1fdf);            /* call 0x10103541 */
            ii(0x1007_1562, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_1564, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1007_1567, 5); call(0x1007_643c, 0x4ed0);              /* call 0x1007643c */
            ii(0x1007_156c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_156e, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1007_1571, 5); call(0x1013_ad71, 0xc_97fb);            /* call 0x1013ad71 */
            ii(0x1007_1576, 2); test(al, al);                           /* test al, al */
            ii(0x1007_1578, 2); if(jz(0x1007_15ce, 0x54)) goto l_0x1007_15ce; /* jz 0x100715ce */
            ii(0x1007_157a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_157c, 6); mov(dl, memb[ds, 0x101c_3889]);         /* mov dl, [0x101c3889] */
            ii(0x1007_1582, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_1584, 5); mov(al, memb[ds, 0x101c_388a]);         /* mov al, [0x101c388a] */
            ii(0x1007_1589, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1007_158b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_158d, 2); if(jz(0x1007_159e, 0xf)) goto l_0x1007_159e; /* jz 0x1007159e */
            ii(0x1007_158f, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x1007_1594, 5); call(0x1007_6b90, 0x55f7);              /* call 0x10076b90 */
            ii(0x1007_1599, 1); cwde();                                 /* cwde */
            ii(0x1007_159a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_159c, 2); if(jnz(0x1007_15a0, 2)) goto l_0x1007_15a0; /* jnz 0x100715a0 */
        l_0x1007_159e:
            ii(0x1007_159e, 2); jmp(0x1007_15a5, 5); goto l_0x1007_15a5; /* jmp 0x100715a5 */
        l_0x1007_15a0:
            ii(0x1007_15a0, 5); call(0x100f_f5c1, 0x8_e01c);            /* call 0x100ff5c1 */
        l_0x1007_15a5:
            ii(0x1007_15a5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_15a7, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1007_15aa, 5); call(0x1013_ad71, 0xc_97c2);            /* call 0x1013ad71 */
            ii(0x1007_15af, 2); test(al, al);                           /* test al, al */
            ii(0x1007_15b1, 2); if(jz(0x1007_15ce, 0x1b)) goto l_0x1007_15ce; /* jz 0x100715ce */
            ii(0x1007_15b3, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_15b7, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1007_15ba, 5); call(0x1007_63a0, 0x4de1);              /* call 0x100763a0 */
            ii(0x1007_15bf, 5); call(0x1014_f2a2, 0xd_dcde);            /* call 0x1014f2a2 */
            ii(0x1007_15c4, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1007_15c7, 5); call(0x1007_6bf8, 0x562c);              /* call 0x10076bf8 */
            ii(0x1007_15cc, 2); jmp(0x1007_15a5, -0x29); goto l_0x1007_15a5; /* jmp 0x100715a5 */
        l_0x1007_15ce:
            ii(0x1007_15ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_15d0, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1007_15d3, 5); call(0x1007_5f6c, 0x4994);              /* call 0x10075f6c */
            ii(0x1007_15d8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_15da, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_15db, 1); pop(edi);                               /* pop edi */
            ii(0x1007_15dc, 1); pop(esi);                               /* pop esi */
            ii(0x1007_15dd, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_15de, 1); ret();                                  /* ret */
        }
    }
}
