using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_1399-db700e3a")]
        public void Method_1015_1399()
        {
            ii(0x1015_1399, 5); push(0x54);                             /* push 0x54 */
            ii(0x1015_139e, 5); call(Definitions.sys_check_available_stack_size, 0x1_49af); /* call 0x10165d52 */
            ii(0x1015_13a3, 1); push(ebx);                              /* push ebx */
            ii(0x1015_13a4, 1); push(ecx);                              /* push ecx */
            ii(0x1015_13a5, 1); push(esi);                              /* push esi */
            ii(0x1015_13a6, 1); push(edi);                              /* push edi */
            ii(0x1015_13a7, 1); push(ebp);                              /* push ebp */
            ii(0x1015_13a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_13aa, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1015_13b0, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_13b3, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_13b6, 4); or(memb[ss, ebp - 12], 1);              /* or byte [ebp-0xc], 0x1 */
            ii(0x1015_13ba, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_13bd, 5); call(Definitions.my_ctor_0x101b_38f8, -0xd_acd2); /* call 0x100766f0 */
            ii(0x1015_13c2, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1015_13c5, 4); and(memb[ss, ebp - 12], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1015_13c9, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1015_13d0, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_13d4, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_13d7, 7); test(memb[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1015_13de, 2); if(jz(0x1015_13f0, 0x10)) goto l_0x1015_13f0; /* jz 0x101513f0 */
            ii(0x1015_13e0, 7); mov(memd[ss, ebp - 20], 0x13);          /* mov dword [ebp-0x14], 0x13 */
            ii(0x1015_13e7, 7); mov(memd[ss, ebp - 24], 0xf);           /* mov dword [ebp-0x18], 0xf */
            ii(0x1015_13ee, 2); jmp(0x1015_13fe, 0xe); goto l_0x1015_13fe; /* jmp 0x101513fe */
        l_0x1015_13f0:
            ii(0x1015_13f0, 7); mov(memd[ss, ebp - 20], 0x14);          /* mov dword [ebp-0x14], 0x14 */
            ii(0x1015_13f7, 7); mov(memd[ss, ebp - 24], 0x10);          /* mov dword [ebp-0x18], 0x10 */
        l_0x1015_13fe:
            ii(0x1015_13fe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_1401, 3); mov(edx, memd[ds, eax + 65]);           /* mov edx, [eax+0x41] */
            ii(0x1015_1404, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_1407, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_140a, 3); mov(eax, memd[ds, eax + 63]);           /* mov eax, [eax+0x3f] */
            ii(0x1015_140d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1410, 5); call(0x1007_3d48, -0xd_d6cd);           /* call 0x10073d48 */
            ii(0x1015_1415, 2); test(al, 6);                            /* test al, 0x6 */
            ii(0x1015_1417, 2); if(jz(0x1015_1421, 8)) goto l_0x1015_1421; /* jz 0x10151421 */
            ii(0x1015_1419, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_141c, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
            ii(0x1015_141f, 2); jmp(0x1015_1471, 0x50); goto l_0x1015_1471; /* jmp 0x10151471 */
        l_0x1015_1421:
            ii(0x1015_1421, 5); call(0x1010_2b84, -0x4_e8a2);           /* call 0x10102b84 */
            ii(0x1015_1426, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_142b, 1); push(eax);                              /* push eax */
            ii(0x1015_142c, 5); call(0x1010_2ba4, -0x4_e88d);           /* call 0x10102ba4 */
            ii(0x1015_1431, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_1436, 1); push(eax);                              /* push eax */
            ii(0x1015_1437, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_1439, 1); push(eax);                              /* push eax */
            ii(0x1015_143a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_143d, 3); mov(eax, memd[ds, eax + 65]);           /* mov eax, [eax+0x41] */
            ii(0x1015_1440, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1443, 1); push(eax);                              /* push eax */
            ii(0x1015_1444, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_1447, 3); mov(eax, memd[ds, eax + 63]);           /* mov eax, [eax+0x3f] */
            ii(0x1015_144a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_144d, 1); push(eax);                              /* push eax */
            ii(0x1015_144e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_1450, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_1453, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1015_1456, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_1458, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_145b, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1015_145f, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1015_1462, 5); call(0x1015_a2da, 0x8e73);              /* call 0x1015a2da */
            ii(0x1015_1467, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1469, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1015_146c, 5); call(0x1007_5f2c, -0xd_b545);           /* call 0x10075f2c */
        l_0x1015_1471:
            ii(0x1015_1471, 5); call(0x1010_2b84, -0x4_e8f2);           /* call 0x10102b84 */
            ii(0x1015_1476, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_147b, 1); push(eax);                              /* push eax */
            ii(0x1015_147c, 5); call(0x1010_2ba4, -0x4_e8dd);           /* call 0x10102ba4 */
            ii(0x1015_1481, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_1486, 1); push(eax);                              /* push eax */
            ii(0x1015_1487, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_148b, 1); push(eax);                              /* push eax */
            ii(0x1015_148c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_148f, 3); mov(eax, memd[ds, eax + 65]);           /* mov eax, [eax+0x41] */
            ii(0x1015_1492, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1495, 1); push(eax);                              /* push eax */
            ii(0x1015_1496, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_1499, 3); mov(eax, memd[ds, eax + 63]);           /* mov eax, [eax+0x3f] */
            ii(0x1015_149c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_149f, 1); push(eax);                              /* push eax */
            ii(0x1015_14a0, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_14a2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_14a5, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1015_14a8, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_14aa, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_14ad, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1015_14b1, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1015_14b4, 5); call(0x1015_a2da, 0x8e21);              /* call 0x1015a2da */
            ii(0x1015_14b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_14bb, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_14be, 5); call(0x1008_ac18, -0xc_68ab);           /* call 0x1008ac18 */
            ii(0x1015_14c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_14c5, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1015_14c8, 5); call(0x1007_5f2c, -0xd_b5a1);           /* call 0x10075f2c */
            ii(0x1015_14cd, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1015_14d0, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_14d3, 5); call(0x1007_6574, -0xd_af64);           /* call 0x10076574 */
            ii(0x1015_14d8, 5); call(0x1008_a998, -0xc_6b45);           /* call 0x1008a998 */
            ii(0x1015_14dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_14df, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_14e2, 5); call(0x1007_5f2c, -0xd_b5bb);           /* call 0x10075f2c */
            ii(0x1015_14e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_14e9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_14ea, 1); pop(edi);                               /* pop edi */
            ii(0x1015_14eb, 1); pop(esi);                               /* pop esi */
            ii(0x1015_14ec, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_14ed, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_14ee, 1); ret();                                  /* ret */
        }
    }
}
