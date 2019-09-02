using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_12cd-706df435")]
        public void Method_100c_12cd()
        {
            ii(0x100c_12cd, 5); push(0xd4);                             /* push 0xd4 */
            ii(0x100c_12d2, 5); call(Definitions.sys_check_available_stack_size, 0xa_4a7b); /* call 0x10165d52 */
            ii(0x100c_12d7, 1); push(esi);                              /* push esi */
            ii(0x100c_12d8, 1); push(edi);                              /* push edi */
            ii(0x100c_12d9, 1); push(ebp);                              /* push ebp */
            ii(0x100c_12da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_12dc, 6); sub(esp, 0xbc);                         /* sub esp, 0xbc */
            ii(0x100c_12e2, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_12e5, 3); mov(memb[ss, ebp - 12], dl);            /* mov [ebp-0xc], dl */
            ii(0x100c_12e8, 3); mov(memb[ss, ebp - 8], bl);             /* mov [ebp-0x8], bl */
            ii(0x100c_12eb, 3); mov(memb[ss, ebp - 4], cl);             /* mov [ebp-0x4], cl */
            ii(0x100c_12ee, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100c_12f3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_12f6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_12f8, 2); if(jg(0x100c_1306, 0xc)) goto l_0x100c_1306; /* jg 0x100c1306 */
            ii(0x100c_12fa, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x100c_1301, 5); jmp(0x100c_1fcb, 0xcc5); goto l_0x100c_1fcb; /* jmp 0x100c1fcb */
        l_0x100c_1306:
            ii(0x100c_1306, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1309, 4); cmp(memb[ds, eax + 14], 0);             /* cmp byte [eax+0xe], 0x0 */
            ii(0x100c_130d, 2); if(jz(0x100c_1317, 8)) goto l_0x100c_1317; /* jz 0x100c1317 */
            ii(0x100c_130f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1312, 5); call(0x100b_b2ef, -0x6028);             /* call 0x100bb2ef */
        l_0x100c_1317:
            ii(0x100c_1317, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100c_131c, 5); call(0x1007_5fdc, -0x4_b345);           /* call 0x10075fdc */
            ii(0x100c_1321, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100c_1324, 2); if(jge(0x100c_132a, 4)) goto l_0x100c_132a; /* jge 0x100c132a */
            ii(0x100c_1326, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
        l_0x100c_132a:
            ii(0x100c_132a, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_1331, 2); jmp(0x100c_1339, 6); goto l_0x100c_1339; /* jmp 0x100c1339 */
        l_0x100c_1333:
            ii(0x100c_1333, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_1336, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x100c_1339:
            ii(0x100c_1339, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_133d, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100c_1340, 6); if(jge(0x100c_13f1, 0xab)) goto l_0x100c_13f1; /* jge 0x100c13f1 */
            ii(0x100c_1346, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_134a, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_134d, 6); mov(al, memb[ds, eax + 0x101c_34f4]);   /* mov al, [eax+0x101c34f4] */
            ii(0x100c_1353, 3); cmp(al, memb[ss, ebp - 12]);            /* cmp al, [ebp-0xc] */
            ii(0x100c_1356, 2); if(jnz(0x100c_136a, 0x12)) goto l_0x100c_136a; /* jnz 0x100c136a */
            ii(0x100c_1358, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_135c, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_135f, 6); mov(al, memb[ds, eax + 0x101c_34f5]);   /* mov al, [eax+0x101c34f5] */
            ii(0x100c_1365, 3); cmp(al, memb[ss, ebp - 8]);             /* cmp al, [ebp-0x8] */
            ii(0x100c_1368, 2); if(jz(0x100c_136c, 2)) goto l_0x100c_136c; /* jz 0x100c136c */
        l_0x100c_136a:
            ii(0x100c_136a, 2); jmp(0x100c_137e, 0x12); goto l_0x100c_137e; /* jmp 0x100c137e */
        l_0x100c_136c:
            ii(0x100c_136c, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_1370, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1373, 6); mov(al, memb[ds, eax + 0x101c_34f6]);   /* mov al, [eax+0x101c34f6] */
            ii(0x100c_1379, 3); cmp(al, memb[ss, ebp - 4]);             /* cmp al, [ebp-0x4] */
            ii(0x100c_137c, 2); if(jz(0x100c_1380, 2)) goto l_0x100c_1380; /* jz 0x100c1380 */
        l_0x100c_137e:
            ii(0x100c_137e, 2); jmp(0x100c_1396, 0x16); goto l_0x100c_1396; /* jmp 0x100c1396 */
        l_0x100c_1380:
            ii(0x100c_1380, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_1384, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1387, 7); mov(dx, memw[ds, eax + 0x101c_34e4]);   /* mov dx, [eax+0x101c34e4] */
            ii(0x100c_138e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1391, 3); cmp(dx, memw[ds, eax]);                 /* cmp dx, [eax] */
            ii(0x100c_1394, 2); if(jz(0x100c_1398, 2)) goto l_0x100c_1398; /* jz 0x100c1398 */
        l_0x100c_1396:
            ii(0x100c_1396, 2); jmp(0x100c_13ec, 0x54); goto l_0x100c_13ec; /* jmp 0x100c13ec */
        l_0x100c_1398:
            ii(0x100c_1398, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_139c, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_139f, 5); mov(edx, 0x101c_34e4);                  /* mov edx, 0x101c34e4 */
            ii(0x100c_13a4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_13a6, 3); mov(memd[ss, ebp - 28], edx);           /* mov [ebp-0x1c], edx */
            ii(0x100c_13a9, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_13ad, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_13b0, 9); mov(memw[ds, eax + 0x101c_34e6], 0);    /* mov word [eax+0x101c34e6], 0x0 */
            ii(0x100c_13b9, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_13c0, 2); jmp(0x100c_13c8, 6); goto l_0x100c_13c8; /* jmp 0x100c13c8 */
        l_0x100c_13c2:
            ii(0x100c_13c2, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_13c5, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x100c_13c8:
            ii(0x100c_13c8, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_13cc, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100c_13cf, 2); if(jge(0x100c_13e1, 0x10)) goto l_0x100c_13e1; /* jge 0x100c13e1 */
            ii(0x100c_13d1, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_13d5, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_13d8, 7); inc(memw[ds, eax + 0x101c_34e6]);       /* inc word [eax+0x101c34e6] */
            ii(0x100c_13df, 2); jmp(0x100c_13c2, -0x1f); goto l_0x100c_13c2; /* jmp 0x100c13c2 */
        l_0x100c_13e1:
            ii(0x100c_13e1, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100c_13e4, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_13e7, 5); jmp(0x100c_1fcb, 0xbdf); goto l_0x100c_1fcb; /* jmp 0x100c1fcb */
        l_0x100c_13ec:
            ii(0x100c_13ec, 5); jmp(0x100c_1333, -0xbe); goto l_0x100c_1333; /* jmp 0x100c1333 */
        l_0x100c_13f1:
            ii(0x100c_13f1, 7); mov(memd[ss, ebp - 32], 0);             /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_13f8, 7); mov(memd[ss, ebp - 24], 1);             /* mov dword [ebp-0x18], 0x1 */
            ii(0x100c_13ff, 2); jmp(0x100c_1407, 6); goto l_0x100c_1407; /* jmp 0x100c1407 */
        l_0x100c_1401:
            ii(0x100c_1401, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_1404, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x100c_1407:
            ii(0x100c_1407, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_140b, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100c_140e, 2); if(jge(0x100c_1436, 0x26)) goto l_0x100c_1436; /* jge 0x100c1436 */
            ii(0x100c_1410, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1414, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1417, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x100c_141b, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100c_141e, 7); mov(ax, memw[ds, eax + 0x101c_34e6]);   /* mov ax, [eax+0x101c34e6] */
            ii(0x100c_1425, 7); cmp(ax, memw[ds, edx + 0x101c_34e6]);   /* cmp ax, [edx+0x101c34e6] */
            ii(0x100c_142c, 2); if(jge(0x100c_1434, 6)) goto l_0x100c_1434; /* jge 0x100c1434 */
            ii(0x100c_142e, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_1431, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x100c_1434:
            ii(0x100c_1434, 2); jmp(0x100c_1401, -0x35); goto l_0x100c_1401; /* jmp 0x100c1401 */
        l_0x100c_1436:
            ii(0x100c_1436, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_143a, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_143d, 5); mov(edx, 0x101c_34e4);                  /* mov edx, 0x101c34e4 */
            ii(0x100c_1442, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1444, 5); call(0x100b_9285, -0x81c4);             /* call 0x100b9285 */
            ii(0x100c_1449, 4); movsx(edx, memw[ss, ebp - 32]);         /* movsx edx, word [ebp-0x20] */
            ii(0x100c_144d, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100c_1450, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100c_1453, 6); mov(memb[ds, edx + 0x101c_34f4], al);   /* mov [edx+0x101c34f4], al */
            ii(0x100c_1459, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_145d, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1460, 9); mov(memw[ds, eax + 0x101c_34f2], 0);    /* mov word [eax+0x101c34f2], 0x0 */
            ii(0x100c_1469, 4); movsx(edx, memw[ss, ebp - 32]);         /* movsx edx, word [ebp-0x20] */
            ii(0x100c_146d, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100c_1470, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100c_1473, 6); mov(memb[ds, edx + 0x101c_34f5], al);   /* mov [edx+0x101c34f5], al */
            ii(0x100c_1479, 4); movsx(edx, memw[ss, ebp - 32]);         /* movsx edx, word [ebp-0x20] */
            ii(0x100c_147d, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100c_1480, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100c_1483, 6); mov(memb[ds, edx + 0x101c_34f6], al);   /* mov [edx+0x101c34f6], al */
            ii(0x100c_1489, 4); movsx(edx, memw[ss, ebp - 32]);         /* movsx edx, word [ebp-0x20] */
            ii(0x100c_148d, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100c_1490, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1493, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100c_1496, 7); mov(memw[ds, edx + 0x101c_34e4], ax);   /* mov [edx+0x101c34e4], ax */
            ii(0x100c_149d, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_14a1, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_14a4, 9); mov(memw[ds, eax + 0x101c_34e6], 0);    /* mov word [eax+0x101c34e6], 0x0 */
            ii(0x100c_14ad, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_14b4, 2); jmp(0x100c_14bc, 6); goto l_0x100c_14bc; /* jmp 0x100c14bc */
        l_0x100c_14b6:
            ii(0x100c_14b6, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_14b9, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x100c_14bc:
            ii(0x100c_14bc, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_14c0, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100c_14c3, 2); if(jge(0x100c_14d5, 0x10)) goto l_0x100c_14d5; /* jge 0x100c14d5 */
            ii(0x100c_14c5, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_14c9, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_14cc, 7); inc(memw[ds, eax + 0x101c_34e6]);       /* inc word [eax+0x101c34e6] */
            ii(0x100c_14d3, 2); jmp(0x100c_14b6, -0x1f); goto l_0x100c_14b6; /* jmp 0x100c14b6 */
        l_0x100c_14d5:
            ii(0x100c_14d5, 4); or(memb[ss, ebp - 36], 1);              /* or byte [ebp-0x24], 0x1 */
            ii(0x100c_14d9, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_14dc, 5); call(Definitions.my_ctor_0x101b_5724, -0x83b8); /* call 0x100b9129 */
            ii(0x100c_14e1, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x100c_14e4, 4); and(memb[ss, ebp - 36], -2 /* 0xfe */); /* and byte [ebp-0x24], 0xfe */
            ii(0x100c_14e8, 4); movsx(eax, memb[ss, ebp - 12]);         /* movsx eax, byte [ebp-0xc] */
            ii(0x100c_14ec, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_14ee, 7); mov(ax, memw[ds, eax + 0x101b_77dc]);   /* mov ax, [eax+0x101b77dc] */
            ii(0x100c_14f5, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x100c_14f8, 3); lea(edx, memd[ss, ebp - 72]);           /* lea edx, [ebp-0x48] */
            ii(0x100c_14fb, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_14fe, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_1501, 5); call(0x1007_8137, -0x4_93cf);           /* call 0x10078137 */
            ii(0x100c_1506, 4); cmp(memb[ss, ebp - 8], 1);              /* cmp byte [ebp-0x8], 0x1 */
            ii(0x100c_150a, 2); if(jle(0x100c_1514, 8)) goto l_0x100c_1514; /* jle 0x100c1514 */
            ii(0x100c_150c, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_150f, 5); call(0x100b_9285, -0x828f);             /* call 0x100b9285 */
        l_0x100c_1514:
            ii(0x100c_1514, 4); cmp(memb[ss, ebp - 8], 1);              /* cmp byte [ebp-0x8], 0x1 */
            ii(0x100c_1518, 2); if(jle(0x100c_1540, 0x26)) goto l_0x100c_1540; /* jle 0x100c1540 */
            ii(0x100c_151a, 3); mov(edx, memd[ss, ebp - 52]);           /* mov edx, [ebp-0x34] */
            ii(0x100c_151d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1520, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100c_1523, 5); call(0x100c_0c2f, -0x8f9);              /* call 0x100c0c2f */
            ii(0x100c_1528, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_152c, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_152f, 6); mov(edx, memd[ds, eax + 0x101c_34e8]);  /* mov edx, [eax+0x101c34e8] */
            ii(0x100c_1535, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1538, 3); add(eax, 0x57);                         /* add eax, 0x57 */
            ii(0x100c_153b, 5); call(0x100c_0c2f, -0x911);              /* call 0x100c0c2f */
        l_0x100c_1540:
            ii(0x100c_1540, 4); or(memb[ss, ebp - 36], 1);              /* or byte [ebp-0x24], 0x1 */
            ii(0x100c_1544, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1547, 5); call(0x1008_a1e8, -0x3_7364);           /* call 0x1008a1e8 */
            ii(0x100c_154c, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100c_154f, 4); and(memb[ss, ebp - 36], -2 /* 0xfe */); /* and byte [ebp-0x24], 0xfe */
            ii(0x100c_1553, 7); mov(memd[ss, ebp - 84], 0);             /* mov dword [ebp-0x54], 0x0 */
            ii(0x100c_155a, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_155e, 6); if(jnz(0x100c_15fe, 0x9a)) goto l_0x100c_15fe; /* jnz 0x100c15fe */
            ii(0x100c_1564, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1567, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_156a, 5); call(0x100c_b000, 0x9a91);              /* call 0x100cb000 */
            ii(0x100c_156f, 3); lea(ebx, memd[ss, ebp - 76]);           /* lea ebx, [ebp-0x4c] */
            ii(0x100c_1572, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_1574, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_1576, 5); call(0x100c_af68, 0x99ed);              /* call 0x100caf68 */
            ii(0x100c_157b, 2); jmp(0x100c_1585, 8); goto l_0x100c_1585; /* jmp 0x100c1585 */
        l_0x100c_157d:
            ii(0x100c_157d, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1580, 5); call(0x1007_6bf8, -0x4_a98d);           /* call 0x10076bf8 */
        l_0x100c_1585:
            ii(0x100c_1585, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1587, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_158a, 5); call(0x1013_ad71, 0x7_97e2);            /* call 0x1013ad71 */
            ii(0x100c_158f, 2); test(al, al);                           /* test al, al */
            ii(0x100c_1591, 2); if(jz(0x100c_15f9, 0x66)) goto l_0x100c_15f9; /* jz 0x100c15f9 */
            ii(0x100c_1593, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1596, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_1599, 4); movsx(edx, memw[ss, ebp - 64]);         /* movsx edx, word [ebp-0x40] */
            ii(0x100c_159d, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_15a0, 5); call(0x1008_a0f8, -0x3_74ad);           /* call 0x1008a0f8 */
            ii(0x100c_15a5, 5); call(0x1008_a370, -0x3_723a);           /* call 0x1008a370 */
            ii(0x100c_15aa, 5); call(0x100c_120a, -0x3a5);              /* call 0x100c120a */
            ii(0x100c_15af, 2); test(al, al);                           /* test al, al */
            ii(0x100c_15b1, 2); if(jz(0x100c_15f7, 0x44)) goto l_0x100c_15f7; /* jz 0x100c15f7 */
            ii(0x100c_15b3, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x100c_15b6, 3); inc(memd[ss, ebp - 84]);                /* inc dword [ebp-0x54] */
            ii(0x100c_15b9, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_15bd, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_15c0, 5); mov(edx, 0x101c_34e4);                  /* mov edx, 0x101c34e4 */
            ii(0x100c_15c5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_15c7, 1); push(eax);                              /* push eax */
            ii(0x100c_15c8, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_15cb, 1); push(eax);                              /* push eax */
            ii(0x100c_15cc, 3); lea(ecx, memd[ss, ebp - 72]);           /* lea ecx, [ebp-0x48] */
            ii(0x100c_15cf, 4); movsx(ebx, memb[ss, ebp - 8]);          /* movsx ebx, byte [ebp-0x8] */
            ii(0x100c_15d3, 3); lea(edx, memd[ss, ebp - 88]);           /* lea edx, [ebp-0x58] */
            ii(0x100c_15d6, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_15d9, 5); call(0x1008_a0f8, -0x3_74e6);           /* call 0x1008a0f8 */
            ii(0x100c_15de, 5); call(0x100b_8e63, -0x8780);             /* call 0x100b8e63 */
            ii(0x100c_15e3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_15e5, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_15e8, 5); call(0x1008_a0f8, -0x3_74f5);           /* call 0x1008a0f8 */
            ii(0x100c_15ed, 5); call(0x1008_a370, -0x3_7282);           /* call 0x1008a370 */
            ii(0x100c_15f2, 5); call(0x100c_0d5c, -0x89b);              /* call 0x100c0d5c */
        l_0x100c_15f7:
            ii(0x100c_15f7, 2); jmp(0x100c_157d, -0x7c); goto l_0x100c_157d; /* jmp 0x100c157d */
        l_0x100c_15f9:
            ii(0x100c_15f9, 5); jmp(0x100c_191c, 0x31e); goto l_0x100c_191c; /* jmp 0x100c191c */
        l_0x100c_15fe:
            ii(0x100c_15fe, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100c_1603, 5); call(0x1007_5fdc, -0x4_b62c);           /* call 0x10075fdc */
            ii(0x100c_1608, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100c_160b, 6); if(jge(0x100c_16d2, 0xc1)) goto l_0x100c_16d2; /* jge 0x100c16d2 */
            ii(0x100c_1611, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1614, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_1617, 5); call(0x100c_b000, 0x99e4);              /* call 0x100cb000 */
            ii(0x100c_161c, 3); lea(ebx, memd[ss, ebp - 76]);           /* lea ebx, [ebp-0x4c] */
            ii(0x100c_161f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_1621, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_1623, 5); call(0x100c_af68, 0x9940);              /* call 0x100caf68 */
            ii(0x100c_1628, 2); jmp(0x100c_1632, 8); goto l_0x100c_1632; /* jmp 0x100c1632 */
        l_0x100c_162a:
            ii(0x100c_162a, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_162d, 5); call(0x1007_6bf8, -0x4_aa3a);           /* call 0x10076bf8 */
        l_0x100c_1632:
            ii(0x100c_1632, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1634, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1637, 5); call(0x1013_ad71, 0x7_9735);            /* call 0x1013ad71 */
            ii(0x100c_163c, 2); test(al, al);                           /* test al, al */
            ii(0x100c_163e, 6); if(jz(0x100c_16cd, 0x89)) goto l_0x100c_16cd; /* jz 0x100c16cd */
            ii(0x100c_1644, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1647, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_164a, 4); movsx(edx, memw[ss, ebp - 64]);         /* movsx edx, word [ebp-0x40] */
            ii(0x100c_164e, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1651, 5); call(0x1008_a0f8, -0x3_755e);           /* call 0x1008a0f8 */
            ii(0x100c_1656, 5); call(0x1008_a370, -0x3_72eb);           /* call 0x1008a370 */
            ii(0x100c_165b, 5); call(0x100c_120a, -0x456);              /* call 0x100c120a */
            ii(0x100c_1660, 2); test(al, al);                           /* test al, al */
            ii(0x100c_1662, 2); if(jz(0x100c_16c8, 0x64)) goto l_0x100c_16c8; /* jz 0x100c16c8 */
            ii(0x100c_1664, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x100c_1667, 3); inc(memd[ss, ebp - 84]);                /* inc dword [ebp-0x54] */
            ii(0x100c_166a, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_166e, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1671, 5); mov(edx, 0x101c_34e4);                  /* mov edx, 0x101c34e4 */
            ii(0x100c_1676, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1678, 1); push(eax);                              /* push eax */
            ii(0x100c_1679, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_167c, 1); push(eax);                              /* push eax */
            ii(0x100c_167d, 3); lea(ecx, memd[ss, ebp - 72]);           /* lea ecx, [ebp-0x48] */
            ii(0x100c_1680, 4); movsx(esi, memb[ss, ebp - 8]);          /* movsx esi, byte [ebp-0x8] */
            ii(0x100c_1684, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1687, 5); call(0x1008_a0f8, -0x3_7594);           /* call 0x1008a0f8 */
            ii(0x100c_168c, 5); call(0x1008_a370, -0x3_7321);           /* call 0x1008a370 */
            ii(0x100c_1691, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x100c_1694, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_1697, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_169a, 5); call(0x1008_a0f8, -0x3_75a7);           /* call 0x1008a0f8 */
            ii(0x100c_169f, 5); call(0x1008_a370, -0x3_7334);           /* call 0x1008a370 */
            ii(0x100c_16a4, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100c_16a7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_16aa, 3); lea(eax, memd[ss, ebp - 92]);           /* lea eax, [ebp-0x5c] */
            ii(0x100c_16ad, 5); call(0x1007_6aac, -0x4_ac06);           /* call 0x10076aac */
            ii(0x100c_16b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_16b4, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_16b7, 5); call(0x1008_a0f8, -0x3_75c4);           /* call 0x1008a0f8 */
            ii(0x100c_16bc, 5); call(0x1008_a370, -0x3_7351);           /* call 0x1008a370 */
            ii(0x100c_16c1, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100c_16c3, 5); call(0x100c_0d5c, -0x96c);              /* call 0x100c0d5c */
        l_0x100c_16c8:
            ii(0x100c_16c8, 5); jmp(0x100c_162a, -0xa3); goto l_0x100c_162a; /* jmp 0x100c162a */
        l_0x100c_16cd:
            ii(0x100c_16cd, 5); jmp(0x100c_191c, 0x24a); goto l_0x100c_191c; /* jmp 0x100c191c */
        l_0x100c_16d2:
            ii(0x100c_16d2, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100c_16d7, 5); call(0x1007_6338, -0x4_b3a4);           /* call 0x10076338 */
            ii(0x100c_16dc, 3); lea(ebx, memd[ss, ebp - 96]);           /* lea ebx, [ebp-0x60] */
            ii(0x100c_16df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_16e1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_16e3, 5); call(0x1007_64b8, -0x4_b230);           /* call 0x100764b8 */
            ii(0x100c_16e8, 2); jmp(0x100c_16f2, 8); goto l_0x100c_16f2; /* jmp 0x100c16f2 */
        l_0x100c_16ea:
            ii(0x100c_16ea, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_16ed, 5); call(0x1007_6bf8, -0x4_aafa);           /* call 0x10076bf8 */
        l_0x100c_16f2:
            ii(0x100c_16f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_16f4, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_16f7, 5); call(0x1013_ad71, 0x7_9675);            /* call 0x1013ad71 */
            ii(0x100c_16fc, 2); test(al, al);                           /* test al, al */
            ii(0x100c_16fe, 6); if(jz(0x100c_1792, 0x8e)) goto l_0x100c_1792; /* jz 0x100c1792 */
            ii(0x100c_1704, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1707, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_170a, 4); movsx(edx, memw[ss, ebp - 64]);         /* movsx edx, word [ebp-0x40] */
            ii(0x100c_170e, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1711, 5); call(0x1007_63d4, -0x4_b342);           /* call 0x100763d4 */
            ii(0x100c_1716, 5); call(0x100c_120a, -0x511);              /* call 0x100c120a */
            ii(0x100c_171b, 2); test(al, al);                           /* test al, al */
            ii(0x100c_171d, 2); if(jz(0x100c_1736, 0x17)) goto l_0x100c_1736; /* jz 0x100c1736 */
            ii(0x100c_171f, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1722, 5); call(0x1007_63a0, -0x4_b387);           /* call 0x100763a0 */
            ii(0x100c_1727, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1729, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100c_172c, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_172f, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_1732, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_1734, 2); if(jnz(0x100c_1738, 2)) goto l_0x100c_1738; /* jnz 0x100c1738 */
        l_0x100c_1736:
            ii(0x100c_1736, 2); jmp(0x100c_178d, 0x55); goto l_0x100c_178d; /* jmp 0x100c178d */
        l_0x100c_1738:
            ii(0x100c_1738, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x100c_173b, 3); inc(memd[ss, ebp - 84]);                /* inc dword [ebp-0x54] */
            ii(0x100c_173e, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1742, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100c_1745, 5); mov(eax, 0x101c_34e4);                  /* mov eax, 0x101c34e4 */
            ii(0x100c_174a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_174c, 1); push(eax);                              /* push eax */
            ii(0x100c_174d, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_1750, 1); push(eax);                              /* push eax */
            ii(0x100c_1751, 3); lea(ecx, memd[ss, ebp - 72]);           /* lea ecx, [ebp-0x48] */
            ii(0x100c_1754, 4); movsx(esi, memb[ss, ebp - 8]);          /* movsx esi, byte [ebp-0x8] */
            ii(0x100c_1758, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_175b, 5); call(0x1007_63a0, -0x4_b3c0);           /* call 0x100763a0 */
            ii(0x100c_1760, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x100c_1763, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_1766, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1769, 5); call(0x1007_63a0, -0x4_b3ce);           /* call 0x100763a0 */
            ii(0x100c_176e, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100c_1771, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_1774, 3); lea(eax, memd[ss, ebp - 100]);          /* lea eax, [ebp-0x64] */
            ii(0x100c_1777, 5); call(0x1007_6aac, -0x4_acd0);           /* call 0x10076aac */
            ii(0x100c_177c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_177e, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1781, 5); call(0x1007_63d4, -0x4_b3b2);           /* call 0x100763d4 */
            ii(0x100c_1786, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100c_1788, 5); call(0x100c_0d5c, -0xa31);              /* call 0x100c0d5c */
        l_0x100c_178d:
            ii(0x100c_178d, 5); jmp(0x100c_16ea, -0xa8); goto l_0x100c_16ea; /* jmp 0x100c16ea */
        l_0x100c_1792:
            ii(0x100c_1792, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100c_1797, 5); call(0x1007_6338, -0x4_b464);           /* call 0x10076338 */
            ii(0x100c_179c, 3); lea(ebx, memd[ss, ebp - 96]);           /* lea ebx, [ebp-0x60] */
            ii(0x100c_179f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_17a1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_17a3, 5); call(0x1007_643c, -0x4_b36c);           /* call 0x1007643c */
            ii(0x100c_17a8, 2); jmp(0x100c_17b2, 8); goto l_0x100c_17b2; /* jmp 0x100c17b2 */
        l_0x100c_17aa:
            ii(0x100c_17aa, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_17ad, 5); call(0x1007_6bf8, -0x4_abba);           /* call 0x10076bf8 */
        l_0x100c_17b2:
            ii(0x100c_17b2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_17b4, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_17b7, 5); call(0x1013_ad71, 0x7_95b5);            /* call 0x1013ad71 */
            ii(0x100c_17bc, 2); test(al, al);                           /* test al, al */
            ii(0x100c_17be, 6); if(jz(0x100c_1852, 0x8e)) goto l_0x100c_1852; /* jz 0x100c1852 */
            ii(0x100c_17c4, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_17c7, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_17ca, 4); movsx(edx, memw[ss, ebp - 64]);         /* movsx edx, word [ebp-0x40] */
            ii(0x100c_17ce, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_17d1, 5); call(0x1007_63d4, -0x4_b402);           /* call 0x100763d4 */
            ii(0x100c_17d6, 5); call(0x100c_120a, -0x5d1);              /* call 0x100c120a */
            ii(0x100c_17db, 2); test(al, al);                           /* test al, al */
            ii(0x100c_17dd, 2); if(jz(0x100c_17f6, 0x17)) goto l_0x100c_17f6; /* jz 0x100c17f6 */
            ii(0x100c_17df, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_17e2, 5); call(0x1007_63a0, -0x4_b447);           /* call 0x100763a0 */
            ii(0x100c_17e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_17e9, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100c_17ec, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_17ef, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_17f2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_17f4, 2); if(jnz(0x100c_17f8, 2)) goto l_0x100c_17f8; /* jnz 0x100c17f8 */
        l_0x100c_17f6:
            ii(0x100c_17f6, 2); jmp(0x100c_184d, 0x55); goto l_0x100c_184d; /* jmp 0x100c184d */
        l_0x100c_17f8:
            ii(0x100c_17f8, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x100c_17fb, 3); inc(memd[ss, ebp - 84]);                /* inc dword [ebp-0x54] */
            ii(0x100c_17fe, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1802, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100c_1805, 5); mov(eax, 0x101c_34e4);                  /* mov eax, 0x101c34e4 */
            ii(0x100c_180a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_180c, 1); push(eax);                              /* push eax */
            ii(0x100c_180d, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_1810, 1); push(eax);                              /* push eax */
            ii(0x100c_1811, 3); lea(ecx, memd[ss, ebp - 72]);           /* lea ecx, [ebp-0x48] */
            ii(0x100c_1814, 4); movsx(esi, memb[ss, ebp - 8]);          /* movsx esi, byte [ebp-0x8] */
            ii(0x100c_1818, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_181b, 5); call(0x1007_63a0, -0x4_b480);           /* call 0x100763a0 */
            ii(0x100c_1820, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x100c_1823, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_1826, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1829, 5); call(0x1007_63a0, -0x4_b48e);           /* call 0x100763a0 */
            ii(0x100c_182e, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100c_1831, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_1834, 3); lea(eax, memd[ss, ebp - 104]);          /* lea eax, [ebp-0x68] */
            ii(0x100c_1837, 5); call(0x1007_6aac, -0x4_ad90);           /* call 0x10076aac */
            ii(0x100c_183c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_183e, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1841, 5); call(0x1007_63d4, -0x4_b472);           /* call 0x100763d4 */
            ii(0x100c_1846, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100c_1848, 5); call(0x100c_0d5c, -0xaf1);              /* call 0x100c0d5c */
        l_0x100c_184d:
            ii(0x100c_184d, 5); jmp(0x100c_17aa, -0xa8); goto l_0x100c_17aa; /* jmp 0x100c17aa */
        l_0x100c_1852:
            ii(0x100c_1852, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100c_1857, 5); call(0x1007_6338, -0x4_b524);           /* call 0x10076338 */
            ii(0x100c_185c, 3); lea(ebx, memd[ss, ebp - 96]);           /* lea ebx, [ebp-0x60] */
            ii(0x100c_185f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_1861, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_1863, 5); call(0x1007_643c, -0x4_b42c);           /* call 0x1007643c */
            ii(0x100c_1868, 2); jmp(0x100c_1872, 8); goto l_0x100c_1872; /* jmp 0x100c1872 */
        l_0x100c_186a:
            ii(0x100c_186a, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_186d, 5); call(0x1007_6bf8, -0x4_ac7a);           /* call 0x10076bf8 */
        l_0x100c_1872:
            ii(0x100c_1872, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1874, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1877, 5); call(0x1013_ad71, 0x7_94f5);            /* call 0x1013ad71 */
            ii(0x100c_187c, 2); test(al, al);                           /* test al, al */
            ii(0x100c_187e, 6); if(jz(0x100c_1912, 0x8e)) goto l_0x100c_1912; /* jz 0x100c1912 */
            ii(0x100c_1884, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1887, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_188a, 4); movsx(edx, memw[ss, ebp - 64]);         /* movsx edx, word [ebp-0x40] */
            ii(0x100c_188e, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1891, 5); call(0x1007_63d4, -0x4_b4c2);           /* call 0x100763d4 */
            ii(0x100c_1896, 5); call(0x100c_120a, -0x691);              /* call 0x100c120a */
            ii(0x100c_189b, 2); test(al, al);                           /* test al, al */
            ii(0x100c_189d, 2); if(jz(0x100c_18b6, 0x17)) goto l_0x100c_18b6; /* jz 0x100c18b6 */
            ii(0x100c_189f, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_18a2, 5); call(0x1007_63a0, -0x4_b507);           /* call 0x100763a0 */
            ii(0x100c_18a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_18a9, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100c_18ac, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_18af, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_18b2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_18b4, 2); if(jnz(0x100c_18b8, 2)) goto l_0x100c_18b8; /* jnz 0x100c18b8 */
        l_0x100c_18b6:
            ii(0x100c_18b6, 2); jmp(0x100c_190d, 0x55); goto l_0x100c_190d; /* jmp 0x100c190d */
        l_0x100c_18b8:
            ii(0x100c_18b8, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x100c_18bb, 3); inc(memd[ss, ebp - 84]);                /* inc dword [ebp-0x54] */
            ii(0x100c_18be, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_18c2, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100c_18c5, 5); mov(eax, 0x101c_34e4);                  /* mov eax, 0x101c34e4 */
            ii(0x100c_18ca, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_18cc, 1); push(eax);                              /* push eax */
            ii(0x100c_18cd, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_18d0, 1); push(eax);                              /* push eax */
            ii(0x100c_18d1, 3); lea(ecx, memd[ss, ebp - 72]);           /* lea ecx, [ebp-0x48] */
            ii(0x100c_18d4, 4); movsx(esi, memb[ss, ebp - 8]);          /* movsx esi, byte [ebp-0x8] */
            ii(0x100c_18d8, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_18db, 5); call(0x1007_63a0, -0x4_b540);           /* call 0x100763a0 */
            ii(0x100c_18e0, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x100c_18e3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_18e6, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_18e9, 5); call(0x1007_63a0, -0x4_b54e);           /* call 0x100763a0 */
            ii(0x100c_18ee, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100c_18f1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_18f4, 3); lea(eax, memd[ss, ebp - 108]);          /* lea eax, [ebp-0x6c] */
            ii(0x100c_18f7, 5); call(0x1007_6aac, -0x4_ae50);           /* call 0x10076aac */
            ii(0x100c_18fc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_18fe, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1901, 5); call(0x1007_63d4, -0x4_b532);           /* call 0x100763d4 */
            ii(0x100c_1906, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100c_1908, 5); call(0x100c_0d5c, -0xbb1);              /* call 0x100c0d5c */
        l_0x100c_190d:
            ii(0x100c_190d, 5); jmp(0x100c_186a, -0xa8); goto l_0x100c_186a; /* jmp 0x100c186a */
        l_0x100c_1912:
            ii(0x100c_1912, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1914, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100c_1917, 5); call(0x1007_5f6c, -0x4_b9b0);           /* call 0x10075f6c */
        l_0x100c_191c:
            ii(0x100c_191c, 4); cmp(memb[ss, ebp - 8], 1);              /* cmp byte [ebp-0x8], 0x1 */
            ii(0x100c_1920, 2); if(jle(0x100c_1967, 0x45)) goto l_0x100c_1967; /* jle 0x100c1967 */
            ii(0x100c_1922, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1926, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100c_1929, 5); mov(eax, 0x101c_34e4);                  /* mov eax, 0x101c34e4 */
            ii(0x100c_192e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1930, 5); call(0x100c_116a, -0x7cb);              /* call 0x100c116a */
            ii(0x100c_1935, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_1938, 5); call(0x100c_116a, -0x7d3);              /* call 0x100c116a */
            ii(0x100c_193d, 3); mov(edx, memd[ss, ebp - 52]);           /* mov edx, [ebp-0x34] */
            ii(0x100c_1940, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1944, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1947, 6); mov(eax, memd[ds, eax + 0x101c_34e8]);  /* mov eax, [eax+0x101c34e8] */
            ii(0x100c_194d, 5); call(0x100c_10ef, -0x863);              /* call 0x100c10ef */
            ii(0x100c_1952, 3); mov(edx, memd[ss, ebp - 48]);           /* mov edx, [ebp-0x30] */
            ii(0x100c_1955, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1959, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_195c, 6); mov(eax, memd[ds, eax + 0x101c_34ec]);  /* mov eax, [eax+0x101c34ec] */
            ii(0x100c_1962, 5); call(0x100c_10ef, -0x878);              /* call 0x100c10ef */
        l_0x100c_1967:
            ii(0x100c_1967, 7); mov(memd[ss, ebp - 112], 0);            /* mov dword [ebp-0x70], 0x0 */
            ii(0x100c_196e, 7); mov(memd[ss, ebp - 116], 0);            /* mov dword [ebp-0x74], 0x0 */
            ii(0x100c_1975, 2); jmp(0x100c_197d, 6); goto l_0x100c_197d; /* jmp 0x100c197d */
        l_0x100c_1977:
            ii(0x100c_1977, 3); mov(eax, memd[ss, ebp - 116]);          /* mov eax, [ebp-0x74] */
            ii(0x100c_197a, 3); inc(memd[ss, ebp - 116]);               /* inc dword [ebp-0x74] */
        l_0x100c_197d:
            ii(0x100c_197d, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_1981, 3); cmp(eax, 5);                            /* cmp eax, 0x5 */
            ii(0x100c_1984, 2); if(jge(0x100c_19c1, 0x3b)) goto l_0x100c_19c1; /* jge 0x100c19c1 */
            ii(0x100c_1986, 3); mov(eax, memd[ss, ebp - 116]);          /* mov eax, [ebp-0x74] */
            ii(0x100c_1989, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100c_198c, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x100c_198f, 2); if(jz(0x100c_19aa, 0x19)) goto l_0x100c_19aa; /* jz 0x100c19aa */
            ii(0x100c_1991, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_1995, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_199b, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100c_19a1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_19a6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_19a8, 2); if(jnz(0x100c_19ac, 2)) goto l_0x100c_19ac; /* jnz 0x100c19ac */
        l_0x100c_19aa:
            ii(0x100c_19aa, 2); jmp(0x100c_19bf, 0x13); goto l_0x100c_19bf; /* jmp 0x100c19bf */
        l_0x100c_19ac:
            ii(0x100c_19ac, 3); mov(eax, memd[ss, ebp - 112]);          /* mov eax, [ebp-0x70] */
            ii(0x100c_19af, 3); inc(memd[ss, ebp - 112]);               /* inc dword [ebp-0x70] */
            ii(0x100c_19b2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_19b5, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_19b7, 3); mov(eax, memd[ss, ebp - 116]);          /* mov eax, [ebp-0x74] */
            ii(0x100c_19ba, 5); mov(memw[ds, edx + ebp - 124], ax);     /* mov [edx+ebp-0x7c], ax */
        l_0x100c_19bf:
            ii(0x100c_19bf, 2); jmp(0x100c_1977, -0x4a); goto l_0x100c_1977; /* jmp 0x100c1977 */
        l_0x100c_19c1:
            ii(0x100c_19c1, 4); cmp(memb[ss, ebp - 12], 7);             /* cmp byte [ebp-0xc], 0x7 */
            ii(0x100c_19c5, 6); if(jnz(0x100c_1aff, 0x134)) goto l_0x100c_1aff; /* jnz 0x100c1aff */
            ii(0x100c_19cb, 3); mov(eax, memd[ss, ebp - 112]);          /* mov eax, [ebp-0x70] */
            ii(0x100c_19ce, 3); mov(memd[ss, ebp - 116], eax);          /* mov [ebp-0x74], eax */
        l_0x100c_19d1:
            ii(0x100c_19d1, 3); dec(memd[ss, ebp - 116]);               /* dec dword [ebp-0x74] */
            ii(0x100c_19d4, 5); cmp(memw[ss, ebp - 116], -1 /* 0xff */); /* cmp word [ebp-0x74], 0xffff */
            ii(0x100c_19d9, 2); if(jz(0x100c_1a04, 0x29)) goto l_0x100c_1a04; /* jz 0x100c1a04 */
            ii(0x100c_19db, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_19df, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_19e1, 4); mov(edx, memd[ds, eax + ebp - 126]);    /* mov edx, [eax+ebp-0x7e] */
            ii(0x100c_19e5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_19e8, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100c_19ee, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_19f2, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_19f5, 6); mov(edx, memd[ds, edx + 0x101c_a6a7]);  /* mov edx, [edx+0x101ca6a7] */
            ii(0x100c_19fb, 7); mov(memd[ds, eax + ebp - 140], edx);    /* mov [eax+ebp-0x8c], edx */
            ii(0x100c_1a02, 2); jmp(0x100c_19d1, -0x33); goto l_0x100c_19d1; /* jmp 0x100c19d1 */
        l_0x100c_1a04:
            ii(0x100c_1a04, 10); mov(memd[ss, ebp - 144], 0);           /* mov dword [ebp-0x90], 0x0 */
            ii(0x100c_1a0e, 2); jmp(0x100c_1a1c, 0xc); goto l_0x100c_1a1c; /* jmp 0x100c1a1c */
        l_0x100c_1a10:
            ii(0x100c_1a10, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1a16, 6); inc(memd[ss, ebp - 144]);               /* inc dword [ebp-0x90] */
        l_0x100c_1a1c:
            ii(0x100c_1a1c, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1a22, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_1a29, 6); if(jge(0x100c_1aff, 0xd0)) goto l_0x100c_1aff; /* jge 0x100c1aff */
            ii(0x100c_1a2f, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1a33, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1a36, 7); movsx(edx, memw[ss, ebp - 144]);        /* movsx edx, word [ebp-0x90] */
            ii(0x100c_1a3d, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_1a40, 6); mov(eax, memd[ds, eax + 0x101c_34e8]);  /* mov eax, [eax+0x101c34e8] */
            ii(0x100c_1a46, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1a48, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1a4a, 6); mov(memd[ss, ebp - 148], eax);          /* mov [ebp-0x94], eax */
            ii(0x100c_1a50, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1a56, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100c_1a59, 10); mov(memd[ss, ebp - 152], 0);           /* mov dword [ebp-0x98], 0x0 */
            ii(0x100c_1a63, 2); jmp(0x100c_1a71, 0xc); goto l_0x100c_1a71; /* jmp 0x100c1a71 */
        l_0x100c_1a65:
            ii(0x100c_1a65, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_1a6b, 6); inc(memd[ss, ebp - 152]);               /* inc dword [ebp-0x98] */
        l_0x100c_1a71:
            ii(0x100c_1a71, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_1a77, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_1a7e, 6); if(jge(0x100c_1afa, 0x76)) goto l_0x100c_1afa; /* jge 0x100c1afa */
            ii(0x100c_1a84, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x100c_1a88, 5); mov(eax, memd[ds, 0x101c_9454]);        /* mov eax, [0x101c9454] */
            ii(0x100c_1a8d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1a8f, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100c_1a91, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_1a96, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100c_1a99, 2); if(jnz(0x100c_1adf, 0x44)) goto l_0x100c_1adf; /* jnz 0x100c1adf */
            ii(0x100c_1a9b, 3); mov(eax, memd[ss, ebp - 112]);          /* mov eax, [ebp-0x70] */
            ii(0x100c_1a9e, 3); mov(memd[ss, ebp - 116], eax);          /* mov [ebp-0x74], eax */
        l_0x100c_1aa1:
            ii(0x100c_1aa1, 3); dec(memd[ss, ebp - 116]);               /* dec dword [ebp-0x74] */
            ii(0x100c_1aa4, 5); cmp(memw[ss, ebp - 116], -1 /* 0xff */); /* cmp word [ebp-0x74], 0xffff */
            ii(0x100c_1aa9, 2); if(jz(0x100c_1acc, 0x21)) goto l_0x100c_1acc; /* jz 0x100c1acc */
            ii(0x100c_1aab, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_1aaf, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_1ab2, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x100c_1ab6, 7); mov(eax, memd[ds, eax + ebp - 140]);    /* mov eax, [eax+ebp-0x8c] */
            ii(0x100c_1abd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1abf, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100c_1ac1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_1ac6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_1ac8, 2); if(jnz(0x100c_1acc, 2)) goto l_0x100c_1acc; /* jnz 0x100c1acc */
            ii(0x100c_1aca, 2); jmp(0x100c_1aa1, -0x2b); goto l_0x100c_1aa1; /* jmp 0x100c1aa1 */
        l_0x100c_1acc:
            ii(0x100c_1acc, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_1ad0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_1ad2, 2); if(jge(0x100c_1adf, 0xb)) goto l_0x100c_1adf; /* jge 0x100c1adf */
            ii(0x100c_1ad4, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_1ada, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
        l_0x100c_1adf:
            ii(0x100c_1adf, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_1ae5, 7); add(memd[ss, ebp - 148], 2);            /* add dword [ebp-0x94], 0x2 */
            ii(0x100c_1aec, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x100c_1af2, 3); add(memd[ss, ebp - 24], eax);           /* add [ebp-0x18], eax */
            ii(0x100c_1af5, 5); jmp(0x100c_1a65, -0x95); goto l_0x100c_1a65; /* jmp 0x100c1a65 */
        l_0x100c_1afa:
            ii(0x100c_1afa, 5); jmp(0x100c_1a10, -0xef); goto l_0x100c_1a10; /* jmp 0x100c1a10 */
        l_0x100c_1aff:
            ii(0x100c_1aff, 3); mov(eax, memd[ss, ebp - 112]);          /* mov eax, [ebp-0x70] */
            ii(0x100c_1b02, 3); mov(memd[ss, ebp - 116], eax);          /* mov [ebp-0x74], eax */
        l_0x100c_1b05:
            ii(0x100c_1b05, 3); dec(memd[ss, ebp - 116]);               /* dec dword [ebp-0x74] */
            ii(0x100c_1b08, 5); cmp(memw[ss, ebp - 116], -1 /* 0xff */); /* cmp word [ebp-0x74], 0xffff */
            ii(0x100c_1b0d, 6); if(jz(0x100c_1c48, 0x135)) goto l_0x100c_1c48; /* jz 0x100c1c48 */
            ii(0x100c_1b13, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_1b17, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_1b19, 4); mov(eax, memd[ds, eax + ebp - 126]);    /* mov eax, [eax+ebp-0x7e] */
            ii(0x100c_1b1d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_1b20, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_1b26, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x100c_1b2c, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
            ii(0x100c_1b32, 4); cmp(memb[ss, ebp - 12], 6);             /* cmp byte [ebp-0xc], 0x6 */
            ii(0x100c_1b36, 2); if(jnz(0x100c_1b59, 0x21)) goto l_0x100c_1b59; /* jnz 0x100c1b59 */
            ii(0x100c_1b38, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_1b3c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_1b3e, 4); mov(eax, memd[ds, eax + ebp - 126]);    /* mov eax, [eax+ebp-0x7e] */
            ii(0x100c_1b42, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_1b45, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_1b4b, 6); mov(eax, memd[ds, eax + 0x101c_a6a7]);  /* mov eax, [eax+0x101ca6a7] */
            ii(0x100c_1b51, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
            ii(0x100c_1b57, 2); jmp(0x100c_1b84, 0x2b); goto l_0x100c_1b84; /* jmp 0x100c1b84 */
        l_0x100c_1b59:
            ii(0x100c_1b59, 4); cmp(memb[ss, ebp - 12], 5);             /* cmp byte [ebp-0xc], 0x5 */
            ii(0x100c_1b5d, 2); if(jz(0x100c_1b65, 6)) goto l_0x100c_1b65; /* jz 0x100c1b65 */
            ii(0x100c_1b5f, 4); cmp(memb[ss, ebp - 12], 4);             /* cmp byte [ebp-0xc], 0x4 */
            ii(0x100c_1b63, 2); if(jnz(0x100c_1b84, 0x1f)) goto l_0x100c_1b84; /* jnz 0x100c1b84 */
        l_0x100c_1b65:
            ii(0x100c_1b65, 4); movsx(eax, memw[ss, ebp - 116]);        /* movsx eax, word [ebp-0x74] */
            ii(0x100c_1b69, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_1b6b, 4); mov(eax, memd[ds, eax + ebp - 126]);    /* mov eax, [eax+ebp-0x7e] */
            ii(0x100c_1b6f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_1b72, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_1b78, 6); mov(eax, memd[ds, eax + 0x101c_a6ab]);  /* mov eax, [eax+0x101ca6ab] */
            ii(0x100c_1b7e, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
        l_0x100c_1b84:
            ii(0x100c_1b84, 10); mov(memd[ss, ebp - 144], 0);           /* mov dword [ebp-0x90], 0x0 */
            ii(0x100c_1b8e, 2); jmp(0x100c_1b9c, 0xc); goto l_0x100c_1b9c; /* jmp 0x100c1b9c */
        l_0x100c_1b90:
            ii(0x100c_1b90, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1b96, 6); inc(memd[ss, ebp - 144]);               /* inc dword [ebp-0x90] */
        l_0x100c_1b9c:
            ii(0x100c_1b9c, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1ba2, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_1ba9, 6); if(jge(0x100c_1c43, 0x94)) goto l_0x100c_1c43; /* jge 0x100c1c43 */
            ii(0x100c_1baf, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1bb3, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1bb6, 7); movsx(edx, memw[ss, ebp - 144]);        /* movsx edx, word [ebp-0x90] */
            ii(0x100c_1bbd, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_1bc0, 6); mov(eax, memd[ds, eax + 0x101c_34e8]);  /* mov eax, [eax+0x101c34e8] */
            ii(0x100c_1bc6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1bc8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1bca, 6); mov(memd[ss, ebp - 148], eax);          /* mov [ebp-0x94], eax */
            ii(0x100c_1bd0, 7); movsx(eax, memw[ss, ebp - 144]);        /* movsx eax, word [ebp-0x90] */
            ii(0x100c_1bd7, 6); mov(edx, memd[ss, ebp - 156]);          /* mov edx, [ebp-0x9c] */
            ii(0x100c_1bdd, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_1bdf, 6); mov(memd[ss, ebp - 160], edx);          /* mov [ebp-0xa0], edx */
            ii(0x100c_1be5, 10); mov(memd[ss, ebp - 152], 0);           /* mov dword [ebp-0x98], 0x0 */
            ii(0x100c_1bef, 2); jmp(0x100c_1bfd, 0xc); goto l_0x100c_1bfd; /* jmp 0x100c1bfd */
        l_0x100c_1bf1:
            ii(0x100c_1bf1, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_1bf7, 6); inc(memd[ss, ebp - 152]);               /* inc dword [ebp-0x98] */
        l_0x100c_1bfd:
            ii(0x100c_1bfd, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_1c03, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_1c0a, 2); if(jge(0x100c_1c3e, 0x32)) goto l_0x100c_1c3e; /* jge 0x100c1c3e */
            ii(0x100c_1c0c, 6); mov(eax, memd[ss, ebp - 160]);          /* mov eax, [ebp-0xa0] */
            ii(0x100c_1c12, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x100c_1c15, 2); if(jz(0x100c_1c21, 0xa)) goto l_0x100c_1c21; /* jz 0x100c1c21 */
            ii(0x100c_1c17, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_1c1d, 4); or(memb[ds, eax + 1], -0x80 /* 0x80 */); /* or byte [eax+0x1], 0x80 */
        l_0x100c_1c21:
            ii(0x100c_1c21, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_1c27, 7); add(memd[ss, ebp - 148], 2);            /* add dword [ebp-0x94], 0x2 */
            ii(0x100c_1c2e, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100c_1c33, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_1c36, 6); add(memd[ss, ebp - 160], eax);          /* add [ebp-0xa0], eax */
            ii(0x100c_1c3c, 2); jmp(0x100c_1bf1, -0x4d); goto l_0x100c_1bf1; /* jmp 0x100c1bf1 */
        l_0x100c_1c3e:
            ii(0x100c_1c3e, 5); jmp(0x100c_1b90, -0xb3); goto l_0x100c_1b90; /* jmp 0x100c1b90 */
        l_0x100c_1c43:
            ii(0x100c_1c43, 5); jmp(0x100c_1b05, -0x143); goto l_0x100c_1b05; /* jmp 0x100c1b05 */
        l_0x100c_1c48:
            ii(0x100c_1c48, 4); cmp(memb[ss, ebp - 12], 4);             /* cmp byte [ebp-0xc], 0x4 */
            ii(0x100c_1c4c, 6); if(jnz(0x100c_1d13, 0xc1)) goto l_0x100c_1d13; /* jnz 0x100c1d13 */
            ii(0x100c_1c52, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1c56, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1c59, 6); mov(eax, memd[ds, eax + 0x101c_34e8]);  /* mov eax, [eax+0x101c34e8] */
            ii(0x100c_1c5f, 6); mov(memd[ss, ebp - 164], eax);          /* mov [ebp-0xa4], eax */
            ii(0x100c_1c65, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1c68, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_1c6b, 5); call(0x100c_b000, 0x9390);              /* call 0x100cb000 */
            ii(0x100c_1c70, 3); lea(ebx, memd[ss, ebp - 76]);           /* lea ebx, [ebp-0x4c] */
            ii(0x100c_1c73, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_1c75, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_1c77, 5); call(0x100c_af68, 0x92ec);              /* call 0x100caf68 */
            ii(0x100c_1c7c, 2); jmp(0x100c_1c86, 8); goto l_0x100c_1c86; /* jmp 0x100c1c86 */
        l_0x100c_1c7e:
            ii(0x100c_1c7e, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1c81, 5); call(0x1007_6bf8, -0x4_b08e);           /* call 0x10076bf8 */
        l_0x100c_1c86:
            ii(0x100c_1c86, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1c88, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1c8b, 5); call(0x1013_ad71, 0x7_90e1);            /* call 0x1013ad71 */
            ii(0x100c_1c90, 2); test(al, al);                           /* test al, al */
            ii(0x100c_1c92, 6); if(jz(0x100c_1d13, 0x7b)) goto l_0x100c_1d13; /* jz 0x100c1d13 */
            ii(0x100c_1c98, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1c9b, 5); call(0x1008_a0f8, -0x3_7ba8);           /* call 0x1008a0f8 */
            ii(0x100c_1ca0, 5); call(0x1008_a370, -0x3_7935);           /* call 0x1008a370 */
            ii(0x100c_1ca5, 4); cmp(memb[ds, eax + 61], 0x1a);          /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100c_1ca9, 2); if(jnz(0x100c_1d0e, 0x63)) goto l_0x100c_1d0e; /* jnz 0x100c1d0e */
            ii(0x100c_1cab, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x100c_1cb0, 6); lea(edx, memd[ss, ebp - 168]);          /* lea edx, [ebp-0xa8] */
            ii(0x100c_1cb6, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1cb9, 5); call(0x1008_a0f8, -0x3_7bc6);           /* call 0x1008a0f8 */
            ii(0x100c_1cbe, 5); call(0x100b_8e63, -0x8e60);             /* call 0x100b8e63 */
            ii(0x100c_1cc3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_1cc5, 6); lea(eax, memd[ss, ebp - 184]);          /* lea eax, [ebp-0xb8] */
            ii(0x100c_1ccb, 5); call(0x100a_95c1, -0x1_870f);           /* call 0x100a95c1 */
        l_0x100c_1cd0:
            ii(0x100c_1cd0, 6); lea(eax, memd[ss, ebp - 184]);          /* lea eax, [ebp-0xb8] */
            ii(0x100c_1cd6, 5); call(0x1008_9860, -0x3_847b);           /* call 0x10089860 */
            ii(0x100c_1cdb, 1); cwde();                                 /* cwde */
            ii(0x100c_1cdc, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_1cdf, 6); mov(edx, memd[ss, ebp - 164]);          /* mov edx, [ebp-0xa4] */
            ii(0x100c_1ce5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_1ce7, 6); lea(eax, memd[ss, ebp - 184]);          /* lea eax, [ebp-0xb8] */
            ii(0x100c_1ced, 5); call(0x1008_982c, -0x3_84c6);           /* call 0x1008982c */
            ii(0x100c_1cf2, 1); cwde();                                 /* cwde */
            ii(0x100c_1cf3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_1cf5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_1cf7, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x100c_1cf9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_1cfb, 4); or(memb[ds, eax + 1], -0x80 /* 0x80 */); /* or byte [eax+0x1], 0x80 */
            ii(0x100c_1cff, 6); lea(eax, memd[ss, ebp - 184]);          /* lea eax, [ebp-0xb8] */
            ii(0x100c_1d05, 5); call(0x100a_96db, -0x1_862f);           /* call 0x100a96db */
            ii(0x100c_1d0a, 2); test(al, al);                           /* test al, al */
            ii(0x100c_1d0c, 2); if(jnz(0x100c_1cd0, -0x3e)) goto l_0x100c_1cd0; /* jnz 0x100c1cd0 */
        l_0x100c_1d0e:
            ii(0x100c_1d0e, 5); jmp(0x100c_1c7e, -0x95); goto l_0x100c_1c7e; /* jmp 0x100c1c7e */
        l_0x100c_1d13:
            ii(0x100c_1d13, 10); mov(memd[ss, ebp - 144], 0);           /* mov dword [ebp-0x90], 0x0 */
            ii(0x100c_1d1d, 2); jmp(0x100c_1d2b, 0xc); goto l_0x100c_1d2b; /* jmp 0x100c1d2b */
        l_0x100c_1d1f:
            ii(0x100c_1d1f, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1d25, 6); inc(memd[ss, ebp - 144]);               /* inc dword [ebp-0x90] */
        l_0x100c_1d2b:
            ii(0x100c_1d2b, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1d31, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_1d38, 6); if(jge(0x100c_1dbf, 0x81)) goto l_0x100c_1dbf; /* jge 0x100c1dbf */
            ii(0x100c_1d3e, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1d42, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1d45, 7); movsx(edx, memw[ss, ebp - 144]);        /* movsx edx, word [ebp-0x90] */
            ii(0x100c_1d4c, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_1d4f, 6); mov(eax, memd[ds, eax + 0x101c_34e8]);  /* mov eax, [eax+0x101c34e8] */
            ii(0x100c_1d55, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1d57, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1d59, 6); mov(memd[ss, ebp - 148], eax);          /* mov [ebp-0x94], eax */
            ii(0x100c_1d5f, 10); mov(memd[ss, ebp - 152], 0);           /* mov dword [ebp-0x98], 0x0 */
            ii(0x100c_1d69, 2); jmp(0x100c_1d77, 0xc); goto l_0x100c_1d77; /* jmp 0x100c1d77 */
        l_0x100c_1d6b:
            ii(0x100c_1d6b, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_1d71, 6); inc(memd[ss, ebp - 152]);               /* inc dword [ebp-0x98] */
        l_0x100c_1d77:
            ii(0x100c_1d77, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_1d7d, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_1d84, 2); if(jge(0x100c_1dba, 0x34)) goto l_0x100c_1dba; /* jge 0x100c1dba */
            ii(0x100c_1d86, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_1d8c, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_1d8f, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x100c_1d92, 2); if(jz(0x100c_1da0, 0xc)) goto l_0x100c_1da0; /* jz 0x100c1da0 */
            ii(0x100c_1d94, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_1d9a, 4); and(memb[ds, eax + 1], 0x7f);           /* and byte [eax+0x1], 0x7f */
            ii(0x100c_1d9e, 2); jmp(0x100c_1dab, 0xb); goto l_0x100c_1dab; /* jmp 0x100c1dab */
        l_0x100c_1da0:
            ii(0x100c_1da0, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_1da6, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
        l_0x100c_1dab:
            ii(0x100c_1dab, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_1db1, 7); add(memd[ss, ebp - 148], 2);            /* add dword [ebp-0x94], 0x2 */
            ii(0x100c_1db8, 2); jmp(0x100c_1d6b, -0x4f); goto l_0x100c_1d6b; /* jmp 0x100c1d6b */
        l_0x100c_1dba:
            ii(0x100c_1dba, 5); jmp(0x100c_1d1f, -0xa0); goto l_0x100c_1d1f; /* jmp 0x100c1d1f */
        l_0x100c_1dbf:
            ii(0x100c_1dbf, 4); cmp(memb[ss, ebp - 12], 3);             /* cmp byte [ebp-0xc], 0x3 */
            ii(0x100c_1dc3, 2); if(jz(0x100c_1dcb, 6)) goto l_0x100c_1dcb; /* jz 0x100c1dcb */
            ii(0x100c_1dc5, 4); cmp(memb[ss, ebp - 12], 2);             /* cmp byte [ebp-0xc], 0x2 */
            ii(0x100c_1dc9, 2); if(jnz(0x100c_1dcd, 2)) goto l_0x100c_1dcd; /* jnz 0x100c1dcd */
        l_0x100c_1dcb:
            ii(0x100c_1dcb, 2); jmp(0x100c_1dd6, 9); goto l_0x100c_1dd6; /* jmp 0x100c1dd6 */
        l_0x100c_1dcd:
            ii(0x100c_1dcd, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1dd0, 4); cmp(memd[ds, eax + 103], 0);            /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_1dd4, 2); if(jnz(0x100c_1ddb, 5)) goto l_0x100c_1ddb; /* jnz 0x100c1ddb */
        l_0x100c_1dd6:
            ii(0x100c_1dd6, 5); jmp(0x100c_1eac, 0xd1); goto l_0x100c_1eac; /* jmp 0x100c1eac */
        l_0x100c_1ddb:
            ii(0x100c_1ddb, 10); mov(memd[ss, ebp - 144], 0);           /* mov dword [ebp-0x90], 0x0 */
            ii(0x100c_1de5, 2); jmp(0x100c_1df3, 0xc); goto l_0x100c_1df3; /* jmp 0x100c1df3 */
        l_0x100c_1de7:
            ii(0x100c_1de7, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1ded, 6); inc(memd[ss, ebp - 144]);               /* inc dword [ebp-0x90] */
        l_0x100c_1df3:
            ii(0x100c_1df3, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_1df9, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_1e00, 6); if(jge(0x100c_1eac, 0xa6)) goto l_0x100c_1eac; /* jge 0x100c1eac */
            ii(0x100c_1e06, 10); mov(memd[ss, ebp - 152], 0);           /* mov dword [ebp-0x98], 0x0 */
            ii(0x100c_1e10, 2); jmp(0x100c_1e1e, 0xc); goto l_0x100c_1e1e; /* jmp 0x100c1e1e */
        l_0x100c_1e12:
            ii(0x100c_1e12, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_1e18, 6); inc(memd[ss, ebp - 152]);               /* inc dword [ebp-0x98] */
        l_0x100c_1e1e:
            ii(0x100c_1e1e, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_1e24, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_1e2b, 2); if(jge(0x100c_1ea7, 0x7a)) goto l_0x100c_1ea7; /* jge 0x100c1ea7 */
            ii(0x100c_1e2d, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1e31, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1e34, 7); movsx(edx, memw[ss, ebp - 144]);        /* movsx edx, word [ebp-0x90] */
            ii(0x100c_1e3b, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_1e3e, 6); mov(eax, memd[ds, eax + 0x101c_34e8]);  /* mov eax, [eax+0x101c34e8] */
            ii(0x100c_1e44, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1e46, 7); movsx(edx, memw[ss, ebp - 152]);        /* movsx edx, word [ebp-0x98] */
            ii(0x100c_1e4d, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_1e4f, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1e51, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1e53, 7); movsx(edx, memw[ss, ebp - 144]);        /* movsx edx, word [ebp-0x90] */
            ii(0x100c_1e5a, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_1e5d, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100c_1e5f, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100c_1e62, 3); mov(edx, memd[ds, edx + 103]);          /* mov edx, [edx+0x67] */
            ii(0x100c_1e65, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_1e67, 7); movsx(ebx, memw[ss, ebp - 152]);        /* movsx ebx, word [ebp-0x98] */
            ii(0x100c_1e6e, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_1e70, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_1e72, 4); movsx(dx, memb[ds, edx]);               /* movsx dx, byte [edx] */
            ii(0x100c_1e76, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x100c_1e79, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1e7d, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1e80, 7); movsx(edx, memw[ss, ebp - 144]);        /* movsx edx, word [ebp-0x90] */
            ii(0x100c_1e87, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_1e8a, 6); mov(eax, memd[ds, eax + 0x101c_34ec]);  /* mov eax, [eax+0x101c34ec] */
            ii(0x100c_1e90, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1e92, 7); movsx(edx, memw[ss, ebp - 152]);        /* movsx edx, word [ebp-0x98] */
            ii(0x100c_1e99, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_1e9b, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1e9d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1e9f, 3); inc(memw[ds, eax]);                     /* inc word [eax] */
            ii(0x100c_1ea2, 5); jmp(0x100c_1e12, -0x95); goto l_0x100c_1e12; /* jmp 0x100c1e12 */
        l_0x100c_1ea7:
            ii(0x100c_1ea7, 5); jmp(0x100c_1de7, -0xc5); goto l_0x100c_1de7; /* jmp 0x100c1de7 */
        l_0x100c_1eac:
            ii(0x100c_1eac, 4); cmp(memb[ss, ebp - 12], 3);             /* cmp byte [ebp-0xc], 0x3 */
            ii(0x100c_1eb0, 6); if(jz(0x100c_1f90, 0xda)) goto l_0x100c_1f90; /* jz 0x100c1f90 */
            ii(0x100c_1eb6, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_1eb9, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_1ebc, 5); call(0x100c_b000, 0x913f);              /* call 0x100cb000 */
            ii(0x100c_1ec1, 3); lea(ebx, memd[ss, ebp - 76]);           /* lea ebx, [ebp-0x4c] */
            ii(0x100c_1ec4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_1ec6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_1ec8, 5); call(0x100c_af68, 0x909b);              /* call 0x100caf68 */
            ii(0x100c_1ecd, 2); jmp(0x100c_1ed7, 8); goto l_0x100c_1ed7; /* jmp 0x100c1ed7 */
        l_0x100c_1ecf:
            ii(0x100c_1ecf, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1ed2, 5); call(0x1007_6bf8, -0x4_b2df);           /* call 0x10076bf8 */
        l_0x100c_1ed7:
            ii(0x100c_1ed7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1ed9, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1edc, 5); call(0x1013_ad71, 0x7_8e90);            /* call 0x1013ad71 */
            ii(0x100c_1ee1, 2); test(al, al);                           /* test al, al */
            ii(0x100c_1ee3, 6); if(jz(0x100c_1f90, 0xa7)) goto l_0x100c_1f90; /* jz 0x100c1f90 */
            ii(0x100c_1ee9, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1eec, 5); call(0x1008_a0f8, -0x3_7df9);           /* call 0x1008a0f8 */
            ii(0x100c_1ef1, 5); call(0x1008_a370, -0x3_7b86);           /* call 0x1008a370 */
            ii(0x100c_1ef6, 6); mov(memd[ss, ebp - 188], eax);          /* mov [ebp-0xbc], eax */
            ii(0x100c_1efc, 6); mov(eax, memd[ss, ebp - 188]);          /* mov eax, [ebp-0xbc] */
            ii(0x100c_1f02, 5); cmp(memw[ds, eax + 8], 0x29);           /* cmp word [eax+0x8], 0x29 */
            ii(0x100c_1f07, 2); if(jz(0x100c_1f16, 0xd)) goto l_0x100c_1f16; /* jz 0x100c1f16 */
            ii(0x100c_1f09, 6); mov(eax, memd[ss, ebp - 188]);          /* mov eax, [ebp-0xbc] */
            ii(0x100c_1f0f, 5); cmp(memw[ds, eax + 8], 0x2a);           /* cmp word [eax+0x8], 0x2a */
            ii(0x100c_1f14, 2); if(jnz(0x100c_1f8b, 0x75)) goto l_0x100c_1f8b; /* jnz 0x100c1f8b */
        l_0x100c_1f16:
            ii(0x100c_1f16, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1f1a, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1f1d, 6); mov(edx, memd[ss, ebp - 188]);          /* mov edx, [ebp-0xbc] */
            ii(0x100c_1f23, 3); mov(edx, memd[ds, edx + 24]);           /* mov edx, [edx+0x18] */
            ii(0x100c_1f26, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_1f29, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_1f2c, 6); mov(eax, memd[ds, eax + 0x101c_34e8]);  /* mov eax, [eax+0x101c34e8] */
            ii(0x100c_1f32, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1f34, 6); mov(edx, memd[ss, ebp - 188]);          /* mov edx, [ebp-0xbc] */
            ii(0x100c_1f3a, 3); mov(edx, memd[ds, edx + 26]);           /* mov edx, [edx+0x1a] */
            ii(0x100c_1f3d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_1f40, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_1f42, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1f44, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_1f46, 6); mov(eax, memd[ss, ebp - 188]);          /* mov eax, [ebp-0xbc] */
            ii(0x100c_1f4c, 5); call(0x1007_623c, -0x4_bd15);           /* call 0x1007623c */
            ii(0x100c_1f51, 4); mov(ax, memw[ds, eax + 14]);            /* mov ax, [eax+0xe] */
            ii(0x100c_1f55, 3); add(memw[ds, edx], ax);                 /* add [edx], ax */
            ii(0x100c_1f58, 4); movsx(edx, memw[ss, ebp - 32]);         /* movsx edx, word [ebp-0x20] */
            ii(0x100c_1f5c, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100c_1f5f, 6); mov(eax, memd[ss, ebp - 188]);          /* mov eax, [ebp-0xbc] */
            ii(0x100c_1f65, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x100c_1f68, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_1f6b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_1f6e, 6); mov(edx, memd[ds, edx + 0x101c_34ec]);  /* mov edx, [edx+0x101c34ec] */
            ii(0x100c_1f74, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1f76, 6); mov(edx, memd[ss, ebp - 188]);          /* mov edx, [ebp-0xbc] */
            ii(0x100c_1f7c, 3); mov(edx, memd[ds, edx + 26]);           /* mov edx, [edx+0x1a] */
            ii(0x100c_1f7f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_1f82, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_1f84, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1f86, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_1f88, 3); inc(memw[ds, eax]);                     /* inc word [eax] */
        l_0x100c_1f8b:
            ii(0x100c_1f8b, 5); jmp(0x100c_1ecf, -0xc1); goto l_0x100c_1ecf; /* jmp 0x100c1ecf */
        l_0x100c_1f90:
            ii(0x100c_1f90, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_1f94, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_1f97, 5); mov(edx, 0x101c_34e4);                  /* mov edx, 0x101c34e4 */
            ii(0x100c_1f9c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_1f9e, 3); mov(memd[ss, ebp - 20], edx);           /* mov [ebp-0x14], edx */
            ii(0x100c_1fa1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1fa3, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100c_1fa6, 5); call(0x1008_8e4c, -0x3_915f);           /* call 0x10088e4c */
            ii(0x100c_1fab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_1fad, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_1fb0, 5); call(0x100b_9183, -0x8e32);             /* call 0x100b9183 */
            ii(0x100c_1fb5, 2); jmp(0x100c_1fcb, 0x14); goto l_0x100c_1fcb; /* jmp 0x100c1fcb */
        //  ii(0x100c_1fb7, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100c_1fb9, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
        //  ii(0x100c_1fbc, 5); call(0x1008_8e4c, -0x3_9175);           /* call 0x10088e4c */
        //  ii(0x100c_1fc1, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100c_1fc3, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
        //  ii(0x100c_1fc6, 5); call(0x100b_9183, -0x8e48);             /* call 0x100b9183 */
        l_0x100c_1fcb:
            ii(0x100c_1fcb, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_1fce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_1fd0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_1fd1, 1); pop(edi);                               /* pop edi */
            ii(0x100c_1fd2, 1); pop(esi);                               /* pop esi */
            ii(0x100c_1fd3, 1); ret();                                  /* ret */
        }
    }
}
