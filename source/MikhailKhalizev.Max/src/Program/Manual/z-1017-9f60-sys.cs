using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9f60-4aef5b11")]
        public void /* sys */ Method_1017_9f60()
        {
            // retd(); return;

            var chan = RawProgramMain.DosDma.dma_get_channel(5);

            ii(0x1017_9f60, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_9f61, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9f63, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_9f64, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_9f65, 1); pushd(edx);                             /* push edx */
            ii(0x1017_9f66, 1); pushd(esi);                             /* push esi */
            ii(0x1017_9f67, 1); pushd(edi);                             /* push edi */
            ii(0x1017_9f68, 6); mov(edx, memd_a32[ds, 0x1020_9dc0]);    /* mov edx, [0x10209dc0] */
            ii(0x1017_9f6e, 6); mov(ebx, memd_a32[ds, 0x101b_e41c]);    /* mov ebx, [0x101be41c] */
            ii(0x1017_9f74, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_9f76, 3); sar(edx, 0x2);                          /* sar edx, 0x2 */
            ii(0x1017_9f79, 3); cmp(ebx, -0x1 /* 0xff */);              /* cmp ebx, 0xffffffff */
            ii(0x1017_9f7c, 2); if(jzd(0x1017_9f93, 0x15)) goto l_0x1017_9f93; /* jz 0x10179f93 */
            ii(0x1017_9f7e, 1); pushd(edx);                             /* push edx */
            ii(0x1017_9f7f, 5); calld(/* sys */ 0x1018_dd02, 0x1_3d7e); /* call 0x1018dd02 */
            ii(0x1017_9f84, 6); mov(edx, memd_a32[ds, 0x1020_9dc0]);    /* mov edx, [0x10209dc0] */
            ii(0x1017_9f8a, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_9f8d, 6); add(memd_a32[ds, 0x101b_e420], edx);    /* add [0x101be420], edx */
        l_0x1017_9f93:
            ii(0x1017_9f93, 6); mov(edx, memd_a32[ds, 0x1020_9dc0]);    /* mov edx, [0x10209dc0] */
            ii(0x1017_9f99, 2); neg(edx);                               /* neg edx */
            ii(0x1017_9f9b, 2); sar(edx, 0x1);                          /* sar edx, 1 */
            ii(0x1017_9f9d, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1017_9f9f, 2); if(jled(0x1017_9fb1, 0x10)) goto l_0x1017_9fb1; /* jle 0x10179fb1 */
            ii(0x1017_9fa1, 7); cmp(memd_a32[ds, 0x101b_e428], 0);      /* cmp dword [0x101be428], 0x0 */
            ii(0x1017_9fa8, 2); if(jnzd(0x1017_9fb1, 0x7)) goto l_0x1017_9fb1; /* jnz 0x10179fb1 */
            ii(0x1017_9faa, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_9faf, 2); jmpd(0x1017_9fb3, 0x2); goto l_0x1017_9fb3; /* jmp 0x10179fb3 */
        l_0x1017_9fb1:
            ii(0x1017_9fb1, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1017_9fb3:
            ii(0x1017_9fb3, 5); mov(memd_a32[ds, 0x101b_e424], eax);    /* mov [0x101be424], eax */
            ii(0x1017_9fb8, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_9fba, 5); mov(eax, memd_a32[ds, 0x101b_e418]);    /* mov eax, [0x101be418] */
            ii(0x1017_9fbf, 6); mov(memd_a32[ds, 0x101b_e428], edi);    /* mov [0x101be428], edi */
            ii(0x1017_9fc5, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_9fc8, 6); if(jzd(0x1017_a1ad, 0x1df)) goto l_0x1017_a1ad; /* jz 0x1017a1ad */
            ii(0x1017_9fce, 7); cmp(memd_a32[ds, 0x1020_9dac], 0);      /* cmp dword [0x10209dac], 0x0 */
            ii(0x1017_9fd5, 2); if(jnzd(0x1017_9fe1, 0xa)) goto l_0x1017_9fe1; /* jnz 0x10179fe1 */
            ii(0x1017_9fd7, 5); mov(eax, memd_a32[ds, 0x1020_9a74]);    /* mov eax, [0x10209a74] */
            ii(0x1017_9fdc, 5); mov(memd_a32[ds, 0x1020_9dac], eax);    /* mov [0x10209dac], eax */
        l_0x1017_9fe1:
            ii(0x1017_9fe1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1017_9fe3:

            // Работа с аудио. Загрука данных из файла в память?

            if (chan.masked == false)
            {
                var buf = new byte[2];
                chan.read(buf);
            }

            ii(0x1017_9fe3, 6); mov(edx, memd_a32[ds, 0x101b_e434]);    /* mov edx, [0x101be434] */
            ii(0x1017_9fe9, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1017_9fec, 3); setnz(al);                              /* setnz al */
            ii(0x1017_9fef, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_9ff4, 2); if(jzd(0x1017_a021, 0x2b)) goto l_0x1017_a021; /* jz 0x1017a021 */
            ii(0x1017_9ff6, 5); mov(eax, memd_a32[ds, 0x101b_e418]);    /* mov eax, [0x101be418] */
            ii(0x1017_9ffb, 5); calld(/* sys */ 0x1017_9a00, -0x600);   /* call 0x10179a00 */
            ii(0x1017_a000, 6); mov(ecx, memd_a32[ds, 0x1020_9da4]);    /* mov ecx, [0x10209da4] */
            ii(0x1017_a006, 6); mov(esi, memd_a32[ds, 0x1020_9dac]);    /* mov esi, [0x10209dac] */
            ii(0x1017_a00c, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1017_a00e, 6); mov(edi, memd_a32[ds, 0x1020_9da0]);    /* mov edi, [0x10209da0] */
            ii(0x1017_a014, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1017_a016, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1017_a018, 2); if(jaed(0x1017_a021, 0x7)) goto l_0x1017_a021; /* jae 0x1017a021 */
            ii(0x1017_a01a, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1017_a01f, 2); jmpd(0x1017_9fe3, -0x3e); goto l_0x1017_9fe3; /* jmp 0x10179fe3 */
        l_0x1017_a021:
            ii(0x1017_a021, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_a023, 2); if(jzd(0x1017_a03e, 0x19)) goto l_0x1017_a03e; /* jz 0x1017a03e */
            ii(0x1017_a025, 5); mov(eax, memd_a32[ds, 0x1020_9dc0]);    /* mov eax, [0x10209dc0] */
            ii(0x1017_a02a, 6); mov(edx, memd_a32[ds, 0x1020_9dc0]);    /* mov edx, [0x10209dc0] */
            ii(0x1017_a030, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1017_a033, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_a035, 1); pushd(eax);                             /* push eax */
            ii(0x1017_a036, 5); calld(/* sys */ 0x1018_dc67, 0x1_3c2c); /* call 0x1018dc67 */
            ii(0x1017_a03b, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1017_a03e:
            ii(0x1017_a03e, 6); mov(edx, memd_a32[ds, 0x101b_e434]);    /* mov edx, [0x101be434] */
            ii(0x1017_a044, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1017_a047, 3); setnz(al);                              /* setnz al */
            ii(0x1017_a04a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_a04f, 2); if(jzd(0x1017_a07e, 0x2d)) goto l_0x1017_a07e; /* jz 0x1017a07e */
            ii(0x1017_a051, 5); mov(eax, memd_a32[ds, 0x101b_e418]);    /* mov eax, [0x101be418] */
            ii(0x1017_a056, 5); calld(/* sys */ 0x1017_9a00, -0x65b);   /* call 0x10179a00 */
            ii(0x1017_a05b, 6); mov(edx, memd_a32[ds, 0x1020_9da4]);    /* mov edx, [0x10209da4] */
            ii(0x1017_a061, 6); mov(ebx, memd_a32[ds, 0x1020_9dac]);    /* mov ebx, [0x10209dac] */
            ii(0x1017_a067, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_a069, 5); mov(eax, memd_a32[ds, 0x1020_9da0]);    /* mov eax, [0x10209da0] */
            ii(0x1017_a06e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_a070, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_a072, 2); if(jbed(0x1017_a07e, 0xa)) goto l_0x1017_a07e; /* jbe 0x1017a07e */
            ii(0x1017_a074, 10); mov(memd_a32[ds, 0x101b_e434], 0xffff_ffff); /* mov dword [0x101be434], 0xffffffff */
        l_0x1017_a07e:
            ii(0x1017_a07e, 7); cmp(memd_a32[ds, 0x1020_9d9c], 0);      /* cmp dword [0x10209d9c], 0x0 */
            ii(0x1017_a085, 6); if(jzd(0x1017_a16d, 0xe2)) goto l_0x1017_a16d; /* jz 0x1017a16d */
            ii(0x1017_a08b, 7); cmp(memd_a32[ds, 0x101b_e434], -0x1 /* 0xff */); /* cmp dword [0x101be434], 0xffffffff */
            ii(0x1017_a092, 6); if(jnzd(0x1017_a16d, 0xd5)) goto l_0x1017_a16d; /* jnz 0x1017a16d */
            ii(0x1017_a098, 7); cmp(memd_a32[ds, 0x1020_9d98], 0);      /* cmp dword [0x10209d98], 0x0 */
            ii(0x1017_a09f, 6); if(jzd(0x1017_a16d, 0xc8)) goto l_0x1017_a16d; /* jz 0x1017a16d */
            ii(0x1017_a0a5, 5); mov(eax, memd_a32[ds, 0x1020_9da4]);    /* mov eax, [0x10209da4] */
            ii(0x1017_a0aa, 6); mov(edx, memd_a32[ds, 0x1020_9da8]);    /* mov edx, [0x10209da8] */
            ii(0x1017_a0b0, 6); mov(ebx, memd_a32[ds, 0x1020_9da0]);    /* mov ebx, [0x10209da0] */
            ii(0x1017_a0b6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_a0b8, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1017_a0ba, 6); if(jad(0x1017_a16d, 0xad)) goto l_0x1017_a16d; /* ja 0x1017a16d */
            ii(0x1017_a0c0, 5); mov(eax, memd_a32[ds, 0x1020_9d1c]);    /* mov eax, [0x10209d1c] */
            ii(0x1017_a0c5, 7); mov(eax, memd_a32[ds, eax * 8 + 0x1020_9a70]); /* mov eax, [eax*8+0x10209a70] */
            ii(0x1017_a0cc, 6); mov(memw_a32[ds, 0x1020_9d28], ds);     /* mov [0x10209d28], ds */
            ii(0x1017_a0d2, 5); mov(memd_a32[ds, 0x1020_9d24], eax);    /* mov [0x10209d24], eax */
            ii(0x1017_a0d7, 5); mov(eax, memd_a32[ds, 0x1020_9d1c]);    /* mov eax, [0x10209d1c] */
            ii(0x1017_a0dc, 7); mov(eax, memd_a32[ds, eax * 8 + 0x1020_9a74]); /* mov eax, [eax*8+0x10209a74] */
            ii(0x1017_a0e3, 5); mov(memd_a32[ds, 0x1020_9d2c], eax);    /* mov [0x10209d2c], eax */
            ii(0x1017_a0e8, 6); mov(edx, memd_a32[ds, 0x1020_9da8]);    /* mov edx, [0x10209da8] */
            ii(0x1017_a0ee, 6); add(memd_a32[ds, 0x1020_9da4], edx);    /* add [0x10209da4], edx */
            ii(0x1017_a0f4, 5); mov(memd_a32[ds, 0x1020_9da8], eax);    /* mov [0x10209da8], eax */
            ii(0x1017_a0f9, 7); cmp(memd_a32[ds, 0x1020_9d1c], 0x3b);   /* cmp dword [0x10209d1c], 0x3b */
            ii(0x1017_a100, 2); if(jnzd(0x1017_a10b, 0x9)) goto l_0x1017_a10b; /* jnz 0x1017a10b */
            ii(0x1017_a102, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_a104, 5); mov(memd_a32[ds, 0x1020_9d1c], eax);    /* mov [0x10209d1c], eax */
            ii(0x1017_a109, 2); jmpd(0x1017_a111, 0x6); goto l_0x1017_a111; /* jmp 0x1017a111 */
        l_0x1017_a10b:
            ii(0x1017_a10b, 6); inc(memd_a32[ds, 0x1020_9d1c]);         /* inc dword [0x10209d1c] */
        l_0x1017_a111:
            ii(0x1017_a111, 6); dec(memd_a32[ds, 0x1020_9d98]);         /* dec dword [0x10209d98] */
            ii(0x1017_a117, 5); mov(eax, memd_a32[ds, 0x101b_e418]);    /* mov eax, [0x101be418] */
            ii(0x1017_a11c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_a11e, 2); mov(ecx, ds);                           /* mov ecx, ds */
            ii(0x1017_a120, 6); mov(memd_a32[ds, 0x1020_9d9c], ebx);    /* mov [0x10209d9c], ebx */
            ii(0x1017_a126, 5); mov(ebx, 0x1020_9d24);                  /* mov ebx, 0x10209d24 */
            ii(0x1017_a12b, 5); calld(/* sys */ 0x1017_fd5d, 0x5c2d);   /* call 0x1017fd5d */
            ii(0x1017_a130, 5); mov(memd_a32[ds, 0x101b_e434], eax);    /* mov [0x101be434], eax */
        l_0x1017_a135:

            if (chan.masked == false)
            {
                var buf = new byte[2];
                chan.read(buf);
            //        if (chan.currcnt == 0xffff)
            //            pic.activate_irq(7);
            }

            ii(0x1017_a135, 6); mov(edx, memd_a32[ds, 0x101b_e434]);    /* mov edx, [0x101be434] */
            ii(0x1017_a13b, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1017_a13e, 3); setnz(al);                              /* setnz al */
            ii(0x1017_a141, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_a146, 2); if(jzd(0x1017_a15e, 0x16)) goto l_0x1017_a15e; /* jz 0x1017a15e */
            ii(0x1017_a148, 5); mov(eax, memd_a32[ds, 0x101b_e418]);    /* mov eax, [0x101be418] */
            ii(0x1017_a14d, 5); calld(/* sys */ 0x1017_9a00, -0x752);   /* call 0x10179a00 */
            ii(0x1017_a152, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_a154, 3); setz(al);                               /* setz al */
            ii(0x1017_a157, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_a15c, 2); if(jnzd(0x1017_a135, -0x29)) goto l_0x1017_a135; /* jnz 0x1017a135 */
        l_0x1017_a15e:
            ii(0x1017_a15e, 6); mov(ecx, memd_a32[ds, 0x1020_9dc0]);    /* mov ecx, [0x10209dc0] */
            ii(0x1017_a164, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_a165, 5); calld(/* sys */ 0x1018_dc67, 0x1_3afd); /* call 0x1018dc67 */
            ii(0x1017_a16a, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1017_a16d:
            ii(0x1017_a16d, 5); mov(eax, memd_a32[ds, 0x1020_9d14]);    /* mov eax, [0x10209d14] */
            ii(0x1017_a172, 6); cmp(eax, memd_a32[ds, 0x1020_9d10]);    /* cmp eax, [0x10209d10] */
            ii(0x1017_a178, 2); if(jzd(0x1017_a1ad, 0x33)) goto l_0x1017_a1ad; /* jz 0x1017a1ad */
            ii(0x1017_a17a, 5); mov(eax, memd_a32[ds, 0x1020_9d14]);    /* mov eax, [0x10209d14] */
            ii(0x1017_a17f, 6); mov(edi, memd_a32[ds, 0x1020_9da0]);    /* mov edi, [0x10209da0] */
            ii(0x1017_a185, 7); mov(eax, memd_a32[ds, eax * 8 + 0x1020_9a74]); /* mov eax, [eax*8+0x10209a74] */
            ii(0x1017_a18c, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1017_a18e, 6); mov(memd_a32[ds, 0x1020_9da0], edi);    /* mov [0x10209da0], edi */
            ii(0x1017_a194, 7); cmp(memd_a32[ds, 0x1020_9d14], 0x3b);   /* cmp dword [0x10209d14], 0x3b */
            ii(0x1017_a19b, 2); if(jnzd(0x1017_a1a7, 0xa)) goto l_0x1017_a1a7; /* jnz 0x1017a1a7 */
            ii(0x1017_a19d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_a19f, 6); mov(memd_a32[ds, 0x1020_9d14], ebx);    /* mov [0x10209d14], ebx */
            ii(0x1017_a1a5, 2); jmpd(0x1017_a1ad, 0x6); goto l_0x1017_a1ad; /* jmp 0x1017a1ad */
        l_0x1017_a1a7:
            ii(0x1017_a1a7, 6); inc(memd_a32[ds, 0x1020_9d14]);         /* inc dword [0x10209d14] */
        l_0x1017_a1ad:
            ii(0x1017_a1ad, 3); lea(esp, ebp - 0x14);                   /* lea esp, [ebp-0x14] */
            ii(0x1017_a1b0, 1); popd(edi);                              /* pop edi */
            ii(0x1017_a1b1, 1); popd(esi);                              /* pop esi */
            ii(0x1017_a1b2, 1); popd(edx);                              /* pop edx */
            ii(0x1017_a1b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_a1b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_a1b5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_a1b6, 1); retd(); return;                         /* ret */
        }
    }
}
