using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2831-97b28509")]
        public void /* sys */ Method_1017_2831()
        {
            ii(0x1017_2831, 1); push(esi);                              /* push esi */
            ii(0x1017_2832, 1); push(edi);                              /* push edi */
            ii(0x1017_2833, 1); push(ebp);                              /* push ebp */
            ii(0x1017_2834, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1017_2837, 1); push(eax);                              /* push eax */
            ii(0x1017_2838, 1); push(edx);                              /* push edx */
            ii(0x1017_2839, 2); mov(ebp, ecx);                          /* mov ebp, ecx */
            ii(0x1017_283b, 4); test(memb[ds, ecx + 0xc], 0x2);         /* test byte [ecx+0xc], 0x2 */
            ii(0x1017_283f, 2); if(jnz(0x1017_2856, 0x15)) goto l_0x1017_2856; /* jnz 0x10172856 */
            ii(0x1017_2841, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_2846, 5); call(/* sys */ 0x1018_d3bf, 0x1_ab74);  /* call 0x1018d3bf */
            ii(0x1017_284b, 4); or(memb[ds, ecx + 0xc], 0x20);          /* or byte [ecx+0xc], 0x20 */
            ii(0x1017_284f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_2851, 5); jmp(0x1017_29ea, 0x194); goto l_0x1017_29ea; /* jmp 0x101729ea */
        l_0x1017_2856:
            ii(0x1017_2856, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x1017_2859, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_285b, 2); if(jnz(0x1017_2864, 0x7)) goto l_0x1017_2864; /* jnz 0x10172864 */
            ii(0x1017_285d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_285f, 5); jmp(0x1017_29ea, 0x186); goto l_0x1017_29ea; /* jmp 0x101729ea */
        l_0x1017_2864:
            ii(0x1017_2864, 4); cmp(memd[ds, ecx + 0x8], 0);            /* cmp dword [ecx+0x8], 0x0 */
            ii(0x1017_2868, 2); if(jnz(0x1017_2871, 0x7)) goto l_0x1017_2871; /* jnz 0x10172871 */
            ii(0x1017_286a, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_286c, 5); call(/* sys */ 0x1018_d3ee, 0x1_ab7d);  /* call 0x1018d3ee */
        l_0x1017_2871:
            ii(0x1017_2871, 3); mov(eax, memd[ss, ebp + 0xc]);          /* mov eax, [ebp+0xc] */
            ii(0x1017_2874, 3); mov(dl, memb[ss, ebp + 0xc]);           /* mov dl, [ebp+0xc] */
            ii(0x1017_2877, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_2879, 3); and(eax, 0x30);                         /* and eax, 0x30 */
            ii(0x1017_287c, 3); and(dl, 0xcf);                          /* and dl, 0xcf */
            ii(0x1017_287f, 4); mov(memd[ss, esp + 0xc], esi);          /* mov [esp+0xc], esi */
            ii(0x1017_2883, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1017_2887, 3); mov(memb[ss, ebp + 0xc], dl);           /* mov [ebp+0xc], dl */
            ii(0x1017_288a, 3); test(dl, 0x40);                         /* test dl, 0x40 */
            ii(0x1017_288d, 6); if(jz(0x1017_296c, 0xd9)) goto l_0x1017_296c; /* jz 0x1017296c */
            ii(0x1017_2893, 4); mov(memd[ss, esp + 0x10], ebx);         /* mov [esp+0x10], ebx */
        l_0x1017_2897:
            ii(0x1017_2897, 4); cmp(memd[ss, ebp + 0x4], 0);            /* cmp dword [ebp+0x4], 0x0 */
            ii(0x1017_289b, 2); if(jnz(0x1017_28df, 0x42)) goto l_0x1017_28df; /* jnz 0x101728df */
            ii(0x1017_289d, 4); mov(eax, memd[ss, esp + 0x10]);         /* mov eax, [esp+0x10] */
            ii(0x1017_28a1, 3); cmp(eax, memd[ss, ebp + 0x14]);         /* cmp eax, [ebp+0x14] */
            ii(0x1017_28a4, 2); if(jb(0x1017_28df, 0x39)) goto l_0x1017_28df; /* jb 0x101728df */
            ii(0x1017_28a6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_28a8, 2); xor(bl, al);                            /* xor bl, al */
            ii(0x1017_28aa, 3); and(bh, 0xfe);                          /* and bh, 0xfe */
            ii(0x1017_28ad, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_28af, 2); if(jnz(0x1017_28b3, 0x2)) goto l_0x1017_28b3; /* jnz 0x101728b3 */
            ii(0x1017_28b1, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_28b3:
            ii(0x1017_28b3, 4); mov(edx, memd[ss, esp + 0x4]);          /* mov edx, [esp+0x4] */
            ii(0x1017_28b7, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1017_28ba, 5); call(/* sys */ 0x1018_d72e, 0x1_ae6f);  /* call 0x1018d72e */
            ii(0x1017_28bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_28c1, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_28c4, 2); if(jz(0x1017_28d9, 0x13)) goto l_0x1017_28d9; /* jz 0x101728d9 */
            ii(0x1017_28c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_28c8, 6); if(jnz(0x1017_2940, 0x72)) goto l_0x1017_2940; /* jnz 0x10172940 */
            ii(0x1017_28ce, 5); call(/* sys */ 0x1018_d7a2, 0x1_aecf);  /* call 0x1018d7a2 */
            ii(0x1017_28d3, 6); mov(memd[ds, eax], 0xc);                /* mov dword [eax], 0xc */
        l_0x1017_28d9:
            ii(0x1017_28d9, 4); or(memb[ss, ebp + 0xc], 0x20);          /* or byte [ebp+0xc], 0x20 */
            ii(0x1017_28dd, 2); jmp(0x1017_2940, 0x61); goto l_0x1017_2940; /* jmp 0x10172940 */
        l_0x1017_28df:
            ii(0x1017_28df, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1017_28e2, 3); mov(ebx, memd[ss, ebp + 0x4]);          /* mov ebx, [ebp+0x4] */
            ii(0x1017_28e5, 4); mov(ecx, memd[ss, esp + 0x10]);         /* mov ecx, [esp+0x10] */
            ii(0x1017_28e9, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1017_28eb, 2); cmp(edx, ecx);                          /* cmp edx, ecx */
            ii(0x1017_28ed, 2); if(jbe(0x1017_28f1, 0x2)) goto l_0x1017_28f1; /* jbe 0x101728f1 */
            ii(0x1017_28ef, 2); mov(edx, ecx);                          /* mov edx, ecx */
        l_0x1017_28f1:
            ii(0x1017_28f1, 4); mov(esi, memd[ss, esp + 0x4]);          /* mov esi, [esp+0x4] */
            ii(0x1017_28f5, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_28f7, 3); mov(edi, memd[ss, ebp + 0]);            /* mov edi, [ebp] */
            ii(0x1017_28fa, 1); push(es);                               /* push es */
            ii(0x1017_28fb, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1017_28fd, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1017_28ff, 1); push(edi);                              /* push edi */
            ii(0x1017_2900, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_2902, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1017_2905, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1017_2907, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1017_2909, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1017_290c, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1017_290e, 1); pop(edi);                               /* pop edi */
            ii(0x1017_290f, 1); pop(es);                                /* pop es */
            ii(0x1017_2910, 3); mov(edi, memd[ss, ebp + 0x4]);          /* mov edi, [ebp+0x4] */
            ii(0x1017_2913, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1017_2915, 3); mov(bh, memb[ss, ebp + 0xd]);           /* mov bh, [ebp+0xd] */
            ii(0x1017_2918, 3); mov(memd[ss, ebp + 0x4], edi);          /* mov [ebp+0x4], edi */
            ii(0x1017_291b, 3); or(bh, 0x10);                           /* or bh, 0x10 */
            ii(0x1017_291e, 3); mov(esi, memd[ss, ebp + 0]);            /* mov esi, [ebp] */
            ii(0x1017_2921, 3); mov(memb[ss, ebp + 0xd], bh);           /* mov [ebp+0xd], bh */
            ii(0x1017_2924, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1017_2926, 3); mov(eax, memd[ss, ebp + 0x4]);          /* mov eax, [ebp+0x4] */
            ii(0x1017_2929, 3); mov(ebx, memd[ss, ebp + 0x14]);         /* mov ebx, [ebp+0x14] */
            ii(0x1017_292c, 3); mov(memd[ss, ebp + 0], esi);            /* mov [ebp], esi */
            ii(0x1017_292f, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1017_2931, 2); if(jz(0x1017_2939, 0x6)) goto l_0x1017_2939; /* jz 0x10172939 */
            ii(0x1017_2933, 4); test(memb[ss, ebp + 0xd], 0x4);         /* test byte [ebp+0xd], 0x4 */
            ii(0x1017_2937, 2); if(jz(0x1017_2940, 0x7)) goto l_0x1017_2940; /* jz 0x10172940 */
        l_0x1017_2939:
            ii(0x1017_2939, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_293b, 5); call(/* sys */ 0x1018_d5d9, 0x1_ac99);  /* call 0x1018d5d9 */
        l_0x1017_2940:
            ii(0x1017_2940, 4); mov(ecx, memd[ss, esp + 0x4]);          /* mov ecx, [esp+0x4] */
            ii(0x1017_2944, 4); mov(esi, memd[ss, esp + 0xc]);          /* mov esi, [esp+0xc] */
            ii(0x1017_2948, 4); mov(edi, memd[ss, esp + 0x10]);         /* mov edi, [esp+0x10] */
            ii(0x1017_294c, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x1017_294e, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1017_2950, 4); mov(memd[ss, esp + 0x4], ecx);          /* mov [esp+0x4], ecx */
            ii(0x1017_2954, 4); mov(memd[ss, esp + 0xc], esi);          /* mov [esp+0xc], esi */
            ii(0x1017_2958, 2); sub(edi, edx);                          /* sub edi, edx */
            ii(0x1017_295a, 4); mov(memd[ss, esp + 0x10], edi);         /* mov [esp+0x10], edi */
            ii(0x1017_295e, 2); if(jz(0x1017_29c7, 0x67)) goto l_0x1017_29c7; /* jz 0x101729c7 */
            ii(0x1017_2960, 4); test(memb[ss, ebp + 0xc], 0x20);        /* test byte [ebp+0xc], 0x20 */
            ii(0x1017_2964, 6); if(jz(0x1017_2897, -0xd3)) goto l_0x1017_2897; /* jz 0x10172897 */
            ii(0x1017_296a, 2); jmp(0x1017_29c7, 0x5b); goto l_0x1017_29c7; /* jmp 0x101729c7 */
        l_0x1017_296c:
            ii(0x1017_296c, 3); mov(cl, memb[ss, ebp + 0xd]);           /* mov cl, [ebp+0xd] */
            ii(0x1017_296f, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_2971, 3); test(cl, 0x4);                          /* test cl, 0x4 */
            ii(0x1017_2974, 2); if(jz(0x1017_2987, 0x11)) goto l_0x1017_2987; /* jz 0x10172987 */
            ii(0x1017_2976, 2); mov(ch, cl);                            /* mov ch, cl */
            ii(0x1017_2978, 3); and(ch, 0xfa);                          /* and ch, 0xfa */
            ii(0x1017_297b, 2); mov(al, ch);                            /* mov al, ch */
            ii(0x1017_297d, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1017_297f, 5); mov(edi, 0x1);                          /* mov edi, 0x1 */
            ii(0x1017_2984, 3); mov(memb[ss, ebp + 0xd], al);           /* mov [ebp+0xd], al */
        l_0x1017_2987:
            ii(0x1017_2987, 4); mov(edx, memd[ss, esp + 0x4]);          /* mov edx, [esp+0x4] */
            ii(0x1017_298b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_298d, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1017_298f, 1); inc(edx);                               /* inc edx */
            ii(0x1017_2990, 4); mov(memd[ss, esp + 0x4], edx);          /* mov [esp+0x4], edx */
            ii(0x1017_2994, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1017_2996, 5); call(/* sys */ 0x1017_29f1, 0x56);      /* call 0x101729f1 */
            ii(0x1017_299b, 4); test(memb[ss, ebp + 0xc], 0x30);        /* test byte [ebp+0xc], 0x30 */
            ii(0x1017_299f, 2); if(jnz(0x1017_29ae, 0xd)) goto l_0x1017_29ae; /* jnz 0x101729ae */
            ii(0x1017_29a1, 4); mov(ecx, memd[ss, esp + 0xc]);          /* mov ecx, [esp+0xc] */
            ii(0x1017_29a5, 1); inc(ecx);                               /* inc ecx */
            ii(0x1017_29a6, 4); mov(memd[ss, esp + 0xc], ecx);          /* mov [esp+0xc], ecx */
            ii(0x1017_29aa, 2); cmp(ebx, ecx);                          /* cmp ebx, ecx */
            ii(0x1017_29ac, 2); if(jnz(0x1017_2987, -0x27)) goto l_0x1017_2987; /* jnz 0x10172987 */
        l_0x1017_29ae:
            ii(0x1017_29ae, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_29b0, 2); if(jz(0x1017_29c7, 0x15)) goto l_0x1017_29c7; /* jz 0x101729c7 */
            ii(0x1017_29b2, 3); mov(dh, memb[ss, ebp + 0xd]);           /* mov dh, [ebp+0xd] */
            ii(0x1017_29b5, 3); and(dh, 0xfa);                          /* and dh, 0xfa */
            ii(0x1017_29b8, 2); mov(bl, dh);                            /* mov bl, dh */
            ii(0x1017_29ba, 3); or(bl, 0x4);                            /* or bl, 0x4 */
            ii(0x1017_29bd, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_29bf, 3); mov(memb[ss, ebp + 0xd], bl);           /* mov [ebp+0xd], bl */
            ii(0x1017_29c2, 5); call(/* sys */ 0x1018_d5d9, 0x1_ac12);  /* call 0x1018d5d9 */
        l_0x1017_29c7:
            ii(0x1017_29c7, 4); test(memb[ss, ebp + 0xc], 0x20);        /* test byte [ebp+0xc], 0x20 */
            ii(0x1017_29cb, 2); if(jz(0x1017_29d3, 0x6)) goto l_0x1017_29d3; /* jz 0x101729d3 */
            ii(0x1017_29cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_29cf, 4); mov(memd[ss, esp + 0xc], edx);          /* mov [esp+0xc], edx */
        l_0x1017_29d3:
            ii(0x1017_29d3, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1017_29d7, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1017_29da, 3); mov(ebx, memd[ss, ebp + 0xc]);          /* mov ebx, [ebp+0xc] */
            ii(0x1017_29dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_29df, 2); or(ebx, eax);                           /* or ebx, eax */
            ii(0x1017_29e1, 4); mov(eax, memd[ss, esp + 0xc]);          /* mov eax, [esp+0xc] */
            ii(0x1017_29e5, 3); mov(memd[ss, ebp + 0xc], ebx);          /* mov [ebp+0xc], ebx */
            ii(0x1017_29e8, 2); div(ecx);                               /* div ecx */
        l_0x1017_29ea:
            ii(0x1017_29ea, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1017_29ed, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_29ee, 1); pop(edi);                               /* pop edi */
            ii(0x1017_29ef, 1); pop(esi);                               /* pop esi */
            ii(0x1017_29f0, 1); ret();                                  /* ret */
        }
    }
}
