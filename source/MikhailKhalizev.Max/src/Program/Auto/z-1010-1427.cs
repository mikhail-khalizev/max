using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0dc9d84d-24b2-4d1d-a7ff-a96a44feeeb7")]
        public void Method_1010_1427()
        {
            ii(0x1010_1427, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1010_142c, 5); calld(Definitions.sys_check_available_stack_size, 0x6_4921); /* call 0x10165d52 */
            ii(0x1010_1431, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_1432, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_1433, 1); pushd(esi);                             /* push esi */
            ii(0x1010_1434, 1); pushd(edi);                             /* push edi */
            ii(0x1010_1435, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_1436, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_1438, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1010_143e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_1441, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_1444, 6); mov(ax, memw_a32[ds, 0x101c_38f4]);     /* mov ax, [0x101c38f4] */
            ii(0x1010_144a, 7); sub(ax, memw_a32[ds, 0x101c_38ec]);     /* sub ax, [0x101c38ec] */
            ii(0x1010_1451, 1); inc(eax);                               /* inc eax */
            ii(0x1010_1452, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_1455, 6); mov(ax, memw_a32[ds, 0x101c_38f8]);     /* mov ax, [0x101c38f8] */
            ii(0x1010_145b, 7); sub(ax, memw_a32[ds, 0x101c_38f0]);     /* sub ax, [0x101c38f0] */
            ii(0x1010_1462, 1); inc(eax);                               /* inc eax */
            ii(0x1010_1463, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_1466, 5); mov(eax, memd_a32[ds, 0x101b_8746]);    /* mov eax, [0x101b8746] */
            ii(0x1010_146b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_146e, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x1010_1475, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1478, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_147b, 5); mov(eax, memd_a32[ds, 0x101b_8748]);    /* mov eax, [0x101b8748] */
            ii(0x1010_1480, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1483, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x1010_148a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_148d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_1490, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_1494, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_1496, 2); if(jged(0x1010_149f, 0x7)) goto l_0x1010_149f; /* jge 0x1010149f */
            ii(0x1010_1498, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1010_149f:
            ii(0x1010_149f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_14a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_14a5, 2); if(jged(0x1010_14ae, 0x7)) goto l_0x1010_14ae; /* jge 0x101014ae */
            ii(0x1010_14a7, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1010_14ae:
            ii(0x1010_14ae, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1010_14b2, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1010_14b5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_14b7, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_14ba, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1010_14c0, 6); mov(edx, memd_a32[ds, 0x101b_8746]);    /* mov edx, [0x101b8746] */
            ii(0x1010_14c6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_14c9, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1010_14cb, 2); if(jged(0x1010_14d5, 0x8)) goto l_0x1010_14d5; /* jge 0x101014d5 */
            ii(0x1010_14cd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_14d0, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1010_14d3, 2); jmpd(0x1010_14ae, -0x27); goto l_0x1010_14ae; /* jmp 0x101014ae */
        l_0x1010_14d5:
            ii(0x1010_14d5, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_14d9, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1010_14dc, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_14de, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_14e1, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1010_14e7, 6); mov(edx, memd_a32[ds, 0x101b_8748]);    /* mov edx, [0x101b8748] */
            ii(0x1010_14ed, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_14f0, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1010_14f2, 2); if(jged(0x1010_14fc, 0x8)) goto l_0x1010_14fc; /* jge 0x101014fc */
            ii(0x1010_14f4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_14f7, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x1010_14fa, 2); jmpd(0x1010_14d5, -0x27); goto l_0x1010_14d5; /* jmp 0x101014d5 */
        l_0x1010_14fc:
            ii(0x1010_14fc, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_1500, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_1504, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_1506, 5); cmp(eax, 0x1c00);                       /* cmp eax, 0x1c00 */
            ii(0x1010_150b, 2); if(jld(0x1010_1518, 0xb)) goto l_0x1010_1518; /* jl 0x10101518 */
            ii(0x1010_150d, 5); mov(eax, 0x1c00);                       /* mov eax, 0x1c00 */
            ii(0x1010_1512, 3); sub(eax, memd_a32[ss, ebp - 0x10]);     /* sub eax, [ebp-0x10] */
            ii(0x1010_1515, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1010_1518:
            ii(0x1010_1518, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_151c, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_1520, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_1522, 5); cmp(eax, 0x1c00);                       /* cmp eax, 0x1c00 */
            ii(0x1010_1527, 2); if(jld(0x1010_1534, 0xb)) goto l_0x1010_1534; /* jl 0x10101534 */
            ii(0x1010_1529, 5); mov(eax, 0x1c00);                       /* mov eax, 0x1c00 */
            ii(0x1010_152e, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1010_1531, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1010_1534:
            ii(0x1010_1534, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_1538, 6); cmp(eax, memd_a32[ds, 0x101c_38ec]);    /* cmp eax, [0x101c38ec] */
            ii(0x1010_153e, 2); if(jnzd(0x1010_154c, 0xc)) goto l_0x1010_154c; /* jnz 0x1010154c */
            ii(0x1010_1540, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_1544, 6); cmp(eax, memd_a32[ds, 0x101c_38f0]);    /* cmp eax, [0x101c38f0] */
            ii(0x1010_154a, 2); if(jzd(0x1010_154e, 0x2)) goto l_0x1010_154e; /* jz 0x1010154e */
        l_0x1010_154c:
            ii(0x1010_154c, 2); jmpd(0x1010_1557, 0x9); goto l_0x1010_1557; /* jmp 0x10101557 */
        l_0x1010_154e:
            ii(0x1010_154e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_1551, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1010_1555, 2); if(jzd(0x1010_1559, 0x2)) goto l_0x1010_1559; /* jz 0x10101559 */
        l_0x1010_1557:
            ii(0x1010_1557, 2); jmpd(0x1010_1562, 0x9); goto l_0x1010_1562; /* jmp 0x10101562 */
        l_0x1010_1559:
            ii(0x1010_1559, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_155c, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1010_1560, 2); if(jzd(0x1010_1564, 0x2)) goto l_0x1010_1564; /* jz 0x10101564 */
        l_0x1010_1562:
            ii(0x1010_1562, 2); jmpd(0x1010_1570, 0xc); goto l_0x1010_1570; /* jmp 0x10101570 */
        l_0x1010_1564:
            ii(0x1010_1564, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1010_156b, 5); jmpd(0x1010_1615, 0xa5); goto l_0x1010_1615; /* jmp 0x10101615 */
        l_0x1010_1570:
            ii(0x1010_1570, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_1574, 5); mov(memd_a32[ds, 0x101c_38ec], eax);    /* mov [0x101c38ec], eax */
            ii(0x1010_1579, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_157d, 5); mov(memd_a32[ds, 0x101c_38f0], eax);    /* mov [0x101c38f0], eax */
            ii(0x1010_1582, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_1586, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_158a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_158c, 1); dec(eax);                               /* dec eax */
            ii(0x1010_158d, 5); mov(memd_a32[ds, 0x101c_38f4], eax);    /* mov [0x101c38f4], eax */
            ii(0x1010_1592, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_1596, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_159a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_159c, 1); dec(eax);                               /* dec eax */
            ii(0x1010_159d, 5); mov(memd_a32[ds, 0x101c_38f8], eax);    /* mov [0x101c38f8], eax */
            ii(0x1010_15a2, 6); mov(edx, memd_a32[ds, 0x101c_38ec]);    /* mov edx, [0x101c38ec] */
            ii(0x1010_15a8, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1010_15ab, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_15ad, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_15b0, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1010_15b6, 6); mov(memw_a32[ds, 0x101c_38fc], ax);     /* mov [0x101c38fc], ax */
            ii(0x1010_15bc, 6); mov(edx, memd_a32[ds, 0x101c_38f0]);    /* mov edx, [0x101c38f0] */
            ii(0x1010_15c2, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1010_15c5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_15c7, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_15ca, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1010_15d0, 6); mov(memw_a32[ds, 0x101c_38fe], ax);     /* mov [0x101c38fe], ax */
            ii(0x1010_15d6, 5); mov(eax, memd_a32[ds, 0x101c_38ec]);    /* mov eax, [0x101c38ec] */
            ii(0x1010_15db, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1010_15de, 6); mov(memw_a32[ds, 0x101c_38da], ax);     /* mov [0x101c38da], ax */
            ii(0x1010_15e4, 5); mov(eax, memd_a32[ds, 0x101c_38f0]);    /* mov eax, [0x101c38f0] */
            ii(0x1010_15e9, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1010_15ec, 6); mov(memw_a32[ds, 0x101c_38dc], ax);     /* mov [0x101c38dc], ax */
            ii(0x1010_15f2, 5); mov(eax, memd_a32[ds, 0x101c_38f4]);    /* mov eax, [0x101c38f4] */
            ii(0x1010_15f7, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1010_15fa, 6); mov(memw_a32[ds, 0x101c_38de], ax);     /* mov [0x101c38de], ax */
            ii(0x1010_1600, 5); mov(eax, memd_a32[ds, 0x101c_38f8]);    /* mov eax, [0x101c38f8] */
            ii(0x1010_1605, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1010_1608, 6); mov(memw_a32[ds, 0x101c_38e0], ax);     /* mov [0x101c38e0], ax */
            ii(0x1010_160e, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
        l_0x1010_1615:
            ii(0x1010_1615, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_1618, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_161a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_161b, 1); popd(edi);                              /* pop edi */
            ii(0x1010_161c, 1); popd(esi);                              /* pop esi */
            ii(0x1010_161d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_161e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_161f, 1); retd(); return;                         /* ret */
        }
    }
}
