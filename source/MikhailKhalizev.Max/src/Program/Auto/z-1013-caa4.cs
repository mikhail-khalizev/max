using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_caa4-20c2bb58")]
        public void Method_1013_caa4()
        {
            ii(0x1013_caa4, 5); pushd(0xf8);                            /* push 0xf8 */
            ii(0x1013_caa9, 5); calld(Definitions.sys_check_available_stack_size, 0x2_92a4); /* call 0x10165d52 */
            ii(0x1013_caae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_caaf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_cab0, 1); pushd(edx);                             /* push edx */
            ii(0x1013_cab1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_cab2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_cab3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_cab4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_cab6, 6); sub(esp, 0xcc);                         /* sub esp, 0xcc */
            ii(0x1013_cabc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_cabf, 5); mov(eax, 0x74);                         /* mov eax, 0x74 */
            ii(0x1013_cac4, 5); calld(0x1007_5fdc, -0xc_6aed);          /* call 0x10075fdc */
            ii(0x1013_cac9, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_cacc, 5); mov(eax, 0x73);                         /* mov eax, 0x73 */
            ii(0x1013_cad1, 5); calld(0x1007_5fdc, -0xc_6afa);          /* call 0x10075fdc */
            ii(0x1013_cad6, 5); mov(memd_a32[ds, 0x101c_80fc], eax);    /* mov [0x101c80fc], eax */
            ii(0x1013_cadb, 5); mov(eax, 0x72);                         /* mov eax, 0x72 */
            ii(0x1013_cae0, 5); calld(0x1007_5fdc, -0xc_6b09);          /* call 0x10075fdc */
            ii(0x1013_cae5, 5); mov(memd_a32[ds, 0x101c_8104], eax);    /* mov [0x101c8104], eax */
            ii(0x1013_caea, 5); mov(eax, 0x71);                         /* mov eax, 0x71 */
            ii(0x1013_caef, 5); calld(0x1007_5fdc, -0xc_6b18);          /* call 0x10075fdc */
            ii(0x1013_caf4, 5); mov(memd_a32[ds, 0x101c_8100], eax);    /* mov [0x101c8100], eax */
            ii(0x1013_caf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_cafb, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1013_cb00, 5); calld(/* sys */ 0x1017_d829, 0x4_0d24); /* call 0x1017d829 */
            ii(0x1013_cb05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cb08, 7); mov(memb_a32[ds, eax + 0xdd2], 0x1);    /* mov byte [eax+0xdd2], 0x1 */
            ii(0x1013_cb0f, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_cb13, 2); if(jnzd(0x1013_cb2e, 0x19)) goto l_0x1013_cb2e; /* jnz 0x1013cb2e */
            ii(0x1013_cb15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cb18, 7); mov(memd_a32[ds, eax + 0x1c], 0xffff);  /* mov dword [eax+0x1c], 0xffff */
            ii(0x1013_cb1f, 2); pushd(-0x1 /* 0xff */);                 /* push 0xffffffff */
            ii(0x1013_cb21, 5); calld(/* sys */ 0x1017_9c60, 0x3_d13a); /* call 0x10179c60 */
            ii(0x1013_cb26, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1013_cb29, 5); jmpd(0x1013_cd63, 0x235); goto l_0x1013_cd63; /* jmp 0x1013cd63 */
        l_0x1013_cb2e:
            ii(0x1013_cb2e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_cb30, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_cb32, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_cb34, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_cb36, 5); calld(/* sys */ 0x1017_df7d, 0x4_1442); /* call 0x1017df7d */
            ii(0x1013_cb3b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_cb3e, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1013_cb42, 2); if(jzd(0x1013_cb65, 0x21)) goto l_0x1013_cb65; /* jz 0x1013cb65 */
            ii(0x1013_cb44, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_cb47, 5); calld(/* sys */ 0x1017_ec08, 0x4_20bc); /* call 0x1017ec08 */
            ii(0x1013_cb4c, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cb4d, 5); mov(eax, StringDefinitions.ErrorS);     /* mov eax, 0x101acd10 */
            ii(0x1013_cb52, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cb53, 5); calld(Definitions.sys_printf, 0x2_fae4); /* call 0x1016c63c */
            ii(0x1013_cb58, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1013_cb5b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_cb60, 5); calld(Definitions.sys_exit, 0x2_fafa);  /* call 0x1016c65f */
        l_0x1013_cb65:
            ii(0x1013_cb65, 2); mov(eax, ss);                           /* mov eax, ss */
            ii(0x1013_cb67, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1013_cb6a, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1013_cb6f, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cb70, 1); pushd(edx);                             /* push edx */
            ii(0x1013_cb71, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_cb73, 5); mov(edx, 0x101c_8090);                  /* mov edx, 0x101c8090 */
            ii(0x1013_cb78, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_cb7a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_cb7c, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1013_cb7f, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1013_cb81, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_cb83, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_cb85, 5); calld(/* sys */ 0x1017_e116, 0x4_158c); /* call 0x1017e116 */
            ii(0x1013_cb8a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_cb8d, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1013_cb91, 2); if(jzd(0x1013_cbb9, 0x26)) goto l_0x1013_cbb9; /* jz 0x1013cbb9 */
            ii(0x1013_cb93, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_cb96, 5); calld(/* sys */ 0x1017_ec08, 0x4_206d); /* call 0x1017ec08 */
            ii(0x1013_cb9b, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cb9c, 5); mov(eax, StringDefinitions.ErrorS2);    /* mov eax, 0x101acd1a */
            ii(0x1013_cba1, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cba2, 5); calld(Definitions.sys_printf, 0x2_fa95); /* call 0x1016c63c */
            ii(0x1013_cba7, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1013_cbaa, 5); calld(/* sys */ 0x1017_e0ab, 0x4_14fc); /* call 0x1017e0ab */
            ii(0x1013_cbaf, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_cbb4, 5); calld(Definitions.sys_exit, 0x2_faa6);  /* call 0x1016c65f */
        l_0x1013_cbb9:
            ii(0x1013_cbb9, 5); calld(/* sys */ 0x1017_e0ab, 0x4_14ed); /* call 0x1017e0ab */
            ii(0x1013_cbbe, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_cbc0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_cbc2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_cbc4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_cbc6, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1013_cbc8, 5); calld(/* sys */ 0x1017_efb8, 0x4_23eb); /* call 0x1017efb8 */
            ii(0x1013_cbcd, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1013_cbd0, 3); add(ecx, 0x1c);                         /* add ecx, 0x1c */
            ii(0x1013_cbd3, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_cbd5, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1013_cbda, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cbdb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_cbdc, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_cbde, 5); mov(ecx, 0x101b_d4ec);                  /* mov ecx, 0x101bd4ec */
            ii(0x1013_cbe3, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1013_cbe8, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cbe9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_cbea, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_cbec, 5); mov(ecx, 0x101c_80fc);                  /* mov ecx, 0x101c80fc */
            ii(0x1013_cbf1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_cbf3, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1013_cbf5, 6); mov(edx, memd_a32[ds, 0x101c_80f4]);    /* mov edx, [0x101c80f4] */
            ii(0x1013_cbfb, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1013_cbfd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_cbff, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_cc01, 5); calld(/* sys */ 0x1017_f04e, 0x4_2448); /* call 0x1017f04e */
            ii(0x1013_cc06, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_cc09, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1013_cc0d, 2); if(jzd(0x1013_cc3a, 0x2b)) goto l_0x1013_cc3a; /* jz 0x1013cc3a */
            ii(0x1013_cc0f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_cc12, 5); calld(/* sys */ 0x1017_ec08, 0x4_1ff1); /* call 0x1017ec08 */
            ii(0x1013_cc17, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cc18, 5); mov(eax, StringDefinitions.ErrorS3);    /* mov eax, 0x101acd24 */
            ii(0x1013_cc1d, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cc1e, 5); calld(Definitions.sys_printf, 0x2_fa19); /* call 0x1016c63c */
            ii(0x1013_cc23, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1013_cc26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cc29, 7); mov(memd_a32[ds, eax + 0x1c], 0xffff);  /* mov dword [eax+0x1c], 0xffff */
            ii(0x1013_cc30, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_cc35, 5); calld(Definitions.sys_exit, 0x2_fa25);  /* call 0x1016c65f */
        l_0x1013_cc3a:
            ii(0x1013_cc3a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_cc3d, 6); add(edx, 0xda9);                        /* add edx, 0xda9 */
            ii(0x1013_cc43, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_cc45, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1013_cc4a, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cc4b, 1); pushd(edx);                             /* push edx */
            ii(0x1013_cc4c, 7); mov(bx, memw_a32[ds, 0x101b_d50c]);     /* mov bx, [0x101bd50c] */
            ii(0x1013_cc53, 5); mov(eax, memd_a32[ds, 0x101b_d508]);    /* mov eax, [0x101bd508] */
            ii(0x1013_cc58, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1013_cc5d, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1013_cc5f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_cc61, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_cc63, 5); calld(/* sys */ 0x1017_d93f, 0x4_0cd7); /* call 0x1017d93f */
            ii(0x1013_cc68, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_cc6b, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1013_cc6f, 2); if(jzd(0x1013_cc9f, 0x2e)) goto l_0x1013_cc9f; /* jz 0x1013cc9f */
            ii(0x1013_cc71, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_cc74, 5); calld(/* sys */ 0x1017_ec08, 0x4_1f8f); /* call 0x1017ec08 */
            ii(0x1013_cc79, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cc7a, 5); mov(eax, StringDefinitions.ErrorS4);    /* mov eax, 0x101acd2e */
            ii(0x1013_cc7f, 1); pushd(eax);                             /* push eax */
            ii(0x1013_cc80, 5); calld(Definitions.sys_printf, 0x2_f9b7); /* call 0x1016c63c */
            ii(0x1013_cc85, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1013_cc88, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cc8b, 10); mov(memd_a32[ds, eax + 0xda9], 0xffff); /* mov dword [eax+0xda9], 0xffff */
            ii(0x1013_cc95, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_cc9a, 5); calld(Definitions.sys_exit, 0x2_f9c0);  /* call 0x1016c65f */
        l_0x1013_cc9f:
            ii(0x1013_cc9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cca2, 3); pushd(memd_a32[ds, eax + 0x1c]);        /* push dword [eax+0x1c] */
            ii(0x1013_cca5, 5); calld(/* sys */ 0x1017_9c60, 0x3_cfb6); /* call 0x10179c60 */
            ii(0x1013_ccaa, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1013_ccad, 5); mov(eax, 0x1013_e49e);                  /* mov eax, 0x1013e49e */
            ii(0x1013_ccb2, 5); calld(/* sys */ 0x1016_b3dc, 0x2_e725); /* call 0x1016b3dc */
            ii(0x1013_ccb7, 5); calld(/* sys */ 0x1016_b44c, 0x2_e790); /* call 0x1016b44c */
            ii(0x1013_ccbc, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1013_ccc0, 6); lea(eax, ebp - 0xc8);                   /* lea eax, [ebp-0xc8] */
            ii(0x1013_ccc6, 5); calld(0x1010_68d0, -0x3_63fb);          /* call 0x101068d0 */
            ii(0x1013_cccb, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_ccce, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1013_ccd2, 5); mov(eax, 0x794);                        /* mov eax, 0x794 */
            ii(0x1013_ccd7, 5); calld(Definitions.sys_new_arr, 0x2_9334); /* call 0x10166010 */
            ii(0x1013_ccdc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_ccde, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cce1, 6); mov(memd_a32[ds, eax + 0xdad], edx);    /* mov [eax+0xdad], edx */
            ii(0x1013_cce7, 6); lea(eax, ebp - 0xc8);                   /* lea eax, [ebp-0xc8] */
            ii(0x1013_cced, 5); calld(0x1010_6944, -0x3_63ae);          /* call 0x10106944 */
            ii(0x1013_ccf2, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_ccf9, 2); jmpd(0x1013_cd01, 0x6); goto l_0x1013_cd01; /* jmp 0x1013cd01 */
        l_0x1013_ccfb:
            ii(0x1013_ccfb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ccfe, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1013_cd01:
            ii(0x1013_cd01, 7); cmp(memd_a32[ss, ebp - 0xc], 0x183);    /* cmp dword [ebp-0xc], 0x183 */
            ii(0x1013_cd08, 2); if(jged(0x1013_cd56, 0x4c)) goto l_0x1013_cd56; /* jge 0x1013cd56 */
            ii(0x1013_cd0a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_cd0d, 5); add(eax, 0x51d);                        /* add eax, 0x51d */
            ii(0x1013_cd12, 6); mov(memd_a32[ss, ebp - 0xcc], eax);     /* mov [ebp-0xcc], eax */
            ii(0x1013_cd18, 7); movsx(edx, memw_a32[ss, ebp - 0xcc]);   /* movsx edx, word [ebp-0xcc] */
            ii(0x1013_cd1f, 6); lea(eax, ebp - 0xc8);                   /* lea eax, [ebp-0xc8] */
            ii(0x1013_cd25, 5); calld(0x1010_697a, -0x3_63b0);          /* call 0x1010697a */
            ii(0x1013_cd2a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_cd2c, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1013_cd2f, 3); lea(ebx, ebx + ebx * 4);                /* lea ebx, [ebx+ebx*4] */
            ii(0x1013_cd32, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cd35, 6); mov(eax, memd_a32[ds, eax + 0xdad]);    /* mov eax, [eax+0xdad] */
            ii(0x1013_cd3b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_cd3d, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1013_cd3f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_cd42, 3); lea(edx, edx + edx * 4);                /* lea edx, [edx+edx*4] */
            ii(0x1013_cd45, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cd48, 6); mov(eax, memd_a32[ds, eax + 0xdad]);    /* mov eax, [eax+0xdad] */
            ii(0x1013_cd4e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_cd50, 4); mov(memb_a32[ds, eax + 0x4], 0xff);     /* mov byte [eax+0x4], 0xff */
            ii(0x1013_cd54, 2); jmpd(0x1013_ccfb, -0x5b); goto l_0x1013_ccfb; /* jmp 0x1013ccfb */
        l_0x1013_cd56:
            ii(0x1013_cd56, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_cd58, 6); lea(eax, ebp - 0xc8);                   /* lea eax, [ebp-0xc8] */
            ii(0x1013_cd5e, 5); calld(0x1010_690a, -0x3_6459);          /* call 0x1010690a */
        l_0x1013_cd63:
            ii(0x1013_cd63, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_cd65, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_cd66, 1); popd(edi);                              /* pop edi */
            ii(0x1013_cd67, 1); popd(esi);                              /* pop esi */
            ii(0x1013_cd68, 1); popd(edx);                              /* pop edx */
            ii(0x1013_cd69, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_cd6a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_cd6b, 1); retd(); return;                         /* ret */
        }
    }
}
