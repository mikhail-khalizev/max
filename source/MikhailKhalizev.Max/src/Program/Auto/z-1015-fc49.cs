using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8257a774-2784-42d9-8649-ba355a683f94")]
        public void Method_1015_fc49()
        {
            ii(0x1015_fc49, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1015_fc4e, 5); calld(Definitions.sys_check_available_stack_size, 0x60ff); /* call 0x10165d52 */
            ii(0x1015_fc53, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_fc54, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_fc55, 1); pushd(edx);                             /* push edx */
            ii(0x1015_fc56, 1); pushd(esi);                             /* push esi */
            ii(0x1015_fc57, 1); pushd(edi);                             /* push edi */
            ii(0x1015_fc58, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_fc59, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_fc5b, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_fc61, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_fc64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fc67, 5); calld(0x1007_611c, -0xe_9b50);          /* call 0x1007611c */
            ii(0x1015_fc6c, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1015_fc6f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_fc71, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_fc73, 5); calld(0x1007_66ac, -0xe_95cc);          /* call 0x100766ac */
            ii(0x1015_fc78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fc7a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fc7d, 5); calld(0x1013_ad71, -0x2_4f11);          /* call 0x1013ad71 */
            ii(0x1015_fc82, 2); test(al, al);                           /* test al, al */
            ii(0x1015_fc84, 2); if(jzd(0x1015_fc8f, 0x9)) goto l_0x1015_fc8f; /* jz 0x1015fc8f */
            ii(0x1015_fc86, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1015_fc8d, 2); jmpd(0x1015_fca8, 0x19); goto l_0x1015_fca8; /* jmp 0x1015fca8 */
        l_0x1015_fc8f:
            ii(0x1015_fc8f, 5); mov(ecx, 0x17fd);                       /* mov ecx, 0x17fd */
            ii(0x1015_fc94, 5); mov(ebx, StringDefinitions.UnitsmgrCpp7); /* mov ebx, 0x101b28ba */
            ii(0x1015_fc99, 5); mov(edx, StringDefinitions.ChildNotEqual0); /* mov edx, 0x101b28c7 */
            ii(0x1015_fc9e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_fca0, 5); calld(Definitions.sys_assert, 0x60ed);  /* call 0x10165d92 */
            ii(0x1015_fca5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1015_fca8:
            ii(0x1015_fca8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fcab, 5); calld(0x1007_6574, -0xe_973c);          /* call 0x10076574 */
            ii(0x1015_fcb0, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1015_fcb4, 2); if(jnzd(0x1015_fcde, 0x28)) goto l_0x1015_fcde; /* jnz 0x1015fcde */
            ii(0x1015_fcb6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fcb9, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_fcbc, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_fcbe, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_fcc1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_fcc3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fcc6, 3); mov(edx, memd_a32[ds, eax + 0x41]);     /* mov edx, [eax+0x41] */
            ii(0x1015_fcc9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_fccc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fccf, 3); mov(eax, memd_a32[ds, eax + 0x3f]);     /* mov eax, [eax+0x3f] */
            ii(0x1015_fcd2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_fcd5, 5); calld(0x1011_a3f7, -0x4_58e3);          /* call 0x1011a3f7 */
            ii(0x1015_fcda, 2); test(al, al);                           /* test al, al */
            ii(0x1015_fcdc, 2); if(jnzd(0x1015_fce0, 0x2)) goto l_0x1015_fce0; /* jnz 0x1015fce0 */
        l_0x1015_fcde:
            ii(0x1015_fcde, 2); jmpd(0x1015_fcf7, 0x17); goto l_0x1015_fcf7; /* jmp 0x1015fcf7 */
        l_0x1015_fce0:
            ii(0x1015_fce0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fce3, 5); calld(0x1014_f08b, -0x1_0c5d);          /* call 0x1014f08b */
            ii(0x1015_fce8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fcea, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fced, 5); calld(0x1007_5f2c, -0xe_9dc6);          /* call 0x10075f2c */
            ii(0x1015_fcf2, 5); jmpd(0x1016_002f, 0x338); goto l_0x1016_002f; /* jmp 0x1016002f */
        l_0x1015_fcf7:
            ii(0x1015_fcf7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fcfa, 4); dec(memw_a32[ds, eax + 0x52]);          /* dec word [eax+0x52] */
            ii(0x1015_fcfe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fd00, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd03, 5); calld(0x1008_a998, -0xd_5370);          /* call 0x1008a998 */
            ii(0x1015_fd08, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x1015_fd0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd0e, 5); calld(0x1015_0a5f, -0xf2b4);            /* call 0x10150a5f */
            ii(0x1015_fd13, 5); calld(Definitions.my_2_get_count, -0xd_49b0); /* call 0x1008b368 */
            ii(0x1015_fd18, 1); cwde();                                 /* cwde */
            ii(0x1015_fd19, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_fd1b, 2); if(jled(0x1015_fd26, 0x9)) goto l_0x1015_fd26; /* jle 0x1015fd26 */
            ii(0x1015_fd1d, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1015_fd24, 2); jmpd(0x1015_fd2d, 0x7); goto l_0x1015_fd2d; /* jmp 0x1015fd2d */
        l_0x1015_fd26:
            ii(0x1015_fd26, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1015_fd2d:
            ii(0x1015_fd2d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_fd30, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_fd33, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fd35, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fd38, 5); calld(0x1008_8b04, -0xd_7239);          /* call 0x10088b04 */
            ii(0x1015_fd3d, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1015_fd41, 2); if(jzd(0x1015_fd7c, 0x39)) goto l_0x1015_fd7c; /* jz 0x1015fd7c */
            ii(0x1015_fd43, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd46, 4); mov(memb_a32[ds, eax + 0x3d], 0x4);     /* mov byte [eax+0x3d], 0x4 */
            ii(0x1015_fd4a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd4d, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_fd51, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd54, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_fd57, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_fd59, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_fd5c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd5f, 5); calld(0x1015_0a9e, -0xf2c6);            /* call 0x10150a9e */
            ii(0x1015_fd64, 1); cwde();                                 /* cwde */
            ii(0x1015_fd65, 5); calld(0x100d_4b64, -0x8_b206);          /* call 0x100d4b64 */
            ii(0x1015_fd6a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_fd6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd6f, 3); mov(memb_a32[ds, eax + 0x45], dl);      /* mov [eax+0x45], dl */
            ii(0x1015_fd72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd75, 5); calld(0x1015_1565, -0xe815);            /* call 0x10151565 */
            ii(0x1015_fd7a, 2); jmpd(0x1015_fd8a, 0xe); goto l_0x1015_fd8a; /* jmp 0x1015fd8a */
        l_0x1015_fd7c:
            ii(0x1015_fd7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd7f, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_fd83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fd86, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
        l_0x1015_fd8a:
            ii(0x1015_fd8a, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_fd8f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fd92, 5); calld(0x1008_b530, -0xd_4867);          /* call 0x1008b530 */
            ii(0x1015_fd97, 2); test(al, al);                           /* test al, al */
            ii(0x1015_fd99, 2); if(jzd(0x1015_fda0, 0x5)) goto l_0x1015_fda0; /* jz 0x1015fda0 */
            ii(0x1015_fd9b, 5); calld(0x100e_6236, -0x7_9b6a);          /* call 0x100e6236 */
        l_0x1015_fda0:
            ii(0x1015_fda0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fda3, 5); calld(0x1007_6574, -0xe_9834);          /* call 0x10076574 */
            ii(0x1015_fda8, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1015_fdac, 2); if(jzd(0x1015_fe24, 0x76)) goto l_0x1015_fe24; /* jz 0x1015fe24 */
            ii(0x1015_fdae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fdb0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fdb3, 5); calld(0x1007_6574, -0xe_9844);          /* call 0x10076574 */
            ii(0x1015_fdb8, 5); calld(0x1008_a998, -0xd_5425);          /* call 0x1008a998 */
            ii(0x1015_fdbd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fdc0, 5); calld(0x1007_6574, -0xe_9851);          /* call 0x10076574 */
            ii(0x1015_fdc5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_fdc8, 4); mov(dx, memw_a32[ds, edx + 0x41]);      /* mov dx, [edx+0x41] */
            ii(0x1015_fdcc, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1015_fdd0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fdd3, 5); calld(0x1007_6574, -0xe_9864);          /* call 0x10076574 */
            ii(0x1015_fdd8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_fddb, 4); mov(dx, memw_a32[ds, edx + 0x43]);      /* mov dx, [edx+0x43] */
            ii(0x1015_fddf, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1015_fde3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fde6, 5); calld(0x1007_6574, -0xe_9877);          /* call 0x10076574 */
            ii(0x1015_fdeb, 4); mov(memb_a32[ds, eax + 0x3d], 0x2);     /* mov byte [eax+0x3d], 0x2 */
            ii(0x1015_fdef, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fdf2, 5); calld(0x1007_6574, -0xe_9883);          /* call 0x10076574 */
            ii(0x1015_fdf7, 4); mov(memb_a32[ds, eax + 0x3e], 0);       /* mov byte [eax+0x3e], 0x0 */
            ii(0x1015_fdfb, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_fe00, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe03, 5); calld(0x1007_6600, -0xe_9808);          /* call 0x10076600 */
            ii(0x1015_fe08, 5); calld(0x1007_1838, -0xe_e5d5);          /* call 0x10071838 */
            ii(0x1015_fe0d, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_fe12, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe15, 5); calld(0x1007_65d0, -0xe_984a);          /* call 0x100765d0 */
            ii(0x1015_fe1a, 5); calld(0x1016_2f0a, 0x30eb);             /* call 0x10162f0a */
            ii(0x1015_fe1f, 5); jmpd(0x1015_ff91, 0x16d); goto l_0x1015_ff91; /* jmp 0x1015ff91 */
        l_0x1015_fe24:
            ii(0x1015_fe24, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fe27, 3); mov(ebx, memd_a32[ds, eax + 0x41]);     /* mov ebx, [eax+0x41] */
            ii(0x1015_fe2a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_fe2d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_fe30, 3); mov(edx, memd_a32[ds, edx + 0x3f]);     /* mov edx, [edx+0x3f] */
            ii(0x1015_fe33, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_fe36, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe39, 5); calld(0x1007_6600, -0xe_983e);          /* call 0x10076600 */
            ii(0x1015_fe3e, 5); calld(0x1015_bd55, -0x40ee);            /* call 0x1015bd55 */
            ii(0x1015_fe43, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe46, 5); calld(0x1007_6574, -0xe_98d7);          /* call 0x10076574 */
            ii(0x1015_fe4b, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_fe4f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe52, 5); calld(0x1007_6574, -0xe_98e3);          /* call 0x10076574 */
            ii(0x1015_fe57, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_fe5b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe5e, 5); calld(0x1007_6574, -0xe_98ef);          /* call 0x10076574 */
            ii(0x1015_fe63, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_fe68, 2); if(jzd(0x1015_fe79, 0xf)) goto l_0x1015_fe79; /* jz 0x1015fe79 */
            ii(0x1015_fe6a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe6d, 5); calld(0x1007_6574, -0xe_98fe);          /* call 0x10076574 */
            ii(0x1015_fe72, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1015_fe77, 2); if(jnzd(0x1015_fe7b, 0x2)) goto l_0x1015_fe7b; /* jnz 0x1015fe7b */
        l_0x1015_fe79:
            ii(0x1015_fe79, 2); jmpd(0x1015_fe8e, 0x13); goto l_0x1015_fe8e; /* jmp 0x1015fe8e */
        l_0x1015_fe7b:
            ii(0x1015_fe7b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe7e, 5); calld(0x1007_6574, -0xe_990f);          /* call 0x10076574 */
            ii(0x1015_fe83, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x1015_fe88, 6); if(jnzd(0x1015_ff17, 0x89)) goto l_0x1015_ff17; /* jnz 0x1015ff17 */
        l_0x1015_fe8e:
            ii(0x1015_fe8e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fe91, 5); calld(0x1007_6574, -0xe_9922);          /* call 0x10076574 */
            ii(0x1015_fe96, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_fe9b, 2); if(jnzd(0x1015_fead, 0x10)) goto l_0x1015_fead; /* jnz 0x1015fead */
            ii(0x1015_fe9d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fea0, 5); calld(0x1007_6574, -0xe_9931);          /* call 0x10076574 */
            ii(0x1015_fea5, 6); mov(memw_a32[ds, eax + 0x33], 0);       /* mov word [eax+0x33], 0x0 */
            ii(0x1015_feab, 2); jmpd(0x1015_feec, 0x3f); goto l_0x1015_feec; /* jmp 0x1015feec */
        l_0x1015_fead:
            ii(0x1015_fead, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_feb0, 5); calld(0x1007_6574, -0xe_9941);          /* call 0x10076574 */
            ii(0x1015_feb5, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1015_feba, 2); if(jnzd(0x1015_fecc, 0x10)) goto l_0x1015_fecc; /* jnz 0x1015fecc */
            ii(0x1015_febc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_febf, 5); calld(0x1007_6574, -0xe_9950);          /* call 0x10076574 */
            ii(0x1015_fec4, 6); mov(memw_a32[ds, eax + 0x33], 0);       /* mov word [eax+0x33], 0x0 */
            ii(0x1015_feca, 2); jmpd(0x1015_feec, 0x20); goto l_0x1015_feec; /* jmp 0x1015feec */
        l_0x1015_fecc:
            ii(0x1015_fecc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fecf, 5); calld(0x1007_6574, -0xe_9960);          /* call 0x10076574 */
            ii(0x1015_fed4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_fed6, 6); mov(memw_a32[ds, edx + 0x33], 0x8);     /* mov word [edx+0x33], 0x8 */
            ii(0x1015_fedc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fedf, 5); calld(0x1007_6574, -0xe_9970);          /* call 0x10076574 */
            ii(0x1015_fee4, 4); mov(dx, memw_a32[ds, edx + 0x33]);      /* mov dx, [edx+0x33] */
            ii(0x1015_fee8, 4); mov(memw_a32[ds, eax + 0x33], dx);      /* mov [eax+0x33], dx */
        l_0x1015_feec:
            ii(0x1015_feec, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_feef, 5); calld(0x1007_6574, -0xe_9980);          /* call 0x10076574 */
            ii(0x1015_fef4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fef6, 3); mov(dl, memb_a32[ds, eax + 0x29]);      /* mov dl, [eax+0x29] */
            ii(0x1015_fef9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_fefc, 5); calld(0x1007_6574, -0xe_998d);          /* call 0x10076574 */
            ii(0x1015_ff01, 4); mov(ax, memw_a32[ds, eax + 0x33]);      /* mov ax, [eax+0x33] */
            ii(0x1015_ff05, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_ff07, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_ff0a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_ff0d, 5); calld(0x1007_6574, -0xe_999e);          /* call 0x10076574 */
            ii(0x1015_ff12, 5); calld(0x1014_9b07, -0x1_6410);          /* call 0x10149b07 */
        l_0x1015_ff17:
            ii(0x1015_ff17, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_ff1a, 5); calld(0x1007_6574, -0xe_99ab);          /* call 0x10076574 */
            ii(0x1015_ff1f, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1015_ff22, 5); and(eax, 0x180);                        /* and eax, 0x180 */
            ii(0x1015_ff27, 5); cmp(eax, 0x80);                         /* cmp eax, 0x80 */
            ii(0x1015_ff2c, 2); if(jnzd(0x1015_ff60, 0x32)) goto l_0x1015_ff60; /* jnz 0x1015ff60 */
            ii(0x1015_ff2e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ff31, 3); mov(edx, memd_a32[ds, eax + 0x41]);     /* mov edx, [eax+0x41] */
            ii(0x1015_ff34, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_ff37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ff3a, 3); mov(eax, memd_a32[ds, eax + 0x3f]);     /* mov eax, [eax+0x3f] */
            ii(0x1015_ff3d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_ff40, 5); calld(0x1007_5034, -0xe_af11);          /* call 0x10075034 */
            ii(0x1015_ff45, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_ff48, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1015_ff4c, 2); if(jzd(0x1015_ff60, 0x12)) goto l_0x1015_ff60; /* jz 0x1015ff60 */
            ii(0x1015_ff4e, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1015_ff53, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1015_ff58, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_ff5b, 5); calld(0x1016_2f96, 0x3036);             /* call 0x10162f96 */
        l_0x1015_ff60:
            ii(0x1015_ff60, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_ff63, 5); calld(0x1007_6574, -0xe_99f4);          /* call 0x10076574 */
            ii(0x1015_ff68, 5); calld(0x1014_f1f2, -0x1_0d7b);          /* call 0x1014f1f2 */
            ii(0x1015_ff6d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_ff72, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_ff75, 5); calld(0x1007_6600, -0xe_997a);          /* call 0x10076600 */
            ii(0x1015_ff7a, 5); calld(0x1007_1838, -0xe_e747);          /* call 0x10071838 */
            ii(0x1015_ff7f, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_ff84, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_ff87, 5); calld(0x1007_6600, -0xe_998c);          /* call 0x10076600 */
            ii(0x1015_ff8c, 5); calld(0x1016_2f0a, 0x2f79);             /* call 0x10162f0a */
        l_0x1015_ff91:
            ii(0x1015_ff91, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_ff96, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_ff99, 5); calld(0x1008_b530, -0xd_4a6e);          /* call 0x1008b530 */
            ii(0x1015_ff9e, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ffa0, 2); if(jzd(0x1015_ffc9, 0x27)) goto l_0x1015_ffc9; /* jz 0x1015ffc9 */
            ii(0x1015_ffa2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_ffa5, 5); calld(0x1007_65d0, -0xe_99da);          /* call 0x100765d0 */
            ii(0x1015_ffaa, 5); calld(0x100f_f637, -0x6_0978);          /* call 0x100ff637 */
            ii(0x1015_ffaf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_ffb1, 6); mov(dl, memb_a32[ds, 0x101c_3889]);     /* mov dl, [0x101c3889] */
            ii(0x1015_ffb7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_ffb9, 5); mov(al, memb_a32[ds, 0x101c_388a]);     /* mov al, [0x101c388a] */
            ii(0x1015_ffbe, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1015_ffc0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_ffc2, 2); if(jzd(0x1015_ffc9, 0x5)) goto l_0x1015_ffc9; /* jz 0x1015ffc9 */
            ii(0x1015_ffc4, 5); calld(0x100f_f5c1, -0x6_0a08);          /* call 0x100ff5c1 */
        l_0x1015_ffc9:
            ii(0x1015_ffc9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ffcc, 5); calld(0x1015_26ac, -0xd925);            /* call 0x101526ac */
            ii(0x1015_ffd1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_ffd3, 2); if(jzd(0x1015_fff7, 0x22)) goto l_0x1015_fff7; /* jz 0x1015fff7 */
            ii(0x1015_ffd5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ffd8, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x1015_ffdd, 2); if(jzd(0x1015_ffe9, 0xa)) goto l_0x1015_ffe9; /* jz 0x1015ffe9 */
            ii(0x1015_ffdf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ffe2, 5); cmp(memw_a32[ds, eax + 0x8], 0x48);     /* cmp word [eax+0x8], 0x48 */
            ii(0x1015_ffe7, 2); if(jnzd(0x1015_ffeb, 0x2)) goto l_0x1015_ffeb; /* jnz 0x1015ffeb */
        l_0x1015_ffe9:
            ii(0x1015_ffe9, 2); jmpd(0x1015_fff5, 0xa); goto l_0x1015_fff5; /* jmp 0x1015fff5 */
        l_0x1015_ffeb:
            ii(0x1015_ffeb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ffee, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x1015_fff3, 2); if(jnzd(0x1015_fff7, 0x2)) goto l_0x1015_fff7; /* jnz 0x1015fff7 */
        l_0x1015_fff5:
            ii(0x1015_fff5, 2); jmpd(0x1015_fff9, 0x2); goto l_0x1015_fff9; /* jmp 0x1015fff9 */
        l_0x1015_fff7:
            ii(0x1015_fff7, 2); jmpd(0x1016_001d, 0x24); goto l_0x1016_001d; /* jmp 0x1016001d */
        l_0x1015_fff9:
            ii(0x1015_fff9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_fffc, 5); calld(0x1015_26ac, -0xd955);            /* call 0x101526ac */
            ii(0x1016_0001, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1016_0004, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1016_0007, 3); mov(ecx, memd_a32[ds, eax + 0x2]);      /* mov ecx, [eax+0x2] */
            ii(0x1016_000a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1016_000d, 5); calld(0x1007_65d0, -0xe_9a42);          /* call 0x100765d0 */
            ii(0x1016_0012, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_0014, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_0017, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1016_001a, 3); calld_abs(memd_a32[ds, ecx + 0x68]);    /* call dword [ecx+0x68] */
        l_0x1016_001d:
            ii(0x1016_001d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_0020, 5); calld(0x1014_9fa8, -0x1_607d);          /* call 0x10149fa8 */
            ii(0x1016_0025, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0027, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1016_002a, 5); calld(0x1007_5f2c, -0xe_a103);          /* call 0x10075f2c */
        l_0x1016_002f:
            ii(0x1016_002f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_0031, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_0032, 1); popd(edi);                              /* pop edi */
            ii(0x1016_0033, 1); popd(esi);                              /* pop esi */
            ii(0x1016_0034, 1); popd(edx);                              /* pop edx */
            ii(0x1016_0035, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_0036, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_0037, 1); retd(); return;                         /* ret */
        }
    }
}
