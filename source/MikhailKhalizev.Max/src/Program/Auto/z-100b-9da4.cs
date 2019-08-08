using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("489a2bea-8163-432c-9b8a-e37e8253d4b0")]
        public void Method_100b_9da4()
        {
            ii(0x100b_9da4, 5); pushd(0x9c);                            /* push 0x9c */
            ii(0x100b_9da9, 5); calld(Definitions.sys_check_available_stack_size, 0xa_bfa4); /* call 0x10165d52 */
            ii(0x100b_9dae, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_9daf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_9db0, 1); pushd(esi);                             /* push esi */
            ii(0x100b_9db1, 1); pushd(edi);                             /* push edi */
            ii(0x100b_9db2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_9db3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_9db5, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x100b_9dbb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9dbe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_9dc1, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100b_9dc5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_9dc8, 5); calld(Definitions.my_ctor_0x101b3b58, -0x2_ed29); /* call 0x1008b0a4 */
            ii(0x100b_9dcd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_9dd0, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100b_9dd4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9dd7, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x100b_9dda, 5); calld(0x1007_6b90, -0x4_324f);          /* call 0x10076b90 */
            ii(0x100b_9ddf, 1); cwde();                                 /* cwde */
            ii(0x100b_9de0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_9de2, 6); if(jnzd(0x100b_9f3a, 0x152)) goto l_0x100b_9f3a; /* jnz 0x100b9f3a */
            ii(0x100b_9de8, 5); mov(eax, 0x37);                         /* mov eax, 0x37 */
            ii(0x100b_9ded, 5); calld(Definitions.sys_new, 0xa_c00e);   /* call 0x10165e00 */
            ii(0x100b_9df2, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_9df5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_9df8, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_9dfb, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100b_9dff, 2); if(jzd(0x100b_9e27, 0x26)) goto l_0x100b_9e27; /* jz 0x100b9e27 */
            ii(0x100b_9e01, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_9e04, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_9e07, 5); calld(0x1007_5e64, -0x4_3fa8);          /* call 0x10075e64 */
            ii(0x100b_9e0c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_9e0e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9e11, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_9e14, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_9e17, 5); calld(0x1009_2f1e, -0x2_6efe);          /* call 0x10092f1e */
            ii(0x100b_9e1c, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_9e1f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_9e22, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100b_9e25, 2); jmpd(0x100b_9e2d, 0x6); goto l_0x100b_9e2d; /* jmp 0x100b9e2d */
        l_0x100b_9e27:
            ii(0x100b_9e27, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_9e2a, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100b_9e2d:
            ii(0x100b_9e2d, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100b_9e30, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_9e33, 5); calld(0x1008_afe4, -0x2_ee54);          /* call 0x1008afe4 */
            ii(0x100b_9e38, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_9e3b, 5); calld(0x1008_afb4, -0x2_ee8c);          /* call 0x1008afb4 */
            ii(0x100b_9e40, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9e42, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9e45, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x100b_9e48, 5); calld(0x1009_ca40, -0x1_d40d);          /* call 0x1009ca40 */
            ii(0x100b_9e4d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_9e50, 5); calld(0x1008_afb4, -0x2_eea1);          /* call 0x1008afb4 */
            ii(0x100b_9e55, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9e57, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_9e5c, 5); calld(0x100a_4d50, -0x1_5111);          /* call 0x100a4d50 */
            ii(0x100b_9e61, 5); mov(eax, 0xd1);                         /* mov eax, 0xd1 */
            ii(0x100b_9e66, 5); calld(Definitions.sys_new, 0xa_bf95);   /* call 0x10165e00 */
            ii(0x100b_9e6b, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100b_9e6e, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100b_9e71, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100b_9e74, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100b_9e78, 2); if(jzd(0x100b_9ea0, 0x26)) goto l_0x100b_9ea0; /* jz 0x100b9ea0 */
            ii(0x100b_9e7a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_9e7d, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_9e80, 5); calld(0x1007_5e64, -0x4_4021);          /* call 0x10075e64 */
            ii(0x100b_9e85, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_9e87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9e8a, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_9e8d, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100b_9e90, 5); calld(0x1007_dd5a, -0x3_c13b);          /* call 0x1007dd5a */
            ii(0x100b_9e95, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100b_9e98, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100b_9e9b, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100b_9e9e, 2); jmpd(0x100b_9ea6, 0x6); goto l_0x100b_9ea6; /* jmp 0x100b9ea6 */
        l_0x100b_9ea0:
            ii(0x100b_9ea0, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100b_9ea3, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100b_9ea6:
            ii(0x100b_9ea6, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x100b_9ea9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9eac, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x100b_9eaf, 5); calld(0x1008_afe4, -0x2_eed0);          /* call 0x1008afe4 */
            ii(0x100b_9eb4, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100b_9eb9, 5); calld(Definitions.sys_new, 0xa_bf42);   /* call 0x10165e00 */
            ii(0x100b_9ebe, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100b_9ec1, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100b_9ec4, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100b_9ec7, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100b_9ecb, 2); if(jzd(0x100b_9ef3, 0x26)) goto l_0x100b_9ef3; /* jz 0x100b9ef3 */
            ii(0x100b_9ecd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_9ed0, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100b_9ed3, 5); calld(0x1007_5e64, -0x4_4074);          /* call 0x10075e64 */
            ii(0x100b_9ed8, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_9eda, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9edd, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_9ee0, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100b_9ee3, 5); calld(0x1007_963b, -0x4_08ad);          /* call 0x1007963b */
            ii(0x100b_9ee8, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100b_9eeb, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100b_9eee, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100b_9ef1, 2); jmpd(0x100b_9ef9, 0x6); goto l_0x100b_9ef9; /* jmp 0x100b9ef9 */
        l_0x100b_9ef3:
            ii(0x100b_9ef3, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100b_9ef6, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
        l_0x100b_9ef9:
            ii(0x100b_9ef9, 3); mov(edx, memd_a32[ss, ebp - 0x54]);     /* mov edx, [ebp-0x54] */
            ii(0x100b_9efc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9eff, 3); add(eax, 0x33);                         /* add eax, 0x33 */
            ii(0x100b_9f02, 5); calld(0x100c_acb8, 0x1_0db1);           /* call 0x100cacb8 */
            ii(0x100b_9f07, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9f0a, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x100b_9f0d, 5); calld(0x1008_afb4, -0x2_ef5e);          /* call 0x1008afb4 */
            ii(0x100b_9f12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9f14, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_9f19, 5); calld(0x100a_4d50, -0x1_51ce);          /* call 0x100a4d50 */
            ii(0x100b_9f1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9f21, 3); add(eax, 0x33);                         /* add eax, 0x33 */
            ii(0x100b_9f24, 5); calld(0x100c_ac88, 0x1_0d5f);           /* call 0x100cac88 */
            ii(0x100b_9f29, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9f2b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_9f30, 5); calld(0x100a_4d50, -0x1_51e5);          /* call 0x100a4d50 */
            ii(0x100b_9f35, 5); jmpd(0x100b_a06c, 0x132); goto l_0x100b_a06c; /* jmp 0x100ba06c */
        l_0x100b_9f3a:
            ii(0x100b_9f3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9f3d, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x100b_9f40, 5); calld(0x1008_aef4, -0x2_f051);          /* call 0x1008aef4 */
            ii(0x100b_9f45, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9f47, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_9f4a, 5); calld(0x1008_ae70, -0x2_f0df);          /* call 0x1008ae70 */
            ii(0x100b_9f4f, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100b_9f52, 5); calld(Definitions.my_ctor_0x101b4184, -0x4_3467); /* call 0x10076af0 */
            ii(0x100b_9f57, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_9f5a, 5); calld(0x1008_adf8, -0x2_f167);          /* call 0x1008adf8 */
            ii(0x100b_9f5f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9f61, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_9f64, 5); calld(0x1008_afe4, -0x2_ef85);          /* call 0x1008afe4 */
            ii(0x100b_9f69, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_9f6c, 5); calld(0x1008_af28, -0x2_f049);          /* call 0x1008af28 */
            ii(0x100b_9f71, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100b_9f74, 3); mov(ebx, memd_a32[ss, ebp - 0x60]);     /* mov ebx, [ebp-0x60] */
            ii(0x100b_9f77, 3); mov(ebx, memd_a32[ds, ebx + 0x2]);      /* mov ebx, [ebx+0x2] */
            ii(0x100b_9f7a, 3); lea(edx, ebp - 0x70);                   /* lea edx, [ebp-0x70] */
            ii(0x100b_9f7d, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100b_9f80, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x100b_9f83, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_9f86, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100b_9f89, 5); calld(0x1008_8b44, -0x3_144a);          /* call 0x10088b44 */
            ii(0x100b_9f8e, 4); movsx(ebx, memw_a32[ss, ebp - 0x6c]);   /* movsx ebx, word [ebp-0x6c] */
            ii(0x100b_9f92, 4); movsx(edx, memw_a32[ss, ebp - 0x70]);   /* movsx edx, word [ebp-0x70] */
            ii(0x100b_9f96, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x100b_9f99, 5); calld(0x1007_6aac, -0x4_34f2);          /* call 0x10076aac */
            ii(0x100b_9f9e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9fa0, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100b_9fa3, 5); calld(0x1007_6a6c, -0x4_353c);          /* call 0x10076a6c */
            ii(0x100b_9fa8, 3); mov(edx, memd_a32[ss, ebp - 0x5a]);     /* mov edx, [ebp-0x5a] */
            ii(0x100b_9fab, 4); imul(edx, memd_a32[ss, ebp - 0x5a]);    /* imul edx, [ebp-0x5a] */
            ii(0x100b_9faf, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100b_9fb2, 4); imul(eax, memd_a32[ss, ebp - 0x5c]);    /* imul eax, [ebp-0x5c] */
            ii(0x100b_9fb6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_9fb8, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100b_9fbb, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_9fbe, 5); calld(0x1007_6bf8, -0x4_33cb);          /* call 0x10076bf8 */
            ii(0x100b_9fc3, 2); jmpd(0x100b_9fcd, 0x8); goto l_0x100b_9fcd; /* jmp 0x100b9fcd */
        l_0x100b_9fc5:
            ii(0x100b_9fc5, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_9fc8, 5); calld(0x1007_6bf8, -0x4_33d5);          /* call 0x10076bf8 */
        l_0x100b_9fcd:
            ii(0x100b_9fcd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9fcf, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_9fd2, 5); calld(0x1013_ad71, 0x8_0d9a);           /* call 0x1013ad71 */
            ii(0x100b_9fd7, 2); test(al, al);                           /* test al, al */
            ii(0x100b_9fd9, 6); if(jzd(0x100b_a062, 0x83)) goto l_0x100b_a062; /* jz 0x100ba062 */
            ii(0x100b_9fdf, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_9fe2, 5); calld(0x1008_adc4, -0x2_f223);          /* call 0x1008adc4 */
            ii(0x100b_9fe7, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100b_9fea, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100b_9fed, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100b_9ff0, 3); lea(edx, ebp - 0x70);                   /* lea edx, [ebp-0x70] */
            ii(0x100b_9ff3, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100b_9ff6, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x100b_9ff9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_9ffc, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100b_9fff, 5); calld(0x1008_8b44, -0x3_14c0);          /* call 0x10088b44 */
            ii(0x100b_a004, 4); movsx(ebx, memw_a32[ss, ebp - 0x6c]);   /* movsx ebx, word [ebp-0x6c] */
            ii(0x100b_a008, 4); movsx(edx, memw_a32[ss, ebp - 0x70]);   /* movsx edx, word [ebp-0x70] */
            ii(0x100b_a00c, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x100b_a00f, 5); calld(0x1007_6aac, -0x4_3568);          /* call 0x10076aac */
            ii(0x100b_a014, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a016, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100b_a019, 5); calld(0x1007_6a6c, -0x4_35b2);          /* call 0x10076a6c */
            ii(0x100b_a01e, 3); mov(eax, memd_a32[ss, ebp - 0x5a]);     /* mov eax, [ebp-0x5a] */
            ii(0x100b_a021, 4); imul(eax, memd_a32[ss, ebp - 0x5a]);    /* imul eax, [ebp-0x5a] */
            ii(0x100b_a025, 3); mov(edx, memd_a32[ss, ebp - 0x5c]);     /* mov edx, [ebp-0x5c] */
            ii(0x100b_a028, 4); imul(edx, memd_a32[ss, ebp - 0x5c]);    /* imul edx, [ebp-0x5c] */
            ii(0x100b_a02c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_a02e, 6); mov(memd_a32[ss, ebp - 0x84], edx);     /* mov [ebp-0x84], edx */
            ii(0x100b_a034, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100b_a03a, 4); cmp(ax, memw_a32[ss, ebp - 0x78]);      /* cmp ax, [ebp-0x78] */
            ii(0x100b_a03e, 2); if(jged(0x100b_a05d, 0x1d)) goto l_0x100b_a05d; /* jge 0x100ba05d */
            ii(0x100b_a040, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_a043, 5); calld(0x1008_adf8, -0x2_f250);          /* call 0x1008adf8 */
            ii(0x100b_a048, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100b_a04b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a04d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_a04f, 5); calld(0x1008_afe4, -0x2_f070);          /* call 0x1008afe4 */
            ii(0x100b_a054, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100b_a05a, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
        l_0x100b_a05d:
            ii(0x100b_a05d, 5); jmpd(0x100b_9fc5, -0x9d); goto l_0x100b_9fc5; /* jmp 0x100b9fc5 */
        l_0x100b_a062:
            ii(0x100b_a062, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a064, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_a067, 5); calld(0x1008_8bbc, -0x3_14b0);          /* call 0x10088bbc */
        l_0x100b_a06c:
            ii(0x100b_a06c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_a06f, 5); calld(0x1008_afb4, -0x2_f0c0);          /* call 0x1008afb4 */
            ii(0x100b_a074, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_a077, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a079, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_a07c, 5); calld(0x1008_8b7c, -0x3_1505);          /* call 0x10088b7c */
            ii(0x100b_a081, 2); jmpd(0x100b_a08d, 0xa); goto l_0x100b_a08d; /* jmp 0x100ba08d */
        //    ii(0x100b_a083, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100b_a085, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x100b_a088, 5); calld(0x1008_8b7c, -0x3_1511);          /* call 0x10088b7c */
        l_0x100b_a08d:
            ii(0x100b_a08d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_a090, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a092, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_a093, 1); popd(edi);                              /* pop edi */
            ii(0x100b_a094, 1); popd(esi);                              /* pop esi */
            ii(0x100b_a095, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_a096, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_a097, 1); retd(); return;                         /* ret */
        }
    }
}
