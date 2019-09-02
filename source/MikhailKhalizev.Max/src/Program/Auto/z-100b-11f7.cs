using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_11f7-9b375aeb")]
        public void Method_100b_11f7()
        {
            ii(0x100b_11f7, 5); push(0x80);                             /* push 0x80 */
            ii(0x100b_11fc, 5); call(Definitions.sys_check_available_stack_size, 0xb_4b51); /* call 0x10165d52 */
            ii(0x100b_1201, 1); push(esi);                              /* push esi */
            ii(0x100b_1202, 1); push(edi);                              /* push edi */
            ii(0x100b_1203, 1); push(ebp);                              /* push ebp */
            ii(0x100b_1204, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1206, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x100b_120c, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100b_120f, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100b_1212, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100b_1215, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100b_1218, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x100b_121f, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x100b_1222, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_1225, 5); call(0x100a_2d3d, -0xe4ed);             /* call 0x100a2d3d */
        l_0x100b_122a:
            ii(0x100b_122a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_122d, 5); call(0x1007_6b90, -0x3_a6a2);           /* call 0x10076b90 */
            ii(0x100b_1232, 1); cwde();                                 /* cwde */
            ii(0x100b_1233, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1235, 6); if(jz(0x100b_1335, 0xfa)) goto l_0x100b_1335; /* jz 0x100b1335 */
            ii(0x100b_123b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_123e, 5); call(0x100b_7c44, 0x6a01);              /* call 0x100b7c44 */
            ii(0x100b_1243, 3); lea(ebx, memd[ss, ebp - 36]);           /* lea ebx, [ebp-0x24] */
            ii(0x100b_1246, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1248, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_124a, 5); call(0x100b_7b28, 0x68d9);              /* call 0x100b7b28 */
            ii(0x100b_124f, 4); or(memb[ss, ebp - 20], 1);              /* or byte [ebp-0x14], 0x1 */
            ii(0x100b_1253, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100b_1256, 5); call(0x1008_a634, -0x2_6c27);           /* call 0x1008a634 */
            ii(0x100b_125b, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100b_125e, 4); and(memb[ss, ebp - 20], -2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x100b_1262, 2); jmp(0x100b_126c, 8); goto l_0x100b_126c; /* jmp 0x100b126c */
        l_0x100b_1264:
            ii(0x100b_1264, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x100b_1267, 5); call(0x1007_6bf8, -0x3_a674);           /* call 0x10076bf8 */
        l_0x100b_126c:
            ii(0x100b_126c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_126e, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x100b_1271, 5); call(0x1013_ad71, 0x8_9afb);            /* call 0x1013ad71 */
            ii(0x100b_1276, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1278, 2); if(jz(0x100b_12d4, 0x5a)) goto l_0x100b_12d4; /* jz 0x100b12d4 */
            ii(0x100b_127a, 3); lea(edx, memd[ss, ebp - 48]);           /* lea edx, [ebp-0x30] */
            ii(0x100b_127d, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x100b_1280, 5); call(0x100b_7a14, 0x678f);              /* call 0x100b7a14 */
            ii(0x100b_1285, 5); call(0x100a_ca34, -0x4856);             /* call 0x100aca34 */
            ii(0x100b_128a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_128c, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x100b_128f, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100b_1292, 5); call(0x1007_5e64, -0x3_b433);           /* call 0x10075e64 */
            ii(0x100b_1297, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_1299, 5); call(0x100a_5fca, -0xb2d4);             /* call 0x100a5fca */
            ii(0x100b_129e, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100b_12a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_12a3, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100b_12a6, 5); call(0x1013_ad11, 0x8_9a66);            /* call 0x1013ad11 */
            ii(0x100b_12ab, 2); test(al, al);                           /* test al, al */
            ii(0x100b_12ad, 2); if(jnz(0x100b_12b8, 9)) goto l_0x100b_12b8; /* jnz 0x100b12b8 */
            ii(0x100b_12af, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100b_12b2, 4); cmp(ax, memw[ss, ebp - 60]);            /* cmp ax, [ebp-0x3c] */
            ii(0x100b_12b6, 2); if(jge(0x100b_12d2, 0x1a)) goto l_0x100b_12d2; /* jge 0x100b12d2 */
        l_0x100b_12b8:
            ii(0x100b_12b8, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100b_12bb, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x100b_12be, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x100b_12c1, 5); call(0x100b_7a48, 0x6782);              /* call 0x100b7a48 */
            ii(0x100b_12c6, 3); lea(ebx, memd[ss, ebp - 40]);           /* lea ebx, [ebp-0x28] */
            ii(0x100b_12c9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_12cb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_12cd, 5); call(0x100b_7cfc, 0x6a2a);              /* call 0x100b7cfc */
        l_0x100b_12d2:
            ii(0x100b_12d2, 2); jmp(0x100b_1264, -0x70); goto l_0x100b_1264; /* jmp 0x100b1264 */
        l_0x100b_12d4:
            ii(0x100b_12d4, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x100b_12d7, 3); add(memd[ss, ebp - 24], eax);           /* add [ebp-0x18], eax */
            ii(0x100b_12da, 3); lea(edx, memd[ss, ebp - 64]);           /* lea edx, [ebp-0x40] */
            ii(0x100b_12dd, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100b_12e0, 5); call(0x1008_a520, -0x2_6dc5);           /* call 0x1008a520 */
            ii(0x100b_12e5, 5); call(0x100a_ca34, -0x48b6);             /* call 0x100aca34 */
            ii(0x100b_12ea, 3); lea(ebx, memd[ss, ebp - 32]);           /* lea ebx, [ebp-0x20] */
            ii(0x100b_12ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_12ef, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_12f1, 5); call(0x1008_8b44, -0x2_87b2);           /* call 0x10088b44 */
            ii(0x100b_12f6, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100b_12f9, 5); call(0x1008_a57c, -0x2_6d82);           /* call 0x1008a57c */
            ii(0x100b_12fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1300, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_1303, 5); call(0x100b_7bac, 0x68a4);              /* call 0x100b7bac */
            ii(0x100b_1308, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100b_130b, 5); call(0x1008_a57c, -0x2_6d94);           /* call 0x1008a57c */
            ii(0x100b_1310, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100b_1313, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1315, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1317, 5); call(0x100b_7c14, 0x68f8);              /* call 0x100b7c14 */
            ii(0x100b_131c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_131e, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100b_1321, 5); call(0x1008_8d4c, -0x2_85da);           /* call 0x10088d4c */
            ii(0x100b_1326, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1328, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x100b_132b, 5); call(0x100b_7650, 0x6320);              /* call 0x100b7650 */
            ii(0x100b_1330, 5); jmp(0x100b_122a, -0x10b); goto l_0x100b_122a; /* jmp 0x100b122a */
        l_0x100b_1335:
            ii(0x100b_1335, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1338, 5); call(0x1007_6b90, -0x3_a7ad);           /* call 0x10076b90 */
            ii(0x100b_133d, 1); cwde();                                 /* cwde */
            ii(0x100b_133e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1340, 6); if(jz(0x100b_142a, 0xe4)) goto l_0x100b_142a; /* jz 0x100b142a */
            ii(0x100b_1346, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1349, 5); call(0x100b_7c44, 0x68f6);              /* call 0x100b7c44 */
            ii(0x100b_134e, 3); lea(ebx, memd[ss, ebp - 68]);           /* lea ebx, [ebp-0x44] */
            ii(0x100b_1351, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1353, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1355, 5); call(0x100b_7b28, 0x67ce);              /* call 0x100b7b28 */
            ii(0x100b_135a, 4); or(memb[ss, ebp - 20], 1);              /* or byte [ebp-0x14], 0x1 */
            ii(0x100b_135e, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100b_1361, 5); call(0x1008_a634, -0x2_6d32);           /* call 0x1008a634 */
            ii(0x100b_1366, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x100b_1369, 4); and(memb[ss, ebp - 20], -2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x100b_136d, 2); jmp(0x100b_1377, 8); goto l_0x100b_1377; /* jmp 0x100b1377 */
        l_0x100b_136f:
            ii(0x100b_136f, 3); lea(eax, memd[ss, ebp - 68]);           /* lea eax, [ebp-0x44] */
            ii(0x100b_1372, 5); call(0x1007_6bf8, -0x3_a77f);           /* call 0x10076bf8 */
        l_0x100b_1377:
            ii(0x100b_1377, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1379, 3); lea(eax, memd[ss, ebp - 68]);           /* lea eax, [ebp-0x44] */
            ii(0x100b_137c, 5); call(0x1013_ad71, 0x8_99f0);            /* call 0x1013ad71 */
            ii(0x100b_1381, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1383, 2); if(jz(0x100b_13df, 0x5a)) goto l_0x100b_13df; /* jz 0x100b13df */
            ii(0x100b_1385, 3); lea(edx, memd[ss, ebp - 80]);           /* lea edx, [ebp-0x50] */
            ii(0x100b_1388, 3); lea(eax, memd[ss, ebp - 68]);           /* lea eax, [ebp-0x44] */
            ii(0x100b_138b, 5); call(0x100b_7a14, 0x6684);              /* call 0x100b7a14 */
            ii(0x100b_1390, 5); call(0x100b_7da0, 0x6a0b);              /* call 0x100b7da0 */
            ii(0x100b_1395, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_1397, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x100b_139a, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x100b_139d, 5); call(0x1007_5e64, -0x3_b53e);           /* call 0x10075e64 */
            ii(0x100b_13a2, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_13a4, 5); call(0x100a_5fca, -0xb3df);             /* call 0x100a5fca */
            ii(0x100b_13a9, 3); mov(memd[ss, ebp - 88], eax);           /* mov [ebp-0x58], eax */
            ii(0x100b_13ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_13ae, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100b_13b1, 5); call(0x1013_ad11, 0x8_995b);            /* call 0x1013ad11 */
            ii(0x100b_13b6, 2); test(al, al);                           /* test al, al */
            ii(0x100b_13b8, 2); if(jnz(0x100b_13c3, 9)) goto l_0x100b_13c3; /* jnz 0x100b13c3 */
            ii(0x100b_13ba, 3); mov(eax, memd[ss, ebp - 88]);           /* mov eax, [ebp-0x58] */
            ii(0x100b_13bd, 4); cmp(ax, memw[ss, ebp - 92]);            /* cmp ax, [ebp-0x5c] */
            ii(0x100b_13c1, 2); if(jge(0x100b_13dd, 0x1a)) goto l_0x100b_13dd; /* jge 0x100b13dd */
        l_0x100b_13c3:
            ii(0x100b_13c3, 3); mov(eax, memd[ss, ebp - 88]);           /* mov eax, [ebp-0x58] */
            ii(0x100b_13c6, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
            ii(0x100b_13c9, 3); lea(eax, memd[ss, ebp - 68]);           /* lea eax, [ebp-0x44] */
            ii(0x100b_13cc, 5); call(0x100b_7a48, 0x6677);              /* call 0x100b7a48 */
            ii(0x100b_13d1, 3); lea(ebx, memd[ss, ebp - 72]);           /* lea ebx, [ebp-0x48] */
            ii(0x100b_13d4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_13d6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_13d8, 5); call(0x100b_7cfc, 0x691f);              /* call 0x100b7cfc */
        l_0x100b_13dd:
            ii(0x100b_13dd, 2); jmp(0x100b_136f, -0x70); goto l_0x100b_136f; /* jmp 0x100b136f */
        l_0x100b_13df:
            ii(0x100b_13df, 3); mov(eax, memd[ss, ebp - 92]);           /* mov eax, [ebp-0x5c] */
            ii(0x100b_13e2, 3); add(memd[ss, ebp - 24], eax);           /* add [ebp-0x18], eax */
            ii(0x100b_13e5, 3); lea(edx, memd[ss, ebp - 96]);           /* lea edx, [ebp-0x60] */
            ii(0x100b_13e8, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100b_13eb, 5); call(0x1008_a520, -0x2_6ed0);           /* call 0x1008a520 */
            ii(0x100b_13f0, 5); call(0x100b_7da0, 0x69ab);              /* call 0x100b7da0 */
            ii(0x100b_13f5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_13f7, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x100b_13fa, 5); call(0x1008_8b44, -0x2_88bb);           /* call 0x10088b44 */
            ii(0x100b_13ff, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100b_1402, 5); call(0x1008_a57c, -0x2_6e8b);           /* call 0x1008a57c */
            ii(0x100b_1407, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1409, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_140c, 5); call(0x100b_7bac, 0x679b);              /* call 0x100b7bac */
            ii(0x100b_1411, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1413, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100b_1416, 5); call(0x1008_8d4c, -0x2_86cf);           /* call 0x10088d4c */
            ii(0x100b_141b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_141d, 3); lea(eax, memd[ss, ebp - 68]);           /* lea eax, [ebp-0x44] */
            ii(0x100b_1420, 5); call(0x100b_7650, 0x622b);              /* call 0x100b7650 */
            ii(0x100b_1425, 5); jmp(0x100b_1335, -0xf5); goto l_0x100b_1335; /* jmp 0x100b1335 */
        l_0x100b_142a:
            ii(0x100b_142a, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100b_142e, 2); if(jz(0x100b_1475, 0x45)) goto l_0x100b_1475; /* jz 0x100b1475 */
            ii(0x100b_1430, 3); lea(edx, memd[ss, ebp - 100]);          /* lea edx, [ebp-0x64] */
            ii(0x100b_1433, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1436, 5); call(0x100a_ca34, -0x4a07);             /* call 0x100aca34 */
            ii(0x100b_143b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_143d, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x100b_1440, 3); lea(eax, memd[ss, ebp - 104]);          /* lea eax, [ebp-0x68] */
            ii(0x100b_1443, 5); call(0x1007_5e64, -0x3_b5e4);           /* call 0x10075e64 */
            ii(0x100b_1448, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_144a, 5); call(0x100a_5fca, -0xb485);             /* call 0x100a5fca */
            ii(0x100b_144f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_1451, 3); lea(edx, memd[ss, ebp - 108]);          /* lea edx, [ebp-0x6c] */
            ii(0x100b_1454, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1457, 5); call(0x100b_7da0, 0x6944);              /* call 0x100b7da0 */
            ii(0x100b_145c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_145e, 3); lea(edx, memd[ss, ebp - 112]);          /* lea edx, [ebp-0x70] */
            ii(0x100b_1461, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1464, 5); call(0x100a_ca34, -0x4a35);             /* call 0x100aca34 */
            ii(0x100b_1469, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_146b, 5); call(0x100a_5fca, -0xb4a6);             /* call 0x100a5fca */
            ii(0x100b_1470, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100b_1472, 3); add(memd[ss, ebp - 24], eax);           /* add [ebp-0x18], eax */
        l_0x100b_1475:
            ii(0x100b_1475, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100b_1478, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100b_147b, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100b_147e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_1480, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_1481, 1); pop(edi);                               /* pop edi */
            ii(0x100b_1482, 1); pop(esi);                               /* pop esi */
            ii(0x100b_1483, 1); ret();                                  /* ret */
        }
    }
}
