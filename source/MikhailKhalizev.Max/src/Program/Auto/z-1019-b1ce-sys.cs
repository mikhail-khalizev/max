using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b1ce-55ececc1")]
        public void /* sys */ Method_1019_b1ce()
        {
            ii(0x1019_b1ce, 1); push(ecx);                              /* push ecx */
            ii(0x1019_b1cf, 1); push(esi);                              /* push esi */
            ii(0x1019_b1d0, 1); push(edi);                              /* push edi */
            ii(0x1019_b1d1, 1); push(ebp);                              /* push ebp */
            ii(0x1019_b1d2, 3); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1019_b1d5, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1019_b1d7, 4); mov(memd[ss, esp + 0x10], edx);         /* mov [esp+0x10], edx */
            ii(0x1019_b1db, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b1dd, 3); mov(al, memb[ss, ebp]);                 /* mov al, [ebp] */
            ii(0x1019_b1e0, 3); cmp(eax, 0x3a);                         /* cmp eax, 0x3a */
            ii(0x1019_b1e3, 2); if(jnz(0x1019_b1e6, 1)) goto l_0x1019_b1e6; /* jnz 0x1019b1e6 */
            ii(0x1019_b1e5, 1); inc(ebp);                               /* inc ebp */
        l_0x1019_b1e6:
            ii(0x1019_b1e6, 2); mov(esi, ebp);                          /* mov esi, ebp */
        l_0x1019_b1e8:
            ii(0x1019_b1e8, 3); mov(dl, memb[ss, ebp]);                 /* mov dl, [ebp] */
            ii(0x1019_b1eb, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1019_b1ed, 2); if(jz(0x1019_b20f, 0x20)) goto l_0x1019_b20f; /* jz 0x1019b20f */
            ii(0x1019_b1ef, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b1f1, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1019_b1f3, 3); cmp(eax, 0x2c);                         /* cmp eax, 0x2c */
            ii(0x1019_b1f6, 2); if(jz(0x1019_b20f, 0x17)) goto l_0x1019_b20f; /* jz 0x1019b20f */
            ii(0x1019_b1f8, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1019_b1fb, 2); if(jz(0x1019_b20f, 0x12)) goto l_0x1019_b20f; /* jz 0x1019b20f */
            ii(0x1019_b1fd, 3); cmp(eax, 0x2b);                         /* cmp eax, 0x2b */
            ii(0x1019_b200, 2); if(jz(0x1019_b20f, 0xd)) goto l_0x1019_b20f; /* jz 0x1019b20f */
            ii(0x1019_b202, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1019_b205, 2); if(jl(0x1019_b20c, 5)) goto l_0x1019_b20c; /* jl 0x1019b20c */
            ii(0x1019_b207, 3); cmp(eax, 0x39);                         /* cmp eax, 0x39 */
            ii(0x1019_b20a, 2); if(jle(0x1019_b20f, 3)) goto l_0x1019_b20f; /* jle 0x1019b20f */
        l_0x1019_b20c:
            ii(0x1019_b20c, 1); inc(ebp);                               /* inc ebp */
            ii(0x1019_b20d, 2); jmp(0x1019_b1e8, -0x27); goto l_0x1019_b1e8; /* jmp 0x1019b1e8 */
        l_0x1019_b20f:
            ii(0x1019_b20f, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1019_b211, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1019_b213, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1019_b217, 3); cmp(eax, 0x1e);                         /* cmp eax, 0x1e */
            ii(0x1019_b21a, 2); if(jle(0x1019_b224, 8)) goto l_0x1019_b224; /* jle 0x1019b224 */
            ii(0x1019_b21c, 8); mov(memd[ss, esp + 0xc], 0x1e);         /* mov dword [esp+0xc], 0x1e */
        l_0x1019_b224:
            ii(0x1019_b224, 4); mov(ecx, memd[ss, esp + 0xc]);          /* mov ecx, [esp+0xc] */
            ii(0x1019_b228, 4); mov(edi, memd[ss, esp + 0x10]);         /* mov edi, [esp+0x10] */
            ii(0x1019_b22c, 1); pushd(es);                              /* push es */
            ii(0x1019_b22d, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1019_b22f, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1019_b231, 1); push(edi);                              /* push edi */
            ii(0x1019_b232, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_b234, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1019_b237, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1019_b239, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1019_b23b, 3); and(cl, 3);                             /* and cl, 0x3 */
            ii(0x1019_b23e, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1019_b240, 1); pop(edi);                               /* pop edi */
            ii(0x1019_b241, 1); popd(es);                               /* pop es */
            ii(0x1019_b242, 4); mov(ecx, memd[ss, esp + 0xc]);          /* mov ecx, [esp+0xc] */
            ii(0x1019_b246, 3); lea(eax, memd[ds, edi + ecx]);          /* lea eax, [edi+ecx] */
            ii(0x1019_b249, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1019_b24c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b24e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_b250, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1019_b252, 3); lea(edx, memd[ss, ebp + 1]);            /* lea edx, [ebp+0x1] */
            ii(0x1019_b255, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1019_b258, 2); if(jnz(0x1019_b261, 7)) goto l_0x1019_b261; /* jnz 0x1019b261 */
            ii(0x1019_b25a, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1019_b25f, 2); jmp(0x1019_b266, 5); goto l_0x1019_b266; /* jmp 0x1019b266 */
        l_0x1019_b261:
            ii(0x1019_b261, 3); cmp(eax, 0x2b);                         /* cmp eax, 0x2b */
            ii(0x1019_b264, 2); if(jnz(0x1019_b268, 2)) goto l_0x1019_b268; /* jnz 0x1019b268 */
        l_0x1019_b266:
            ii(0x1019_b266, 2); mov(ebp, edx);                          /* mov ebp, edx */
        l_0x1019_b268:
            ii(0x1019_b268, 3); mov(al, memb[ss, ebp]);                 /* mov al, [ebp] */
            ii(0x1019_b26b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1019_b270, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1019_b273, 6); if(jl(0x1019_b2ed, 0x74)) goto l_0x1019_b2ed; /* jl 0x1019b2ed */
            ii(0x1019_b279, 3); cmp(eax, 0x39);                         /* cmp eax, 0x39 */
            ii(0x1019_b27c, 2); if(jg(0x1019_b2ed, 0x6f)) goto l_0x1019_b2ed; /* jg 0x1019b2ed */
            ii(0x1019_b27e, 4); lea(edx, memd[ss, esp + 8]);            /* lea edx, [esp+0x8] */
            ii(0x1019_b282, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1019_b284, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1019_b286, 3); mov(memd[ss, esp], esi);                /* mov [esp], esi */
            ii(0x1019_b289, 4); mov(memd[ss, esp + 4], esi);            /* mov [esp+0x4], esi */
            ii(0x1019_b28d, 4); mov(memd[ss, esp + 8], esi);            /* mov [esp+0x8], esi */
            ii(0x1019_b291, 5); call(/* sys */ 0x1019_b1aa, -0xec);     /* call 0x1019b1aa */
            ii(0x1019_b296, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b298, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1019_b29a, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1019_b29c, 3); cmp(edx, 0x3a);                         /* cmp edx, 0x3a */
            ii(0x1019_b29f, 2); if(jnz(0x1019_b2c0, 0x1f)) goto l_0x1019_b2c0; /* jnz 0x1019b2c0 */
            ii(0x1019_b2a1, 4); lea(edx, memd[ss, esp + 4]);            /* lea edx, [esp+0x4] */
            ii(0x1019_b2a5, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b2a6, 5); call(/* sys */ 0x1019_b1aa, -0x101);    /* call 0x1019b1aa */
            ii(0x1019_b2ab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b2ad, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1019_b2af, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1019_b2b1, 3); cmp(edx, 0x3a);                         /* cmp edx, 0x3a */
            ii(0x1019_b2b4, 2); if(jnz(0x1019_b2c0, 0xa)) goto l_0x1019_b2c0; /* jnz 0x1019b2c0 */
            ii(0x1019_b2b6, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1019_b2b8, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b2b9, 5); call(/* sys */ 0x1019_b1aa, -0x114);    /* call 0x1019b1aa */
            ii(0x1019_b2be, 2); mov(ebp, eax);                          /* mov ebp, eax */
        l_0x1019_b2c0:
            ii(0x1019_b2c0, 4); mov(esi, memd[ss, esp + 8]);            /* mov esi, [esp+0x8] */
            ii(0x1019_b2c4, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_b2c6, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1019_b2c9, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1019_b2cb, 4); mov(esi, memd[ss, esp + 4]);            /* mov esi, [esp+0x4] */
            ii(0x1019_b2cf, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1019_b2d2, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_b2d4, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_b2d6, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1019_b2d9, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1019_b2db, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1019_b2de, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1019_b2e1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1019_b2e3, 2); mov(memd[ds, ebx], edx);                /* mov [ebx], edx */
            ii(0x1019_b2e5, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_b2e7, 2); if(jz(0x1019_b2ed, 4)) goto l_0x1019_b2ed; /* jz 0x1019b2ed */
            ii(0x1019_b2e9, 2); neg(edx);                               /* neg edx */
            ii(0x1019_b2eb, 2); mov(memd[ds, ebx], edx);                /* mov [ebx], edx */
        l_0x1019_b2ed:
            ii(0x1019_b2ed, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1019_b2ef, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1019_b2f2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_b2f3, 1); pop(edi);                               /* pop edi */
            ii(0x1019_b2f4, 1); pop(esi);                               /* pop esi */
            ii(0x1019_b2f5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_b2f6, 1); ret();                                  /* ret */
        }
    }
}
