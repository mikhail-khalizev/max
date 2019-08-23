using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_3794-e0ca7748")]
        public void Method_1015_3794()
        {
            ii(0x1015_3794, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1015_3799, 5); calld(Definitions.sys_check_available_stack_size, 0x1_25b4); /* call 0x10165d52 */
            ii(0x1015_379e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_379f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_37a0, 1); pushd(edx);                             /* push edx */
            ii(0x1015_37a1, 1); pushd(esi);                             /* push esi */
            ii(0x1015_37a2, 1); pushd(edi);                             /* push edi */
            ii(0x1015_37a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_37a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_37a6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_37ac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_37af, 5); mov(eax, StringDefinitions.PositioningInTape); /* mov eax, 0x101adf33 */
            ii(0x1015_37b4, 5); calld(0x100a_8b4a, -0xa_ac6f);          /* call 0x100a8b4a */
            ii(0x1015_37b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_37bc, 4); cmp(memb_a32[ds, eax + 0x3e], 0x22);    /* cmp byte [eax+0x3e], 0x22 */
            ii(0x1015_37c0, 2); if(jnzd(0x1015_37d2, 0x10)) goto l_0x1015_37d2; /* jnz 0x101537d2 */
            ii(0x1015_37c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_37c5, 4); mov(memb_a32[ds, eax + 0x5e], 0);       /* mov byte [eax+0x5e], 0x0 */
            ii(0x1015_37c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_37cc, 4); mov(memb_a32[ds, eax + 0x3e], 0x23);    /* mov byte [eax+0x3e], 0x23 */
            ii(0x1015_37d0, 2); jmpd(0x1015_37e9, 0x17); goto l_0x1015_37e9; /* jmp 0x101537e9 */
        l_0x1015_37d2:
            ii(0x1015_37d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_37d5, 4); cmp(memb_a32[ds, eax + 0x3e], 0x24);    /* cmp byte [eax+0x3e], 0x24 */
            ii(0x1015_37d9, 2); if(jnzd(0x1015_37e9, 0xe)) goto l_0x1015_37e9; /* jnz 0x101537e9 */
            ii(0x1015_37db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_37de, 4); mov(memb_a32[ds, eax + 0x5e], 0);       /* mov byte [eax+0x5e], 0x0 */
            ii(0x1015_37e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_37e5, 4); mov(memb_a32[ds, eax + 0x3e], 0x25);    /* mov byte [eax+0x3e], 0x25 */
        l_0x1015_37e9:
            ii(0x1015_37e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_37ec, 5); calld(0x1014_9fa8, -0x9849);            /* call 0x10149fa8 */
            ii(0x1015_37f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_37f4, 3); mov(al, memb_a32[ds, eax + 0x5e]);      /* mov al, [eax+0x5e] */
            ii(0x1015_37f7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_37fc, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1015_37ff, 2); if(jged(0x1015_386e, 0x6d)) goto l_0x1015_386e; /* jge 0x1015386e */
            ii(0x1015_3801, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3804, 5); calld(0x1015_3635, -0x1d4);             /* call 0x10153635 */
            ii(0x1015_3809, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_380c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_380f, 3); mov(al, memb_a32[ds, eax + 0x5e]);      /* mov al, [eax+0x5e] */
            ii(0x1015_3812, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_3817, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_3819, 2); if(jnzd(0x1015_382f, 0x14)) goto l_0x1015_382f; /* jnz 0x1015382f */
            ii(0x1015_381b, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1015_381f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3822, 5); calld(0x1011_7fb8, -0x3_b86f);          /* call 0x10117fb8 */
            ii(0x1015_3827, 2); test(al, al);                           /* test al, al */
            ii(0x1015_3829, 6); if(jnzd(0x1015_398e, 0x15f)) goto l_0x1015_398e; /* jnz 0x1015398e */
        l_0x1015_382f:
            ii(0x1015_382f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3832, 3); inc(memb_a32[ds, eax + 0x5e]);          /* inc byte [eax+0x5e] */
            ii(0x1015_3835, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_3839, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d91c]); /* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1015_3841, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1015_3844, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_3847, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_384b, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d914]); /* movsx ax, byte [eax+0x101bd914] */
            ii(0x1015_3853, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1015_3856, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_3859, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_385c, 5); calld(0x1014_9c2f, -0x9c32);            /* call 0x10149c2f */
            ii(0x1015_3861, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3864, 5); calld(0x1014_9fa8, -0x98c1);            /* call 0x10149fa8 */
            ii(0x1015_3869, 5); jmpd(0x1015_398e, 0x120); goto l_0x1015_398e; /* jmp 0x1015398e */
        l_0x1015_386e:
            ii(0x1015_386e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3871, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1015_3874, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1015_3877, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_387a, 5); calld(0x1014_f08b, -0x47f4);            /* call 0x1014f08b */
            ii(0x1015_387f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3882, 4); mov(memb_a32[ds, eax + 0x5e], 0);       /* mov byte [eax+0x5e], 0x0 */
            ii(0x1015_3886, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3889, 5); cmp(memw_a32[ds, eax + 0x8], 0x30);     /* cmp word [eax+0x8], 0x30 */
            ii(0x1015_388e, 2); if(jnzd(0x1015_38af, 0x1f)) goto l_0x1015_38af; /* jnz 0x101538af */
            ii(0x1015_3890, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1015_3895, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3898, 5); calld(0x1015_1172, -0x272b);            /* call 0x10151172 */
            ii(0x1015_389d, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1015_38a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_38a5, 5); calld(0x1016_2f0a, 0xf660);             /* call 0x10162f0a */
            ii(0x1015_38aa, 5); jmpd(0x1015_398e, 0xdf); goto l_0x1015_398e; /* jmp 0x1015398e */
        l_0x1015_38af:
            ii(0x1015_38af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_38b2, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x1015_38b7, 2); if(jnzd(0x1015_38bf, 0x6)) goto l_0x1015_38bf; /* jnz 0x101538bf */
            ii(0x1015_38b9, 4); cmp(memb_a32[ss, ebp - 0xc], 0x23);     /* cmp byte [ebp-0xc], 0x23 */
            ii(0x1015_38bd, 2); if(jzd(0x1015_38c1, 0x2)) goto l_0x1015_38c1; /* jz 0x101538c1 */
        l_0x1015_38bf:
            ii(0x1015_38bf, 2); jmpd(0x1015_390c, 0x4b); goto l_0x1015_390c; /* jmp 0x1015390c */
        l_0x1015_38c1:
            ii(0x1015_38c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_38c4, 5); calld(0x1015_0a9e, -0x2e2b);            /* call 0x10150a9e */
            ii(0x1015_38c9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_38cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_38cf, 5); calld(0x1015_1172, -0x2762);            /* call 0x10151172 */
            ii(0x1015_38d4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_38d7, 3); mov(al, memb_a32[ds, eax + 0x29]);      /* mov al, [eax+0x29] */
            ii(0x1015_38da, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_38dc, 1); inc(eax);                               /* inc eax */
            ii(0x1015_38dd, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1015_38e2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_38e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_38e8, 5); calld(0x1011_7fb8, -0x3_b935);          /* call 0x10117fb8 */
            ii(0x1015_38ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_38f0, 7); mov(ax, memw_a32[ds, eax + 0xd5]);      /* mov ax, [eax+0xd5] */
            ii(0x1015_38f7, 5); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1015_38fc, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_38ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3902, 5); calld(0x1014_9b07, -0x9e00);            /* call 0x10149b07 */
            ii(0x1015_3907, 5); jmpd(0x1015_398e, 0x82); goto l_0x1015_398e; /* jmp 0x1015398e */
        l_0x1015_390c:
            ii(0x1015_390c, 4); cmp(memb_a32[ss, ebp - 0xc], 0x23);     /* cmp byte [ebp-0xc], 0x23 */
            ii(0x1015_3910, 2); if(jzd(0x1015_398e, 0x7c)) goto l_0x1015_398e; /* jz 0x1015398e */
            ii(0x1015_3912, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_3915, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3918, 5); calld(0x1014_edfa, -0x4b23);            /* call 0x1014edfa */
            ii(0x1015_391d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_3920, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_3925, 5); calld(0x1010_3752, -0x5_01d8);          /* call 0x10103752 */
            ii(0x1015_392a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_392d, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1015_3930, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_3933, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1015_3936, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3938, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_393b, 4); mov(memw_a32[ds, eax + 0x1a], dx);      /* mov [eax+0x1a], dx */
            ii(0x1015_393f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3942, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x1015_3945, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_3948, 3); sar(edx, 0x6);                          /* sar edx, 0x6 */
            ii(0x1015_394b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_394e, 4); mov(memw_a32[ds, eax + 0x1c], dx);      /* mov [eax+0x1c], dx */
            ii(0x1015_3952, 5); calld(0x100d_53f0, -0x7_e567);          /* call 0x100d53f0 */
            ii(0x1015_3957, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_3959, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_395b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_395e, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_3963, 5); calld(0x1010_346f, -0x5_04f9);          /* call 0x1010346f */
            ii(0x1015_3968, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_396d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3970, 5); calld(0x1007_1838, -0xe_213d);          /* call 0x10071838 */
            ii(0x1015_3975, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3977, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_397a, 5); calld(0x1007_65d0, -0xd_d3af);          /* call 0x100765d0 */
            ii(0x1015_397f, 5); calld(0x1007_1838, -0xe_214c);          /* call 0x10071838 */
            ii(0x1015_3984, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3986, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_3989, 5); calld(0x1007_5f2c, -0xd_da62);          /* call 0x10075f2c */
        l_0x1015_398e:
            ii(0x1015_398e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_3990, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_3991, 1); popd(edi);                              /* pop edi */
            ii(0x1015_3992, 1); popd(esi);                              /* pop esi */
            ii(0x1015_3993, 1); popd(edx);                              /* pop edx */
            ii(0x1015_3994, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_3995, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_3996, 1); retd();                                 /* ret */
        }
    }
}
