using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("561849a7-503b-4ce5-bfef-6b09e9f81c27")]
        public void Method_1015_ce8f()
        {
            ii(0x1015_ce8f, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1015_ce94, 5); calld(Definitions.sys_check_available_stack_size, 0x8eb9); /* call 0x10165d52 */
            ii(0x1015_ce99, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_ce9a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_ce9b, 1); pushd(edx);                             /* push edx */
            ii(0x1015_ce9c, 1); pushd(esi);                             /* push esi */
            ii(0x1015_ce9d, 1); pushd(edi);                             /* push edi */
            ii(0x1015_ce9e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_ce9f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_cea1, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1015_cea7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_ceaa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_cead, 5); calld(0x1007_611c, -0xe_6d96);          /* call 0x1007611c */
            ii(0x1015_ceb2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ceb4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_ceb7, 5); calld(0x1007_66ac, -0xe_6810);          /* call 0x100766ac */
            ii(0x1015_cebc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_cebf, 5); calld(0x1007_6600, -0xe_68c4);          /* call 0x10076600 */
            ii(0x1015_cec4, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_cec7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cec9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_cecc, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_cecf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_ced2, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_ced6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_ced9, 5); calld(0x1007_623c, -0xe_6ca2);          /* call 0x1007623c */
            ii(0x1015_cede, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1015_cee1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_cee4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_cee6, 2); if(jnzd(0x1015_cf10, 0x28)) goto l_0x1015_cf10; /* jnz 0x1015cf10 */
            ii(0x1015_cee8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_ceeb, 5); calld(0x1007_623c, -0xe_6cb4);          /* call 0x1007623c */
            ii(0x1015_cef0, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1015_cef3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_cef6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_cef9, 5); calld(0x1015_0369, -0xcb95);            /* call 0x10150369 */
            ii(0x1015_cefe, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_cf01, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1015_cf04, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_cf06, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_cf09, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_cf0b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_cf0e, 2); jmpd(0x1015_cf76, 0x66); goto l_0x1015_cf76; /* jmp 0x1015cf76 */
        l_0x1015_cf10:
            ii(0x1015_cf10, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cf13, 5); calld(0x1007_623c, -0xe_6cdc);          /* call 0x1007623c */
            ii(0x1015_cf18, 3); mov(ebx, memd_a32[ds, eax + 0xe]);      /* mov ebx, [eax+0xe] */
            ii(0x1015_cf1b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_cf1e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_cf21, 5); calld(0x1015_0369, -0xcbbd);            /* call 0x10150369 */
            ii(0x1015_cf26, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_cf29, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1015_cf2c, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x1015_cf2f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cf32, 5); calld(0x1007_623c, -0xe_6cfb);          /* call 0x1007623c */
            ii(0x1015_cf37, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1015_cf3a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_cf3d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cf40, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1015_cf43, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_cf48, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1015_cf4b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1015_cf4d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cf50, 5); calld(0x1007_623c, -0xe_6d19);          /* call 0x1007623c */
            ii(0x1015_cf55, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1015_cf58, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_cf5b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cf5e, 5); calld(0x1007_623c, -0xe_6d27);          /* call 0x1007623c */
            ii(0x1015_cf63, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1015_cf66, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_cf69, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1015_cf6c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_cf6e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_cf71, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_cf73, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1015_cf76:
            ii(0x1015_cf76, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_cf7a, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_cf7d, 2); if(jged(0x1015_cf86, 0x7)) goto l_0x1015_cf86; /* jge 0x1015cf86 */
            ii(0x1015_cf7f, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
        l_0x1015_cf86:
            ii(0x1015_cf86, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cf89, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_cf8b, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_cf8e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cf90, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_cf95, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_cf97, 2); if(jnzd(0x1015_cfab, 0x12)) goto l_0x1015_cfab; /* jnz 0x1015cfab */
            ii(0x1015_cf99, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1015_cf9e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cfa1, 5); calld(0x100f_3c32, -0x6_9374);          /* call 0x100f3c32 */
            ii(0x1015_cfa6, 5); jmpd(0x1015_d063, 0xb8); goto l_0x1015_d063; /* jmp 0x1015d063 */
        l_0x1015_cfab:
            ii(0x1015_cfab, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1015_cfaf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cfb1, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_cfb6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_cfb8, 6); if(jnzd(0x1015_d063, 0xa5)) goto l_0x1015_d063; /* jnz 0x1015d063 */
            ii(0x1015_cfbe, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cfc1, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1015_cfc4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_cfc7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_cfca, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1015_cfcd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_cfd0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_cfd3, 5); calld(0x1007_6aac, -0xe_652c);          /* call 0x10076aac */
            ii(0x1015_cfd8, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_cfdc, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_cfdf, 2); if(jnzd(0x1015_cfff, 0x1e)) goto l_0x1015_cfff; /* jnz 0x1015cfff */
            ii(0x1015_cfe1, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1015_cfe4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_cfe7, 5); calld(0x1007_5e64, -0xe_7188);          /* call 0x10075e64 */
            ii(0x1015_cfec, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1015_cfee, 3); mov(ebx, memd_a32[ss, ebp - 0x18]);     /* mov ebx, [ebp-0x18] */
            ii(0x1015_cff1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_cff3, 5); mov(eax, StringDefinitions.EnemyUnitDisabledFor1Turn); /* mov eax, 0x101b2822 */
            ii(0x1015_cff8, 5); calld(0x1011_5b60, -0x4_749d);          /* call 0x10115b60 */
            ii(0x1015_cffd, 2); jmpd(0x1015_d047, 0x48); goto l_0x1015_d047; /* jmp 0x1015d047 */
        l_0x1015_cfff:
            ii(0x1015_cfff, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1015_d002, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1015_d005, 5); calld(0x1007_5e64, -0xe_71a6);          /* call 0x10075e64 */
            ii(0x1015_d00a, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1015_d00c, 3); mov(ebx, memd_a32[ss, ebp - 0x18]);     /* mov ebx, [ebp-0x18] */
            ii(0x1015_d00f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d011, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_d015, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d016, 5); mov(eax, StringDefinitions.EnemyUnitDisabledForITurns); /* mov eax, 0x101b2842 */
            ii(0x1015_d01b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d01c, 5); mov(eax, 0x64);                         /* mov eax, 0x64 */
            ii(0x1015_d021, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d022, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1015_d025, 5); calld(Definitions.my_string_ctor, -0x1_b542); /* call 0x10141ae8 */
            ii(0x1015_d02a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d02b, 5); calld(0x1014_2037, -0x1_aff9);          /* call 0x10142037 */
            ii(0x1015_d030, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1015_d033, 5); calld(Definitions.my_strobj_c_str_v2, -0xd_3870); /* call 0x100897c8 */
            ii(0x1015_d038, 5); calld(0x1011_5b60, -0x4_74dd);          /* call 0x10115b60 */
            ii(0x1015_d03d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d03f, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1015_d042, 5); calld(Definitions.my_string_dtor, -0x1_b51d); /* call 0x10141b2a */
        l_0x1015_d047:
            ii(0x1015_d047, 5); calld(0x100d_5470, -0x8_7bdc);          /* call 0x100d5470 */
            ii(0x1015_d04c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_d04f, 5); mov(ebx, 0x3d8);                        /* mov ebx, 0x3d8 */
            ii(0x1015_d054, 5); mov(edx, 0x3d7);                        /* mov edx, 0x3d7 */
            ii(0x1015_d059, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_d05e, 5); calld(0x1013_daea, -0x1_f579);          /* call 0x1013daea */
        l_0x1015_d063:
            ii(0x1015_d063, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d066, 3); mov(al, memb_a32[ds, eax + 0x3d]);      /* mov al, [eax+0x3d] */
            ii(0x1015_d069, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x1015_d06c, 5); jmpd(0x1015_d0e7, 0x76); goto l_0x1015_d0e7; /* jmp 0x1015d0e7 */
        l_0x1015_d071:
            ii(0x1015_d071, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d074, 4); cmp(memb_a32[ds, eax + 0x3e], 0x19);    /* cmp byte [eax+0x3e], 0x19 */
            ii(0x1015_d078, 2); if(jnzd(0x1015_d084, 0xa)) goto l_0x1015_d084; /* jnz 0x1015d084 */
            ii(0x1015_d07a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d07d, 5); calld(0x100f_3f62, -0x6_9120);          /* call 0x100f3f62 */
            ii(0x1015_d082, 2); jmpd(0x1015_d0ad, 0x29); goto l_0x1015_d0ad; /* jmp 0x1015d0ad */
        l_0x1015_d084:
            ii(0x1015_d084, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d087, 5); calld(0x1015_0b1a, -0xc572);            /* call 0x10150b1a */
            ii(0x1015_d08c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d08f, 4); cmp(memb_a32[ds, eax + 0x3d], 0x15);    /* cmp byte [eax+0x3d], 0x15 */
            ii(0x1015_d093, 2); if(jzd(0x1015_d084, -0x11)) goto l_0x1015_d084; /* jz 0x1015d084 */
            ii(0x1015_d095, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d098, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1015_d09c, 2); if(jnzd(0x1015_d0ad, 0xf)) goto l_0x1015_d0ad; /* jnz 0x1015d0ad */
            ii(0x1015_d09e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d0a1, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_d0a5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d0a8, 5); calld(0x1015_25a8, -0xab05);            /* call 0x101525a8 */
        l_0x1015_d0ad:
            ii(0x1015_d0ad, 5); jmpd(0x1015_d11f, 0x6d); goto l_0x1015_d11f; /* jmp 0x1015d11f */
        l_0x1015_d0b2:
            ii(0x1015_d0b2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_d0b7, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1015_d0bc, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d0bf, 5); calld(0x1016_2f96, 0x5ed2);             /* call 0x10162f96 */
            ii(0x1015_d0c4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d0c7, 5); calld(0x1015_ccd1, -0x3fb);             /* call 0x1015ccd1 */
            ii(0x1015_d0cc, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_d0d0, 2); jmpd(0x1015_d11f, 0x4d); goto l_0x1015_d11f; /* jmp 0x1015d11f */
        l_0x1015_d0d2:
            ii(0x1015_d0d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d0d4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d0d7, 5); calld(0x1014_eea8, -0xe234);            /* call 0x1014eea8 */
            ii(0x1015_d0dc, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d0df, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_d0e3, 2); jmpd(0x1015_d11f, 0x3a); goto l_0x1015_d11f; /* jmp 0x1015d11f */
        l_0x1015_d0e5:
            ii(0x1015_d0e5, 2); jmpd(0x1015_d11f, 0x38); goto l_0x1015_d11f; /* jmp 0x1015d11f */
        l_0x1015_d0e7:
            ii(0x1015_d0e7, 3); mov(al, memb_a32[ss, ebp - 0x30]);      /* mov al, [ebp-0x30] */
            ii(0x1015_d0ea, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
            ii(0x1015_d0ed, 4); cmp(memb_a32[ss, ebp - 0x34], 0x4);     /* cmp byte [ebp-0x34], 0x4 */
            ii(0x1015_d0f1, 2); if(jbd(0x1015_d117, 0x24)) goto l_0x1015_d117; /* jb 0x1015d117 */
            ii(0x1015_d0f3, 4); cmp(memb_a32[ss, ebp - 0x34], 0x4);     /* cmp byte [ebp-0x34], 0x4 */
            ii(0x1015_d0f7, 6); if(jbed(0x1015_d071, -0x8c)) goto l_0x1015_d071; /* jbe 0x1015d071 */
            ii(0x1015_d0fd, 4); cmp(memb_a32[ss, ebp - 0x34], 0x7);     /* cmp byte [ebp-0x34], 0x7 */
            ii(0x1015_d101, 2); if(jbd(0x1015_d115, 0x12)) goto l_0x1015_d115; /* jb 0x1015d115 */
            ii(0x1015_d103, 4); cmp(memb_a32[ss, ebp - 0x34], 0x7);     /* cmp byte [ebp-0x34], 0x7 */
            ii(0x1015_d107, 2); if(jbed(0x1015_d0b2, -0x57)) goto l_0x1015_d0b2; /* jbe 0x1015d0b2 */
            ii(0x1015_d109, 4); cmp(memb_a32[ss, ebp - 0x34], 0xb);     /* cmp byte [ebp-0x34], 0xb */
            ii(0x1015_d10d, 6); if(jzd(0x1015_d071, -0xa2)) goto l_0x1015_d071; /* jz 0x1015d071 */
            ii(0x1015_d113, 2); jmpd(0x1015_d0e5, -0x30); goto l_0x1015_d0e5; /* jmp 0x1015d0e5 */
        l_0x1015_d115:
            ii(0x1015_d115, 2); jmpd(0x1015_d0e5, -0x32); goto l_0x1015_d0e5; /* jmp 0x1015d0e5 */
        l_0x1015_d117:
            ii(0x1015_d117, 4); cmp(memb_a32[ss, ebp - 0x34], 0x2);     /* cmp byte [ebp-0x34], 0x2 */
            ii(0x1015_d11b, 2); if(jzd(0x1015_d0d2, -0x4b)) goto l_0x1015_d0d2; /* jz 0x1015d0d2 */
            ii(0x1015_d11d, 2); jmpd(0x1015_d0e5, -0x3a); goto l_0x1015_d0e5; /* jmp 0x1015d0e5 */
        l_0x1015_d11f:
            ii(0x1015_d11f, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1015_d122, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d125, 5); calld(0x1014_edfa, -0xe330);            /* call 0x1014edfa */
            ii(0x1015_d12a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d12c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d12f, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_d132, 5); calld(0x1007_6a34, -0xe_6703);          /* call 0x10076a34 */
            ii(0x1015_d137, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_d13c, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1015_d141, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d144, 5); calld(0x1016_2f96, 0x5e4d);             /* call 0x10162f96 */
            ii(0x1015_d149, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d14c, 5); calld(0x1015_287d, -0xa8d4);            /* call 0x1015287d */
            ii(0x1015_d151, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1015_d154, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1015_d157, 3); mov(memb_a32[ds, edx + 0x58], al);      /* mov [edx+0x58], al */
            ii(0x1015_d15a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_d15f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d162, 5); calld(0x1007_1838, -0xe_b92f);          /* call 0x10071838 */
            ii(0x1015_d167, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d169, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_d16c, 5); calld(0x1007_6600, -0xe_6b71);          /* call 0x10076600 */
            ii(0x1015_d171, 5); calld(0x1007_1838, -0xe_b93e);          /* call 0x10071838 */
            ii(0x1015_d176, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d179, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_d17c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_d17e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_d181, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d184, 5); calld(0x100a_9060, -0xb_4129);          /* call 0x100a9060 */
            ii(0x1015_d189, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d18c, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_d18f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_d194, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_d19a, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_d1a0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_d1a5, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_d1a8, 2); if(jnzd(0x1015_d1b1, 0x7)) goto l_0x1015_d1b1; /* jnz 0x1015d1b1 */
            ii(0x1015_d1aa, 7); mov(memb_a32[ds, 0x101c_391b], 0x1);    /* mov byte [0x101c391b], 0x1 */
        l_0x1015_d1b1:
            ii(0x1015_d1b1, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1015_d1b5, 2); if(jzd(0x1015_d1f4, 0x3d)) goto l_0x1015_d1f4; /* jz 0x1015d1f4 */
            ii(0x1015_d1b7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d1ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d1bc, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_d1bf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_d1c1, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_d1c6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_d1c8, 2); if(jnzd(0x1015_d1d0, 0x6)) goto l_0x1015_d1d0; /* jnz 0x1015d1d0 */
            ii(0x1015_d1ca, 4); mov(memb_a32[ss, ebp - 0x38], 0x1);     /* mov byte [ebp-0x38], 0x1 */
            ii(0x1015_d1ce, 2); jmpd(0x1015_d1d4, 0x4); goto l_0x1015_d1d4; /* jmp 0x1015d1d4 */
        l_0x1015_d1d0:
            ii(0x1015_d1d0, 4); mov(memb_a32[ss, ebp - 0x38], 0);       /* mov byte [ebp-0x38], 0x0 */
        l_0x1015_d1d4:
            ii(0x1015_d1d4, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_d1d6, 3); mov(cl, memb_a32[ss, ebp - 0x38]);      /* mov cl, [ebp-0x38] */
            ii(0x1015_d1d9, 3); mov(ebx, memd_a32[ss, ebp - 0x18]);     /* mov ebx, [ebp-0x18] */
            ii(0x1015_d1dc, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d1df, 5); calld(0x1007_6204, -0xe_6fe0);          /* call 0x10076204 */
            ii(0x1015_d1e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d1e6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d1e9, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_d1ec, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_d1ee, 1); cwde();                                 /* cwde */
            ii(0x1015_d1ef, 5); calld(0x100a_1ea3, -0xb_b351);          /* call 0x100a1ea3 */
        l_0x1015_d1f4:
            ii(0x1015_d1f4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d1f6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_d1f9, 5); calld(0x1007_5f2c, -0xe_72d2);          /* call 0x10075f2c */
            ii(0x1015_d1fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d200, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d203, 5); calld(0x1007_5f2c, -0xe_72dc);          /* call 0x10075f2c */
            ii(0x1015_d208, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_d20a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_d20b, 1); popd(edi);                              /* pop edi */
            ii(0x1015_d20c, 1); popd(esi);                              /* pop esi */
            ii(0x1015_d20d, 1); popd(edx);                              /* pop edx */
            ii(0x1015_d20e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_d20f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_d210, 1); retd(); return;                         /* ret */
        }
    }
}
