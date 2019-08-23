using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_256c-385f8b2c")]
        public void /* sys */ sys_fread()
        {
            ii(0x1017_256c, 1); push(esi);                              /* push esi */
            ii(0x1017_256d, 1); push(edi);                              /* push edi */
            ii(0x1017_256e, 1); push(ebp);                              /* push ebp */
            ii(0x1017_256f, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1017_2572, 1); push(eax);                              /* push eax */
            ii(0x1017_2573, 1); push(edx);                              /* push edx */
            ii(0x1017_2574, 2); mov(ebp, ecx);                          /* mov ebp, ecx */
            ii(0x1017_2576, 4); test(memb[ds, ecx + 0xc], 0x1);         /* test byte [ecx+0xc], 0x1 */
            ii(0x1017_257a, 2); if(jnz(0x1017_2596, 0x1a)) goto l_0x1017_2596; /* jnz 0x10172596 */
            ii(0x1017_257c, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_2581, 5); call(/* sys */ 0x1018_d3bf, 0x1_ae39);  /* call 0x1018d3bf */
            ii(0x1017_2586, 3); mov(dh, memb[ds, ecx + 0xc]);           /* mov dh, [ecx+0xc] */
            ii(0x1017_2589, 3); or(dh, 0x20);                           /* or dh, 0x20 */
            ii(0x1017_258c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_258e, 3); mov(memb[ds, ecx + 0xc], dh);           /* mov [ecx+0xc], dh */
            ii(0x1017_2591, 5); jmp(0x1017_2740, 0x1aa); goto l_0x1017_2740; /* jmp 0x10172740 */
        l_0x1017_2596:
            ii(0x1017_2596, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x1017_2599, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_259b, 2); if(jnz(0x1017_25a4, 0x7)) goto l_0x1017_25a4; /* jnz 0x101725a4 */
            ii(0x1017_259d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_259f, 5); jmp(0x1017_2740, 0x19c); goto l_0x1017_2740; /* jmp 0x10172740 */
        l_0x1017_25a4:
            ii(0x1017_25a4, 4); cmp(memd[ds, ecx + 0x8], 0);            /* cmp dword [ecx+0x8], 0x0 */
            ii(0x1017_25a8, 2); if(jnz(0x1017_25b1, 0x7)) goto l_0x1017_25b1; /* jnz 0x101725b1 */
            ii(0x1017_25aa, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_25ac, 5); call(/* sys */ 0x1018_d3ee, 0x1_ae3d);  /* call 0x1018d3ee */
        l_0x1017_25b1:
            ii(0x1017_25b1, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_25b3, 3); mov(dl, memb[ss, ebp + 0xc]);           /* mov dl, [ebp+0xc] */
            ii(0x1017_25b6, 4); mov(memd[ss, esp + 0x8], esi);          /* mov [esp+0x8], esi */
            ii(0x1017_25ba, 3); test(dl, 0x40);                         /* test dl, 0x40 */
            ii(0x1017_25bd, 6); if(jz(0x1017_26c1, 0xfe)) goto l_0x1017_26c1; /* jz 0x101726c1 */
            ii(0x1017_25c3, 4); mov(memd[ss, esp + 0xc], ebx);          /* mov [esp+0xc], ebx */
        l_0x1017_25c7:
            ii(0x1017_25c7, 3); mov(edx, memd[ss, ebp + 0x4]);          /* mov edx, [ebp+0x4] */
            ii(0x1017_25ca, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_25cc, 2); if(jz(0x1017_2622, 0x54)) goto l_0x1017_2622; /* jz 0x10172622 */
            ii(0x1017_25ce, 4); mov(ebx, memd[ss, esp + 0xc]);          /* mov ebx, [esp+0xc] */
            ii(0x1017_25d2, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1017_25d4, 2); if(jbe(0x1017_25d8, 0x2)) goto l_0x1017_25d8; /* jbe 0x101725d8 */
            ii(0x1017_25d6, 2); mov(edx, ebx);                          /* mov edx, ebx */
        l_0x1017_25d8:
            ii(0x1017_25d8, 4); mov(edi, memd[ss, esp + 0x4]);          /* mov edi, [esp+0x4] */
            ii(0x1017_25dc, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_25de, 3); mov(esi, memd[ss, ebp + 0]);            /* mov esi, [ebp] */
            ii(0x1017_25e1, 4); mov(ebx, memd[ss, esp + 0x8]);          /* mov ebx, [esp+0x8] */
            ii(0x1017_25e5, 1); pushd(es);                              /* push es */
            ii(0x1017_25e6, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1017_25e8, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1017_25ea, 1); push(edi);                              /* push edi */
            ii(0x1017_25eb, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_25ed, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1017_25f0, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1017_25f2, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1017_25f4, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1017_25f7, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1017_25f9, 1); pop(edi);                               /* pop edi */
            ii(0x1017_25fa, 1); popd(es);                               /* pop es */
            ii(0x1017_25fb, 4); mov(eax, memd[ss, esp + 0xc]);          /* mov eax, [esp+0xc] */
            ii(0x1017_25ff, 3); mov(ecx, memd[ss, ebp + 0]);            /* mov ecx, [ebp] */
            ii(0x1017_2602, 3); lea(esi, memd[ds, edi + edx]);          /* lea esi, [edi+edx] */
            ii(0x1017_2605, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1017_2607, 4); mov(memd[ss, esp + 0x4], esi);          /* mov [esp+0x4], esi */
            ii(0x1017_260b, 4); mov(memd[ss, esp + 0x8], ebx);          /* mov [esp+0x8], ebx */
            ii(0x1017_260f, 3); mov(edi, memd[ss, ebp + 0x4]);          /* mov edi, [ebp+0x4] */
            ii(0x1017_2612, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x1017_2614, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1017_2616, 2); sub(edi, edx);                          /* sub edi, edx */
            ii(0x1017_2618, 3); mov(memd[ss, ebp + 0], ecx);            /* mov [ebp], ecx */
            ii(0x1017_261b, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1017_261f, 3); mov(memd[ss, ebp + 0x4], edi);          /* mov [ebp+0x4], edi */
        l_0x1017_2622:
            ii(0x1017_2622, 4); mov(ecx, memd[ss, esp + 0xc]);          /* mov ecx, [esp+0xc] */
            ii(0x1017_2626, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_2628, 6); if(jz(0x1017_2735, 0x107)) goto l_0x1017_2735; /* jz 0x10172735 */
            ii(0x1017_262e, 3); cmp(ecx, memd[ss, ebp + 0x14]);         /* cmp ecx, [ebp+0x14] */
            ii(0x1017_2631, 2); if(jae(0x1017_263d, 0xa)) goto l_0x1017_263d; /* jae 0x1017263d */
            ii(0x1017_2633, 4); test(memb[ss, ebp + 0xd], 0x4);         /* test byte [ebp+0xd], 0x4 */
            ii(0x1017_2637, 6); if(jz(0x1017_26ad, 0x70)) goto l_0x1017_26ad; /* jz 0x101726ad */
        l_0x1017_263d:
            ii(0x1017_263d, 7); mov(memd[ss, ebp + 0x4], 0);            /* mov dword [ebp+0x4], 0x0 */
            ii(0x1017_2644, 4); mov(ebx, memd[ss, esp + 0xc]);          /* mov ebx, [esp+0xc] */
            ii(0x1017_2648, 3); mov(eax, memd[ss, ebp + 0x8]);          /* mov eax, [ebp+0x8] */
            ii(0x1017_264b, 3); mov(cl, memb[ss, ebp + 0xd]);           /* mov cl, [ebp+0xd] */
            ii(0x1017_264e, 3); mov(memd[ss, ebp + 0], eax);            /* mov [ebp], eax */
            ii(0x1017_2651, 3); test(cl, 0x4);                          /* test cl, 0x4 */
            ii(0x1017_2654, 2); if(jnz(0x1017_2663, 0xd)) goto l_0x1017_2663; /* jnz 0x10172663 */
            ii(0x1017_2656, 6); cmp(ebx, 0x200);                        /* cmp ebx, 0x200 */
            ii(0x1017_265c, 2); if(jbe(0x1017_2663, 0x5)) goto l_0x1017_2663; /* jbe 0x10172663 */
            ii(0x1017_265e, 2); xor(bl, bl);                            /* xor bl, bl */
            ii(0x1017_2660, 3); and(bh, 0xfe);                          /* and bh, 0xfe */
        l_0x1017_2663:
            ii(0x1017_2663, 4); mov(edx, memd[ss, esp + 0x4]);          /* mov edx, [esp+0x4] */
            ii(0x1017_2667, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1017_266a, 5); call(/* sys */ 0x1018_d4b6, 0x1_ae47);  /* call 0x1018d4b6 */
            ii(0x1017_266f, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_2672, 2); if(jnz(0x1017_267d, 0x9)) goto l_0x1017_267d; /* jnz 0x1017267d */
            ii(0x1017_2674, 4); or(memb[ss, ebp + 0xc], 0x20);          /* or byte [ebp+0xc], 0x20 */
            ii(0x1017_2678, 5); jmp(0x1017_2735, 0xb8); goto l_0x1017_2735; /* jmp 0x10172735 */
        l_0x1017_267d:
            ii(0x1017_267d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_267f, 2); if(jnz(0x1017_268a, 0x9)) goto l_0x1017_268a; /* jnz 0x1017268a */
        l_0x1017_2681:
            ii(0x1017_2681, 4); or(memb[ss, ebp + 0xc], 0x10);          /* or byte [ebp+0xc], 0x10 */
            ii(0x1017_2685, 5); jmp(0x1017_2735, 0xab); goto l_0x1017_2735; /* jmp 0x10172735 */
        l_0x1017_268a:
            ii(0x1017_268a, 4); mov(edx, memd[ss, esp + 0x4]);          /* mov edx, [esp+0x4] */
            ii(0x1017_268e, 4); mov(ebx, memd[ss, esp + 0xc]);          /* mov ebx, [esp+0xc] */
            ii(0x1017_2692, 4); mov(ecx, memd[ss, esp + 0x8]);          /* mov ecx, [esp+0x8] */
            ii(0x1017_2696, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_2698, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1017_269a, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1017_269c, 4); mov(memd[ss, esp + 0x4], edx);          /* mov [esp+0x4], edx */
            ii(0x1017_26a0, 4); mov(memd[ss, esp + 0xc], ebx);          /* mov [esp+0xc], ebx */
            ii(0x1017_26a4, 4); mov(memd[ss, esp + 0x8], ecx);          /* mov [esp+0x8], ecx */
            ii(0x1017_26a8, 5); jmp(0x1017_25c7, -0xe6); goto l_0x1017_25c7; /* jmp 0x101725c7 */
        l_0x1017_26ad:
            ii(0x1017_26ad, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_26af, 5); call(/* sys */ 0x1017_1fbd, -0x6f7);    /* call 0x10171fbd */
            ii(0x1017_26b4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_26b6, 6); if(jz(0x1017_2735, 0x79)) goto l_0x1017_2735; /* jz 0x10172735 */
            ii(0x1017_26bc, 5); jmp(0x1017_25c7, -0xfa); goto l_0x1017_25c7; /* jmp 0x101725c7 */
        l_0x1017_26c1:
            ii(0x1017_26c1, 4); mov(edx, memd[ss, esp + 0x4]);          /* mov edx, [esp+0x4] */
            ii(0x1017_26c5, 2); add(ebx, edx);                          /* add ebx, edx */
        l_0x1017_26c7:
            ii(0x1017_26c7, 4); cmp(memd[ss, ebp + 0x4], 0);            /* cmp dword [ebp+0x4], 0x0 */
            ii(0x1017_26cb, 2); if(jnz(0x1017_26d8, 0xb)) goto l_0x1017_26d8; /* jnz 0x101726d8 */
            ii(0x1017_26cd, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_26cf, 5); call(/* sys */ 0x1017_1fbd, -0x717);    /* call 0x10171fbd */
            ii(0x1017_26d4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_26d6, 2); if(jz(0x1017_2735, 0x5d)) goto l_0x1017_2735; /* jz 0x10172735 */
        l_0x1017_26d8:
            ii(0x1017_26d8, 3); mov(ecx, memd[ss, ebp + 0x4]);          /* mov ecx, [ebp+0x4] */
            ii(0x1017_26db, 3); mov(eax, memd[ss, ebp + 0]);            /* mov eax, [ebp] */
            ii(0x1017_26de, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_26df, 3); lea(esi, memd[ds, eax + 0x1]);          /* lea esi, [eax+0x1] */
            ii(0x1017_26e2, 3); mov(memd[ss, ebp + 0x4], ecx);          /* mov [ebp+0x4], ecx */
            ii(0x1017_26e5, 3); mov(memd[ss, ebp + 0], esi);            /* mov [ebp], esi */
            ii(0x1017_26e8, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1017_26ea, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_26ef, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1017_26f2, 2); if(jnz(0x1017_271c, 0x28)) goto l_0x1017_271c; /* jnz 0x1017271c */
            ii(0x1017_26f4, 4); cmp(memd[ss, ebp + 0x4], 0);            /* cmp dword [ebp+0x4], 0x0 */
            ii(0x1017_26f8, 2); if(jnz(0x1017_2705, 0xb)) goto l_0x1017_2705; /* jnz 0x10172705 */
            ii(0x1017_26fa, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_26fc, 5); call(/* sys */ 0x1017_1fbd, -0x744);    /* call 0x10171fbd */
            ii(0x1017_2701, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2703, 2); if(jz(0x1017_2735, 0x30)) goto l_0x1017_2735; /* jz 0x10172735 */
        l_0x1017_2705:
            ii(0x1017_2705, 3); mov(edi, memd[ss, ebp + 0x4]);          /* mov edi, [ebp+0x4] */
            ii(0x1017_2708, 3); mov(eax, memd[ss, ebp + 0]);            /* mov eax, [ebp] */
            ii(0x1017_270b, 1); dec(edi);                               /* dec edi */
            ii(0x1017_270c, 3); lea(esi, memd[ds, eax + 0x1]);          /* lea esi, [eax+0x1] */
            ii(0x1017_270f, 3); mov(memd[ss, ebp + 0x4], edi);          /* mov [ebp+0x4], edi */
            ii(0x1017_2712, 3); mov(memd[ss, ebp + 0], esi);            /* mov [ebp], esi */
            ii(0x1017_2715, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1017_2717, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1017_271c:
            ii(0x1017_271c, 3); cmp(eax, 0x1a);                         /* cmp eax, 0x1a */
            ii(0x1017_271f, 6); if(jz(0x1017_2681, -0xa4)) goto l_0x1017_2681; /* jz 0x10172681 */
            ii(0x1017_2725, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x1017_2727, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1017_272b, 1); inc(eax);                               /* inc eax */
            ii(0x1017_272c, 1); inc(edx);                               /* inc edx */
            ii(0x1017_272d, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1017_2731, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1017_2733, 2); if(jnz(0x1017_26c7, -0x6e)) goto l_0x1017_26c7; /* jnz 0x101726c7 */
        l_0x1017_2735:
            ii(0x1017_2735, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1017_2739, 3); mov(esi, memd[ss, esp]);                /* mov esi, [esp] */
            ii(0x1017_273c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_273e, 2); div(esi);                               /* div esi */
        l_0x1017_2740:
            ii(0x1017_2740, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_2743, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_2744, 1); pop(edi);                               /* pop edi */
            ii(0x1017_2745, 1); pop(esi);                               /* pop esi */
            ii(0x1017_2746, 1); ret();                                  /* ret */
        }
    }
}
