using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d888-ee5b2da0")]
        public void /* sys */ Method_1018_d888()
        {
            ii(0x1018_d888, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_d889, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_d88a, 1); pushd(edx);                             /* push edx */
            ii(0x1018_d88b, 1); pushd(esi);                             /* push esi */
            ii(0x1018_d88c, 1); pushd(edi);                             /* push edi */
            ii(0x1018_d88d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_d88e, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_d890, 5); mov(esi, 0xc);                          /* mov esi, 0xc */
            ii(0x1018_d895, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x1018_d898, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1018_d89b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1018_d89e, 2); idiv(esi);                              /* idiv esi */
            ii(0x1018_d8a0, 5); mov(ebx, 0x101b_76cc);                  /* mov ebx, 0x101b76cc */
            ii(0x1018_d8a5, 3); mov(esi, memd_a32[ss, ebp + 0x14]);     /* mov esi, [ebp+0x14] */
            ii(0x1018_d8a8, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_d8aa, 6); cmp(esi, 0xf4fb_7ea1);                  /* cmp esi, 0xf4fb7ea1 */
            ii(0x1018_d8b0, 2); if(jged(0x1018_d8bc, 0xa)) goto l_0x1018_d8bc; /* jge 0x1018d8bc */
        l_0x1018_d8b2:
            ii(0x1018_d8b2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1018_d8b7, 5); jmpd(0x1018_d9d5, 0x119); goto l_0x1018_d9d5; /* jmp 0x1018d9d5 */
        l_0x1018_d8bc:
            ii(0x1018_d8bc, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1018_d8bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d8c1, 5); mov(ecx, 0xc);                          /* mov ecx, 0xc */
            ii(0x1018_d8c6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1018_d8c9, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1018_d8cb, 2); add(esi, eax);                          /* add esi, eax */
        l_0x1018_d8cd:
            ii(0x1018_d8cd, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_d8cf, 2); if(jged(0x1018_d8d7, 0x6)) goto l_0x1018_d8d7; /* jge 0x1018d8d7 */
            ii(0x1018_d8d1, 1); dec(esi);                               /* dec esi */
            ii(0x1018_d8d2, 3); add(edi, 0xc);                          /* add edi, 0xc */
            ii(0x1018_d8d5, 2); jmpd(0x1018_d8cd, -0xa); goto l_0x1018_d8cd; /* jmp 0x1018d8cd */
        l_0x1018_d8d7:
            ii(0x1018_d8d7, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_d8d9, 2); if(jld(0x1018_d8b2, -0x29)) goto l_0x1018_d8b2; /* jl 0x1018d8b2 */
            ii(0x1018_d8db, 6); lea(eax, esi + 0x76c);                  /* lea eax, [esi+0x76c] */
            ii(0x1018_d8e1, 5); calld(/* sys */ 0x1019_ab72, 0xd28c);   /* call 0x1019ab72 */
            ii(0x1018_d8e6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d8e8, 2); if(jzd(0x1018_d8ef, 0x5)) goto l_0x1018_d8ef; /* jz 0x1018d8ef */
            ii(0x1018_d8ea, 5); mov(ebx, 0x101b_76e6);                  /* mov ebx, 0x101b76e6 */
        l_0x1018_d8ef:
            ii(0x1018_d8ef, 3); lea(ecx, esi + 0x3);                    /* lea ecx, [esi+0x3] */
            ii(0x1018_d8f2, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_d8f4, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_d8f7, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1018_d8f9, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_d8fc, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1018_d8fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d900, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_d903, 3); sar(ecx, 0x2);                          /* sar ecx, 0x2 */
            ii(0x1018_d906, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_d908, 3); lea(edx, eax + ecx);                    /* lea edx, [eax+ecx] */
            ii(0x1018_d90b, 4); movsx(eax, memw_a32[ds, ebx + edi * 2]); /* movsx eax, word [ebx+edi*2] */
            ii(0x1018_d90f, 3); mov(edi, memd_a32[ss, ebp + 0xc]);      /* mov edi, [ebp+0xc] */
            ii(0x1018_d912, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_d914, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1018_d916, 1); dec(edi);                               /* dec edi */
            ii(0x1018_d917, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_d919, 2); if(jzd(0x1018_d91c, 0x1)) goto l_0x1018_d91c; /* jz 0x1018d91c */
            ii(0x1018_d91b, 1); dec(edi);                               /* dec edi */
        l_0x1018_d91c:
            ii(0x1018_d91c, 3); mov(edx, memd_a32[ss, ebp + 0x8]);      /* mov edx, [ebp+0x8] */
            ii(0x1018_d91f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_d921, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1018_d924, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1018_d926, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_d929, 3); mov(edx, memd_a32[ss, ebp + 0x4]);      /* mov edx, [ebp+0x4] */
            ii(0x1018_d92c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_d92e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_d930, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1018_d933, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1018_d935, 3); mov(esi, memd_a32[ss, ebp + 0]);        /* mov esi, [ebp] */
            ii(0x1018_d938, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_d93b, 2); add(esi, eax);                          /* add esi, eax */
        l_0x1018_d93d:
            ii(0x1018_d93d, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_d93f, 2); if(jged(0x1018_d94a, 0x9)) goto l_0x1018_d94a; /* jge 0x1018d94a */
            ii(0x1018_d941, 1); dec(edi);                               /* dec edi */
            ii(0x1018_d942, 6); add(esi, 0x1_5180);                     /* add esi, 0x15180 */
            ii(0x1018_d948, 2); jmpd(0x1018_d93d, -0xd); goto l_0x1018_d93d; /* jmp 0x1018d93d */
        l_0x1018_d94a:
            ii(0x1018_d94a, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1018_d94c, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1018_d94e, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_d950, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_d952, 5); calld(/* sys */ 0x1019_afb9, 0xd662);   /* call 0x1019afb9 */
            ii(0x1018_d957, 5); calld(/* sys */ 0x1019_b165, 0xd809);   /* call 0x1019b165 */
            ii(0x1018_d95c, 6); mov(edx, memd_a32[ds, 0x101c_1ca0]);    /* mov edx, [0x101c1ca0] */
            ii(0x1018_d962, 3); mov(ebx, memd_a32[ss, ebp + 0x20]);     /* mov ebx, [ebp+0x20] */
            ii(0x1018_d965, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_d967, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_d969, 2); if(jged(0x1018_d972, 0x7)) goto l_0x1018_d972; /* jge 0x1018d972 */
            ii(0x1018_d96b, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_d96d, 5); calld(/* sys */ 0x1019_acc6, 0xd354);   /* call 0x1019acc6 */
        l_0x1018_d972:
            ii(0x1018_d972, 4); cmp(memd_a32[ss, ebp + 0x20], 0);       /* cmp dword [ebp+0x20], 0x0 */
            ii(0x1018_d976, 2); if(jled(0x1018_d97e, 0x6)) goto l_0x1018_d97e; /* jle 0x1018d97e */
            ii(0x1018_d978, 6); sub(esi, memd_a32[ds, 0x101c_1ca4]);    /* sub esi, [0x101c1ca4] */
        l_0x1018_d97e:
            ii(0x1018_d97e, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_d980, 2); if(jged(0x1018_d98b, 0x9)) goto l_0x1018_d98b; /* jge 0x1018d98b */
            ii(0x1018_d982, 1); dec(edi);                               /* dec edi */
            ii(0x1018_d983, 6); add(esi, 0x1_5180);                     /* add esi, 0x15180 */
            ii(0x1018_d989, 2); jmpd(0x1018_d97e, -0xd); goto l_0x1018_d97e; /* jmp 0x1018d97e */
        l_0x1018_d98b:
            ii(0x1018_d98b, 6); cmp(edi, 0x63de);                       /* cmp edi, 0x63de */
            ii(0x1018_d991, 6); if(jld(0x1018_d8b2, -0xe5)) goto l_0x1018_d8b2; /* jl 0x1018d8b2 */
            ii(0x1018_d997, 2); if(jnzd(0x1018_d9b5, 0x1c)) goto l_0x1018_d9b5; /* jnz 0x1018d9b5 */
            ii(0x1018_d999, 5); mov(eax, memd_a32[ds, 0x101c_1ca0]);    /* mov eax, [0x101c1ca0] */
            ii(0x1018_d99e, 6); sub(esi, 0x1_5180);                     /* sub esi, 0x15180 */
            ii(0x1018_d9a4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d9a6, 6); if(jled(0x1018_d8b2, -0xfa)) goto l_0x1018_d8b2; /* jle 0x1018d8b2 */
            ii(0x1018_d9ac, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_d9ae, 2); if(jged(0x1018_d9d3, 0x23)) goto l_0x1018_d9d3; /* jge 0x1018d9d3 */
            ii(0x1018_d9b0, 5); jmpd(0x1018_d8b2, -0x103); goto l_0x1018_d8b2; /* jmp 0x1018d8b2 */
        l_0x1018_d9b5:
            ii(0x1018_d9b5, 6); lea(eax, edi - 0x63df);                 /* lea eax, [edi-0x63df] */
            ii(0x1018_d9bb, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_d9bd, 3); shl(edi, 0x3);                          /* shl edi, 0x3 */
            ii(0x1018_d9c0, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x1018_d9c2, 3); shl(edi, 0x5);                          /* shl edi, 0x5 */
            ii(0x1018_d9c5, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1018_d9c7, 3); shl(edi, 0x7);                          /* shl edi, 0x7 */
            ii(0x1018_d9ca, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_d9cc, 3); shl(edi, 0x2);                          /* shl edi, 0x2 */
            ii(0x1018_d9cf, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x1018_d9d1, 2); add(esi, edi);                          /* add esi, edi */
        l_0x1018_d9d3:
            ii(0x1018_d9d3, 2); mov(eax, esi);                          /* mov eax, esi */
        l_0x1018_d9d5:
            ii(0x1018_d9d5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_d9d6, 1); popd(edi);                              /* pop edi */
            ii(0x1018_d9d7, 1); popd(esi);                              /* pop esi */
            ii(0x1018_d9d8, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d9d9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_d9da, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_d9db, 1); retd();                                 /* ret */
        }
    }
}
