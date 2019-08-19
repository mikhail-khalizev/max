using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_6ead-7956b668")]
        public void Method_1014_6ead()
        {
            ii(0x1014_6ead, 5); pushd(0x80);                            /* push 0x80 */
            ii(0x1014_6eb2, 5); calld(Definitions.sys_check_available_stack_size, 0x1_ee9b); /* call 0x10165d52 */
            ii(0x1014_6eb7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_6eb8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_6eb9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_6eba, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_6ebb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6ebd, 6); sub(esp, 0x64);                         /* sub esp, 0x64 */
            ii(0x1014_6ec3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_6ec6, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_6ec9, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_6ecc, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1014_6ed1, 5); calld(Definitions.sys_new, 0x1_ef2a);   /* call 0x10165e00 */
            ii(0x1014_6ed6, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1014_6ed9, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1014_6edc, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1014_6edf, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1014_6ee3, 2); if(jzd(0x1014_6f0a, 0x25)) goto l_0x1014_6f0a; /* jz 0x10146f0a */
            ii(0x1014_6ee5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6ee8, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6ee9, 5); mov(ecx, 0x3e);                         /* mov ecx, 0x3e */
            ii(0x1014_6eee, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1014_6ef1, 3); add(ebx, 0x12);                         /* add ebx, 0x12 */
            ii(0x1014_6ef4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_6ef7, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1014_6efa, 5); calld(0x1014_5a6b, -0x1494);            /* call 0x10145a6b */
            ii(0x1014_6eff, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1014_6f02, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1014_6f05, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_6f08, 2); jmpd(0x1014_6f10, 0x6); goto l_0x1014_6f10; /* jmp 0x10146f10 */
        l_0x1014_6f0a:
            ii(0x1014_6f0a, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_6f0d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1014_6f10:
            ii(0x1014_6f10, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1014_6f13, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1014_6f16, 5); calld(0x1014_7bcc, 0xcb1);              /* call 0x10147bcc */
            ii(0x1014_6f1b, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x1014_6f22, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_6f26, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1014_6f29, 5); calld(0x1014_784c, 0x91e);              /* call 0x1014784c */
            ii(0x1014_6f2e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1014_6f31, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1014_6f35, 5); mov(edx, StringDefinitions.Index);      /* mov edx, 0x101ad0b0 */
            ii(0x1014_6f3a, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1014_6f3d, 5); calld(0x100e_0648, -0x6_68fa);          /* call 0x100e0648 */
            ii(0x1014_6f42, 5); calld(0x1014_60aa, -0xe9d);             /* call 0x101460aa */
            ii(0x1014_6f47, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_6f4a, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1014_6f4e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_6f50, 2); if(jnzd(0x1014_6f5e, 0xc)) goto l_0x1014_6f5e; /* jnz 0x10146f5e */
            ii(0x1014_6f52, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x1014_6f59, 5); jmpd(0x1014_7091, 0x133); goto l_0x1014_7091; /* jmp 0x10147091 */
        l_0x1014_6f5e:
            ii(0x1014_6f5e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6f61, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1014_6f64, 5); calld(Definitions.my_1_get_count, -0x9_ba91); /* call 0x100ab4d8 */
            ii(0x1014_6f69, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1014_6f6d, 2); if(jld(0x1014_6f89, 0x1a)) goto l_0x1014_6f89; /* jl 0x10146f89 */
            ii(0x1014_6f6f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_6f72, 1); dec(eax);                               /* dec eax */
            ii(0x1014_6f73, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_6f76, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6f79, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1014_6f7c, 5); calld(0x1013_c5f8, -0xa989);            /* call 0x1013c5f8 */
            ii(0x1014_6f81, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1014_6f84, 5); jmpd(0x1014_7091, 0x108); goto l_0x1014_7091; /* jmp 0x10147091 */
        l_0x1014_6f89:
            ii(0x1014_6f89, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6f8c, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1014_6f8f, 5); calld(Definitions.my_1_get_count, -0x9_babc); /* call 0x100ab4d8 */
            ii(0x1014_6f94, 1); cwde();                                 /* cwde */
            ii(0x1014_6f95, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1014_6f99, 1); inc(eax);                               /* inc eax */
            ii(0x1014_6f9a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_6f9c, 2); if(jzd(0x1014_6fb5, 0x17)) goto l_0x1014_6fb5; /* jz 0x10146fb5 */
            ii(0x1014_6f9e, 5); mov(eax, StringDefinitions.IndexRefersToUnknownObject); /* mov eax, 0x101ad0b6 */
            ii(0x1014_6fa3, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6fa4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6fa7, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6fa8, 5); calld(0x1014_69b5, -0x5f8);             /* call 0x101469b5 */
            ii(0x1014_6fad, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1014_6fb0, 5); jmpd(0x1014_7091, 0xdc); goto l_0x1014_7091; /* jmp 0x10147091 */
        l_0x1014_6fb5:
            ii(0x1014_6fb5, 5); mov(ebx, StringDefinitions.Type);       /* mov ebx, 0x101ad0d5 */
            ii(0x1014_6fba, 3); lea(edx, ebp - 0x4c);                   /* lea edx, [ebp-0x4c] */
            ii(0x1014_6fbd, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1014_6fc0, 5); calld(0x100e_0648, -0x6_697d);          /* call 0x100e0648 */
            ii(0x1014_6fc5, 5); calld(0x1014_60f3, -0xed7);             /* call 0x101460f3 */
            ii(0x1014_6fca, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1014_6fcd, 5); calld(Definitions.my_strobj_c_str_v2, -0xb_d80a); /* call 0x100897c8 */
            ii(0x1014_6fd2, 3); lea(ebx, ebp - 0x54);                   /* lea ebx, [ebp-0x54] */
            ii(0x1014_6fd5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6fd7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_6fd9, 5); calld(0x1013_b57c, -0xba62);            /* call 0x1013b57c */
            ii(0x1014_6fde, 3); lea(edx, ebp - 0x54);                   /* lea edx, [ebp-0x54] */
            ii(0x1014_6fe1, 5); mov(eax, memd_a32[ds, 0x101c_7274]);    /* mov eax, [0x101c7274] */
            ii(0x1014_6fe6, 5); calld(0x1014_80ac, 0x10c1);             /* call 0x101480ac */
            ii(0x1014_6feb, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1014_6fee, 4); cmp(memd_a32[ss, ebp - 0x58], 0);       /* cmp dword [ebp-0x58], 0x0 */
            ii(0x1014_6ff2, 2); if(jnzd(0x1014_700b, 0x17)) goto l_0x1014_700b; /* jnz 0x1014700b */
            ii(0x1014_6ff4, 5); mov(eax, StringDefinitions.UnknownType); /* mov eax, 0x101ad0da */
            ii(0x1014_6ff9, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6ffa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_6ffd, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6ffe, 5); calld(0x1014_69b5, -0x64e);             /* call 0x101469b5 */
            ii(0x1014_7003, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1014_7006, 5); jmpd(0x1014_7087, 0x7c); goto l_0x1014_7087; /* jmp 0x10147087 */
        l_0x1014_700b:
            ii(0x1014_700b, 5); mov(ebx, StringDefinitions.Object);     /* mov ebx, 0x101ad0e7 */
            ii(0x1014_7010, 3); lea(edx, ebp - 0x5c);                   /* lea edx, [ebp-0x5c] */
            ii(0x1014_7013, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1014_7016, 5); calld(0x100e_0648, -0x6_69d3);          /* call 0x100e0648 */
            ii(0x1014_701b, 5); calld(0x1014_625c, -0xdc4);             /* call 0x1014625c */
            ii(0x1014_7020, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7022, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1014_7025, 5); calld(0x1013_ad11, -0xc319);            /* call 0x1013ad11 */
            ii(0x1014_702a, 2); test(al, al);                           /* test al, al */
            ii(0x1014_702c, 2); if(jzd(0x1014_7040, 0x12)) goto l_0x1014_7040; /* jz 0x10147040 */
            ii(0x1014_702e, 5); mov(eax, StringDefinitions.NoObjectStructure); /* mov eax, 0x101ad0ee */
            ii(0x1014_7033, 1); pushd(eax);                             /* push eax */
            ii(0x1014_7034, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7037, 1); pushd(eax);                             /* push eax */
            ii(0x1014_7038, 5); calld(0x1014_69b5, -0x688);             /* call 0x101469b5 */
            ii(0x1014_703d, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x1014_7040:
            ii(0x1014_7040, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1014_7043, 5); calld(0x1013_c808, -0xa840);            /* call 0x1013c808 */
            ii(0x1014_7048, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1014_704b, 5); calld(0x1013_c6ac, -0xa9a4);            /* call 0x1013c6ac */
            ii(0x1014_7050, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_7053, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x1014_7056, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7059, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1014_705c, 5); calld(0x1013_c5c0, -0xaaa1);            /* call 0x1013c5c0 */
            ii(0x1014_7061, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1014_7064, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1014_7067, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1014_706a, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1014_706d, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1014_7070, 5); calld(0x1010_48c0, -0x4_27b5);          /* call 0x101048c0 */
            ii(0x1014_7075, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_7077, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1014_707a, 3); calld_abs(memd_a32[ds, ebx + 0x10]);    /* call dword [ebx+0x10] */
            ii(0x1014_707d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_707f, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1014_7082, 5); calld(0x100e_03fc, -0x6_6c8b);          /* call 0x100e03fc */
        l_0x1014_7087:
            ii(0x1014_7087, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7089, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1014_708c, 5); calld(Definitions.my_string_dtor, -0x5567); /* call 0x10141b2a */
        l_0x1014_7091:
            ii(0x1014_7091, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1014_7096, 5); calld(Definitions.sys_new, 0x1_ed65);   /* call 0x10165e00 */
            ii(0x1014_709b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_709e, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_70a1, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_70a4, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1014_70a8, 2); if(jzd(0x1014_70c6, 0x1c)) goto l_0x1014_70c6; /* jz 0x101470c6 */
            ii(0x1014_70aa, 3); mov(ecx, memd_a32[ss, ebp - 0x30]);     /* mov ecx, [ebp-0x30] */
            ii(0x1014_70ad, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1014_70b0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_70b3, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_70b6, 5); calld(0x1014_5587, -0x1b34);            /* call 0x10145587 */
            ii(0x1014_70bb, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1014_70be, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_70c1, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1014_70c4, 2); jmpd(0x1014_70cc, 0x6); goto l_0x1014_70cc; /* jmp 0x101470cc */
        l_0x1014_70c6:
            ii(0x1014_70c6, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_70c9, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
        l_0x1014_70cc:
            ii(0x1014_70cc, 3); mov(edx, memd_a32[ss, ebp - 0x64]);     /* mov edx, [ebp-0x64] */
            ii(0x1014_70cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_70d2, 5); calld(0x1014_7f44, 0xe6d);              /* call 0x10147f44 */
            ii(0x1014_70d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_70d9, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1014_70dc, 5); calld(0x1013_9d0c, -0xd3d5);            /* call 0x10139d0c */
            ii(0x1014_70e1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_70e3, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1014_70e6, 5); calld(0x100e_03fc, -0x6_6cef);          /* call 0x100e03fc */
            ii(0x1014_70eb, 2); jmpd(0x1014_7101, 0x14); goto l_0x1014_7101; /* jmp 0x10147101 */
        //  ii(0x1014_70ed, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_70ef, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
        //  ii(0x1014_70f2, 5); calld(0x1013_9d0c, -0xd3eb);            /* call 0x10139d0c */
        //  ii(0x1014_70f7, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_70f9, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
        //  ii(0x1014_70fc, 5); calld(0x100e_03fc, -0x6_6d05);          /* call 0x100e03fc */
        l_0x1014_7101:
            ii(0x1014_7101, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7104, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7106, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7107, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7108, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7109, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_710a, 1); retd(); return;                         /* ret */
        }
    }
}
