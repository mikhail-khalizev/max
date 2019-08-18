using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2119-b8354fb4")]
        public void Method_1010_2119()
        {
            ii(0x1010_2119, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x1010_211e, 5); calld(Definitions.sys_check_available_stack_size, 0x6_3c2f); /* call 0x10165d52 */
            ii(0x1010_2123, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2124, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2125, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2126, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2128, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1010_212e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_2131, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_2134, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_2137, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1010_213a, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_213e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_2144, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1010_2149, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_214b, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1010_214e, 5); calld(0x1010_2b84, 0xa31);              /* call 0x10102b84 */
            ii(0x1010_2153, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_2158, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2159, 5); calld(0x1010_2ba4, 0xa46);              /* call 0x10102ba4 */
            ii(0x1010_215e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_2163, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2164, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_2166, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2167, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_216b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_216c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_2170, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2171, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_2173, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1010_2177, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_217b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_217e, 5); calld(0x1015_a2da, 0x5_8157);           /* call 0x1015a2da */
            ii(0x1010_2183, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_2186, 5); calld(0x1007_6574, -0x8_bc17);          /* call 0x10076574 */
            ii(0x1010_218b, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_218e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_2191, 7); test(memd_a32[ss, ebp - 0x1c], 0x100_0000); /* test dword [ebp-0x1c], 0x1000000 */
            ii(0x1010_2198, 2); if(jzd(0x1010_21ae, 0x14)) goto l_0x1010_21ae; /* jz 0x101021ae */
            ii(0x1010_219a, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x1010_219d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_21a1, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_21a5, 5); calld(0x1007_4048, -0x8_e162);          /* call 0x10074048 */
            ii(0x1010_21aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_21ac, 2); if(jnzd(0x1010_21b3, 0x5)) goto l_0x1010_21b3; /* jnz 0x101021b3 */
        l_0x1010_21ae:
            ii(0x1010_21ae, 5); jmpd(0x1010_2231, 0x7e); goto l_0x1010_2231; /* jmp 0x10102231 */
        l_0x1010_21b3:
            ii(0x1010_21b3, 7); test(memd_a32[ss, ebp - 0x1c], 0x10);   /* test dword [ebp-0x1c], 0x10 */
            ii(0x1010_21ba, 2); if(jzd(0x1010_21c5, 0x9)) goto l_0x1010_21c5; /* jz 0x101021c5 */
            ii(0x1010_21bc, 7); mov(memd_a32[ss, ebp - 0x20], 0x11);    /* mov dword [ebp-0x20], 0x11 */
            ii(0x1010_21c3, 2); jmpd(0x1010_21cc, 0x7); goto l_0x1010_21cc; /* jmp 0x101021cc */
        l_0x1010_21c5:
            ii(0x1010_21c5, 7); mov(memd_a32[ss, ebp - 0x20], 0x12);    /* mov dword [ebp-0x20], 0x12 */
        l_0x1010_21cc:
            ii(0x1010_21cc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_21cf, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_21d2, 5); calld(0x1010_2b84, 0x9ad);              /* call 0x10102b84 */
            ii(0x1010_21d7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_21dc, 1); pushd(eax);                             /* push eax */
            ii(0x1010_21dd, 5); calld(0x1010_2ba4, 0x9c2);              /* call 0x10102ba4 */
            ii(0x1010_21e2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_21e7, 1); pushd(eax);                             /* push eax */
            ii(0x1010_21e8, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1010_21ec, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x1010_21ef, 6); mov(edx, memd_a32[ds, edx + 0x101c_81c6]); /* mov edx, [edx+0x101c81c6] */
            ii(0x1010_21f5, 3); mov(dl, memb_a32[ds, edx + 0x1]);       /* mov dl, [edx+0x1] */
            ii(0x1010_21f8, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1010_21fe, 5); calld(/* sys */ 0x1016_5e9b, 0x6_3c98); /* call 0x10165e9b */
            ii(0x1010_2203, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1010_2206, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1010_2209, 1); cwde();                                 /* cwde */
            ii(0x1010_220a, 1); pushd(eax);                             /* push eax */
            ii(0x1010_220b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_220f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2210, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_2214, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2215, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_2217, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1010_221b, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1010_221f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_2222, 5); calld(0x1015_a2da, 0x5_80b3);           /* call 0x1015a2da */
            ii(0x1010_2227, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2229, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_222c, 5); calld(0x1007_5f2c, -0x8_c305);          /* call 0x10075f2c */
        l_0x1010_2231:
            ii(0x1010_2231, 5); cmp(memw_a32[ss, ebp - 0xc], 0x28);     /* cmp word [ebp-0xc], 0x28 */
            ii(0x1010_2236, 2); if(jnzd(0x1010_224d, 0x15)) goto l_0x1010_224d; /* jnz 0x1010224d */
            ii(0x1010_2238, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_223c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_2240, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_2243, 5); calld(0x1007_6600, -0x8_bc48);          /* call 0x10076600 */
            ii(0x1010_2248, 5); calld(0x1016_3263, 0x6_1016);           /* call 0x10163263 */
        l_0x1010_224d:
            ii(0x1010_224d, 7); test(memd_a32[ss, ebp - 0x1c], 0x80_0018); /* test dword [ebp-0x1c], 0x800018 */
            ii(0x1010_2254, 2); if(jzd(0x1010_2263, 0xd)) goto l_0x1010_2263; /* jz 0x10102263 */
            ii(0x1010_2256, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_2259, 5); calld(0x1007_6600, -0x8_bc5e);          /* call 0x10076600 */
            ii(0x1010_225e, 5); calld(0x1015_ec73, 0x5_ca10);           /* call 0x1015ec73 */
        l_0x1010_2263:
            ii(0x1010_2263, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2265, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_2268, 5); calld(0x1007_5f2c, -0x8_c341);          /* call 0x10075f2c */
            ii(0x1010_226d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_226f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2270, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2271, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2272, 1); retd(); return;                         /* ret */
        }
    }
}
