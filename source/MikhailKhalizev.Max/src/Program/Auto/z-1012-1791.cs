using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_1791-34155824")]
        public void Method_1012_1791()
        {
            ii(0x1012_1791, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1012_1796, 5); calld(Definitions.sys_check_available_stack_size, 0x4_45b7); /* call 0x10165d52 */
            ii(0x1012_179b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_179c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_179d, 1); pushd(esi);                             /* push esi */
            ii(0x1012_179e, 1); pushd(edi);                             /* push edi */
            ii(0x1012_179f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_17a0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_17a2, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1012_17a8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_17ab, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_17ae, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1012_17b5, 2); if(jzd(0x1012_17ce, 0x17)) goto l_0x1012_17ce; /* jz 0x101217ce */
            ii(0x1012_17b7, 5); mov(edx, 0x101b_6a98);                  /* mov edx, 0x101b6a98 */
            ii(0x1012_17bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_17bf, 5); calld(Definitions.sys_call_dtor_arr, 0x4_47f4); /* call 0x10165fb8 */
            ii(0x1012_17c4, 5); calld(Definitions.sys_delete_arr, 0x4_480f); /* call 0x10165fd8 */
            ii(0x1012_17c9, 5); jmpd(0x1012_19ba, 0x1ec); goto l_0x1012_19ba; /* jmp 0x101219ba */
        l_0x1012_17ce:
            ii(0x1012_17ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_17d1, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_6aac); /* mov dword [eax+0x13], 0x101b6aac */
            ii(0x1012_17d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_17db, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1012_17de, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1012_17e1, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1012_17e5, 2); if(jzd(0x1012_17fb, 0x14)) goto l_0x1012_17fb; /* jz 0x101217fb */
            ii(0x1012_17e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_17e9, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1012_17ec, 5); calld(Definitions.my_dtor_d2, -0x5_32b9); /* call 0x100ce538 */
            ii(0x1012_17f1, 5); calld(Definitions.sys_delete, 0x4_476e); /* call 0x10165f64 */
            ii(0x1012_17f6, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1012_17f9, 2); jmpd(0x1012_1802, 0x7); goto l_0x1012_1802; /* jmp 0x10121802 */
        l_0x1012_17fb:
            ii(0x1012_17fb, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x1012_1802:
            ii(0x1012_1802, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_1805, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x1012_1808, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1012_180b, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1012_180f, 2); if(jzd(0x1012_1825, 0x14)) goto l_0x1012_1825; /* jz 0x10121825 */
            ii(0x1012_1811, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_1813, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1012_1816, 5); calld(Definitions.my_dtor_d2, -0x5_32e3); /* call 0x100ce538 */
            ii(0x1012_181b, 5); calld(Definitions.sys_delete, 0x4_4744); /* call 0x10165f64 */
            ii(0x1012_1820, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_1823, 2); jmpd(0x1012_182c, 0x7); goto l_0x1012_182c; /* jmp 0x1012182c */
        l_0x1012_1825:
            ii(0x1012_1825, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1012_182c:
            ii(0x1012_182c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_182f, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_1832, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_1835, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1012_1839, 2); if(jzd(0x1012_184f, 0x14)) goto l_0x1012_184f; /* jz 0x1012184f */
            ii(0x1012_183b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_183d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_1840, 5); calld(Definitions.my_dtor_d2, -0x5_330d); /* call 0x100ce538 */
            ii(0x1012_1845, 5); calld(Definitions.sys_delete, 0x4_471a); /* call 0x10165f64 */
            ii(0x1012_184a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_184d, 2); jmpd(0x1012_1856, 0x7); goto l_0x1012_1856; /* jmp 0x10121856 */
        l_0x1012_184f:
            ii(0x1012_184f, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1012_1856:
            ii(0x1012_1856, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_1859, 4); cmp(memd_a32[ds, eax + 0x42], 0);       /* cmp dword [eax+0x42], 0x0 */
            ii(0x1012_185d, 2); if(jzd(0x1012_1889, 0x2a)) goto l_0x1012_1889; /* jz 0x10121889 */
            ii(0x1012_185f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_1862, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_1865, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1012_1868, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1012_186c, 2); if(jzd(0x1012_1882, 0x14)) goto l_0x1012_1882; /* jz 0x10121882 */
            ii(0x1012_186e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_1870, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1012_1873, 5); calld(Definitions.my_dtor_d6, -0x3_67a1); /* call 0x100eb0d7 */
            ii(0x1012_1878, 5); calld(Definitions.sys_delete, 0x4_46e7); /* call 0x10165f64 */
            ii(0x1012_187d, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1012_1880, 2); jmpd(0x1012_1889, 0x7); goto l_0x1012_1889; /* jmp 0x10121889 */
        l_0x1012_1882:
            ii(0x1012_1882, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
        l_0x1012_1889:
            ii(0x1012_1889, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_1890, 2); jmpd(0x1012_1898, 0x6); goto l_0x1012_1898; /* jmp 0x10121898 */
        l_0x1012_1892:
            ii(0x1012_1892, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_1895, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1012_1898:
            ii(0x1012_1898, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_189b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_189e, 4); cmp(ax, memw_a32[ds, edx + 0x49]);      /* cmp ax, [edx+0x49] */
            ii(0x1012_18a2, 6); if(jged(0x1012_1984, 0xdc)) goto l_0x1012_1984; /* jge 0x10121984 */
            ii(0x1012_18a8, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_18ac, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_18af, 7); cmp(memd_a32[ds, eax + 0x101b_b068], 0); /* cmp dword [eax+0x101bb068], 0x0 */
            ii(0x1012_18b6, 2); if(jzd(0x1012_18fa, 0x42)) goto l_0x1012_18fa; /* jz 0x101218fa */
            ii(0x1012_18b8, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_18bc, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_18bf, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_18c5, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1012_18c8, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1012_18cc, 2); if(jzd(0x1012_18e2, 0x14)) goto l_0x1012_18e2; /* jz 0x101218e2 */
            ii(0x1012_18ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_18d0, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1012_18d3, 5); calld(Definitions.my_dtor_d2, -0x5_33a0); /* call 0x100ce538 */
            ii(0x1012_18d8, 5); calld(Definitions.sys_delete, 0x4_4687); /* call 0x10165f64 */
            ii(0x1012_18dd, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1012_18e0, 2); jmpd(0x1012_18e9, 0x7); goto l_0x1012_18e9; /* jmp 0x101218e9 */
        l_0x1012_18e2:
            ii(0x1012_18e2, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
        l_0x1012_18e9:
            ii(0x1012_18e9, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_18ed, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_18f0, 10); mov(memd_a32[ds, eax + 0x101b_b068], 0); /* mov dword [eax+0x101bb068], 0x0 */
        l_0x1012_18fa:
            ii(0x1012_18fa, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_18fe, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1901, 7); cmp(memd_a32[ds, eax + 0x101b_b06c], 0); /* cmp dword [eax+0x101bb06c], 0x0 */
            ii(0x1012_1908, 2); if(jzd(0x1012_194c, 0x42)) goto l_0x1012_194c; /* jz 0x1012194c */
            ii(0x1012_190a, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_190e, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1911, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_1917, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1012_191a, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1012_191e, 2); if(jzd(0x1012_1934, 0x14)) goto l_0x1012_1934; /* jz 0x10121934 */
            ii(0x1012_1920, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_1922, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1012_1925, 5); calld(Definitions.my_dtor_d3, -0x4_9bf7); /* call 0x100d7d33 */
            ii(0x1012_192a, 5); calld(Definitions.sys_delete, 0x4_4635); /* call 0x10165f64 */
            ii(0x1012_192f, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1012_1932, 2); jmpd(0x1012_193b, 0x7); goto l_0x1012_193b; /* jmp 0x1012193b */
        l_0x1012_1934:
            ii(0x1012_1934, 7); mov(memd_a32[ss, ebp - 0x40], 0);       /* mov dword [ebp-0x40], 0x0 */
        l_0x1012_193b:
            ii(0x1012_193b, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_193f, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1942, 10); mov(memd_a32[ds, eax + 0x101b_b06c], 0); /* mov dword [eax+0x101bb06c], 0x0 */
        l_0x1012_194c:
            ii(0x1012_194c, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_1950, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1953, 7); cmp(memd_a32[ds, eax + 0x101b_b070], 0); /* cmp dword [eax+0x101bb070], 0x0 */
            ii(0x1012_195a, 2); if(jzd(0x1012_197f, 0x23)) goto l_0x1012_197f; /* jz 0x1012197f */
            ii(0x1012_195c, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_1960, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1963, 6); mov(eax, memd_a32[ds, eax + 0x101b_b070]); /* mov eax, [eax+0x101bb070] */
            ii(0x1012_1969, 5); calld(Definitions.sys_delete, 0x4_45f6); /* call 0x10165f64 */
            ii(0x1012_196e, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_1972, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1975, 10); mov(memd_a32[ds, eax + 0x101b_b070], 0); /* mov dword [eax+0x101bb070], 0x0 */
        l_0x1012_197f:
            ii(0x1012_197f, 5); jmpd(0x1012_1892, -0xf2); goto l_0x1012_1892; /* jmp 0x10121892 */
        l_0x1012_1984:
            ii(0x1012_1984, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_1987, 6); cmp(memw_a32[ds, eax + 0x40], 0x6cd);   /* cmp word [eax+0x40], 0x6cd */
            ii(0x1012_198d, 2); if(jnzd(0x1012_1999, 0xa)) goto l_0x1012_1999; /* jnz 0x10121999 */
            ii(0x1012_198f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_1994, 5); calld(0x1010_0efe, -0x2_0a9b);          /* call 0x10100efe */
        l_0x1012_1999:
            ii(0x1012_1999, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_199e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_19a1, 5); calld(0x100d_6999, -0x4_b00d);          /* call 0x100d6999 */
            ii(0x1012_19a6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_19a9, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1012_19b0, 2); if(jzd(0x1012_19ba, 0x8)) goto l_0x1012_19ba; /* jz 0x101219ba */
            ii(0x1012_19b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_19b5, 5); calld(Definitions.sys_delete, 0x4_45aa); /* call 0x10165f64 */
        l_0x1012_19ba:
            ii(0x1012_19ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_19bd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_19c0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_19c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_19c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_19c6, 1); popd(edi);                              /* pop edi */
            ii(0x1012_19c7, 1); popd(esi);                              /* pop esi */
            ii(0x1012_19c8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_19c9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_19ca, 1); retd(); return;                         /* ret */
        }
    }
}
