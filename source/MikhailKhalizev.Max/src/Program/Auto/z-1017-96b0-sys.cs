using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a1d408ee-2f6a-4f58-950c-6ddb33f1d8eb")]
        public void /* sys */ Method_1017_96b0()
        {
            ii(0x1017_96b0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_96b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_96b3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_96b4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_96b5, 1); pushd(esi);                             /* push esi */
            ii(0x1017_96b6, 1); pushd(edi);                             /* push edi */
            ii(0x1017_96b7, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_96b9, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_96bb, 7); lea(eax, eax * 4 + 0);                  /* lea eax, [eax*4] */
            ii(0x1017_96c2, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1017_96c4, 7); lea(eax, eax * 8 + 0);                  /* lea eax, [eax*8] */
            ii(0x1017_96cb, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1017_96cd, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1017_96d0, 5); mov(edi, 0x20bc);                       /* mov edi, 0x20bc */
            ii(0x1017_96d5, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1017_96d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_96d9, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1017_96dc, 2); div(edi);                               /* div edi */
            ii(0x1017_96de, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_96e0, 3); imul(edi, ebx);                         /* imul edi, ebx */
            ii(0x1017_96e3, 6); mov(edx, memd_a32[ds, 0x101b_e41c]);    /* mov edx, [0x101be41c] */
            ii(0x1017_96e9, 2); neg(edi);                               /* neg edi */
            ii(0x1017_96eb, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1017_96ee, 2); if(jzd(0x1017_9704, 0x14)) goto l_0x1017_9704; /* jz 0x10179704 */
            ii(0x1017_96f0, 6); cmp(esi, memd_a32[ds, 0x1020_9dbc]);    /* cmp esi, [0x10209dbc] */
            ii(0x1017_96f6, 2); if(jnzd(0x1017_9704, 0xc)) goto l_0x1017_9704; /* jnz 0x10179704 */
            ii(0x1017_96f8, 6); cmp(edi, memd_a32[ds, 0x1020_9dc0]);    /* cmp edi, [0x10209dc0] */
            ii(0x1017_96fe, 6); if(jzd(0x1017_97db, 0xd7)) goto l_0x1017_97db; /* jz 0x101797db */
        l_0x1017_9704:
            ii(0x1017_9704, 7); cmp(memd_a32[ds, 0x101b_e41c], -0x1 /* 0xff */); /* cmp dword [0x101be41c], 0xffffffff */
            ii(0x1017_970b, 2); if(jzd(0x1017_971d, 0x10)) goto l_0x1017_971d; /* jz 0x1017971d */
            ii(0x1017_970d, 5); calld(/* sys */ 0x1018_dcc4, 0x145b2);  /* call 0x1018dcc4 */
            ii(0x1017_9712, 5); mov(eax, memd_a32[ds, 0x1020_9dc0]);    /* mov eax, [0x10209dc0] */
            ii(0x1017_9717, 6); add(memd_a32[ds, 0x101b_e420], eax);    /* add [0x101be420], eax */
        l_0x1017_971d:
            ii(0x1017_971d, 6); mov(memd_a32[ds, 0x1020_9dbc], esi);    /* mov [0x10209dbc], esi */
            ii(0x1017_9723, 6); mov(memd_a32[ds, 0x1020_9dc0], edi);    /* mov [0x10209dc0], edi */
            ii(0x1017_9729, 6); mov(ebx, memd_a32[ds, 0x101b_e41c]);    /* mov ebx, [0x101be41c] */
            ii(0x1017_972f, 3); cmp(ebx, -0x1 /* 0xff */);              /* cmp ebx, 0xffffffff */
            ii(0x1017_9732, 2); if(jzd(0x1017_974e, 0x1a)) goto l_0x1017_974e; /* jz 0x1017974e */
            ii(0x1017_9734, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_9736, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_973b, 5); calld(/* sys */ 0x1017_dc61, 0x4521);   /* call 0x1017dc61 */
            ii(0x1017_9740, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_9742, 6); mov(memd_a32[ds, 0x101b_e41c], ecx);    /* mov [0x101be41c], ecx */
            ii(0x1017_9748, 6); mov(memd_a32[ds, 0x101b_e420], esi);    /* mov [0x101be420], esi */
        l_0x1017_974e:
            ii(0x1017_974e, 7); cmp(memd_a32[ds, 0x101b_e42c], 0);      /* cmp dword [0x101be42c], 0x0 */
            ii(0x1017_9755, 2); if(jzd(0x1017_9779, 0x22)) goto l_0x1017_9779; /* jz 0x10179779 */
            ii(0x1017_9757, 5); mov(eax, 0x1020_9dd0);                  /* mov eax, 0x10209dd0 */
            ii(0x1017_975c, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1017_9761, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9763, 5); calld(/* sys */ 0x1019_44a0, 0x1ad38);  /* call 0x101944a0 */
            ii(0x1017_9768, 5); mov(eax, 0x101b_e420);                  /* mov eax, 0x101be420 */
            ii(0x1017_976d, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1017_9772, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9774, 5); calld(/* sys */ 0x1019_44a0, 0x1ad27);  /* call 0x101944a0 */
        l_0x1017_9779:
            ii(0x1017_9779, 7); cmp(memd_a32[ds, 0x101b_e42c], 0);      /* cmp dword [0x101be42c], 0x0 */
            ii(0x1017_9780, 2); if(jzd(0x1017_97ac, 0x2a)) goto l_0x1017_97ac; /* jz 0x101797ac */
            ii(0x1017_9782, 5); mov(ebx, 0x400);                        /* mov ebx, 0x400 */
            ii(0x1017_9787, 5); mov(eax, memd_a32[ds, 0x101b_e430]);    /* mov eax, [0x101be430] */
            ii(0x1017_978c, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_978e, 5); calld(/* sys */ 0x1019_44a0, 0x1ad0d);  /* call 0x101944a0 */
            ii(0x1017_9793, 5); mov(eax, /* sys */ 0x1017_9690);        /* mov eax, 0x10179690 */
            ii(0x1017_9798, 5); mov(ebx, 0x400);                        /* mov ebx, 0x400 */
            ii(0x1017_979d, 2); mov(edx, cs);                           /* mov edx, cs */
            ii(0x1017_979f, 5); calld(/* sys */ 0x1019_44a0, 0x1acfc);  /* call 0x101944a0 */
            ii(0x1017_97a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_97a6, 6); mov(memd_a32[ds, 0x101b_e42c], edx);    /* mov [0x101be42c], edx */
        l_0x1017_97ac:
            ii(0x1017_97ac, 1); pushd(ds);                              /* push ds */
            ii(0x1017_97ad, 5); mov(eax, 0x77);                         /* mov eax, 0x77 */
            ii(0x1017_97b2, 5); pushd(0x101b_e41c);                     /* push 0x101be41c */
            ii(0x1017_97b7, 5); mov(ebx, /* sys */ 0x1017_9690);        /* mov ebx, 0x10179690 */
            ii(0x1017_97bc, 2); mov(ecx, cs);                           /* mov ecx, cs */
            ii(0x1017_97be, 5); calld(/* sys */ 0x1017_d93f, 0x417c);   /* call 0x1017d93f */
            ii(0x1017_97c3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_97c5, 2); if(jzd(0x1017_97d6, 0xf)) goto l_0x1017_97d6; /* jz 0x101797d6 */
            ii(0x1017_97c7, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_97cc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_97ce, 6); mov(memd_a32[ds, 0x101b_e41c], ebx);    /* mov [0x101be41c], ebx */
            ii(0x1017_97d4, 2); jmpd(0x1017_97e0, 0xa); goto l_0x1017_97e0; /* jmp 0x101797e0 */
        l_0x1017_97d6:
            ii(0x1017_97d6, 5); calld(/* sys */ 0x1018_dc98, 0x144bd);  /* call 0x1018dc98 */
        l_0x1017_97db:
            ii(0x1017_97db, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1017_97e0:
            ii(0x1017_97e0, 3); lea(esp, ebp - 0x10);                   /* lea esp, [ebp-0x10] */
            ii(0x1017_97e3, 1); popd(edi);                              /* pop edi */
            ii(0x1017_97e4, 1); popd(esi);                              /* pop esi */
            ii(0x1017_97e5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_97e6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_97e7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_97e8, 1); retd(); return;                         /* ret */
        }
    }
}
