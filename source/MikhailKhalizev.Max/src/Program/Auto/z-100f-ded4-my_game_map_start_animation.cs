using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_ded4-3ba752d7")]
        public void my_game_map_start_animation()
        {
            ii(0x100f_ded4, 5); push(0x48);                             /* push 0x48 */
            ii(0x100f_ded9, 5); call(Definitions.sys_check_available_stack_size, 0x6_7e74); /* call 0x10165d52 */
            ii(0x100f_dede, 1); push(ebx);                              /* push ebx */
            ii(0x100f_dedf, 1); push(ecx);                              /* push ecx */
            ii(0x100f_dee0, 1); push(edx);                              /* push edx */
            ii(0x100f_dee1, 1); push(esi);                              /* push esi */
            ii(0x100f_dee2, 1); push(edi);                              /* push edi */
            ii(0x100f_dee3, 1); push(ebp);                              /* push ebp */
            ii(0x100f_dee4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_dee6, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100f_deec, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x100f_deef, 5); call(0x100f_b576, -0x297e);             /* call 0x100fb576 */
            ii(0x100f_def4, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_defb, 2); if(jz(0x100f_df44, 0x47)) goto l_0x100f_df44; /* jz 0x100fdf44 */
            ii(0x100f_defd, 4); cmp(memb[ss, ebp - 0x4], 0x6);          /* cmp byte [ebp-0x4], 0x6 */
            ii(0x100f_df01, 2); if(jnz(0x100f_df3a, 0x37)) goto l_0x100f_df3a; /* jnz 0x100fdf3a */
            ii(0x100f_df03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_df05, 6); mov(dl, memb[ds, 0x101c_37da]);         /* mov dl, [0x101c37da] */
            ii(0x100f_df0b, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100f_df11, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_df13, 6); mov(bl, memb[ds, edx + 0x101c_a4ef]);   /* mov bl, [edx+0x101ca4ef] */
            ii(0x100f_df19, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_df1b, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_df20, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_df23, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x100f_df28, 5); call(0x1012_8897, 0x2_a96a);            /* call 0x10128897 */
            ii(0x100f_df2d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_df2f, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_df34, 1); cwde();                                 /* cwde */
            ii(0x100f_df35, 5); call(0x1013_602e, 0x3_80f4);            /* call 0x1013602e */
        l_0x100f_df3a:
            ii(0x100f_df3a, 5); mov(eax, memd[ds, 0x101c_5628]);        /* mov eax, [0x101c5628] */
            ii(0x100f_df3f, 5); call(/* sys */ 0x1016_5ebf, 0x6_7f7b);  /* call 0x10165ebf */
        l_0x100f_df44:
            ii(0x100f_df44, 5); call(0x100a_8ae1, -0x5_5468);           /* call 0x100a8ae1 */
            ii(0x100f_df49, 5); call(0x1011_fce3, 0x2_1d95);            /* call 0x1011fce3 */
            ii(0x100f_df4e, 4); cmp(memb[ss, ebp - 0x4], 0x6);          /* cmp byte [ebp-0x4], 0x6 */
            ii(0x100f_df52, 6); if(jnz(0x100f_e085, 0x12d)) goto l_0x100f_e085; /* jnz 0x100fe085 */
            ii(0x100f_df58, 7); mov(memb[ds, 0x101c_391e], 0x7);        /* mov byte [0x101c391e], 0x7 */
            ii(0x100f_df5f, 5); call(0x100f_dc7b, -0x2e9);              /* call 0x100fdc7b */
            ii(0x100f_df64, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_df66, 6); if(jz(0x100f_e1c4, 0x258)) goto l_0x100f_e1c4; /* jz 0x100fe1c4 */
            ii(0x100f_df6c, 5); call(0x100e_a903, -0x1_366e);           /* call 0x100ea903 */
            ii(0x100f_df71, 7); cmp(memb[ds, 0x101b_8744], 0);          /* cmp byte [0x101b8744], 0x0 */
            ii(0x100f_df78, 2); if(jz(0x100f_df88, 0xe)) goto l_0x100f_df88; /* jz 0x100fdf88 */
            ii(0x100f_df7a, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100f_df7f, 5); call(0x1007_5fdc, -0x8_7fa8);           /* call 0x10075fdc */
            ii(0x100f_df84, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_df86, 2); if(jz(0x100f_df8d, 0x5)) goto l_0x100f_df8d; /* jz 0x100fdf8d */
        l_0x100f_df88:
            ii(0x100f_df88, 5); jmp(0x100f_e016, 0x89); goto l_0x100f_e016; /* jmp 0x100fe016 */
        l_0x100f_df8d:
            ii(0x100f_df8d, 5); mov(eax, 0x101c_3990);                  /* mov eax, 0x101c3990 */
            ii(0x100f_df92, 5); call(0x100f_1370, -0xcc27);             /* call 0x100f1370 */
            ii(0x100f_df97, 5); mov(eax, 0x96);                         /* mov eax, 0x96 */
            ii(0x100f_df9c, 5); call(0x100f_3499, -0xab08);             /* call 0x100f3499 */
            ii(0x100f_dfa1, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_dfa4, 5); mov(eax, 0x6b5);                        /* mov eax, 0x6b5 */
            ii(0x100f_dfa9, 5); call(0x1011_584c, 0x1_789e);            /* call 0x1011584c */
            ii(0x100f_dfae, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x100f_dfb3, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_dfb6, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x100f_dfbb, 5); call(Definitions.sys_memcpy, 0x6_7e8b); /* call 0x10165e4b */
            ii(0x100f_dfc0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_dfc3, 5); call(Definitions.sys_free, 0x6_d0f9);   /* call 0x1016b0c1 */
            ii(0x100f_dfc8, 5); call(0x100d_533c, -0x2_8c91);           /* call 0x100d533c */
            ii(0x100f_dfcd, 1); cwde();                                 /* cwde */
            ii(0x100f_dfce, 1); push(eax);                              /* push eax */
            ii(0x100f_dfcf, 5); call(0x100d_5360, -0x2_8c74);           /* call 0x100d5360 */
            ii(0x100f_dfd4, 1); cwde();                                 /* cwde */
            ii(0x100f_dfd5, 1); push(eax);                              /* push eax */
            ii(0x100f_dfd6, 5); call(0x100d_5384, -0x2_8c57);           /* call 0x100d5384 */
            ii(0x100f_dfdb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_dfe0, 1); push(eax);                              /* push eax */
            ii(0x100f_dfe1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_dfe3, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x100f_dfe8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_dfea, 5); call(0x100e_883d, -0x1_57b2);           /* call 0x100e883d */
            ii(0x100f_dfef, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_dff1, 5); mov(eax, 0x6be);                        /* mov eax, 0x6be */
            ii(0x100f_dff6, 5); call(0x100e_8c51, -0x1_53aa);           /* call 0x100e8c51 */
            ii(0x100f_dffb, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_e000, 5); call(0x1010_0efe, 0x2ef9);              /* call 0x10100efe */
            ii(0x100f_e005, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x100f_e00a, 5); call(0x100e_9399, -0x1_4c76);           /* call 0x100e9399 */
            ii(0x100f_e00f, 7); mov(memb[ds, 0x101b_8744], 0);          /* mov byte [0x101b8744], 0x0 */
        l_0x100f_e016:
            ii(0x100f_e016, 7); mov(memb[ds, 0x101c_391e], 0xb);        /* mov byte [0x101c391e], 0xb */
            ii(0x100f_e01d, 5); mov(eax, 0x101c_3990);                  /* mov eax, 0x101c3990 */
            ii(0x100f_e022, 5); call(0x100f_189b, -0xc78c);             /* call 0x100f189b */
            ii(0x100f_e027, 7); mov(memd[ss, ebp - 0xc], 0x4);          /* mov dword [ebp-0xc], 0x4 */
            ii(0x100f_e02e, 7); mov(memd[ss, ebp - 0x10], 0x40);        /* mov dword [ebp-0x10], 0x40 */
            ii(0x100f_e035, 7); cmp(memb[ds, 0x101c_814a], 0);          /* cmp byte [0x101c814a], 0x0 */
            ii(0x100f_e03c, 2); if(jz(0x100f_e045, 0x7)) goto l_0x100f_e045; /* jz 0x100fe045 */
            ii(0x100f_e03e, 7); mov(memd[ss, ebp - 0x10], 0x20);        /* mov dword [ebp-0x10], 0x20 */
        l_0x100f_e045:
            ii(0x100f_e045, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_e048, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100f_e04c, 2); if(jg(0x100f_e080, 0x32)) goto l_0x100f_e080; /* jg 0x100fe080 */
            ii(0x100f_e04e, 5); call(0x1014_82f4, 0x4_a2a1);            /* call 0x101482f4 */
            ii(0x100f_e053, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_e056, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_e058, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e05a, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100f_e05e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e060, 5); call(0x1010_1620, 0x35bb);              /* call 0x10101620 */
            ii(0x100f_e065, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e067, 5); call(0x1010_0efe, 0x2e92);              /* call 0x10100efe */
        l_0x100f_e06c:
            ii(0x100f_e06c, 5); call(0x1014_82f4, 0x4_a283);            /* call 0x101482f4 */
            ii(0x100f_e071, 3); sub(eax, memd[ss, ebp - 0x14]);         /* sub eax, [ebp-0x14] */
            ii(0x100f_e074, 5); cmp(eax, 0x6119);                       /* cmp eax, 0x6119 */
            ii(0x100f_e079, 2); if(jb(0x100f_e06c, -0xf)) goto l_0x100f_e06c; /* jb 0x100fe06c */
            ii(0x100f_e07b, 3); shl(memd[ss, ebp - 0xc], 0x1);          /* shl dword [ebp-0xc], 1 */
            ii(0x100f_e07e, 2); jmp(0x100f_e045, -0x3b); goto l_0x100f_e045; /* jmp 0x100fe045 */
        l_0x100f_e080:
            ii(0x100f_e080, 5); jmp(0x100f_e136, 0xb1); goto l_0x100f_e136; /* jmp 0x100fe136 */
        l_0x100f_e085:
            ii(0x100f_e085, 7); mov(memb[ds, 0x101c_391e], 0xa);        /* mov byte [0x101c391e], 0xa */
            ii(0x100f_e08c, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_e093, 2); if(jnz(0x100f_e09b, 0x6)) goto l_0x100f_e09b; /* jnz 0x100fe09b */
            ii(0x100f_e095, 4); mov(memb[ss, ebp - 0x18], 0x1);         /* mov byte [ebp-0x18], 0x1 */
            ii(0x100f_e099, 2); jmp(0x100f_e09f, 0x4); goto l_0x100f_e09f; /* jmp 0x100fe09f */
        l_0x100f_e09b:
            ii(0x100f_e09b, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x100f_e09f:
            ii(0x100f_e09f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e0a1, 3); mov(bl, memb[ss, ebp - 0x18]);          /* mov bl, [ebp-0x18] */
            ii(0x100f_e0a4, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100f_e0a9, 5); call(0x1007_5fdc, -0x8_80d2);           /* call 0x10075fdc */
            ii(0x100f_e0ae, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_e0b1, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x100f_e0b6, 5); call(0x1007_5fdc, -0x8_80df);           /* call 0x10075fdc */
            ii(0x100f_e0bb, 1); cwde();                                 /* cwde */
            ii(0x100f_e0bc, 5); call(0x1013_8eb6, 0x3_adf5);            /* call 0x10138eb6 */
            ii(0x100f_e0c1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e0c3, 2); if(jnz(0x100f_e0d1, 0xc)) goto l_0x100f_e0d1; /* jnz 0x100fe0d1 */
            ii(0x100f_e0c5, 7); mov(memb[ds, 0x101c_391e], 0x3);        /* mov byte [0x101c391e], 0x3 */
            ii(0x100f_e0cc, 5); jmp(0x100f_e1c4, 0xf3); goto l_0x100f_e1c4; /* jmp 0x100fe1c4 */
        l_0x100f_e0d1:
            ii(0x100f_e0d1, 7); mov(memb[ds, 0x101c_391e], 0xb);        /* mov byte [0x101c391e], 0xb */
            ii(0x100f_e0d8, 5); mov(eax, 0x101c_3990);                  /* mov eax, 0x101c3990 */
            ii(0x100f_e0dd, 5); call(0x100f_189b, -0xc847);             /* call 0x100f189b */
            ii(0x100f_e0e2, 5); call(0x100f_dbfd, -0x4ea);              /* call 0x100fdbfd */
            ii(0x100f_e0e7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_e0e9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e0eb, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_e0f0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e0f2, 5); call(0x1010_1620, 0x3529);              /* call 0x10101620 */
            ii(0x100f_e0f7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e0f9, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_e0fe, 1); cwde();                                 /* cwde */
            ii(0x100f_e0ff, 5); call(0x100f_1d28, -0xc3dc);             /* call 0x100f1d28 */
            ii(0x100f_e104, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_e107, 5); call(0x1010_2acc, 0x49c0);              /* call 0x10102acc */
            ii(0x100f_e10c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_e10e, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_e110, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_e113, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100f_e116, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_e119, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_e11c, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100f_e11f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_e122, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_e127, 5); call(0x1010_1620, 0x34f4);              /* call 0x10101620 */
            ii(0x100f_e12c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_e131, 5); call(0x1010_0efe, 0x2dc8);              /* call 0x10100efe */
        l_0x100f_e136:
            ii(0x100f_e136, 7); mov(memb[ds, 0x101c_391e], 0x8);        /* mov byte [0x101c391e], 0x8 */
            ii(0x100f_e13d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e13f, 5); mov(al, memb[ds, 0x101c_3920]);         /* mov al, [0x101c3920] */
            ii(0x100f_e144, 5); call(0x1007_1cca, -0x8_c47f);           /* call 0x10071cca */
            ii(0x100f_e149, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x100f_e14e, 5); call(0x1007_5fdc, -0x8_8177);           /* call 0x10075fdc */
            ii(0x100f_e153, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_e155, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100f_e15a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_e15c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_e15f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_e161, 5); add(eax, 0x6a1);                        /* add eax, 0x6a1 */
            ii(0x100f_e166, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_e169, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_e16e, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x100f_e172, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_e177, 5); call(0x1013_cf8e, 0x3_ee12);            /* call 0x1013cf8e */
            ii(0x100f_e17c, 5); call(0x100f_3502, -0xac7f);             /* call 0x100f3502 */
            ii(0x100f_e181, 5); call(0x100f_1052, -0xd134);             /* call 0x100f1052 */
            ii(0x100f_e186, 5); call(0x100f_fc13, 0x1a88);              /* call 0x100ffc13 */
            ii(0x100f_e18b, 6); mov(edx, memd[ds, 0x101c_3960]);        /* mov edx, [0x101c3960] */
            ii(0x100f_e191, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_e194, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e196, 5); call(0x100f_b4fd, -0x2c9e);             /* call 0x100fb4fd */
            ii(0x100f_e19b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e19d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e19f, 5); call(0x100f_32a2, -0xaf02);             /* call 0x100f32a2 */
            ii(0x100f_e1a4, 5); call(/* sys */ 0x1016_be34, 0x6_dc8b);  /* call 0x1016be34 */
            ii(0x100f_e1a9, 5); mov(edx, 0xf0);                         /* mov edx, 0xf0 */
            ii(0x100f_e1ae, 5); mov(eax, 0x140);                        /* mov eax, 0x140 */
            ii(0x100f_e1b3, 5); call(/* sys */ 0x1016_c2bc, 0x6_e104);  /* call 0x1016c2bc */
            ii(0x100f_e1b8, 5); call(/* sys */ 0x1016_bcc4, 0x6_db07);  /* call 0x1016bcc4 */
            ii(0x100f_e1bd, 7); mov(memb[ds, 0x101c_388f], 0x1);        /* mov byte [0x101c388f], 0x1 */
        l_0x100f_e1c4:
            ii(0x100f_e1c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_e1c6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_e1c7, 1); pop(edi);                               /* pop edi */
            ii(0x100f_e1c8, 1); pop(esi);                               /* pop esi */
            ii(0x100f_e1c9, 1); pop(edx);                               /* pop edx */
            ii(0x100f_e1ca, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_e1cb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_e1cc, 1); ret();                                  /* ret */
        }
    }
}
