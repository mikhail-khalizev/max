using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e01b5889-6adf-493d-a60c-7bca2df8dccc")]
        public void Method_1010_11ff()
        {
            ii(0x1010_11ff, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_1204, 5); calld(Definitions.sys_check_available_stack_size, 0x64b49); /* call 0x10165d52 */
            ii(0x1010_1209, 1); pushd(esi);                             /* push esi */
            ii(0x1010_120a, 1); pushd(edi);                             /* push edi */
            ii(0x1010_120b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_120c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_120e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_1214, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_1217, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_121a, 3); mov(memd_a32[ss, ebp - 0x10], ebx);     /* mov [ebp-0x10], ebx */
            ii(0x1010_121d, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1010_1220, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_1223, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_1226, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1229, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_122b, 2); if(jld(0x1010_123a, 0xd)) goto l_0x1010_123a; /* jl 0x1010123a */
            ii(0x1010_122d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_1230, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1010_1233, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1236, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_1238, 2); if(jged(0x1010_123c, 0x2)) goto l_0x1010_123c; /* jge 0x1010123c */
        l_0x1010_123a:
            ii(0x1010_123a, 2); jmpd(0x1010_1249, 0xd); goto l_0x1010_1249; /* jmp 0x10101249 */
        l_0x1010_123c:
            ii(0x1010_123c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_123f, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1010_1242, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1245, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_1247, 2); if(jged(0x1010_124b, 0x2)) goto l_0x1010_124b; /* jge 0x1010124b */
        l_0x1010_1249:
            ii(0x1010_1249, 2); jmpd(0x1010_1258, 0xd); goto l_0x1010_1258; /* jmp 0x10101258 */
        l_0x1010_124b:
            ii(0x1010_124b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_124e, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1010_1251, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1254, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_1256, 2); if(jged(0x1010_125a, 0x2)) goto l_0x1010_125a; /* jge 0x1010125a */
        l_0x1010_1258:
            ii(0x1010_1258, 2); jmpd(0x1010_126b, 0x11); goto l_0x1010_126b; /* jmp 0x1010126b */
        l_0x1010_125a:
            ii(0x1010_125a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_125d, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1010_1260, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1263, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_1265, 6); if(jged(0x1010_131c, 0xb1)) goto l_0x1010_131c; /* jge 0x1010131c */
        l_0x1010_126b:
            ii(0x1010_126b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_126f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_1275, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1010_127b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1280, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_1283, 2); if(jzd(0x1010_128c, 0x7)) goto l_0x1010_128c; /* jz 0x1010128c */
            ii(0x1010_1285, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_128c:
            ii(0x1010_128c, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_1290, 6); if(jzd(0x1010_1313, 0x7d)) goto l_0x1010_1313; /* jz 0x10101313 */
            ii(0x1010_1296, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_1298, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1010_129d, 5); calld(0x1013_ad71, 0x39acf);            /* call 0x1013ad71 */
            ii(0x1010_12a2, 2); test(al, al);                           /* test al, al */
            ii(0x1010_12a4, 2); if(jzd(0x1010_12c0, 0x1a)) goto l_0x1010_12c0; /* jz 0x101012c0 */
            ii(0x1010_12a6, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_12aa, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_12b0, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1010_12b6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_12bb, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_12be, 2); if(jzd(0x1010_12c2, 0x2)) goto l_0x1010_12c2; /* jz 0x101012c2 */
        l_0x1010_12c0:
            ii(0x1010_12c0, 2); jmpd(0x1010_12d6, 0x14); goto l_0x1010_12d6; /* jmp 0x101012d6 */
        l_0x1010_12c2:
            ii(0x1010_12c2, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1010_12c7, 5); calld(0x1007_6574, -0x8ad58);           /* call 0x10076574 */
            ii(0x1010_12cc, 5); calld(0x1007_6204, -0x8b0cd);           /* call 0x10076204 */
            ii(0x1010_12d1, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1010_12d4, 2); if(jzd(0x1010_12d8, 0x2)) goto l_0x1010_12d8; /* jz 0x101012d8 */
        l_0x1010_12d6:
            ii(0x1010_12d6, 2); jmpd(0x1010_12f7, 0x1f); goto l_0x1010_12f7; /* jmp 0x101012f7 */
        l_0x1010_12d8:
            ii(0x1010_12d8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_12da, 3); mov(cl, memb_a32[ss, ebp - 0x10]);      /* mov cl, [ebp-0x10] */
            ii(0x1010_12dd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1010_12e2, 5); calld(0x1007_6600, -0x8ace7);           /* call 0x10076600 */
            ii(0x1010_12e7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_12e9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_12ec, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_12f0, 5); calld(0x100a_1ea3, -0x5f452);           /* call 0x100a1ea3 */
            ii(0x1010_12f5, 2); jmpd(0x1010_130a, 0x13); goto l_0x1010_130a; /* jmp 0x1010130a */
        l_0x1010_12f7:
            ii(0x1010_12f7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_12f9, 3); mov(cl, memb_a32[ss, ebp - 0x10]);      /* mov cl, [ebp-0x10] */
            ii(0x1010_12fc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_12fe, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_1301, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_1305, 5); calld(0x100a_1ea3, -0x5f467);           /* call 0x100a1ea3 */
        l_0x1010_130a:
            ii(0x1010_130a, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_1311, 2); jmpd(0x1010_1323, 0x10); goto l_0x1010_1323; /* jmp 0x10101323 */
        l_0x1010_1313:
            ii(0x1010_1313, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_131a, 2); jmpd(0x1010_1323, 0x7); goto l_0x1010_1323; /* jmp 0x10101323 */
        l_0x1010_131c:
            ii(0x1010_131c, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
        l_0x1010_1323:
            ii(0x1010_1323, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_1326, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_1328, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_1329, 1); popd(edi);                              /* pop edi */
            ii(0x1010_132a, 1); popd(esi);                              /* pop esi */
            ii(0x1010_132b, 1); retd(); return;                         /* ret */
        }
    }
}
