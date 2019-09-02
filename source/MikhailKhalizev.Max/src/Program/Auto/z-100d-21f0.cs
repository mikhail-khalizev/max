using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_21f0-9f38d25e")]
        public void Method_100d_21f0()
        {
            ii(0x100d_21f0, 5); push(0x34);                             /* push 0x34 */
            ii(0x100d_21f5, 5); call(Definitions.sys_check_available_stack_size, 0x9_3b58); /* call 0x10165d52 */
            ii(0x100d_21fa, 1); push(ebx);                              /* push ebx */
            ii(0x100d_21fb, 1); push(ecx);                              /* push ecx */
            ii(0x100d_21fc, 1); push(esi);                              /* push esi */
            ii(0x100d_21fd, 1); push(edi);                              /* push edi */
            ii(0x100d_21fe, 1); push(ebp);                              /* push ebp */
            ii(0x100d_21ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_2201, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_2207, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_220a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_220d, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100d_2211, 2); if(jle(0x100d_221c, 9)) goto l_0x100d_221c; /* jle 0x100d221c */
            ii(0x100d_2213, 7); cmp(memd[ss, ebp - 4], 0x7000);         /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_221a, 2); if(jl(0x100d_221e, 2)) goto l_0x100d_221e; /* jl 0x100d221e */
        l_0x100d_221c:
            ii(0x100d_221c, 2); jmp(0x100d_2228, 0xa); goto l_0x100d_2228; /* jmp 0x100d2228 */
        l_0x100d_221e:
            ii(0x100d_221e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2221, 7); mov(memb[ds, eax + 0x86], 0);           /* mov byte [eax+0x86], 0x0 */
        l_0x100d_2228:
            ii(0x100d_2228, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_222b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_222e, 5); jmp(0x100d_242d, 0x1fa); goto l_0x100d_242d; /* jmp 0x100d242d */
        l_0x100d_2233:
            ii(0x100d_2233, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2236, 4); mov(memb[ds, eax + 0x37], 1);           /* mov byte [eax+0x37], 0x1 */
        l_0x100d_223a:
            ii(0x100d_223a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_223d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_2240, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_2243, 3); mov(edx, memd[ds, eax + 0x13]);         /* mov edx, [eax+0x13] */
            ii(0x100d_2246, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_2249, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x100d_224c, 5); jmp(0x100d_24f5, 0x2a4); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_2251:
            ii(0x100d_2251, 5); call(0x1011_6ba6, 0x4_4950);            /* call 0x10116ba6 */
            ii(0x100d_2256, 5); jmp(0x100d_24f5, 0x29a); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_225b:
            ii(0x100d_225b, 5); call(0x100d_4e6c, 0x2c0c);              /* call 0x100d4e6c */
            ii(0x100d_2260, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_2262, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_2264, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_2266, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x100d_226b, 5); call(0x1010_5b00, 0x3_3890);            /* call 0x10105b00 */
            ii(0x100d_2270, 5); jmp(0x100d_24f5, 0x280); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_2275:
            ii(0x100d_2275, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2278, 3); mov(eax, memd[ds, eax + 0x4a]);         /* mov eax, [eax+0x4a] */
            ii(0x100d_227b, 5); call(0x100c_fbbe, -0x26c2);             /* call 0x100cfbbe */
            ii(0x100d_2280, 7); mov(memb[ds, 0x101b_7ed0], 1);          /* mov byte [0x101b7ed0], 0x1 */
            ii(0x100d_2287, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_228a, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_228d, 5); call(0x100d_0149, -0x2149);             /* call 0x100d0149 */
            ii(0x100d_2292, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_2295, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2298, 5); call(0x100d_19a4, -0x8f9);              /* call 0x100d19a4 */
            ii(0x100d_229d, 5); jmp(0x100d_24f5, 0x253); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_22a2:
            ii(0x100d_22a2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_22a5, 3); mov(eax, memd[ds, eax + 0x4a]);         /* mov eax, [eax+0x4a] */
            ii(0x100d_22a8, 5); call(0x100c_fbbe, -0x26ef);             /* call 0x100cfbbe */
            ii(0x100d_22ad, 7); mov(memb[ds, 0x101b_7ed0], 0);          /* mov byte [0x101b7ed0], 0x0 */
            ii(0x100d_22b4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_22b7, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_22ba, 5); call(0x100d_0149, -0x2176);             /* call 0x100d0149 */
            ii(0x100d_22bf, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_22c2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_22c5, 5); call(0x100d_19a4, -0x926);              /* call 0x100d19a4 */
            ii(0x100d_22ca, 5); jmp(0x100d_24f5, 0x226); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_22cf:
            ii(0x100d_22cf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_22d2, 4); mov(memb[ds, eax + 0x36], 1);           /* mov byte [eax+0x36], 0x1 */
            ii(0x100d_22d6, 5); jmp(0x100d_24f5, 0x21a); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_22db:
            ii(0x100d_22db, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_22de, 6); mov(memw[ds, eax + 0x38], 1);           /* mov word [eax+0x38], 0x1 */
            ii(0x100d_22e4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_22e7, 3); mov(eax, memd[ds, eax + 0x5e]);         /* mov eax, [eax+0x5e] */
            ii(0x100d_22ea, 5); call(0x100c_fbbe, -0x2731);             /* call 0x100cfbbe */
            ii(0x100d_22ef, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_22f2, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_22f5, 5); call(0x100d_0149, -0x21b1);             /* call 0x100d0149 */
            ii(0x100d_22fa, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_22fd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2300, 5); call(0x100d_19a4, -0x961);              /* call 0x100d19a4 */
            ii(0x100d_2305, 5); jmp(0x100d_24f5, 0x1eb); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_230a:
            ii(0x100d_230a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_230d, 6); mov(memw[ds, eax + 0x38], 2);           /* mov word [eax+0x38], 0x2 */
            ii(0x100d_2313, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2316, 3); mov(eax, memd[ds, eax + 0x62]);         /* mov eax, [eax+0x62] */
            ii(0x100d_2319, 5); call(0x100c_fbbe, -0x2760);             /* call 0x100cfbbe */
            ii(0x100d_231e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2321, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_2324, 5); call(0x100d_0149, -0x21e0);             /* call 0x100d0149 */
            ii(0x100d_2329, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_232c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_232f, 5); call(0x100d_19a4, -0x990);              /* call 0x100d19a4 */
            ii(0x100d_2334, 5); jmp(0x100d_24f5, 0x1bc); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_2339:
            ii(0x100d_2339, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_233c, 6); mov(memw[ds, eax + 0x38], 4);           /* mov word [eax+0x38], 0x4 */
            ii(0x100d_2342, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2345, 3); mov(eax, memd[ds, eax + 0x66]);         /* mov eax, [eax+0x66] */
            ii(0x100d_2348, 5); call(0x100c_fbbe, -0x278f);             /* call 0x100cfbbe */
            ii(0x100d_234d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2350, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_2353, 5); call(0x100d_0149, -0x220f);             /* call 0x100d0149 */
            ii(0x100d_2358, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_235b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_235e, 5); call(0x100d_19a4, -0x9bf);              /* call 0x100d19a4 */
            ii(0x100d_2363, 5); jmp(0x100d_24f5, 0x18d); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_2368:
            ii(0x100d_2368, 7); cmp(memd[ss, ebp - 4], 0x7000);         /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_236f, 6); if(jl(0x100d_2408, 0x93)) goto l_0x100d_2408; /* jl 0x100d2408 */
            ii(0x100d_2375, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2378, 7); cmp(memb[ds, eax + 0x86], 0);           /* cmp byte [eax+0x86], 0x0 */
            ii(0x100d_237f, 6); if(jnz(0x100d_23fc, 0x77)) goto l_0x100d_23fc; /* jnz 0x100d23fc */
            ii(0x100d_2385, 7); add(memd[ss, ebp - 4], 0xffff_9000);    /* add dword [ebp-0x4], 0xffff9000 */
            ii(0x100d_238c, 4); cmp(memd[ss, ebp - 4], 0xd);            /* cmp dword [ebp-0x4], 0xd */
            ii(0x100d_2390, 2); if(jnz(0x100d_239f, 0xd)) goto l_0x100d_239f; /* jnz 0x100d239f */
            ii(0x100d_2392, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2395, 3); mov(eax, memd[ds, eax + 0x4e]);         /* mov eax, [eax+0x4e] */
            ii(0x100d_2398, 5); call(0x100c_fbbe, -0x27df);             /* call 0x100cfbbe */
            ii(0x100d_239d, 2); jmp(0x100d_23fc, 0x5d); goto l_0x100d_23fc; /* jmp 0x100d23fc */
        l_0x100d_239f:
            ii(0x100d_239f, 7); cmp(memd[ss, ebp - 4], 0x44c);          /* cmp dword [ebp-0x4], 0x44c */
            ii(0x100d_23a6, 2); if(jnz(0x100d_23b5, 0xd)) goto l_0x100d_23b5; /* jnz 0x100d23b5 */
            ii(0x100d_23a8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_23ab, 3); mov(eax, memd[ds, eax + 0x52]);         /* mov eax, [eax+0x52] */
            ii(0x100d_23ae, 5); call(0x100c_fbbe, -0x27f5);             /* call 0x100cfbbe */
            ii(0x100d_23b3, 2); jmp(0x100d_23fc, 0x47); goto l_0x100d_23fc; /* jmp 0x100d23fc */
        l_0x100d_23b5:
            ii(0x100d_23b5, 4); cmp(memd[ss, ebp - 4], 0x1b);           /* cmp dword [ebp-0x4], 0x1b */
            ii(0x100d_23b9, 2); if(jnz(0x100d_23c8, 0xd)) goto l_0x100d_23c8; /* jnz 0x100d23c8 */
            ii(0x100d_23bb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_23be, 3); mov(eax, memd[ds, eax + 0x56]);         /* mov eax, [eax+0x56] */
            ii(0x100d_23c1, 5); call(0x100c_fbbe, -0x2808);             /* call 0x100cfbbe */
            ii(0x100d_23c6, 2); jmp(0x100d_23fc, 0x34); goto l_0x100d_23fc; /* jmp 0x100d23fc */
        l_0x100d_23c8:
            ii(0x100d_23c8, 7); cmp(memd[ss, ebp - 4], 0x452);          /* cmp dword [ebp-0x4], 0x452 */
            ii(0x100d_23cf, 2); if(jnz(0x100d_23de, 0xd)) goto l_0x100d_23de; /* jnz 0x100d23de */
            ii(0x100d_23d1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_23d4, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x100d_23d7, 5); call(0x100c_fbbe, -0x281e);             /* call 0x100cfbbe */
            ii(0x100d_23dc, 2); jmp(0x100d_23fc, 0x1e); goto l_0x100d_23fc; /* jmp 0x100d23fc */
        l_0x100d_23de:
            ii(0x100d_23de, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_23e1, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_23e4, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_23e7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_23ea, 3); mov(ebx, memd[ds, eax + 0x40]);         /* mov ebx, [eax+0x40] */
            ii(0x100d_23ed, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_23f0, 6); add(edx, 0x7000);                       /* add edx, 0x7000 */
            ii(0x100d_23f6, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_23f9, 3); call_abs(memd[ds, ebx + 0xc]);          /* call dword [ebx+0xc] */
        l_0x100d_23fc:
            ii(0x100d_23fc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_23ff, 7); mov(memb[ds, eax + 0x86], 1);           /* mov byte [eax+0x86], 0x1 */
            ii(0x100d_2406, 2); jmp(0x100d_2428, 0x20); goto l_0x100d_2428; /* jmp 0x100d2428 */
        l_0x100d_2408:
            ii(0x100d_2408, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_240b, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_240e, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_2411, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_2414, 3); mov(ebx, memd[ds, eax + 0x40]);         /* mov ebx, [eax+0x40] */
            ii(0x100d_2417, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_241a, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_241d, 3); call_abs(memd[ds, ebx + 0xc]);          /* call dword [ebx+0xc] */
            ii(0x100d_2420, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100d_2423, 5); jmp(0x100d_24f9, 0xd1); goto l_0x100d_24f9; /* jmp 0x100d24f9 */
        l_0x100d_2428:
            ii(0x100d_2428, 5); jmp(0x100d_24f5, 0xc8); goto l_0x100d_24f5; /* jmp 0x100d24f5 */
        l_0x100d_242d:
            ii(0x100d_242d, 7); cmp(memd[ss, ebp - 0x10], 0x44d);       /* cmp dword [ebp-0x10], 0x44d */
            ii(0x100d_2434, 2); if(jb(0x100d_2494, 0x5e)) goto l_0x100d_2494; /* jb 0x100d2494 */
            ii(0x100d_2436, 7); cmp(memd[ss, ebp - 0x10], 0x44d);       /* cmp dword [ebp-0x10], 0x44d */
            ii(0x100d_243d, 6); if(jbe(0x100d_22db, -0x168)) goto l_0x100d_22db; /* jbe 0x100d22db */
            ii(0x100d_2443, 7); cmp(memd[ss, ebp - 0x10], 0x450);       /* cmp dword [ebp-0x10], 0x450 */
            ii(0x100d_244a, 2); if(jb(0x100d_247d, 0x31)) goto l_0x100d_247d; /* jb 0x100d247d */
            ii(0x100d_244c, 7); cmp(memd[ss, ebp - 0x10], 0x450);       /* cmp dword [ebp-0x10], 0x450 */
            ii(0x100d_2453, 6); if(jbe(0x100d_2275, -0x1e4)) goto l_0x100d_2275; /* jbe 0x100d2275 */
            ii(0x100d_2459, 7); cmp(memd[ss, ebp - 0x10], 0x451);       /* cmp dword [ebp-0x10], 0x451 */
            ii(0x100d_2460, 6); if(jbe(0x100d_22a2, -0x1c4)) goto l_0x100d_22a2; /* jbe 0x100d22a2 */
            ii(0x100d_2466, 7); cmp(memd[ss, ebp - 0x10], 0x452);       /* cmp dword [ebp-0x10], 0x452 */
            ii(0x100d_246d, 6); if(jz(0x100d_2233, -0x240)) goto l_0x100d_2233; /* jz 0x100d2233 */
            ii(0x100d_2473, 5); jmp(0x100d_2368, -0x110); goto l_0x100d_2368; /* jmp 0x100d2368 */
        //  ii(0x100d_2478, 5); jmp(0x100d_2368, -0x115); goto l_0x100d_2368; /* jmp 0x100d2368 */
        l_0x100d_247d:
            ii(0x100d_247d, 7); cmp(memd[ss, ebp - 0x10], 0x44e);       /* cmp dword [ebp-0x10], 0x44e */
            ii(0x100d_2484, 6); if(jbe(0x100d_230a, -0x180)) goto l_0x100d_230a; /* jbe 0x100d230a */
            ii(0x100d_248a, 5); jmp(0x100d_2339, -0x156); goto l_0x100d_2339; /* jmp 0x100d2339 */
        //  ii(0x100d_248f, 5); jmp(0x100d_2368, -0x12c); goto l_0x100d_2368; /* jmp 0x100d2368 */
        l_0x100d_2494:
            ii(0x100d_2494, 4); cmp(memd[ss, ebp - 0x10], 0x3f);        /* cmp dword [ebp-0x10], 0x3f */
            ii(0x100d_2498, 2); if(jb(0x100d_24d1, 0x37)) goto l_0x100d_24d1; /* jb 0x100d24d1 */
            ii(0x100d_249a, 4); cmp(memd[ss, ebp - 0x10], 0x3f);        /* cmp dword [ebp-0x10], 0x3f */
            ii(0x100d_249e, 6); if(jbe(0x100d_225b, -0x249)) goto l_0x100d_225b; /* jbe 0x100d225b */
            ii(0x100d_24a4, 7); cmp(memd[ss, ebp - 0x10], 0x119);       /* cmp dword [ebp-0x10], 0x119 */
            ii(0x100d_24ab, 2); if(jb(0x100d_24cc, 0x1f)) goto l_0x100d_24cc; /* jb 0x100d24cc */
            ii(0x100d_24ad, 7); cmp(memd[ss, ebp - 0x10], 0x119);       /* cmp dword [ebp-0x10], 0x119 */
            ii(0x100d_24b4, 6); if(jbe(0x100d_2251, -0x269)) goto l_0x100d_2251; /* jbe 0x100d2251 */
            ii(0x100d_24ba, 7); cmp(memd[ss, ebp - 0x10], 0x44c);       /* cmp dword [ebp-0x10], 0x44c */
            ii(0x100d_24c1, 6); if(jz(0x100d_225b, -0x26c)) goto l_0x100d_225b; /* jz 0x100d225b */
            ii(0x100d_24c7, 5); jmp(0x100d_2368, -0x164); goto l_0x100d_2368; /* jmp 0x100d2368 */
        l_0x100d_24cc:
            ii(0x100d_24cc, 5); jmp(0x100d_2368, -0x169); goto l_0x100d_2368; /* jmp 0x100d2368 */
        l_0x100d_24d1:
            ii(0x100d_24d1, 4); cmp(memd[ss, ebp - 0x10], 0xd);         /* cmp dword [ebp-0x10], 0xd */
            ii(0x100d_24d5, 2); if(jb(0x100d_24f0, 0x19)) goto l_0x100d_24f0; /* jb 0x100d24f0 */
            ii(0x100d_24d7, 4); cmp(memd[ss, ebp - 0x10], 0xd);         /* cmp dword [ebp-0x10], 0xd */
            ii(0x100d_24db, 6); if(jbe(0x100d_223a, -0x2a7)) goto l_0x100d_223a; /* jbe 0x100d223a */
            ii(0x100d_24e1, 4); cmp(memd[ss, ebp - 0x10], 0x1b);        /* cmp dword [ebp-0x10], 0x1b */
            ii(0x100d_24e5, 6); if(jz(0x100d_22cf, -0x21c)) goto l_0x100d_22cf; /* jz 0x100d22cf */
            ii(0x100d_24eb, 5); jmp(0x100d_2368, -0x188); goto l_0x100d_2368; /* jmp 0x100d2368 */
        l_0x100d_24f0:
            ii(0x100d_24f0, 5); jmp(0x100d_2368, -0x18d); goto l_0x100d_2368; /* jmp 0x100d2368 */
        l_0x100d_24f5:
            ii(0x100d_24f5, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
        l_0x100d_24f9:
            ii(0x100d_24f9, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100d_24fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_24fe, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_24ff, 1); pop(edi);                               /* pop edi */
            ii(0x100d_2500, 1); pop(esi);                               /* pop esi */
            ii(0x100d_2501, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_2502, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_2503, 1); ret();                                  /* ret */
        }
    }
}
