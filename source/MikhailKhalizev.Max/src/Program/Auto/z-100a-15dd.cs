using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_15dd-6fc086d5")]
        public void Method_100a_15dd()
        {
            ii(0x100a_15dd, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100a_15e2, 5); calld(Definitions.sys_check_available_stack_size, 0xc_476b); /* call 0x10165d52 */
            ii(0x100a_15e7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_15e8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_15e9, 1); pushd(esi);                             /* push esi */
            ii(0x100a_15ea, 1); pushd(edi);                             /* push edi */
            ii(0x100a_15eb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_15ec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_15ee, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_15f4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_15f7, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100a_15fa, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100a_15fe, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1601, 5); calld(0x1007_64fc, -0x2_b10a);          /* call 0x100764fc */
            ii(0x100a_1606, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_1609, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100a_160d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_160f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1612, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_1615, 5); calld(0x1013_ad71, 0x9_9757);           /* call 0x1013ad71 */
            ii(0x100a_161a, 2); test(al, al);                           /* test al, al */
            ii(0x100a_161c, 2); if(jzd(0x100a_163e, 0x20)) goto l_0x100a_163e; /* jz 0x100a163e */
            ii(0x100a_161e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_1620, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x100a_1623, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1626, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_1629, 5); calld(0x1007_6600, -0x2_b02e);          /* call 0x10076600 */
            ii(0x100a_162e, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100a_1631, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_1633, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100a_1635, 5); calld(0x100a_1460, -0x1da);             /* call 0x100a1460 */
            ii(0x100a_163a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_163c, 2); if(jnzd(0x100a_1640, 0x2)) goto l_0x100a_1640; /* jnz 0x100a1640 */
        l_0x100a_163e:
            ii(0x100a_163e, 2); jmpd(0x100a_1656, 0x16); goto l_0x100a_1656; /* jmp 0x100a1656 */
        l_0x100a_1640:
            ii(0x100a_1640, 7); mov(memd_a32[ss, ebp - 0x18], 0x1);     /* mov dword [ebp-0x18], 0x1 */
            ii(0x100a_1647, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_1649, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_164c, 5); calld(0x1007_5f6c, -0x2_b6e5);          /* call 0x10075f6c */
            ii(0x100a_1651, 5); jmpd(0x100a_16d1, 0x7b); goto l_0x100a_16d1; /* jmp 0x100a16d1 */
        l_0x100a_1656:
            ii(0x100a_1656, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_165b, 5); calld(0x1007_6338, -0x2_b328);          /* call 0x10076338 */
            ii(0x100a_1660, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100a_1663, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_1665, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_1667, 5); calld(0x1007_643c, -0x2_b230);          /* call 0x1007643c */
        l_0x100a_166c:
            ii(0x100a_166c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_166e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1671, 5); calld(0x1013_ad71, 0x9_96fb);           /* call 0x1013ad71 */
            ii(0x100a_1676, 2); test(al, al);                           /* test al, al */
            ii(0x100a_1678, 2); if(jzd(0x100a_16b4, 0x3a)) goto l_0x100a_16b4; /* jz 0x100a16b4 */
            ii(0x100a_167a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_167c, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x100a_167f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1682, 5); calld(0x1007_6408, -0x2_b27f);          /* call 0x10076408 */
            ii(0x100a_1687, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100a_168a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_168c, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100a_168e, 5); calld(0x100a_1460, -0x233);             /* call 0x100a1460 */
            ii(0x100a_1693, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1695, 2); if(jzd(0x100a_16aa, 0x13)) goto l_0x100a_16aa; /* jz 0x100a16aa */
            ii(0x100a_1697, 7); mov(memd_a32[ss, ebp - 0x18], 0x1);     /* mov dword [ebp-0x18], 0x1 */
            ii(0x100a_169e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_16a0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_16a3, 5); calld(0x1007_5f6c, -0x2_b73c);          /* call 0x10075f6c */
            ii(0x100a_16a8, 2); jmpd(0x100a_16d1, 0x27); goto l_0x100a_16d1; /* jmp 0x100a16d1 */
        l_0x100a_16aa:
            ii(0x100a_16aa, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_16ad, 5); calld(0x1007_6bf8, -0x2_aaba);          /* call 0x10076bf8 */
            ii(0x100a_16b2, 2); jmpd(0x100a_166c, -0x48); goto l_0x100a_166c; /* jmp 0x100a166c */
        l_0x100a_16b4:
            ii(0x100a_16b4, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_16bb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_16bd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_16c0, 5); calld(0x1007_5f6c, -0x2_b759);          /* call 0x10075f6c */
            ii(0x100a_16c5, 2); jmpd(0x100a_16d1, 0xa); goto l_0x100a_16d1; /* jmp 0x100a16d1 */
        //  ii(0x100a_16c7, 10); Недостижимый код.
        l_0x100a_16d1:
            ii(0x100a_16d1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_16d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_16d6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_16d7, 1); popd(edi);                              /* pop edi */
            ii(0x100a_16d8, 1); popd(esi);                              /* pop esi */
            ii(0x100a_16d9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_16da, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_16db, 1); retd(); return;                         /* ret */
        }
    }
}
