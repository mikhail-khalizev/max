using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e2cafd62-5168-4504-97ee-276c4166bfc1")]
        public void Method_1009_24b6()
        {
            ii(0x1009_24b6, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1009_24bb, 5); calld(Definitions.sys_check_available_stack_size, 0xd_3892); /* call 0x10165d52 */
            ii(0x1009_24c0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_24c1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_24c2, 1); pushd(esi);                             /* push esi */
            ii(0x1009_24c3, 1); pushd(edi);                             /* push edi */
            ii(0x1009_24c4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_24c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_24c7, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_24cd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_24d0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_24d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_24d6, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_24d9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_24dc, 1); pushd(eax);                             /* push eax */
            ii(0x1009_24dd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_24df, 1); pushd(eax);                             /* push eax */
            ii(0x1009_24e0, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_24e3, 1); pushd(eax);                             /* push eax */
            ii(0x1009_24e4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_24e7, 1); pushd(eax);                             /* push eax */
            ii(0x1009_24e8, 3); lea(ecx, ebp - 0x10);                   /* lea ecx, [ebp-0x10] */
            ii(0x1009_24eb, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_24f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_24f3, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1009_24f5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_24f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_24fb, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_24fe, 5); calld(0x1014_2d0b, 0xb_0808);           /* call 0x10142d0b */
            ii(0x1009_2503, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1009_2507, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_250b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_250d, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_2511, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_2513, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1009_2516, 2); if(jged(0x1009_2521, 0x9)) goto l_0x1009_2521; /* jge 0x10092521 */
            ii(0x1009_2518, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_251c, 5); jmpd(0x1009_2621, 0x100); goto l_0x1009_2621; /* jmp 0x10092621 */
        l_0x1009_2521:
            ii(0x1009_2521, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2524, 3); mov(eax, memd_a32[ds, eax + 0x2b]);     /* mov eax, [eax+0x2b] */
            ii(0x1009_2527, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_252a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_252c, 2); if(jld(0x1009_253b, 0xd)) goto l_0x1009_253b; /* jl 0x1009253b */
            ii(0x1009_252e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2531, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1009_2534, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2537, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_2539, 2); if(jged(0x1009_253d, 0x2)) goto l_0x1009_253d; /* jge 0x1009253d */
        l_0x1009_253b:
            ii(0x1009_253b, 2); jmpd(0x1009_254a, 0xd); goto l_0x1009_254a; /* jmp 0x1009254a */
        l_0x1009_253d:
            ii(0x1009_253d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2540, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1009_2543, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2546, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_2548, 2); if(jged(0x1009_254c, 0x2)) goto l_0x1009_254c; /* jge 0x1009254c */
        l_0x1009_254a:
            ii(0x1009_254a, 2); jmpd(0x1009_2555, 0x9); goto l_0x1009_2555; /* jmp 0x10092555 */
        l_0x1009_254c:
            ii(0x1009_254c, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_2550, 5); jmpd(0x1009_2621, 0xcc); goto l_0x1009_2621; /* jmp 0x10092621 */
        l_0x1009_2555:
            ii(0x1009_2555, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2558, 4); mov(ax, memw_a32[ds, eax + 0x2d]);      /* mov ax, [eax+0x2d] */
            ii(0x1009_255c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_255f, 3); neg(memd_a32[ss, ebp - 0x14]);          /* neg dword [ebp-0x14] */
            ii(0x1009_2562, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2565, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1009_2568, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_256b, 2); neg(eax);                               /* neg eax */
            ii(0x1009_256d, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1009_2571, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_2573, 2); if(jged(0x1009_2582, 0xd)) goto l_0x1009_2582; /* jge 0x10092582 */
            ii(0x1009_2575, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2578, 4); mov(ax, memw_a32[ds, eax + 0x2f]);      /* mov ax, [eax+0x2f] */
            ii(0x1009_257c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_257f, 3); neg(memd_a32[ss, ebp - 0x14]);          /* neg dword [ebp-0x14] */
        l_0x1009_2582:
            ii(0x1009_2582, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2585, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1009_2588, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_258b, 2); neg(eax);                               /* neg eax */
            ii(0x1009_258d, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1009_2591, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_2593, 2); if(jged(0x1009_25a2, 0xd)) goto l_0x1009_25a2; /* jge 0x100925a2 */
            ii(0x1009_2595, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2598, 4); mov(ax, memw_a32[ds, eax + 0x2b]);      /* mov ax, [eax+0x2b] */
            ii(0x1009_259c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_259f, 3); neg(memd_a32[ss, ebp - 0x14]);          /* neg dword [ebp-0x14] */
        l_0x1009_25a2:
            ii(0x1009_25a2, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_25a6, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_25a9, 2); if(jld(0x1009_25b2, 0x7)) goto l_0x1009_25b2; /* jl 0x100925b2 */
            ii(0x1009_25ab, 7); mov(memd_a32[ss, ebp - 0x14], 0x8);     /* mov dword [ebp-0x14], 0x8 */
        l_0x1009_25b2:
            ii(0x1009_25b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_25b5, 3); mov(eax, memd_a32[ds, eax + 0x2b]);     /* mov eax, [eax+0x2b] */
            ii(0x1009_25b8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_25bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_25bd, 2); neg(edx);                               /* neg edx */
            ii(0x1009_25bf, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_25c3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_25c5, 2); if(jld(0x1009_25d6, 0xf)) goto l_0x1009_25d6; /* jl 0x100925d6 */
            ii(0x1009_25c7, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_25cb, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_25ce, 2); if(jld(0x1009_25d6, 0x6)) goto l_0x1009_25d6; /* jl 0x100925d6 */
            ii(0x1009_25d0, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_25d4, 2); jmpd(0x1009_2621, 0x4b); goto l_0x1009_2621; /* jmp 0x10092621 */
        l_0x1009_25d6:
            ii(0x1009_25d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_25d9, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1009_25dc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_25df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_25e1, 2); neg(edx);                               /* neg edx */
            ii(0x1009_25e3, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_25e7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_25e9, 2); if(jld(0x1009_25fa, 0xf)) goto l_0x1009_25fa; /* jl 0x100925fa */
            ii(0x1009_25eb, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_25ef, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_25f2, 2); if(jld(0x1009_25fa, 0x6)) goto l_0x1009_25fa; /* jl 0x100925fa */
            ii(0x1009_25f4, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_25f8, 2); jmpd(0x1009_2621, 0x27); goto l_0x1009_2621; /* jmp 0x10092621 */
        l_0x1009_25fa:
            ii(0x1009_25fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_25fd, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1009_2600, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2603, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_2605, 2); neg(edx);                               /* neg edx */
            ii(0x1009_2607, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_260b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_260d, 2); if(jld(0x1009_261d, 0xe)) goto l_0x1009_261d; /* jl 0x1009261d */
            ii(0x1009_260f, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_2613, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_2615, 2); if(jled(0x1009_261d, 0x6)) goto l_0x1009_261d; /* jle 0x1009261d */
            ii(0x1009_2617, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_261b, 2); jmpd(0x1009_2621, 0x4); goto l_0x1009_2621; /* jmp 0x10092621 */
        l_0x1009_261d:
            ii(0x1009_261d, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1009_2621:
            ii(0x1009_2621, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_2624, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_2626, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_2627, 1); popd(edi);                              /* pop edi */
            ii(0x1009_2628, 1); popd(esi);                              /* pop esi */
            ii(0x1009_2629, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_262a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_262b, 1); retd(); return;                         /* ret */
        }
    }
}
