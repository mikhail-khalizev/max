using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1e09-52683eb2")]
        public void Method_100b_1e09()
        {
            ii(0x100b_1e09, 5); pushd(0x9c);                            /* push 0x9c */
            ii(0x100b_1e0e, 5); calld(Definitions.sys_check_available_stack_size, 0xb_3f3f); /* call 0x10165d52 */
            ii(0x100b_1e13, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_1e14, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_1e15, 1); pushd(edx);                             /* push edx */
            ii(0x100b_1e16, 1); pushd(esi);                             /* push esi */
            ii(0x100b_1e17, 1); pushd(edi);                             /* push edi */
            ii(0x100b_1e18, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_1e19, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1e1b, 6); sub(esp, 0x7c);                         /* sub esp, 0x7c */
            ii(0x100b_1e21, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_1e24, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1e26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1e29, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1e2c, 5); calld(0x1013_ad11, 0x8_8ee0);           /* call 0x1013ad11 */
            ii(0x100b_1e31, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1e33, 2); if(jzd(0x100b_1e3e, 0x9)) goto l_0x100b_1e3e; /* jz 0x100b1e3e */
            ii(0x100b_1e35, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_1e39, 5); jmpd(0x100b_2380, 0x542); goto l_0x100b_2380; /* jmp 0x100b2380 */
        l_0x100b_1e3e:
            ii(0x100b_1e3e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1e41, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1e44, 5); calld(0x1007_6574, -0x3_b8d5);          /* call 0x10076574 */
            ii(0x100b_1e49, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_1e4c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_1e4f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1e52, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1e55, 5); calld(0x1007_6574, -0x3_b8e6);          /* call 0x10076574 */
            ii(0x100b_1e5a, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_1e5d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_1e60, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_1e63, 5); calld(0x1007_6aac, -0x3_b3bc);          /* call 0x10076aac */
            ii(0x100b_1e68, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_1e6b, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_b380); /* call 0x10076af0 */
            ii(0x100b_1e70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1e72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1e75, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_1e78, 5); calld(0x100b_7cfc, 0x5e7f);             /* call 0x100b7cfc */
            ii(0x100b_1e7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1e80, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1e83, 5); calld(0x1007_6574, -0x3_b914);          /* call 0x10076574 */
            ii(0x100b_1e88, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1e8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1e8d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1e90, 5); calld(0x1007_6574, -0x3_b921);          /* call 0x10076574 */
            ii(0x100b_1e95, 5); calld(0x1007_623c, -0x3_bc5e);          /* call 0x1007623c */
            ii(0x100b_1e9a, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x100b_1e9e, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x100b_1ea2, 6); if(jged(0x100b_21b9, 0x311)) goto l_0x100b_21b9; /* jge 0x100b21b9 */
            ii(0x100b_1ea8, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_1ead, 5); calld(0x1007_6338, -0x3_bb7a);          /* call 0x10076338 */
            ii(0x100b_1eb2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1eb4, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_1eb7, 5); calld(0x1007_64b8, -0x3_ba04);          /* call 0x100764b8 */
            ii(0x100b_1ebc, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100b_1ec0, 5); calld(0x1008_a6d4, -0x2_77f1);          /* call 0x1008a6d4 */
            ii(0x100b_1ec5, 1); cwde();                                 /* cwde */
            ii(0x100b_1ec6, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100b_1ec9, 3); pushd(memd_a32[ss, ebp - 0x30]);        /* push dword [ebp-0x30] */
            ii(0x100b_1ecc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1ecf, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1ed2, 5); calld(0x1007_6574, -0x3_b963);          /* call 0x10076574 */
            ii(0x100b_1ed7, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_1edc, 2); if(jnzd(0x100b_1ee4, 0x6)) goto l_0x100b_1ee4; /* jnz 0x100b1ee4 */
            ii(0x100b_1ede, 4); mov(memb_a32[ss, ebp - 0x28], 0x2);     /* mov byte [ebp-0x28], 0x2 */
            ii(0x100b_1ee2, 2); jmpd(0x100b_1ee8, 0x4); goto l_0x100b_1ee8; /* jmp 0x100b1ee8 */
        l_0x100b_1ee4:
            ii(0x100b_1ee4, 4); mov(memb_a32[ss, ebp - 0x28], 0x3);     /* mov byte [ebp-0x28], 0x3 */
        l_0x100b_1ee8:
            ii(0x100b_1ee8, 3); mov(ecx, memd_a32[ss, ebp - 0x2b]);     /* mov ecx, [ebp-0x2b] */
            ii(0x100b_1eeb, 3); sar(ecx, 0x18);                         /* sar ecx, 0x18 */
            ii(0x100b_1eee, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100b_1ef3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1ef6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1ef9, 5); calld(0x1007_65d0, -0x3_b92e);          /* call 0x100765d0 */
            ii(0x100b_1efe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1f00, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_1f03, 5); calld(0x1011_fec1, 0x6_dfb9);           /* call 0x1011fec1 */
            ii(0x100b_1f08, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100b_1f0b, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100b_1f0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1f12, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_1f15, 5); calld(0x1007_6b90, -0x3_b38a);          /* call 0x10076b90 */
            ii(0x100b_1f1a, 1); cwde();                                 /* cwde */
            ii(0x100b_1f1b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1f1d, 6); if(jzd(0x100b_203c, 0x119)) goto l_0x100b_203c; /* jz 0x100b203c */
            ii(0x100b_1f23, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1f26, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_1f29, 5); calld(0x100b_7c44, 0x5d16);             /* call 0x100b7c44 */
            ii(0x100b_1f2e, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x100b_1f31, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1f33, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1f35, 5); calld(0x100b_7b28, 0x5bee);             /* call 0x100b7b28 */
            ii(0x100b_1f3a, 2); jmpd(0x100b_1f44, 0x8); goto l_0x100b_1f44; /* jmp 0x100b1f44 */
        l_0x100b_1f3c:
            ii(0x100b_1f3c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1f3f, 5); calld(0x1007_6bf8, -0x3_b34c);          /* call 0x10076bf8 */
        l_0x100b_1f44:
            ii(0x100b_1f44, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1f46, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1f49, 5); calld(0x1013_ad71, 0x8_8e23);           /* call 0x1013ad71 */
            ii(0x100b_1f4e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1f50, 6); if(jzd(0x100b_2032, 0xdc)) goto l_0x100b_2032; /* jz 0x100b2032 */
            ii(0x100b_1f56, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1f59, 5); calld(0x100b_7a14, 0x5ab6);             /* call 0x100b7a14 */
            ii(0x100b_1f5e, 5); calld(0x100b_7d68, 0x5e05);             /* call 0x100b7d68 */
            ii(0x100b_1f63, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1f65, 2); if(jzd(0x100b_1f7a, 0x13)) goto l_0x100b_1f7a; /* jz 0x100b1f7a */
            ii(0x100b_1f67, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1f6a, 5); calld(0x100b_7a14, 0x5aa5);             /* call 0x100b7a14 */
            ii(0x100b_1f6f, 5); calld(0x100b_7d68, 0x5df4);             /* call 0x100b7d68 */
            ii(0x100b_1f74, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_1f78, 2); if(jnzd(0x100b_1f7c, 0x2)) goto l_0x100b_1f7c; /* jnz 0x100b1f7c */
        l_0x100b_1f7a:
            ii(0x100b_1f7a, 2); jmpd(0x100b_1f8f, 0x13); goto l_0x100b_1f8f; /* jmp 0x100b1f8f */
        l_0x100b_1f7c:
            ii(0x100b_1f7c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1f7f, 5); calld(0x100b_7a14, 0x5a90);             /* call 0x100b7a14 */
            ii(0x100b_1f84, 5); calld(0x100b_7dd8, 0x5e4f);             /* call 0x100b7dd8 */
            ii(0x100b_1f89, 4); cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x100b_1f8d, 2); if(jnzd(0x100b_1fce, 0x3f)) goto l_0x100b_1fce; /* jnz 0x100b1fce */
        l_0x100b_1f8f:
            ii(0x100b_1f8f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1f92, 5); calld(0x100b_7a14, 0x5a7d);             /* call 0x100b7a14 */
            ii(0x100b_1f97, 5); calld(0x100b_7d68, 0x5dcc);             /* call 0x100b7d68 */
            ii(0x100b_1f9c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1f9e, 2); if(jzd(0x100b_1fb5, 0x15)) goto l_0x100b_1fb5; /* jz 0x100b1fb5 */
            ii(0x100b_1fa0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_1fa3, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1fa6, 5); calld(0x100b_7a14, 0x5a69);             /* call 0x100b7a14 */
            ii(0x100b_1fab, 5); calld(0x100b_7d68, 0x5db8);             /* call 0x100b7d68 */
            ii(0x100b_1fb0, 5); calld(0x1015_27b8, 0xa_0803);           /* call 0x101527b8 */
        l_0x100b_1fb5:
            ii(0x100b_1fb5, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1fb8, 5); calld(0x100b_7a7c, 0x5abf);             /* call 0x100b7a7c */
            ii(0x100b_1fbd, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_1fc0, 3); add(ebx, 0x19);                         /* add ebx, 0x19 */
            ii(0x100b_1fc3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1fc5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1fc7, 5); calld(0x100b_7be4, 0x5c18);             /* call 0x100b7be4 */
            ii(0x100b_1fcc, 2); jmpd(0x100b_202d, 0x5f); goto l_0x100b_202d; /* jmp 0x100b202d */
        l_0x100b_1fce:
            ii(0x100b_1fce, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_1fd1, 5); calld(0x100b_7a14, 0x5a3e);             /* call 0x100b7a14 */
            ii(0x100b_1fd6, 5); calld(0x100b_7d68, 0x5d8d);             /* call 0x100b7d68 */
            ii(0x100b_1fdb, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_1fde, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100b_1fe1, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100b_1fe4, 5); calld(0x1007_5e64, -0x3_c185);          /* call 0x10075e64 */
            ii(0x100b_1fe9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1feb, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_1fee, 5); calld(0x1007_0ca1, -0x4_1352);          /* call 0x10070ca1 */
            ii(0x100b_1ff3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_1ff6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1ff8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1ffb, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_1ffe, 5); calld(0x1013_ad11, 0x8_8d0e);           /* call 0x1013ad11 */
            ii(0x100b_2003, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2005, 2); if(jnzd(0x100b_2010, 0x9)) goto l_0x100b_2010; /* jnz 0x100b2010 */
            ii(0x100b_2007, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_200a, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_200e, 2); if(jged(0x100b_202d, 0x1d)) goto l_0x100b_202d; /* jge 0x100b202d */
        l_0x100b_2010:
            ii(0x100b_2010, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_2013, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_2016, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_2019, 5); calld(0x100b_7a48, 0x5a2a);             /* call 0x100b7a48 */
            ii(0x100b_201e, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_2021, 3); add(ebx, 0x23);                         /* add ebx, 0x23 */
            ii(0x100b_2024, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2026, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_2028, 5); calld(0x100b_7cfc, 0x5ccf);             /* call 0x100b7cfc */
        l_0x100b_202d:
            ii(0x100b_202d, 5); jmpd(0x100b_1f3c, -0xf6); goto l_0x100b_1f3c; /* jmp 0x100b1f3c */
        l_0x100b_2032:
            ii(0x100b_2032, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2034, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_2037, 5); calld(0x100b_7650, 0x5614);             /* call 0x100b7650 */
        l_0x100b_203c:
            ii(0x100b_203c, 2); jmpd(0x100b_2046, 0x8); goto l_0x100b_2046; /* jmp 0x100b2046 */
        l_0x100b_203e:
            ii(0x100b_203e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_2041, 5); calld(0x1007_6bf8, -0x3_b44e);          /* call 0x10076bf8 */
        l_0x100b_2046:
            ii(0x100b_2046, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2048, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_204b, 5); calld(0x1013_ad71, 0x8_8d21);           /* call 0x1013ad71 */
            ii(0x100b_2050, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2052, 6); if(jzd(0x100b_21a5, 0x14d)) goto l_0x100b_21a5; /* jz 0x100b21a5 */
            ii(0x100b_2058, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_205b, 5); calld(0x1007_63a0, -0x3_bcc0);          /* call 0x100763a0 */
            ii(0x100b_2060, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2062, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_2065, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2068, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_206b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_206e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_2070, 2); if(jnzd(0x100b_2080, 0xe)) goto l_0x100b_2080; /* jnz 0x100b2080 */
            ii(0x100b_2072, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_2075, 5); calld(0x1007_63a0, -0x3_bcda);          /* call 0x100763a0 */
            ii(0x100b_207a, 4); test(memb_a32[ds, eax + 0x13], 0x1);    /* test byte [eax+0x13], 0x1 */
            ii(0x100b_207e, 2); if(jnzd(0x100b_2082, 0x2)) goto l_0x100b_2082; /* jnz 0x100b2082 */
        l_0x100b_2080:
            ii(0x100b_2080, 2); jmpd(0x100b_2091, 0xf); goto l_0x100b_2091; /* jmp 0x100b2091 */
        l_0x100b_2082:
            ii(0x100b_2082, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_2085, 5); calld(0x1007_63a0, -0x3_bcea);          /* call 0x100763a0 */
            ii(0x100b_208a, 5); cmp(memw_a32[ds, eax + 0x8], 0x39);     /* cmp word [eax+0x8], 0x39 */
            ii(0x100b_208f, 2); if(jnzd(0x100b_2093, 0x2)) goto l_0x100b_2093; /* jnz 0x100b2093 */
        l_0x100b_2091:
            ii(0x100b_2091, 2); jmpd(0x100b_20a4, 0x11); goto l_0x100b_20a4; /* jmp 0x100b20a4 */
        l_0x100b_2093:
            ii(0x100b_2093, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_2096, 5); calld(0x1007_63a0, -0x3_bcfb);          /* call 0x100763a0 */
            ii(0x100b_209b, 5); calld(0x1015_26ac, 0xa_060c);           /* call 0x101526ac */
            ii(0x100b_20a0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_20a2, 2); if(jnzd(0x100b_20a6, 0x2)) goto l_0x100b_20a6; /* jnz 0x100b20a6 */
        l_0x100b_20a4:
            ii(0x100b_20a4, 2); jmpd(0x100b_20c6, 0x20); goto l_0x100b_20c6; /* jmp 0x100b20c6 */
        l_0x100b_20a6:
            ii(0x100b_20a6, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_20a9, 5); calld(0x1007_63a0, -0x3_bd0e);          /* call 0x100763a0 */
            ii(0x100b_20ae, 5); calld(0x1015_26ac, 0xa_05f9);           /* call 0x101526ac */
            ii(0x100b_20b3, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100b_20b6, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100b_20b9, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_20bc, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100b_20bf, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_20c2, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_20c4, 2); if(jzd(0x100b_20c8, 0x2)) goto l_0x100b_20c8; /* jz 0x100b20c8 */
        l_0x100b_20c6:
            ii(0x100b_20c6, 2); jmpd(0x100b_20d9, 0x11); goto l_0x100b_20d9; /* jmp 0x100b20d9 */
        l_0x100b_20c8:
            ii(0x100b_20c8, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_20cb, 5); calld(0x1007_63d4, -0x3_bcfc);          /* call 0x100763d4 */
            ii(0x100b_20d0, 5); calld(0x100a_2edb, -0xf1fa);            /* call 0x100a2edb */
            ii(0x100b_20d5, 2); test(al, al);                           /* test al, al */
            ii(0x100b_20d7, 2); if(jnzd(0x100b_20de, 0x5)) goto l_0x100b_20de; /* jnz 0x100b20de */
        l_0x100b_20d9:
            ii(0x100b_20d9, 5); jmpd(0x100b_21a0, 0xc2); goto l_0x100b_21a0; /* jmp 0x100b21a0 */
        l_0x100b_20de:
            ii(0x100b_20de, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_20e1, 5); calld(0x1007_63a0, -0x3_bd46);          /* call 0x100763a0 */
            ii(0x100b_20e6, 5); calld(0x1015_26ac, 0xa_05c1);           /* call 0x101526ac */
            ii(0x100b_20eb, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100b_20ee, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_20f1, 5); calld(0x1007_63a0, -0x3_bd56);          /* call 0x100763a0 */
            ii(0x100b_20f6, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_20f9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_20fe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2100, 2); if(jzd(0x100b_2114, 0x12)) goto l_0x100b_2114; /* jz 0x100b2114 */
            ii(0x100b_2102, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100b_2105, 5); calld(0x100b_7dd8, 0x5cce);             /* call 0x100b7dd8 */
            ii(0x100b_210a, 4); cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x100b_210e, 6); if(jzd(0x100b_21a0, 0x8c)) goto l_0x100b_21a0; /* jz 0x100b21a0 */
        l_0x100b_2114:
            ii(0x100b_2114, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100b_2117, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_211a, 5); calld(0x1007_5e64, -0x3_c2bb);          /* call 0x10075e64 */
            ii(0x100b_211f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2121, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_2124, 5); calld(0x1007_63d4, -0x3_bd55);          /* call 0x100763d4 */
            ii(0x100b_2129, 5); calld(0x1007_0ca1, -0x4_148d);          /* call 0x10070ca1 */
            ii(0x100b_212e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_2131, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2133, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2136, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2139, 5); calld(0x1013_ad11, 0x8_8bd3);           /* call 0x1013ad11 */
            ii(0x100b_213e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2140, 2); if(jnzd(0x100b_214b, 0x9)) goto l_0x100b_214b; /* jnz 0x100b214b */
            ii(0x100b_2142, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_2145, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_2149, 2); if(jged(0x100b_21a0, 0x55)) goto l_0x100b_21a0; /* jge 0x100b21a0 */
        l_0x100b_214b:
            ii(0x100b_214b, 3); lea(ebx, ebp - 0x40);                   /* lea ebx, [ebp-0x40] */
            ii(0x100b_214e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_2151, 5); calld(0x1007_63d4, -0x3_bd82);          /* call 0x100763d4 */
            ii(0x100b_2156, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2158, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_215b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_215e, 5); calld(0x1007_65d0, -0x3_bb93);          /* call 0x100765d0 */
            ii(0x100b_2163, 5); calld(0x100b_1bf2, -0x576);             /* call 0x100b1bf2 */
            ii(0x100b_2168, 2); test(al, al);                           /* test al, al */
            ii(0x100b_216a, 2); if(jzd(0x100b_21a0, 0x34)) goto l_0x100b_21a0; /* jz 0x100b21a0 */
            ii(0x100b_216c, 3); mov(edx, memd_a32[ss, ebp - 0x54]);     /* mov edx, [ebp-0x54] */
            ii(0x100b_216f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2172, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2175, 5); calld(0x100b_7cfc, 0x5b82);             /* call 0x100b7cfc */
            ii(0x100b_217a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_217d, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_2180, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_2183, 5); calld(0x1007_63a0, -0x3_bde8);          /* call 0x100763a0 */
            ii(0x100b_2188, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100b_218c, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x100b_2190, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_2193, 5); calld(0x1007_63a0, -0x3_bdf8);          /* call 0x100763a0 */
            ii(0x100b_2198, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100b_219c, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
        l_0x100b_21a0:
            ii(0x100b_21a0, 5); jmpd(0x100b_203e, -0x167); goto l_0x100b_203e; /* jmp 0x100b203e */
        l_0x100b_21a5:
            ii(0x100b_21a5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_21a7, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_21aa, 5); calld(Definitions.my_dtor_d1, -0x2_94b3); /* call 0x10088cfc */
            ii(0x100b_21af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_21b1, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_21b4, 5); calld(0x1007_5f6c, -0x3_c24d);          /* call 0x10075f6c */
        l_0x100b_21b9:
            ii(0x100b_21b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_21bc, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_21bf, 5); calld(0x1007_6574, -0x3_bc50);          /* call 0x10076574 */
            ii(0x100b_21c4, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100b_21c7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_21ca, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_21cc, 6); if(jled(0x100b_22cf, 0xfd)) goto l_0x100b_22cf; /* jle 0x100b22cf */
            ii(0x100b_21d2, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100b_21d6, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_21d9, 5); calld(0x100b_7cbc, 0x5ade);             /* call 0x100b7cbc */
            ii(0x100b_21de, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100b_21e1, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100b_21e5, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100b_21e9, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_21ec, 5); calld(0x100b_7b6c, 0x597b);             /* call 0x100b7b6c */
            ii(0x100b_21f1, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100b_21f4, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100b_21f8, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100b_21fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_21fe, 5); calld(0x100b_0f0d, -0x12f6);            /* call 0x100b0f0d */
            ii(0x100b_2203, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_2206, 5); calld(0x100b_7c44, 0x5a39);             /* call 0x100b7c44 */
            ii(0x100b_220b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_220d, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_2210, 5); calld(0x100b_7aac, 0x5897);             /* call 0x100b7aac */
            ii(0x100b_2215, 2); jmpd(0x100b_221f, 0x8); goto l_0x100b_221f; /* jmp 0x100b221f */
        l_0x100b_2217:
            ii(0x100b_2217, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_221a, 5); calld(0x1007_6bf8, -0x3_b627);          /* call 0x10076bf8 */
        l_0x100b_221f:
            ii(0x100b_221f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2221, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_2224, 5); calld(0x1013_ad71, 0x8_8b48);           /* call 0x1013ad71 */
            ii(0x100b_2229, 2); test(al, al);                           /* test al, al */
            ii(0x100b_222b, 6); if(jzd(0x100b_22bb, 0x8a)) goto l_0x100b_22bb; /* jz 0x100b22bb */
            ii(0x100b_2231, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_2234, 5); calld(0x100b_7a14, 0x57db);             /* call 0x100b7a14 */
            ii(0x100b_2239, 5); calld(0x100b_7d68, 0x5b2a);             /* call 0x100b7d68 */
            ii(0x100b_223e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2240, 2); if(jnzd(0x100b_2258, 0x16)) goto l_0x100b_2258; /* jnz 0x100b2258 */
            ii(0x100b_2242, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_2245, 5); calld(0x100b_7a7c, 0x5832);             /* call 0x100b7a7c */
            ii(0x100b_224a, 3); lea(ebx, ebp - 0x64);                   /* lea ebx, [ebp-0x64] */
            ii(0x100b_224d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_224f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_2251, 5); calld(0x100b_7be4, 0x598e);             /* call 0x100b7be4 */
            ii(0x100b_2256, 2); jmpd(0x100b_22b6, 0x5e); goto l_0x100b_22b6; /* jmp 0x100b22b6 */
        l_0x100b_2258:
            ii(0x100b_2258, 3); lea(edx, ebp - 0x74);                   /* lea edx, [ebp-0x74] */
            ii(0x100b_225b, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_225e, 5); calld(0x100b_7a14, 0x57b1);             /* call 0x100b7a14 */
            ii(0x100b_2263, 5); calld(0x100b_7da0, 0x5b38);             /* call 0x100b7da0 */
            ii(0x100b_2268, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_226a, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100b_226d, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x100b_2270, 5); calld(0x1007_5e64, -0x3_c411);          /* call 0x10075e64 */
            ii(0x100b_2275, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_2277, 5); calld(0x1007_0c51, -0x4_162b);          /* call 0x10070c51 */
            ii(0x100b_227c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_227f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2281, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2284, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2287, 5); calld(0x1013_ad11, 0x8_8a85);           /* call 0x1013ad11 */
            ii(0x100b_228c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_228e, 2); if(jnzd(0x100b_2299, 0x9)) goto l_0x100b_2299; /* jnz 0x100b2299 */
            ii(0x100b_2290, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_2293, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_2297, 2); if(jged(0x100b_22b6, 0x1d)) goto l_0x100b_22b6; /* jge 0x100b22b6 */
        l_0x100b_2299:
            ii(0x100b_2299, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_229c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_229f, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_22a2, 5); calld(0x100b_7a48, 0x57a1);             /* call 0x100b7a48 */
            ii(0x100b_22a7, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_22aa, 3); add(ebx, 0x23);                         /* add ebx, 0x23 */
            ii(0x100b_22ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_22af, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_22b1, 5); calld(0x100b_7cfc, 0x5a46);             /* call 0x100b7cfc */
        l_0x100b_22b6:
            ii(0x100b_22b6, 5); jmpd(0x100b_2217, -0xa4); goto l_0x100b_2217; /* jmp 0x100b2217 */
        l_0x100b_22bb:
            ii(0x100b_22bb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_22bd, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x100b_22c0, 5); calld(0x100b_7650, 0x538b);             /* call 0x100b7650 */
            ii(0x100b_22c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_22c7, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_22ca, 5); calld(0x100b_7610, 0x5341);             /* call 0x100b7610 */
        l_0x100b_22cf:
            ii(0x100b_22cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_22d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_22d4, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_22d7, 5); calld(0x1013_ad71, 0x8_8a95);           /* call 0x1013ad71 */
            ii(0x100b_22dc, 2); test(al, al);                           /* test al, al */
            ii(0x100b_22de, 2); if(jzd(0x100b_22e9, 0x9)) goto l_0x100b_22e9; /* jz 0x100b22e9 */
            ii(0x100b_22e0, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_22e4, 5); jmpd(0x100b_2380, 0x97); goto l_0x100b_2380; /* jmp 0x100b2380 */
        l_0x100b_22e9:
            ii(0x100b_22e9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_22ec, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_22ef, 5); calld(0x1008_b060, -0x2_7294);          /* call 0x1008b060 */
            ii(0x100b_22f4, 5); calld(0x1008_a79c, -0x2_7b5d);          /* call 0x1008a79c */
            ii(0x100b_22f9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_22fb, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_22fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2300, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2303, 5); calld(0x1007_65d0, -0x3_bd38);          /* call 0x100765d0 */
            ii(0x100b_2308, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_230a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_230f, 5); calld(0x100a_53ac, -0xcf68);            /* call 0x100a53ac */
            ii(0x100b_2314, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2316, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2319, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_231c, 5); calld(0x1007_6630, -0x3_bcf1);          /* call 0x10076630 */
            ii(0x100b_2321, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2323, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2326, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_2329, 5); calld(0x1013_ad71, 0x8_8a43);           /* call 0x1013ad71 */
            ii(0x100b_232e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2330, 2); if(jzd(0x100b_2359, 0x27)) goto l_0x100b_2359; /* jz 0x100b2359 */
            ii(0x100b_2332, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2335, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_2338, 5); calld(0x1008_a7dc, -0x2_7b61);          /* call 0x1008a7dc */
            ii(0x100b_233d, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100b_2340, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100b_2343, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_2346, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100b_2349, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
            ii(0x100b_234c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_234e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2351, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_2354, 5); calld(0x1008_a898, -0x2_7ac1);          /* call 0x1008a898 */
        l_0x100b_2359:
            ii(0x100b_2359, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_235c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_2361, 5); calld(0x100a_5e27, -0xc53f);            /* call 0x100a5e27 */
            ii(0x100b_2366, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_236a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_236c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_236f, 5); calld(0x1008_8b7c, -0x2_97f8);          /* call 0x10088b7c */
            ii(0x100b_2374, 2); jmpd(0x100b_2380, 0xa); goto l_0x100b_2380; /* jmp 0x100b2380 */
        //  ii(0x100b_2376, 10); Недостижимый код.
        l_0x100b_2380:
            ii(0x100b_2380, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_2383, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_2385, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_2386, 1); popd(edi);                              /* pop edi */
            ii(0x100b_2387, 1); popd(esi);                              /* pop esi */
            ii(0x100b_2388, 1); popd(edx);                              /* pop edx */
            ii(0x100b_2389, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_238a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_238b, 1); retd(); return;                         /* ret */
        }
    }
}
