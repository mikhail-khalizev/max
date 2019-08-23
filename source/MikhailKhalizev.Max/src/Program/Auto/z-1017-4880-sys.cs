using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_4880-c9a2fe7e")]
        public void /* sys */ Method_1017_4880()
        {
            ii(0x1017_4880, 1); push(ebx);                              /* push ebx */
            ii(0x1017_4881, 1); push(ecx);                              /* push ecx */
            ii(0x1017_4882, 1); push(edx);                              /* push edx */
            ii(0x1017_4883, 1); push(esi);                              /* push esi */
            ii(0x1017_4884, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_4887, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1017_4889, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_488b, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_4890, 5); call(/* sys */ 0x1017_8f18, 0x4683);    /* call 0x10178f18 */
            ii(0x1017_4895, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_4897, 6); if(jnz(0x1017_49c0, 0x123)) goto l_0x1017_49c0; /* jnz 0x101749c0 */
            ii(0x1017_489d, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1017_48a0, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1017_48a2, 3); cmp(dl, 0x52);                          /* cmp dl, 0x52 */
            ii(0x1017_48a5, 2); if(jz(0x1017_48d9, 0x32)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48a7, 3); cmp(dl, 0x4f);                          /* cmp dl, 0x4f */
            ii(0x1017_48aa, 2); if(jz(0x1017_48d9, 0x2d)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48ac, 3); cmp(dl, 0x50);                          /* cmp dl, 0x50 */
            ii(0x1017_48af, 2); if(jz(0x1017_48d9, 0x28)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48b1, 3); cmp(dl, 0x51);                          /* cmp dl, 0x51 */
            ii(0x1017_48b4, 2); if(jz(0x1017_48d9, 0x23)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48b6, 3); cmp(dl, 0x4b);                          /* cmp dl, 0x4b */
            ii(0x1017_48b9, 2); if(jz(0x1017_48d9, 0x1e)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48bb, 3); cmp(dl, 0x4c);                          /* cmp dl, 0x4c */
            ii(0x1017_48be, 2); if(jz(0x1017_48d9, 0x19)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48c0, 3); cmp(dl, 0x4d);                          /* cmp dl, 0x4d */
            ii(0x1017_48c3, 2); if(jz(0x1017_48d9, 0x14)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48c5, 3); cmp(dl, 0x47);                          /* cmp dl, 0x47 */
            ii(0x1017_48c8, 2); if(jz(0x1017_48d9, 0xf)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48ca, 3); cmp(dl, 0x48);                          /* cmp dl, 0x48 */
            ii(0x1017_48cd, 2); if(jz(0x1017_48d9, 0xa)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48cf, 3); cmp(dl, 0x49);                          /* cmp dl, 0x49 */
            ii(0x1017_48d2, 2); if(jz(0x1017_48d9, 0x5)) goto l_0x1017_48d9; /* jz 0x101748d9 */
            ii(0x1017_48d4, 3); cmp(dl, 0x53);                          /* cmp dl, 0x53 */
            ii(0x1017_48d7, 2); if(jnz(0x1017_48fe, 0x25)) goto l_0x1017_48fe; /* jnz 0x101748fe */
        l_0x1017_48d9:
            ii(0x1017_48d9, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1017_48dc, 3); mov(ch, memb[ds, eax + 0x2]);           /* mov ch, [eax+0x2] */
            ii(0x1017_48df, 3); test(ch, 0x60);                         /* test ch, 0x60 */
            ii(0x1017_48e2, 2); if(jnz(0x1017_48fe, 0x1a)) goto l_0x1017_48fe; /* jnz 0x101748fe */
            ii(0x1017_48e4, 3); test(ch, 0x2);                          /* test ch, 0x2 */
            ii(0x1017_48e7, 2); if(jz(0x1017_48fe, 0x15)) goto l_0x1017_48fe; /* jz 0x101748fe */
            ii(0x1017_48e9, 3); test(ch, 0x18);                         /* test ch, 0x18 */
            ii(0x1017_48ec, 2); if(jnz(0x1017_48f6, 0x8)) goto l_0x1017_48f6; /* jnz 0x101748f6 */
            ii(0x1017_48ee, 3); or(ch, 0x8);                            /* or ch, 0x8 */
            ii(0x1017_48f1, 3); mov(memb[ds, eax + 0x2], ch);           /* mov [eax+0x2], ch */
            ii(0x1017_48f4, 2); jmp(0x1017_48fe, 0x8); goto l_0x1017_48fe; /* jmp 0x101748fe */
        l_0x1017_48f6:
            ii(0x1017_48f6, 2); mov(cl, ch);                            /* mov cl, ch */
            ii(0x1017_48f8, 3); and(cl, 0xe7);                          /* and cl, 0xe7 */
            ii(0x1017_48fb, 3); mov(memb[ds, eax + 0x2], cl);           /* mov [eax+0x2], cl */
        l_0x1017_48fe:
            ii(0x1017_48fe, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1017_4901, 6); test(memw[ds, eax + 0x2], 0x180);       /* test word [eax+0x2], 0x180 */
            ii(0x1017_4907, 2); if(jz(0x1017_4925, 0x1c)) goto l_0x1017_4925; /* jz 0x10174925 */
            ii(0x1017_4909, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1017_490b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_4910, 7); lea(ebx, eax * 4 + 0);                  /* lea ebx, [eax*4] */
            ii(0x1017_4917, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1017_4919, 7); mov(ebx, memd[ds, ebx * 2 + 0x1020_8a46]); /* mov ebx, [ebx*2+0x10208a46] */
            ii(0x1017_4920, 5); jmp(0x1017_4999, 0x74); goto l_0x1017_4999; /* jmp 0x10174999 */
        l_0x1017_4925:
            ii(0x1017_4925, 3); mov(dl, memb[ds, eax + 0x2]);           /* mov dl, [eax+0x2] */
            ii(0x1017_4928, 3); test(dl, 0x20);                         /* test dl, 0x20 */
            ii(0x1017_492b, 2); if(jz(0x1017_4946, 0x19)) goto l_0x1017_4946; /* jz 0x10174946 */
            ii(0x1017_492d, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1017_492f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_4934, 7); lea(ebx, eax * 4 + 0);                  /* lea ebx, [eax*4] */
            ii(0x1017_493b, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1017_493d, 7); mov(ebx, memd[ds, ebx * 2 + 0x1020_8a42]); /* mov ebx, [ebx*2+0x10208a42] */
            ii(0x1017_4944, 2); jmp(0x1017_4999, 0x53); goto l_0x1017_4999; /* jmp 0x10174999 */
        l_0x1017_4946:
            ii(0x1017_4946, 3); test(dl, 0x40);                         /* test dl, 0x40 */
            ii(0x1017_4949, 2); if(jz(0x1017_4964, 0x19)) goto l_0x1017_4964; /* jz 0x10174964 */
            ii(0x1017_494b, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1017_494d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_4952, 7); lea(ebx, eax * 4 + 0);                  /* lea ebx, [eax*4] */
            ii(0x1017_4959, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1017_495b, 7); mov(ebx, memd[ds, ebx * 2 + 0x1020_8a44]); /* mov ebx, [ebx*2+0x10208a44] */
            ii(0x1017_4962, 2); jmp(0x1017_4999, 0x35); goto l_0x1017_4999; /* jmp 0x10174999 */
        l_0x1017_4964:
            ii(0x1017_4964, 3); test(dl, 0x18);                         /* test dl, 0x18 */
            ii(0x1017_4967, 2); if(jz(0x1017_4982, 0x19)) goto l_0x1017_4982; /* jz 0x10174982 */
            ii(0x1017_4969, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1017_496b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_4970, 7); lea(ebx, eax * 4 + 0);                  /* lea ebx, [eax*4] */
            ii(0x1017_4977, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1017_4979, 7); mov(ebx, memd[ds, ebx * 2 + 0x1020_8a40]); /* mov ebx, [ebx*2+0x10208a40] */
            ii(0x1017_4980, 2); jmp(0x1017_4999, 0x17); goto l_0x1017_4999; /* jmp 0x10174999 */
        l_0x1017_4982:
            ii(0x1017_4982, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1017_4984, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_4989, 7); lea(ebx, eax * 4 + 0);                  /* lea ebx, [eax*4] */
            ii(0x1017_4990, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1017_4992, 7); mov(ebx, memd[ds, ebx * 2 + 0x1020_8a3e]); /* mov ebx, [ebx*2+0x10208a3e] */
        l_0x1017_4999:
            ii(0x1017_4999, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1017_499c, 1); cli();                                  /* cli */
            ii(0x1017_499d, 5); mov(eax, memd[ds, 0x101b_e1ec]);        /* mov eax, [0x101be1ec] */
            ii(0x1017_49a2, 6); cmp(eax, memd[ds, 0x101b_e1e8]);        /* cmp eax, [0x101be1e8] */
            ii(0x1017_49a8, 2); if(jz(0x1017_49be, 0x14)) goto l_0x1017_49be; /* jz 0x101749be */
            ii(0x1017_49aa, 3); lea(ecx, eax + 0x1);                    /* lea ecx, [eax+0x1] */
            ii(0x1017_49ad, 2); mov(esi, ecx);                          /* mov esi, ecx */
            ii(0x1017_49af, 6); mov(memd[ds, 0x101b_e1ec], ecx);        /* mov [0x101be1ec], ecx */
            ii(0x1017_49b5, 3); and(esi, 0x3f);                         /* and esi, 0x3f */
            ii(0x1017_49b8, 6); mov(memd[ds, 0x101b_e1ec], esi);        /* mov [0x101be1ec], esi */
        l_0x1017_49be:
            ii(0x1017_49be, 1); sti();                                  /* sti */
            ii(0x1017_49bf, 1); cld();                                  /* cld */
        l_0x1017_49c0:
            ii(0x1017_49c0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_49c2, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_49c5, 1); pop(esi);                               /* pop esi */
            ii(0x1017_49c6, 1); pop(edx);                               /* pop edx */
            ii(0x1017_49c7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_49c8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_49c9, 1); ret();                                  /* ret */
        }
    }
}
