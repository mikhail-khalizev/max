using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4930a5ac-eff0-4f17-9b68-93bccdf6a329")]
        public void Method_1011_241a()
        {
            ii(0x1011_241a, 5); pushd(0x7c);                            /* push 0x7c */
            ii(0x1011_241f, 5); calld(Definitions.sys_check_available_stack_size, 0x5392e); /* call 0x10165d52 */
            ii(0x1011_2424, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_2425, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_2426, 1); pushd(esi);                             /* push esi */
            ii(0x1011_2427, 1); pushd(edi);                             /* push edi */
            ii(0x1011_2428, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_2429, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_242b, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1011_2431, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_2434, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_2437, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_243b, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1011_243e, 5); mov(edx, 0x101b_9ea4);                  /* mov edx, 0x101b9ea4 */
            ii(0x1011_2443, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_2445, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_2448, 4); cmp(memb_a32[ss, ebp - 0x4], 0x13);     /* cmp byte [ebp-0x4], 0x13 */
            ii(0x1011_244c, 2); if(jld(0x1011_245a, 0xc)) goto l_0x1011_245a; /* jl 0x1011245a */
            ii(0x1011_244e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_2453, 5); calld(/* sys */ 0x1016_a24c, 0x57df4);  /* call 0x1016a24c */
            ii(0x1011_2458, 2); jmpd(0x1011_2464, 0xa); goto l_0x1011_2464; /* jmp 0x10112464 */
        l_0x1011_245a:
            ii(0x1011_245a, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_245f, 5); calld(/* sys */ 0x1016_a24c, 0x57de8);  /* call 0x1016a24c */
        l_0x1011_2464:
            ii(0x1011_2464, 4); cmp(memb_a32[ss, ebp - 0x4], 0x1);      /* cmp byte [ebp-0x4], 0x1 */
            ii(0x1011_2468, 6); if(jnzd(0x1011_2523, 0xb5)) goto l_0x1011_2523; /* jnz 0x10112523 */
            ii(0x1011_246e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2471, 3); mov(al, memb_a32[ds, eax + 0x12]);      /* mov al, [eax+0x12] */
            ii(0x1011_2474, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_2476, 5); add(eax, 0x2d5);                        /* add eax, 0x2d5 */
            ii(0x1011_247b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_247e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2481, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1011_2484, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_2487, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_248a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_248d, 7); cmp(memb_a32[ds, eax + 0x51f], 0);      /* cmp byte [eax+0x51f], 0x0 */
            ii(0x1011_2494, 2); if(jzd(0x1011_249c, 0x6)) goto l_0x1011_249c; /* jz 0x1011249c */
            ii(0x1011_2496, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_2499, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1011_249c:
            ii(0x1011_249c, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1011_24a1, 5); calld(Definitions.sys_new, 0x5395a);    /* call 0x10165e00 */
            ii(0x1011_24a6, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_24a9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_24ac, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_24af, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1011_24b3, 2); if(jzd(0x1011_24e6, 0x31)) goto l_0x1011_24e6; /* jz 0x101124e6 */
            ii(0x1011_24b5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_24b8, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_24ba, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_24bd, 1); pushd(eax);                             /* push eax */
            ii(0x1011_24be, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_24c1, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1011_24c4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_24c7, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1011_24cb, 1); inc(eax);                               /* inc eax */
            ii(0x1011_24cc, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_24cf, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1011_24d3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_24d6, 5); calld(Definitions.my_ctor_c17, -0x440cc); /* call 0x100ce40f */
            ii(0x1011_24db, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_24de, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1011_24e1, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_24e4, 2); jmpd(0x1011_24ec, 0x6); goto l_0x1011_24ec; /* jmp 0x101124ec */
        l_0x1011_24e6:
            ii(0x1011_24e6, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_24e9, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1011_24ec:
            ii(0x1011_24ec, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_24f0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_24f3, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1011_24f6, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1011_24f8, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_24fb, 3); mov(memd_a32[ds, ecx + 0x16], eax);     /* mov [ecx+0x16], eax */
            ii(0x1011_24fe, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x1011_2503, 5); mov(ebx, 0x29);                         /* mov ebx, 0x29 */
            ii(0x1011_2508, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_250c, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2510, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2513, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_2516, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_2519, 5); calld(0x100c_ed1b, -0x43803);           /* call 0x100ced1b */
            ii(0x1011_251e, 5); jmpd(0x1011_2662, 0x13f); goto l_0x1011_2662; /* jmp 0x10112662 */
        l_0x1011_2523:
            ii(0x1011_2523, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2526, 5); cmp(memw_a32[ds, eax + 0x8], -0x1 /* 0xff */); /* cmp word [eax+0x8], 0xffff */
            ii(0x1011_252b, 6); if(jnzd(0x1011_25a8, 0x77)) goto l_0x1011_25a8; /* jnz 0x101125a8 */
            ii(0x1011_2531, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1011_2536, 5); calld(Definitions.sys_new, 0x538c5);    /* call 0x10165e00 */
            ii(0x1011_253b, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_253e, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_2541, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_2544, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1011_2548, 2); if(jzd(0x1011_258b, 0x41)) goto l_0x1011_258b; /* jz 0x1011258b */
            ii(0x1011_254a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_254d, 4); mov(ax, memw_a32[ds, eax + 0x6]);       /* mov ax, [eax+0x6] */
            ii(0x1011_2551, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_2554, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x1011_2558, 1); cwde();                                 /* cwde */
            ii(0x1011_2559, 1); pushd(eax);                             /* push eax */
            ii(0x1011_255a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_255d, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1011_2561, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_2564, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1011_2567, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_256a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_256d, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1011_256f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_2572, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2575, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_2578, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_257b, 5); calld(0x100c_e39d, -0x441e3);           /* call 0x100ce39d */
            ii(0x1011_2580, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1011_2583, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1011_2586, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1011_2589, 2); jmpd(0x1011_2591, 0x6); goto l_0x1011_2591; /* jmp 0x10112591 */
        l_0x1011_258b:
            ii(0x1011_258b, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_258e, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1011_2591:
            ii(0x1011_2591, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2595, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2598, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_259b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_259d, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1011_25a0, 3); mov(memd_a32[ds, edx + 0x16], eax);     /* mov [edx+0x16], eax */
            ii(0x1011_25a3, 5); jmpd(0x1011_2662, 0xba); goto l_0x1011_2662; /* jmp 0x10112662 */
        l_0x1011_25a8:
            ii(0x1011_25a8, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1011_25ad, 5); calld(Definitions.sys_new, 0x5384e);    /* call 0x10165e00 */
            ii(0x1011_25b2, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1011_25b5, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1011_25b8, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1011_25bb, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1011_25bf, 2); if(jzd(0x1011_25f7, 0x36)) goto l_0x1011_25f7; /* jz 0x101125f7 */
            ii(0x1011_25c1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_25c4, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_25c6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_25c9, 1); pushd(eax);                             /* push eax */
            ii(0x1011_25ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_25cd, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1011_25d0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_25d3, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1011_25d7, 1); inc(eax);                               /* inc eax */
            ii(0x1011_25d8, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_25db, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_25de, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1011_25e1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_25e4, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1011_25e7, 5); calld(Definitions.my_ctor_c17, -0x441dd); /* call 0x100ce40f */
            ii(0x1011_25ec, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1011_25ef, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1011_25f2, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1011_25f5, 2); jmpd(0x1011_25fd, 0x6); goto l_0x1011_25fd; /* jmp 0x101125fd */
        l_0x1011_25f7:
            ii(0x1011_25f7, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1011_25fa, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x1011_25fd:
            ii(0x1011_25fd, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x1011_2601, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_2604, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x1011_2607, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1011_260a, 3); mov(memd_a32[ds, edx + 0x16], eax);     /* mov [edx+0x16], eax */
            ii(0x1011_260d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2610, 4); cmp(memd_a32[ds, eax + 0xa], 0);        /* cmp dword [eax+0xa], 0x0 */
            ii(0x1011_2614, 2); if(jzd(0x1011_2662, 0x4c)) goto l_0x1011_2662; /* jz 0x10112662 */
            ii(0x1011_2616, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1011_2619, 5); calld(0x100d_5224, -0x3d3fa);           /* call 0x100d5224 */
            ii(0x1011_261e, 1); pushd(eax);                             /* push eax */
            ii(0x1011_261f, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_2622, 5); calld(0x100d_5250, -0x3d3d7);           /* call 0x100d5250 */
            ii(0x1011_2627, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2628, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1011_262b, 5); calld(0x100d_527c, -0x3d3b4);           /* call 0x100d527c */
            ii(0x1011_2630, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2631, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1011_2634, 5); calld(0x100d_52a8, -0x3d391);           /* call 0x100d52a8 */
            ii(0x1011_2639, 1); pushd(eax);                             /* push eax */
            ii(0x1011_263a, 5); calld(0x100d_52d4, -0x3d36b);           /* call 0x100d52d4 */
            ii(0x1011_263f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_2642, 5); calld(0x100d_52f8, -0x3d34f);           /* call 0x100d52f8 */
            ii(0x1011_2647, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_264a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_264d, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x1011_2650, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2654, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2657, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_265a, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_265d, 5); calld(0x100c_ef64, -0x436fe);           /* call 0x100cef64 */
        l_0x1011_2662:
            ii(0x1011_2662, 4); cmp(memb_a32[ss, ebp - 0x4], 0xd);      /* cmp byte [ebp-0x4], 0xd */
            ii(0x1011_2666, 2); if(jld(0x1011_266e, 0x6)) goto l_0x1011_266e; /* jl 0x1011266e */
            ii(0x1011_2668, 4); cmp(memb_a32[ss, ebp - 0x4], 0x10);     /* cmp byte [ebp-0x4], 0x10 */
            ii(0x1011_266c, 2); if(jled(0x1011_2673, 0x5)) goto l_0x1011_2673; /* jle 0x10112673 */
        l_0x1011_266e:
            ii(0x1011_266e, 5); jmpd(0x1011_2707, 0x94); goto l_0x1011_2707; /* jmp 0x10112707 */
        l_0x1011_2673:
            ii(0x1011_2673, 5); mov(edx, 0x30e);                        /* mov edx, 0x30e */
            ii(0x1011_2678, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_267c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_267f, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_2682, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_2685, 5); calld(0x100c_f168, -0x43522);           /* call 0x100cf168 */
            ii(0x1011_268a, 5); mov(edx, 0x30e);                        /* mov edx, 0x30e */
            ii(0x1011_268f, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2693, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2696, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_2699, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_269c, 5); calld(0x100c_f2ba, -0x433e7);           /* call 0x100cf2ba */
            ii(0x1011_26a1, 5); mov(edx, 0x30a);                        /* mov edx, 0x30a */
            ii(0x1011_26a6, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_26aa, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_26ad, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_26b0, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_26b3, 5); calld(0x100c_f211, -0x434a7);           /* call 0x100cf211 */
            ii(0x1011_26b8, 5); mov(edx, 0x30a);                        /* mov edx, 0x30a */
            ii(0x1011_26bd, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_26c1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_26c4, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_26c7, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_26ca, 5); calld(0x100c_f363, -0x4336c);           /* call 0x100cf363 */
            ii(0x1011_26cf, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_26d4, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_26d8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_26db, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_26de, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_26e1, 5); calld(0x100d_5194, -0x3d552);           /* call 0x100d5194 */
            ii(0x1011_26e6, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_26ea, 6); lea(edx, eax + 0x3e8);                  /* lea edx, [eax+0x3e8] */
            ii(0x1011_26f0, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_26f4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_26f7, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_26fa, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_26fd, 5); calld(0x100d_5164, -0x3d59e);           /* call 0x100d5164 */
            ii(0x1011_2702, 5); jmpd(0x1011_27aa, 0xa3); goto l_0x1011_27aa; /* jmp 0x101127aa */
        l_0x1011_2707:
            ii(0x1011_2707, 4); cmp(memb_a32[ss, ebp - 0x4], 0x11);     /* cmp byte [ebp-0x4], 0x11 */
            ii(0x1011_270b, 2); if(jnzd(0x1011_275e, 0x51)) goto l_0x1011_275e; /* jnz 0x1011275e */
            ii(0x1011_270d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_2712, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2716, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2719, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_271c, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_271f, 5); calld(0x100d_5194, -0x3d590);           /* call 0x100d5194 */
            ii(0x1011_2724, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2728, 6); lea(edx, eax + 0x3e8);                  /* lea edx, [eax+0x3e8] */
            ii(0x1011_272e, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2732, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2735, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_2738, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_273b, 5); calld(0x100d_5134, -0x3d60c);           /* call 0x100d5134 */
            ii(0x1011_2740, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2744, 6); lea(edx, eax + 0x3e8);                  /* lea edx, [eax+0x3e8] */
            ii(0x1011_274a, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_274e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2751, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_2754, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_2757, 5); calld(0x100d_5164, -0x3d5f8);           /* call 0x100d5164 */
            ii(0x1011_275c, 2); jmpd(0x1011_27aa, 0x4c); goto l_0x1011_27aa; /* jmp 0x101127aa */
        l_0x1011_275e:
            ii(0x1011_275e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_2760, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2764, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2767, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_276a, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_276d, 5); calld(0x100d_5194, -0x3d5de);           /* call 0x100d5194 */
            ii(0x1011_2772, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2776, 6); lea(edx, eax + 0x3e8);                  /* lea edx, [eax+0x3e8] */
            ii(0x1011_277c, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2780, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2783, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_2786, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_2789, 5); calld(0x100d_5134, -0x3d65a);           /* call 0x100d5134 */
            ii(0x1011_278e, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2792, 6); lea(edx, eax + 0x7000);                 /* lea edx, [eax+0x7000] */
            ii(0x1011_2798, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_279c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_279f, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_27a2, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_27a5, 5); calld(0x100d_5164, -0x3d646);           /* call 0x100d5164 */
        l_0x1011_27aa:
            ii(0x1011_27aa, 4); cmp(memb_a32[ss, ebp - 0x4], 0x17);     /* cmp byte [ebp-0x4], 0x17 */
            ii(0x1011_27ae, 2); if(jzd(0x1011_27b6, 0x6)) goto l_0x1011_27b6; /* jz 0x101127b6 */
            ii(0x1011_27b0, 4); cmp(memb_a32[ss, ebp - 0x4], 0x16);     /* cmp byte [ebp-0x4], 0x16 */
            ii(0x1011_27b4, 2); if(jnzd(0x1011_27b8, 0x2)) goto l_0x1011_27b8; /* jnz 0x101127b8 */
        l_0x1011_27b6:
            ii(0x1011_27b6, 2); jmpd(0x1011_27be, 0x6); goto l_0x1011_27be; /* jmp 0x101127be */
        l_0x1011_27b8:
            ii(0x1011_27b8, 4); cmp(memb_a32[ss, ebp - 0x4], 0x11);     /* cmp byte [ebp-0x4], 0x11 */
            ii(0x1011_27bc, 2); if(jnzd(0x1011_27d5, 0x17)) goto l_0x1011_27d5; /* jnz 0x101127d5 */
        l_0x1011_27be:
            ii(0x1011_27be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_27c1, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_27c3, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_27c7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_27ca, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_27cd, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_27d0, 5); calld(0x100c_effe, -0x437d7);           /* call 0x100ceffe */
        l_0x1011_27d5:
            ii(0x1011_27d5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_27d8, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1011_27db, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_27de, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_27e2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_27e5, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_27e8, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_27eb, 5); calld(0x100d_50d4, -0x3d71c);           /* call 0x100d50d4 */
            ii(0x1011_27f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_27f3, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_27f5, 3); mov(edx, memd_a32[ds, edx + 0x12]);     /* mov edx, [edx+0x12] */
            ii(0x1011_27f8, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_27fc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_27ff, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_2802, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_2805, 5); calld(0x100c_f85c, -0x42fae);           /* call 0x100cf85c */
            ii(0x1011_280a, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x1011_280e, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2812, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1011_2815, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_2818, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1011_281e, 3); mov(memd_a32[ds, eax + 0x76], edx);     /* mov [eax+0x76], edx */
            ii(0x1011_2821, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_2825, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1011_2828, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_282b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_282d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2830, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1011_2833, 3); mov(memd_a32[ds, edx + 0x7a], eax);     /* mov [edx+0x7a], eax */
            ii(0x1011_2836, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_283a, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1011_283d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_2840, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_2842, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2845, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1011_2848, 3); mov(memd_a32[ds, edx + 0x7e], eax);     /* mov [edx+0x7e], eax */
            ii(0x1011_284b, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_2850, 5); calld(/* sys */ 0x1016_a24c, 0x579f7);  /* call 0x1016a24c */
            ii(0x1011_2855, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_2857, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_2858, 1); popd(edi);                              /* pop edi */
            ii(0x1011_2859, 1); popd(esi);                              /* pop esi */
            ii(0x1011_285a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_285b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_285c, 1); retd(); return;                         /* ret */
        }
    }
}