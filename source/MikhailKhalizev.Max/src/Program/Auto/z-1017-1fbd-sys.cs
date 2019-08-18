using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("93ca2966-9c45-4b62-95e1-2ec492310737")]
        public void /* sys */ Method_1017_1fbd()
        {
            ii(0x1017_1fbd, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_1fbe, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_1fbf, 1); pushd(edx);                             /* push edx */
            ii(0x1017_1fc0, 1); pushd(esi);                             /* push esi */
            ii(0x1017_1fc1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_1fc3, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x1017_1fc7, 2); if(jnzd(0x1017_1fce, 0x5)) goto l_0x1017_1fce; /* jnz 0x10171fce */
            ii(0x1017_1fc9, 5); calld(/* sys */ 0x1018_d3ee, 0x1_b420); /* call 0x1018d3ee */
        l_0x1017_1fce:
            ii(0x1017_1fce, 3); mov(ah, memb_a32[ds, ecx + 0xd]);       /* mov ah, [ecx+0xd] */
            ii(0x1017_1fd1, 3); test(ah, 0x20);                         /* test ah, 0x20 */
            ii(0x1017_1fd4, 2); if(jzd(0x1017_1fe5, 0xf)) goto l_0x1017_1fe5; /* jz 0x10171fe5 */
            ii(0x1017_1fd6, 3); test(ah, 0x6);                          /* test ah, 0x6 */
            ii(0x1017_1fd9, 2); if(jzd(0x1017_1fe5, 0xa)) goto l_0x1017_1fe5; /* jz 0x10171fe5 */
            ii(0x1017_1fdb, 5); mov(eax, 0x2000);                       /* mov eax, 0x2000 */
            ii(0x1017_1fe0, 5); calld(/* sys */ 0x1018_d46a, 0x1_b485); /* call 0x1018d46a */
        l_0x1017_1fe5:
            ii(0x1017_1fe5, 3); mov(edx, memd_a32[ds, ecx + 0x8]);      /* mov edx, [ecx+0x8] */
            ii(0x1017_1fe8, 2); mov(memd_a32[ds, ecx], edx);            /* mov [ecx], edx */
            ii(0x1017_1fea, 3); mov(dh, memb_a32[ds, ecx + 0xc]);       /* mov dh, [ecx+0xc] */
            ii(0x1017_1fed, 3); mov(eax, memd_a32[ds, ecx + 0xc]);      /* mov eax, [ecx+0xc] */
            ii(0x1017_1ff0, 3); and(dh, 0xfb);                          /* and dh, 0xfb */
            ii(0x1017_1ff3, 5); and(eax, 0x2400);                       /* and eax, 0x2400 */
            ii(0x1017_1ff8, 3); mov(memb_a32[ds, ecx + 0xc], dh);       /* mov [ecx+0xc], dh */
            ii(0x1017_1ffb, 5); cmp(eax, 0x2400);                       /* cmp eax, 0x2400 */
            ii(0x1017_2000, 2); if(jnzd(0x1017_2025, 0x23)) goto l_0x1017_2025; /* jnz 0x10172025 */
            ii(0x1017_2002, 3); mov(ebx, memd_a32[ds, ecx + 0x10]);     /* mov ebx, [ecx+0x10] */
            ii(0x1017_2005, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_2007, 2); if(jnzd(0x1017_2025, 0x1c)) goto l_0x1017_2025; /* jnz 0x10172025 */
            ii(0x1017_2009, 3); mov(memd_a32[ds, ecx + 0x4], ebx);      /* mov [ecx+0x4], ebx */
            ii(0x1017_200c, 5); calld(/* sys */ 0x1018_d499, 0x1_b488); /* call 0x1018d499 */
            ii(0x1017_2011, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_2013, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_2016, 2); if(jzd(0x1017_2042, 0x2a)) goto l_0x1017_2042; /* jz 0x10172042 */
            ii(0x1017_2018, 2); mov(eax, memd_a32[ds, ecx]);            /* mov eax, [ecx] */
            ii(0x1017_201a, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1017_201c, 7); mov(memd_a32[ds, ecx + 0x4], 0x1);      /* mov dword [ecx+0x4], 0x1 */
            ii(0x1017_2023, 2); jmpd(0x1017_2042, 0x1d); goto l_0x1017_2042; /* jmp 0x10172042 */
        l_0x1017_2025:
            ii(0x1017_2025, 4); test(memb_a32[ds, ecx + 0xd], 0x4);     /* test byte [ecx+0xd], 0x4 */
            ii(0x1017_2029, 2); if(jzd(0x1017_2032, 0x7)) goto l_0x1017_2032; /* jz 0x10172032 */
            ii(0x1017_202b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1017_2030, 2); jmpd(0x1017_2035, 0x3); goto l_0x1017_2035; /* jmp 0x10172035 */
        l_0x1017_2032:
            ii(0x1017_2032, 3); mov(ebx, memd_a32[ds, ecx + 0x14]);     /* mov ebx, [ecx+0x14] */
        l_0x1017_2035:
            ii(0x1017_2035, 2); mov(edx, memd_a32[ds, ecx]);            /* mov edx, [ecx] */
            ii(0x1017_2037, 3); mov(eax, memd_a32[ds, ecx + 0x10]);     /* mov eax, [ecx+0x10] */
            ii(0x1017_203a, 5); calld(/* sys */ 0x1018_d4b6, 0x1_b477); /* call 0x1018d4b6 */
            ii(0x1017_203f, 3); mov(memd_a32[ds, ecx + 0x4], eax);      /* mov [ecx+0x4], eax */
        l_0x1017_2042:
            ii(0x1017_2042, 3); mov(esi, memd_a32[ds, ecx + 0x4]);      /* mov esi, [ecx+0x4] */
            ii(0x1017_2045, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_2047, 2); if(jgd(0x1017_2061, 0x18)) goto l_0x1017_2061; /* jg 0x10172061 */
            ii(0x1017_2049, 2); if(jnzd(0x1017_2051, 0x6)) goto l_0x1017_2051; /* jnz 0x10172051 */
            ii(0x1017_204b, 4); or(memb_a32[ds, ecx + 0xc], 0x10);      /* or byte [ecx+0xc], 0x10 */
            ii(0x1017_204f, 2); jmpd(0x1017_2061, 0x10); goto l_0x1017_2061; /* jmp 0x10172061 */
        l_0x1017_2051:
            ii(0x1017_2051, 3); mov(bh, memb_a32[ds, ecx + 0xc]);       /* mov bh, [ecx+0xc] */
            ii(0x1017_2054, 7); mov(memd_a32[ds, ecx + 0x4], 0);        /* mov dword [ecx+0x4], 0x0 */
            ii(0x1017_205b, 3); or(bh, 0x20);                           /* or bh, 0x20 */
            ii(0x1017_205e, 3); mov(memb_a32[ds, ecx + 0xc], bh);       /* mov [ecx+0xc], bh */
        l_0x1017_2061:
            ii(0x1017_2061, 3); mov(eax, memd_a32[ds, ecx + 0x4]);      /* mov eax, [ecx+0x4] */
            ii(0x1017_2064, 1); popd(esi);                              /* pop esi */
            ii(0x1017_2065, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2066, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_2067, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_2068, 1); retd(); return;                         /* ret */
        }
    }
}
