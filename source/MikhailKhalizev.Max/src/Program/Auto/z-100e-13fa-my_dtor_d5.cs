using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_13fa-b2a9a48a")]
        public void my_dtor_d5()
        {
            ii(0x100e_13fa, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x100e_13ff, 5); calld(Definitions.sys_check_available_stack_size, 0x8_494e); /* call 0x10165d52 */
            ii(0x100e_1404, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_1405, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_1406, 1); pushd(esi);                             /* push esi */
            ii(0x100e_1407, 1); pushd(edi);                             /* push edi */
            ii(0x100e_1408, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_1409, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_140b, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100e_1411, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_1414, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_1417, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_141a, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_141d, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_1420, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100e_1424, 2); if(jzd(0x100e_143a, 0x14)) goto l_0x100e_143a; /* jz 0x100e143a */
            ii(0x100e_1426, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1428, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_142b, 5); calld(Definitions.my_dtor_d3, -0x96fd); /* call 0x100d7d33 */
            ii(0x100e_1430, 5); calld(Definitions.sys_delete, 0x8_4b2f); /* call 0x10165f64 */
            ii(0x100e_1435, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_1438, 2); jmpd(0x100e_1441, 0x7); goto l_0x100e_1441; /* jmp 0x100e1441 */
        l_0x100e_143a:
            ii(0x100e_143a, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x100e_1441:
            ii(0x100e_1441, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1444, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1447, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_144a, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100e_144e, 2); if(jzd(0x100e_1464, 0x14)) goto l_0x100e_1464; /* jz 0x100e1464 */
            ii(0x100e_1450, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1452, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_1455, 5); calld(Definitions.my_dtor_d3, -0x9727); /* call 0x100d7d33 */
            ii(0x100e_145a, 5); calld(Definitions.sys_delete, 0x8_4b05); /* call 0x10165f64 */
            ii(0x100e_145f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_1462, 2); jmpd(0x100e_146b, 0x7); goto l_0x100e_146b; /* jmp 0x100e146b */
        l_0x100e_1464:
            ii(0x100e_1464, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100e_146b:
            ii(0x100e_146b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_146e, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100e_1471, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_1474, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100e_1478, 2); if(jzd(0x100e_148e, 0x14)) goto l_0x100e_148e; /* jz 0x100e148e */
            ii(0x100e_147a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_147c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_147f, 5); calld(Definitions.my_dtor_d2, -0x1_2f4c); /* call 0x100ce538 */
            ii(0x100e_1484, 5); calld(Definitions.sys_delete, 0x8_4adb); /* call 0x10165f64 */
            ii(0x100e_1489, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_148c, 2); jmpd(0x100e_1495, 0x7); goto l_0x100e_1495; /* jmp 0x100e1495 */
        l_0x100e_148e:
            ii(0x100e_148e, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x100e_1495:
            ii(0x100e_1495, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1498, 4); cmp(memd_a32[ds, eax + 0x14], 0);       /* cmp dword [eax+0x14], 0x0 */
            ii(0x100e_149c, 6); if(jzd(0x100e_1520, 0x7e)) goto l_0x100e_1520; /* jz 0x100e1520 */
            ii(0x100e_14a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_14a5, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_14a8, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100e_14ab, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100e_14af, 2); if(jzd(0x100e_14c5, 0x14)) goto l_0x100e_14c5; /* jz 0x100e14c5 */
            ii(0x100e_14b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_14b3, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_14b6, 5); calld(Definitions.my_dtor_d2, -0x1_2f83); /* call 0x100ce538 */
            ii(0x100e_14bb, 5); calld(Definitions.sys_delete, 0x8_4aa4); /* call 0x10165f64 */
            ii(0x100e_14c0, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_14c3, 2); jmpd(0x100e_14cc, 0x7); goto l_0x100e_14cc; /* jmp 0x100e14cc */
        l_0x100e_14c5:
            ii(0x100e_14c5, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
        l_0x100e_14cc:
            ii(0x100e_14cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_14cf, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100e_14d2, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_14d5, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100e_14d9, 2); if(jzd(0x100e_14ef, 0x14)) goto l_0x100e_14ef; /* jz 0x100e14ef */
            ii(0x100e_14db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_14dd, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_14e0, 5); calld(Definitions.my_dtor_d2, -0x1_2fad); /* call 0x100ce538 */
            ii(0x100e_14e5, 5); calld(Definitions.sys_delete, 0x8_4a7a); /* call 0x10165f64 */
            ii(0x100e_14ea, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_14ed, 2); jmpd(0x100e_14f6, 0x7); goto l_0x100e_14f6; /* jmp 0x100e14f6 */
        l_0x100e_14ef:
            ii(0x100e_14ef, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
        l_0x100e_14f6:
            ii(0x100e_14f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_14f9, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100e_14fc, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_14ff, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100e_1503, 2); if(jzd(0x100e_1519, 0x14)) goto l_0x100e_1519; /* jz 0x100e1519 */
            ii(0x100e_1505, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1507, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_150a, 5); calld(Definitions.my_dtor_d2, -0x1_2fd7); /* call 0x100ce538 */
            ii(0x100e_150f, 5); calld(Definitions.sys_delete, 0x8_4a50); /* call 0x10165f64 */
            ii(0x100e_1514, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_1517, 2); jmpd(0x100e_1520, 0x7); goto l_0x100e_1520; /* jmp 0x100e1520 */
        l_0x100e_1519:
            ii(0x100e_1519, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
        l_0x100e_1520:
            ii(0x100e_1520, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1522, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1525, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1528, 5); calld(0x1007_5f2c, -0x6_b601);          /* call 0x10075f2c */
            ii(0x100e_152d, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x100e_1530, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_1533, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1536, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_1539, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_153c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_153e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_153f, 1); popd(edi);                              /* pop edi */
            ii(0x100e_1540, 1); popd(esi);                              /* pop esi */
            ii(0x100e_1541, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_1542, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_1543, 1); retd(); return;                         /* ret */
        }
    }
}
