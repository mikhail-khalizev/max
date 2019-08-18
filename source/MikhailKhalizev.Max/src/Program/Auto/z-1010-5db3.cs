using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a1d51a67-f402-4ca9-b576-bec94effb6f9")]
        public void Method_1010_5db3()
        {
            ii(0x1010_5db3, 5); pushd(0xd0);                            /* push 0xd0 */
            ii(0x1010_5db8, 5); calld(Definitions.sys_check_available_stack_size, 0x5_ff95); /* call 0x10165d52 */
            ii(0x1010_5dbd, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_5dbe, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_5dbf, 1); pushd(edx);                             /* push edx */
            ii(0x1010_5dc0, 1); pushd(esi);                             /* push esi */
            ii(0x1010_5dc1, 1); pushd(edi);                             /* push edi */
            ii(0x1010_5dc2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_5dc3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_5dc5, 6); sub(esp, 0xa8);                         /* sub esp, 0xa8 */
            ii(0x1010_5dcb, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_5dce, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1010_5dd3, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1010_5dd6, 5); calld(Definitions.sys_strcpy, 0x6_00f4); /* call 0x10165ecf */
            ii(0x1010_5ddb, 5); mov(edx, StringDefinitions.MaxIni);     /* mov edx, 0x101a3a80 */
            ii(0x1010_5de0, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1010_5de3, 5); calld(Definitions.sys_strcat, 0x6_0149); /* call 0x10165f31 */
            ii(0x1010_5de8, 5); mov(edx, StringDefinitions.Rt2);        /* mov edx, 0x101a3a88 */
            ii(0x1010_5ded, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1010_5df0, 5); calld(Definitions.sys_fopen, 0x6_c585); /* call 0x1017237a */
            ii(0x1010_5df5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_5df8, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_5dfc, 6); if(jnzd(0x1010_5f25, 0x123)) goto l_0x1010_5f25; /* jnz 0x10105f25 */
            ii(0x1010_5e02, 5); mov(eax, StringDefinitions.ManderIniFileNotFoundUsingDefaults); /* mov eax, 0x101a3a8b */
            ii(0x1010_5e07, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5e08, 5); calld(Definitions.sys_printf, 0x6_682f); /* call 0x1016c63c */
            ii(0x1010_5e0d, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1010_5e10, 5); mov(edx, StringDefinitions.Wt);         /* mov edx, 0x101a3abc */
            ii(0x1010_5e15, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1010_5e18, 5); calld(Definitions.sys_fopen, 0x6_c55d); /* call 0x1017237a */
            ii(0x1010_5e1d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_5e20, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_5e24, 2); if(jnzd(0x1010_5e3e, 0x18)) goto l_0x1010_5e3e; /* jnz 0x10105e3e */
            ii(0x1010_5e26, 5); mov(eax, StringDefinitions.UnableToWriteFileDiskFull); /* mov eax, 0x101a3abf */
            ii(0x1010_5e2b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5e2c, 5); calld(Definitions.sys_printf, 0x6_680b); /* call 0x1016c63c */
            ii(0x1010_5e31, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1010_5e34, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1010_5e39, 5); calld(0x100e_f3a0, -0x1_6a9e);          /* call 0x100ef3a0 */
        l_0x1010_5e3e:
            ii(0x1010_5e3e, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_5e45, 2); jmpd(0x1010_5e4d, 0x6); goto l_0x1010_5e4d; /* jmp 0x10105e4d */
        l_0x1010_5e47:
            ii(0x1010_5e47, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5e4a, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1010_5e4d:
            ii(0x1010_5e4d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5e51, 3); cmp(eax, 0x76);                         /* cmp eax, 0x76 */
            ii(0x1010_5e54, 6); if(jged(0x1010_5f25, 0xcb)) goto l_0x1010_5f25; /* jge 0x10105f25 */
            ii(0x1010_5e5a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5e5e, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_5e61, 7); test(memb_a32[ds, eax + 0x101b_8b88], 0x1); /* test byte [eax+0x101b8b88], 0x1 */
            ii(0x1010_5e68, 2); if(jzd(0x1010_5ebd, 0x53)) goto l_0x1010_5ebd; /* jz 0x10105ebd */
            ii(0x1010_5e6a, 5); cmp(memw_a32[ss, ebp - 0x8], 0);        /* cmp word [ebp-0x8], 0x0 */
            ii(0x1010_5e6f, 2); if(jzd(0x1010_5e83, 0x12)) goto l_0x1010_5e83; /* jz 0x10105e83 */
            ii(0x1010_5e71, 5); mov(edx, StringDefinitions.Control6);   /* mov edx, 0x101a3ae4 */
            ii(0x1010_5e76, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5e7c, 5); calld(Definitions.sys_strcpy, 0x6_004e); /* call 0x10165ecf */
            ii(0x1010_5e81, 2); jmpd(0x1010_5e93, 0x10); goto l_0x1010_5e93; /* jmp 0x10105e93 */
        l_0x1010_5e83:
            ii(0x1010_5e83, 5); mov(edx, StringDefinitions.Control9);   /* mov edx, 0x101a3ae7 */
            ii(0x1010_5e88, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5e8e, 5); calld(Definitions.sys_strcpy, 0x6_003c); /* call 0x10165ecf */
        l_0x1010_5e93:
            ii(0x1010_5e93, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5e97, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_5e9a, 6); mov(edx, memd_a32[ds, eax + 0x101b_8b80]); /* mov edx, [eax+0x101b8b80] */
            ii(0x1010_5ea0, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5ea6, 5); calld(Definitions.sys_strcat, 0x6_0086); /* call 0x10165f31 */
            ii(0x1010_5eab, 5); mov(edx, StringDefinitions.Control7);   /* mov edx, 0x101a3ae9 */
            ii(0x1010_5eb0, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5eb6, 5); calld(Definitions.sys_strcat, 0x6_0076); /* call 0x10165f31 */
            ii(0x1010_5ebb, 2); jmpd(0x1010_5efd, 0x40); goto l_0x1010_5efd; /* jmp 0x10105efd */
        l_0x1010_5ebd:
            ii(0x1010_5ebd, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_5ec1, 3); lea(edx, edx + edx * 8);                /* lea edx, [edx+edx*8] */
            ii(0x1010_5ec4, 6); mov(edx, memd_a32[ds, edx + 0x101b_8b80]); /* mov edx, [edx+0x101b8b80] */
            ii(0x1010_5eca, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5ed0, 5); calld(Definitions.sys_strcpy, 0x5_fffa); /* call 0x10165ecf */
            ii(0x1010_5ed5, 5); mov(edx, StringDefinitions.Control10);  /* mov edx, 0x101a3aeb */
            ii(0x1010_5eda, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5ee0, 5); calld(Definitions.sys_strcat, 0x6_004c); /* call 0x10165f31 */
            ii(0x1010_5ee5, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_5ee9, 3); lea(edx, edx + edx * 8);                /* lea edx, [edx+edx*8] */
            ii(0x1010_5eec, 6); mov(edx, memd_a32[ds, edx + 0x101b_8b84]); /* mov edx, [edx+0x101b8b84] */
            ii(0x1010_5ef2, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5ef8, 5); calld(Definitions.sys_strcat, 0x6_0034); /* call 0x10165f31 */
        l_0x1010_5efd:
            ii(0x1010_5efd, 5); mov(edx, StringDefinitions.Control8);   /* mov edx, 0x101a3aed */
            ii(0x1010_5f02, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5f08, 5); calld(Definitions.sys_strcat, 0x6_0024); /* call 0x10165f31 */
            ii(0x1010_5f0d, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1010_5f13, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5f14, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5f17, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5f18, 5); calld(/* sys */ 0x1017_913b, 0x7_321e); /* call 0x1017913b */
            ii(0x1010_5f1d, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_5f20, 5); jmpd(0x1010_5e47, -0xde); goto l_0x1010_5e47; /* jmp 0x10105e47 */
        l_0x1010_5f25:
            ii(0x1010_5f25, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5f28, 5); calld(Definitions.sys_fclose, 0x6_c13c); /* call 0x10172069 */
            ii(0x1010_5f2d, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1010_5f30, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5f31, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5f34, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5f35, 5); calld(0x1012_346f, 0x1_d535);           /* call 0x1012346f */
            ii(0x1010_5f3a, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_5f3d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5f3f, 2); if(jnzd(0x1010_5f4b, 0xa)) goto l_0x1010_5f4b; /* jnz 0x10105f4b */
            ii(0x1010_5f41, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1010_5f46, 5); calld(0x100e_f3a0, -0x1_6bab);          /* call 0x100ef3a0 */
        l_0x1010_5f4b:
            ii(0x1010_5f4b, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_5f52, 2); jmpd(0x1010_5f5a, 0x6); goto l_0x1010_5f5a; /* jmp 0x10105f5a */
        l_0x1010_5f54:
            ii(0x1010_5f54, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5f57, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1010_5f5a:
            ii(0x1010_5f5a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5f5e, 3); cmp(eax, 0x76);                         /* cmp eax, 0x76 */
            ii(0x1010_5f61, 6); if(jged(0x1010_604b, 0xe4)) goto l_0x1010_604b; /* jge 0x1010604b */
            ii(0x1010_5f67, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5f6b, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_5f6e, 7); test(memb_a32[ds, eax + 0x101b_8b88], 0x1); /* test byte [eax+0x101b8b88], 0x1 */
            ii(0x1010_5f75, 2); if(jzd(0x1010_5f95, 0x1e)) goto l_0x1010_5f95; /* jz 0x10105f95 */
            ii(0x1010_5f77, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5f7b, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_5f7e, 6); pushd(memd_a32[ds, eax + 0x101b_8b80]); /* push dword [eax+0x101b8b80] */
            ii(0x1010_5f84, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5f87, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5f88, 5); calld(0x1012_36fa, 0x1_d76d);           /* call 0x101236fa */
            ii(0x1010_5f8d, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_5f90, 5); jmpd(0x1010_6046, 0xb1); goto l_0x1010_6046; /* jmp 0x10106046 */
        l_0x1010_5f95:
            ii(0x1010_5f95, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5f99, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_5f9c, 7); test(memb_a32[ds, eax + 0x101b_8b88], 0x2); /* test byte [eax+0x101b8b88], 0x2 */
            ii(0x1010_5fa3, 6); if(jzd(0x1010_6046, 0x9d)) goto l_0x1010_6046; /* jz 0x10106046 */
            ii(0x1010_5fa9, 6); lea(eax, ebp - 0xa8);                   /* lea eax, [ebp-0xa8] */
            ii(0x1010_5faf, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5fb0, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5fb4, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_5fb7, 6); pushd(memd_a32[ds, eax + 0x101b_8b80]); /* push dword [eax+0x101b8b80] */
            ii(0x1010_5fbd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5fc0, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5fc1, 5); calld(0x1012_4113, 0x1_e14d);           /* call 0x10124113 */
            ii(0x1010_5fc6, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_5fc9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5fcb, 2); if(jzd(0x1010_5fe1, 0x14)) goto l_0x1010_5fe1; /* jz 0x10105fe1 */
            ii(0x1010_5fcd, 6); mov(ebx, memd_a32[ss, ebp - 0xa8]);     /* mov ebx, [ebp-0xa8] */
            ii(0x1010_5fd3, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_5fd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5fda, 5); calld(0x1010_610a, 0x12b);              /* call 0x1010610a */
            ii(0x1010_5fdf, 2); jmpd(0x1010_6046, 0x65); goto l_0x1010_6046; /* jmp 0x10106046 */
        l_0x1010_5fe1:
            ii(0x1010_5fe1, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_5fe6, 5); mov(edx, StringDefinitions._0x);        /* mov edx, 0x101a3aef */
            ii(0x1010_5feb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5fef, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_5ff2, 6); mov(eax, memd_a32[ds, eax + 0x101b_8b84]); /* mov eax, [eax+0x101b8b84] */
            ii(0x1010_5ff8, 5); calld(Definitions.sys_strncmp, 0x7_315f); /* call 0x1017915c */
            ii(0x1010_5ffd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5fff, 2); if(jnzd(0x1010_6026, 0x25)) goto l_0x1010_6026; /* jnz 0x10106026 */
            ii(0x1010_6001, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_6005, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_6008, 6); mov(eax, memd_a32[ds, eax + 0x101b_8b84]); /* mov eax, [eax+0x101b8b84] */
            ii(0x1010_600e, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1010_6011, 5); calld(0x1012_47af, 0x1_e799);           /* call 0x101247af */
            ii(0x1010_6016, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_6018, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_601c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_601f, 5); calld(0x1010_610a, 0xe6);               /* call 0x1010610a */
            ii(0x1010_6024, 2); jmpd(0x1010_6046, 0x20); goto l_0x1010_6046; /* jmp 0x10106046 */
        l_0x1010_6026:
            ii(0x1010_6026, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_602a, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_602d, 6); mov(eax, memd_a32[ds, eax + 0x101b_8b84]); /* mov eax, [eax+0x101b8b84] */
            ii(0x1010_6033, 5); calld(/* sys */ 0x1017_90ce, 0x7_3096); /* call 0x101790ce */
            ii(0x1010_6038, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_603a, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_603e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6041, 5); calld(0x1010_610a, 0xc4);               /* call 0x1010610a */
        l_0x1010_6046:
            ii(0x1010_6046, 5); jmpd(0x1010_5f54, -0xf7); goto l_0x1010_5f54; /* jmp 0x10105f54 */
        l_0x1010_604b:
            ii(0x1010_604b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_604d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_604e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_604f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6050, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6051, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6052, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6053, 1); retd(); return;                         /* ret */
        }
    }
}
