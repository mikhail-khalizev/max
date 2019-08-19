using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2204-a57c592")]
        public void Method_100a_2204()
        {
            ii(0x100a_2204, 5); pushd(0x3b0);                           /* push 0x3b0 */
            ii(0x100a_2209, 5); calld(Definitions.sys_check_available_stack_size, 0xc_3b44); /* call 0x10165d52 */
            ii(0x100a_220e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_220f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2210, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2211, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2212, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2213, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2215, 6); sub(esp, 0x398);                        /* sub esp, 0x398 */
            ii(0x100a_221b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_221e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_2221, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100a_2225, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_2228, 5); calld(0x1007_64fc, -0x2_bd31);          /* call 0x100764fc */
            ii(0x100a_222d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_2230, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100a_2234, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100a_2238, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100a_223b, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100a_223f, 6); lea(eax, ebp - 0x394);                  /* lea eax, [ebp-0x394] */
            ii(0x100a_2245, 5); calld(0x100a_0104, -0x2146);            /* call 0x100a0104 */
            ii(0x100a_224a, 6); mov(memd_a32[ss, ebp - 0x398], eax);    /* mov [ebp-0x398], eax */
            ii(0x100a_2250, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100a_2254, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_2258, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_225d, 5); calld(0x1007_6338, -0x2_bf2a);          /* call 0x10076338 */
            ii(0x100a_2262, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100a_2265, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_2267, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_2269, 5); calld(0x1007_643c, -0x2_be32);          /* call 0x1007643c */
        l_0x100a_226e:
            ii(0x100a_226e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_2270, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_2273, 5); calld(0x1013_ad71, 0x9_8af9);           /* call 0x1013ad71 */
            ii(0x100a_2278, 2); test(al, al);                           /* test al, al */
            ii(0x100a_227a, 2); if(jzd(0x100a_2287, 0xb)) goto l_0x100a_2287; /* jz 0x100a2287 */
            ii(0x100a_227c, 7); movsx(eax, memw_a32[ss, ebp - 0x368]);  /* movsx eax, word [ebp-0x368] */
            ii(0x100a_2283, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2285, 2); if(jgd(0x100a_228c, 0x5)) goto l_0x100a_228c; /* jg 0x100a228c */
        l_0x100a_2287:
            ii(0x100a_2287, 5); jmpd(0x100a_2398, 0x10c); goto l_0x100a_2398; /* jmp 0x100a2398 */
        l_0x100a_228c:
            ii(0x100a_228c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_228f, 5); calld(0x1007_63a0, -0x2_bef4);          /* call 0x100763a0 */
            ii(0x100a_2294, 5); calld(0x1007_6204, -0x2_c095);          /* call 0x10076204 */
            ii(0x100a_2299, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100a_229c, 2); if(jnzd(0x100a_22ac, 0xe)) goto l_0x100a_22ac; /* jnz 0x100a22ac */
            ii(0x100a_229e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_22a1, 5); calld(0x1007_63a0, -0x2_bf06);          /* call 0x100763a0 */
            ii(0x100a_22a6, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1f);    /* cmp byte [eax+0x3d], 0x1f */
            ii(0x100a_22aa, 2); if(jzd(0x100a_22ae, 0x2)) goto l_0x100a_22ae; /* jz 0x100a22ae */
        l_0x100a_22ac:
            ii(0x100a_22ac, 2); jmpd(0x100a_22c0, 0x12); goto l_0x100a_22c0; /* jmp 0x100a22c0 */
        l_0x100a_22ae:
            ii(0x100a_22ae, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_22b1, 5); calld(0x1007_63a0, -0x2_bf16);          /* call 0x100763a0 */
            ii(0x100a_22b6, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100a_22b9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_22bc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_22be, 2); if(jzd(0x100a_22c2, 0x2)) goto l_0x100a_22c2; /* jz 0x100a22c2 */
        l_0x100a_22c0:
            ii(0x100a_22c0, 2); jmpd(0x100a_22ee, 0x2c); goto l_0x100a_22ee; /* jmp 0x100a22ee */
        l_0x100a_22c2:
            ii(0x100a_22c2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_22c5, 5); calld(0x1007_63a0, -0x2_bf2a);          /* call 0x100763a0 */
            ii(0x100a_22ca, 5); calld(0x1015_14ef, 0xa_f220);           /* call 0x101514ef */
            ii(0x100a_22cf, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_22d2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_22d5, 5); calld(0x1007_63a0, -0x2_bf3a);          /* call 0x100763a0 */
            ii(0x100a_22da, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_22dd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_22e0, 5); calld(0x1007_1e00, -0x3_04e5);          /* call 0x10071e00 */
            ii(0x100a_22e5, 7); cmp(ax, memw_a32[ss, ebp - 0x368]);     /* cmp ax, [ebp-0x368] */
            ii(0x100a_22ec, 2); if(jled(0x100a_22f0, 0x2)) goto l_0x100a_22f0; /* jle 0x100a22f0 */
        l_0x100a_22ee:
            ii(0x100a_22ee, 2); jmpd(0x100a_230c, 0x1c); goto l_0x100a_230c; /* jmp 0x100a230c */
        l_0x100a_22f0:
            ii(0x100a_22f0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_22f3, 5); calld(0x1007_63a0, -0x2_bf58);          /* call 0x100763a0 */
            ii(0x100a_22f8, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_22fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_22fe, 5); calld(0x1007_1ff5, -0x3_030e);          /* call 0x10071ff5 */
            ii(0x100a_2303, 7); cmp(ax, memw_a32[ss, ebp - 0x362]);     /* cmp ax, [ebp-0x362] */
            ii(0x100a_230a, 2); if(jled(0x100a_2311, 0x5)) goto l_0x100a_2311; /* jle 0x100a2311 */
        l_0x100a_230c:
            ii(0x100a_230c, 5); jmpd(0x100a_238b, 0x7a); goto l_0x100a_238b; /* jmp 0x100a238b */
        l_0x100a_2311:
            ii(0x100a_2311, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_2314, 5); calld(0x1007_63a0, -0x2_bf79);          /* call 0x100763a0 */
            ii(0x100a_2319, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_231c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_231f, 5); calld(0x1007_1f2e, -0x3_03f6);          /* call 0x10071f2e */
            ii(0x100a_2324, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_2327, 6); lea(eax, ebp - 0x394);                  /* lea eax, [ebp-0x394] */
            ii(0x100a_232d, 5); calld(0x100a_11c4, -0x116e);            /* call 0x100a11c4 */
            ii(0x100a_2332, 2); test(al, al);                           /* test al, al */
            ii(0x100a_2334, 2); if(jzd(0x100a_238b, 0x55)) goto l_0x100a_238b; /* jz 0x100a238b */
            ii(0x100a_2336, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_2339, 5); calld(0x1007_63a0, -0x2_bf9e);          /* call 0x100763a0 */
            ii(0x100a_233e, 5); calld(0x1015_14ef, 0xa_f1ac);           /* call 0x101514ef */
            ii(0x100a_2343, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_2346, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_2349, 5); calld(0x1007_63a0, -0x2_bfae);          /* call 0x100763a0 */
            ii(0x100a_234e, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_2351, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_2354, 5); calld(0x1007_1e00, -0x3_0559);          /* call 0x10071e00 */
            ii(0x100a_2359, 7); sub(memw_a32[ss, ebp - 0x368], ax);     /* sub [ebp-0x368], ax */
            ii(0x100a_2360, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_2363, 5); calld(0x1007_63a0, -0x2_bfc8);          /* call 0x100763a0 */
            ii(0x100a_2368, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_236b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_236e, 5); calld(0x1007_1ff5, -0x3_037e);          /* call 0x10071ff5 */
            ii(0x100a_2373, 7); sub(memw_a32[ss, ebp - 0x362], ax);     /* sub [ebp-0x362], ax */
            ii(0x100a_237a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_237d, 5); calld(0x1007_63a0, -0x2_bfe2);          /* call 0x100763a0 */
            ii(0x100a_2382, 5); calld(0x1015_2387, 0xb_0000);           /* call 0x10152387 */
            ii(0x100a_2387, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100a_238b:
            ii(0x100a_238b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_238e, 5); calld(0x1007_6bf8, -0x2_b79b);          /* call 0x10076bf8 */
            ii(0x100a_2393, 5); jmpd(0x100a_226e, -0x12a); goto l_0x100a_226e; /* jmp 0x100a226e */
        l_0x100a_2398:
            ii(0x100a_2398, 6); lea(eax, ebp - 0x394);                  /* lea eax, [ebp-0x394] */
            ii(0x100a_239e, 5); calld(0x100a_08ce, -0x1ad5);            /* call 0x100a08ce */
            ii(0x100a_23a3, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_23a6, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100a_23a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_23ab, 6); lea(eax, ebp - 0x394);                  /* lea eax, [ebp-0x394] */
            ii(0x100a_23b1, 5); calld(0x100a_a698, 0x82e2);             /* call 0x100aa698 */
            ii(0x100a_23b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_23b8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_23bb, 5); calld(0x1007_5f6c, -0x2_c454);          /* call 0x10075f6c */
            ii(0x100a_23c0, 2); jmpd(0x100a_23d9, 0x17); goto l_0x100a_23d9; /* jmp 0x100a23d9 */
        //  ii(0x100a_23c2, 23); Недостижимый код.
        l_0x100a_23d9:
            ii(0x100a_23d9, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100a_23dc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_23de, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_23df, 1); popd(edi);                              /* pop edi */
            ii(0x100a_23e0, 1); popd(esi);                              /* pop esi */
            ii(0x100a_23e1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_23e2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_23e3, 1); retd(); return;                         /* ret */
        }
    }
}
