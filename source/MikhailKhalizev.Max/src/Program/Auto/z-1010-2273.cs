using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2273-d9c03d50")]
        public void Method_1010_2273()
        {
            ii(0x1010_2273, 5); push(0x4c);                             /* push 0x4c */
            ii(0x1010_2278, 5); call(Definitions.sys_check_available_stack_size, 0x6_3ad5); /* call 0x10165d52 */
            ii(0x1010_227d, 1); push(esi);                              /* push esi */
            ii(0x1010_227e, 1); push(edi);                              /* push edi */
            ii(0x1010_227f, 1); push(ebp);                              /* push ebp */
            ii(0x1010_2280, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2282, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1010_2288, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_228b, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1010_228e, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1010_2291, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1010_2294, 4); cmp(memd[ss, ebp + 0x24], 0);           /* cmp dword [ebp+0x24], 0x0 */
            ii(0x1010_2298, 2); if(jz(0x1010_22a3, 0x9)) goto l_0x1010_22a3; /* jz 0x101022a3 */
            ii(0x1010_229a, 7); mov(memd[ss, ebp - 0x14], 0x20);        /* mov dword [ebp-0x14], 0x20 */
            ii(0x1010_22a1, 2); jmp(0x1010_22aa, 0x7); goto l_0x1010_22aa; /* jmp 0x101022aa */
        l_0x1010_22a3:
            ii(0x1010_22a3, 7); mov(memd[ss, ebp - 0x14], 0x10);        /* mov dword [ebp-0x14], 0x10 */
        l_0x1010_22aa:
            ii(0x1010_22aa, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1010_22ad, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1010_22b0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_22b2, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_22b5, 3); idiv(memd[ss, ebp + 0x20]);             /* idiv dword [ebp+0x20] */
            ii(0x1010_22b8, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_22bb, 4); cmp(memd[ss, ebp + 0x24], 0);           /* cmp dword [ebp+0x24], 0x0 */
            ii(0x1010_22bf, 2); if(jz(0x1010_22ca, 0x9)) goto l_0x1010_22ca; /* jz 0x101022ca */
            ii(0x1010_22c1, 7); mov(memd[ss, ebp - 0x1c], 0x80);        /* mov dword [ebp-0x1c], 0x80 */
            ii(0x1010_22c8, 2); jmp(0x1010_22d1, 0x7); goto l_0x1010_22d1; /* jmp 0x101022d1 */
        l_0x1010_22ca:
            ii(0x1010_22ca, 7); mov(memd[ss, ebp - 0x1c], 0x40);        /* mov dword [ebp-0x1c], 0x40 */
        l_0x1010_22d1:
            ii(0x1010_22d1, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1010_22d4, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1010_22d7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_22d9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_22dc, 3); idiv(memd[ss, ebp + 0x20]);             /* idiv dword [ebp+0x20] */
            ii(0x1010_22df, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1010_22e2, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_22e5, 4); cmp(memb[ss, ebp + 0x28], 0);           /* cmp byte [ebp+0x28], 0x0 */
            ii(0x1010_22e9, 2); if(jz(0x1010_22f4, 0x9)) goto l_0x1010_22f4; /* jz 0x101022f4 */
            ii(0x1010_22eb, 7); mov(memd[ss, ebp - 0x24], 0x3);         /* mov dword [ebp-0x24], 0x3 */
            ii(0x1010_22f2, 2); jmp(0x1010_22fb, 0x7); goto l_0x1010_22fb; /* jmp 0x101022fb */
        l_0x1010_22f4:
            ii(0x1010_22f4, 7); mov(memd[ss, ebp - 0x24], 0x1);         /* mov dword [ebp-0x24], 0x1 */
        l_0x1010_22fb:
            ii(0x1010_22fb, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_22fe, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_2301, 4); cmp(memb[ss, ebp + 0x28], 0);           /* cmp byte [ebp+0x28], 0x0 */
            ii(0x1010_2305, 2); if(jz(0x1010_2313, 0xc)) goto l_0x1010_2313; /* jz 0x10102313 */
            ii(0x1010_2307, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_2309, 5); mov(al, memb[ds, 0x101b_8745]);         /* mov al, [0x101b8745] */
            ii(0x1010_230e, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_2311, 2); jmp(0x1010_231a, 0x7); goto l_0x1010_231a; /* jmp 0x1010231a */
        l_0x1010_2313:
            ii(0x1010_2313, 7); mov(memd[ss, ebp - 0x2c], 0xff);        /* mov dword [ebp-0x2c], 0xff */
        l_0x1010_231a:
            ii(0x1010_231a, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1010_231d, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
        l_0x1010_2320:
            ii(0x1010_2320, 3); dec(memd[ss, ebp - 0x28]);              /* dec dword [ebp-0x28] */
            ii(0x1010_2323, 5); cmp(memw[ss, ebp - 0x28], -0x1 /* 0xff */); /* cmp word [ebp-0x28], 0xffff */
            ii(0x1010_2328, 6); if(jz(0x1010_26f0, 0x3c2)) goto l_0x1010_26f0; /* jz 0x101026f0 */
            ii(0x1010_232e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2331, 4); cmp(ax, memw[ss, ebp + 0x14]);          /* cmp ax, [ebp+0x14] */
            ii(0x1010_2335, 2); if(jl(0x1010_2340, 0x9)) goto l_0x1010_2340; /* jl 0x10102340 */
            ii(0x1010_2337, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_233a, 4); cmp(ax, memw[ss, ebp + 0x1c]);          /* cmp ax, [ebp+0x1c] */
            ii(0x1010_233e, 2); if(jle(0x1010_2342, 0x2)) goto l_0x1010_2342; /* jle 0x10102342 */
        l_0x1010_2340:
            ii(0x1010_2340, 2); jmp(0x1010_2354, 0x12); goto l_0x1010_2354; /* jmp 0x10102354 */
        l_0x1010_2342:
            ii(0x1010_2342, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_2346, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_234a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_234c, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1010_2350, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_2352, 2); if(jge(0x1010_2356, 0x2)) goto l_0x1010_2356; /* jge 0x10102356 */
        l_0x1010_2354:
            ii(0x1010_2354, 2); jmp(0x1010_235f, 0x9); goto l_0x1010_235f; /* jmp 0x1010235f */
        l_0x1010_2356:
            ii(0x1010_2356, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2359, 4); cmp(ax, memw[ss, ebp + 0x18]);          /* cmp ax, [ebp+0x18] */
            ii(0x1010_235d, 2); if(jle(0x1010_2361, 0x2)) goto l_0x1010_2361; /* jle 0x10102361 */
        l_0x1010_235f:
            ii(0x1010_235f, 2); jmp(0x1010_23a0, 0x3f); goto l_0x1010_23a0; /* jmp 0x101023a0 */
        l_0x1010_2361:
            ii(0x1010_2361, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_2365, 1); push(eax);                              /* push eax */
            ii(0x1010_2366, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_236a, 1); push(eax);                              /* push eax */
            ii(0x1010_236b, 4); movsx(edx, memw[ss, ebp + 0x18]);       /* movsx edx, word [ebp+0x18] */
            ii(0x1010_236f, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_2373, 4); movsx(ecx, memw[ss, ebp - 0x18]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x1010_2377, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_2379, 5); call(Definitions.my_min, -0x7_8bfa);    /* call 0x10089784 */
            ii(0x1010_237e, 1); push(eax);                              /* push eax */
            ii(0x1010_237f, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1010_2383, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1010_2387, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_238b, 5); call(0x1007_6e7c, -0x8_b514);           /* call 0x10076e7c */
            ii(0x1010_2390, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_2394, 3); mov(esi, memd[ss, ebp - 0x10]);         /* mov esi, [ebp-0x10] */
            ii(0x1010_2397, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_2399, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1010_239b, 5); call(/* sys */ 0x1016_a5a0, 0x6_8200);  /* call 0x1016a5a0 */
        l_0x1010_23a0:
            ii(0x1010_23a0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_23a3, 4); cmp(ax, memw[ss, ebp + 0x10]);          /* cmp ax, [ebp+0x10] */
            ii(0x1010_23a7, 2); if(jl(0x1010_23b2, 0x9)) goto l_0x1010_23b2; /* jl 0x101023b2 */
            ii(0x1010_23a9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_23ac, 4); cmp(ax, memw[ss, ebp + 0x18]);          /* cmp ax, [ebp+0x18] */
            ii(0x1010_23b0, 2); if(jle(0x1010_23b4, 0x2)) goto l_0x1010_23b4; /* jle 0x101023b4 */
        l_0x1010_23b2:
            ii(0x1010_23b2, 2); jmp(0x1010_23c6, 0x12); goto l_0x1010_23c6; /* jmp 0x101023c6 */
        l_0x1010_23b4:
            ii(0x1010_23b4, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_23b8, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_23bc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_23be, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x1010_23c2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_23c4, 2); if(jge(0x1010_23c8, 0x2)) goto l_0x1010_23c8; /* jge 0x101023c8 */
        l_0x1010_23c6:
            ii(0x1010_23c6, 2); jmp(0x1010_23d1, 0x9); goto l_0x1010_23d1; /* jmp 0x101023d1 */
        l_0x1010_23c8:
            ii(0x1010_23c8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_23cb, 4); cmp(ax, memw[ss, ebp + 0x1c]);          /* cmp ax, [ebp+0x1c] */
            ii(0x1010_23cf, 2); if(jle(0x1010_23d3, 0x2)) goto l_0x1010_23d3; /* jle 0x101023d3 */
        l_0x1010_23d1:
            ii(0x1010_23d1, 2); jmp(0x1010_2410, 0x3d); goto l_0x1010_2410; /* jmp 0x10102410 */
        l_0x1010_23d3:
            ii(0x1010_23d3, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_23d7, 1); push(eax);                              /* push eax */
            ii(0x1010_23d8, 4); movsx(edx, memw[ss, ebp + 0x1c]);       /* movsx edx, word [ebp+0x1c] */
            ii(0x1010_23dc, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_23e0, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1010_23e4, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_23e6, 5); call(Definitions.my_min, -0x7_8c67);    /* call 0x10089784 */
            ii(0x1010_23eb, 1); push(eax);                              /* push eax */
            ii(0x1010_23ec, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_23f0, 1); push(eax);                              /* push eax */
            ii(0x1010_23f1, 4); movsx(edx, memw[ss, ebp + 0x14]);       /* movsx edx, word [ebp+0x14] */
            ii(0x1010_23f5, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_23f9, 5); call(0x1007_6e7c, -0x8_b582);           /* call 0x10076e7c */
            ii(0x1010_23fe, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1010_2400, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_2404, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_2408, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_240b, 5); call(/* sys */ 0x1016_a5a0, 0x6_8190);  /* call 0x1016a5a0 */
        l_0x1010_2410:
            ii(0x1010_2410, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_2413, 3); add(memd[ss, ebp - 0x8], eax);          /* add [ebp-0x8], eax */
            ii(0x1010_2416, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2419, 4); cmp(ax, memw[ss, ebp + 0x14]);          /* cmp ax, [ebp+0x14] */
            ii(0x1010_241d, 2); if(jl(0x1010_2428, 0x9)) goto l_0x1010_2428; /* jl 0x10102428 */
            ii(0x1010_241f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2422, 4); cmp(ax, memw[ss, ebp + 0x1c]);          /* cmp ax, [ebp+0x1c] */
            ii(0x1010_2426, 2); if(jle(0x1010_242a, 0x2)) goto l_0x1010_242a; /* jle 0x1010242a */
        l_0x1010_2428:
            ii(0x1010_2428, 2); jmp(0x1010_2433, 0x9); goto l_0x1010_2433; /* jmp 0x10102433 */
        l_0x1010_242a:
            ii(0x1010_242a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_242d, 4); cmp(ax, memw[ss, ebp + 0x10]);          /* cmp ax, [ebp+0x10] */
            ii(0x1010_2431, 2); if(jge(0x1010_2435, 0x2)) goto l_0x1010_2435; /* jge 0x10102435 */
        l_0x1010_2433:
            ii(0x1010_2433, 2); jmp(0x1010_2447, 0x12); goto l_0x1010_2447; /* jmp 0x10102447 */
        l_0x1010_2435:
            ii(0x1010_2435, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_2439, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_243d, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1010_243f, 4); movsx(eax, memw[ss, ebp + 0x18]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1010_2443, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_2445, 2); if(jle(0x1010_2449, 0x2)) goto l_0x1010_2449; /* jle 0x10102449 */
        l_0x1010_2447:
            ii(0x1010_2447, 2); jmp(0x1010_2488, 0x3f); goto l_0x1010_2488; /* jmp 0x10102488 */
        l_0x1010_2449:
            ii(0x1010_2449, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_244d, 1); push(eax);                              /* push eax */
            ii(0x1010_244e, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_2452, 1); push(eax);                              /* push eax */
            ii(0x1010_2453, 4); movsx(edx, memw[ss, ebp + 0x18]);       /* movsx edx, word [ebp+0x18] */
            ii(0x1010_2457, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_245b, 5); call(Definitions.my_min, -0x7_8cdc);    /* call 0x10089784 */
            ii(0x1010_2460, 1); push(eax);                              /* push eax */
            ii(0x1010_2461, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1010_2465, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1010_2469, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_246d, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_2471, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1010_2473, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_2475, 5); call(0x1007_6e7c, -0x8_b5fe);           /* call 0x10076e7c */
            ii(0x1010_247a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_247c, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_2480, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2483, 5); call(/* sys */ 0x1016_a5a0, 0x6_8118);  /* call 0x1016a5a0 */
        l_0x1010_2488:
            ii(0x1010_2488, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_248b, 4); cmp(ax, memw[ss, ebp + 0x10]);          /* cmp ax, [ebp+0x10] */
            ii(0x1010_248f, 2); if(jl(0x1010_249a, 0x9)) goto l_0x1010_249a; /* jl 0x1010249a */
            ii(0x1010_2491, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2494, 4); cmp(ax, memw[ss, ebp + 0x18]);          /* cmp ax, [ebp+0x18] */
            ii(0x1010_2498, 2); if(jle(0x1010_249c, 0x2)) goto l_0x1010_249c; /* jle 0x1010249c */
        l_0x1010_249a:
            ii(0x1010_249a, 2); jmp(0x1010_24ae, 0x12); goto l_0x1010_24ae; /* jmp 0x101024ae */
        l_0x1010_249c:
            ii(0x1010_249c, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_24a0, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_24a4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_24a6, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x1010_24aa, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_24ac, 2); if(jge(0x1010_24b0, 0x2)) goto l_0x1010_24b0; /* jge 0x101024b0 */
        l_0x1010_24ae:
            ii(0x1010_24ae, 2); jmp(0x1010_24b9, 0x9); goto l_0x1010_24b9; /* jmp 0x101024b9 */
        l_0x1010_24b0:
            ii(0x1010_24b0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_24b3, 4); cmp(ax, memw[ss, ebp + 0x1c]);          /* cmp ax, [ebp+0x1c] */
            ii(0x1010_24b7, 2); if(jle(0x1010_24bb, 0x2)) goto l_0x1010_24bb; /* jle 0x101024bb */
        l_0x1010_24b9:
            ii(0x1010_24b9, 2); jmp(0x1010_24f8, 0x3d); goto l_0x1010_24f8; /* jmp 0x101024f8 */
        l_0x1010_24bb:
            ii(0x1010_24bb, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_24bf, 1); push(eax);                              /* push eax */
            ii(0x1010_24c0, 4); movsx(edx, memw[ss, ebp + 0x1c]);       /* movsx edx, word [ebp+0x1c] */
            ii(0x1010_24c4, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_24c8, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1010_24cc, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_24ce, 5); call(Definitions.my_min, -0x7_8d4f);    /* call 0x10089784 */
            ii(0x1010_24d3, 1); push(eax);                              /* push eax */
            ii(0x1010_24d4, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_24d8, 1); push(eax);                              /* push eax */
            ii(0x1010_24d9, 4); movsx(edx, memw[ss, ebp + 0x14]);       /* movsx edx, word [ebp+0x14] */
            ii(0x1010_24dd, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_24e1, 5); call(0x1007_6e7c, -0x8_b66a);           /* call 0x10076e7c */
            ii(0x1010_24e6, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1010_24e8, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_24ec, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_24f0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_24f3, 5); call(/* sys */ 0x1016_a5a0, 0x6_80a8);  /* call 0x1016a5a0 */
        l_0x1010_24f8:
            ii(0x1010_24f8, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_24fb, 3); add(memd[ss, ebp - 0x4], eax);          /* add [ebp-0x4], eax */
            ii(0x1010_24fe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2501, 4); cmp(ax, memw[ss, ebp + 0x14]);          /* cmp ax, [ebp+0x14] */
            ii(0x1010_2505, 2); if(jl(0x1010_2510, 0x9)) goto l_0x1010_2510; /* jl 0x10102510 */
            ii(0x1010_2507, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_250a, 4); cmp(ax, memw[ss, ebp + 0x1c]);          /* cmp ax, [ebp+0x1c] */
            ii(0x1010_250e, 2); if(jle(0x1010_2512, 0x2)) goto l_0x1010_2512; /* jle 0x10102512 */
        l_0x1010_2510:
            ii(0x1010_2510, 2); jmp(0x1010_251b, 0x9); goto l_0x1010_251b; /* jmp 0x1010251b */
        l_0x1010_2512:
            ii(0x1010_2512, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2515, 4); cmp(ax, memw[ss, ebp + 0x10]);          /* cmp ax, [ebp+0x10] */
            ii(0x1010_2519, 2); if(jge(0x1010_251d, 0x2)) goto l_0x1010_251d; /* jge 0x1010251d */
        l_0x1010_251b:
            ii(0x1010_251b, 2); jmp(0x1010_252f, 0x12); goto l_0x1010_252f; /* jmp 0x1010252f */
        l_0x1010_251d:
            ii(0x1010_251d, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_2521, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_2525, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1010_2527, 4); movsx(eax, memw[ss, ebp + 0x18]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1010_252b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_252d, 2); if(jle(0x1010_2531, 0x2)) goto l_0x1010_2531; /* jle 0x10102531 */
        l_0x1010_252f:
            ii(0x1010_252f, 2); jmp(0x1010_2570, 0x3f); goto l_0x1010_2570; /* jmp 0x10102570 */
        l_0x1010_2531:
            ii(0x1010_2531, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_2535, 1); push(eax);                              /* push eax */
            ii(0x1010_2536, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_253a, 1); push(eax);                              /* push eax */
            ii(0x1010_253b, 4); movsx(edx, memw[ss, ebp + 0x18]);       /* movsx edx, word [ebp+0x18] */
            ii(0x1010_253f, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_2543, 5); call(Definitions.my_min, -0x7_8dc4);    /* call 0x10089784 */
            ii(0x1010_2548, 1); push(eax);                              /* push eax */
            ii(0x1010_2549, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1010_254d, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1010_2551, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_2555, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_2559, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1010_255b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_255d, 5); call(0x1007_6e7c, -0x8_b6e6);           /* call 0x10076e7c */
            ii(0x1010_2562, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_2564, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_2568, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_256b, 5); call(/* sys */ 0x1016_a5a0, 0x6_8030);  /* call 0x1016a5a0 */
        l_0x1010_2570:
            ii(0x1010_2570, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2573, 4); cmp(ax, memw[ss, ebp + 0x10]);          /* cmp ax, [ebp+0x10] */
            ii(0x1010_2577, 2); if(jl(0x1010_2582, 0x9)) goto l_0x1010_2582; /* jl 0x10102582 */
            ii(0x1010_2579, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_257c, 4); cmp(ax, memw[ss, ebp + 0x18]);          /* cmp ax, [ebp+0x18] */
            ii(0x1010_2580, 2); if(jle(0x1010_2584, 0x2)) goto l_0x1010_2584; /* jle 0x10102584 */
        l_0x1010_2582:
            ii(0x1010_2582, 2); jmp(0x1010_258d, 0x9); goto l_0x1010_258d; /* jmp 0x1010258d */
        l_0x1010_2584:
            ii(0x1010_2584, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2587, 4); cmp(ax, memw[ss, ebp + 0x14]);          /* cmp ax, [ebp+0x14] */
            ii(0x1010_258b, 2); if(jge(0x1010_258f, 0x2)) goto l_0x1010_258f; /* jge 0x1010258f */
        l_0x1010_258d:
            ii(0x1010_258d, 2); jmp(0x1010_25a1, 0x12); goto l_0x1010_25a1; /* jmp 0x101025a1 */
        l_0x1010_258f:
            ii(0x1010_258f, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_2593, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_2597, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1010_2599, 4); movsx(eax, memw[ss, ebp + 0x1c]);       /* movsx eax, word [ebp+0x1c] */
            ii(0x1010_259d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_259f, 2); if(jle(0x1010_25a3, 0x2)) goto l_0x1010_25a3; /* jle 0x101025a3 */
        l_0x1010_25a1:
            ii(0x1010_25a1, 2); jmp(0x1010_25e0, 0x3d); goto l_0x1010_25e0; /* jmp 0x101025e0 */
        l_0x1010_25a3:
            ii(0x1010_25a3, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_25a7, 1); push(eax);                              /* push eax */
            ii(0x1010_25a8, 4); movsx(edx, memw[ss, ebp + 0x14]);       /* movsx edx, word [ebp+0x14] */
            ii(0x1010_25ac, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_25b0, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1010_25b4, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1010_25b6, 5); call(0x1007_6e7c, -0x8_b73f);           /* call 0x10076e7c */
            ii(0x1010_25bb, 1); push(eax);                              /* push eax */
            ii(0x1010_25bc, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_25c0, 1); push(eax);                              /* push eax */
            ii(0x1010_25c1, 4); movsx(edx, memw[ss, ebp + 0x1c]);       /* movsx edx, word [ebp+0x1c] */
            ii(0x1010_25c5, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_25c9, 5); call(Definitions.my_min, -0x7_8e4a);    /* call 0x10089784 */
            ii(0x1010_25ce, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1010_25d0, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_25d4, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_25d8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_25db, 5); call(/* sys */ 0x1016_a5a0, 0x6_7fc0);  /* call 0x1016a5a0 */
        l_0x1010_25e0:
            ii(0x1010_25e0, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_25e3, 3); sub(memd[ss, ebp - 0x8], eax);          /* sub [ebp-0x8], eax */
            ii(0x1010_25e6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_25e9, 4); cmp(ax, memw[ss, ebp + 0x14]);          /* cmp ax, [ebp+0x14] */
            ii(0x1010_25ed, 2); if(jl(0x1010_25f8, 0x9)) goto l_0x1010_25f8; /* jl 0x101025f8 */
            ii(0x1010_25ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_25f2, 4); cmp(ax, memw[ss, ebp + 0x1c]);          /* cmp ax, [ebp+0x1c] */
            ii(0x1010_25f6, 2); if(jle(0x1010_25fa, 0x2)) goto l_0x1010_25fa; /* jle 0x101025fa */
        l_0x1010_25f8:
            ii(0x1010_25f8, 2); jmp(0x1010_260c, 0x12); goto l_0x1010_260c; /* jmp 0x1010260c */
        l_0x1010_25fa:
            ii(0x1010_25fa, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_25fe, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_2602, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_2604, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1010_2608, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_260a, 2); if(jge(0x1010_260e, 0x2)) goto l_0x1010_260e; /* jge 0x1010260e */
        l_0x1010_260c:
            ii(0x1010_260c, 2); jmp(0x1010_2617, 0x9); goto l_0x1010_2617; /* jmp 0x10102617 */
        l_0x1010_260e:
            ii(0x1010_260e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2611, 4); cmp(ax, memw[ss, ebp + 0x18]);          /* cmp ax, [ebp+0x18] */
            ii(0x1010_2615, 2); if(jle(0x1010_2619, 0x2)) goto l_0x1010_2619; /* jle 0x10102619 */
        l_0x1010_2617:
            ii(0x1010_2617, 2); jmp(0x1010_2658, 0x3f); goto l_0x1010_2658; /* jmp 0x10102658 */
        l_0x1010_2619:
            ii(0x1010_2619, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_261d, 1); push(eax);                              /* push eax */
            ii(0x1010_261e, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_2622, 1); push(eax);                              /* push eax */
            ii(0x1010_2623, 4); movsx(edx, memw[ss, ebp + 0x18]);       /* movsx edx, word [ebp+0x18] */
            ii(0x1010_2627, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_262b, 4); movsx(ecx, memw[ss, ebp - 0x18]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x1010_262f, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_2631, 5); call(Definitions.my_min, -0x7_8eb2);    /* call 0x10089784 */
            ii(0x1010_2636, 1); push(eax);                              /* push eax */
            ii(0x1010_2637, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1010_263b, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1010_263f, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_2643, 5); call(0x1007_6e7c, -0x8_b7cc);           /* call 0x10076e7c */
            ii(0x1010_2648, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_264c, 3); mov(esi, memd[ss, ebp - 0x10]);         /* mov esi, [ebp-0x10] */
            ii(0x1010_264f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_2651, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1010_2653, 5); call(/* sys */ 0x1016_a5a0, 0x6_7f48);  /* call 0x1016a5a0 */
        l_0x1010_2658:
            ii(0x1010_2658, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_265b, 4); cmp(ax, memw[ss, ebp + 0x10]);          /* cmp ax, [ebp+0x10] */
            ii(0x1010_265f, 2); if(jl(0x1010_266a, 0x9)) goto l_0x1010_266a; /* jl 0x1010266a */
            ii(0x1010_2661, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2664, 4); cmp(ax, memw[ss, ebp + 0x18]);          /* cmp ax, [ebp+0x18] */
            ii(0x1010_2668, 2); if(jle(0x1010_266c, 0x2)) goto l_0x1010_266c; /* jle 0x1010266c */
        l_0x1010_266a:
            ii(0x1010_266a, 2); jmp(0x1010_2675, 0x9); goto l_0x1010_2675; /* jmp 0x10102675 */
        l_0x1010_266c:
            ii(0x1010_266c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_266f, 4); cmp(ax, memw[ss, ebp + 0x14]);          /* cmp ax, [ebp+0x14] */
            ii(0x1010_2673, 2); if(jge(0x1010_2677, 0x2)) goto l_0x1010_2677; /* jge 0x10102677 */
        l_0x1010_2675:
            ii(0x1010_2675, 2); jmp(0x1010_2689, 0x12); goto l_0x1010_2689; /* jmp 0x10102689 */
        l_0x1010_2677:
            ii(0x1010_2677, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_267b, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_267f, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1010_2681, 4); movsx(eax, memw[ss, ebp + 0x1c]);       /* movsx eax, word [ebp+0x1c] */
            ii(0x1010_2685, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_2687, 2); if(jle(0x1010_268b, 0x2)) goto l_0x1010_268b; /* jle 0x1010268b */
        l_0x1010_2689:
            ii(0x1010_2689, 2); jmp(0x1010_26c8, 0x3d); goto l_0x1010_26c8; /* jmp 0x101026c8 */
        l_0x1010_268b:
            ii(0x1010_268b, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_268f, 1); push(eax);                              /* push eax */
            ii(0x1010_2690, 4); movsx(edx, memw[ss, ebp + 0x14]);       /* movsx edx, word [ebp+0x14] */
            ii(0x1010_2694, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_2698, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1010_269c, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1010_269e, 5); call(0x1007_6e7c, -0x8_b827);           /* call 0x10076e7c */
            ii(0x1010_26a3, 1); push(eax);                              /* push eax */
            ii(0x1010_26a4, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_26a8, 1); push(eax);                              /* push eax */
            ii(0x1010_26a9, 4); movsx(edx, memw[ss, ebp + 0x1c]);       /* movsx edx, word [ebp+0x1c] */
            ii(0x1010_26ad, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_26b1, 5); call(Definitions.my_min, -0x7_8f32);    /* call 0x10089784 */
            ii(0x1010_26b6, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1010_26b8, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_26bc, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_26c0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_26c3, 5); call(/* sys */ 0x1016_a5a0, 0x6_7ed8);  /* call 0x1016a5a0 */
        l_0x1010_26c8:
            ii(0x1010_26c8, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_26cb, 3); sub(memd[ss, ebp - 0x4], eax);          /* sub [ebp-0x4], eax */
            ii(0x1010_26ce, 4); add(memd[ss, ebp - 0x20], -0x2 /* 0xfe */); /* add dword [ebp-0x20], 0xfffffffe */
            ii(0x1010_26d2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_26d5, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
            ii(0x1010_26d8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_26db, 3); inc(memd[ss, ebp - 0x4]);               /* inc dword [ebp-0x4] */
            ii(0x1010_26de, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_26e1, 3); dec(memd[ss, ebp - 0x18]);              /* dec dword [ebp-0x18] */
            ii(0x1010_26e4, 7); xor(memd[ss, ebp - 0x30], 0xff);        /* xor dword [ebp-0x30], 0xff */
            ii(0x1010_26eb, 5); jmp(0x1010_2320, -0x3d0); goto l_0x1010_2320; /* jmp 0x10102320 */
        l_0x1010_26f0:
            ii(0x1010_26f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_26f2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_26f3, 1); pop(edi);                               /* pop edi */
            ii(0x1010_26f4, 1); pop(esi);                               /* pop esi */
            ii(0x1010_26f5, 3); ret(0x1c);                              /* ret 0x1c */
        }
    }
}
