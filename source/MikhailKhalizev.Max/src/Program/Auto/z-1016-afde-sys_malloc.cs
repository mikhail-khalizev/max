using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_afde-69497942")]
        public void /* sys */ sys_malloc()
        {
            ii(0x1016_afde, 1); push(ebx);                              /* push ebx */
            ii(0x1016_afdf, 1); push(ecx);                              /* push ecx */
            ii(0x1016_afe0, 1); push(edx);                              /* push edx */
            ii(0x1016_afe1, 1); push(esi);                              /* push esi */
            ii(0x1016_afe2, 1); push(edi);                              /* push edi */
            ii(0x1016_afe3, 1); pushd(es);                              /* push es */
            ii(0x1016_afe4, 2); pushd(fs);                              /* push fs */
            ii(0x1016_afe6, 2); pushd(gs);                              /* push gs */
            ii(0x1016_afe8, 1); push(ebp);                              /* push ebp */
            ii(0x1016_afe9, 3); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1016_afec, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_afee, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_aff0, 2); if(jz(0x1016_aff7, 5)) goto l_0x1016_aff7; /* jz 0x1016aff7 */
            ii(0x1016_aff2, 3); cmp(eax, -0x2c /* 0xd4 */);             /* cmp eax, 0xffffffd4 */
            ii(0x1016_aff5, 2); if(jbe(0x1016_affe, 7)) goto l_0x1016_affe; /* jbe 0x1016affe */
        l_0x1016_aff7:
            ii(0x1016_aff7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_aff9, 5); jmp(0x1016_b0b2, 0xb4); goto l_0x1016_b0b2; /* jmp 0x1016b0b2 */
        l_0x1016_affe:
            ii(0x1016_affe, 5); mov(ebp, 0x101b_de0c);                  /* mov ebp, 0x101bde0c */
            ii(0x1016_b003, 3); lea(edi, memd[ds, esi + 3]);            /* lea edi, [esi+0x3] */
            ii(0x1016_b006, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_b008, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_b00a, 3); mov(memb[ss, esp], ah);                 /* mov [esp], ah */
            ii(0x1016_b00d, 4); and(di, -4 /* 0xfc */);                 /* and di, 0xfffc */
        l_0x1016_b011:
            ii(0x1016_b011, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_b013, 3); cmp(edi, 0xc);                          /* cmp edi, 0xc */
            ii(0x1016_b016, 2); if(jae(0x1016_b01d, 5)) goto l_0x1016_b01d; /* jae 0x1016b01d */
            ii(0x1016_b018, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
        l_0x1016_b01d:
            ii(0x1016_b01d, 6); cmp(eax, memd[ds, 0x101b_de14]);        /* cmp eax, [0x101bde14] */
            ii(0x1016_b023, 2); if(jbe(0x1016_b03d, 0x18)) goto l_0x1016_b03d; /* jbe 0x1016b03d */
            ii(0x1016_b025, 6); mov(ecx, memd[ds, 0x101b_de10]);        /* mov ecx, [0x101bde10] */
            ii(0x1016_b02b, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_b02d, 2); if(jnz(0x1016_b075, 0x46)) goto l_0x1016_b075; /* jnz 0x1016b075 */
        l_0x1016_b02f:
            ii(0x1016_b02f, 6); mov(memd[ds, 0x101b_de14], ecx);        /* mov [0x101bde14], ecx */
            ii(0x1016_b035, 6); mov(ecx, memd[ds, 0x101b_de0c]);        /* mov ecx, [0x101bde0c] */
            ii(0x1016_b03b, 2); jmp(0x1016_b075, 0x38); goto l_0x1016_b075; /* jmp 0x1016b075 */
        l_0x1016_b03d:
            ii(0x1016_b03d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_b03f, 2); jmp(0x1016_b02f, -0x12); goto l_0x1016_b02f; /* jmp 0x1016b02f */
        l_0x1016_b041:
            ii(0x1016_b041, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1016_b043, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_b045, 6); mov(memd[ds, 0x101b_de10], ecx);        /* mov [0x101bde10], ecx */
            ii(0x1016_b04b, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
            ii(0x1016_b051, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_b053, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_b055, 5); call(/* sys */ 0x1018_6978, 0x1_b91e);  /* call 0x10186978 */
            ii(0x1016_b05a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_b05c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b05e, 2); if(jnz(0x1016_b0a8, 0x48)) goto l_0x1016_b0a8; /* jnz 0x1016b0a8 */
            ii(0x1016_b060, 6); mov(ebx, memd[ds, 0x101b_de14]);        /* mov ebx, [0x101bde14] */
            ii(0x1016_b066, 3); mov(eax, memd[ds, ecx + 0x14]);         /* mov eax, [ecx+0x14] */
            ii(0x1016_b069, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1016_b06b, 2); if(jbe(0x1016_b072, 5)) goto l_0x1016_b072; /* jbe 0x1016b072 */
            ii(0x1016_b06d, 5); mov(memd[ds, 0x101b_de14], eax);        /* mov [0x101bde14], eax */
        l_0x1016_b072:
            ii(0x1016_b072, 3); mov(ecx, memd[ds, ecx + 8]);            /* mov ecx, [ecx+0x8] */
        l_0x1016_b075:
            ii(0x1016_b075, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_b077, 2); if(jnz(0x1016_b041, -0x38)) goto l_0x1016_b041; /* jnz 0x1016b041 */
            ii(0x1016_b079, 4); cmp(memb[ss, esp], 0);                  /* cmp byte [esp], 0x0 */
            ii(0x1016_b07d, 2); if(jnz(0x1016_b08a, 0xb)) goto l_0x1016_b08a; /* jnz 0x1016b08a */
            ii(0x1016_b07f, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_b081, 5); call(/* sys */ 0x1018_6f1c, 0x1_be96);  /* call 0x10186f1c */
            ii(0x1016_b086, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b088, 2); if(jnz(0x1016_b09f, 0x15)) goto l_0x1016_b09f; /* jnz 0x1016b09f */
        l_0x1016_b08a:
            ii(0x1016_b08a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_b08c, 5); call(/* sys */ 0x1018_70e5, 0x1_c054);  /* call 0x101870e5 */
            ii(0x1016_b091, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b093, 2); if(jz(0x1016_b0a8, 0x13)) goto l_0x1016_b0a8; /* jz 0x1016b0a8 */
            ii(0x1016_b095, 2); xor(cl, cl);                            /* xor cl, cl */
            ii(0x1016_b097, 3); mov(memb[ss, esp], cl);                 /* mov [esp], cl */
            ii(0x1016_b09a, 5); jmp(0x1016_b011, -0x8e); goto l_0x1016_b011; /* jmp 0x1016b011 */
        l_0x1016_b09f:
            ii(0x1016_b09f, 4); mov(memb[ss, esp], 1);                  /* mov byte [esp], 0x1 */
            ii(0x1016_b0a3, 5); jmp(0x1016_b011, -0x97); goto l_0x1016_b011; /* jmp 0x1016b011 */
        l_0x1016_b0a8:
            ii(0x1016_b0a8, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1016_b0aa, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_b0ac, 6); mov(memb[ds, 0x1020_a2d4], ch);         /* mov [0x1020a2d4], ch */
        l_0x1016_b0b2:
            ii(0x1016_b0b2, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1016_b0b5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_b0b6, 2); popd(gs);                               /* pop gs */
            ii(0x1016_b0b8, 2); popd(fs);                               /* pop fs */
            ii(0x1016_b0ba, 1); popd(es);                               /* pop es */
            ii(0x1016_b0bb, 1); pop(edi);                               /* pop edi */
            ii(0x1016_b0bc, 1); pop(esi);                               /* pop esi */
            ii(0x1016_b0bd, 1); pop(edx);                               /* pop edx */
            ii(0x1016_b0be, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_b0bf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_b0c0, 1); ret();                                  /* ret */
        }
    }
}
