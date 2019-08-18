using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_227d-2e3dad99")]
        public void /* sys */ Method_1017_227d()
        {
            ii(0x1017_227d, 1); pushd(esi);                             /* push esi */
            ii(0x1017_227e, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_2280, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1017_2282, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1017_2284, 4); mov(ecx, memd_a32[ss, esp + 0x8]);      /* mov ecx, [esp+0x8] */
            ii(0x1017_2288, 4); and(memb_a32[ds, ecx + 0xc], -0x4 /* 0xfc */); /* and byte [ecx+0xc], 0xfc */
            ii(0x1017_228c, 3); or(memd_a32[ds, ecx + 0xc], ebx);       /* or [ecx+0xc], ebx */
            ii(0x1017_228f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_2294, 5); calld(Definitions.sys_toupper, 0xec51); /* call 0x10180eea */
            ii(0x1017_2299, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_229e, 3); cmp(eax, 0x72);                         /* cmp eax, 0x72 */
            ii(0x1017_22a1, 2); if(jnzd(0x1017_22c0, 0x1d)) goto l_0x1017_22c0; /* jnz 0x101722c0 */
            ii(0x1017_22a3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_22a5, 3); test(bl, 0x2);                          /* test bl, 0x2 */
            ii(0x1017_22a8, 2); if(jzd(0x1017_22af, 0x5)) goto l_0x1017_22af; /* jz 0x101722af */
            ii(0x1017_22aa, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
        l_0x1017_22af:
            ii(0x1017_22af, 3); test(bl, 0x40);                         /* test bl, 0x40 */
            ii(0x1017_22b2, 2); if(jzd(0x1017_22b9, 0x5)) goto l_0x1017_22b9; /* jz 0x101722b9 */
            ii(0x1017_22b4, 3); or(ah, 0x2);                            /* or ah, 0x2 */
            ii(0x1017_22b7, 2); jmpd(0x1017_22bc, 0x3); goto l_0x1017_22bc; /* jmp 0x101722bc */
        l_0x1017_22b9:
            ii(0x1017_22b9, 3); or(ah, 0x1);                            /* or ah, 0x1 */
        l_0x1017_22bc:
            ii(0x1017_22bc, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_22be, 2); jmpd(0x1017_22eb, 0x2b); goto l_0x1017_22eb; /* jmp 0x101722eb */
        l_0x1017_22c0:
            ii(0x1017_22c0, 3); test(bl, 0x1);                          /* test bl, 0x1 */
            ii(0x1017_22c3, 3); setnz(al);                              /* setnz al */
            ii(0x1017_22c6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_22cb, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1017_22ce, 3); test(bl, 0x80);                         /* test bl, 0x80 */
            ii(0x1017_22d1, 2); if(jzd(0x1017_22d7, 0x4)) goto l_0x1017_22d7; /* jz 0x101722d7 */
            ii(0x1017_22d3, 2); or(al, 0x10);                           /* or al, 0x10 */
            ii(0x1017_22d5, 2); jmpd(0x1017_22d9, 0x2); goto l_0x1017_22d9; /* jmp 0x101722d9 */
        l_0x1017_22d7:
            ii(0x1017_22d7, 2); or(al, 0x40);                           /* or al, 0x40 */
        l_0x1017_22d9:
            ii(0x1017_22d9, 3); test(bl, 0x40);                         /* test bl, 0x40 */
            ii(0x1017_22dc, 2); if(jzd(0x1017_22e3, 0x5)) goto l_0x1017_22e3; /* jz 0x101722e3 */
            ii(0x1017_22de, 3); or(ah, 0x2);                            /* or ah, 0x2 */
            ii(0x1017_22e1, 2); jmpd(0x1017_22e6, 0x3); goto l_0x1017_22e6; /* jmp 0x101722e6 */
        l_0x1017_22e3:
            ii(0x1017_22e3, 3); or(ah, 0x1);                            /* or ah, 0x1 */
        l_0x1017_22e6:
            ii(0x1017_22e6, 5); pushd(0x180);                           /* push 0x180 */
        l_0x1017_22eb:
            ii(0x1017_22eb, 1); pushd(edx);                             /* push edx */
            ii(0x1017_22ec, 1); pushd(eax);                             /* push eax */
            ii(0x1017_22ed, 1); pushd(esi);                             /* push esi */
            ii(0x1017_22ee, 5); calld(/* sys */ 0x1017_cf49, 0xac56);   /* call 0x1017cf49 */
            ii(0x1017_22f3, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_22f6, 3); mov(memd_a32[ds, ecx + 0x10], eax);     /* mov [ecx+0x10], eax */
            ii(0x1017_22f9, 4); cmp(memd_a32[ds, ecx + 0x10], -0x1 /* 0xff */); /* cmp dword [ecx+0x10], 0xffffffff */
            ii(0x1017_22fd, 2); if(jnzd(0x1017_230c, 0xd)) goto l_0x1017_230c; /* jnz 0x1017230c */
            ii(0x1017_22ff, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_2301, 5); calld(/* sys */ 0x1018_d57c, 0x1_b276); /* call 0x1018d57c */
            ii(0x1017_2306, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_2308, 1); popd(esi);                              /* pop esi */
            ii(0x1017_2309, 3); retd(0x4); return;                      /* ret 0x4 */
        l_0x1017_230c:
            ii(0x1017_230c, 7); mov(memd_a32[ds, ecx + 0x4], 0);        /* mov dword [ecx+0x4], 0x0 */
            ii(0x1017_2313, 7); mov(memd_a32[ds, ecx + 0x8], 0);        /* mov dword [ecx+0x8], 0x0 */
            ii(0x1017_231a, 7); mov(memd_a32[ds, ecx + 0x14], 0);       /* mov dword [ecx+0x14], 0x0 */
            ii(0x1017_2321, 3); test(bl, 0x80);                         /* test bl, 0x80 */
            ii(0x1017_2324, 2); if(jzd(0x1017_2334, 0xe)) goto l_0x1017_2334; /* jz 0x10172334 */
            ii(0x1017_2326, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1017_232b, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_232d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_232f, 5); calld(Definitions.sys_fseek, 0x13c);    /* call 0x10172470 */
        l_0x1017_2334:
            ii(0x1017_2334, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_2336, 5); calld(/* sys */ 0x1018_d6ec, 0x1_b3b1); /* call 0x1018d6ec */
            ii(0x1017_233b, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_233d, 1); popd(esi);                              /* pop esi */
            ii(0x1017_233e, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
