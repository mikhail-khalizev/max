using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("168a73e7-38fa-4f97-8736-5a7d1d61d0dd")]
        public void Method_1011_2206()
        {
            ii(0x1011_2206, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_220b, 5); calld(Definitions.sys_check_available_stack_size, 0x53b42); /* call 0x10165d52 */
            ii(0x1011_2210, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_2211, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_2212, 1); pushd(edx);                             /* push edx */
            ii(0x1011_2213, 1); pushd(esi);                             /* push esi */
            ii(0x1011_2214, 1); pushd(edi);                             /* push edi */
            ii(0x1011_2215, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_2216, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_2218, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_221e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_2221, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2224, 7); cmp(memd_a32[ds, eax + 0x19e], 0);      /* cmp dword [eax+0x19e], 0x0 */
            ii(0x1011_222b, 6); if(jzd(0x1011_2411, 0x1e0)) goto l_0x1011_2411; /* jz 0x10112411 */
            ii(0x1011_2231, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2234, 6); mov(eax, memd_a32[ds, eax + 0x19e]);    /* mov eax, [eax+0x19e] */
            ii(0x1011_223a, 5); calld(0x100e_b68a, -0x26bb5);           /* call 0x100eb68a */
            ii(0x1011_223f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2242, 6); mov(eax, memd_a32[ds, eax + 0x19e]);    /* mov eax, [eax+0x19e] */
            ii(0x1011_2248, 5); calld(0x100e_b226, -0x27027);           /* call 0x100eb226 */
            ii(0x1011_224d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2250, 6); mov(edx, memd_a32[ds, eax + 0x19e]);    /* mov edx, [eax+0x19e] */
            ii(0x1011_2256, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2259, 6); cmp(edx, memd_a32[ds, eax + 0x196]);    /* cmp edx, [eax+0x196] */
            ii(0x1011_225f, 6); if(jnzd(0x1011_2385, 0x120)) goto l_0x1011_2385; /* jnz 0x10112385 */
            ii(0x1011_2265, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_2268, 6); add(edx, 0x1a2);                        /* add edx, 0x1a2 */
            ii(0x1011_226e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2271, 5); add(eax, 0x21a);                        /* add eax, 0x21a */
            ii(0x1011_2276, 5); calld(Definitions.sys_strcpy, 0x53c54); /* call 0x10165ecf */
            ii(0x1011_227b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_227e, 5); add(eax, 0x21a);                        /* add eax, 0x21a */
            ii(0x1011_2283, 5); calld(Definitions.sys_strlen, 0x5fc3f); /* call 0x10171ec7 */
            ii(0x1011_2288, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_228a, 2); if(jnzd(0x1011_229e, 0x12)) goto l_0x1011_229e; /* jnz 0x1011229e */
            ii(0x1011_228c, 5); mov(edx, 0x101a_471e);                  /* mov edx, 0x101a471e */ /* "No Name" */
            ii(0x1011_2291, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2294, 5); add(eax, 0x21a);                        /* add eax, 0x21a */
            ii(0x1011_2299, 5); calld(Definitions.sys_strcpy, 0x53c31); /* call 0x10165ecf */
        l_0x1011_229e:
            ii(0x1011_229e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_22a1, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_22a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_22a6, 6); mov(eax, memd_a32[ds, eax + 0x5a1]);    /* mov eax, [eax+0x5a1] */
            ii(0x1011_22ac, 5); calld(0x100d_7f6c, -0x3a345);           /* call 0x100d7f6c */
            ii(0x1011_22b1, 5); calld(0x1011_5318, 0x3062);             /* call 0x10115318 */
            ii(0x1011_22b6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_22bb, 1); pushd(eax);                             /* push eax */
            ii(0x1011_22bc, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1011_22c1, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1011_22c6, 5); mov(edx, 0x101b_9da0);                  /* mov edx, 0x101b9da0 */
            ii(0x1011_22cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_22ce, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_22d0, 5); calld(0x1010_8a05, -0x98d0);            /* call 0x10108a05 */
            ii(0x1011_22d5, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1011_22d8, 6); add(ebx, 0x21a);                        /* add ebx, 0x21a */
            ii(0x1011_22de, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1011_22e3, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_22e8, 5); calld(0x1010_6205, -0xc0e8);            /* call 0x10106205 */
            ii(0x1011_22ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_22f0, 3); mov(al, memb_a32[ds, eax + 0x11]);      /* mov al, [eax+0x11] */
            ii(0x1011_22f3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_22f8, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1011_22fd, 6); if(jzd(0x1011_2383, 0x80)) goto l_0x1011_2383; /* jz 0x10112383 */
            ii(0x1011_2303, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2306, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_2308, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_230b, 3); mov(al, memb_a32[ds, eax + 0x11]);      /* mov al, [eax+0x11] */
            ii(0x1011_230e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2313, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2316, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_2319, 6); mov(eax, memd_a32[ds, eax + 0x5a9]);    /* mov eax, [eax+0x5a9] */
            ii(0x1011_231f, 5); calld(0x100d_7f6c, -0x3a3b8);           /* call 0x100d7f6c */
            ii(0x1011_2324, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_2327, 6); add(edx, 0x21a);                        /* add edx, 0x21a */
            ii(0x1011_232d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2330, 3); mov(al, memb_a32[ds, eax + 0x11]);      /* mov al, [eax+0x11] */
            ii(0x1011_2333, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2338, 3); imul(ebx, eax, 0x1e);                   /* imul ebx, eax, 0x1e */
            ii(0x1011_233b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_233e, 5); add(eax, 0x338);                        /* add eax, 0x338 */
            ii(0x1011_2343, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_2345, 5); calld(Definitions.sys_strcpy, 0x53b85); /* call 0x10165ecf */
            ii(0x1011_234a, 5); calld(0x1011_5318, 0x2fc9);             /* call 0x10115318 */
            ii(0x1011_234f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2354, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2355, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_2357, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1011_235c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_235f, 3); mov(al, memb_a32[ds, eax + 0x11]);      /* mov al, [eax+0x11] */
            ii(0x1011_2362, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2367, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1011_236a, 3); imul(edx, eax, 0x14);                   /* imul edx, eax, 0x14 */
            ii(0x1011_236d, 5); mov(eax, 0x101b_9d8c);                  /* mov eax, 0x101b9d8c */
            ii(0x1011_2372, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_2374, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2377, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_2379, 5); calld(0x1010_8a05, -0x9979);            /* call 0x10108a05 */
            ii(0x1011_237e, 5); calld(0x1012_a9e3, 0x18660);            /* call 0x1012a9e3 */
        l_0x1011_2383:
            ii(0x1011_2383, 2); jmpd(0x1011_23f7, 0x72); goto l_0x1011_23f7; /* jmp 0x101123f7 */
        l_0x1011_2385:
            ii(0x1011_2385, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2388, 4); cmp(memd_a32[ds, eax + 0x4], 0x1b);     /* cmp dword [eax+0x4], 0x1b */
            ii(0x1011_238c, 2); if(jnzd(0x1011_2398, 0xa)) goto l_0x1011_2398; /* jnz 0x10112398 */
            ii(0x1011_238e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2391, 7); mov(memb_a32[ds, eax + 0x1a2], 0);      /* mov byte [eax+0x1a2], 0x0 */
        l_0x1011_2398:
            ii(0x1011_2398, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_239b, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_239d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_23a0, 6); mov(eax, memd_a32[ds, eax + 0x5b9]);    /* mov eax, [eax+0x5b9] */
            ii(0x1011_23a6, 5); calld(0x100d_7f6c, -0x3a43f);           /* call 0x100d7f6c */
            ii(0x1011_23ab, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_23ae, 6); add(edx, 0x1a2);                        /* add edx, 0x1a2 */
            ii(0x1011_23b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_23b7, 5); add(eax, 0x3b0);                        /* add eax, 0x3b0 */
            ii(0x1011_23bc, 5); calld(Definitions.sys_strcpy, 0x53b0e); /* call 0x10165ecf */
            ii(0x1011_23c1, 5); calld(0x1011_5318, 0x2f52);             /* call 0x10115318 */
            ii(0x1011_23c6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_23cb, 1); pushd(eax);                             /* push eax */
            ii(0x1011_23cc, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1011_23d1, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1011_23d6, 5); mov(edx, 0x101b_9e18);                  /* mov edx, 0x101b9e18 */
            ii(0x1011_23db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_23de, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_23e0, 5); calld(0x1010_8a05, -0x99e0);            /* call 0x10108a05 */
            ii(0x1011_23e5, 5); calld(0x1012_aa40, 0x18656);            /* call 0x1012aa40 */
            ii(0x1011_23ea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_23ec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_23ef, 3); mov(eax, memd_a32[ds, eax + 0x5a]);     /* mov eax, [eax+0x5a] */
            ii(0x1011_23f2, 5); calld(0x100c_fb73, -0x42884);           /* call 0x100cfb73 */
        l_0x1011_23f7:
            ii(0x1011_23f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_23fa, 10); mov(memd_a32[ds, eax + 0x19e], 0);     /* mov dword [eax+0x19e], 0x0 */
            ii(0x1011_2404, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2407, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_2409, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1011_240c, 5); calld(Definitions.sys_display_draw_0, 0x55073); /* call 0x10167484 */
        l_0x1011_2411:
            ii(0x1011_2411, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_2413, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_2414, 1); popd(edi);                              /* pop edi */
            ii(0x1011_2415, 1); popd(esi);                              /* pop esi */
            ii(0x1011_2416, 1); popd(edx);                              /* pop edx */
            ii(0x1011_2417, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_2418, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_2419, 1); retd(); return;                         /* ret */
        }
    }
}
