using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cc7e54a8-800e-4f89-9686-e358d291852f")]
        public void Method_1015_ec73()
        {
            ii(0x1015_ec73, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1015_ec78, 5); calld(Definitions.sys_check_available_stack_size, 0x70d5); /* call 0x10165d52 */
            ii(0x1015_ec7d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_ec7e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_ec7f, 1); pushd(edx);                             /* push edx */
            ii(0x1015_ec80, 1); pushd(esi);                             /* push esi */
            ii(0x1015_ec81, 1); pushd(edi);                             /* push edi */
            ii(0x1015_ec82, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_ec83, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_ec85, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1015_ec8b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_ec8e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_ec90, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_ec93, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_ec96, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_ec99, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_ec9d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_eca0, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xe_85b5); /* call 0x100766f0 */
            ii(0x1015_eca5, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_eca8, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_ecac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ecaf, 5); calld(0x1014_9fa8, -0x1_4d0c);          /* call 0x10149fa8 */
            ii(0x1015_ecb4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ecb7, 7); test(memd_a32[ds, eax + 0x12], 0x80_0018); /* test dword [eax+0x12], 0x800018 */
            ii(0x1015_ecbe, 2); if(jzd(0x1015_ecc9, 0x9)) goto l_0x1015_ecc9; /* jz 0x1015ecc9 */
            ii(0x1015_ecc0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ecc3, 4); test(memb_a32[ds, eax + 0x12], 0x1);    /* test byte [eax+0x12], 0x1 */
            ii(0x1015_ecc7, 2); if(jzd(0x1015_ecd8, 0xf)) goto l_0x1015_ecd8; /* jz 0x1015ecd8 */
        l_0x1015_ecc9:
            ii(0x1015_ecc9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_eccb, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ecce, 5); calld(0x1007_5f2c, -0xe_8da7);          /* call 0x10075f2c */
            ii(0x1015_ecd3, 5); jmpd(0x1015_f2c3, 0x5eb); goto l_0x1015_f2c3; /* jmp 0x1015f2c3 */
        l_0x1015_ecd8:
            ii(0x1015_ecd8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ecdb, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1015_ecdf, 2); if(jzd(0x1015_ecea, 0x9)) goto l_0x1015_ecea; /* jz 0x1015ecea */
            ii(0x1015_ece1, 7); mov(memd_a32[ss, ebp - 0x28], 0x2);     /* mov dword [ebp-0x28], 0x2 */
            ii(0x1015_ece8, 2); jmpd(0x1015_ecf1, 0x7); goto l_0x1015_ecf1; /* jmp 0x1015ecf1 */
        l_0x1015_ecea:
            ii(0x1015_ecea, 7); mov(memd_a32[ss, ebp - 0x28], 0x1);     /* mov dword [ebp-0x28], 0x1 */
        l_0x1015_ecf1:
            ii(0x1015_ecf1, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_ecf4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_ecf7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ecfa, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1015_ecfe, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_ed01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ed04, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1015_ed08, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_ed0b, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_ed0f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_ed15, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1015_ed1a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_ed1c, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x1015_ed1f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ed22, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_ed25, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_ed28, 5); calld(0x1015_ec1c, -0x111);             /* call 0x1015ec1c */
            ii(0x1015_ed2d, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ed2f, 2); if(jzd(0x1015_ed3b, 0xa)) goto l_0x1015_ed3b; /* jz 0x1015ed3b */
            ii(0x1015_ed31, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_ed34, 7); inc(memw_a32[ds, eax + 0x113]);         /* inc word [eax+0x113] */
        l_0x1015_ed3b:
            ii(0x1015_ed3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ed3e, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x1015_ed43, 2); if(jnzd(0x1015_ed4f, 0xa)) goto l_0x1015_ed4f; /* jnz 0x1015ed4f */
            ii(0x1015_ed45, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_ed48, 7); inc(memw_a32[ds, eax + 0x115]);         /* inc word [eax+0x115] */
        l_0x1015_ed4f:
            ii(0x1015_ed4f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ed52, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1015_ed56, 2); if(jzd(0x1015_ed62, 0xa)) goto l_0x1015_ed62; /* jz 0x1015ed62 */
            ii(0x1015_ed58, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_ed5b, 7); inc(memw_a32[ds, eax + 0x117]);         /* inc word [eax+0x117] */
        l_0x1015_ed62:
            ii(0x1015_ed62, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_ed64, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_ed67, 1); dec(eax);                               /* dec eax */
            ii(0x1015_ed68, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_ed6b, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1015_ed6f, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_ed73, 5); calld(0x1007_5331, -0xe_9a47);          /* call 0x10075331 */
            ii(0x1015_ed78, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ed7a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ed7d, 5); calld(0x1007_6630, -0xe_8752);          /* call 0x10076630 */
            ii(0x1015_ed82, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1015_ed84, 5); calld(0x1013_ad71, -0x2_4018);          /* call 0x1013ad71 */
            ii(0x1015_ed89, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ed8b, 6); if(jzd(0x1015_ee05, 0x74)) goto l_0x1015_ee05; /* jz 0x1015ee05 */
            ii(0x1015_ed91, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ed94, 4); or(memb_a32[ds, eax + 0x69], 0x1);      /* or byte [eax+0x69], 0x1 */
            ii(0x1015_ed98, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ed9b, 5); calld(0x1007_6574, -0xe_882c);          /* call 0x10076574 */
            ii(0x1015_eda0, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_eda7, 2); if(jzd(0x1015_edb7, 0xe)) goto l_0x1015_edb7; /* jz 0x1015edb7 */
            ii(0x1015_eda9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_edac, 5); calld(0x1007_6574, -0xe_883d);          /* call 0x10076574 */
            ii(0x1015_edb1, 4); or(memb_a32[ds, eax + 0x69], 0x10);     /* or byte [eax+0x69], 0x10 */
            ii(0x1015_edb5, 2); jmpd(0x1015_edf8, 0x41); goto l_0x1015_edf8; /* jmp 0x1015edf8 */
        l_0x1015_edb7:
            ii(0x1015_edb7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_edba, 1); dec(eax);                               /* dec eax */
            ii(0x1015_edbb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_edbe, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_edc1, 1); inc(eax);                               /* inc eax */
            ii(0x1015_edc2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_edc5, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_edc9, 5); calld(0x1007_5331, -0xe_9a9d);          /* call 0x10075331 */
            ii(0x1015_edce, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_edd1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_edd3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_edd5, 5); calld(0x1007_6e00, -0xe_7fda);          /* call 0x10076e00 */
            ii(0x1015_edda, 2); test(al, al);                           /* test al, al */
            ii(0x1015_eddc, 2); if(jzd(0x1015_edec, 0xe)) goto l_0x1015_edec; /* jz 0x1015edec */
            ii(0x1015_edde, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ede1, 5); calld(0x1007_6574, -0xe_8872);          /* call 0x10076574 */
            ii(0x1015_ede6, 4); or(memb_a32[ds, eax + 0x69], 0x10);     /* or byte [eax+0x69], 0x10 */
            ii(0x1015_edea, 2); jmpd(0x1015_edf8, 0xc); goto l_0x1015_edf8; /* jmp 0x1015edf8 */
        l_0x1015_edec:
            ii(0x1015_edec, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_edef, 5); calld(0x1007_6574, -0xe_8880);          /* call 0x10076574 */
            ii(0x1015_edf4, 4); or(memb_a32[ds, eax + 0x69], 0x20);     /* or byte [eax+0x69], 0x20 */
        l_0x1015_edf8:
            ii(0x1015_edf8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_edfb, 5); calld(0x1007_6574, -0xe_888c);          /* call 0x10076574 */
            ii(0x1015_ee00, 5); calld(0x1014_9fa8, -0x1_4e5d);          /* call 0x10149fa8 */
        l_0x1015_ee05:
            ii(0x1015_ee05, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_ee07, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_ee0a, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_ee0d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_ee10, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1015_ee14, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_ee18, 5); calld(0x1007_5331, -0xe_9aec);          /* call 0x10075331 */
            ii(0x1015_ee1d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ee1f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ee22, 5); calld(0x1007_6630, -0xe_87f7);          /* call 0x10076630 */
            ii(0x1015_ee27, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1015_ee29, 5); calld(0x1013_ad71, -0x2_40bd);          /* call 0x1013ad71 */
            ii(0x1015_ee2e, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ee30, 6); if(jzd(0x1015_eeac, 0x76)) goto l_0x1015_eeac; /* jz 0x1015eeac */
            ii(0x1015_ee36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ee39, 4); or(memb_a32[ds, eax + 0x69], 0x10);     /* or byte [eax+0x69], 0x10 */
            ii(0x1015_ee3d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ee40, 5); calld(0x1007_6574, -0xe_88d1);          /* call 0x10076574 */
            ii(0x1015_ee45, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_ee4c, 2); if(jzd(0x1015_ee5c, 0xe)) goto l_0x1015_ee5c; /* jz 0x1015ee5c */
            ii(0x1015_ee4e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ee51, 5); calld(0x1007_6574, -0xe_88e2);          /* call 0x10076574 */
            ii(0x1015_ee56, 4); or(memb_a32[ds, eax + 0x69], 0x1);      /* or byte [eax+0x69], 0x1 */
            ii(0x1015_ee5a, 2); jmpd(0x1015_ee9f, 0x43); goto l_0x1015_ee9f; /* jmp 0x1015ee9f */
        l_0x1015_ee5c:
            ii(0x1015_ee5c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_ee5f, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_ee62, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_ee65, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_ee68, 1); inc(eax);                               /* inc eax */
            ii(0x1015_ee69, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_ee6c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_ee70, 5); calld(0x1007_5331, -0xe_9b44);          /* call 0x10075331 */
            ii(0x1015_ee75, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_ee78, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ee7a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_ee7c, 5); calld(0x1007_6e00, -0xe_8081);          /* call 0x10076e00 */
            ii(0x1015_ee81, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ee83, 2); if(jzd(0x1015_ee93, 0xe)) goto l_0x1015_ee93; /* jz 0x1015ee93 */
            ii(0x1015_ee85, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ee88, 5); calld(0x1007_6574, -0xe_8919);          /* call 0x10076574 */
            ii(0x1015_ee8d, 4); or(memb_a32[ds, eax + 0x69], 0x1);      /* or byte [eax+0x69], 0x1 */
            ii(0x1015_ee91, 2); jmpd(0x1015_ee9f, 0xc); goto l_0x1015_ee9f; /* jmp 0x1015ee9f */
        l_0x1015_ee93:
            ii(0x1015_ee93, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ee96, 5); calld(0x1007_6574, -0xe_8927);          /* call 0x10076574 */
            ii(0x1015_ee9b, 4); or(memb_a32[ds, eax + 0x69], 0x2);      /* or byte [eax+0x69], 0x2 */
        l_0x1015_ee9f:
            ii(0x1015_ee9f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_eea2, 5); calld(0x1007_6574, -0xe_8933);          /* call 0x10076574 */
            ii(0x1015_eea7, 5); calld(0x1014_9fa8, -0x1_4f04);          /* call 0x10149fa8 */
        l_0x1015_eeac:
            ii(0x1015_eeac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_eeaf, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1015_eeb3, 6); if(jzd(0x1015_f003, 0x14a)) goto l_0x1015_f003; /* jz 0x1015f003 */
            ii(0x1015_eeb9, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_eebb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_eebe, 1); dec(eax);                               /* dec eax */
            ii(0x1015_eebf, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_eec2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_eec5, 1); inc(eax);                               /* inc eax */
            ii(0x1015_eec6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_eec9, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_eecd, 5); calld(0x1007_5331, -0xe_9ba1);          /* call 0x10075331 */
            ii(0x1015_eed2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_eed4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_eed7, 5); calld(0x1007_6630, -0xe_88ac);          /* call 0x10076630 */
            ii(0x1015_eedc, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1015_eede, 5); calld(0x1013_ad71, -0x2_4172);          /* call 0x1013ad71 */
            ii(0x1015_eee3, 2); test(al, al);                           /* test al, al */
            ii(0x1015_eee5, 6); if(jzd(0x1015_ef5c, 0x71)) goto l_0x1015_ef5c; /* jz 0x1015ef5c */
            ii(0x1015_eeeb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_eeee, 4); or(memb_a32[ds, eax + 0x69], 0x2);      /* or byte [eax+0x69], 0x2 */
            ii(0x1015_eef2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_eef5, 5); calld(0x1007_6574, -0xe_8986);          /* call 0x10076574 */
            ii(0x1015_eefa, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_ef01, 2); if(jzd(0x1015_ef11, 0xe)) goto l_0x1015_ef11; /* jz 0x1015ef11 */
            ii(0x1015_ef03, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ef06, 5); calld(0x1007_6574, -0xe_8997);          /* call 0x10076574 */
            ii(0x1015_ef0b, 4); or(memb_a32[ds, eax + 0x69], 0x10);     /* or byte [eax+0x69], 0x10 */
            ii(0x1015_ef0f, 2); jmpd(0x1015_ef4f, 0x3e); goto l_0x1015_ef4f; /* jmp 0x1015ef4f */
        l_0x1015_ef11:
            ii(0x1015_ef11, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_ef14, 1); dec(eax);                               /* dec eax */
            ii(0x1015_ef15, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_ef18, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1015_ef1c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_ef20, 5); calld(0x1007_5331, -0xe_9bf4);          /* call 0x10075331 */
            ii(0x1015_ef25, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_ef28, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ef2a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_ef2c, 5); calld(0x1007_6e00, -0xe_8131);          /* call 0x10076e00 */
            ii(0x1015_ef31, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ef33, 2); if(jzd(0x1015_ef43, 0xe)) goto l_0x1015_ef43; /* jz 0x1015ef43 */
            ii(0x1015_ef35, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ef38, 5); calld(0x1007_6574, -0xe_89c9);          /* call 0x10076574 */
            ii(0x1015_ef3d, 4); or(memb_a32[ds, eax + 0x69], 0x20);     /* or byte [eax+0x69], 0x20 */
            ii(0x1015_ef41, 2); jmpd(0x1015_ef4f, 0xc); goto l_0x1015_ef4f; /* jmp 0x1015ef4f */
        l_0x1015_ef43:
            ii(0x1015_ef43, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ef46, 5); calld(0x1007_6574, -0xe_89d7);          /* call 0x10076574 */
            ii(0x1015_ef4b, 4); or(memb_a32[ds, eax + 0x69], 0x10);     /* or byte [eax+0x69], 0x10 */
        l_0x1015_ef4f:
            ii(0x1015_ef4f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ef52, 5); calld(0x1007_6574, -0xe_89e3);          /* call 0x10076574 */
            ii(0x1015_ef57, 5); calld(0x1014_9fa8, -0x1_4fb4);          /* call 0x10149fa8 */
        l_0x1015_ef5c:
            ii(0x1015_ef5c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_ef5e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_ef61, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_ef64, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_ef67, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_ef6a, 1); inc(eax);                               /* inc eax */
            ii(0x1015_ef6b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_ef6e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_ef72, 5); calld(0x1007_5331, -0xe_9c46);          /* call 0x10075331 */
            ii(0x1015_ef77, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ef79, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ef7c, 5); calld(0x1007_6630, -0xe_8951);          /* call 0x10076630 */
            ii(0x1015_ef81, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1015_ef83, 5); calld(0x1013_ad71, -0x2_4217);          /* call 0x1013ad71 */
            ii(0x1015_ef88, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ef8a, 6); if(jzd(0x1015_f003, 0x73)) goto l_0x1015_f003; /* jz 0x1015f003 */
            ii(0x1015_ef90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ef93, 4); or(memb_a32[ds, eax + 0x69], 0x20);     /* or byte [eax+0x69], 0x20 */
            ii(0x1015_ef97, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ef9a, 5); calld(0x1007_6574, -0xe_8a2b);          /* call 0x10076574 */
            ii(0x1015_ef9f, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_efa6, 2); if(jzd(0x1015_efb6, 0xe)) goto l_0x1015_efb6; /* jz 0x1015efb6 */
            ii(0x1015_efa8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_efab, 5); calld(0x1007_6574, -0xe_8a3c);          /* call 0x10076574 */
            ii(0x1015_efb0, 4); or(memb_a32[ds, eax + 0x69], 0x1);      /* or byte [eax+0x69], 0x1 */
            ii(0x1015_efb4, 2); jmpd(0x1015_eff6, 0x40); goto l_0x1015_eff6; /* jmp 0x1015eff6 */
        l_0x1015_efb6:
            ii(0x1015_efb6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_efb9, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_efbc, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_efbf, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1015_efc3, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_efc7, 5); calld(0x1007_5331, -0xe_9c9b);          /* call 0x10075331 */
            ii(0x1015_efcc, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_efcf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_efd1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_efd3, 5); calld(0x1007_6e00, -0xe_81d8);          /* call 0x10076e00 */
            ii(0x1015_efd8, 2); test(al, al);                           /* test al, al */
            ii(0x1015_efda, 2); if(jzd(0x1015_efea, 0xe)) goto l_0x1015_efea; /* jz 0x1015efea */
            ii(0x1015_efdc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_efdf, 5); calld(0x1007_6574, -0xe_8a70);          /* call 0x10076574 */
            ii(0x1015_efe4, 4); or(memb_a32[ds, eax + 0x69], 0x2);      /* or byte [eax+0x69], 0x2 */
            ii(0x1015_efe8, 2); jmpd(0x1015_eff6, 0xc); goto l_0x1015_eff6; /* jmp 0x1015eff6 */
        l_0x1015_efea:
            ii(0x1015_efea, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_efed, 5); calld(0x1007_6574, -0xe_8a7e);          /* call 0x10076574 */
            ii(0x1015_eff2, 4); or(memb_a32[ds, eax + 0x69], 0x1);      /* or byte [eax+0x69], 0x1 */
        l_0x1015_eff6:
            ii(0x1015_eff6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_eff9, 5); calld(0x1007_6574, -0xe_8a8a);          /* call 0x10076574 */
            ii(0x1015_effe, 5); calld(0x1014_9fa8, -0x1_505b);          /* call 0x10149fa8 */
        l_0x1015_f003:
            ii(0x1015_f003, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f005, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_f009, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f00c, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_f00f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f012, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f016, 5); calld(0x1007_5331, -0xe_9cea);          /* call 0x10075331 */
            ii(0x1015_f01b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f01d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f020, 5); calld(0x1007_6630, -0xe_89f5);          /* call 0x10076630 */
            ii(0x1015_f025, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1015_f027, 5); calld(0x1013_ad71, -0x2_42bb);          /* call 0x1013ad71 */
            ii(0x1015_f02c, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f02e, 6); if(jzd(0x1015_f0aa, 0x76)) goto l_0x1015_f0aa; /* jz 0x1015f0aa */
            ii(0x1015_f034, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f037, 4); or(memb_a32[ds, eax + 0x69], 0x4);      /* or byte [eax+0x69], 0x4 */
            ii(0x1015_f03b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f03e, 5); calld(0x1007_6574, -0xe_8acf);          /* call 0x10076574 */
            ii(0x1015_f043, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_f04a, 2); if(jzd(0x1015_f05a, 0xe)) goto l_0x1015_f05a; /* jz 0x1015f05a */
            ii(0x1015_f04c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f04f, 5); calld(0x1007_6574, -0xe_8ae0);          /* call 0x10076574 */
            ii(0x1015_f054, 4); or(memb_a32[ds, eax + 0x69], 0x40);     /* or byte [eax+0x69], 0x40 */
            ii(0x1015_f058, 2); jmpd(0x1015_f09d, 0x43); goto l_0x1015_f09d; /* jmp 0x1015f09d */
        l_0x1015_f05a:
            ii(0x1015_f05a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_f05d, 1); inc(eax);                               /* inc eax */
            ii(0x1015_f05e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_f061, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f064, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_f067, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f06a, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f06e, 5); calld(0x1007_5331, -0xe_9d42);          /* call 0x10075331 */
            ii(0x1015_f073, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_f076, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f078, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_f07a, 5); calld(0x1007_6e00, -0xe_827f);          /* call 0x10076e00 */
            ii(0x1015_f07f, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f081, 2); if(jzd(0x1015_f091, 0xe)) goto l_0x1015_f091; /* jz 0x1015f091 */
            ii(0x1015_f083, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f086, 5); calld(0x1007_6574, -0xe_8b17);          /* call 0x10076574 */
            ii(0x1015_f08b, 4); or(memb_a32[ds, eax + 0x69], 0x40);     /* or byte [eax+0x69], 0x40 */
            ii(0x1015_f08f, 2); jmpd(0x1015_f09d, 0xc); goto l_0x1015_f09d; /* jmp 0x1015f09d */
        l_0x1015_f091:
            ii(0x1015_f091, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f094, 5); calld(0x1007_6574, -0xe_8b25);          /* call 0x10076574 */
            ii(0x1015_f099, 4); or(memb_a32[ds, eax + 0x69], -0x80 /* 0x80 */); /* or byte [eax+0x69], 0x80 */
        l_0x1015_f09d:
            ii(0x1015_f09d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f0a0, 5); calld(0x1007_6574, -0xe_8b31);          /* call 0x10076574 */
            ii(0x1015_f0a5, 5); calld(0x1014_9fa8, -0x1_5102);          /* call 0x10149fa8 */
        l_0x1015_f0aa:
            ii(0x1015_f0aa, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f0ac, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_f0b0, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f0b3, 1); dec(eax);                               /* dec eax */
            ii(0x1015_f0b4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f0b7, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f0bb, 5); calld(0x1007_5331, -0xe_9d8f);          /* call 0x10075331 */
            ii(0x1015_f0c0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f0c2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f0c5, 5); calld(0x1007_6630, -0xe_8a9a);          /* call 0x10076630 */
            ii(0x1015_f0ca, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1015_f0cc, 5); calld(0x1013_ad71, -0x2_4360);          /* call 0x1013ad71 */
            ii(0x1015_f0d1, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f0d3, 6); if(jzd(0x1015_f14d, 0x74)) goto l_0x1015_f14d; /* jz 0x1015f14d */
            ii(0x1015_f0d9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f0dc, 4); or(memb_a32[ds, eax + 0x69], 0x40);     /* or byte [eax+0x69], 0x40 */
            ii(0x1015_f0e0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f0e3, 5); calld(0x1007_6574, -0xe_8b74);          /* call 0x10076574 */
            ii(0x1015_f0e8, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_f0ef, 2); if(jzd(0x1015_f0ff, 0xe)) goto l_0x1015_f0ff; /* jz 0x1015f0ff */
            ii(0x1015_f0f1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f0f4, 5); calld(0x1007_6574, -0xe_8b85);          /* call 0x10076574 */
            ii(0x1015_f0f9, 4); or(memb_a32[ds, eax + 0x69], 0x4);      /* or byte [eax+0x69], 0x4 */
            ii(0x1015_f0fd, 2); jmpd(0x1015_f140, 0x41); goto l_0x1015_f140; /* jmp 0x1015f140 */
        l_0x1015_f0ff:
            ii(0x1015_f0ff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_f102, 1); inc(eax);                               /* inc eax */
            ii(0x1015_f103, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_f106, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f109, 1); dec(eax);                               /* dec eax */
            ii(0x1015_f10a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f10d, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f111, 5); calld(0x1007_5331, -0xe_9de5);          /* call 0x10075331 */
            ii(0x1015_f116, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_f119, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f11b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_f11d, 5); calld(0x1007_6e00, -0xe_8322);          /* call 0x10076e00 */
            ii(0x1015_f122, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f124, 2); if(jzd(0x1015_f134, 0xe)) goto l_0x1015_f134; /* jz 0x1015f134 */
            ii(0x1015_f126, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f129, 5); calld(0x1007_6574, -0xe_8bba);          /* call 0x10076574 */
            ii(0x1015_f12e, 4); or(memb_a32[ds, eax + 0x69], 0x4);      /* or byte [eax+0x69], 0x4 */
            ii(0x1015_f132, 2); jmpd(0x1015_f140, 0xc); goto l_0x1015_f140; /* jmp 0x1015f140 */
        l_0x1015_f134:
            ii(0x1015_f134, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f137, 5); calld(0x1007_6574, -0xe_8bc8);          /* call 0x10076574 */
            ii(0x1015_f13c, 4); or(memb_a32[ds, eax + 0x69], 0x8);      /* or byte [eax+0x69], 0x8 */
        l_0x1015_f140:
            ii(0x1015_f140, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f143, 5); calld(0x1007_6574, -0xe_8bd4);          /* call 0x10076574 */
            ii(0x1015_f148, 5); calld(0x1014_9fa8, -0x1_51a5);          /* call 0x10149fa8 */
        l_0x1015_f14d:
            ii(0x1015_f14d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f150, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1015_f154, 6); if(jzd(0x1015_f2a4, 0x14a)) goto l_0x1015_f2a4; /* jz 0x1015f2a4 */
            ii(0x1015_f15a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f15c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_f15f, 1); inc(eax);                               /* inc eax */
            ii(0x1015_f160, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_f163, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f166, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_f169, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f16c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f170, 5); calld(0x1007_5331, -0xe_9e44);          /* call 0x10075331 */
            ii(0x1015_f175, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f177, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f17a, 5); calld(0x1007_6630, -0xe_8b4f);          /* call 0x10076630 */
            ii(0x1015_f17f, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1015_f181, 5); calld(0x1013_ad71, -0x2_4415);          /* call 0x1013ad71 */
            ii(0x1015_f186, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f188, 6); if(jzd(0x1015_f201, 0x73)) goto l_0x1015_f201; /* jz 0x1015f201 */
            ii(0x1015_f18e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f191, 4); or(memb_a32[ds, eax + 0x69], 0x8);      /* or byte [eax+0x69], 0x8 */
            ii(0x1015_f195, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f198, 5); calld(0x1007_6574, -0xe_8c29);          /* call 0x10076574 */
            ii(0x1015_f19d, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_f1a4, 2); if(jzd(0x1015_f1b4, 0xe)) goto l_0x1015_f1b4; /* jz 0x1015f1b4 */
            ii(0x1015_f1a6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f1a9, 5); calld(0x1007_6574, -0xe_8c3a);          /* call 0x10076574 */
            ii(0x1015_f1ae, 4); or(memb_a32[ds, eax + 0x69], 0x40);     /* or byte [eax+0x69], 0x40 */
            ii(0x1015_f1b2, 2); jmpd(0x1015_f1f4, 0x40); goto l_0x1015_f1f4; /* jmp 0x1015f1f4 */
        l_0x1015_f1b4:
            ii(0x1015_f1b4, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_f1b8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f1bb, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_f1be, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f1c1, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f1c5, 5); calld(0x1007_5331, -0xe_9e99);          /* call 0x10075331 */
            ii(0x1015_f1ca, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_f1cd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f1cf, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_f1d1, 5); calld(0x1007_6e00, -0xe_83d6);          /* call 0x10076e00 */
            ii(0x1015_f1d6, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f1d8, 2); if(jzd(0x1015_f1e8, 0xe)) goto l_0x1015_f1e8; /* jz 0x1015f1e8 */
            ii(0x1015_f1da, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f1dd, 5); calld(0x1007_6574, -0xe_8c6e);          /* call 0x10076574 */
            ii(0x1015_f1e2, 4); or(memb_a32[ds, eax + 0x69], -0x80 /* 0x80 */); /* or byte [eax+0x69], 0x80 */
            ii(0x1015_f1e6, 2); jmpd(0x1015_f1f4, 0xc); goto l_0x1015_f1f4; /* jmp 0x1015f1f4 */
        l_0x1015_f1e8:
            ii(0x1015_f1e8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f1eb, 5); calld(0x1007_6574, -0xe_8c7c);          /* call 0x10076574 */
            ii(0x1015_f1f0, 4); or(memb_a32[ds, eax + 0x69], 0x40);     /* or byte [eax+0x69], 0x40 */
        l_0x1015_f1f4:
            ii(0x1015_f1f4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f1f7, 5); calld(0x1007_6574, -0xe_8c88);          /* call 0x10076574 */
            ii(0x1015_f1fc, 5); calld(0x1014_9fa8, -0x1_5259);          /* call 0x10149fa8 */
        l_0x1015_f201:
            ii(0x1015_f201, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f203, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_f206, 1); inc(eax);                               /* inc eax */
            ii(0x1015_f207, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_f20a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f20d, 1); dec(eax);                               /* dec eax */
            ii(0x1015_f20e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f211, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f215, 5); calld(0x1007_5331, -0xe_9ee9);          /* call 0x10075331 */
            ii(0x1015_f21a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f21c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f21f, 5); calld(0x1007_6630, -0xe_8bf4);          /* call 0x10076630 */
            ii(0x1015_f224, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1015_f226, 5); calld(0x1013_ad71, -0x2_44ba);          /* call 0x1013ad71 */
            ii(0x1015_f22b, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f22d, 6); if(jzd(0x1015_f2a4, 0x71)) goto l_0x1015_f2a4; /* jz 0x1015f2a4 */
            ii(0x1015_f233, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f236, 4); or(memb_a32[ds, eax + 0x69], -0x80 /* 0x80 */); /* or byte [eax+0x69], 0x80 */
            ii(0x1015_f23a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f23d, 5); calld(0x1007_6574, -0xe_8cce);          /* call 0x10076574 */
            ii(0x1015_f242, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_f249, 2); if(jzd(0x1015_f259, 0xe)) goto l_0x1015_f259; /* jz 0x1015f259 */
            ii(0x1015_f24b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f24e, 5); calld(0x1007_6574, -0xe_8cdf);          /* call 0x10076574 */
            ii(0x1015_f253, 4); or(memb_a32[ds, eax + 0x69], 0x4);      /* or byte [eax+0x69], 0x4 */
            ii(0x1015_f257, 2); jmpd(0x1015_f297, 0x3e); goto l_0x1015_f297; /* jmp 0x1015f297 */
        l_0x1015_f259:
            ii(0x1015_f259, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_f25d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f260, 1); dec(eax);                               /* dec eax */
            ii(0x1015_f261, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f264, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f268, 5); calld(0x1007_5331, -0xe_9f3c);          /* call 0x10075331 */
            ii(0x1015_f26d, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_f270, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f272, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_f274, 5); calld(0x1007_6e00, -0xe_8479);          /* call 0x10076e00 */
            ii(0x1015_f279, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f27b, 2); if(jzd(0x1015_f28b, 0xe)) goto l_0x1015_f28b; /* jz 0x1015f28b */
            ii(0x1015_f27d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f280, 5); calld(0x1007_6574, -0xe_8d11);          /* call 0x10076574 */
            ii(0x1015_f285, 4); or(memb_a32[ds, eax + 0x69], 0x8);      /* or byte [eax+0x69], 0x8 */
            ii(0x1015_f289, 2); jmpd(0x1015_f297, 0xc); goto l_0x1015_f297; /* jmp 0x1015f297 */
        l_0x1015_f28b:
            ii(0x1015_f28b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f28e, 5); calld(0x1007_6574, -0xe_8d1f);          /* call 0x10076574 */
            ii(0x1015_f293, 4); or(memb_a32[ds, eax + 0x69], 0x4);      /* or byte [eax+0x69], 0x4 */
        l_0x1015_f297:
            ii(0x1015_f297, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f29a, 5); calld(0x1007_6574, -0xe_8d2b);          /* call 0x10076574 */
            ii(0x1015_f29f, 5); calld(0x1014_9fa8, -0x1_52fc);          /* call 0x10149fa8 */
        l_0x1015_f2a4:
            ii(0x1015_f2a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f2a7, 5); calld(0x1014_bb98, -0x1_3714);          /* call 0x1014bb98 */
            ii(0x1015_f2ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f2af, 5); calld(0x1007_6204, -0xe_90b0);          /* call 0x10076204 */
            ii(0x1015_f2b4, 5); calld(0x1007_35ac, -0xe_bd0d);          /* call 0x100735ac */
            ii(0x1015_f2b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f2bb, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_f2be, 5); calld(0x1007_5f2c, -0xe_9397);          /* call 0x10075f2c */
        l_0x1015_f2c3:
            ii(0x1015_f2c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_f2c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_f2c6, 1); popd(edi);                              /* pop edi */
            ii(0x1015_f2c7, 1); popd(esi);                              /* pop esi */
            ii(0x1015_f2c8, 1); popd(edx);                              /* pop edx */
            ii(0x1015_f2c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_f2ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_f2cb, 1); retd(); return;                         /* ret */
        }
    }
}
