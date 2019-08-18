using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("95d0657d-6b4e-4e77-9c47-0308e797fc48")]
        public void Method_100e_185e()
        {
            ii(0x100e_185e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_1863, 5); calld(Definitions.sys_check_available_stack_size, 0x8_44ea); /* call 0x10165d52 */
            ii(0x100e_1868, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_1869, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_186a, 1); pushd(edx);                             /* push edx */
            ii(0x100e_186b, 1); pushd(esi);                             /* push esi */
            ii(0x100e_186c, 1); pushd(edi);                             /* push edi */
            ii(0x100e_186d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_186e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_1870, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_1876, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_1879, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_187b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_187e, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1881, 5); calld(0x1013_ad11, 0x5_948b);           /* call 0x1013ad11 */
            ii(0x100e_1886, 2); test(al, al);                           /* test al, al */
            ii(0x100e_1888, 2); if(jzd(0x100e_18a0, 0x16)) goto l_0x100e_18a0; /* jz 0x100e18a0 */
            ii(0x100e_188a, 5); calld(0x100d_51c4, -0xc6cb);            /* call 0x100d51c4 */
            ii(0x100e_188f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1891, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_1893, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_1896, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100e_1899, 5); calld(0x100c_fb06, -0x1_1d98);          /* call 0x100cfb06 */
            ii(0x100e_189e, 2); jmpd(0x100e_18bd, 0x1d); goto l_0x100e_18bd; /* jmp 0x100e18bd */
        l_0x100e_18a0:
            ii(0x100e_18a0, 5); calld(0x100d_51e4, -0xc6c1);            /* call 0x100d51e4 */
            ii(0x100e_18a5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_18a7, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_18a9, 5); calld(0x100d_5204, -0xc6aa);            /* call 0x100d5204 */
            ii(0x100e_18ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_18b0, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_18b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_18b5, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100e_18b8, 5); calld(0x100c_fa7c, -0x1_1e41);          /* call 0x100cfa7c */
        l_0x100e_18bd:
            ii(0x100e_18bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_18c0, 4); cmp(memd_a32[ds, eax + 0x18], 0);       /* cmp dword [eax+0x18], 0x0 */
            ii(0x100e_18c4, 6); if(jzd(0x100e_19ed, 0x123)) goto l_0x100e_19ed; /* jz 0x100e19ed */
            ii(0x100e_18ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_18cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_18cf, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_18d2, 5); calld(0x1013_ad71, 0x5_949a);           /* call 0x1013ad71 */
            ii(0x100e_18d7, 2); test(al, al);                           /* test al, al */
            ii(0x100e_18d9, 2); if(jzd(0x100e_18f6, 0x1b)) goto l_0x100e_18f6; /* jz 0x100e18f6 */
            ii(0x100e_18db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_18de, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_18e1, 5); calld(0x1007_65d0, -0x6_b316);          /* call 0x100765d0 */
            ii(0x100e_18e6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_18e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_18eb, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_18ed, 5); calld(0x100e_2f04, 0x1612);             /* call 0x100e2f04 */
            ii(0x100e_18f2, 2); test(al, al);                           /* test al, al */
            ii(0x100e_18f4, 2); if(jnzd(0x100e_18f8, 0x2)) goto l_0x100e_18f8; /* jnz 0x100e18f8 */
        l_0x100e_18f6:
            ii(0x100e_18f6, 2); jmpd(0x100e_1917, 0x1f); goto l_0x100e_1917; /* jmp 0x100e1917 */
        l_0x100e_18f8:
            ii(0x100e_18f8, 5); calld(0x100d_51e4, -0xc719);            /* call 0x100d51e4 */
            ii(0x100e_18fd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_18ff, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_1901, 5); calld(0x100d_5204, -0xc702);            /* call 0x100d5204 */
            ii(0x100e_1906, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1908, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_190a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_190d, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_1910, 5); calld(0x100c_fa7c, -0x1_1e99);          /* call 0x100cfa7c */
            ii(0x100e_1915, 2); jmpd(0x100e_192b, 0x14); goto l_0x100e_192b; /* jmp 0x100e192b */
        l_0x100e_1917:
            ii(0x100e_1917, 5); calld(0x100d_51c4, -0xc758);            /* call 0x100d51c4 */
            ii(0x100e_191c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_191e, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_1920, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_1923, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_1926, 5); calld(0x100c_fb06, -0x1_1e25);          /* call 0x100cfb06 */
        l_0x100e_192b:
            ii(0x100e_192b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_192d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_1930, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1933, 5); calld(0x1013_ad71, 0x5_9439);           /* call 0x1013ad71 */
            ii(0x100e_1938, 2); test(al, al);                           /* test al, al */
            ii(0x100e_193a, 2); if(jzd(0x100e_1957, 0x1b)) goto l_0x100e_1957; /* jz 0x100e1957 */
            ii(0x100e_193c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_193f, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1942, 5); calld(0x1007_65d0, -0x6_b377);          /* call 0x100765d0 */
            ii(0x100e_1947, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1949, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_194c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_194e, 5); calld(0x100e_2f92, 0x163f);             /* call 0x100e2f92 */
            ii(0x100e_1953, 2); test(al, al);                           /* test al, al */
            ii(0x100e_1955, 2); if(jnzd(0x100e_1959, 0x2)) goto l_0x100e_1959; /* jnz 0x100e1959 */
        l_0x100e_1957:
            ii(0x100e_1957, 2); jmpd(0x100e_1978, 0x1f); goto l_0x100e_1978; /* jmp 0x100e1978 */
        l_0x100e_1959:
            ii(0x100e_1959, 5); calld(0x100d_51e4, -0xc77a);            /* call 0x100d51e4 */
            ii(0x100e_195e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_1960, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_1962, 5); calld(0x100d_5204, -0xc763);            /* call 0x100d5204 */
            ii(0x100e_1967, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1969, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_196b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_196e, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100e_1971, 5); calld(0x100c_fa7c, -0x1_1efa);          /* call 0x100cfa7c */
            ii(0x100e_1976, 2); jmpd(0x100e_198c, 0x14); goto l_0x100e_198c; /* jmp 0x100e198c */
        l_0x100e_1978:
            ii(0x100e_1978, 5); calld(0x100d_51c4, -0xc7b9);            /* call 0x100d51c4 */
            ii(0x100e_197d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_197f, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_1981, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_1984, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100e_1987, 5); calld(0x100c_fb06, -0x1_1e86);          /* call 0x100cfb06 */
        l_0x100e_198c:
            ii(0x100e_198c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_198e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_1991, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1994, 5); calld(0x1013_ad71, 0x5_93d8);           /* call 0x1013ad71 */
            ii(0x100e_1999, 2); test(al, al);                           /* test al, al */
            ii(0x100e_199b, 2); if(jzd(0x100e_19b8, 0x1b)) goto l_0x100e_19b8; /* jz 0x100e19b8 */
            ii(0x100e_199d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_19a0, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_19a3, 5); calld(0x1007_65d0, -0x6_b3d8);          /* call 0x100765d0 */
            ii(0x100e_19a8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_19aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_19ad, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_19af, 5); calld(0x100e_3020, 0x166c);             /* call 0x100e3020 */
            ii(0x100e_19b4, 2); test(al, al);                           /* test al, al */
            ii(0x100e_19b6, 2); if(jnzd(0x100e_19ba, 0x2)) goto l_0x100e_19ba; /* jnz 0x100e19ba */
        l_0x100e_19b8:
            ii(0x100e_19b8, 2); jmpd(0x100e_19d9, 0x1f); goto l_0x100e_19d9; /* jmp 0x100e19d9 */
        l_0x100e_19ba:
            ii(0x100e_19ba, 5); calld(0x100d_51e4, -0xc7db);            /* call 0x100d51e4 */
            ii(0x100e_19bf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_19c1, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_19c3, 5); calld(0x100d_5204, -0xc7c4);            /* call 0x100d5204 */
            ii(0x100e_19c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_19ca, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_19cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_19cf, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100e_19d2, 5); calld(0x100c_fa7c, -0x1_1f5b);          /* call 0x100cfa7c */
            ii(0x100e_19d7, 2); jmpd(0x100e_19ed, 0x14); goto l_0x100e_19ed; /* jmp 0x100e19ed */
        l_0x100e_19d9:
            ii(0x100e_19d9, 5); calld(0x100d_51c4, -0xc81a);            /* call 0x100d51c4 */
            ii(0x100e_19de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_19e0, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_19e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_19e5, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100e_19e8, 5); calld(0x100c_fb06, -0x1_1ee7);          /* call 0x100cfb06 */
        l_0x100e_19ed:
            ii(0x100e_19ed, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_19ef, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_19f0, 1); popd(edi);                              /* pop edi */
            ii(0x100e_19f1, 1); popd(esi);                              /* pop esi */
            ii(0x100e_19f2, 1); popd(edx);                              /* pop edx */
            ii(0x100e_19f3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_19f4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_19f5, 1); retd(); return;                         /* ret */
        }
    }
}
