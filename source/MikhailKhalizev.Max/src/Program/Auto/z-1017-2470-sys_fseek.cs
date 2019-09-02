using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2470-c16ac63a")]
        public void /* sys */ sys_fseek()
        {
            ii(0x1017_2470, 1); push(ecx);                              /* push ecx */
            ii(0x1017_2471, 1); push(esi);                              /* push esi */
            ii(0x1017_2472, 1); push(edi);                              /* push edi */
            ii(0x1017_2473, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_2475, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_2477, 4); test(memb[ds, eax + 12], 6);            /* test byte [eax+0xc], 0x6 */
            ii(0x1017_247b, 2); if(jz(0x1017_24d8, 0x5b)) goto l_0x1017_24d8; /* jz 0x101724d8 */
            ii(0x1017_247d, 4); test(memb[ds, ecx + 13], 0x10);         /* test byte [ecx+0xd], 0x10 */
            ii(0x1017_2481, 2); if(jz(0x1017_24a9, 0x26)) goto l_0x1017_24a9; /* jz 0x101724a9 */
            ii(0x1017_2483, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_2485, 5); call(/* sys */ 0x1018_d5d9, 0x1_b14f);  /* call 0x1018d5d9 */
            ii(0x1017_248a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_248c, 2); if(jz(0x1017_24bd, 0x2f)) goto l_0x1017_24bd; /* jz 0x101724bd */
            ii(0x1017_248e, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_2490, 2); if(jnz(0x1017_24a0, 0xe)) goto l_0x1017_24a0; /* jnz 0x101724a0 */
            ii(0x1017_2492, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_2494, 2); if(jge(0x1017_24a0, 0xa)) goto l_0x1017_24a0; /* jge 0x101724a0 */
        l_0x1017_2496:
            ii(0x1017_2496, 5); mov(eax, 9);                            /* mov eax, 0x9 */
            ii(0x1017_249b, 5); call(/* sys */ 0x1018_d3bf, 0x1_af1f);  /* call 0x1018d3bf */
        l_0x1017_24a0:
            ii(0x1017_24a0, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_24a5, 1); pop(edi);                               /* pop edi */
            ii(0x1017_24a6, 1); pop(esi);                               /* pop esi */
            ii(0x1017_24a7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_24a8, 1); ret(); return;                          /* ret */
        l_0x1017_24a9:
            ii(0x1017_24a9, 3); cmp(ebx, 1);                            /* cmp ebx, 0x1 */
            ii(0x1017_24ac, 2); if(jnz(0x1017_24b1, 3)) goto l_0x1017_24b1; /* jnz 0x101724b1 */
            ii(0x1017_24ae, 3); sub(esi, memd[ds, ecx + 4]);            /* sub esi, [ecx+0x4] */
        l_0x1017_24b1:
            ii(0x1017_24b1, 3); mov(eax, memd[ds, ecx + 8]);            /* mov eax, [ecx+0x8] */
            ii(0x1017_24b4, 7); mov(memd[ds, ecx + 4], 0);              /* mov dword [ecx+0x4], 0x0 */
            ii(0x1017_24bb, 2); mov(memd[ds, ecx], eax);                /* mov [ecx], eax */
        l_0x1017_24bd:
            ii(0x1017_24bd, 4); and(memb[ds, ecx + 12], -0x15 /* 0xeb */); /* and byte [ecx+0xc], 0xeb */
            ii(0x1017_24c1, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_24c3, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1017_24c6, 5); call(Definitions.sys_lseek, 0xaccc);    /* call 0x1017d197 */
            ii(0x1017_24cb, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1017_24ce, 6); if(jnz(0x1017_2566, 0x92)) goto l_0x1017_2566; /* jnz 0x10172566 */
            ii(0x1017_24d4, 1); pop(edi);                               /* pop edi */
            ii(0x1017_24d5, 1); pop(esi);                               /* pop esi */
            ii(0x1017_24d6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_24d7, 1); ret(); return;                          /* ret */
        l_0x1017_24d8:
            ii(0x1017_24d8, 3); cmp(ebx, 1);                            /* cmp ebx, 0x1 */
            ii(0x1017_24db, 2); if(jb(0x1017_24e6, 9)) goto l_0x1017_24e6; /* jb 0x101724e6 */
            ii(0x1017_24dd, 2); if(jbe(0x1017_24ec, 0xd)) goto l_0x1017_24ec; /* jbe 0x101724ec */
            ii(0x1017_24df, 3); cmp(ebx, 2);                            /* cmp ebx, 0x2 */
            ii(0x1017_24e2, 2); if(jz(0x1017_2542, 0x5e)) goto l_0x1017_2542; /* jz 0x10172542 */
            ii(0x1017_24e4, 2); jmp(0x1017_2496, -0x50); goto l_0x1017_2496; /* jmp 0x10172496 */
        l_0x1017_24e6:
            ii(0x1017_24e6, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_24e8, 2); if(jz(0x1017_2511, 0x27)) goto l_0x1017_2511; /* jz 0x10172511 */
            ii(0x1017_24ea, 2); jmp(0x1017_2496, -0x56); goto l_0x1017_2496; /* jmp 0x10172496 */
        l_0x1017_24ec:
            ii(0x1017_24ec, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1017_24ee, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_24f0, 3); mov(edi, memd[ds, ecx + 4]);            /* mov edi, [ecx+0x4] */
            ii(0x1017_24f3, 5); call(/* sys */ 0x1017_242e, -0xca);     /* call 0x1017242e */
            ii(0x1017_24f8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_24fa, 2); if(jz(0x1017_2566, 0x6a)) goto l_0x1017_2566; /* jz 0x10172566 */
            ii(0x1017_24fc, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_24fe, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1017_2501, 2); sub(edx, edi);                          /* sub edx, edi */
            ii(0x1017_2503, 5); call(Definitions.sys_lseek, 0xac8f);    /* call 0x1017d197 */
            ii(0x1017_2508, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1017_250b, 2); if(jnz(0x1017_2566, 0x59)) goto l_0x1017_2566; /* jnz 0x10172566 */
            ii(0x1017_250d, 1); pop(edi);                               /* pop edi */
            ii(0x1017_250e, 1); pop(esi);                               /* pop esi */
            ii(0x1017_250f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_2510, 1); ret(); return;                          /* ret */
        l_0x1017_2511:
            ii(0x1017_2511, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1017_2514, 5); call(/* sys */ 0x1018_d71d, 0x1_b204);  /* call 0x1018d71d */
            ii(0x1017_2519, 3); mov(edx, memd[ds, ecx + 4]);            /* mov edx, [ecx+0x4] */
            ii(0x1017_251c, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1017_251e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1017_2520, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x1017_2522, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1017_2524, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_2526, 5); call(/* sys */ 0x1017_242e, -0xfd);     /* call 0x1017242e */
            ii(0x1017_252b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_252d, 2); if(jz(0x1017_2566, 0x37)) goto l_0x1017_2566; /* jz 0x10172566 */
            ii(0x1017_252f, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_2531, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1017_2534, 5); call(Definitions.sys_lseek, 0xac5e);    /* call 0x1017d197 */
            ii(0x1017_2539, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1017_253c, 2); if(jnz(0x1017_2566, 0x28)) goto l_0x1017_2566; /* jnz 0x10172566 */
            ii(0x1017_253e, 1); pop(edi);                               /* pop edi */
            ii(0x1017_253f, 1); pop(esi);                               /* pop esi */
            ii(0x1017_2540, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_2541, 1); ret(); return;                          /* ret */
        l_0x1017_2542:
            ii(0x1017_2542, 3); mov(eax, memd[ds, ecx + 8]);            /* mov eax, [ecx+0x8] */
            ii(0x1017_2545, 3); mov(dl, memb[ds, ecx + 12]);            /* mov dl, [ecx+0xc] */
            ii(0x1017_2548, 2); mov(memd[ds, ecx], eax);                /* mov [ecx], eax */
            ii(0x1017_254a, 3); and(dl, 0xef);                          /* and dl, 0xef */
            ii(0x1017_254d, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1017_2550, 3); mov(memb[ds, ecx + 12], dl);            /* mov [ecx+0xc], dl */
            ii(0x1017_2553, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_2555, 7); mov(memd[ds, ecx + 4], 0);              /* mov dword [ecx+0x4], 0x0 */
            ii(0x1017_255c, 5); call(Definitions.sys_lseek, 0xac36);    /* call 0x1017d197 */
            ii(0x1017_2561, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1017_2564, 2); if(jz(0x1017_2568, 2)) goto l_0x1017_2568; /* jz 0x10172568 */
        l_0x1017_2566:
            ii(0x1017_2566, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1017_2568:
            ii(0x1017_2568, 1); pop(edi);                               /* pop edi */
            ii(0x1017_2569, 1); pop(esi);                               /* pop esi */
            ii(0x1017_256a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_256b, 1); ret();                                  /* ret */
        }
    }
}
