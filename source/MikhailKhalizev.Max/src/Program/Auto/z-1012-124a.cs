using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_124a-34362cec")]
        public void Method_1012_124a()
        {
            ii(0x1012_124a, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_124f, 5); call(Definitions.sys_check_available_stack_size, 0x4_4afe); /* call 0x10165d52 */
            ii(0x1012_1254, 1); push(ebx);                              /* push ebx */
            ii(0x1012_1255, 1); push(ecx);                              /* push ecx */
            ii(0x1012_1256, 1); push(edx);                              /* push edx */
            ii(0x1012_1257, 1); push(esi);                              /* push esi */
            ii(0x1012_1258, 1); push(edi);                              /* push edi */
            ii(0x1012_1259, 1); push(ebp);                              /* push ebp */
            ii(0x1012_125a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_125c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_1262, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_1269, 2); jmp(0x1012_1271, 6); goto l_0x1012_1271; /* jmp 0x10121271 */
        l_0x1012_126b:
            ii(0x1012_126b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_126e, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x1012_1271:
            ii(0x1012_1271, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_1275, 3); cmp(eax, 0x1e);                         /* cmp eax, 0x1e */
            ii(0x1012_1278, 6); if(jge(0x1012_139d, 0x11f)) goto l_0x1012_139d; /* jge 0x1012139d */
            ii(0x1012_127e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_1282, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_1284, 7); mov(ax, memw[ds, eax + 0x101b_afe4]);   /* mov ax, [eax+0x101bafe4] */
            ii(0x1012_128b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_128e, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_1292, 5); call(Definitions.my_get_res_data_by_id, 0x1_2d41); /* call 0x10133fd8 */
            ii(0x1012_1297, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_129a, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1012_129e, 3); imul(edx, edx, 0x16);                   /* imul edx, edx, 0x16 */
            ii(0x1012_12a1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_12a4, 3); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x1012_12a7, 6); mov(memd[ds, edx + 0x101c_539e], eax);  /* mov [edx+0x101c539e], eax */
            ii(0x1012_12ad, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1012_12b1, 6); if(jz(0x1012_1398, 0xe1)) goto l_0x1012_1398; /* jz 0x10121398 */
            ii(0x1012_12b7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_12ba, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1012_12bd, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_12c1, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_12c4, 6); mov(memd[ds, eax + 0x101c_538c], edx);  /* mov [eax+0x101c538c], edx */
            ii(0x1012_12ca, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_12cd, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1012_12cf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_12d2, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_12d6, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_12d9, 6); mov(memd[ds, eax + 0x101c_5390], edx);  /* mov [eax+0x101c5390], edx */
            ii(0x1012_12df, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_12e2, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1012_12e5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_12e8, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_12ec, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_12ef, 6); mov(memd[ds, eax + 0x101c_5394], edx);  /* mov [eax+0x101c5394], edx */
            ii(0x1012_12f5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_12f8, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1012_12fb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_12fe, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_1302, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_1305, 6); mov(memd[ds, eax + 0x101c_5398], edx);  /* mov [eax+0x101c5398], edx */
            ii(0x1012_130b, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_130f, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_1312, 9); mov(memw[ds, eax + 0x101c_539c], 1);    /* mov word [eax+0x101c539c], 0x1 */
            ii(0x1012_131b, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_131f, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_1322, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1012_1326, 3); imul(edx, edx, 0x16);                   /* imul edx, edx, 0x16 */
            ii(0x1012_1329, 6); mov(edx, memd[ds, edx + 0x101c_538c]);  /* mov edx, [edx+0x101c538c] */
            ii(0x1012_132f, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1012_1331, 6); cmp(edx, memd[ds, eax + 0x101c_5390]);  /* cmp edx, [eax+0x101c5390] */
            ii(0x1012_1337, 2); if(jge(0x1012_1398, 0x5f)) goto l_0x1012_1398; /* jge 0x10121398 */
            ii(0x1012_1339, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1012_133d, 3); imul(edx, edx, 0x16);                   /* imul edx, edx, 0x16 */
            ii(0x1012_1340, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_1344, 3); imul(ebx, ebx, 0x16);                   /* imul ebx, ebx, 0x16 */
            ii(0x1012_1347, 6); mov(edx, memd[ds, edx + 0x101c_5390]);  /* mov edx, [edx+0x101c5390] */
            ii(0x1012_134d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_134f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_1352, 6); idiv(memd[ds, ebx + 0x101c_538c]);      /* idiv dword [ebx+0x101c538c] */
            ii(0x1012_1358, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_135a, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1012_135c, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1012_1360, 3); imul(edx, edx, 0x16);                   /* imul edx, edx, 0x16 */
            ii(0x1012_1363, 7); mov(memw[ds, edx + 0x101c_539c], bx);   /* mov [edx+0x101c539c], bx */
            ii(0x1012_136a, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_136e, 3); imul(ebx, ebx, 0x16);                   /* imul ebx, ebx, 0x16 */
            ii(0x1012_1371, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1012_1375, 3); imul(edx, edx, 0x16);                   /* imul edx, edx, 0x16 */
            ii(0x1012_1378, 6); mov(ecx, memd[ds, edx + 0x101c_539a]);  /* mov ecx, [edx+0x101c539a] */
            ii(0x1012_137e, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1012_1381, 6); mov(eax, memd[ds, ebx + 0x101c_5390]);  /* mov eax, [ebx+0x101c5390] */
            ii(0x1012_1387, 6); mov(edx, memd[ds, ebx + 0x101c_5390]);  /* mov edx, [ebx+0x101c5390] */
            ii(0x1012_138d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_1390, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1012_1392, 6); mov(memd[ds, ebx + 0x101c_5390], eax);  /* mov [ebx+0x101c5390], eax */
        l_0x1012_1398:
            ii(0x1012_1398, 5); jmp(0x1012_126b, -0x132); goto l_0x1012_126b; /* jmp 0x1012126b */
        l_0x1012_139d:
            ii(0x1012_139d, 7); mov(memb[ds, 0x101c_5620], 0x1e);       /* mov byte [0x101c5620], 0x1e */
            ii(0x1012_13a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_13a6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_13a7, 1); pop(edi);                               /* pop edi */
            ii(0x1012_13a8, 1); pop(esi);                               /* pop esi */
            ii(0x1012_13a9, 1); pop(edx);                               /* pop edx */
            ii(0x1012_13aa, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_13ab, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_13ac, 1); ret();                                  /* ret */
        }
    }
}
