using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_114f-94af794a")]
        public void Method_1007_114f()
        {
            ii(0x1007_114f, 5); push(0x40);                             /* push 0x40 */
            ii(0x1007_1154, 5); call(Definitions.sys_check_available_stack_size, 0xf_4bf9); /* call 0x10165d52 */
            ii(0x1007_1159, 1); push(ecx);                              /* push ecx */
            ii(0x1007_115a, 1); push(esi);                              /* push esi */
            ii(0x1007_115b, 1); push(edi);                              /* push edi */
            ii(0x1007_115c, 1); push(ebp);                              /* push ebp */
            ii(0x1007_115d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_115f, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1007_1165, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_1168, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1007_116b, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1007_116e, 4); or(memb[ss, ebp - 0x10], 1);            /* or byte [ebp-0x10], 0x1 */
            ii(0x1007_1172, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1175, 5); call(0x1007_64fc, 0x5382);              /* call 0x100764fc */
            ii(0x1007_117a, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_117d, 4); and(memb[ss, ebp - 0x10], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1007_1181, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_1183, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_1186, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1007_1189, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_118c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_118f, 8); imul(ax, memw[ds, 0x101c_8172]);        /* imul ax, [0x101c8172] */
            ii(0x1007_1197, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_119a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_119c, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1007_119f, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_11a6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_11a9, 5); cmp(memw[ds, eax + 8], 0x45);           /* cmp word [eax+0x8], 0x45 */
            ii(0x1007_11ae, 6); if(jnz(0x1007_1257, 0xa3)) goto l_0x1007_1257; /* jnz 0x10071257 */
            ii(0x1007_11b4, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1007_11b8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_11be, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_11c2, 6); mov(eax, memd[ds, eax + 0x101c_a6a7]);  /* mov eax, [eax+0x101ca6a7] */
            ii(0x1007_11c8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_11ca, 2); inc(memb[ds, eax]);                     /* inc byte [eax] */
            ii(0x1007_11cc, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1007_11ce, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_11d3, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1007_11d6, 6); if(jnz(0x1007_1257, 0x7b)) goto l_0x1007_1257; /* jnz 0x10071257 */
            ii(0x1007_11dc, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_11e0, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1007_11e4, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_11e9, 5); call(0x1010_3541, 0x9_2353);            /* call 0x10103541 */
            ii(0x1007_11ee, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_11f0, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_11f3, 5); call(0x1007_643c, 0x5244);              /* call 0x1007643c */
            ii(0x1007_11f8, 2); jmp(0x1007_1202, 8); goto l_0x1007_1202; /* jmp 0x10071202 */
        l_0x1007_11fa:
            ii(0x1007_11fa, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_11fd, 5); call(0x1007_6bf8, 0x59f6);              /* call 0x10076bf8 */
        l_0x1007_1202:
            ii(0x1007_1202, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_1204, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1207, 5); call(0x1013_ad71, 0xc_9b65);            /* call 0x1013ad71 */
            ii(0x1007_120c, 2); test(al, al);                           /* test al, al */
            ii(0x1007_120e, 2); if(jz(0x1007_1257, 0x47)) goto l_0x1007_1257; /* jz 0x10071257 */
            ii(0x1007_1210, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1213, 5); call(0x1007_63d4, 0x51bc);              /* call 0x100763d4 */
            ii(0x1007_1218, 5); call(0x1016_433b, 0xf_311e);            /* call 0x1016433b */
            ii(0x1007_121d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_121f, 2); if(jz(0x1007_1255, 0x34)) goto l_0x1007_1255; /* jz 0x10071255 */
            ii(0x1007_1221, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_1225, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1228, 5); call(0x1007_63a0, 0x5173);              /* call 0x100763a0 */
            ii(0x1007_122d, 5); call(0x1014_f634, 0xd_e402);            /* call 0x1014f634 */
            ii(0x1007_1232, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1235, 5); call(0x1007_63a0, 0x5166);              /* call 0x100763a0 */
            ii(0x1007_123a, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_123d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_1240, 3); cmp(dl, memb[ds, eax + 0x26]);          /* cmp dl, [eax+0x26] */
            ii(0x1007_1243, 2); if(jz(0x1007_1255, 0x10)) goto l_0x1007_1255; /* jz 0x10071255 */
            ii(0x1007_1245, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1248, 5); call(0x1007_63d4, 0x5187);              /* call 0x100763d4 */
            ii(0x1007_124d, 5); call(0x1007_1031, -0x221);              /* call 0x10071031 */
            ii(0x1007_1252, 3); or(memd[ss, ebp - 0x18], eax);          /* or [ebp-0x18], eax */
        l_0x1007_1255:
            ii(0x1007_1255, 2); jmp(0x1007_11fa, -0x5d); goto l_0x1007_11fa; /* jmp 0x100711fa */
        l_0x1007_1257:
            ii(0x1007_1257, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_125a, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_125f, 2); if(jz(0x1007_126f, 0xe)) goto l_0x1007_126f; /* jz 0x1007126f */
            ii(0x1007_1261, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_1264, 5); cmp(memw[ds, eax + 8], 0x43);           /* cmp word [eax+0x8], 0x43 */
            ii(0x1007_1269, 6); if(jnz(0x1007_1310, 0xa1)) goto l_0x1007_1310; /* jnz 0x10071310 */
        l_0x1007_126f:
            ii(0x1007_126f, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1007_1273, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_1279, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_127d, 6); mov(eax, memd[ds, eax + 0x101c_a6ab]);  /* mov eax, [eax+0x101ca6ab] */
            ii(0x1007_1283, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_1285, 2); inc(memb[ds, eax]);                     /* inc byte [eax] */
            ii(0x1007_1287, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1007_1289, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_128e, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1007_1291, 6); if(jnz(0x1007_1310, 0x79)) goto l_0x1007_1310; /* jnz 0x10071310 */
            ii(0x1007_1297, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_129b, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1007_129f, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_12a4, 5); call(0x1010_3541, 0x9_2298);            /* call 0x10103541 */
            ii(0x1007_12a9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_12ab, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_12ae, 5); call(0x1007_643c, 0x5189);              /* call 0x1007643c */
            ii(0x1007_12b3, 2); jmp(0x1007_12bd, 8); goto l_0x1007_12bd; /* jmp 0x100712bd */
        l_0x1007_12b5:
            ii(0x1007_12b5, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_12b8, 5); call(0x1007_6bf8, 0x593b);              /* call 0x10076bf8 */
        l_0x1007_12bd:
            ii(0x1007_12bd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_12bf, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_12c2, 5); call(0x1013_ad71, 0xc_9aaa);            /* call 0x1013ad71 */
            ii(0x1007_12c7, 2); test(al, al);                           /* test al, al */
            ii(0x1007_12c9, 2); if(jz(0x1007_1310, 0x45)) goto l_0x1007_1310; /* jz 0x10071310 */
            ii(0x1007_12cb, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_12ce, 5); call(0x1007_63a0, 0x50cd);              /* call 0x100763a0 */
            ii(0x1007_12d3, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_12d8, 2); if(jnz(0x1007_130e, 0x34)) goto l_0x1007_130e; /* jnz 0x1007130e */
            ii(0x1007_12da, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_12de, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_12e1, 5); call(0x1007_63a0, 0x50ba);              /* call 0x100763a0 */
            ii(0x1007_12e6, 5); call(0x1014_f634, 0xd_e349);            /* call 0x1014f634 */
            ii(0x1007_12eb, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_12ee, 5); call(0x1007_63a0, 0x50ad);              /* call 0x100763a0 */
            ii(0x1007_12f3, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_12f6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_12f9, 3); cmp(dl, memb[ds, eax + 0x26]);          /* cmp dl, [eax+0x26] */
            ii(0x1007_12fc, 2); if(jz(0x1007_130e, 0x10)) goto l_0x1007_130e; /* jz 0x1007130e */
            ii(0x1007_12fe, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1301, 5); call(0x1007_63d4, 0x50ce);              /* call 0x100763d4 */
            ii(0x1007_1306, 5); call(0x1007_1031, -0x2da);              /* call 0x10071031 */
            ii(0x1007_130b, 3); or(memd[ss, ebp - 0x18], eax);          /* or [ebp-0x18], eax */
        l_0x1007_130e:
            ii(0x1007_130e, 2); jmp(0x1007_12b5, -0x5b); goto l_0x1007_12b5; /* jmp 0x100712b5 */
        l_0x1007_1310:
            ii(0x1007_1310, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1007_1314, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_131a, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_131e, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x1007_1324, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_1326, 2); inc(memb[ds, eax]);                     /* inc byte [eax] */
            ii(0x1007_1328, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1007_132a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_132f, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1007_1332, 6); if(jnz(0x1007_1410, 0xd8)) goto l_0x1007_1410; /* jnz 0x10071410 */
            ii(0x1007_1338, 4); movsx(ecx, memw[ss, ebp - 0x20]);       /* movsx ecx, word [ebp-0x20] */
            ii(0x1007_133c, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_1340, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1007_1344, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_1347, 5); call(0x1007_6aac, 0x5760);              /* call 0x10076aac */
            ii(0x1007_134c, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1007_134e, 5); call(0x100a_91d7, 0x3_7e84);            /* call 0x100a91d7 */
            ii(0x1007_1353, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_1357, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_1359, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1007_135e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_1360, 2); if(jnz(0x1007_137c, 0x1a)) goto l_0x1007_137c; /* jnz 0x1007137c */
            ii(0x1007_1362, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_1366, 5); mov(eax, memd[ds, 0x101c_70e8]);        /* mov eax, [0x101c70e8] */
            ii(0x1007_136b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_136d, 4); movsx(ebx, memw[ss, ebp - 0x14]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x1007_1371, 5); mov(eax, memd[ds, 0x101c_70e0]);        /* mov eax, [0x101c70e0] */
            ii(0x1007_1376, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_1378, 2); mov(dl, memb[ds, edx]);                 /* mov dl, [edx] */
            ii(0x1007_137a, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
        l_0x1007_137c:
            ii(0x1007_137c, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_1380, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1007_1384, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_1389, 5); call(0x1010_3541, 0x9_21b3);            /* call 0x10103541 */
            ii(0x1007_138e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_1390, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1393, 5); call(0x1007_643c, 0x50a4);              /* call 0x1007643c */
            ii(0x1007_1398, 2); jmp(0x1007_13a2, 8); goto l_0x1007_13a2; /* jmp 0x100713a2 */
        l_0x1007_139a:
            ii(0x1007_139a, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_139d, 5); call(0x1007_6bf8, 0x5856);              /* call 0x10076bf8 */
        l_0x1007_13a2:
            ii(0x1007_13a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_13a4, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_13a7, 5); call(0x1013_ad71, 0xc_99c5);            /* call 0x1013ad71 */
            ii(0x1007_13ac, 2); test(al, al);                           /* test al, al */
            ii(0x1007_13ae, 2); if(jz(0x1007_1410, 0x60)) goto l_0x1007_1410; /* jz 0x10071410 */
            ii(0x1007_13b0, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_13b4, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_13b7, 5); call(0x1007_63a0, 0x4fe4);              /* call 0x100763a0 */
            ii(0x1007_13bc, 5); call(0x1007_6074, 0x4cb3);              /* call 0x10076074 */
            ii(0x1007_13c1, 2); test(al, al);                           /* test al, al */
            ii(0x1007_13c3, 2); if(jnz(0x1007_140e, 0x49)) goto l_0x1007_140e; /* jnz 0x1007140e */
            ii(0x1007_13c5, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_13c9, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_13cc, 5); call(0x1007_63a0, 0x4fcf);              /* call 0x100763a0 */
            ii(0x1007_13d1, 5); call(0x1014_f432, 0xd_e05c);            /* call 0x1014f432 */
            ii(0x1007_13d6, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_13da, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_13dd, 5); call(0x1007_63a0, 0x4fbe);              /* call 0x100763a0 */
            ii(0x1007_13e2, 5); call(0x1007_6074, 0x4c8d);              /* call 0x10076074 */
            ii(0x1007_13e7, 2); test(al, al);                           /* test al, al */
            ii(0x1007_13e9, 2); if(jz(0x1007_140e, 0x23)) goto l_0x1007_140e; /* jz 0x1007140e */
            ii(0x1007_13eb, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_13ee, 5); call(0x1007_63a0, 0x4fad);              /* call 0x100763a0 */
            ii(0x1007_13f3, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_13f6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_13f9, 3); cmp(dl, memb[ds, eax + 0x26]);          /* cmp dl, [eax+0x26] */
            ii(0x1007_13fc, 2); if(jz(0x1007_140e, 0x10)) goto l_0x1007_140e; /* jz 0x1007140e */
            ii(0x1007_13fe, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_1401, 5); call(0x1007_63d4, 0x4fce);              /* call 0x100763d4 */
            ii(0x1007_1406, 5); call(0x1007_1031, -0x3da);              /* call 0x10071031 */
            ii(0x1007_140b, 3); or(memd[ss, ebp - 0x18], eax);          /* or [ebp-0x18], eax */
        l_0x1007_140e:
            ii(0x1007_140e, 2); jmp(0x1007_139a, -0x76); goto l_0x1007_139a; /* jmp 0x1007139a */
        l_0x1007_1410:
            ii(0x1007_1410, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_1413, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_1416, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_1418, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_141b, 5); call(0x1007_5f6c, 0x4b4c);              /* call 0x10075f6c */
            ii(0x1007_1420, 2); jmp(0x1007_142c, 0xa); goto l_0x1007_142c; /* jmp 0x1007142c */
        //  ii(0x1007_1422, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_1424, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
        //  ii(0x1007_1427, 5); call(0x1007_5f6c, 0x4b40);              /* call 0x10075f6c */
        l_0x1007_142c:
            ii(0x1007_142c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_142f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1431, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_1432, 1); pop(edi);                               /* pop edi */
            ii(0x1007_1433, 1); pop(esi);                               /* pop esi */
            ii(0x1007_1434, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_1435, 1); ret();                                  /* ret */
        }
    }
}
