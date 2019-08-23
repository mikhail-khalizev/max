using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_39b4-473063fa")]
        public void Method_100f_39b4()
        {
            ii(0x100f_39b4, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100f_39b9, 5); calld(Definitions.sys_check_available_stack_size, 0x7_2394); /* call 0x10165d52 */
            ii(0x100f_39be, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_39bf, 1); pushd(esi);                             /* push esi */
            ii(0x100f_39c0, 1); pushd(edi);                             /* push edi */
            ii(0x100f_39c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_39c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_39c4, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100f_39ca, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_39cd, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100f_39d0, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100f_39d3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_39d5, 5); calld(0x100e_93d0, -0xa60a);            /* call 0x100e93d0 */
            ii(0x100f_39da, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_39df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_39e1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_39e3, 5); calld(0x100f_fca3, 0xc2bb);             /* call 0x100ffca3 */
            ii(0x100f_39e8, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x100f_39ed, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100f_39f0, 5); mov(eax, memd_a32[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x100f_39f5, 5); calld(Definitions.sys_memcpy, 0x7_2451); /* call 0x10165e4b */
            ii(0x100f_39fa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_39fd, 5); calld(Definitions.sys_free, 0x7_76bf);  /* call 0x1016b0c1 */
            ii(0x100f_3a02, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100f_3a06, 5); cmp(memw_a32[ss, ebp - 0x8], 0);        /* cmp word [ebp-0x8], 0x0 */
            ii(0x100f_3a0b, 6); if(jzd(0x100f_3aee, 0xdd)) goto l_0x100f_3aee; /* jz 0x100f3aee */
            ii(0x100f_3a11, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3a13, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_3a18, 5); calld(0x1013_ad71, 0x4_7354);           /* call 0x1013ad71 */
            ii(0x100f_3a1d, 2); test(al, al);                           /* test al, al */
            ii(0x100f_3a1f, 2); if(jzd(0x100f_3a42, 0x21)) goto l_0x100f_3a42; /* jz 0x100f3a42 */
            ii(0x100f_3a21, 5); calld(0x1010_2bf8, 0xf1d2);             /* call 0x10102bf8 */
            ii(0x100f_3a26, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_3a28, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_3a2a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_3a2c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_3a31, 5); calld(0x1007_6600, -0x7_d436);          /* call 0x10076600 */
            ii(0x100f_3a36, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_3a38, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_3a3d, 5); calld(0x1013_d5c0, 0x4_9b7e);           /* call 0x1013d5c0 */
        l_0x100f_3a42:
            ii(0x100f_3a42, 5); calld(0x1011_606c, 0x2_2625);           /* call 0x1011606c */
            ii(0x100f_3a47, 7); mov(memb_a32[ds, 0x101c_3911], 0);      /* mov byte [0x101c3911], 0x0 */
            ii(0x100f_3a4e, 7); mov(memb_a32[ds, 0x101c_391e], 0xa);    /* mov byte [0x101c391e], 0xa */
            ii(0x100f_3a55, 5); calld(0x1013_9c10, 0x4_61b6);           /* call 0x10139c10 */
            ii(0x100f_3a5a, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100f_3a5d, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x100f_3a62, 5); calld(0x1010_2e0f, 0xf3a8);             /* call 0x10102e0f */
            ii(0x100f_3a67, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100f_3a6c, 5); calld(0x1010_2e0f, 0xf39e);             /* call 0x10102e0f */
            ii(0x100f_3a71, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x100f_3a76, 5); calld(0x1010_2e0f, 0xf394);             /* call 0x10102e0f */
            ii(0x100f_3a7b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_3a80, 5); calld(0x1010_2e0f, 0xf38a);             /* call 0x10102e0f */
            ii(0x100f_3a85, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100f_3a8a, 5); calld(0x1010_2e0f, 0xf380);             /* call 0x10102e0f */
            ii(0x100f_3a8f, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x100f_3a94, 5); calld(0x1010_3ff1, 0x1_0558);           /* call 0x10103ff1 */
            ii(0x100f_3a99, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x100f_3a9e, 5); calld(0x1010_380b, 0xfd68);             /* call 0x1010380b */
            ii(0x100f_3aa3, 5); calld(0x100a_8ae1, -0x4_afc7);          /* call 0x100a8ae1 */
            ii(0x100f_3aa8, 5); calld(0x1011_fce3, 0x2_c236);           /* call 0x1011fce3 */
            ii(0x100f_3aad, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_3ab2, 5); calld(0x1013_a6f4, 0x4_6c3d);           /* call 0x1013a6f4 */
            ii(0x100f_3ab7, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_3abc, 5); movsx(ax, memb_a32[ss, ebp - 0x14]);    /* movsx ax, byte [ebp-0x14] */
            ii(0x100f_3ac1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_3ac4, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_3ac8, 5); calld(0x1013_8eb6, 0x4_53e9);           /* call 0x10138eb6 */
            ii(0x100f_3acd, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100f_3ad0, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_3ad4, 2); if(jzd(0x100f_3aee, 0x18)) goto l_0x100f_3aee; /* jz 0x100f3aee */
            ii(0x100f_3ad6, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_3add, 2); if(jzd(0x100f_3ae4, 0x5)) goto l_0x100f_3ae4; /* jz 0x100f3ae4 */
            ii(0x100f_3adf, 5); calld(0x1012_9753, 0x3_5c6f);           /* call 0x10129753 */
        l_0x100f_3ae4:
            ii(0x100f_3ae4, 5); mov(eax, 0x101c_3990);                  /* mov eax, 0x101c3990 */
            ii(0x100f_3ae9, 5); calld(0x100f_189b, -0x2253);            /* call 0x100f189b */
        l_0x100f_3aee:
            ii(0x100f_3aee, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_3af2, 2); if(jnzd(0x100f_3b42, 0x4e)) goto l_0x100f_3b42; /* jnz 0x100f3b42 */
            ii(0x100f_3af4, 5); calld(0x100d_533c, -0x1_e7bd);          /* call 0x100d533c */
            ii(0x100f_3af9, 1); cwde();                                 /* cwde */
            ii(0x100f_3afa, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3afb, 5); calld(0x100d_5360, -0x1_e7a0);          /* call 0x100d5360 */
            ii(0x100f_3b00, 1); cwde();                                 /* cwde */
            ii(0x100f_3b01, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3b02, 5); calld(0x100d_5384, -0x1_e783);          /* call 0x100d5384 */
            ii(0x100f_3b07, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_3b0c, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3b0d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_3b0f, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x100f_3b14, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3b16, 5); calld(0x100e_883d, -0xb2de);            /* call 0x100e883d */
            ii(0x100f_3b1b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_3b1d, 5); mov(eax, 0x6be);                        /* mov eax, 0x6be */
            ii(0x100f_3b22, 5); calld(0x100e_8c51, -0xaed6);            /* call 0x100e8c51 */
            ii(0x100f_3b27, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3b29, 5); calld(0x100f_0b1b, -0x3013);            /* call 0x100f0b1b */
            ii(0x100f_3b2e, 5); calld(0x100f_0fc5, -0x2b6e);            /* call 0x100f0fc5 */
            ii(0x100f_3b33, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3b35, 5); calld(0x100e_883d, -0xb2fd);            /* call 0x100e883d */
            ii(0x100f_3b3a, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100f_3b3d, 5); calld(Definitions.sys_display_draw_0, 0x7_3942); /* call 0x10167484 */
        l_0x100f_3b42:
            ii(0x100f_3b42, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_3b46, 2); if(jzd(0x100f_3b5d, 0x15)) goto l_0x100f_3b5d; /* jz 0x100f3b5d */
            ii(0x100f_3b48, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100f_3b4d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_3b4f, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_3b54, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3b56, 5); calld(0x1010_1620, 0xdac5);             /* call 0x10101620 */
            ii(0x100f_3b5b, 2); jmpd(0x100f_3b74, 0x17); goto l_0x100f_3b74; /* jmp 0x100f3b74 */
        l_0x100f_3b5d:
            ii(0x100f_3b5d, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100f_3b62, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_3b64, 6); mov(edx, memd_a32[ds, 0x101c_38be]);    /* mov edx, [0x101c38be] */
            ii(0x100f_3b6a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_3b6d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3b6f, 5); calld(0x1010_1620, 0xdaac);             /* call 0x10101620 */
        l_0x100f_3b74:
            ii(0x100f_3b74, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_3b79, 5); calld(0x1010_0efe, 0xd380);             /* call 0x10100efe */
            ii(0x100f_3b7e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3b80, 5); calld(0x100e_9399, -0xa7ec);            /* call 0x100e9399 */
            ii(0x100f_3b85, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x100f_3b8a, 5); calld(0x1007_5fdc, -0x7_dbb3);          /* call 0x10075fdc */
            ii(0x100f_3b8f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_3b91, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100f_3b96, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_3b98, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_3b9b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_3b9d, 5); add(eax, 0x6a1);                        /* add eax, 0x6a1 */
            ii(0x100f_3ba2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_3ba5, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_3baa, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100f_3bae, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_3bb3, 5); calld(0x1013_cf8e, 0x4_93d6);           /* call 0x1013cf8e */
            ii(0x100f_3bb8, 5); calld(0x100f_3502, -0x6bb);             /* call 0x100f3502 */
            ii(0x100f_3bbd, 5); calld(0x100f_1052, -0x2b70);            /* call 0x100f1052 */
            ii(0x100f_3bc2, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_3bc6, 2); if(jzd(0x100f_3bd5, 0xd)) goto l_0x100f_3bd5; /* jz 0x100f3bd5 */
            ii(0x100f_3bc8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3bca, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_3bcf, 1); cwde();                                 /* cwde */
            ii(0x100f_3bd0, 5); calld(0x100f_3800, -0x3d5);             /* call 0x100f3800 */
        l_0x100f_3bd5:
            ii(0x100f_3bd5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3bd7, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_3bdc, 5); calld(0x1013_ad71, 0x4_7190);           /* call 0x1013ad71 */
            ii(0x100f_3be1, 2); test(al, al);                           /* test al, al */
            ii(0x100f_3be3, 2); if(jzd(0x100f_3bf6, 0x11)) goto l_0x100f_3bf6; /* jz 0x100f3bf6 */
            ii(0x100f_3be5, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_3bea, 5); calld(0x1007_6600, -0x7_d5ef);          /* call 0x10076600 */
            ii(0x100f_3bef, 5); calld(0x100f_fa70, 0xbe7c);             /* call 0x100ffa70 */
            ii(0x100f_3bf4, 2); jmpd(0x100f_3bfd, 0x7); goto l_0x100f_3bfd; /* jmp 0x100f3bfd */
        l_0x100f_3bf6:
            ii(0x100f_3bf6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3bf8, 5); calld(0x100f_fa70, 0xbe73);             /* call 0x100ffa70 */
        l_0x100f_3bfd:
            ii(0x100f_3bfd, 5); mov(eax, memd_a32[ds, 0x101c_37da]);    /* mov eax, [0x101c37da] */
            ii(0x100f_3c02, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_3c05, 5); calld(0x100f_32f7, -0x913);             /* call 0x100f32f7 */
            ii(0x100f_3c0a, 5); calld(0x1010_2aac, 0xee9d);             /* call 0x10102aac */
            ii(0x100f_3c0f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3c11, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_3c13, 5); mov(eax, memd_a32[ds, 0x101c_3960]);    /* mov eax, [0x101c3960] */
            ii(0x100f_3c18, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_3c1b, 5); calld(0x100f_334b, -0x8d5);             /* call 0x100f334b */
            ii(0x100f_3c20, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3c22, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100f_3c25, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_3c28, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_3c2b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_3c2d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_3c2e, 1); popd(edi);                              /* pop edi */
            ii(0x100f_3c2f, 1); popd(esi);                              /* pop esi */
            ii(0x100f_3c30, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_3c31, 1); retd();                                 /* ret */
        }
    }
}
