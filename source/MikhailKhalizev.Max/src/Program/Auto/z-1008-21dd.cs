using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_21dd-b964fb6d")]
        public void Method_1008_21dd()
        {
            ii(0x1008_21dd, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1008_21e2, 5); calld(Definitions.sys_check_available_stack_size, 0xe_3b6b); /* call 0x10165d52 */
            ii(0x1008_21e7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_21e8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_21e9, 1); pushd(edx);                             /* push edx */
            ii(0x1008_21ea, 1); pushd(esi);                             /* push esi */
            ii(0x1008_21eb, 1); pushd(edi);                             /* push edi */
            ii(0x1008_21ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_21ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_21ef, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_21f5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_21f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_21fb, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_21fe, 5); calld(0x1008_9d08, 0x7b05);             /* call 0x10089d08 */
            ii(0x1008_2203, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2205, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_2208, 5); calld(0x1008_9be4, 0x79d7);             /* call 0x10089be4 */
            ii(0x1008_220d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_220f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2212, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_2215, 5); calld(0x1013_ad71, 0xb_8b57);           /* call 0x1013ad71 */
            ii(0x1008_221a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_221c, 2); if(jzd(0x1008_2245, 0x27)) goto l_0x1008_2245; /* jz 0x10082245 */
            ii(0x1008_221e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2221, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_2224, 5); calld(0x1008_9970, 0x7747);             /* call 0x10089970 */
            ii(0x1008_2229, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_222c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_222f, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_2232, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_2235, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
            ii(0x1008_2238, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_223a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_223d, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_2240, 5); calld(0x1008_99fc, 0x77b7);             /* call 0x100899fc */
        l_0x1008_2245:
            ii(0x1008_2245, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2247, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_224a, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_224d, 5); calld(0x1013_ad71, 0xb_8b1f);           /* call 0x1013ad71 */
            ii(0x1008_2252, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2254, 2); if(jzd(0x1008_2276, 0x20)) goto l_0x1008_2276; /* jz 0x10082276 */
            ii(0x1008_2256, 5); calld(0x1008_a79c, 0x8541);             /* call 0x1008a79c */
            ii(0x1008_225b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_225d, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_225f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2262, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_2265, 5); calld(0x1007_65d0, -0xbc9a);            /* call 0x100765d0 */
            ii(0x1008_226a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_226c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_2271, 5); calld(0x100a_53ac, 0x2_3136);           /* call 0x100a53ac */
        l_0x1008_2276:
            ii(0x1008_2276, 2); jmpd(0x1008_2280, 0x8); goto l_0x1008_2280; /* jmp 0x10082280 */
        l_0x1008_2278:
            ii(0x1008_2278, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_227b, 5); calld(0x1007_6bf8, -0xb688);            /* call 0x10076bf8 */
        l_0x1008_2280:
            ii(0x1008_2280, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2282, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_2285, 5); calld(0x1013_ad71, 0xb_8ae7);           /* call 0x1013ad71 */
            ii(0x1008_228a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_228c, 2); if(jzd(0x1008_22bb, 0x2d)) goto l_0x1008_22bb; /* jz 0x100822bb */
            ii(0x1008_228e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2290, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_2293, 5); calld(0x1008_9acc, 0x7834);             /* call 0x10089acc */
            ii(0x1008_2298, 5); calld(0x1008_9f38, 0x7c9b);             /* call 0x10089f38 */
            ii(0x1008_229d, 5); calld(0x100b_8e30, 0x3_6b8e);           /* call 0x100b8e30 */
            ii(0x1008_22a2, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_22a5, 5); calld(0x1008_9acc, 0x7822);             /* call 0x10089acc */
            ii(0x1008_22aa, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_22ad, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_22b0, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_22b3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_22b6, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
            ii(0x1008_22b9, 2); jmpd(0x1008_2278, -0x43); goto l_0x1008_2278; /* jmp 0x10082278 */
        l_0x1008_22bb:
            ii(0x1008_22bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_22be, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_22c1, 5); calld(0x1013_a6f4, 0xb_842e);           /* call 0x1013a6f4 */
            ii(0x1008_22c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_22c9, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_22cc, 5); calld(0x1013_a6f4, 0xb_8423);           /* call 0x1013a6f4 */
            ii(0x1008_22d1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_22d4, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_22d9, 5); calld(0x100a_5e27, 0x2_3b49);           /* call 0x100a5e27 */
            ii(0x1008_22de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_22e0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_22e3, 5); calld(0x1008_9044, 0x6d5c);             /* call 0x10089044 */
            ii(0x1008_22e8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_22ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_22eb, 1); popd(edi);                              /* pop edi */
            ii(0x1008_22ec, 1); popd(esi);                              /* pop esi */
            ii(0x1008_22ed, 1); popd(edx);                              /* pop edx */
            ii(0x1008_22ee, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_22ef, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_22f0, 1); retd();                                 /* ret */
        }
    }
}
