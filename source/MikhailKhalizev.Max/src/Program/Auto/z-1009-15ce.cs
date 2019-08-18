using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_15ce-59b00bd6")]
        public void Method_1009_15ce()
        {
            ii(0x1009_15ce, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1009_15d3, 5); calld(Definitions.sys_check_available_stack_size, 0xd_477a); /* call 0x10165d52 */
            ii(0x1009_15d8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_15d9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_15da, 1); pushd(esi);                             /* push esi */
            ii(0x1009_15db, 1); pushd(edi);                             /* push edi */
            ii(0x1009_15dc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_15dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_15df, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1009_15e5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_15e8, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_15eb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_15ee, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_ab03); /* call 0x10076af0 */
            ii(0x1009_15f3, 5); mov(ebx, 0x101b_4184);                  /* mov ebx, 0x101b4184 */
            ii(0x1009_15f8, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1009_15fd, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_1600, 5); calld(Definitions.sys_call_ctor_arr_v2, 0xd_496b); /* call 0x10165f70 */
            ii(0x1009_1605, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1009_160c, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1009_160f, 1); dec(eax);                               /* dec eax */
            ii(0x1009_1610, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x1009_1614, 3); mov(eax, memd_a32[ss, ebp + 0x24]);     /* mov eax, [ebp+0x24] */
            ii(0x1009_1617, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x1009_161b, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
            ii(0x1009_161e, 3); sub(eax, memd_a32[ss, ebp + 0x18]);     /* sub eax, [ebp+0x18] */
            ii(0x1009_1621, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_1624, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_162b, 2); jmpd(0x1009_1631, 0x4); goto l_0x1009_1631; /* jmp 0x10091631 */
        l_0x1009_162d:
            ii(0x1009_162d, 4); add(memd_a32[ss, ebp - 0x10], 0x2);     /* add dword [ebp-0x10], 0x2 */
        l_0x1009_1631:
            ii(0x1009_1631, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_1635, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_1638, 6); if(jged(0x1009_16f5, 0xb7)) goto l_0x1009_16f5; /* jge 0x100916f5 */
            ii(0x1009_163e, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1009_1645, 2); jmpd(0x1009_164d, 0x6); goto l_0x1009_164d; /* jmp 0x1009164d */
        l_0x1009_1647:
            ii(0x1009_1647, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_164a, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1009_164d:
            ii(0x1009_164d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_1650, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1009_1654, 6); if(jged(0x1009_16da, 0x80)) goto l_0x1009_16da; /* jge 0x100916da */
            ii(0x1009_165a, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_165e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1661, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_1666, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_1668, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_166b, 5); calld(0x1008_b1a4, -0x64cc);            /* call 0x1008b1a4 */
            ii(0x1009_1670, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_1674, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_1676, 2); if(jld(0x1009_1684, 0xc)) goto l_0x1009_1684; /* jl 0x10091684 */
            ii(0x1009_1678, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_167b, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1009_1682, 2); if(jld(0x1009_1686, 0x2)) goto l_0x1009_1686; /* jl 0x10091686 */
        l_0x1009_1684:
            ii(0x1009_1684, 2); jmpd(0x1009_168e, 0x8); goto l_0x1009_168e; /* jmp 0x1009168e */
        l_0x1009_1686:
            ii(0x1009_1686, 4); movsx(eax, memw_a32[ss, ebp - 0x1a]);   /* movsx eax, word [ebp-0x1a] */
            ii(0x1009_168a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_168c, 2); if(jged(0x1009_1690, 0x2)) goto l_0x1009_1690; /* jge 0x10091690 */
        l_0x1009_168e:
            ii(0x1009_168e, 2); jmpd(0x1009_169c, 0xc); goto l_0x1009_169c; /* jmp 0x1009169c */
        l_0x1009_1690:
            ii(0x1009_1690, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x1009_1693, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_169a, 2); if(jld(0x1009_169e, 0x2)) goto l_0x1009_169e; /* jl 0x1009169e */
        l_0x1009_169c:
            ii(0x1009_169c, 2); jmpd(0x1009_16ba, 0x1c); goto l_0x1009_16ba; /* jmp 0x100916ba */
        l_0x1009_169e:
            ii(0x1009_169e, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_16a2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_16a5, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_16a8, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x1009_16ac, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_16ae, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_16b0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_16b2, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_16b5, 3); cmp(eax, 0x7);                          /* cmp eax, 0x7 */
            ii(0x1009_16b8, 2); if(jld(0x1009_16bc, 0x2)) goto l_0x1009_16bc; /* jl 0x100916bc */
        l_0x1009_16ba:
            ii(0x1009_16ba, 2); jmpd(0x1009_16d5, 0x19); goto l_0x1009_16d5; /* jmp 0x100916d5 */
        l_0x1009_16bc:
            ii(0x1009_16bc, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1009_16bf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_16c2, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x1009_16c5, 1); cwde();                                 /* cwde */
            ii(0x1009_16c6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_16c9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_16cb, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_16ce, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_16d0, 5); calld(0x1008_8b44, -0x8b91);            /* call 0x10088b44 */
        l_0x1009_16d5:
            ii(0x1009_16d5, 5); jmpd(0x1009_1647, -0x93); goto l_0x1009_1647; /* jmp 0x10091647 */
        l_0x1009_16da:
            ii(0x1009_16da, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_16de, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_16e1, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_16e6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_16e8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_16eb, 5); calld(0x1008_b1a4, -0x654c);            /* call 0x1008b1a4 */
            ii(0x1009_16f0, 5); jmpd(0x1009_162d, -0xc8); goto l_0x1009_162d; /* jmp 0x1009162d */
        l_0x1009_16f5:
            ii(0x1009_16f5, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1009_16f9, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_16fc, 2); if(jnzd(0x1009_1717, 0x19)) goto l_0x1009_1717; /* jnz 0x10091717 */
            ii(0x1009_16fe, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x1009_1702, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1705, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_1708, 4); movsx(edx, memw_a32[ss, ebp - 0x3a]);   /* movsx edx, word [ebp-0x3a] */
            ii(0x1009_170c, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_170e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_1710, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1712, 5); mov(memw_a32[ds, eax], 0x5);            /* mov word [eax], 0x5 */
        l_0x1009_1717:
            ii(0x1009_1717, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1009_171b, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1009_171e, 2); if(jnzd(0x1009_1729, 0x9)) goto l_0x1009_1729; /* jnz 0x10091729 */
            ii(0x1009_1720, 4); movsx(eax, memw_a32[ss, ebp + 0x28]);   /* movsx eax, word [ebp+0x28] */
            ii(0x1009_1724, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1009_1727, 2); if(jzd(0x1009_172b, 0x2)) goto l_0x1009_172b; /* jz 0x1009172b */
        l_0x1009_1729:
            ii(0x1009_1729, 2); jmpd(0x1009_173f, 0x14); goto l_0x1009_173f; /* jmp 0x1009173f */
        l_0x1009_172b:
            ii(0x1009_172b, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1009_172e, 4); cmp(ax, memw_a32[ss, ebp - 0x38]);      /* cmp ax, [ebp-0x38] */
            ii(0x1009_1732, 2); if(jzd(0x1009_173d, 0x9)) goto l_0x1009_173d; /* jz 0x1009173d */
            ii(0x1009_1734, 3); mov(eax, memd_a32[ss, ebp - 0x3a]);     /* mov eax, [ebp-0x3a] */
            ii(0x1009_1737, 4); cmp(ax, memw_a32[ss, ebp - 0x36]);      /* cmp ax, [ebp-0x36] */
            ii(0x1009_173b, 2); if(jnzd(0x1009_173f, 0x2)) goto l_0x1009_173f; /* jnz 0x1009173f */
        l_0x1009_173d:
            ii(0x1009_173d, 2); jmpd(0x1009_1741, 0x2); goto l_0x1009_1741; /* jmp 0x10091741 */
        l_0x1009_173f:
            ii(0x1009_173f, 2); jmpd(0x1009_1773, 0x32); goto l_0x1009_1773; /* jmp 0x10091773 */
        l_0x1009_1741:
            ii(0x1009_1741, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x1009_1745, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1748, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_174b, 4); movsx(edx, memw_a32[ss, ebp - 0x3a]);   /* movsx edx, word [ebp-0x3a] */
            ii(0x1009_174f, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_1751, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_1753, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1755, 5); mov(memw_a32[ds, eax], 0x5);            /* mov word [eax], 0x5 */
            ii(0x1009_175a, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1009_175e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1761, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_1764, 4); movsx(edx, memw_a32[ss, ebp - 0x36]);   /* movsx edx, word [ebp-0x36] */
            ii(0x1009_1768, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_176a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_176c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_176e, 5); mov(memw_a32[ds, eax], 0x5);            /* mov word [eax], 0x5 */
        l_0x1009_1773:
            ii(0x1009_1773, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_1775, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_1776, 1); popd(edi);                              /* pop edi */
            ii(0x1009_1777, 1); popd(esi);                              /* pop esi */
            ii(0x1009_1778, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_1779, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_177a, 3); retd(0x14); return;                     /* ret 0x14 */
        }
    }
}
