using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6764-39de66ed")]
        public void /* sys */ Method_1016_6764()
        {
            ii(0x1016_6764, 1); pushd(esi);                             /* push esi */
            ii(0x1016_6765, 1); pushd(edi);                             /* push edi */
            ii(0x1016_6766, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_6767, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_676a, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1016_676e, 3); mov(memd_a32[ss, esp], edx);            /* mov [esp], edx */
            ii(0x1016_6771, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1016_6773, 4); mov(ebx, memd_a32[ss, esp + 0x18]);     /* mov ebx, [esp+0x18] */
            ii(0x1016_6777, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_677e, 2); if(jzd(0x1016_67c6, 0x46)) goto l_0x1016_67c6; /* jz 0x101667c6 */
            ii(0x1016_6780, 7); cmp(memd_a32[ds, 0x101c_b2d8], 0x32);   /* cmp dword [0x101cb2d8], 0x32 */
            ii(0x1016_6787, 2); if(jzd(0x1016_67c6, 0x3d)) goto l_0x1016_67c6; /* jz 0x101667c6 */
            ii(0x1016_6789, 5); mov(eax, memd_a32[ds, 0x1020_88e8]);    /* mov eax, [0x102088e8] */
            ii(0x1016_678e, 6); sub(eax, memd_a32[ds, 0x1020_88e0]);    /* sub eax, [0x102088e0] */
            ii(0x1016_6794, 1); inc(eax);                               /* inc eax */
            ii(0x1016_6795, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_6797, 2); if(jgd(0x1016_67c6, 0x2d)) goto l_0x1016_67c6; /* jg 0x101667c6 */
            ii(0x1016_6799, 5); mov(eax, memd_a32[ds, 0x1020_88ec]);    /* mov eax, [0x102088ec] */
            ii(0x1016_679e, 6); sub(eax, memd_a32[ds, 0x1020_88e4]);    /* sub eax, [0x102088e4] */
            ii(0x1016_67a4, 1); inc(eax);                               /* inc eax */
            ii(0x1016_67a5, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1016_67a7, 2); if(jgd(0x1016_67c6, 0x1d)) goto l_0x1016_67c6; /* jg 0x101667c6 */
            ii(0x1016_67a9, 5); mov(eax, 0x44);                         /* mov eax, 0x44 */
            ii(0x1016_67ae, 5); calld(Definitions.sys_malloc_internal, 0x1_bb3d); /* call 0x101822f0 */
            ii(0x1016_67b3, 6); mov(esi, memd_a32[ds, 0x101c_b2d8]);    /* mov esi, [0x101cb2d8] */
            ii(0x1016_67b9, 7); mov(memd_a32[ds, esi * 4 + 0x101c_b1fc], eax); /* mov [esi*4+0x101cb1fc], eax */
            ii(0x1016_67c0, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_67c2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_67c4, 2); if(jnzd(0x1016_67d0, 0xa)) goto l_0x1016_67d0; /* jnz 0x101667d0 */
        l_0x1016_67c6:
            ii(0x1016_67c6, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1016_67cb, 5); jmpd(0x1016_6983, 0x1b3); goto l_0x1016_6983; /* jmp 0x10166983 */
        l_0x1016_67d0:
            ii(0x1016_67d0, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_67d2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_67d4, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x1016_67d7, 5); calld(Definitions.sys_malloc_internal, 0x1_bb14); /* call 0x101822f0 */
            ii(0x1016_67dc, 3); mov(memd_a32[ds, esi + 0x2c], eax);     /* mov [esi+0x2c], eax */
            ii(0x1016_67df, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_67e1, 2); if(jnzd(0x1016_67fa, 0x17)) goto l_0x1016_67fa; /* jnz 0x101667fa */
            ii(0x1016_67e3, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_67e5, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1016_67ea, 5); calld(Definitions.sys_free_internal, 0x1_bc65); /* call 0x10182454 */
            ii(0x1016_67ef, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_67f1, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_67f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_67f5, 1); popd(edi);                              /* pop edi */
            ii(0x1016_67f6, 1); popd(esi);                              /* pop esi */
            ii(0x1016_67f7, 3); retd(0x8); return;                      /* ret 0x8 */
        l_0x1016_67fa:
            ii(0x1016_67fa, 5); mov(esi, 0x1);                          /* mov esi, 0x1 */
            ii(0x1016_67ff, 2); jmpd(0x1016_6802, 0x1); goto l_0x1016_6802; /* jmp 0x10166802 */
        l_0x1016_6801:
            ii(0x1016_6801, 1); inc(esi);                               /* inc esi */
        l_0x1016_6802:
            ii(0x1016_6802, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_6804, 5); calld(/* sys */ 0x1016_7dac, 0x15a3);   /* call 0x10167dac */
            ii(0x1016_6809, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_680b, 2); if(jnzd(0x1016_6801, -0xc)) goto l_0x1016_6801; /* jnz 0x10166801 */
            ii(0x1016_680d, 4); mov(ah, memb_a32[ss, esp + 0x1c]);      /* mov ah, [esp+0x1c] */
            ii(0x1016_6811, 2); mov(memd_a32[ds, edi], esi);            /* mov [edi], esi */
            ii(0x1016_6813, 3); test(ah, 0x1);                          /* test ah, 0x1 */
            ii(0x1016_6816, 2); if(jzd(0x1016_6827, 0xf)) goto l_0x1016_6827; /* jz 0x10166827 */
            ii(0x1016_6818, 4); mov(ebp, memd_a32[ss, esp + 0x1c]);     /* mov ebp, [esp+0x1c] */
            ii(0x1016_681c, 5); mov(eax, memd_a32[ds, 0x101c_b2dc]);    /* mov eax, [0x101cb2dc] */
            ii(0x1016_6821, 2); or(ebp, eax);                           /* or ebp, eax */
            ii(0x1016_6823, 4); mov(memd_a32[ss, esp + 0x1c], ebp);     /* mov [esp+0x1c], ebp */
        l_0x1016_6827:
            ii(0x1016_6827, 3); mov(memd_a32[ds, edi + 0x18], edx);     /* mov [edi+0x18], edx */
            ii(0x1016_682a, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_682e, 3); mov(memd_a32[ds, edi + 0x1c], ecx);     /* mov [edi+0x1c], ecx */
            ii(0x1016_6831, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1016_6834, 5); calld(/* sys */ 0x1016_5e9b, -0x99e);   /* call 0x10165e9b */
            ii(0x1016_6839, 5); and(eax, 0xfffe);                       /* and eax, 0xfffe */
            ii(0x1016_683e, 3); mov(memd_a32[ds, edi + 0x24], eax);     /* mov [edi+0x24], eax */
            ii(0x1016_6841, 5); calld(/* sys */ 0x1016_5e9b, -0x9ab);   /* call 0x10165e9b */
            ii(0x1016_6846, 5); and(eax, 0xfffe);                       /* and eax, 0xfffe */
            ii(0x1016_684b, 3); mov(memd_a32[ds, edi + 0x28], eax);     /* mov [edi+0x28], eax */
            ii(0x1016_684e, 6); cmp(ebx, 0x100);                        /* cmp ebx, 0x100 */
            ii(0x1016_6854, 2); if(jzd(0x1016_687b, 0x25)) goto l_0x1016_687b; /* jz 0x1016687b */
            ii(0x1016_6856, 3); test(bh, 0xff);                         /* test bh, 0xff */
            ii(0x1016_6859, 2); if(jzd(0x1016_6896, 0x3b)) goto l_0x1016_6896; /* jz 0x10166896 */
            ii(0x1016_685b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_685d, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1016_6862, 7); mov(eax, memd_a32[ds, eax * 4 + 0x101b_d9bc]); /* mov eax, [eax*4+0x101bd9bc] */
            ii(0x1016_6869, 6); mov(al, memb_a32[ds, eax + 0x1020_0520]); /* mov al, [eax+0x10200520] */
            ii(0x1016_686f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6874, 3); xor(bx, bx);                            /* xor bx, bx */
            ii(0x1016_6877, 2); or(ebx, eax);                           /* or ebx, eax */
            ii(0x1016_6879, 2); jmpd(0x1016_6896, 0x1b); goto l_0x1016_6896; /* jmp 0x10166896 */
        l_0x1016_687b:
            ii(0x1016_687b, 7); cmp(memd_a32[ds, 0x101c_b2e0], 0);      /* cmp dword [0x101cb2e0], 0x0 */
            ii(0x1016_6882, 2); if(jnzd(0x1016_6896, 0x12)) goto l_0x1016_6896; /* jnz 0x10166896 */
            ii(0x1016_6884, 6); mov(ebx, memd_a32[ds, 0x101b_ddc0]);    /* mov ebx, [0x101bddc0] */
            ii(0x1016_688a, 6); mov(bl, memb_a32[ds, ebx + 0x1020_0520]); /* mov bl, [ebx+0x10200520] */
            ii(0x1016_6890, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
        l_0x1016_6896:
            ii(0x1016_6896, 7); mov(memd_a32[ds, edi + 0x30], 0);       /* mov dword [edi+0x30], 0x0 */
            ii(0x1016_689d, 7); mov(memd_a32[ds, edi + 0x34], 0);       /* mov dword [edi+0x34], 0x0 */
            ii(0x1016_68a4, 7); mov(memd_a32[ds, edi + 0x38], 0);       /* mov dword [edi+0x38], 0x0 */
            ii(0x1016_68ab, 7); mov(memd_a32[ds, edi + 0x3c], 0);       /* mov dword [edi+0x3c], 0x0 */
            ii(0x1016_68b2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_68b3, 7); mov(memd_a32[ds, edi + 0x40], /* sys */ 0x1017_1e10); /* mov dword [edi+0x40], 0x10171e10 */
            ii(0x1016_68ba, 5); mov(eax, memd_a32[ds, 0x101c_b2d8]);    /* mov eax, [0x101cb2d8] */
            ii(0x1016_68bf, 3); mov(memd_a32[ds, edi + 0x20], ebx);     /* mov [edi+0x20], ebx */
            ii(0x1016_68c2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_68c3, 7); mov(memd_a32[ds, esi * 4 + 0x101c_b134], eax); /* mov [esi*4+0x101cb134], eax */
            ii(0x1016_68ca, 3); lea(ebx, eax + 0x1);                    /* lea ebx, [eax+0x1] */
            ii(0x1016_68cd, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_68cf, 6); mov(memd_a32[ds, 0x101c_b2d8], ebx);    /* mov [0x101cb2d8], ebx */
            ii(0x1016_68d5, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_68d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_68d9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_68db, 5); calld(/* sys */ 0x1016_71f0, 0x910);    /* call 0x101671f0 */
            ii(0x1016_68e0, 3); mov(dl, memb_a32[ds, edi + 0x4]);       /* mov dl, [edi+0x4] */
            ii(0x1016_68e3, 3); mov(ebx, memd_a32[ss, esp]);            /* mov ebx, [esp] */
            ii(0x1016_68e6, 3); or(dl, 0x8);                            /* or dl, 0x8 */
            ii(0x1016_68e9, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_68eb, 3); mov(memb_a32[ds, edi + 0x4], dl);       /* mov [edi+0x4], dl */
            ii(0x1016_68ee, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1016_68f2, 5); calld(/* sys */ 0x1016_73c8, 0xad1);    /* call 0x101673c8 */
            ii(0x1016_68f7, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_68fb, 4); mov(dh, memb_a32[ss, esp + 0x1c]);      /* mov dh, [esp+0x1c] */
            ii(0x1016_68ff, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1016_6902, 3); test(dh, 0x4);                          /* test dh, 0x4 */
            ii(0x1016_6905, 6); if(jnzd(0x1016_6981, 0x76)) goto l_0x1016_6981; /* jnz 0x10166981 */
            ii(0x1016_690b, 6); mov(ebx, memd_a32[ds, 0x101c_b2d8]);    /* mov ebx, [0x101cb2d8] */
            ii(0x1016_6911, 3); sub(ebx, 0x2);                          /* sub ebx, 0x2 */
            ii(0x1016_6914, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_6916, 2); if(jgd(0x1016_6924, 0xc)) goto l_0x1016_6924; /* jg 0x10166924 */
            ii(0x1016_6918, 2); jmpd(0x1016_6937, 0x1d); goto l_0x1016_6937; /* jmp 0x10166937 */
        l_0x1016_691a:
            ii(0x1016_691a, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1016_691d, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_691e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_6920, 2); if(jgd(0x1016_692b, 0x9)) goto l_0x1016_692b; /* jg 0x1016692b */
            ii(0x1016_6922, 2); jmpd(0x1016_6937, 0x13); goto l_0x1016_6937; /* jmp 0x10166937 */
        l_0x1016_6924:
            ii(0x1016_6924, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
        l_0x1016_692b:
            ii(0x1016_692b, 6); mov(edx, memd_a32[ds, eax + 0x101c_b1fc]); /* mov edx, [eax+0x101cb1fc] */
            ii(0x1016_6931, 4); test(memb_a32[ds, edx + 0x4], 0x4);     /* test byte [edx+0x4], 0x4 */
            ii(0x1016_6935, 2); if(jnzd(0x1016_691a, -0x1d)) goto l_0x1016_691a; /* jnz 0x1016691a */
        l_0x1016_6937:
            ii(0x1016_6937, 5); mov(eax, memd_a32[ds, 0x101c_b2d8]);    /* mov eax, [0x101cb2d8] */
            ii(0x1016_693c, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1016_693f, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1016_6941, 2); if(jzd(0x1016_6981, 0x3e)) goto l_0x1016_6981; /* jz 0x10166981 */
            ii(0x1016_6943, 6); mov(edx, memd_a32[ds, 0x101c_b2d8]);    /* mov edx, [0x101cb2d8] */
            ii(0x1016_6949, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_694a, 1); dec(edx);                               /* dec edx */
            ii(0x1016_694b, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1016_694d, 2); if(jled(0x1016_6973, 0x24)) goto l_0x1016_6973; /* jle 0x10166973 */
            ii(0x1016_694f, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
        l_0x1016_6956:
            ii(0x1016_6956, 6); mov(ecx, memd_a32[ds, eax + 0x101c_b1f8]); /* mov ecx, [eax+0x101cb1f8] */
            ii(0x1016_695c, 6); mov(memd_a32[ds, eax + 0x101c_b1fc], ecx); /* mov [eax+0x101cb1fc], ecx */
            ii(0x1016_6962, 2); mov(ecx, memd_a32[ds, ecx]);            /* mov ecx, [ecx] */
            ii(0x1016_6964, 7); mov(memd_a32[ds, ecx * 4 + 0x101c_b134], edx); /* mov [ecx*4+0x101cb134], edx */
            ii(0x1016_696b, 1); dec(edx);                               /* dec edx */
            ii(0x1016_696c, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1016_696f, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1016_6971, 2); if(jgd(0x1016_6956, -0x1d)) goto l_0x1016_6956; /* jg 0x10166956 */
        l_0x1016_6973:
            ii(0x1016_6973, 7); mov(memd_a32[ds, ebx * 4 + 0x101c_b1fc], edi); /* mov [ebx*4+0x101cb1fc], edi */
            ii(0x1016_697a, 7); mov(memd_a32[ds, esi * 4 + 0x101c_b134], ebx); /* mov [esi*4+0x101cb134], ebx */
        l_0x1016_6981:
            ii(0x1016_6981, 2); mov(ebx, esi);                          /* mov ebx, esi */
        l_0x1016_6983:
            ii(0x1016_6983, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_6985, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_6988, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_6989, 1); popd(edi);                              /* pop edi */
            ii(0x1016_698a, 1); popd(esi);                              /* pop esi */
            ii(0x1016_698b, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}
