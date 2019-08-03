using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c826c977-9636-4581-b2c7-05178cf1823e")]
        public void Method_1007_2388()
        {
            ii(0x1007_2388, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1007_238d, 5); calld(Definitions.sys_check_available_stack_size, 0xf39c0); /* call 0x10165d52 */
            ii(0x1007_2392, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_2393, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2394, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2395, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2396, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2398, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_239e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_23a1, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_23a4, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1007_23a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_23aa, 5); calld(0x1007_20e6, -0x2c9);             /* call 0x100720e6 */
            ii(0x1007_23af, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_23b2, 3); mov(al, memb_a32[ds, eax + 0x3d]);      /* mov al, [eax+0x3d] */
            ii(0x1007_23b5, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1007_23b8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_23bb, 4); cmp(memb_a32[ds, eax + 0x3e], 0);       /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1007_23bf, 2); if(jnzd(0x1007_23c7, 0x6)) goto l_0x1007_23c7; /* jnz 0x100723c7 */
            ii(0x1007_23c1, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_23c5, 2); if(jzd(0x1007_23c9, 0x2)) goto l_0x1007_23c9; /* jz 0x100723c9 */
        l_0x1007_23c7:
            ii(0x1007_23c7, 2); jmpd(0x1007_23d2, 0x9); goto l_0x1007_23d2; /* jmp 0x100723d2 */
        l_0x1007_23c9:
            ii(0x1007_23c9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_23cc, 3); mov(al, memb_a32[ds, eax + 0x3f]);      /* mov al, [eax+0x3f] */
            ii(0x1007_23cf, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
        l_0x1007_23d2:
            ii(0x1007_23d2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_23d5, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1007_23d9, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_23dc, 5); jmpd(0x1007_255d, 0x17c); goto l_0x1007_255d; /* jmp 0x1007255d */
        l_0x1007_23e1:
            ii(0x1007_23e1, 4); cmp(memb_a32[ss, ebp - 0x10], 0x7);     /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1007_23e5, 2); if(jzd(0x1007_23f1, 0xa)) goto l_0x1007_23f1; /* jz 0x100723f1 */
            ii(0x1007_23e7, 4); cmp(memb_a32[ss, ebp - 0x10], 0x6);     /* cmp byte [ebp-0x10], 0x6 */
            ii(0x1007_23eb, 6); if(jnzd(0x1007_24fb, 0x10a)) goto l_0x1007_24fb; /* jnz 0x100724fb */
        l_0x1007_23f1:
            ii(0x1007_23f1, 7); mov(memd_a32[ss, ebp - 0x18], 0x4);     /* mov dword [ebp-0x18], 0x4 */
            ii(0x1007_23f8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_23fb, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_23fe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_2403, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_2409, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1007_240f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_2414, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_2417, 2); if(jnzd(0x1007_2448, 0x2f)) goto l_0x1007_2448; /* jnz 0x10072448 */
            ii(0x1007_2419, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_241e, 5); calld(0x1007_5fdc, 0x3bb9);             /* call 0x10075fdc */
            ii(0x1007_2423, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_2426, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_242a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1007_242d, 2); if(jnzd(0x1007_2438, 0x9)) goto l_0x1007_2438; /* jnz 0x10072438 */
            ii(0x1007_242f, 7); mov(memd_a32[ss, ebp - 0x18], 0x5);     /* mov dword [ebp-0x18], 0x5 */
            ii(0x1007_2436, 2); jmpd(0x1007_2448, 0x10); goto l_0x1007_2448; /* jmp 0x10072448 */
        l_0x1007_2438:
            ii(0x1007_2438, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_243c, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1007_243f, 2); if(jnzd(0x1007_2448, 0x7)) goto l_0x1007_2448; /* jnz 0x10072448 */
            ii(0x1007_2441, 7); mov(memd_a32[ss, ebp - 0x18], 0x6);     /* mov dword [ebp-0x18], 0x6 */
        l_0x1007_2448:
            ii(0x1007_2448, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_244b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_244d, 3); mov(dl, memb_a32[ds, eax + 0x49]);      /* mov dl, [eax+0x49] */
            ii(0x1007_2450, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1007_2454, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_2457, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_2459, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_245c, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1007_245f, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1007_2461, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1007_2464, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_2467, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x1007_246a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_246c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_246f, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x1007_2472, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_2475, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2477, 3); mov(dl, memb_a32[ds, eax + 0x47]);      /* mov dl, [eax+0x47] */
            ii(0x1007_247a, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1007_247e, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_2481, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_2483, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_2486, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1007_2489, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1007_248b, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1007_248e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_2491, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1007_2493, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_2496, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_2498, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_249b, 4); mov(memw_a32[ds, eax + 0x2], dx);       /* mov [eax+0x2], dx */
            ii(0x1007_249f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_24a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_24a4, 3); mov(dl, memb_a32[ds, eax + 0x48]);      /* mov dl, [eax+0x48] */
            ii(0x1007_24a7, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1007_24ab, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_24ae, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_24b0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_24b3, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1007_24b6, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1007_24b8, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1007_24bb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_24be, 3); mov(edx, memd_a32[ds, edx + 0x2]);      /* mov edx, [edx+0x2] */
            ii(0x1007_24c1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_24c4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_24c6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_24c9, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x1007_24cd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_24d0, 3); mov(al, memb_a32[ds, eax + 0x46]);      /* mov al, [eax+0x46] */
            ii(0x1007_24d3, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_24d5, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1007_24da, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1007_24dc, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_24de, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_24e1, 4); add(memw_a32[ds, edx + 0xa], ax);       /* add [edx+0xa], ax */
            ii(0x1007_24e5, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1007_24e8, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1007_24ed, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_24f0, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1007_24f3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_24f6, 5); calld(0x1007_2305, -0x1f6);             /* call 0x10072305 */
        l_0x1007_24fb:
            ii(0x1007_24fb, 5); jmpd(0x1007_25f0, 0xf0); goto l_0x1007_25f0; /* jmp 0x100725f0 */
        l_0x1007_2500:
            ii(0x1007_2500, 4); cmp(memb_a32[ss, ebp - 0x10], 0x7);     /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1007_2504, 2); if(jnzd(0x1007_251c, 0x16)) goto l_0x1007_251c; /* jnz 0x1007251c */
            ii(0x1007_2506, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1007_2509, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1007_250e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_2511, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1007_2514, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_2517, 5); calld(0x1007_2305, -0x217);             /* call 0x10072305 */
        l_0x1007_251c:
            ii(0x1007_251c, 5); jmpd(0x1007_25f0, 0xcf); goto l_0x1007_25f0; /* jmp 0x100725f0 */
        l_0x1007_2521:
            ii(0x1007_2521, 5); jmpd(0x1007_25f0, 0xca); goto l_0x1007_25f0; /* jmp 0x100725f0 */
        l_0x1007_2526:
            ii(0x1007_2526, 4); cmp(memb_a32[ss, ebp - 0x10], 0x4);     /* cmp byte [ebp-0x10], 0x4 */
            ii(0x1007_252a, 2); if(jnzd(0x1007_2535, 0x9)) goto l_0x1007_2535; /* jnz 0x10072535 */
            ii(0x1007_252c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_252f, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1007_2533, 2); if(jnzd(0x1007_2537, 0x2)) goto l_0x1007_2537; /* jnz 0x10072537 */
        l_0x1007_2535:
            ii(0x1007_2535, 2); jmpd(0x1007_2553, 0x1c); goto l_0x1007_2553; /* jmp 0x10072553 */
        l_0x1007_2537:
            ii(0x1007_2537, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1007_253a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_253d, 5); calld(0x1015_14ef, 0xdefad);            /* call 0x101514ef */
            ii(0x1007_2542, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_2545, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_2548, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1007_254b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_254e, 5); calld(0x1007_2305, -0x24e);             /* call 0x10072305 */
        l_0x1007_2553:
            ii(0x1007_2553, 5); jmpd(0x1007_25f0, 0x98); goto l_0x1007_25f0; /* jmp 0x100725f0 */
        l_0x1007_2558:
            ii(0x1007_2558, 5); jmpd(0x1007_25f0, 0x93); goto l_0x1007_25f0; /* jmp 0x100725f0 */
        l_0x1007_255d:
            ii(0x1007_255d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_2560, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_2563, 5); cmp(memw_a32[ss, ebp - 0x20], 0x1b);    /* cmp word [ebp-0x20], 0x1b */
            ii(0x1007_2568, 2); if(jbd(0x1007_25a1, 0x37)) goto l_0x1007_25a1; /* jb 0x100725a1 */
            ii(0x1007_256a, 5); cmp(memw_a32[ss, ebp - 0x20], 0x1b);    /* cmp word [ebp-0x20], 0x1b */
            ii(0x1007_256f, 2); if(jbed(0x1007_2526, -0x4b)) goto l_0x1007_2526; /* jbe 0x10072526 */
            ii(0x1007_2571, 5); cmp(memw_a32[ss, ebp - 0x20], 0x1d);    /* cmp word [ebp-0x20], 0x1d */
            ii(0x1007_2576, 2); if(jbd(0x1007_259c, 0x24)) goto l_0x1007_259c; /* jb 0x1007259c */
            ii(0x1007_2578, 5); cmp(memw_a32[ss, ebp - 0x20], 0x1e);    /* cmp word [ebp-0x20], 0x1e */
            ii(0x1007_257d, 2); if(jbed(0x1007_2500, -0x7f)) goto l_0x1007_2500; /* jbe 0x10072500 */
            ii(0x1007_257f, 5); cmp(memw_a32[ss, ebp - 0x20], 0x20);    /* cmp word [ebp-0x20], 0x20 */
            ii(0x1007_2584, 2); if(jbd(0x1007_259a, 0x14)) goto l_0x1007_259a; /* jb 0x1007259a */
            ii(0x1007_2586, 5); cmp(memw_a32[ss, ebp - 0x20], 0x20);    /* cmp word [ebp-0x20], 0x20 */
            ii(0x1007_258b, 2); if(jbed(0x1007_2526, -0x67)) goto l_0x1007_2526; /* jbe 0x10072526 */
            ii(0x1007_258d, 5); cmp(memw_a32[ss, ebp - 0x20], 0x28);    /* cmp word [ebp-0x20], 0x28 */
            ii(0x1007_2592, 6); if(jzd(0x1007_23e1, -0x1b7)) goto l_0x1007_23e1; /* jz 0x100723e1 */
            ii(0x1007_2598, 2); jmpd(0x1007_2558, -0x42); goto l_0x1007_2558; /* jmp 0x10072558 */
        l_0x1007_259a:
            ii(0x1007_259a, 2); jmpd(0x1007_2558, -0x44); goto l_0x1007_2558; /* jmp 0x10072558 */
        l_0x1007_259c:
            ii(0x1007_259c, 5); jmpd(0x1007_2500, -0xa1); goto l_0x1007_2500; /* jmp 0x10072500 */
        l_0x1007_25a1:
            ii(0x1007_25a1, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3);     /* cmp word [ebp-0x20], 0x3 */
            ii(0x1007_25a6, 2); if(jbd(0x1007_25e6, 0x3e)) goto l_0x1007_25e6; /* jb 0x100725e6 */
            ii(0x1007_25a8, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3);     /* cmp word [ebp-0x20], 0x3 */
            ii(0x1007_25ad, 6); if(jbed(0x1007_2521, -0x92)) goto l_0x1007_2521; /* jbe 0x10072521 */
            ii(0x1007_25b3, 5); cmp(memw_a32[ss, ebp - 0x20], 0x9);     /* cmp word [ebp-0x20], 0x9 */
            ii(0x1007_25b8, 2); if(jbd(0x1007_25e1, 0x27)) goto l_0x1007_25e1; /* jb 0x100725e1 */
            ii(0x1007_25ba, 5); cmp(memw_a32[ss, ebp - 0x20], 0xb);     /* cmp word [ebp-0x20], 0xb */
            ii(0x1007_25bf, 6); if(jbed(0x1007_2521, -0xa4)) goto l_0x1007_2521; /* jbe 0x10072521 */
            ii(0x1007_25c5, 5); cmp(memw_a32[ss, ebp - 0x20], 0x17);    /* cmp word [ebp-0x20], 0x17 */
            ii(0x1007_25ca, 2); if(jbd(0x1007_25dc, 0x10)) goto l_0x1007_25dc; /* jb 0x100725dc */
            ii(0x1007_25cc, 5); cmp(memw_a32[ss, ebp - 0x20], 0x19);    /* cmp word [ebp-0x20], 0x19 */
            ii(0x1007_25d1, 6); if(jbed(0x1007_2526, -0xb1)) goto l_0x1007_2526; /* jbe 0x10072526 */
            ii(0x1007_25d7, 5); jmpd(0x1007_2558, -0x84); goto l_0x1007_2558; /* jmp 0x10072558 */
        l_0x1007_25dc:
            ii(0x1007_25dc, 5); jmpd(0x1007_2558, -0x89); goto l_0x1007_2558; /* jmp 0x10072558 */
        l_0x1007_25e1:
            ii(0x1007_25e1, 5); jmpd(0x1007_2558, -0x8e); goto l_0x1007_2558; /* jmp 0x10072558 */
        l_0x1007_25e6:
            ii(0x1007_25e6, 5); jmpd(0x1007_2500, -0xeb); goto l_0x1007_2500; /* jmp 0x10072500 */
        //  ii(0x1007_25eb, 5); Недостижимый код.
l_0x1007_25f0:
            ii(0x1007_25f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_25f3, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1007_25f6, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1007_25f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_25fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_25fc, 1); popd(edi);                              /* pop edi */
            ii(0x1007_25fd, 1); popd(esi);                              /* pop esi */
            ii(0x1007_25fe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_25ff, 1); retd(); return;                         /* ret */
        }
    }
}
