using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_15df-1a61b8b4")]
        public void Method_1007_15df()
        {
            ii(0x1007_15df, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_15e4, 5); calld(Definitions.sys_check_available_stack_size, 0xf_4769); /* call 0x10165d52 */
            ii(0x1007_15e9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_15ea, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_15eb, 1); pushd(edx);                             /* push edx */
            ii(0x1007_15ec, 1); pushd(esi);                             /* push esi */
            ii(0x1007_15ed, 1); pushd(edi);                             /* push edi */
            ii(0x1007_15ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_15ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_15f1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_15f7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_15fa, 7); cmp(memb_a32[ds, 0x101c_3920], 0);      /* cmp byte [0x101c3920], 0x0 */
            ii(0x1007_1601, 2); if(jzd(0x1007_1642, 0x3f)) goto l_0x1007_1642; /* jz 0x10071642 */
            ii(0x1007_1603, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_160a, 2); jmpd(0x1007_1612, 0x6); goto l_0x1007_1612; /* jmp 0x10071612 */
        l_0x1007_160c:
            ii(0x1007_160c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_160f, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1007_1612:
            ii(0x1007_1612, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_1616, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1007_1619, 2); if(jged(0x1007_1642, 0x27)) goto l_0x1007_1642; /* jge 0x10071642 */
            ii(0x1007_161b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_161f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_1625, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1007_162b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1630, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1632, 2); if(jzd(0x1007_1640, 0xc)) goto l_0x1007_1640; /* jz 0x10071640 */
            ii(0x1007_1634, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_1638, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_163b, 5); calld(0x1014_f634, 0xd_dff4);           /* call 0x1014f634 */
        l_0x1007_1640:
            ii(0x1007_1640, 2); jmpd(0x1007_160c, -0x36); goto l_0x1007_160c; /* jmp 0x1007160c */
        l_0x1007_1642:
            ii(0x1007_1642, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_1645, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1007_1649, 8); imul(ax, memw_a32[ds, 0x101c_8172]);    /* imul ax, [0x101c8172] */
            ii(0x1007_1651, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_1653, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_1656, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1007_165a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_165c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_165f, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
        l_0x1007_1666:
            ii(0x1007_1666, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1007_1669, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1007_166e, 6); if(jzd(0x1007_1731, 0xbd)) goto l_0x1007_1731; /* jz 0x10071731 */
            ii(0x1007_1674, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_1678, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_167e, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1007_1684, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1689, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_168b, 6); if(jzd(0x1007_172c, 0x9b)) goto l_0x1007_172c; /* jz 0x1007172c */
            ii(0x1007_1691, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_1695, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_169b, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_169f, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a7]); /* mov eax, [eax+0x101ca6a7] */
            ii(0x1007_16a5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_16a7, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x1007_16aa, 2); if(jzd(0x1007_16b8, 0xc)) goto l_0x1007_16b8; /* jz 0x100716b8 */
            ii(0x1007_16ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_16af, 5); calld(0x1016_433b, 0xf_2c87);           /* call 0x1016433b */
            ii(0x1007_16b4, 2); test(al, al);                           /* test al, al */
            ii(0x1007_16b6, 2); if(jnzd(0x1007_16ba, 0x2)) goto l_0x1007_16ba; /* jnz 0x100716ba */
        l_0x1007_16b8:
            ii(0x1007_16b8, 2); jmpd(0x1007_16c6, 0xc); goto l_0x1007_16c6; /* jmp 0x100716c6 */
        l_0x1007_16ba:
            ii(0x1007_16ba, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_16be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_16c1, 5); calld(0x1014_f634, 0xd_df6e);           /* call 0x1014f634 */
        l_0x1007_16c6:
            ii(0x1007_16c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_16c9, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_16ce, 2); if(jnzd(0x1007_16f7, 0x27)) goto l_0x1007_16f7; /* jnz 0x100716f7 */
            ii(0x1007_16d0, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_16d4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_16da, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_16de, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6ab]); /* mov eax, [eax+0x101ca6ab] */
            ii(0x1007_16e4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_16e6, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x1007_16e9, 2); if(jzd(0x1007_16f7, 0xc)) goto l_0x1007_16f7; /* jz 0x100716f7 */
            ii(0x1007_16eb, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_16ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_16f2, 5); calld(0x1014_f634, 0xd_df3d);           /* call 0x1014f634 */
        l_0x1007_16f7:
            ii(0x1007_16f7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_16fb, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_1701, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_1705, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x1007_170b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_170d, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x1007_1710, 2); if(jzd(0x1007_1720, 0xe)) goto l_0x1007_1720; /* jz 0x10071720 */
            ii(0x1007_1712, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_1716, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_1719, 5); calld(0x1014_f432, 0xd_dd14);           /* call 0x1014f432 */
            ii(0x1007_171e, 2); jmpd(0x1007_172c, 0xc); goto l_0x1007_172c; /* jmp 0x1007172c */
        l_0x1007_1720:
            ii(0x1007_1720, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_1724, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_1727, 5); calld(0x1014_f2a2, 0xd_db76);           /* call 0x1014f2a2 */
        l_0x1007_172c:
            ii(0x1007_172c, 5); jmpd(0x1007_1666, -0xcb); goto l_0x1007_1666; /* jmp 0x10071666 */
        l_0x1007_1731:
            ii(0x1007_1731, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1733, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_1734, 1); popd(edi);                              /* pop edi */
            ii(0x1007_1735, 1); popd(esi);                              /* pop esi */
            ii(0x1007_1736, 1); popd(edx);                              /* pop edx */
            ii(0x1007_1737, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_1738, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_1739, 1); retd(); return;                         /* ret */
        }
    }
}
