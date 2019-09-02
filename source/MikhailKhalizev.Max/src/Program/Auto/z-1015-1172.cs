using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_1172-5fd35a72")]
        public void Method_1015_1172()
        {
            ii(0x1015_1172, 5); push(0x58);                             /* push 0x58 */
            ii(0x1015_1177, 5); call(Definitions.sys_check_available_stack_size, 0x1_4bd6); /* call 0x10165d52 */
            ii(0x1015_117c, 1); push(ebx);                              /* push ebx */
            ii(0x1015_117d, 1); push(ecx);                              /* push ecx */
            ii(0x1015_117e, 1); push(esi);                              /* push esi */
            ii(0x1015_117f, 1); push(edi);                              /* push edi */
            ii(0x1015_1180, 1); push(ebp);                              /* push ebp */
            ii(0x1015_1181, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_1183, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1015_1189, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_118c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_118f, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_1193, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_1196, 6); mov(eax, memd[ds, eax + 0x101c_81c0]);  /* mov eax, [eax+0x101c81c0] */
            ii(0x1015_119c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_119f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_11a2, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1015_11a5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_11a8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_11ab, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x1015_11ae, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_11b1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_11b4, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1015_11b7, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_11b9, 1); cwde();                                 /* cwde */
            ii(0x1015_11ba, 5); call(0x1007_3f48, -0xd_d277);           /* call 0x10073f48 */
            ii(0x1015_11bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_11c1, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_11c4, 5); call(0x1007_66ac, -0xd_ab1d);           /* call 0x100766ac */
            ii(0x1015_11c9, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_11cc, 5); call(0x1007_6574, -0xd_ac5d);           /* call 0x10076574 */
            ii(0x1015_11d1, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1015_11d4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_11d7, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_11da, 5); call(0x1007_6574, -0xd_ac6b);           /* call 0x10076574 */
            ii(0x1015_11df, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x1015_11e2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_11e5, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1015_11e8, 5); call(0x1007_6aac, -0xd_a741);           /* call 0x10076aac */
            ii(0x1015_11ed, 7); test(memd[ss, ebp - 12], 0x10);         /* test dword [ebp-0xc], 0x10 */
            ii(0x1015_11f4, 6); if(jz(0x1015_12db, 0xe1)) goto l_0x1015_12db; /* jz 0x101512db */
            ii(0x1015_11fa, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1015_11fd, 5); call(Definitions.my_ctor_0x101b_4184, -0xd_a712); /* call 0x10076af0 */
            ii(0x1015_1202, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1015_1205, 4); mov(memw[ss, ebp - 24], ax);            /* mov [ebp-0x18], ax */
            ii(0x1015_1209, 2); jmp(0x1015_1212, 7); goto l_0x1015_1212; /* jmp 0x10151212 */
        l_0x1015_120b:
            ii(0x1015_120b, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1015_120e, 4); inc(memw[ss, ebp - 24]);                /* inc word [ebp-0x18] */
        l_0x1015_1212:
            ii(0x1015_1212, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1015_1216, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1015_121a, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x1015_121d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_121f, 6); if(jge(0x1015_12db, 0xb6)) goto l_0x1015_12db; /* jge 0x101512db */
            ii(0x1015_1225, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x1015_1228, 4); mov(memw[ss, ebp - 22], ax);            /* mov [ebp-0x16], ax */
            ii(0x1015_122c, 2); jmp(0x1015_1235, 7); goto l_0x1015_1235; /* jmp 0x10151235 */
        l_0x1015_122e:
            ii(0x1015_122e, 3); mov(eax, memd[ss, ebp - 22]);           /* mov eax, [ebp-0x16] */
            ii(0x1015_1231, 4); inc(memw[ss, ebp - 22]);                /* inc word [ebp-0x16] */
        l_0x1015_1235:
            ii(0x1015_1235, 4); movsx(eax, memw[ss, ebp - 18]);         /* movsx eax, word [ebp-0x12] */
            ii(0x1015_1239, 4); movsx(edx, memw[ss, ebp - 22]);         /* movsx edx, word [ebp-0x16] */
            ii(0x1015_123d, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x1015_1240, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_1242, 6); if(jge(0x1015_12d6, 0x8e)) goto l_0x1015_12d6; /* jge 0x101512d6 */
            ii(0x1015_1248, 4); movsx(ebx, memw[ss, ebp - 22]);         /* movsx ebx, word [ebp-0x16] */
            ii(0x1015_124c, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1015_1250, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_1255, 5); call(0x1010_3541, -0x4_dd19);           /* call 0x10103541 */
            ii(0x1015_125a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_125c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_125f, 5); call(0x1007_64b8, -0xd_adac);           /* call 0x100764b8 */
            ii(0x1015_1264, 2); jmp(0x1015_126e, 8); goto l_0x1015_126e; /* jmp 0x1015126e */
        l_0x1015_1266:
            ii(0x1015_1266, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_1269, 5); call(0x1007_6bf8, -0xd_a676);           /* call 0x10076bf8 */
        l_0x1015_126e:
            ii(0x1015_126e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1270, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_1273, 5); call(0x1013_ad71, -0x1_6507);           /* call 0x1013ad71 */
            ii(0x1015_1278, 2); test(al, al);                           /* test al, al */
            ii(0x1015_127a, 2); if(jz(0x1015_12c7, 0x4b)) goto l_0x1015_12c7; /* jz 0x101512c7 */
            ii(0x1015_127c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_127f, 5); call(0x1007_63a0, -0xd_aee4);           /* call 0x100763a0 */
            ii(0x1015_1284, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_1289, 2); if(jz(0x1015_129a, 0xf)) goto l_0x1015_129a; /* jz 0x1015129a */
            ii(0x1015_128b, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_128e, 5); call(0x1007_63a0, -0xd_aef3);           /* call 0x100763a0 */
            ii(0x1015_1293, 5); cmp(memw[ds, eax + 8], 0x47);           /* cmp word [eax+0x8], 0x47 */
            ii(0x1015_1298, 2); if(jnz(0x1015_129c, 2)) goto l_0x1015_129c; /* jnz 0x1015129c */
        l_0x1015_129a:
            ii(0x1015_129a, 2); jmp(0x1015_12ab, 0xf); goto l_0x1015_12ab; /* jmp 0x101512ab */
        l_0x1015_129c:
            ii(0x1015_129c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_129f, 5); call(0x1007_63a0, -0xd_af04);           /* call 0x100763a0 */
            ii(0x1015_12a4, 5); cmp(memw[ds, eax + 8], 0x41);           /* cmp word [eax+0x8], 0x41 */
            ii(0x1015_12a9, 2); if(jnz(0x1015_12c5, 0x1a)) goto l_0x1015_12c5; /* jnz 0x101512c5 */
        l_0x1015_12ab:
            ii(0x1015_12ab, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x1015_12ae, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1015_12b1, 5); call(0x1007_5e64, -0xd_b452);           /* call 0x10075e64 */
            ii(0x1015_12b6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_12b8, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_12bb, 5); call(0x1007_63d4, -0xd_aeec);           /* call 0x100763d4 */
            ii(0x1015_12c0, 5); call(0x1015_0faa, -0x31b);              /* call 0x10150faa */
        l_0x1015_12c5:
            ii(0x1015_12c5, 2); jmp(0x1015_1266, -0x61); goto l_0x1015_1266; /* jmp 0x10151266 */
        l_0x1015_12c7:
            ii(0x1015_12c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_12c9, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_12cc, 5); call(0x1007_5f6c, -0xd_b365);           /* call 0x10075f6c */
            ii(0x1015_12d1, 5); jmp(0x1015_122e, -0xa8); goto l_0x1015_122e; /* jmp 0x1015122e */
        l_0x1015_12d6:
            ii(0x1015_12d6, 5); jmp(0x1015_120b, -0xd0); goto l_0x1015_120b; /* jmp 0x1015120b */
        l_0x1015_12db:
            ii(0x1015_12db, 7); test(memd[ss, ebp - 12], 0x100_0000);   /* test dword [ebp-0xc], 0x1000000 */
            ii(0x1015_12e2, 6); if(jz(0x1015_1387, 0x9f)) goto l_0x1015_1387; /* jz 0x10151387 */
            ii(0x1015_12e8, 7); test(memd[ss, ebp - 12], 0x10);         /* test dword [ebp-0xc], 0x10 */
            ii(0x1015_12ef, 2); if(jz(0x1015_12fa, 9)) goto l_0x1015_12fa; /* jz 0x101512fa */
            ii(0x1015_12f1, 7); mov(memd[ss, ebp - 36], 0x11);          /* mov dword [ebp-0x24], 0x11 */
            ii(0x1015_12f8, 2); jmp(0x1015_1301, 7); goto l_0x1015_1301; /* jmp 0x10151301 */
        l_0x1015_12fa:
            ii(0x1015_12fa, 7); mov(memd[ss, ebp - 36], 0x12);          /* mov dword [ebp-0x24], 0x12 */
        l_0x1015_1301:
            ii(0x1015_1301, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1015_1304, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1015_1307, 5); call(0x1010_2b84, -0x4_e788);           /* call 0x10102b84 */
            ii(0x1015_130c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_1311, 1); push(eax);                              /* push eax */
            ii(0x1015_1312, 5); call(0x1010_2ba4, -0x4_e773);           /* call 0x10102ba4 */
            ii(0x1015_1317, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_131c, 1); push(eax);                              /* push eax */
            ii(0x1015_131d, 4); movsx(eax, memw[ss, ebp - 40]);         /* movsx eax, word [ebp-0x28] */
            ii(0x1015_1321, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_1324, 6); mov(eax, memd[ds, eax + 0x101c_81c6]);  /* mov eax, [eax+0x101c81c6] */
            ii(0x1015_132a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_132c, 3); mov(dl, memb[ds, eax + 1]);             /* mov dl, [eax+0x1] */
            ii(0x1015_132f, 5); call(/* sys */ 0x1016_5e9b, 0x1_4b67);  /* call 0x10165e9b */
            ii(0x1015_1334, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1015_1337, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1015_133a, 1); cwde();                                 /* cwde */
            ii(0x1015_133b, 1); push(eax);                              /* push eax */
            ii(0x1015_133c, 4); movsx(eax, memw[ss, ebp - 18]);         /* movsx eax, word [ebp-0x12] */
            ii(0x1015_1340, 1); push(eax);                              /* push eax */
            ii(0x1015_1341, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1015_1345, 1); push(eax);                              /* push eax */
            ii(0x1015_1346, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_1348, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1015_134b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_134d, 3); mov(al, memb[ds, edx + 38]);            /* mov al, [edx+0x26] */
            ii(0x1015_1350, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_1353, 4); movsx(edx, memw[ss, ebp - 40]);         /* movsx edx, word [ebp-0x28] */
            ii(0x1015_1357, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1015_135a, 5); call(0x1015_a2da, 0x8f7b);              /* call 0x1015a2da */
            ii(0x1015_135f, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1015_1362, 5); call(0x1007_6574, -0xd_adf3);           /* call 0x10076574 */
            ii(0x1015_1367, 4); mov(memb[ds, eax + 45], 4);             /* mov byte [eax+0x2d], 0x4 */
            ii(0x1015_136b, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_1370, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1015_1373, 5); call(0x1007_6600, -0xd_ad78);           /* call 0x10076600 */
            ii(0x1015_1378, 5); call(0x1016_2f0a, 0x1_1b8d);            /* call 0x10162f0a */
            ii(0x1015_137d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_137f, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1015_1382, 5); call(0x1007_5f2c, -0xd_b45b);           /* call 0x10075f2c */
        l_0x1015_1387:
            ii(0x1015_1387, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1389, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_138c, 5); call(0x1007_5f2c, -0xd_b465);           /* call 0x10075f2c */
            ii(0x1015_1391, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_1393, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_1394, 1); pop(edi);                               /* pop edi */
            ii(0x1015_1395, 1); pop(esi);                               /* pop esi */
            ii(0x1015_1396, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_1397, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_1398, 1); ret();                                  /* ret */
        }
    }
}
