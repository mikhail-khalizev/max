using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b7f3ea82-9c5d-408a-b21e-7b0e1a184eb2")]
        public void Method_1008_12b8()
        {
            ii(0x1008_12b8, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1008_12bd, 5); calld(Definitions.sys_check_available_stack_size, 0xe_4a90); /* call 0x10165d52 */
            ii(0x1008_12c2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_12c3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_12c4, 1); pushd(edx);                             /* push edx */
            ii(0x1008_12c5, 1); pushd(esi);                             /* push esi */
            ii(0x1008_12c6, 1); pushd(edi);                             /* push edi */
            ii(0x1008_12c7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_12c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_12ca, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_12d0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_12d3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_12d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_12d8, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_12db, 5); calld(0x1013_ad71, 0xb_9a91);           /* call 0x1013ad71 */
            ii(0x1008_12e0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_12e2, 2); if(jzd(0x1008_12fe, 0x1a)) goto l_0x1008_12fe; /* jz 0x100812fe */
            ii(0x1008_12e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_12e7, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_12ea, 5); calld(0x1008_9970, 0x8681);             /* call 0x10089970 */
            ii(0x1008_12ef, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_12f2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_12f5, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_12f8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_12fb, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
        l_0x1008_12fe:
            ii(0x1008_12fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1300, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1303, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_1306, 5); calld(0x1013_ad71, 0xb_9a66);           /* call 0x1013ad71 */
            ii(0x1008_130b, 2); test(al, al);                           /* test al, al */
            ii(0x1008_130d, 2); if(jzd(0x1008_1342, 0x33)) goto l_0x1008_1342; /* jz 0x10081342 */
            ii(0x1008_130f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_1312, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1315, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_1318, 5); calld(0x1007_6574, -0xada9);            /* call 0x10076574 */
            ii(0x1008_131d, 5); calld(0x1015_27b8, 0xd_1496);           /* call 0x101527b8 */
            ii(0x1008_1322, 5); calld(0x1008_a79c, 0x9475);             /* call 0x1008a79c */
            ii(0x1008_1327, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_1329, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_132b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_132e, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_1331, 5); calld(0x1007_65d0, -0xad66);            /* call 0x100765d0 */
            ii(0x1008_1336, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1338, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_133d, 5); calld(0x100a_53ac, 0x2_406a);           /* call 0x100a53ac */
        l_0x1008_1342:
            ii(0x1008_1342, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1345, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_1348, 5); calld(0x1008_9d08, 0x89bb);             /* call 0x10089d08 */
            ii(0x1008_134d, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1008_1350, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1352, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_1354, 5); calld(0x1008_9be4, 0x888b);             /* call 0x10089be4 */
            ii(0x1008_1359, 2); jmpd(0x1008_1363, 0x8); goto l_0x1008_1363; /* jmp 0x10081363 */
        l_0x1008_135b:
            ii(0x1008_135b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_135e, 5); calld(0x1007_6bf8, -0xa76b);            /* call 0x10076bf8 */
        l_0x1008_1363:
            ii(0x1008_1363, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1365, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_1368, 5); calld(0x1013_ad71, 0xb_9a04);           /* call 0x1013ad71 */
            ii(0x1008_136d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_136f, 2); if(jzd(0x1008_139e, 0x2d)) goto l_0x1008_139e; /* jz 0x1008139e */
            ii(0x1008_1371, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1373, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_1376, 5); calld(0x1008_9acc, 0x8751);             /* call 0x10089acc */
            ii(0x1008_137b, 5); calld(0x1008_9f38, 0x8bb8);             /* call 0x10089f38 */
            ii(0x1008_1380, 5); calld(0x100b_8e30, 0x3_7aab);           /* call 0x100b8e30 */
            ii(0x1008_1385, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_1388, 5); calld(0x1008_9acc, 0x873f);             /* call 0x10089acc */
            ii(0x1008_138d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_1390, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_1393, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_1396, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_1399, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
            ii(0x1008_139c, 2); jmpd(0x1008_135b, -0x43); goto l_0x1008_135b; /* jmp 0x1008135b */
        l_0x1008_139e:
            ii(0x1008_139e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_13a1, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_13a4, 5); calld(0x1013_a6f4, 0xb_934b);           /* call 0x1013a6f4 */
            ii(0x1008_13a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_13ac, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_13af, 5); calld(0x1013_a6f4, 0xb_9340);           /* call 0x1013a6f4 */
            ii(0x1008_13b4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_13b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_13b9, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_13bc, 5); calld(0x1008_9e38, 0x8a77);             /* call 0x10089e38 */
            ii(0x1008_13c1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_13c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_13c6, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_13c9, 5); calld(0x1008_afe4, 0x9c16);             /* call 0x1008afe4 */
            ii(0x1008_13ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_13d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_13d3, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_13d6, 5); calld(0x1008_99fc, 0x8621);             /* call 0x100899fc */
            ii(0x1008_13db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_13dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_13e0, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_13e3, 5); calld(0x1007_6630, -0xadb8);            /* call 0x10076630 */
            ii(0x1008_13e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_13ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_13ed, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1008_13f0, 5); calld(0x1008_afe4, 0x9bef);             /* call 0x1008afe4 */
            ii(0x1008_13f5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_13f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_13fa, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_13fd, 5); calld(0x1007_6630, -0xadd2);            /* call 0x10076630 */
            ii(0x1008_1402, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_1405, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_140a, 5); calld(0x100a_5e27, 0x2_4a18);           /* call 0x100a5e27 */
            ii(0x1008_140f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1411, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_1414, 5); calld(0x1008_9044, 0x7c2b);             /* call 0x10089044 */
            ii(0x1008_1419, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_141b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_141c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_141d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_141e, 1); popd(edx);                              /* pop edx */
            ii(0x1008_141f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_1420, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_1421, 1); retd(); return;                         /* ret */
        }
    }
}
