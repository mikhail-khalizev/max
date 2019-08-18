using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d51df49e-0f87-4a62-be9d-3912c130464c")]
        public void Method_100f_9e15()
        {
            ii(0x100f_9e15, 7); test(memb_a32[ds, 0x101c_38d4], 0x3);   /* test byte [0x101c38d4], 0x3 */
            ii(0x100f_9e1c, 6); if(jnzd_func(0x100f_a7df, 0x9bd)) return; /* jnz 0x100fa7df */
            ii(0x100f_9e22, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100f_9e27, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_9e2c, 5); calld(0x1013_dc59, 0x4_3e28);           /* call 0x1013dc59 */
            ii(0x100f_9e31, 7); cmp(memb_a32[ds, 0x101c_391d], 0);      /* cmp byte [0x101c391d], 0x0 */
            ii(0x100f_9e38, 2); if(jzd(0x100f_9e3f, 0x5)) goto l_0x100f_9e3f; /* jz 0x100f9e3f */
            ii(0x100f_9e3a, 5); calld(0x1011_606c, 0x1_c22d);           /* call 0x1011606c */
        l_0x100f_9e3f:
            ii(0x100f_9e3f, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_9e46, 6); if(jnzd(0x100f_9efd, 0xb1)) goto l_0x100f_9efd; /* jnz 0x100f9efd */
            ii(0x100f_9e4c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9e4e, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9e53, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_9e56, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_9e5d, 7); mov(memw_a32[ds, eax + 0x101c_35bc], dx); /* mov [eax+0x101c35bc], dx */
            ii(0x100f_9e64, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9e66, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9e6b, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_9e6e, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_9e75, 7); mov(memw_a32[ds, eax + 0x101c_35be], dx); /* mov [eax+0x101c35be], dx */
            ii(0x100f_9e7c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9e7e, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9e83, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_9e89, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_9e90, 7); mov(memw_a32[ds, eax + 0x101c_a56c], dx); /* mov [eax+0x101ca56c], dx */
            ii(0x100f_9e97, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9e99, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9e9e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_9ea4, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_9eab, 7); mov(memw_a32[ds, eax + 0x101c_a56e], dx); /* mov [eax+0x101ca56e], dx */
            ii(0x100f_9eb2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9eb4, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9eb9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_9ebf, 9); mov(memw_a32[ds, eax + 0x101c_a56a], 0x40); /* mov word [eax+0x101ca56a], 0x40 */
            ii(0x100f_9ec8, 5); calld(0x1012_11ea, 0x2_731d);           /* call 0x101211ea */
            ii(0x100f_9ecd, 2); cmp(al, 0x14);                          /* cmp al, 0x14 */
            ii(0x100f_9ecf, 2); if(jnzd(0x100f_9ee9, 0x18)) goto l_0x100f_9ee9; /* jnz 0x100f9ee9 */
            ii(0x100f_9ed1, 7); mov(memb_a32[ds, 0x101c_391e], 0xd);    /* mov byte [0x101c391e], 0xd */
            ii(0x100f_9ed8, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x100f_9edd, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_9ee2, 5); calld(0x1013_dc59, 0x4_3d72);           /* call 0x1013dc59 */
            ii(0x100f_9ee7, 2); jmpd(0x100f_9ef8, 0xf); goto l_0x100f_9ef8; /* jmp 0x100f9ef8 */
        l_0x100f_9ee9:
            ii(0x100f_9ee9, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100f_9eee, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_9ef3, 5); calld(0x1013_dc59, 0x4_3d61);           /* call 0x1013dc59 */
        l_0x100f_9ef8:
            ii(0x100f_9ef8, 5); if(jmpd_func(0x100f_a7df, 0x8e2)) return; /* jmp 0x100fa7df */
        l_0x100f_9efd:
            ii(0x100f_9efd, 5); mov(ecx, 0x40_0000);                    /* mov ecx, 0x400000 */
            ii(0x100f_9f02, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9f04, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_9f09, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_9f0c, 6); mov(edx, memd_a32[ds, 0x101c_3908]);    /* mov edx, [0x101c3908] */
            ii(0x100f_9f12, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9f15, 5); mov(eax, memd_a32[ds, 0x101c_3906]);    /* mov eax, [0x101c3906] */
            ii(0x100f_9f1a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9f1d, 5); calld(0x1007_388b, -0x8_6697);          /* call 0x1007388b */
            ii(0x100f_9f22, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_9f25, 7); cmp(memb_a32[ds, 0x101c_37d4], 0);      /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_9f2c, 6); if(jzd(0x100f_9ffe, 0xcc)) goto l_0x100f_9ffe; /* jz 0x100f9ffe */
            ii(0x100f_9f32, 7); test(memb_a32[ds, 0x101c_38d4], 0x20);  /* test byte [0x101c38d4], 0x20 */
            ii(0x100f_9f39, 2); if(jzd(0x100f_9f77, 0x3c)) goto l_0x100f_9f77; /* jz 0x100f9f77 */
            ii(0x100f_9f3b, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_9f3f, 2); if(jnzd(0x100f_9f5a, 0x19)) goto l_0x100f_9f5a; /* jnz 0x100f9f5a */
            ii(0x100f_9f41, 6); mov(edx, memd_a32[ds, 0x101c_3908]);    /* mov edx, [0x101c3908] */
            ii(0x100f_9f47, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9f4a, 5); mov(eax, memd_a32[ds, 0x101c_3906]);    /* mov eax, [0x101c3906] */
            ii(0x100f_9f4f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9f52, 5); calld(0x1007_3c18, -0x8_633f);          /* call 0x10073c18 */
            ii(0x100f_9f57, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100f_9f5a:
            ii(0x100f_9f5a, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_9f5e, 2); if(jzd(0x100f_9f72, 0x12)) goto l_0x100f_9f72; /* jz 0x100f9f72 */
            ii(0x100f_9f60, 5); mov(ebx, 0x1a);                         /* mov ebx, 0x1a */
            ii(0x100f_9f65, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_9f6a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_9f6d, 5); calld(0x1016_3053, 0x6_90e1);           /* call 0x10163053 */
        l_0x100f_9f72:
            ii(0x100f_9f72, 5); if(jmpd_func(0x100f_a7df, 0x868)) return; /* jmp 0x100fa7df */
        l_0x100f_9f77:
            ii(0x100f_9f77, 6); mov(ebx, memd_a32[ds, 0x101c_3908]);    /* mov ebx, [0x101c3908] */
            ii(0x100f_9f7d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9f80, 6); mov(edx, memd_a32[ds, 0x101c_3906]);    /* mov edx, [0x101c3906] */
            ii(0x100f_9f86, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9f89, 5); mov(eax, 0x101c_37c4);                  /* mov eax, 0x101c37c4 */
            ii(0x100f_9f8e, 5); calld(0x1008_abbc, -0x6_f3d7);          /* call 0x1008abbc */
            ii(0x100f_9f93, 5); calld(0x1016_30fa, 0x6_9162);           /* call 0x101630fa */
            ii(0x100f_9f98, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_9f9a, 6); if(jzd_func(0x100f_a7df, 0x83f)) return; /* jz 0x100fa7df */
            ii(0x100f_9fa0, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_9fa7, 2); if(jzd(0x100f_9fd1, 0x28)) goto l_0x100f_9fd1; /* jz 0x100f9fd1 */
            ii(0x100f_9fa9, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_9faf, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_9fb2, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_9fb8, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9fbb, 6); mov(edx, memd_a32[ds, 0x101c_37d4]);    /* mov edx, [0x101c37d4] */
            ii(0x100f_9fc1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9fc4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9fc6, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_9fcb, 1); cwde();                                 /* cwde */
            ii(0x100f_9fcc, 5); calld(0x1012_90e7, 0x2_f116);           /* call 0x101290e7 */
        l_0x100f_9fd1:
            ii(0x100f_9fd1, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_9fd7, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_9fda, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_9fe0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9fe3, 6); mov(edx, memd_a32[ds, 0x101c_37d4]);    /* mov edx, [0x101c37d4] */
            ii(0x100f_9fe9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9fec, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9fee, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_9ff3, 1); cwde();                                 /* cwde */
            ii(0x100f_9ff4, 5); calld(0x1010_2119, 0x8120);             /* call 0x10102119 */
            ii(0x100f_9ff9, 5); if(jmpd_func(0x100f_a7df, 0x7e1)) return; /* jmp 0x100fa7df */
        l_0x100f_9ffe:
            ii(0x100f_9ffe, 5); mov(ecx, 0x40_0000);                    /* mov ecx, 0x400000 */
            ii(0x100f_a003, 6); mov(ebx, memd_a32[ds, 0x101c_3908]);    /* mov ebx, [0x101c3908] */
            ii(0x100f_a009, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a00c, 6); mov(edx, memd_a32[ds, 0x101c_3906]);    /* mov edx, [0x101c3906] */
            ii(0x100f_a012, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_a015, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_a017, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_a01c, 1); cwde();                                 /* cwde */
            ii(0x100f_a01d, 5); calld(0x1007_459a, -0x8_5a88);          /* call 0x1007459a */
            ii(0x100f_a022, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_a025, 7); test(memb_a32[ds, 0x101c_38d4], 0x20);  /* test byte [0x101c38d4], 0x20 */
            ii(0x100f_a02c, 6); if(jzd(0x100f_a13a, 0x108)) goto l_0x100f_a13a; /* jz 0x100fa13a */
            ii(0x100f_a032, 5); calld(0x100f_40a6, -0x5f91);            /* call 0x100f40a6 */
            ii(0x100f_a037, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a039, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a03e, 5); calld(0x1013_ad71, 0x4_0d2e);           /* call 0x1013ad71 */
            ii(0x100f_a043, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a045, 2); if(jzd(0x100f_a06b, 0x24)) goto l_0x100f_a06b; /* jz 0x100fa06b */
            ii(0x100f_a047, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_a04a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a04f, 5); calld(0x1007_6e00, -0x8_3254);          /* call 0x10076e00 */
            ii(0x100f_a054, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a056, 2); if(jnzd(0x100f_a069, 0x11)) goto l_0x100f_a069; /* jnz 0x100fa069 */
            ii(0x100f_a058, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a05b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a060, 5); calld(0x1007_6e00, -0x8_3265);          /* call 0x10076e00 */
            ii(0x100f_a065, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a067, 2); if(jzd(0x100f_a06b, 0x2)) goto l_0x100f_a06b; /* jz 0x100fa06b */
        l_0x100f_a069:
            ii(0x100f_a069, 2); jmpd(0x100f_a06d, 0x2); goto l_0x100f_a06d; /* jmp 0x100fa06d */
        l_0x100f_a06b:
            ii(0x100f_a06b, 2); jmpd(0x100f_a081, 0x14); goto l_0x100f_a081; /* jmp 0x100fa081 */
        l_0x100f_a06d:
            ii(0x100f_a06d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a072, 5); calld(0x1008_abbc, -0x6_f4bb);          /* call 0x1008abbc */
            ii(0x100f_a077, 5); calld(0x1014_0d43, 0x4_6cc7);           /* call 0x10140d43 */
            ii(0x100f_a07c, 5); jmpd(0x100f_a135, 0xb4); goto l_0x100f_a135; /* jmp 0x100fa135 */
        l_0x100f_a081:
            ii(0x100f_a081, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_a085, 2); if(jzd(0x100f_a094, 0xd)) goto l_0x100f_a094; /* jz 0x100fa094 */
            ii(0x100f_a087, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_a08a, 5); calld(0x100f_92fe, -0xd91);             /* call 0x100f92fe */
            ii(0x100f_a08f, 5); jmpd(0x100f_a135, 0xa1); goto l_0x100f_a135; /* jmp 0x100fa135 */
        l_0x100f_a094:
            ii(0x100f_a094, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_a098, 2); if(jzd(0x100f_a0ec, 0x52)) goto l_0x100f_a0ec; /* jz 0x100fa0ec */
            ii(0x100f_a09a, 7); cmp(memb_a32[ds, 0x101c_388c], 0);      /* cmp byte [0x101c388c], 0x0 */
            ii(0x100f_a0a1, 2); if(jzd(0x100f_a0c6, 0x23)) goto l_0x100f_a0c6; /* jz 0x100fa0c6 */
            ii(0x100f_a0a3, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a0a6, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_a0ab, 5); calld(0x1008_aab4, -0x6_f5fc);          /* call 0x1008aab4 */
            ii(0x100f_a0b0, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a0b2, 2); if(jzd(0x100f_a0b9, 0x5)) goto l_0x100f_a0b9; /* jz 0x100fa0b9 */
            ii(0x100f_a0b4, 5); calld(0x100f_f5c1, 0x5508);             /* call 0x100ff5c1 */
        l_0x100f_a0b9:
            ii(0x100f_a0b9, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a0bc, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_a0c1, 5); calld(0x1008_ab1c, -0x6_f5aa);          /* call 0x1008ab1c */
        l_0x100f_a0c6:
            ii(0x100f_a0c6, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a0cc, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a0cf, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a0d5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a0d8, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a0db, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a0e0, 5); calld(0x1007_65d0, -0x8_3b15);          /* call 0x100765d0 */
            ii(0x100f_a0e5, 5); calld(0x100f_927b, -0xe6f);             /* call 0x100f927b */
            ii(0x100f_a0ea, 2); jmpd(0x100f_a135, 0x49); goto l_0x100f_a135; /* jmp 0x100fa135 */
        l_0x100f_a0ec:
            ii(0x100f_a0ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a0ee, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a0f3, 5); calld(0x1013_ad71, 0x4_0c79);           /* call 0x1013ad71 */
            ii(0x100f_a0f8, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a0fa, 2); if(jzd(0x100f_a135, 0x39)) goto l_0x100f_a135; /* jz 0x100fa135 */
            ii(0x100f_a0fc, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a101, 5); calld(0x1007_6574, -0x8_3b92);          /* call 0x10076574 */
            ii(0x100f_a106, 4); mov(memb_a32[ds, eax + 0x55], 0);       /* mov byte [eax+0x55], 0x0 */
            ii(0x100f_a10a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a10f, 5); calld(0x1007_6574, -0x8_3ba0);          /* call 0x10076574 */
            ii(0x100f_a114, 4); mov(memb_a32[ds, eax + 0x56], 0);       /* mov byte [eax+0x56], 0x0 */
            ii(0x100f_a118, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a11d, 5); calld(0x1007_6574, -0x8_3bae);          /* call 0x10076574 */
            ii(0x100f_a122, 4); mov(memb_a32[ds, eax + 0x57], 0);       /* mov byte [eax+0x57], 0x0 */
            ii(0x100f_a126, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a12b, 5); calld(0x1007_65d0, -0x8_3b60);          /* call 0x100765d0 */
            ii(0x100f_a130, 5); calld(0x1010_094d, 0x6818);             /* call 0x1010094d */
        l_0x100f_a135:
            ii(0x100f_a135, 5); if(jmpd_func(0x100f_a7df, 0x6a5)) return; /* jmp 0x100fa7df */
        l_0x100f_a13a:
            ii(0x100f_a13a, 5); calld(0x1012_11ea, 0x2_70ab);           /* call 0x101211ea */
            ii(0x100f_a13f, 3); mov(memb_a32[ss, ebp - 0x64], al);      /* mov [ebp-0x64], al */
            ii(0x100f_a142, 5); if(jmpd_func(0x100f_a740, 0x5f9)) return; /* jmp 0x100fa740 */
            ii(0x100f_a147, 5); calld(0x100f_40a6, -0x60a6);            /* call 0x100f40a6 */
            ii(0x100f_a14c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a14e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a153, 5); calld(0x1013_ad71, 0x4_0c19);           /* call 0x1013ad71 */
            ii(0x100f_a158, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a15a, 2); if(jzd(0x100f_a178, 0x1c)) goto l_0x100f_a178; /* jz 0x100fa178 */
            ii(0x100f_a15c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a161, 5); calld(0x1007_6574, -0x8_3bf2);          /* call 0x10076574 */
            ii(0x100f_a166, 4); mov(memb_a32[ds, eax + 0x56], 0);       /* mov byte [eax+0x56], 0x0 */
            ii(0x100f_a16a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a16f, 5); calld(0x1007_6574, -0x8_3c00);          /* call 0x10076574 */
            ii(0x100f_a174, 4); mov(memb_a32[ds, eax + 0x55], 0);       /* mov byte [eax+0x55], 0x0 */
        l_0x100f_a178:
            ii(0x100f_a178, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_a17c, 2); if(jzd(0x100f_a18b, 0xd)) goto l_0x100f_a18b; /* jz 0x100fa18b */
            ii(0x100f_a17e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_a181, 5); calld(0x100f_92fe, -0xe88);             /* call 0x100f92fe */
            ii(0x100f_a186, 5); jmpd(0x100f_a217, 0x8c); goto l_0x100f_a217; /* jmp 0x100fa217 */
        l_0x100f_a18b:
            ii(0x100f_a18b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a18d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a192, 5); calld(0x1013_ad71, 0x4_0bda);           /* call 0x1013ad71 */
            ii(0x100f_a197, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a199, 2); if(jzd(0x100f_a1ac, 0x11)) goto l_0x100f_a1ac; /* jz 0x100fa1ac */
            ii(0x100f_a19b, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a19e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a1a3, 5); calld(0x1007_6e00, -0x8_33a8);          /* call 0x10076e00 */
            ii(0x100f_a1a8, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a1aa, 2); if(jnzd(0x100f_a1b2, 0x6)) goto l_0x100f_a1b2; /* jnz 0x100fa1b2 */
        l_0x100f_a1ac:
            ii(0x100f_a1ac, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_a1b0, 2); if(jzd(0x100f_a217, 0x65)) goto l_0x100f_a217; /* jz 0x100fa217 */
        l_0x100f_a1b2:
            ii(0x100f_a1b2, 7); cmp(memb_a32[ds, 0x101c_388c], 0);      /* cmp byte [0x101c388c], 0x0 */
            ii(0x100f_a1b9, 2); if(jzd(0x100f_a1e2, 0x27)) goto l_0x100f_a1e2; /* jz 0x100fa1e2 */
            ii(0x100f_a1bb, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a1be, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_a1c3, 5); calld(0x1008_aab4, -0x6_f714);          /* call 0x1008aab4 */
            ii(0x100f_a1c8, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a1ca, 2); if(jzd(0x100f_a1d3, 0x7)) goto l_0x100f_a1d3; /* jz 0x100fa1d3 */
            ii(0x100f_a1cc, 5); calld(0x100f_f5c1, 0x53f0);             /* call 0x100ff5c1 */
            ii(0x100f_a1d1, 2); jmpd(0x100f_a1e0, 0xd); goto l_0x100f_a1e0; /* jmp 0x100fa1e0 */
        l_0x100f_a1d3:
            ii(0x100f_a1d3, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a1d6, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_a1db, 5); calld(0x1008_ab1c, -0x6_f6c4);          /* call 0x1008ab1c */
        l_0x100f_a1e0:
            ii(0x100f_a1e0, 2); jmpd(0x100f_a217, 0x35); goto l_0x100f_a217; /* jmp 0x100fa217 */
        l_0x100f_a1e2:
            ii(0x100f_a1e2, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a1e5, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a1ea, 5); calld(0x1008_b4ec, -0x6_ed03);          /* call 0x1008b4ec */
            ii(0x100f_a1ef, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a1f1, 2); if(jzd(0x100f_a217, 0x24)) goto l_0x100f_a217; /* jz 0x100fa217 */
            ii(0x100f_a1f3, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a1f9, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a1fc, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a202, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a205, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a208, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a20d, 5); calld(0x1007_65d0, -0x8_3c42);          /* call 0x100765d0 */
            ii(0x100f_a212, 5); calld(0x100f_927b, -0xf9c);             /* call 0x100f927b */
        l_0x100f_a217:
            ii(0x100f_a217, 5); if(jmpd_func(0x100f_a75d, 0x541)) return; /* jmp 0x100fa75d */
            ii(0x100f_a21c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a221, 5); calld(0x1007_6574, -0x8_3cb2);          /* call 0x10076574 */
            ii(0x100f_a226, 5); calld(0x1007_611c, -0x8_410f);          /* call 0x1007611c */
            ii(0x100f_a22b, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100f_a22e, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_a235, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100f_a238, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100f_a23c, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_a243, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100f_a246, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100f_a24a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a24f, 5); calld(0x1007_6600, -0x8_3c54);          /* call 0x10076600 */
            ii(0x100f_a254, 3); mov(ebx, memd_a32[ss, ebp - 0x68]);     /* mov ebx, [ebp-0x68] */
            ii(0x100f_a257, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_a259, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_a25b, 5); calld(0x1008_a998, -0x6_f8c8);          /* call 0x1008a998 */
            ii(0x100f_a260, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_a265, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100f_a26a, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100f_a26d, 5); calld(0x1016_3053, 0x6_8de1);           /* call 0x10163053 */
            ii(0x100f_a272, 5); if(jmpd_func(0x100f_a75d, 0x4e6)) return; /* jmp 0x100fa75d */
            ii(0x100f_a277, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a27c, 5); calld(0x1008_abbc, -0x6_f6c5);          /* call 0x1008abbc */
            ii(0x100f_a281, 5); calld(0x100f_8b93, -0x16f3);            /* call 0x100f8b93 */
            ii(0x100f_a286, 5); if(jmpd_func(0x100f_a75d, 0x4d2)) return; /* jmp 0x100fa75d */
            ii(0x100f_a28b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a28d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a292, 5); calld(0x1013_ad71, 0x4_0ada);           /* call 0x1013ad71 */
            ii(0x100f_a297, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a299, 6); if(jzd(0x100f_a3a0, 0x101)) goto l_0x100f_a3a0; /* jz 0x100fa3a0 */
            ii(0x100f_a29f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a2a4, 5); calld(0x1007_6574, -0x8_3d35);          /* call 0x10076574 */
            ii(0x100f_a2a9, 4); cmp(memb_a32[ds, eax + 0x56], 0);       /* cmp byte [eax+0x56], 0x0 */
            ii(0x100f_a2ad, 2); if(jzd(0x100f_a2ed, 0x3e)) goto l_0x100f_a2ed; /* jz 0x100fa2ed */
            ii(0x100f_a2af, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_a2b2, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100f_a2b5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a2b8, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a2b9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_a2bc, 3); mov(ecx, memd_a32[ds, eax + 0x18]);     /* mov ecx, [eax+0x18] */
            ii(0x100f_a2bf, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a2c2, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a2c7, 5); calld(0x1007_65d0, -0x8_3cfc);          /* call 0x100765d0 */
            ii(0x100f_a2cc, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_a2ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a2d0, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x100f_a2d5, 5); calld(0x100f_79d4, -0x2906);            /* call 0x100f79d4 */
            ii(0x100f_a2da, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a2df, 5); calld(0x1007_6574, -0x8_3d70);          /* call 0x10076574 */
            ii(0x100f_a2e4, 4); mov(memb_a32[ds, eax + 0x56], 0);       /* mov byte [eax+0x56], 0x0 */
            ii(0x100f_a2e8, 5); if(jmpd_func(0x100f_a75d, 0x470)) return; /* jmp 0x100fa75d */
        l_0x100f_a2ed:
            ii(0x100f_a2ed, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a2f2, 5); calld(0x1007_6574, -0x8_3d83);          /* call 0x10076574 */
            ii(0x100f_a2f7, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100f_a2fb, 2); if(jnzd(0x100f_a351, 0x54)) goto l_0x100f_a351; /* jnz 0x100fa351 */
            ii(0x100f_a2fd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_a2ff, 5); calld(0x100f_448c, -0x5e78);            /* call 0x100f448c */
            ii(0x100f_a304, 5); calld(0x100f_f5c1, 0x52b8);             /* call 0x100ff5c1 */
            ii(0x100f_a309, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a30e, 5); calld(0x1007_6574, -0x8_3d9f);          /* call 0x10076574 */
            ii(0x100f_a313, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_a31a, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100f_a31e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a323, 5); calld(0x1007_6574, -0x8_3db4);          /* call 0x10076574 */
            ii(0x100f_a328, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_a32f, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100f_a333, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100f_a338, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100f_a33d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a342, 5); calld(0x1007_6600, -0x8_3d47);          /* call 0x10076600 */
            ii(0x100f_a347, 5); calld(0x1016_3053, 0x6_8d07);           /* call 0x10163053 */
            ii(0x100f_a34c, 5); if(jmpd_func(0x100f_a75d, 0x40c)) return; /* jmp 0x100fa75d */
        l_0x100f_a351:
            ii(0x100f_a351, 5); mov(eax, memd_a32[ds, 0x101c_3908]);    /* mov eax, [0x101c3908] */
            ii(0x100f_a356, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a359, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100f_a35c, 3); pushd(memd_a32[ss, ebp - 0x70]);        /* push dword [ebp-0x70] */
            ii(0x100f_a35f, 5); mov(eax, memd_a32[ds, 0x101c_3906]);    /* mov eax, [0x101c3906] */
            ii(0x100f_a364, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a367, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100f_a36a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a36f, 5); calld(0x1007_65d0, -0x8_3da4);          /* call 0x100765d0 */
            ii(0x100f_a374, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100f_a377, 5); calld(0x1012_11ea, 0x2_6e6e);           /* call 0x101211ea */
            ii(0x100f_a37c, 2); cmp(al, 0x14);                          /* cmp al, 0x14 */
            ii(0x100f_a37e, 2); if(jnzd(0x100f_a386, 0x6)) goto l_0x100f_a386; /* jnz 0x100fa386 */
            ii(0x100f_a380, 4); mov(memb_a32[ss, ebp - 0x6c], 0);       /* mov byte [ebp-0x6c], 0x0 */
            ii(0x100f_a384, 2); jmpd(0x100f_a38a, 0x4); goto l_0x100f_a38a; /* jmp 0x100fa38a */
        l_0x100f_a386:
            ii(0x100f_a386, 4); mov(memb_a32[ss, ebp - 0x6c], 0x1c);    /* mov byte [ebp-0x6c], 0x1c */
        l_0x100f_a38a:
            ii(0x100f_a38a, 3); mov(edx, memd_a32[ss, ebp - 0x6f]);     /* mov edx, [ebp-0x6f] */
            ii(0x100f_a38d, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100f_a390, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_a395, 3); mov(ecx, memd_a32[ss, ebp - 0x74]);     /* mov ecx, [ebp-0x74] */
            ii(0x100f_a398, 3); mov(ebx, memd_a32[ss, ebp - 0x78]);     /* mov ebx, [ebp-0x78] */
            ii(0x100f_a39b, 5); calld(0x100f_79d4, -0x29cc);            /* call 0x100f79d4 */
        l_0x100f_a3a0:
            ii(0x100f_a3a0, 5); if(jmpd_func(0x100f_a75d, 0x3b8)) return; /* jmp 0x100fa75d */
            ii(0x100f_a3a5, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a3ab, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a3ae, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a3b4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a3b7, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a3bd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a3c2, 5); calld(0x1007_65d0, -0x8_3df7);          /* call 0x100765d0 */
            ii(0x100f_a3c7, 5); calld(0x100f_9465, -0xf67);             /* call 0x100f9465 */
            ii(0x100f_a3cc, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a3ce, 2); if(jzd(0x100f_a3f5, 0x25)) goto l_0x100f_a3f5; /* jz 0x100fa3f5 */
            ii(0x100f_a3d0, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a3d5, 5); calld(0x1007_6574, -0x8_3e66);          /* call 0x10076574 */
            ii(0x100f_a3da, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_a3dc, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a3e1, 5); calld(0x1007_6574, -0x8_3e72);          /* call 0x10076574 */
            ii(0x100f_a3e6, 5); calld(0x1007_623c, -0x8_41af);          /* call 0x1007623c */
            ii(0x100f_a3eb, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x100f_a3ef, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x100f_a3f3, 2); if(jld(0x100f_a3fa, 0x5)) goto l_0x100f_a3fa; /* jl 0x100fa3fa */
        l_0x100f_a3f5:
            ii(0x100f_a3f5, 5); jmpd(0x100f_a521, 0x127); goto l_0x100f_a521; /* jmp 0x100fa521 */
        l_0x100f_a3fa:
            ii(0x100f_a3fa, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a3ff, 5); calld(0x1007_6574, -0x8_3e90);          /* call 0x10076574 */
            ii(0x100f_a404, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100f_a409, 2); if(jnzd(0x100f_a44f, 0x44)) goto l_0x100f_a44f; /* jnz 0x100fa44f */
            ii(0x100f_a40b, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a411, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a416, 5); calld(0x1007_6574, -0x8_3ea7);          /* call 0x10076574 */
            ii(0x100f_a41b, 5); calld(0x1008_a998, -0x6_fa88);          /* call 0x1008a998 */
            ii(0x100f_a420, 5); mov(eax, memd_a32[ds, 0x101c_3908]);    /* mov eax, [0x101c3908] */
            ii(0x100f_a425, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a428, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a429, 6); mov(ecx, memd_a32[ds, 0x101c_3906]);    /* mov ecx, [0x101c3906] */
            ii(0x100f_a42f, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a432, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a437, 5); calld(0x1007_65d0, -0x8_3e6c);          /* call 0x100765d0 */
            ii(0x100f_a43c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_a43e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a440, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_a445, 5); calld(0x100f_79d4, -0x2a76);            /* call 0x100f79d4 */
            ii(0x100f_a44a, 5); jmpd(0x100f_a521, 0xd2); goto l_0x100f_a521; /* jmp 0x100fa521 */
        l_0x100f_a44f:
            ii(0x100f_a44f, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_a454, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_a458, 2); if(jnzd(0x100f_a482, 0x28)) goto l_0x100f_a482; /* jnz 0x100fa482 */
            ii(0x100f_a45a, 5); calld(0x100c_aa00, -0x2_fa5f);          /* call 0x100caa00 */
            ii(0x100f_a45f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_a464, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a465, 5); calld(0x100c_aa20, -0x2_fa4a);          /* call 0x100caa20 */
            ii(0x100f_a46a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_a46c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_a46e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_a473, 5); mov(eax, StringDefinitions.UnableToLoadDisabledUnits); /* mov eax, 0x101a2879 */
            ii(0x100f_a478, 5); calld(0x1011_5d23, 0x1_b8a6);           /* call 0x10115d23 */
            ii(0x100f_a47d, 5); jmpd(0x100f_a521, 0x9f); goto l_0x100f_a521; /* jmp 0x100fa521 */
        l_0x100f_a482:
            ii(0x100f_a482, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a487, 5); calld(0x1007_6574, -0x8_3f18);          /* call 0x10076574 */
            ii(0x100f_a48c, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a492, 4); mov(dx, memw_a32[ds, edx + 0x1a]);      /* mov dx, [edx+0x1a] */
            ii(0x100f_a496, 4); cmp(dx, memw_a32[ds, eax + 0x1a]);      /* cmp dx, [eax+0x1a] */
            ii(0x100f_a49a, 2); if(jnzd(0x100f_a4b6, 0x1a)) goto l_0x100f_a4b6; /* jnz 0x100fa4b6 */
            ii(0x100f_a49c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a4a1, 5); calld(0x1007_6574, -0x8_3f32);          /* call 0x10076574 */
            ii(0x100f_a4a6, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a4ac, 4); mov(dx, memw_a32[ds, edx + 0x1c]);      /* mov dx, [edx+0x1c] */
            ii(0x100f_a4b0, 4); cmp(dx, memw_a32[ds, eax + 0x1c]);      /* cmp dx, [eax+0x1c] */
            ii(0x100f_a4b4, 2); if(jzd(0x100f_a4b8, 0x2)) goto l_0x100f_a4b8; /* jz 0x100fa4b8 */
        l_0x100f_a4b6:
            ii(0x100f_a4b6, 2); jmpd(0x100f_a4c3, 0xb); goto l_0x100f_a4c3; /* jmp 0x100fa4c3 */
        l_0x100f_a4b8:
            ii(0x100f_a4b8, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_a4bd, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_a4c1, 2); if(jzd(0x100f_a4c5, 0x2)) goto l_0x100f_a4c5; /* jz 0x100fa4c5 */
        l_0x100f_a4c3:
            ii(0x100f_a4c3, 2); jmpd(0x100f_a4ee, 0x29); goto l_0x100f_a4ee; /* jmp 0x100fa4ee */
        l_0x100f_a4c5:
            ii(0x100f_a4c5, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a4ca, 5); calld(0x1007_65d0, -0x8_3eff);          /* call 0x100765d0 */
            ii(0x100f_a4cf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_a4d1, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_a4d6, 5); calld(0x1008_a998, -0x6_fb43);          /* call 0x1008a998 */
            ii(0x100f_a4db, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_a4dd, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x100f_a4e2, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_a4e7, 5); calld(0x1016_3053, 0x6_8b67);           /* call 0x10163053 */
            ii(0x100f_a4ec, 2); jmpd(0x100f_a521, 0x33); goto l_0x100f_a521; /* jmp 0x100fa521 */
        l_0x100f_a4ee:
            ii(0x100f_a4ee, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a4f3, 5); calld(0x1007_6574, -0x8_3f84);          /* call 0x10076574 */
            ii(0x100f_a4f8, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100f_a4fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a4fe, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a4ff, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a504, 5); calld(0x1007_6574, -0x8_3f95);          /* call 0x10076574 */
            ii(0x100f_a509, 3); mov(ecx, memd_a32[ds, eax + 0x18]);     /* mov ecx, [eax+0x18] */
            ii(0x100f_a50c, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a50f, 6); mov(ebx, memd_a32[ds, 0x101c_3894]);    /* mov ebx, [0x101c3894] */
            ii(0x100f_a515, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a517, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x100f_a51c, 5); calld(0x100f_79d4, -0x2b4d);            /* call 0x100f79d4 */
        l_0x100f_a521:
            ii(0x100f_a521, 5); if(jmpd_func(0x100f_a75d, 0x237)) return; /* jmp 0x100fa75d */
            ii(0x100f_a526, 5); mov(eax, memd_a32[ds, 0x101c_3908]);    /* mov eax, [0x101c3908] */
            ii(0x100f_a52b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a52e, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a52f, 6); mov(ecx, memd_a32[ds, 0x101c_3906]);    /* mov ecx, [0x101c3906] */
            ii(0x100f_a535, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a538, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a53d, 5); calld(0x1007_65d0, -0x8_3f72);          /* call 0x100765d0 */
            ii(0x100f_a542, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_a544, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a546, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100f_a54b, 5); calld(0x100f_79d4, -0x2b7c);            /* call 0x100f79d4 */
            ii(0x100f_a550, 5); if(jmpd_func(0x100f_a75d, 0x208)) return; /* jmp 0x100fa75d */
            ii(0x100f_a555, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a55a, 5); calld(0x1007_6574, -0x8_3feb);          /* call 0x10076574 */
            ii(0x100f_a55f, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_a566, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100f_a56a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a56f, 5); calld(0x1007_6574, -0x8_4000);          /* call 0x10076574 */
            ii(0x100f_a574, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_a57b, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100f_a57f, 5); mov(eax, memd_a32[ds, 0x101c_3908]);    /* mov eax, [0x101c3908] */
            ii(0x100f_a584, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a587, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a588, 6); mov(ecx, memd_a32[ds, 0x101c_3906]);    /* mov ecx, [0x101c3906] */
            ii(0x100f_a58e, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a591, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a596, 5); calld(0x1007_65d0, -0x8_3fcb);          /* call 0x100765d0 */
            ii(0x100f_a59b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_a59d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_a5a2, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100f_a5a7, 5); calld(0x100f_79d4, -0x2bd8);            /* call 0x100f79d4 */
            ii(0x100f_a5ac, 5); if(jmpd_func(0x100f_a75d, 0x1ac)) return; /* jmp 0x100fa75d */
            ii(0x100f_a5b1, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a5b7, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a5ba, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a5c0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a5c3, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a5c9, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a5ce, 5); calld(0x1007_65d0, -0x8_4003);          /* call 0x100765d0 */
            ii(0x100f_a5d3, 5); calld(0x100f_9465, -0x1173);            /* call 0x100f9465 */
            ii(0x100f_a5d8, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a5da, 2); if(jzd(0x100f_a5f1, 0x15)) goto l_0x100f_a5f1; /* jz 0x100fa5f1 */
            ii(0x100f_a5dc, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a5e2, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a5e7, 5); calld(0x1008_abbc, -0x6_fa30);          /* call 0x1008abbc */
            ii(0x100f_a5ec, 5); calld(0x100f_8d4a, -0x18a7);            /* call 0x100f8d4a */
        l_0x100f_a5f1:
            ii(0x100f_a5f1, 5); if(jmpd_func(0x100f_a75d, 0x167)) return; /* jmp 0x100fa75d */
            ii(0x100f_a5f6, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a5fc, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a5ff, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a605, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a608, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a60e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a613, 5); calld(0x1007_65d0, -0x8_4048);          /* call 0x100765d0 */
            ii(0x100f_a618, 5); calld(0x100f_9465, -0x11b8);            /* call 0x100f9465 */
            ii(0x100f_a61d, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a61f, 2); if(jzd(0x100f_a636, 0x15)) goto l_0x100f_a636; /* jz 0x100fa636 */
            ii(0x100f_a621, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a627, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a62c, 5); calld(0x1008_abbc, -0x6_fa75);          /* call 0x1008abbc */
            ii(0x100f_a631, 5); calld(0x100f_8e48, -0x17ee);            /* call 0x100f8e48 */
        l_0x100f_a636:
            ii(0x100f_a636, 5); if(jmpd_func(0x100f_a75d, 0x122)) return; /* jmp 0x100fa75d */
            ii(0x100f_a63b, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a641, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a644, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a64a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a64d, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a653, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a658, 5); calld(0x1007_65d0, -0x8_408d);          /* call 0x100765d0 */
            ii(0x100f_a65d, 5); calld(0x100f_9465, -0x11fd);            /* call 0x100f9465 */
            ii(0x100f_a662, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a664, 2); if(jzd(0x100f_a67b, 0x15)) goto l_0x100f_a67b; /* jz 0x100fa67b */
            ii(0x100f_a666, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a66c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a671, 5); calld(0x1007_65d0, -0x8_40a6);          /* call 0x100765d0 */
            ii(0x100f_a676, 5); calld(0x100f_8f46, -0x1735);            /* call 0x100f8f46 */
        l_0x100f_a67b:
            ii(0x100f_a67b, 5); if(jmpd_func(0x100f_a75d, 0xdd)) return; /* jmp 0x100fa75d */
            ii(0x100f_a680, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a686, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a689, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a68f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a692, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_a695, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a69a, 5); calld(0x1007_65d0, -0x8_40cf);          /* call 0x100765d0 */
            ii(0x100f_a69f, 5); calld(0x100f_9465, -0x123f);            /* call 0x100f9465 */
            ii(0x100f_a6a4, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a6a6, 2); if(jzd(0x100f_a6cc, 0x24)) goto l_0x100f_a6cc; /* jz 0x100fa6cc */
            ii(0x100f_a6a8, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a6ae, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a6b1, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a6b7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a6ba, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_a6bd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a6c2, 5); calld(0x1007_65d0, -0x8_40f7);          /* call 0x100765d0 */
            ii(0x100f_a6c7, 5); calld(0x100f_939e, -0x132e);            /* call 0x100f939e */
        l_0x100f_a6cc:
            ii(0x100f_a6cc, 5); if(jmpd_func(0x100f_a75d, 0x8c)) return; /* jmp 0x100fa75d */
            ii(0x100f_a6d1, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a6d4, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a6d9, 5); calld(0x1008_abbc, -0x6_fb22);          /* call 0x1008abbc */
            ii(0x100f_a6de, 5); calld(0x100f_911b, -0x15c8);            /* call 0x100f911b */
            ii(0x100f_a6e3, 5); if(jmpd_func(0x100f_a75d, 0x75)) return; /* jmp 0x100fa75d */
            ii(0x100f_a6e8, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a6eb, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a6f0, 5); calld(0x1008_abbc, -0x6_fb39);          /* call 0x1008abbc */
            ii(0x100f_a6f5, 5); calld(0x100f_91cb, -0x152f);            /* call 0x100f91cb */
            ii(0x100f_a6fa, 2); if(jmpd_func(0x100f_a75d, 0x61)) return; /* jmp 0x100fa75d */
        }
    }
}
