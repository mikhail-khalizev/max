using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_6df3-1ece3b1c")]
        public void Method_100a_6df3()
        {
            ii(0x100a_6df3, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100a_6df8, 5); calld(Definitions.sys_check_available_stack_size, 0xb_ef55); /* call 0x10165d52 */
            ii(0x100a_6dfd, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_6dfe, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_6dff, 1); pushd(edx);                             /* push edx */
            ii(0x100a_6e00, 1); pushd(esi);                             /* push esi */
            ii(0x100a_6e01, 1); pushd(edi);                             /* push edi */
            ii(0x100a_6e02, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_6e03, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6e05, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_6e0b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_6e0e, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100a_6e12, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6e15, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_072a); /* call 0x100766f0 */
            ii(0x100a_6e1a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_6e1d, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100a_6e21, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6e23, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6e26, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6e29, 5); calld(0x1013_ad11, 0x9_3ee3);           /* call 0x1013ad11 */
            ii(0x100a_6e2e, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6e30, 2); if(jzd(0x100a_6e41, 0xf)) goto l_0x100a_6e41; /* jz 0x100a6e41 */
            ii(0x100a_6e32, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6e34, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6e37, 5); calld(0x1007_5f2c, -0x3_0f10);          /* call 0x10075f2c */
            ii(0x100a_6e3c, 5); jmpd(0x100a_6f79, 0x138); goto l_0x100a_6f79; /* jmp 0x100a6f79 */
        l_0x100a_6e41:
            ii(0x100a_6e41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6e43, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6e46, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_6e49, 5); calld(0x1007_6630, -0x3_081e);          /* call 0x10076630 */
            ii(0x100a_6e4e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6e50, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6e53, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_6e56, 5); calld(0x1007_6630, -0x3_082b);          /* call 0x10076630 */
            ii(0x100a_6e5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6e5e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_6e61, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_6e64, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_6e67, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_6e6a, 3); calld_abs(memd_a32[ds, edx + 0x74]);    /* call dword [edx+0x74] */
            ii(0x100a_6e6d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6e6f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6e72, 5); calld(0x1007_6630, -0x3_0847);          /* call 0x10076630 */
            ii(0x100a_6e77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6e7a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_6e7d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6e80, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_6e83, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6e86, 3); calld_abs(memd_a32[ds, edx + 0x78]);    /* call dword [edx+0x78] */
            ii(0x100a_6e89, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6e8b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6e8e, 5); calld(0x1013_ad71, 0x9_3ede);           /* call 0x1013ad71 */
            ii(0x100a_6e93, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6e95, 6); if(jzd(0x100a_6f1c, 0x81)) goto l_0x100a_6f1c; /* jz 0x100a6f1c */
            ii(0x100a_6e9b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6e9d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6ea0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_6ea3, 5); calld(0x1013_ad11, 0x9_3e69);           /* call 0x1013ad11 */
            ii(0x100a_6ea8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6eaa, 2); if(jzd(0x100a_6ebc, 0x10)) goto l_0x100a_6ebc; /* jz 0x100a6ebc */
            ii(0x100a_6eac, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100a_6eaf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6eb2, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_6eb5, 5); calld(0x1008_ac18, -0x1_c2a2);          /* call 0x1008ac18 */
            ii(0x100a_6eba, 2); jmpd(0x100a_6f1c, 0x60); goto l_0x100a_6f1c; /* jmp 0x100a6f1c */
        l_0x100a_6ebc:
            ii(0x100a_6ebc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6ebf, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6ec2, 5); calld(0x1008_abbc, -0x1_c30b);          /* call 0x1008abbc */
            ii(0x100a_6ec7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6ec9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6ecc, 5); calld(0x1008_abbc, -0x1_c315);          /* call 0x1008abbc */
            ii(0x100a_6ed1, 5); calld(0x100a_601a, -0xebc);             /* call 0x100a601a */
            ii(0x100a_6ed6, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_6ed9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6edc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6edf, 5); calld(0x1008_abbc, -0x1_c328);          /* call 0x1008abbc */
            ii(0x100a_6ee4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6ee6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6ee9, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_6eec, 5); calld(0x1008_abbc, -0x1_c335);          /* call 0x1008abbc */
            ii(0x100a_6ef1, 5); calld(0x100a_601a, -0xedc);             /* call 0x100a601a */
            ii(0x100a_6ef6, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_6ef9, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100a_6efd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_6eff, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_6f02, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_6f04, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100a_6f06, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100a_6f0a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100a_6f0c, 2); if(jled(0x100a_6f1c, 0xe)) goto l_0x100a_6f1c; /* jle 0x100a6f1c */
            ii(0x100a_6f0e, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100a_6f11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6f14, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_6f17, 5); calld(0x1008_ac18, -0x1_c304);          /* call 0x1008ac18 */
        l_0x100a_6f1c:
            ii(0x100a_6f1c, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100a_6f1f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6f22, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_6f25, 5); calld(0x1009_cbc4, -0xa366);            /* call 0x1009cbc4 */
            ii(0x100a_6f2a, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6f2c, 2); if(jzd(0x100a_6f3f, 0x11)) goto l_0x100a_6f3f; /* jz 0x100a6f3f */
            ii(0x100a_6f2e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6f31, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100a_6f34, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6f37, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_6f3a, 5); calld(0x1008_ac18, -0x1_c327);          /* call 0x1008ac18 */
        l_0x100a_6f3f:
            ii(0x100a_6f3f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6f41, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6f44, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_6f47, 5); calld(0x1013_ad11, 0x9_3dc5);           /* call 0x1013ad11 */
            ii(0x100a_6f4c, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6f4e, 2); if(jzd(0x100a_6f5c, 0xc)) goto l_0x100a_6f5c; /* jz 0x100a6f5c */
            ii(0x100a_6f50, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6f52, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6f55, 5); calld(0x1007_5f2c, -0x3_102e);          /* call 0x10075f2c */
            ii(0x100a_6f5a, 2); jmpd(0x100a_6f79, 0x1d); goto l_0x100a_6f79; /* jmp 0x100a6f79 */
        l_0x100a_6f5c:
            ii(0x100a_6f5c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6f5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6f62, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_6f65, 5); calld(0x1007_6574, -0x3_09f6);          /* call 0x10076574 */
            ii(0x100a_6f6a, 5); calld(0x1015_27ed, 0xa_b87e);           /* call 0x101527ed */
            ii(0x100a_6f6f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6f71, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6f74, 5); calld(0x1007_5f2c, -0x3_104d);          /* call 0x10075f2c */
        l_0x100a_6f79:
            ii(0x100a_6f79, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6f7b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_6f7c, 1); popd(edi);                              /* pop edi */
            ii(0x100a_6f7d, 1); popd(esi);                              /* pop esi */
            ii(0x100a_6f7e, 1); popd(edx);                              /* pop edx */
            ii(0x100a_6f7f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_6f80, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_6f81, 1); retd();                                 /* ret */
        }
    }
}
